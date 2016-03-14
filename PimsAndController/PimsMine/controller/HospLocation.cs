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
        public string unit { get; set; }
        public string floor { get; set; }
        public string roomNum { get; set; }
        public HospLocation()
        {
            bedNum = "123";
            unit = "1234";
            floor = "12";
            roomNum = "1";
        }
    }
}
