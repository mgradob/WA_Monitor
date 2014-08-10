using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Models
{
    class TimeoutLog
    {
        public string tData_date;


        public TimeoutLog()
        {
            tData_date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
