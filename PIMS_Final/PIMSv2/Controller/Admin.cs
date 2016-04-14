using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class Admin : User
    {
        public override Patient getPatient()
        {
            return null;
        }
        public override void searchPatients()
        {
            return;
        }
        public override void readDirInfo()
        {
            return;
        }
    }
}
