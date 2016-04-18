using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class BedList
    {
        public List<HospLocation> locations { get; set; }
    
        public BedList()
        {
             locations = new List<HospLocation>();
        }

    }
}
