using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Graph_Models
{
    class RadiationModel
    {
        public int radiation;
        public DateTime date_time;


        public RadiationModel(int rad, DateTime dateTime)
        {
            radiation = rad;
            date_time = dateTime;
        }
    }
}
