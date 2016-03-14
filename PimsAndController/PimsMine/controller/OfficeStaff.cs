using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class OfficeStaff : User
    {
        public override void searchPatients()
        {
            return;
        }
        public override void readDirInfo()
        {
            return;
        }
        public void readBillInfo()
        {

        }
        public void updateBillInfo()
        {

        }
        public void updateDirInfo()
        {

        }
        public void readInsInfo()
        {

        }
        public void updateInsInfo()
        {

        }
        public override Patient getPatient()
        {
            Patient myPatient = new Patient();
            return myPatient;
        }
    }
}
