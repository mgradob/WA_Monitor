using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Automation.Models
{
    class InvalidDataLog
    {
        public string iData_date;


        public InvalidDataLog()
        {
            iData_date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
