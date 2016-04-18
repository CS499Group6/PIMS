using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIMSController
{
    public class PatientDirInfo
    {
        public string patientID { get; set; }
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        // true is for males, false for females
        public bool gender { get; set; }
        public DateTime DOB { get; set; }
        public string strAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNum1 { get; set; }
        public string phoneNum2 { get; set; }
        public string workphone { get; set; }
        public bool isAdmitted { get; set; }
        public List<Visitor> visitors { get; set; }
        public HospLocation location { get; set; }
        public EmerContact emerContact1  { get; set; }
        public EmerContact emerContact2 { get; set; }

        public PatientDirInfo()
        { 
            visitors = new List<Visitor>();
            location = new HospLocation();
            emerContact1 = new EmerContact();
            emerContact2 = new EmerContact();
        }
    }
}
