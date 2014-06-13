using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Models
{
    class LogByDate
    {
        public float moisture_1 { get; set; }
        public float moisture_2 { get; set; }
        public float moisture_3 { get; set; }
        public float moisture_4 { get; set; }
        public float moisture_5 { get; set; }
        public float moisture_6 { get; set; }

        public int radiation { get; set; }
        public float atmospheric_humidity { get; set; }
        public float atmospheric_temperature { get; set; }
        public float wind_speed { get; set; }

        public int relay_status { get; set; }

        public float consolidate { get; set; }
        public int timeout_DAAD { get; set; }
        public int timeout_DA55 { get; set; }
        public int timeout_c { get; set; }

        public DateTime dateTime { get; set; }

        public LogByDate(String line)
        {
            // Split data from csv line
            String[] data = line.Split(',');

            //Test: foreach (String data_line in data) file_textbox.AppendText(data_line + "\);

            // Add data to list
            // Write moisture data
            try
            {
                moisture_1 = float.Parse(data[1]);
                moisture_2 = float.Parse(data[2]);
                moisture_3 = float.Parse(data[3]);
                moisture_4 = float.Parse(data[4]);
                moisture_5 = float.Parse(data[5]);
                moisture_6 = float.Parse(data[6]);

                // Write weather data
                radiation = int.Parse(data[7]);
                atmospheric_humidity = float.Parse(data[8]);
                atmospheric_temperature = float.Parse(data[9]);
                wind_speed = float.Parse(data[10]);

                // Write pump data
                relay_status = int.Parse(data[11]);

                // Write timeout data
                timeout_DAAD = int.Parse(data[12]);
                timeout_DA55 = int.Parse(data[13]);
                timeout_c = int.Parse(data[14]);
                consolidate = float.Parse(data[0]);

                // Write date and time
                dateTime = DateTime.Parse(data[15], null, DateTimeStyles.None);
            }
            catch (FormatException fex)
            {
                if (data[0].Equals("i"))
                    moisture_1 = -1;
                else if (data[0].Equals("t"))
                    moisture_1 = -2;

                moisture_2 = 0;
                moisture_3 = 0;
                moisture_4 = 0;
                moisture_5 = 0;
                moisture_6 = 0;

                // Write weather data
                radiation = 0;
                atmospheric_humidity = 0;
                atmospheric_temperature = 0;
                wind_speed = 0;

                // Write pump data
                relay_status = 0;

                // Write timeout data
                timeout_DAAD = 0;
                timeout_DA55 = 0;
                timeout_c = 0;
                consolidate = 0;

                // Write date and time
                dateTime = DateTime.Parse(data[15], null, DateTimeStyles.None);
            }
        }
    }
}
