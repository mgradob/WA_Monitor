using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Graph_Models
{
    class AtmosphericHumidityModel
    {
        public float atm_hum;
        public DateTime date_time;


        public AtmosphericHumidityModel(float atmHum, DateTime dateTime)
        {
            atm_hum = atmHum;
            date_time = dateTime;
        }
    }
}
