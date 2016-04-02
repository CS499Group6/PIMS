using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS
{
    interface IPatientDirInfo
    {
        string patientID { get; set; }
        string fName { get; set; }
        string mName { get; set; }
        string lName { get; set; }
        DateTime dateOfBirth { get; set; }
        string strAddress { get; set; }
        string city { get; set; }
        string county { get; set; }
        string zip { get; set; }
        string phone { get; set; }
        string emerContact1Name { get; set; }
        string emerContact1Phone { get; set; }
        string emerContact1Address { get; set; }
        string visList { get; set; }
        string bedNum { get; set; }
    }
}
