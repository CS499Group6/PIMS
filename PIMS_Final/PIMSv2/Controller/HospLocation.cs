using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class HospLocation
    {
        public int? bedNum { get; set; }
        public string unit { get; set; } //ex: cardiology
        public int? floor { get; set; }
        public int? roomNum { get; set; }
        public int? occupancy { get; set; }//number of occupants currently in that room

        /*
        public HospLocation()
        {
              
        }
         */
    }
}
