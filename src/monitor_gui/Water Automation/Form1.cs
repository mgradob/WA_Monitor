using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Water_Automation.Models;
using System.Globalization;
using Water_Automation.Graph_Models;
using System.Net.Mail;

namespace Water_Automation
{
    public partial class mainForm : Form
    {
        // Global Variables ------------
        Stream fileStream;
        String line;
        String[] data;
        int file_lenght;
        String file_path, file_name;

        int timeout_count = 0;
        int iData_count = 0;

        LogByDate logByDate;
        BindingList<LogByDate> logsList = new BindingList<LogByDate>();
        BindingList<TimeoutLog> timeoutsList = new BindingList<TimeoutLog>();
        BindingList<InvalidDataLog> invalidDataList = new BindingList<InvalidDataLog>();
        // -----------------------------


        public mainForm()
        {
            InitializeComponent();            
        }


        private void fileChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (!File.Exists(file_name)) return;
                string new_line = File.ReadAllLines(file_name).Last();

                logByDate = new LogByDate(new_line);

                if (existsInList(logByDate))
                    Console.WriteLine("Already exists in list");
                else
                {
                    if (logByDate.moisture_1 == -1)
                    {
                        invalidDataList.Add(new InvalidDataLog(logByDate.dateTime));
                        tbx_invalid_data.Text += "\n" + logByDate.dateTime.ToString();
                        iData_count++;
                    }
                    else if (logByDate.moisture_1 == -2)
                    {
                        timeoutsList.Add(new TimeoutLog(logByDate.dateTime));
                        tbx_timeout.Text += "\n" + logByDate.dateTime.ToString();
                        timeout_count++;
                    }

                    logsList.Add(logByDate);

                    data_grid.Refresh();
                }

                if (iData_count >= 10)
                {
                    sendEmailMessage(-1);
                    iData_count = 0;
                }
                if (timeout_count >= 10)
                {
                    sendEmailMessage(-2);
                    timeout_count = 0;
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Last line not added");
            }
        }


        private void btn_open_file_Click(object sender, EventArgs e)
        {
            DialogResult clicked_ok = openFileDialog.ShowDialog();

            if(clicked_ok == DialogResult.OK)
            {
                try
                {
                    if((fileStream = openFileDialog.OpenFile()) != null)
                    {
                        file_name = openFileDialog.FileName;
                        file_path = Path.GetDirectoryName(file_name);

                        using(StreamReader sr = new StreamReader(fileStream))
                        {
                            while((line = sr.ReadLine()) != null)
                            {
                                logByDate = new LogByDate(line);

                                if (logByDate.moisture_1 == -1)
                                {
                                    invalidDataList.Add(new InvalidDataLog(logByDate.dateTime));
                                    tbx_invalid_data.Text += "\n" + logByDate.dateTime.ToString();
                                }
                                else if (logByDate.moisture_1 == -2)
                                {
                                    timeoutsList.Add(new TimeoutLog(logByDate.dateTime));
                                    tbx_timeout.Text += "\n" + logByDate.dateTime.ToString();
                                }

                                logsList.Add(logByDate);
                            }
                        }
                    }
                }
                catch (IOException ioex)
                {
                    Console.WriteLine("Couldn't open log file");
                }

                data_grid.DataSource = logsList;
                data_grid.Refresh();

                fileWatcher.Path = file_path;
                fileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;
                fileWatcher.Filter = "*.*";
                fileWatcher.Changed += new FileSystemEventHandler(fileChanged);
                fileWatcher.EnableRaisingEvents = true;
            }
        }


        bool existsInList(LogByDate log_to_check)
        {
            int repeated = 0;

            foreach(LogByDate log in logsList)
            {
                if (log.dateTime.Equals(log_to_check.dateTime))
                    repeated++;
            }

            if(repeated == 0)
                return false;
            else
                return true;
        }


        void sendEmailMessage(int error_code)
        {
            string error_type;

            switch (error_code)
            {
                case -1:    
                    error_type = "Timeout";
                    break;
                case -2:
                    error_type = "Invalid Data";
                    break;
                default:
                    error_type = "";
                    break;
            }

            // TODO: Add email alerts

        }
    }
}
