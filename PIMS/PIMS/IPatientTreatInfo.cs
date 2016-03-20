using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS
{
    interface IPatientTreatInfo 
    {
        DateTime dateAdmitted { get; set; }
        string reasonForAdmittance { get; set; }
        DateTime dateDischarged { get; set; }
        string primDoc { get; set; }
        string schedProcedures { get; set; }
        string docNotes { get; set; }
        string medStaffNotes { get; set; }
        PrescDrug[] medsOn { get; set; }


    }
}
