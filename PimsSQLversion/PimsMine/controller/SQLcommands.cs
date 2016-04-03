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
           
            /*
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
                    x.directory.zip = (String)datardr.GetValue(7);
                if (datardr.GetValue(8) != System.DBNull.Value)
                    x.directory.state = (String)datardr.GetValue(8);
                if (datardr.GetValue(10) != System.DBNull.Value)
                    x.directory.phoneNum1 = datardr.GetValue(10).ToString();
                if (datardr.GetValue(9) != System.DBNull.Value)
                    x.directory.city = (String)datardr.GetValue(9);
                if (datardr.GetValue(11) != System.DBNull.Value)
                    x.directory.phoneNum2 = datardr.GetValue(11).ToString();
                if (datardr.GetValue(12) != System.DBNull.Value)
                    x.directory.emerContact1.name = (String)datardr.GetValue(12);
                if (datardr.GetValue(13) != System.DBNull.Value)
                    x.directory.emerContact1.phoneNum = datardr.GetValue(13).ToString();
                if (datardr.GetValue(14) != System.DBNull.Value)
                    x.directory.emerContact2.name = (String)datardr.GetValue(14);
                if (datardr.GetValue(15) != System.DBNull.Value)
                    x.directory.emerContact2.phoneNum = datardr.GetValue(15).ToString();
                if (datardr.GetValue(16) != System.DBNull.Value)
                {
                    Visitor v = new Visitor();
                    v.name = (String)datardr.GetValue(16);
                    x.directory.visitors.Add(v);
                }
                if (!(datardr.GetValue(17).Equals(System.DBNull.Value)))
                    x.directory.location.bedNum = (String)datardr.GetValue(17);                         
           }
             */

                Visitor v= new Visitor();
                DateTime min = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                {
                    cnn.Close();
                }
            cnn.Open();   
            SqlCommand cmd= new SqlCommand("createPatient", cnn);
               
            //Add all the parameters required by the procedure in SQL
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //The input parameter patientID    
                 cmd.Parameters.Add(new SqlParameter("@patientID", patientID));
            //all the output parameters
                    cmd.Parameters.Add(new SqlParameter("@fname", x.directory.fName));
                    cmd.Parameters.Add(new SqlParameter( "@lname", x.directory.lName));
                    cmd.Parameters.Add(new SqlParameter("@mname", x.directory.mName));
                    cmd.Parameters.Add(new SqlParameter("@DOB", min));
                        x.directory.DOB = min;
                    cmd.Parameters.Add(new SqlParameter("@gender", x.directory.gender));
                    cmd.Parameters.Add(new SqlParameter("@pStreet", x.directory.strAddress));
                    cmd.Parameters.Add(new SqlParameter("@pCity", x.directory.city));
                    cmd.Parameters.Add(new SqlParameter( "@pState", x.directory.state));
                    cmd.Parameters.Add(new SqlParameter( "@pZip", x.directory.zip));
                    cmd.Parameters.Add(new SqlParameter( "@phone1", x.directory.phoneNum1));
                    cmd.Parameters.Add(new SqlParameter( "@phone2", x.directory.phoneNum2));
                    cmd.Parameters.Add(new SqlParameter( "@emName1", x.directory.emerContact1.name));
                    cmd.Parameters.Add(new SqlParameter( "@emNum1", x.directory.emerContact1.phoneNum));
                    cmd.Parameters.Add(new SqlParameter("@emName2", x.directory.emerContact2.name));
                    cmd.Parameters.Add(new SqlParameter( "@emNum2", x.directory.emerContact2.phoneNum));
                    cmd.Parameters.Add(new SqlParameter("@visitor", v.name));
                    cmd.Parameters.Add(new SqlParameter( "@bedNum", x.directory.location.bedNum));                  
            SqlDataReader datardr;
            datardr = cmd.ExecuteReader();

            cnn.Close();

            // If current user is a volunteer, this is all the info we need
            if (PimsMain.Program.currentUser is Volunteer)
            {
                return x;
            }

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String getBillingInfo = "SELECT * from Charges where patientID = " + patientID;
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
                    x.directory.zip = (String)datardr.GetValue(7);
                if (datardr.GetValue(8) != System.DBNull.Value)
                    x.directory.state = (String)datardr.GetValue(8);
                if (datardr.GetValue(10) != System.DBNull.Value)
                    x.directory.phoneNum1 = datardr.GetValue(10).ToString();
                if (datardr.GetValue(9) != System.DBNull.Value)
                    x.directory.city = (String)datardr.GetValue(9);
                if (datardr.GetValue(11) != System.DBNull.Value)
                    x.directory.phoneNum2 = datardr.GetValue(11).ToString();
                if (datardr.GetValue(12) != System.DBNull.Value)
                    x.directory.emerContact1.name = (String)datardr.GetValue(12);
                if (datardr.GetValue(13) != System.DBNull.Value)
                    x.directory.emerContact1.phoneNum = datardr.GetValue(13).ToString();
                if (datardr.GetValue(14) != System.DBNull.Value)
                    x.directory.emerContact2.name = (String)datardr.GetValue(14);
                if (datardr.GetValue(15) != System.DBNull.Value)
                    x.directory.emerContact2.phoneNum = datardr.GetValue(15).ToString();
                if (datardr.GetValue(16) != System.DBNull.Value)
                {
                    Visitor v = new Visitor();
                    v.name = (String)datardr.GetValue(16);
                    x.directory.visitors.Add(v);
                }
                if (!(datardr.GetValue(17).Equals(System.DBNull.Value)))
                    x.directory.location.bedNum = (String)datardr.GetValue(17);  
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
