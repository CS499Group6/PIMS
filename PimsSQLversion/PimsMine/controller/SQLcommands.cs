using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIMSController
{
    public class SQLcommands
    {
        static string connectString = "user id=PIMS;password=PIMS;server=cs-sql\\PIMS;database=PIMS_database;";
        static SqlConnection cnn = new SqlConnection(connectString);
        
        public static List<Patient> patients = null;
        
        public static Boolean checkLogin(string userID, string pwd)
        {
            string getPWD = "SELECT * from Staff";
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(getPWD,cnn);
            SqlDataReader datardr;
            datardr = cmd.ExecuteReader();
            while (datardr.Read())
                {
                    if (datardr.GetValue(3).Equals(userID))
                    {
                        if(datardr.GetValue(5).Equals(pwd))
                        {
                            if(datardr.GetValue(2).Equals("doc"))
                                PimsMain.Program.currentUser = new Doctor();
                            else if(datardr.GetValue(2).Equals("off"))
                                PimsMain.Program.currentUser = new OfficeStaff();
                            else if (datardr.GetValue(2).Equals("med"))
                                PimsMain.Program.currentUser = new MedStaff();
                            else if (datardr.GetValue(2).Equals("vol"))
                                PimsMain.Program.currentUser = new Volunteer();

                            datardr.Close();
                            cnn.Close();
                            return true;
                        }
                    }
                }
            datardr.Close();
            cnn.Close();
           return false;

        }
        public static Patient buildPatient(string patientID)
        {
            Patient x = new Patient();
            string getDirInfo = "SELECT * from Patient where patientID = " + patientID;
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(getDirInfo, cnn);
            SqlDataReader datardr;
            datardr = cmd.ExecuteReader();

            // Build directory section
            while (datardr.Read())
            {
                if (datardr.GetValue(0) != System.DBNull.Value)
                    x.directory.patientID = (String)datardr.GetValue(0);
                if (datardr.GetValue(1) != System.DBNull.Value)
                    x.directory.fName = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    x.directory.lName = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    x.directory.mName = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    x.directory.DOB = (DateTime)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                {
                    string g = (String)datardr.GetValue(5);
                    if (g == "m")
                        x.directory.gender = true;
                    else x.directory.gender = false;
                }
                if (datardr.GetValue(6) != System.DBNull.Value)
                    x.directory.strAddress = (String)datardr.GetValue(6);
                if (datardr.GetValue(7) != System.DBNull.Value)
                    x.directory.phoneNum1 = datardr.GetValue(7).ToString();
                if (datardr.GetValue(8) != System.DBNull.Value)
                    x.directory.phoneNum2 = datardr.GetValue(8).ToString();
                if (datardr.GetValue(9) != System.DBNull.Value)
                    x.directory.emerContact1.name = (String)datardr.GetValue(9);
                if (datardr.GetValue(10) != System.DBNull.Value)
                    x.directory.emerContact1.phoneNum = datardr.GetValue(10).ToString();
                if (datardr.GetValue(11) != System.DBNull.Value)
                    x.directory.emerContact2.name = (String)datardr.GetValue(11);
                if (datardr.GetValue(12) != System.DBNull.Value)
                    x.directory.emerContact2.phoneNum = datardr.GetValue(12).ToString();
                if (datardr.GetValue(13) != System.DBNull.Value)
                {
                    Visitor v = new Visitor();
                    v.name = (String)datardr.GetValue(13);
                    x.directory.visitors.Add(v);
                }
                if (!(datardr.GetValue(14).Equals(System.DBNull.Value)))
                    x.directory.location.bedNum = (String)datardr.GetValue(14);
                if (datardr.GetValue(15) != System.DBNull.Value)
                    x.directory.city = (String)datardr.GetValue(15);
                if (datardr.GetValue(16) != System.DBNull.Value)
                    x.directory.state = (String)datardr.GetValue(16);
            }

            cnn.Close();

            // If current user is a volunteer, this is all the info we need
            if (PimsMain.Program.currentUser is Volunteer)
            {
                return x;
            }

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String getBillingInfo = "SELECT * from Billing where patientID = " + patientID;
            cmd = new SqlCommand(getBillingInfo, cnn);
            datardr = cmd.ExecuteReader();

            // build billing info here

            // if user is office staff, this is all the info we need
            if (PimsMain.Program.currentUser is OfficeStaff)
            {
                return x;
            }

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String getTreatmentInfo = "SELECT * from Treatment where patientID = " + patientID;
            cmd = new SqlCommand(getBillingInfo, cnn);
            datardr = cmd.ExecuteReader();

            return x;
        }
        public static List<Patient> getPatientList()
        {
            string getPatList = "SELECT * from Patient";
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(getPatList, cnn);
            SqlDataReader datardr;
            datardr = cmd.ExecuteReader();

         
            patients = new List<Patient>();
           
            while (datardr.Read())
            {
                Patient x = new Patient();
                if(datardr.GetValue(0) != null)
                   x.directory.patientID = (String)datardr.GetValue(0);
                if (datardr.GetValue(1) != null)
                   x.directory.fName     = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != null)
                   x.directory.lName     = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != null)
                   x.directory.mName     = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != null)
                    x.directory.DOB       = (DateTime)datardr.GetValue(4);
                if (datardr.GetValue(5) != null)
                {
                    string g = (String)datardr.GetValue(5);
                    if (g == "m")
                        x.directory.gender = true;
                    else x.directory.gender = false;
                }
                if (datardr.GetValue(6) != null)
                    x.directory.strAddress = (String)datardr.GetValue(6);
                if (datardr.GetValue(7) != null)
                    x.directory.phoneNum1 = datardr.GetValue(7).ToString();
                if (datardr.GetValue(8) != null)
                    x.directory.phoneNum2 = datardr.GetValue(8).ToString();
                if (datardr.GetValue(9) != null)
                    x.directory.emerContact1.name = (String)datardr.GetValue(9);
                if (datardr.GetValue(10) != null)
                    x.directory.emerContact1.phoneNum = datardr.GetValue(10).ToString();
                if (datardr.GetValue(11) != null)
                    x.directory.emerContact2.name = (String)datardr.GetValue(11);
                if (datardr.GetValue(12) != null)
                    x.directory.emerContact2.phoneNum = datardr.GetValue(12).ToString();
                if (datardr.GetValue(13) != null)
                {
                    Visitor v = new Visitor();
                    v.name = (String)datardr.GetValue(13);
                    x.directory.visitors.Add(v);
                }
                if (!(datardr.GetValue(14).Equals(System.DBNull.Value)))
                    x.directory.location.bedNum = (String)datardr.GetValue(14);
                if(datardr.GetValue(15) != null)
                    x.directory.city = (String)datardr.GetValue(15);
                if(datardr.GetValue(16) != null)
                    x.directory.state = (String)datardr.GetValue(16);
                patients.Add(x);
                
            }
 
            
            return patients;
        }

        public static void updatePatient(Patient patient)
        {
            //TODO: SQL update this patient info
        }

        
    }
}
