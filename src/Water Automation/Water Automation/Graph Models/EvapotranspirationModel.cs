using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Graph_Models
{
    class EvapotranspirationModel
    {
        public float eto;
        public string date_time;


        public EvapotranspirationModel(float eto_new)
        {
            eto = eto_new;
            date_time = DateTime.Now.ToString("yyyy/mm/dd h:mm:ss");  
        }
    }
}
