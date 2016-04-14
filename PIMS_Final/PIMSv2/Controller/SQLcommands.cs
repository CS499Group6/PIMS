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

        //static string connectString = "Data Source=INA-PC;Initial Catalog=PIMS_database;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        static string connectString = "user id=PIMS;password=PIMS;server=cs-sql\\PIMS;database=PIMS;";
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
                Console.WriteLine(datardr.GetValue(3));
                Console.WriteLine(datardr.GetValue(5));
                if (datardr.GetValue(3).Equals(userID))
                    {
                        if(datardr.GetValue(5).Equals(pwd))
                        {
                        if (datardr.GetValue(2).Equals("doc"))
                                PIMS.Program.currentUser = new Doctor();
                            else if(datardr.GetValue(2).Equals("off"))
                                PIMS.Program.currentUser = new OfficeStaff();
                            else if (datardr.GetValue(2).Equals("med"))
                                PIMS.Program.currentUser = new MedStaff();
                            else if (datardr.GetValue(2).Equals("vol"))
                                PIMS.Program.currentUser = new Volunteer();
                            else if (datardr.GetValue(2).Equals("admin"))
                                PIMS.Program.currentUser = new Admin();

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
                    if (g.ToUpper().Equals("M"))
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

            cnn.Close();
            if (x.directory.location.bedNum != null)
            {
                string getLocInfo = "SELECT * from Location where bedNo = " + x.directory.location.bedNum;
                if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(getLocInfo, cnn);
                datardr = cmd.ExecuteReader();
                datardr.Read();
                if (datardr.GetValue(1) != System.DBNull.Value)
                    x.directory.location.unit = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    x.directory.location.floor = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    x.directory.location.roomNum = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    x.directory.location.occupancy = (int)datardr.GetValue(4);

                datardr.Close();
            }
            // If current user is a volunteer, this is all the info we need
            if (PIMS.Program.currentUser is Volunteer)
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
            while (datardr.Read())
            {
                BillingLineItem item = new BillingLineItem();
                if (datardr.GetValue(2) != System.DBNull.Value)
                    item.item = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    item.cost = (int)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    item.paid = (int)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    item.insPaid = (int)datardr.GetValue(5);
                if (datardr.GetValue(6) != System.DBNull.Value)
                    item.dueDate = (DateTime)datardr.GetValue(6);
                x.billing.items.Add(item);
            }
            datardr.Close();

            String getInsInfo = "SELECT * from Insurance where patientID = " + patientID;
            cmd = new SqlCommand(getInsInfo, cnn);
            datardr = cmd.ExecuteReader();
            if (datardr.Read())
            {
                if (datardr.GetValue(1) != System.DBNull.Value)
                    x.billing.insurance.provider = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    x.billing.insurance.bin = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    x.billing.insurance.id = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    x.billing.insurance.pcn = (String)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    x.billing.insurance.groupNum = (String)datardr.GetValue(5);
                datardr.Close();
            }
            // if user is office staff, this is all the info we need
            if (PIMS.Program.currentUser is OfficeStaff)
            {
                return x;
            }

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String getTreatmentInfo = "SELECT * from Treatment where patientID = " + patientID;
            cmd = new SqlCommand(getTreatmentInfo, cnn);
            datardr = cmd.ExecuteReader();
            if (datardr.Read())
            {
                if (datardr.GetValue(1) != System.DBNull.Value)
                    x.treatment.dateAdmitted = (DateTime)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    x.treatment.reasonAdmitted = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    x.treatment.dateDischarged = (DateTime)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    x.treatment.primaryDoc = (String)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    x.treatment.docNotes = (String)datardr.GetValue(5);
                if (datardr.GetValue(6) != System.DBNull.Value)
                    x.treatment.medStaffNotes.allergies = (String)datardr.GetValue(6);
                if (datardr.GetValue(9) != System.DBNull.Value)
                    x.treatment.medStaffNotes.nurseNotes = (String)datardr.GetValue(9);
            }
                datardr.Close();
            
            String getStatList = "SELECT * from patientStats where patientID = " + patientID;
            cmd = new SqlCommand(getStatList, cnn);
            datardr = cmd.ExecuteReader();

            // build stats info here
            while (datardr.Read())
            {
                MedStaffNotes.patientStats stats = new MedStaffNotes.patientStats();

                if (datardr.GetValue(1) != System.DBNull.Value)
                    stats.patientHeight = (int)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    stats.patientWeight = (int)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    stats.bloodPressureSys = (int)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    stats.bloodPressureDia = (int)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    stats.heartrate = (int)datardr.GetValue(5);
                if (datardr.GetValue(6) != System.DBNull.Value)
                {
                    DateTime date1;
                    DateTime.TryParse((String)datardr.GetValue(6),out date1);
                    stats.time = date1;
                }


                x.treatment.medStaffNotes.statList.Add(stats);
            }
            datardr.Close();

            String getDrugList = "SELECT * from Prescriptions where patientID = " + patientID;
            cmd = new SqlCommand(getDrugList, cnn);
            datardr = cmd.ExecuteReader();

            // build stats info here
            while (datardr.Read())
            {
                PrescDrug drug = new PrescDrug();

                if (datardr.GetValue(1) != System.DBNull.Value)
                    drug.name = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    drug.ndc = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    drug.SIG = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    drug.prescribingPhysician = (String)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    drug.dateFilled = (DateTime)datardr.GetValue(5);
                if (datardr.GetValue(6) != System.DBNull.Value)
                    drug.cost = (int)datardr.GetValue(6);

                x.treatment.prescriptions.prescriptions.Add(drug);
            }
            datardr.Close();

            String getProcList = "SELECT * from ScheduledProcedures where patientID = " + patientID;
            cmd = new SqlCommand(getProcList, cnn);
            datardr = cmd.ExecuteReader();

            // build stats info here
            while (datardr.Read())
            {
                MedProcedure proc = new MedProcedure();

                if (datardr.GetValue(1) != System.DBNull.Value)
                    proc.what = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    proc.when = (DateTime)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    proc.who = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    proc.where = (String)datardr.GetValue(4);

                x.treatment.procedures.Add(proc);

            }
            datardr.Close();



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
                Console.WriteLine("reading a patient");
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
            Patient x = PIMS.Program.currentPatient;
            PatientDirInfo dir = x.directory;

            // Volunteers can't update info, so exit if current user is a volunteer
            if(PIMS.Program.currentUser is Volunteer)
            {
                return;
            }

            // only office staff can update billing and directory info
            if (PIMS.Program.currentUser is OfficeStaff || PIMS.Program.currentUser is Doctor)
            {
                // Start with directory updates
                updatePatientDirInfo();
                updateBillingInfo();
            }

            // nurse/med staff updates here
            if (PIMS.Program.currentUser is MedStaff)
            {

            }

            // Doctor updates hereTreatment updates here
            if (PIMS.Program.currentUser is Doctor)
            {
                

            }
            //TODO: SQL update this patient info
        }

        static void updatePatientDirInfo()
        {
             PatientDirInfo dir = PIMS.Program.currentPatient.directory;
             if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                 cnn.Close();
             cnn.Open();
             String cmdText = "UPDATE patient SET firstName = @fn, lastName = @ln, middleName = @mn," +
                 "DOB = @dob, gender = @g, patientAddress = @adr, patientZip = @zip, patientState = @ps," +
                 "patientCity = @city, phone1 = @ph1, phone2 = @ph2,emergencyName = @em, emergencyNumber = @emn," +
                 "emergencyName2 = @em2, emergencyNumber2 = @emn2, visitorList = @vl, bedNo = @bn " +
                 "WHERE patientID = @pid if @@ROWCOUNT = 0 INSERT INTO patient VALUES('@pid','@fn','@ln', '@mn'," +
                 " '@dob', '@g', '@adr', '@zip', '@ps', '@city', '@ph1', '@ph2', '@em', '@emn', '@em2', '@emn2', " +
                 "'@vl')";

             SqlCommand cmd = new SqlCommand(cmdText, cnn);

             cmd.Parameters.AddWithValue("@fn", dir.fName);
             cmd.Parameters.AddWithValue("@ln", dir.lName);
             cmd.Parameters.AddWithValue("@mn", dir.mName);
             cmd.Parameters.AddWithValue("@dob", dir.DOB);
             cmd.Parameters.AddWithValue("@g", dir.gender ? "m" : "f");
             cmd.Parameters.AddWithValue("@adr", dir.strAddress);
             cmd.Parameters.AddWithValue("@zip", dir.zip);
             cmd.Parameters.AddWithValue("@ps", dir.state);
             cmd.Parameters.AddWithValue("@city", dir.city);
             cmd.Parameters.AddWithValue("@ph1", dir.phoneNum1);
             cmd.Parameters.AddWithValue("@ph2", dir.phoneNum2);
             cmd.Parameters.AddWithValue("@em", dir.emerContact1.name);
             cmd.Parameters.AddWithValue("@emn", dir.emerContact1.phoneNum);
             cmd.Parameters.AddWithValue("@em2", dir.emerContact2.name);
             cmd.Parameters.AddWithValue("@emn2", dir.emerContact2.phoneNum);
             cmd.Parameters.AddWithValue("@pid", dir.patientID);
            string visitors = "$";
             foreach (Visitor v in dir.visitors)
             {
                 visitors = visitors + v.name + "$";
             }
             cmd.Parameters.AddWithValue("@vl", visitors);
             cmd.Parameters.AddWithValue("@bn", dir.location.bedNum);
            
             cmd.ExecuteNonQuery();

        }
        public static void createPatient()
        {
            PatientDirInfo dir = PIMS.Program.currentPatient.directory;
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String cmdText = "INSERT INTO patient VALUES('@pid','@fn','@ln', '@mn'," +
                " '@dob', '@g', '@adr', '@zip', '@ps', '@city', '@ph1', '@ph2', '@em', '@emn', '@em2', '@emn2', " +
                "'@vl')";

            SqlCommand cmd = new SqlCommand(cmdText, cnn);

            cmd.Parameters.AddWithValue("@fn", dir.fName);
            cmd.Parameters.AddWithValue("@ln", dir.lName);
            cmd.Parameters.AddWithValue("@mn", dir.mName);
            cmd.Parameters.AddWithValue("@dob", dir.DOB);
            cmd.Parameters.AddWithValue("@g", dir.gender ? "m" : "f");
            cmd.Parameters.AddWithValue("@adr", dir.strAddress);
            cmd.Parameters.AddWithValue("@zip", dir.zip);
            cmd.Parameters.AddWithValue("@ps", dir.state);
            cmd.Parameters.AddWithValue("@city", dir.city);
            cmd.Parameters.AddWithValue("@ph1", dir.phoneNum1);
            cmd.Parameters.AddWithValue("@ph2", dir.phoneNum2);
            cmd.Parameters.AddWithValue("@em", dir.emerContact1.name);
            cmd.Parameters.AddWithValue("@emn", dir.emerContact1.phoneNum);
            cmd.Parameters.AddWithValue("@em2", dir.emerContact2.name);
            cmd.Parameters.AddWithValue("@emn2", dir.emerContact2.phoneNum);
            cmd.Parameters.AddWithValue("@pid", dir.patientID);
            string visitors = "$";
            foreach (Visitor v in dir.visitors)
            {
                visitors = visitors + v.name + "$";
            }
            cmd.Parameters.AddWithValue("@vl", visitors);
            cmd.Parameters.AddWithValue("@bn", dir.location.bedNum);

            cmd.ExecuteNonQuery();

        }
        static void updateBillingInfo()
        {
            Patient patient = PIMS.Program.currentPatient;
            PatientBillingInfo bill = PIMS.Program.currentPatient.billing;
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String cmdText = "UPDATE Insurance SET provider = @pr, BIN = @bin, ID = @id, " +
                "PCN = @pcn, groupNo = @gn " +
                "WHERE patientID = " + patient.directory.patientID;

            SqlCommand cmd = new SqlCommand(cmdText, cnn);

            cmd.Parameters.AddWithValue("@pr", bill.insurance.provider);
            cmd.Parameters.AddWithValue("@bin", bill.insurance.bin);
            cmd.Parameters.AddWithValue("@id", bill.insurance.id);
            cmd.Parameters.AddWithValue("@pcn", bill.insurance.pcn);
            cmd.Parameters.AddWithValue("@gn", bill.insurance.groupNum);

            cmd.ExecuteNonQuery();

            cmdText = "UPDATE Charges SET item = @item, cost = @c, amountPaid = @ap, " +
                "insurancePaid = @ip, dueDate = @dd WHERE idNum = @id " +
                "if @@ROWCOUNT = 0 INSERT into Charges values('@pid','@item'," +
                "'@c','@ap','@ip','@dd','id')";
                

            foreach (BillingLineItem item in bill.items)
            {
                cmd = new SqlCommand(cmdText, cnn);

                cmd.Parameters.AddWithValue("@item", item.item);
                cmd.Parameters.AddWithValue("@c", item.cost);
                cmd.Parameters.AddWithValue("@ap", item.paid);
                cmd.Parameters.AddWithValue("@ip", item.insPaid);
                cmd.Parameters.AddWithValue("@dd", item.dueDate);
                cmd.Parameters.AddWithValue("@id", item.itemId);

                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
