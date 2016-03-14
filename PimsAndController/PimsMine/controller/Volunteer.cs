using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class Volunteer : User
    {
        public override void searchPatients()
        {
            return;
        }
        public override void readDirInfo()
        {
            return;
        }
        public override Patient getPatient()
        {
            Patient myPatient = new Patient();
            // do SQL stuff
            return myPatient;
        }
    }
}
