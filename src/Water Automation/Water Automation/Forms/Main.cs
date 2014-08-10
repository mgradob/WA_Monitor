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
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;
using Xively;
using System.Threading;

namespace Water_Automation
{
    public partial class mainForm : Form
    {
        // -----------------------------
        // Global Variables
        // -----------------------------
        Stream fileStream;
        String line;
        String[] data;
        String file_path, file_name = "dataLog.txt";
        int file_lenght;
        
        int timeout_count = 0;
        int iData_count = 0;

        LogByDate logByDate;
        BindingList<LogByDate> logsList = new BindingList<LogByDate>();
        BindingList<TimeoutLog> timeoutsList = new BindingList<TimeoutLog>();
        BindingList<InvalidDataLog> invalidDataList = new BindingList<InvalidDataLog>();

        BindingList<LogByDate> chartList = new BindingList<LogByDate>();
        Boolean isGraphedS1 = false, isGraphedS2 = false, isGraphedS3 = false, isGraphedS4 = false, isGraphedS5 = false, isGraphedS6 = false, isGraphedEto = false, isGraphedPoints = false;

        List<String> avPorts = new List<string>();
        SerialPort comPort;
        Byte[] dataIn = new Byte[55];
        System.Timers.Timer timer = new System.Timers.Timer(180*1000);

        public static string apiKey = "a9KrKo29wXCznae6xgGhVX7sGS1Q8E809vFAKWPoFU5g4RQy";
        public static string userAgent = "Water Automation";
        public static int feedId = 1129833362;
        XivelyClient client;
        Boolean can_upload = false;

        // -----------------------------
        // Main
        // -----------------------------
        public mainForm()
        {
            InitializeComponent();

            btnComClose.Enabled = false;

            timer.SynchronizingObject = this;
            timer.Elapsed += new ElapsedEventHandler(timerHandler);

            chartEto.Series["Evapotranspiration"].ChartType = SeriesChartType.Line;

            chartEto.ChartAreas["etoChartArea"].AxisX.Minimum = chartList.Count;
            chartEto.ChartAreas["etoChartArea"].AxisX.MajorGrid.Enabled = false;
            chartEto.ChartAreas["etoChartArea"].AxisY.MajorGrid.Enabled = false;

            chartEto.Series["Sensor1"].Enabled = false;
            chartEto.Series["Sensor2"].Enabled = false;
            chartEto.Series["Sensor3"].Enabled = false;
            chartEto.Series["Sensor4"].Enabled = false;
            chartEto.Series["Sensor5"].Enabled = false;
            chartEto.Series["Sensor6"].Enabled = false;
            chartEto.Series["Evapotranspiration"].Enabled = false;

            try
            {
                 client = new XivelyClient(apiKey, userAgent);
                 can_upload = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet connection, cannot upload any data");
                can_upload = false;
            }
        }

        // -----------------------------
        // Method: getComPorts()
        //  Find available COM ports.
        //  Arguments: void.
        //  Returns: void.
        // -----------------------------
        void getComPorts()
        {
            avPorts.AddRange(SerialPort.GetPortNames());
            foreach (string port in avPorts)
            {
                cbxSerialPort.Items.Add(port);
            }
        }

        // -----------------------------
        // Method: cbxSerialPort_DropDown()
        //  Ocurrs when combobox dropdown menu is displayed.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSerialPort_DropDown(object sender, EventArgs e)
        {
            cbxSerialPort.Items.Clear();
            avPorts.Clear();
            getComPorts();
        }

