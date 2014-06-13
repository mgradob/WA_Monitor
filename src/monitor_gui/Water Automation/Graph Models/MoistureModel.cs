using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Graph_Models
{
    class MoistureModel
    {
        public DateTime date_time;
        public float value;


        public MoistureModel(float val, DateTime dateTime)
        {
            value = val;
            date_time = dateTime;
        }
    }
}
