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
        public PatientInsInfo insurance;

        public Patient()
        {
            if (PIMS.Program.currentUser is Doctor ||
               PIMS.Program.currentUser is MedStaff)
            {
                directory = new PatientDirInfo();
                treatment = new PatientTreatmentInfo();
                billing = new PatientBillingInfo();
                insurance = new PatientInsInfo();
            }
            else if (PIMS.Program.currentUser is OfficeStaff)
            {
                directory = new PatientDirInfo();
                billing = new PatientBillingInfo();
                insurance = new PatientInsInfo();
                treatment = null;
            }
            else
            {
                directory = new PatientDirInfo();
                insurance = null;
                treatment = null;
                billing = null;
            }
        }
    }
}
