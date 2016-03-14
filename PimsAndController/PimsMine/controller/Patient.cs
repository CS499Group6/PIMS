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
            this.directory = new PatientDirInfo();
            this.treatment = new PatientTreatmentInfo();
            treatment.docNotes = "First set of notes" + "\nsecond line of notes";

        }

        public Patient(string lName, string fName)
        {
            directory = new PatientDirInfo();
            directory.lName = lName;
            directory.fName = fName;
            treatment = new PatientTreatmentInfo();
        }
    }
}
