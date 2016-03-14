using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIMSController
{
    public class PatientDirInfo
    {
        static int id = 12345;
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
        public bool isAdmitted { get; set; }
        public Visitor[] visitorList { get; set; }
        public HospLocation location { get; set; }
        public EmerContact emerContact1  { get; set; }
        public EmerContact emerContact2 { get; set; }
        public PatientDirInfo()
        {

            patientID = (id++).ToString();
            fName = "Thomas";
            mName = "Brandon";
            lName = "Kibler";
            gender = true;
            DOB = new DateTime(1976,9,12);
            strAddress = "314 Cumberland Drive";
            city = "Huntsville";
            state = "Alabama";
            zip = "35803";
            phoneNum1 = "2569199468";
            phoneNum2 = "";
            visitorList = new Visitor[10];
            location = new HospLocation();
            emerContact1 = new EmerContact();
            emerContact2 = new EmerContact();
            //emerContact1.name = "";
            //emerContact1.phoneNum = "";
            //emerContact2.name = "";
            //emerContact2.phoneNum = "";


        }
    }
}
