using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class HospLocation
    {
        public string bedNum { get; set; }
        public string unit { get; set; } //ex: cardiology
        public string floor { get; set; }
        public string roomNum { get; set; }
        public int occupancy { get; set; }//number of occupants currently in that room
        public HospLocation()
        {
 
        }
    }
}