        // -----------------------------
        // Method: btnComConnect_Click()
        //  Connect to a COM.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void btnComConnect_Click(object sender, EventArgs e)
        {
            if (!(cbxSerialPort.SelectedIndex < 0))
            {
                comPort = new SerialPort(cbxSerialPort.SelectedItem.ToString());
                comPort.BaudRate = 9600;
                comPort.DataReceived += new SerialDataReceivedEventHandler(comDataHandler);

                if (comPort.IsOpen)
                {
                    comPort.Close();
                }

                try
                {
                    comPort.Open();

                    timer.Start();

                    lblStatus.Text = "System ready, waiting for data.";

                    data_grid.DataSource = logsList;
                    data_grid.Columns["dateTime"].DisplayIndex = 0;
                    data_grid.Columns["consolidate"].DisplayIndex = 1;
                    data_grid.Columns["radiation"].Visible = false;
                    data_grid.Columns["atmospheric_humidity"].Visible = false;
                    data_grid.Columns["atmospheric_temperature"].Visible = false;
                    data_grid.Columns["wind_speed"].Visible = false;
                    //data_grid.Columns["moisture_1"].Visible = false;
                    //data_grid.Columns["moisture_2"].Visible = false;
                    //data_grid.Columns["moisture_3"].Visible = false;
                    //data_grid.Columns["moisture_4"].Visible = false;
                    //data_grid.Columns["moisture_5"].Visible = false;
                    //data_grid.Columns["moisture_6"].Visible = false;
                    data_grid.Columns["timeout_DAAD"].Visible = false;
                    data_grid.Columns["timeout_DA55"].Visible = false;
                    data_grid.Columns["timeout_c"].Visible = false;
                    data_grid.Columns["timeout_climate_node"].Visible = false;
                    data_grid.Columns["timeout_pump_node"].Visible = false;
                    data_grid.Refresh();
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("COM Port unavailable");
                }

                btnComConnect.Enabled = false;
                btnComClose.Enabled = true;
                cbxSerialPort.Enabled = false;
            }
            else
                MessageBox.Show("No COM selected");
        }

        // -----------------------------
        // Method: btnComClose_Clickk()
        //  Close a serial COM.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void btnComClose_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Close();
            }

            btnComClose.Enabled = false;
            btnComConnect.Enabled = true;
            cbxSerialPort.Enabled = true;

