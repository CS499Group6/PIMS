using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class Doctor : User
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
        public void updateDocNotes()
        {

        }
        public void updateProcedures()
        {

        }
        public void updatePresc()
        {

        }
        public override Patient getPatient()
        {
            Patient myPatient = new Patient();
            return myPatient;
        }
    }
}
