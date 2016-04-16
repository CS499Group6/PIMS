using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class MedProcedure
    {
        //comments specify name of corresponding column name in database 
        public string what { get; set; } //scheduledProcedure
        public DateTime when { get; set; } //whenScheduled
        public string who { get; set; } //performedBy
        public string where { get; set; } //Location
        public int id { get; set; } // Id
    }
}
