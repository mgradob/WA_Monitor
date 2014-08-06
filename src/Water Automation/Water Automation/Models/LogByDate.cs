using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xively;

namespace Water_Automation.Models
{
    class LogByDate
    {
        // -----------------------------
        // Global Variables
        // -----------------------------
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
        public float evapotranspiration { get; set; }

        public int relay_status { get; set; }
        public float water_flow { get; set; }

        public float consolidate { get; set; }
        public int timeout_DAAD { get; set; }
        public int timeout_DA55 { get; set; }
        public int timeout_c { get; set; }
        public int timeout_climate_node { get; set; }
        public int timeout_pump_node { get; set; }

        public string dateTime { get; set; }

        // -----------------------------
        // Constructor
        // -----------------------------
        public LogByDate(byte[] data)
        {
            // Write humidity data
            moisture_1 = (float)data[17] + (float)data[18]/100;
            moisture_2 = (float)data[19] + (float)data[20] / 100;
            moisture_3 = (float)data[21] + (float)data[22] / 100;
            moisture_4 = (float)data[24] + (float)data[25] / 100;
            moisture_5 = (float)data[26] + (float)data[27] / 100;
            moisture_6 = (float)data[28] + (float)data[29] / 100;

            // Write weather data
            radiation = ((int)data[31] << 8) | (int)data[32];
            atmospheric_humidity = (float)data[33] + (float)data[34] / 100;
            atmospheric_temperature = (float)data[35] + (float)data[36] / 100;
            wind_speed = (float)data[37] + (float)data[38] / 100;
            evapotranspiration = (float)data[39] + (float)data[40] / 100;

            // Write pump data
            relay_status = (int)data[42];
            water_flow = (float)data[43] + (float)data[44] / 100;

            // Write timeout data
            consolidate = (float)data[46] + (float)data[47] / 100;
            timeout_DAAD = (int)data[48];
            timeout_DA55 = (int)data[49];
            timeout_c = (int)data[50];
            timeout_climate_node = (int)data[51];
            timeout_pump_node = (int)data[52];

            // Write date and time
            dateTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        // -----------------------------
        // Method: dataToString()
        //  Returns the string with all the data of the log.
        //  Arguments: void.
        //  Returns: string.
        // -----------------------------
        public string dataToString(){
            string data;
            data = consolidate.ToString() + ",";
            data += moisture_1.ToString() + ",";
            data += moisture_2.ToString() + ",";
            data += moisture_3.ToString() + ",";
            data += moisture_4.ToString() + ",";
            data += moisture_5.ToString() + ",";
            data += moisture_6.ToString() + ",";
            data += radiation.ToString() + ",";
            data += atmospheric_temperature.ToString() + ",";
            data += atmospheric_humidity.ToString() + ",";
            data += wind_speed.ToString() + ",";
            data += evapotranspiration.ToString() + ",";
            data += relay_status.ToString() + ",";
            data += water_flow.ToString() + ",";
            data += timeout_DAAD.ToString() + ",";
            data += timeout_DA55.ToString() + ",";
            data += timeout_c.ToString() + ",";
            data += timeout_climate_node.ToString() + ",";
            data += timeout_pump_node.ToString() + ",";
            data += dateTime.ToString();

            return data;
        }

        // -----------------------------
        // Method: getDataPoints()
        //  Returns an array of XivelyDataPoints for the object.
        //  Arguments: void.
        //  Returns: XivelyDataPoint[].
        // -----------------------------
        public XivelyDataPoint[] getDataPoints()
        {
            XivelyDataPoint[] arr = new XivelyDataPoint[14];

            XivelyDataPoint moisture1_point = new XivelyDataPoint();
            moisture1_point.StreamId = "HM1_S1";
            moisture1_point.CurrentValue = moisture_1.ToString();

            XivelyDataPoint moisture2_point = new XivelyDataPoint();
            moisture2_point.StreamId = "HM1_S2";
            moisture2_point.CurrentValue = moisture_2.ToString();

            XivelyDataPoint moisture3_point = new XivelyDataPoint();
            moisture3_point.StreamId = "HM2_S1";
            moisture3_point.CurrentValue = moisture_3.ToString();

            XivelyDataPoint moisture4_point = new XivelyDataPoint();
            moisture4_point.StreamId = "HM2_S2";
            moisture4_point.CurrentValue = moisture_4.ToString();

            XivelyDataPoint moisture5_point = new XivelyDataPoint();
            moisture5_point.StreamId = "HM3_S1";
            moisture5_point.CurrentValue = moisture_5.ToString();

            XivelyDataPoint moisture6_point = new XivelyDataPoint();
            moisture6_point.StreamId = "HM3_S2";
            moisture6_point.CurrentValue = moisture_6.ToString();
            
            XivelyDataPoint radiation_point = new XivelyDataPoint();
            radiation_point.StreamId = "Radiation";
            radiation_point.CurrentValue = radiation.ToString();

            XivelyDataPoint atm_hum_point = new XivelyDataPoint();
            atm_hum_point.StreamId = "Atm_Humidity";
            atm_hum_point.CurrentValue = atmospheric_humidity.ToString();

            XivelyDataPoint atm_temp_point = new XivelyDataPoint();
            atm_temp_point.StreamId = "Atm_Temperature";
            atm_temp_point.CurrentValue = atmospheric_temperature.ToString();

            XivelyDataPoint wnd_spd_point = new XivelyDataPoint();
            wnd_spd_point.StreamId = "Wind_Speed";
            wnd_spd_point.CurrentValue = wind_speed.ToString();

            XivelyDataPoint eto_point = new XivelyDataPoint();
            eto_point.StreamId = "Evapotranspiration";
            eto_point.CurrentValue = evapotranspiration.ToString();
            
            XivelyDataPoint relay_stat_point = new XivelyDataPoint();
            relay_stat_point.StreamId = "Pump_State";
            relay_stat_point.CurrentValue = relay_status.ToString();

            XivelyDataPoint wtr_flow_point = new XivelyDataPoint();
            wtr_flow_point.StreamId = "Water_Flow";
            wtr_flow_point.CurrentValue = water_flow.ToString();
                        
            XivelyDataPoint consolidate_point = new XivelyDataPoint();
            consolidate_point.StreamId = "Cons_Humidity";
            consolidate_point.CurrentValue = consolidate.ToString();

            arr[0] = moisture1_point;
            arr[1] = moisture2_point;
            arr[2] = moisture3_point;
            arr[3] = moisture4_point;
            arr[4] = moisture5_point;
            arr[5] = moisture6_point;
            arr[6] = radiation_point;
            arr[7] = atm_hum_point;
            arr[8] = atm_temp_point;
            arr[9] = wnd_spd_point;
            arr[10] = eto_point;
            arr[11] = relay_stat_point;
            arr[12] = wtr_flow_point;
            arr[13] = consolidate_point;

            return arr;
        }
    }
}
