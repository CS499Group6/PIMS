using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PatientTreatmentInfo
    {

        public DateTime? dateAdmitted { get; set; } 
        public string reasonAdmitted { get; set; }
        public DateTime? dateDischarged { get; set; }
        public string reasonDischarged { get; set; }
        public string primaryDoc { get; set; } //primary physician
        public string attendingDoc { get; set; } //hospital doctor
        public string docNotes { get; set; }
        public string allergies { get; set; }
        public string diagnosis { get; set; }
        public MedStaffNotes  medStaffNotes { get; set; }
        public List<MedProcedure> procedures;

        public PatientPrescInfo prescriptions { get; set; }

        public PatientTreatmentInfo()
        {
            dateAdmitted = null;
            dateDischarged = null;
            medStaffNotes = new MedStaffNotes();
            procedures = new List<MedProcedure>();
            prescriptions = new PatientPrescInfo();
        }
    }
}
