using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class Patient
    {
        public PatientDirInfo directory;
        public PatientTreatmentInfo treatment;
        public PatientBillingInfo billing;

        public Patient()
        {
            if (PimsMain.Program.currentUser is Doctor ||
               PimsMain.Program.currentUser is MedStaff)
            {
                directory = new PatientDirInfo();
                treatment = new PatientTreatmentInfo();
                billing = new PatientBillingInfo();
            }
            else if (PimsMain.Program.currentUser is OfficeStaff)
            {
                directory = new PatientDirInfo();
                billing = new PatientBillingInfo();
                treatment = null;
            }
            else
            {
                directory = new PatientDirInfo();
                treatment = null;
                billing = null;
            }
        }
    }
}