            lblStatus.Text = "System stopped.";
        }

        // -----------------------------
        // Method: comDataHandler()
        //  Handler method for the data received form the serial port.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        void comDataHandler(object sender, SerialDataReceivedEventArgs e)
        {
            timer.Stop();
            
            while (comPort.BytesToRead < 55) { ; }
            comPort.Read(dataIn, 0, 55);

            if ((dataIn[15] == 0x01) && (dataIn[53] == 0x04))
            {
                writeToList('L');
            }
            else
            {
                writeToList('I');
            }

            comPort.DiscardInBuffer();
            timer.Start();
        }

        // -----------------------------
        // Method: timerHandler()
        //  Handler method for the timer, in case of a timeout ocurrs.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        void timerHandler(object sender, ElapsedEventArgs e)
        {
            writeToList('T');
        }

        // -----------------------------
        // Method: existsInList()
        //  Checks if a given LogByDate already exists in the list, returns true if it exists, otherwise returns false.
        //  Arguments: LogByDate.
        //  Returns: Boolean.
        // -----------------------------
        bool existsInList(LogByDate log_to_check)
        {
            int repeated = 0;

            foreach (LogByDate log in logsList)
            {
                if (log.dateTime.Equals(log_to_check.dateTime))
                    repeated++;
            }

            if (repeated == 0)
                return false;
            else
                return true;
        }

        // -----------------------------
        // Method: writeToList()
        //  Writes the log to the corresponding list. L = logList, I = invalidDataList, T = timeoutList
        //  Arguments: char.
        //  Returns: void.
        // -----------------------------
        void writeToList(char listSelector) 
        {
            switch (listSelector)
            {
                case 'L':   logByDate = new LogByDate(dataIn);
                            if (!existsInList(logByDate))
                            {
                                this.Invoke(new MethodInvoker(delegate()
                                {
                                    logsList.Add(logByDate);
                                    data_grid.Refresh();

                                    lblHumidity.Text = "" + logByDate.consolidate + " %";
                                    lblTemp.Text = "" + logByDate.atmospheric_temperature + " °C";
                                    lblEto.Text = "" + logByDate.evapotranspiration + " mm";
                                    lblWndSpd.Text = "" + logByDate.wind_speed + " m/s";

                                    if (logByDate.timeout_DAAD == 1) tbx_timeout.AppendText("Sensor Node 1 at " + logByDate.dateTime + "\n");
                                    if (logByDate.timeout_DA55 == 1) tbx_timeout.AppendText("Sensor Node 2 at " + logByDate.dateTime + "\n");
                                    if (logByDate.timeout_c == 1) tbx_timeout.AppendText("Sensor Node C at " + logByDate.dateTime + "\n");
                                    if (logByDate.timeout_climate_node == 1) tbx_timeout.AppendText("Climate Node at " + logByDate.dateTime + "\n");
                                    if (logByDate.timeout_pump_node == 1) tbx_timeout.AppendText("Pump Node at " + logByDate.dateTime + "\n");

                                    writeToFile(logByDate.dataToString());

                                    writeToXively(logByDate);
                                }));
                            }
                            break;

                case 'I':   for (int i = 0; i < dataIn.Length; i++) dataIn[i] = 0;
                            logByDate = new LogByDate(dataIn);

                            if (!existsInList(logByDate))
                            {
                                this.Invoke(new MethodInvoker(delegate()
                                {
                                    logsList.Add(logByDate);
                                    InvalidDataLog idl = new InvalidDataLog();
                                    invalidDataList.Add(idl);
                                    tbx_invalid_data.AppendText(idl.iData_date + '\n');
                                    data_grid.Refresh();

                                    lblHumidity.Text = "invalid data";
                                    lblTemp.Text = "invalid data";
                                    lblEto.Text = "invalid data";
                                    lblWndSpd.Text = "invalid data";

                                    writeToFile("Invalid data, " + idl.iData_date);
                                }));
                            }
                            break;

                case 'T':   for (int i = 0; i < dataIn.Length; i++) dataIn[i] = 0;
                            logByDate = new LogByDate(dataIn);

                            if (!existsInList(logByDate))
                            {
                                this.Invoke(new MethodInvoker(delegate()
                                {
                                    logsList.Add(logByDate);
                                    TimeoutLog tl = new TimeoutLog();
                                    timeoutsList.Add(tl);
                                    tbx_timeout.AppendText(tl.tData_date + '\n');
                                    data_grid.Refresh();

                                    lblHumidity.Text = "timeout";
                                    lblTemp.Text = "timeout";
                                    lblEto.Text = "timeout";
                                    lblWndSpd.Text = "timeout";

                                    writeToFile("Timeout, " + tl.tData_date);
                                }));
                            }
                            break;

                default: break;
            }

            // Fill graph log            
            this.Invoke(new MethodInvoker(delegate()
            {
                chartList.Add(logByDate);
                chartEto.Series["Evapotranspiration"].Points.AddXY(logByDate.dateTime, logByDate.evapotranspiration);
                chartEto.Series["Sensor1"].Points.AddXY(logByDate.dateTime, logByDate.moisture_1);
                chartEto.Series["Sensor2"].Points.AddXY(logByDate.dateTime, logByDate.moisture_2);
                chartEto.Series["Sensor3"].Points.AddXY(logByDate.dateTime, logByDate.moisture_3);
                chartEto.Series["Sensor4"].Points.AddXY(logByDate.dateTime, logByDate.moisture_4);
                chartEto.Series["Sensor5"].Points.AddXY(logByDate.dateTime, logByDate.moisture_5);
                chartEto.Series["Sensor6"].Points.AddXY(logByDate.dateTime, logByDate.moisture_6);
            }));
        }

        // -----------------------------
        // Method: writeToFile()
        //  Writes the log to a .txt file.
        //  Arguments: String.
        //  Returns: void.
        // -----------------------------
        void writeToFile(String line)
        {
            using (StreamWriter w = File.AppendText(file_name))
            {
                w.WriteLine(line);
            }

            checkDate();
        }

        // -----------------------------
        // Method: writeToXively()
        //  Writes the data to the Xively API.
        //  Arguments: LogByDate.
        //  Returns: void.
        // -----------------------------
        void writeToXively(LogByDate log)
        {
            if (can_upload)
            {
                try
                {
                    lblStatus.Text = "Writing data to Xively.";
                    client.WriteToFeed(feedId, log.getDataPoints());
                    lblStatus.Text = "Writing complete. Waiting for data.";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Data not uploaded to Xively";
                }
            }
        }

        // -----------------------------
        // Method: btnExport_Click()
        //  Writes the data to the Xively API.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void btnExport_Click(object sender, EventArgs e)
        {
            chartEto.SaveImage("chart.jpg", ChartImageFormat.Jpeg);
            lblStatus.Text = "Image exported.";
        }

        // -----------------------------
        // Method: checkDate()
        //  Checks the date to backup the log file.
        //  Arguments: void.
        //  Returns: void.
        // -----------------------------
        private void checkDate()
        {
            String line, date;
            List<string> buff = new List<string>();

            if (File.Exists(file_name))
            {
                if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Monday) && (DateTime.Now.Hour == 0) && (DateTime.Now.Minute == 0))
                {
                    using (StreamReader rd = new StreamReader(file_name))
                    {
                        line = rd.ReadLine();
                    }
                    date = line.Substring(line.LastIndexOf(',') + 1);
                    date = date.Substring(0, date.LastIndexOf(' '));

                    using (StreamReader rd = new StreamReader(file_name))
                    {
                        int counter = 0;
                        while ((line = rd.ReadLine()) != null)
                        {
                            buff.Add(line);
                        }
                    }

                    String new_file_name = date + "_Log.txt";
                    using (StreamWriter w = File.AppendText(new_file_name))
                    {
                        foreach(String buf_line in buff) w.WriteLine(buf_line);
                    }
                }
            }
        }

        // -----------------------------
        // Method: timer_clock_Tick()
        //  Writes the time in lblTime, every second.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.TimeOfDay.ToString();
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor1.Checked && cbxSensor1.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor1"].Enabled = true;
                isGraphedS1 = true;
            }
            else
            {
                chartEto.Series["Sensor1"].Enabled = false;
                isGraphedS1 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor2.Checked && cbxSensor2.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor2"].Enabled = true;
                isGraphedS2 = true;
            }
            else
            {
                chartEto.Series["Sensor2"].Enabled = false;
                isGraphedS2 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor3.Checked && cbxSensor3.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor3"].Enabled = true;
                isGraphedS3 = true;
            }
            else
            {
                chartEto.Series["Sensor3"].Enabled = false;
                isGraphedS3 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor4.Checked && cbxSensor4.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor4"].Enabled = true;
                isGraphedS4 = true;
            }
            else
            {
                chartEto.Series["Sensor4"].Enabled = false;
                isGraphedS4 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor5.Checked && cbxSensor5.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor5"].Enabled = true;
                isGraphedS5 = true;
            }
            else
            {
                chartEto.Series["Sensor5"].Enabled = false;
                isGraphedS5 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxSensor6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSensor6.Checked && cbxSensor6.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Sensor6"].Enabled = true;
                isGraphedS6 = true;
            }
            else
            {
                chartEto.Series["Sensor6"].Enabled = false;
                isGraphedS6 = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks for the item selected in the checkbox.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxEto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEto.Checked && cbxEto.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Evapotranspiration"].Enabled = true;
                isGraphedEto = true;
            }
            else
            {
                chartEto.Series["Evapotranspiration"].Enabled = false;
                isGraphedEto = false;
            }
        }

        // -----------------------------
        // Method: cbxSensor1_CheckedChanged()
        //  Checks to display points on graphs.
        //  Arguments: object, EventArgs.
        //  Returns: void.
        // -----------------------------
        private void cbxPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPoints.Checked && cbxPoints.CheckState.Equals(CheckState.Checked))
            {
                chartEto.Series["Evapotranspiration"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Evapotranspiration"].ToolTip = "#VALY";
                chartEto.Series["Sensor1"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor1"].ToolTip = "#VALY";
                chartEto.Series["Sensor2"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor2"].ToolTip = "#VALY";
                chartEto.Series["Sensor3"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor3"].ToolTip = "#VALY";
                chartEto.Series["Sensor4"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor4"].ToolTip = "#VALY";
                chartEto.Series["Sensor5"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor5"].ToolTip = "#VALY";
                chartEto.Series["Sensor6"].MarkerStyle = MarkerStyle.Circle;
                chartEto.Series["Sensor6"].ToolTip = "#VALY";
                isGraphedPoints = true;
            }
            else
            {
                chartEto.Series["Evapotranspiration"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor1"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor2"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor3"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor4"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor5"].MarkerStyle = MarkerStyle.None;
                chartEto.Series["Sensor6"].MarkerStyle = MarkerStyle.None;
                isGraphedPoints = false;
            }
        }
    }
}
