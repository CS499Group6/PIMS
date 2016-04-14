using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public abstract class User
    {
        public string staffID { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string username { get; set; }
        public string unit { get; set; }
        public string password { get; set; } 


        public abstract void readDirInfo();
        public abstract void searchPatients();
        public abstract Patient getPatient();
       
    }
}
