using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public abstract class User
    {
        protected string username { get; set; }
        protected string password { get; set; }
        protected string staffID { get; set; }
        protected string name { get; set; }
        protected string position { get; set; }
        protected string unit { get; set; }

        public abstract void readDirInfo();
        public abstract void searchPatients();
        public abstract Patient getPatient();
       
    }
}
