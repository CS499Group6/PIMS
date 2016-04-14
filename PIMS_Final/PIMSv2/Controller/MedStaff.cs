using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class MedStaff : User
    {
        public override void searchPatients()
        {
            return;
        }
        public override void readDirInfo()
        {
            return;
        }
        public void readTreatInfo()
        {

        }
        public void readBillInfo()
        {

        }
        public void readInsInfo()
        {

        }
        public void updateNurseNotes()
        {

        }
        public override Patient getPatient()
        {
            Patient myPatient = new Patient();
            return myPatient;
        }
    }
}
