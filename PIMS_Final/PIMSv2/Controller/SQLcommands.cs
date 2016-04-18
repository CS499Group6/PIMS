using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PIMSController
{
    public class SQLcommands
    {
        // This specifies the server/db/user to use to login to the SQL db
        static string connectString = "user id=PIMS;password=PIMS;server=146.229.232.110\\PIMS;database=PIMS;Connect Timeout=5;";
        //static string connectString = "Data Source=INA-PC;Initial Catalog=PIMS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        static SqlConnection cnn = new SqlConnection(connectString);

        public static List<Patient> patients = null;

        // Indexes for adding new items to certain tables, these values get initialized to the max value
        // present in their respective tables during the initValues function.
        // Once running, these values represent the max value currently in table.
        public static int statsIndex = 0;
        public static int billIndex = 0;
        public static int drugIndex = 0;
        public static int procIndex = 0;
        public static int patientIndex = 0;
        public static int staffIndex = 0;

        /* 
         *This function gets the max value of the key from the relevant tables
         *and sets the value of the above indexes to those values.
         */
        public static void initValues()
        {
            string staffList = "SELECT max(Cast(staffID as int)) from Staff";
            SqlCommand staffCmd = new SqlCommand(staffList, cnn);
            cnn.Open();
            try
            {
                staffIndex = (int)staffCmd.ExecuteScalar();
            }
            catch
            {
                staffIndex = 9999;
            }


            string drugList = " SELECT * from drugs";
            SqlCommand cmd = new SqlCommand(drugList, cnn);
            SqlDataReader datardr = cmd.ExecuteReader();

            while (datardr.Read())
            {
                PIMS.Controller.Drug d = new PIMS.Controller.Drug();
                d.name = datardr.GetValue(0).ToString();
                d.cost = (int)datardr.GetValue(1);
                PIMS.Program.drugs.Add(d);
            }
            datardr.Close();
            string locList = " SELECT * from location";
            cmd = new SqlCommand(locList, cnn);
            datardr = cmd.ExecuteReader();
            while (datardr.Read())
            {
                HospLocation loc = new HospLocation();
                loc.bedNum = Convert.ToInt32(datardr.GetValue(0).ToString());
                loc.unit = datardr.GetValue(1).ToString();
                loc.floor = Convert.ToInt32(datardr.GetValue(2).ToString());
                loc.roomNum = Convert.ToInt32(datardr.GetValue(3).ToString());
                loc.occupancy = (int)datardr.GetValue(4);

                PIMS.Program.locations.Add(loc);
                Console.WriteLine(loc.unit);
            }
            datardr.Close();
            ////try
            ////{

            string genericStr = "select max(idNum) from ";
            string statsStr = genericStr + "patientStats";
            cmd = new SqlCommand(statsStr, cnn);
            try
            {
                statsIndex = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                statsIndex = 9999;
            }

            string idString = "Select max(patientID) from patient";
            cmd = new SqlCommand(idString, cnn);
            try
            {
                patientIndex = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                patientIndex = 9999;
            }


            string billStr = genericStr + "charges";
            cmd = new SqlCommand(billStr, cnn);
            try
            {
                billIndex = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                billIndex = 9999;
            }


            string drugStr = "Select max(drugID) from prescriptions";
            cmd = new SqlCommand(drugStr, cnn);
            try
            {
                drugIndex = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                drugIndex = 9999;
            }

            string procStr = genericStr + "ScheduledProcedures";
            cmd = new SqlCommand(procStr, cnn);
            procIndex = (int)cmd.ExecuteScalar();
            try
            {
                procIndex = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                procIndex = 9999;
            }

            // cnn.Close();
            // MessageBox.Show("statIndex= " + statsIndex + "\ndrugIndex = " + drugIndex + "\nprocIndex = " + procIndex + "\nbillIndex = " + billIndex + "\npatIndex = " + patientIndex);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Cannot connect to Database.\nPlease try again");
            //    System.Environment.Exit(0);
            //}
        }



        /*
         * This function checks the login username and password entered 
         * against the data in the Staff database table
         * 
         * returns true if match is found, false if no match or 
         * an exception is raised
         */
        public static Boolean checkLogin(string userID, string pwd)
        {
            try
            {
                // SQL query and opening the connection
                string getPWD = "SELECT * from Staff";
                if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                SqlCommand cmd = new SqlCommand(getPWD, cnn);
                SqlDataReader datardr;
                datardr = cmd.ExecuteReader();

                // Checks the value of userID and pwd, creates the program user if they match
                // and returns true if match is found
                while (datardr.Read())
                {
                    if (datardr.GetValue(3).Equals(userID))
                    {
                        if (datardr.GetValue(5).Equals(pwd))
                        {
                            if (datardr.GetValue(2).Equals("doc"))
                                PIMS.Program.currentUser = new Doctor();
                            else if (datardr.GetValue(2).Equals("off"))
                                PIMS.Program.currentUser = new OfficeStaff();
                            else if (datardr.GetValue(2).Equals("med"))
                                PIMS.Program.currentUser = new MedStaff();
                            else if (datardr.GetValue(2).Equals("vol"))
                                PIMS.Program.currentUser = new Volunteer();
                            else if (datardr.GetValue(2).Equals("admin"))
                                PIMS.Program.currentUser = new Admin();
                            PIMS.Program.currentUser.name = datardr.GetValue(1).ToString();

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
            catch (Exception ex)
            {
                return false;
            }

        }

        /* Takes int bedid for the bed number being queried for
         * create a room object to return
         */
        public static HospLocation buildHospital(int bedID)
        {

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("getLocations", cnn);
            SqlDataReader rdr;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            HospLocation current = new HospLocation();
            current.bedNum = bedID;
            cmd.Parameters.AddWithValue("@bedNum", bedID);

            //Create a SqlParameter object to hold the output parameter value
            SqlParameter units = new SqlParameter();
            units.ParameterName = "@unit";
            units.SqlDbType = System.Data.SqlDbType.VarChar;
            units.Size = 15;
            units.Direction = System.Data.ParameterDirection.Output;
            units.Value = current.unit;
            cmd.Parameters.Add(units);

            SqlParameter floorN = new SqlParameter();
            floorN.ParameterName = "@floorNum";
            floorN.SqlDbType = System.Data.SqlDbType.Int;
            floorN.Direction = System.Data.ParameterDirection.Output;
            floorN.Value = current.floor;
            cmd.Parameters.Add(floorN);

            SqlParameter roomN = new SqlParameter();
            roomN.ParameterName = "@roomNum";
            roomN.SqlDbType = System.Data.SqlDbType.Int;
            roomN.Direction = System.Data.ParameterDirection.Output;
            roomN.Value = current.roomNum;
            cmd.Parameters.Add(roomN);

            SqlParameter occup = new SqlParameter();
            occup.ParameterName = "@occupants";
            occup.SqlDbType = System.Data.SqlDbType.Int;
            occup.Direction = System.Data.ParameterDirection.Output;
            occup.Value = current.occupancy;
            cmd.Parameters.Add(occup);

            rdr = cmd.ExecuteReader();
            current.unit = Convert.ToString(units.Value);
            current.floor = Convert.ToInt32(floorN.Value);
            current.roomNum = Convert.ToInt32(roomN.Value);
            current.occupancy = Convert.ToInt32(occup.Value);


            cmd.Parameters.Clear();
            rdr.Close();

            cnn.Close();
            return current;

        }

        /*
         * Takes a patient object and uses that patient's location information
         * sents the current patients room information into the database
         */
        public static void updatePatientLocation(Patient A)
        {
             Console.WriteLine("UPDATING LOCATION");
            //create patientid 
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            SqlCommand cmd;
            cmd = new SqlCommand("UpdateLocation", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bed", A.directory.location.bedNum);
            cmd.Parameters.AddWithValue("@patientID", A.directory.patientID);

            cmd.ExecuteReader();
            cmd.Parameters.Clear();
            cnn.Close();

        }//end update location

        /*
        * Takes a patient object and uses that patient's location information
        * sents the current patients room information into the database
        * 
        */
        public static void dischargePatientLocation(Patient A)
        {
            Console.WriteLine("UPDATING LOCATION");
            //create patientid 
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            SqlCommand cmd;
            cmd = new SqlCommand("UpdateLocation", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bed", A.directory.location.bedNum);
            cmd.Parameters.AddWithValue("@patientID", A.directory.patientID);

            cmd.ExecuteReader();
            cmd.Parameters.Clear();
            cnn.Close();

        }//end discharge patient

        // This function queries the SQL server and builds the patient requested by the 
        // PatientID according to the type of user currently logged in
        public static Patient buildPatient(string patientID)
        {
            //try
            //{
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
                    x.directory.patientID = datardr.GetValue(0).ToString();
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
                    if (g.Equals("m") || g.Equals("M"))
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
                if (datardr.GetValue(15) != System.DBNull.Value)
                    x.directory.workphone = datardr.GetValue(18).ToString();
                if (datardr.GetValue(18) != System.DBNull.Value)
                {
                    string unparsedNames = (String)datardr.GetValue(16);
                    string[] visitors = unparsedNames.Split('$');
                    foreach (string vis in visitors)
                    {
                        Visitor v = new Visitor();
                        v.name = vis;
                        if (!v.name.Equals(""))
                            x.directory.visitors.Add(v);
                    }

                }
                if (!(datardr.GetValue(17) == (System.DBNull.Value)))
                    x.directory.location.bedNum = (int)datardr.GetValue(17);
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
                while (datardr.Read())
                {
                    if (datardr.GetValue(1) != System.DBNull.Value)
                        x.directory.location.unit = (String)datardr.GetValue(1);
                    if (datardr.GetValue(2) != System.DBNull.Value)
                        x.directory.location.floor = (int)datardr.GetValue(2);
                    if (datardr.GetValue(3) != System.DBNull.Value)
                        x.directory.location.roomNum = (int)datardr.GetValue(3);
                    if (datardr.GetValue(4) != System.DBNull.Value)
                        x.directory.location.occupancy = (int)datardr.GetValue(4);
                }
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
                if (datardr.GetValue(1) != System.DBNull.Value)
                    item.item = (String)datardr.GetValue(2);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    item.cost = (int)datardr.GetValue(3);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    item.paid = (int)datardr.GetValue(4);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    item.insPaid = (int)datardr.GetValue(5);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    item.dueDate = (DateTime)datardr.GetValue(6);
                if (datardr.GetValue(6) != System.DBNull.Value)
                    item.itemId = (int)datardr.GetValue(1);
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
                if (datardr.GetValue(6) != System.DBNull.Value)
                    x.billing.insurance.insuranceType = (String)datardr.GetValue(6);
            }
            datardr.Close();


            // if user is office staff, this is all the info we need
            if (PIMS.Program.currentUser is OfficeStaff)
            {
                return x;
            }

            // fill the treatment data since the user at this point is a doc or nurse
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String getTreatmentInfo = "SELECT * from Treatment where patientID = " + patientID;
            cmd = new SqlCommand(getTreatmentInfo, cnn);
            datardr = cmd.ExecuteReader();
            while (datardr.Read())
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
                if (datardr.GetValue(10) != System.DBNull.Value)
                    x.treatment.reasonDischarged = (String)datardr.GetValue(10);
                if (datardr.GetValue(11) != System.DBNull.Value)
                    x.treatment.diagnosis = (String)datardr.GetValue(11);
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
                if (datardr.GetValue(7) != System.DBNull.Value)
                    stats.idNum = (int)datardr.GetValue(7);
                if (datardr.GetValue(6) != System.DBNull.Value)
                {
                    stats.time = (DateTime)datardr.GetValue(6);
                }
                if (datardr.GetValue(8) != System.DBNull.Value)
                    stats.nurse = (string)datardr.GetValue(8);
                else
                    stats.nurse = "";


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

                if (datardr.GetValue(0) != System.DBNull.Value)
                    drug.id = (int)datardr.GetValue(0);
                if (datardr.GetValue(1) != System.DBNull.Value)
                    drug.drug.name = (String)datardr.GetValue(1);
                if (datardr.GetValue(2) != System.DBNull.Value)
                    drug.ndc = (String)datardr.GetValue(2);
                if (datardr.GetValue(3) != System.DBNull.Value)
                    drug.SIG = (String)datardr.GetValue(3);
                if (datardr.GetValue(4) != System.DBNull.Value)
                    drug.prescribingPhysician = (String)datardr.GetValue(4);
                if (datardr.GetValue(5) != System.DBNull.Value)
                    drug.dateFilled = (DateTime)datardr.GetValue(5);
                if (datardr.GetValue(6) != System.DBNull.Value)
                    drug.drug.cost = (int)datardr.GetValue(6);

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
                if (datardr.GetValue(5) != System.DBNull.Value)
                    proc.id = (int)datardr.GetValue(5);

                x.treatment.procedures.Add(proc);

            }


            return x;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error retrieving patient information.\nPlease try again");
            //    return null;
            //}
        }


        // This function builds the patient list from the db to allow the search to happen
        public static List<Patient> getPatientList()
        {
            string getPatList = "SELECT * from Patient";
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(getPatList, cnn);
            SqlDataReader datardr;
            patients = new List<Patient>();
            datardr = cmd.ExecuteReader();

            while (datardr.Read())
            {
                Patient x = new Patient();
                if (datardr.GetValue(0) != System.DBNull.Value)
                    x.directory.patientID = datardr.GetValue(0).ToString();
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
                    if (g.Equals("m") || g.Equals("M"))
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
                if (datardr.GetValue(18) != System.DBNull.Value)
                    x.directory.workphone = datardr.GetValue(18).ToString();
                if (datardr.GetValue(16) != System.DBNull.Value)
                {
                    string unparsedNames = (String)datardr.GetValue(16);
                    string[] visitors = unparsedNames.Split('$');
                    foreach (string vis in visitors)
                    {
                        Visitor v = new Visitor();
                        v.name = vis;
                        if (!v.name.Equals(""))
                            x.directory.visitors.Add(v);
                    }
                }
                if (!(datardr.GetValue(17).Equals(System.DBNull.Value)))
                    x.directory.location.bedNum = (int)datardr.GetValue(17);



                patients.Add(x);

            }

            foreach (PIMSController.Patient x in patients)
            {
                if (x.directory.location.bedNum != null)
                {
                    string getLocInfo = "SELECT * from Location where bedNo = " + x.directory.location.bedNum;
                    if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                        cnn.Close();
                    cnn.Open();
                    cmd = new SqlCommand(getLocInfo, cnn);
                    datardr = cmd.ExecuteReader();
                    while (datardr.Read())
                    {
                        if (datardr.GetValue(1) != System.DBNull.Value)
                            x.directory.location.unit = (String)datardr.GetValue(1);
                        if (datardr.GetValue(2) != System.DBNull.Value)
                            x.directory.location.floor = (int)datardr.GetValue(2);
                        if (datardr.GetValue(3) != System.DBNull.Value)
                            x.directory.location.roomNum = (int)datardr.GetValue(3);
                        if (datardr.GetValue(4) != System.DBNull.Value)
                            x.directory.location.occupancy = (int)datardr.GetValue(4);
                    }
                }
            }

            return patients;
        }

        public static void updatePatient()
        {
            // Volunteers can't update info, so exit if current user is a volunteer
            if (PIMS.Program.currentUser is Volunteer)
            {
                return;
            }

            // only office staff can update billing and directory info
            if (PIMS.Program.currentUser is OfficeStaff)
            {
                // Start with directory updates
                updatePatientDirInfo();
                updateBillingInfo();
            }

            // med Staff/ Doctors update here
            if (PIMS.Program.currentUser is MedStaff || PIMS.Program.currentUser is Doctor)
            {
                updateTreatmentInfo();
            }
        }

        static void updatePatientDirInfo()
        {
            //try
            //{
                PatientDirInfo dir = PIMS.Program.currentPatient.directory;
                if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                String cmdText = /*"IF NOT EXISTS(SELECT firstName from Patient where  PatientID = @pid) " +
                                 "INSERT INTO  patient values('@fn', '@ln','@mn', " +
                                 "'@dob', '@g', '@adr', '@zip', '@ps', '@city', '@ph1', '@ph2', " +
                                 "'@em', '@emn', '@em2', '@emn2', '@vl', '@bn')" +
                                 "else " +*/
                                 " UPDATE  patient SET firstName = @fn, lastName = @ln, middleName = @mn," +
                                 "DOB = @dob, gender = @g, patientAddress = @adr, patientZip = @zip, patientState = @ps," +
                                 "patientCity = @city, phone1 = @ph1, phone2 = @ph2,emergencyName = @em, emergencyNumber = @emn, " +
                                 "emergencyName2 = @em2, emergencyNumber2 = @emn2, visitorList = @vl, bedNo = @bn  WHERE PatientID=@pid";


                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@pid", dir.patientID);
                cmd.Parameters.AddWithValue("@fn", dir.fName);
                cmd.Parameters.AddWithValue("@ln", dir.lName);
                if (dir.mName == null || dir.mName == "")
                    cmd.Parameters.AddWithValue("@mn", System.DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@mn", dir.mName);
                cmd.Parameters.AddWithValue("@dob", dir.DOB);
                cmd.Parameters.AddWithValue("@g", dir.gender ? "M" : "F");
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
                string visitors = "$";
                foreach (Visitor v in dir.visitors)
                {
                    visitors = visitors + v.name + "$";
                }
                cmd.Parameters.AddWithValue("@vl", visitors);
                if (dir.location.bedNum == null)
                    cmd.Parameters.AddWithValue("@bn", System.DBNull.Value);
                else cmd.Parameters.AddWithValue("@bn", dir.location.bedNum);

                cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error updating Patient Information.\nPlease try again.");
            //}

        }

        static void updateBillingInfo()
        {
            //try
            //{
            Patient patient = PIMS.Program.currentPatient;
            PatientBillingInfo bill = PIMS.Program.currentPatient.billing;
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            //Updates insurance information
            String cmdText = "IF NOT EXISTS(SELECT patientID from Insurance where patientID = @pid) " +
                             " INSERT INTO Insurance values(@pid, @pr, @bin, @id, @pcn, @gn, @type) " +
                             "else " +
                             "UPDATE Insurance SET provider = @pr, BIN = @bin, ID = @id, " +
                             "PCN = @pcn, groupNo = @gn, insuranceType = @type " +
                             "WHERE patientID = @pid ";

            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@pid", patient.directory.patientID);

            if (bill.insurance.provider == null)
                cmd.Parameters.AddWithValue("@pr", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@pr", bill.insurance.provider);

            if (bill.insurance.bin == null)
                cmd.Parameters.AddWithValue("@bin", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@bin", bill.insurance.bin);

            if (bill.insurance.id == null)
                cmd.Parameters.AddWithValue("@id", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@id", bill.insurance.id);

            if (bill.insurance.pcn == null)
                cmd.Parameters.AddWithValue("@pcn", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@pcn", bill.insurance.pcn);

            if (bill.insurance.groupNum == null)
                cmd.Parameters.AddWithValue("@gn", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@gn", bill.insurance.groupNum);

            if (bill.insurance.insuranceType == null)
                cmd.Parameters.AddWithValue("@type", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@type", bill.insurance.insuranceType);

            cmd.ExecuteNonQuery();


            // Updates billing address

            cmdText = "IF NOT EXISTS(SELECT billingAddress from BillingAddress where patientID = @pid) " +
                      "INSERT INTO BillingAddress values(@pid, @ba, @bc, @bs, @bz) " +
                      "else " +
                      "UPDATE billingAddress SET billingAddress = @ba, billingCity = @bc, " +
                      "billingState = @bs, billingZip = @bz WHERE patientID = @pid ";
            cmd = new SqlCommand(cmdText, cnn);

            cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
            if (bill.strAddress == null)
                cmd.Parameters.AddWithValue("@ba", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ba", bill.strAddress);
            if (bill.city == null)
                cmd.Parameters.AddWithValue("@bc", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@bc", bill.city);
            if (bill.state == null)
                cmd.Parameters.AddWithValue("@bs", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@bs", bill.state);
            if (bill.zip == null)
                cmd.Parameters.AddWithValue("@bz", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@bz", bill.zip);

            cmd.ExecuteNonQuery();


            cmdText = "IF NOT EXISTS(SELECT item from charges where  idNum = @id) " +
                      "INSERT INTO  Charges values(@pid, @id, @item, " +
                      "@c, @ap, @ip, @dd)" +
                      "else " +
                      " UPDATE  Charges SET item = @item, cost = @c, amountPaid = @ap, " +
                      "insurancePaid = @ip, dueDate = @dd WHERE idNum = @id ";


            foreach (BillingLineItem item in bill.items)
            {
                billIndex++;

                cmd = new SqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@item", item.item);
                cmd.Parameters.AddWithValue("@c", item.cost);
                cmd.Parameters.AddWithValue("@ap", item.paid);
                cmd.Parameters.AddWithValue("@ip", item.insPaid);
                cmd.Parameters.AddWithValue("@dd", item.dueDate);
                if (item.itemId == 0)
                {
                    billIndex++;
                    item.itemId = billIndex;
                }
                cmd.Parameters.AddWithValue("@id", item.itemId);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error updating billing information.\nPlease try again.");
            //}333332
        }

        static void updateTreatmentInfo()
        {
            //try
            //{
            PatientTreatmentInfo info = PIMS.Program.currentPatient.treatment;

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String cmdText = "IF NOT EXISTS(SELECT patientID from treatment where patientID = @pid) " +
                             "INSERT INTO  treatment values(@pid, convert(datetime,ISNULL(@da, '1-1-1970 0:00'))," +
                             "@r, convert(datetime,ISNULL(@dd, '1-1-1970 0:00')), @pd, @dn, @a, @x, @x, @mn)" +
                             "else " +
                             " UPDATE treatment SET dateAdmitted = convert(datetime,ISNULL(@da, '1-1-1970 0:00')), reason = @r, dateDischarged = convert(datetime, ISNULL(@dd, '1-1-1970 0:00'))," +
                             " primaryDoctor = @pd, doctorNotes = @dn, allergies = @a, medStaffNotes = @mn" +
                             " WHERE patientID = @pid";

            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            if (info.dateAdmitted != null)
                cmd.Parameters.AddWithValue("@da", info.dateAdmitted.ToString());
            else cmd.Parameters.AddWithValue("@da", System.DBNull.Value.ToString());
           
            if (info.reasonAdmitted != null)
                cmd.Parameters.AddWithValue("@r", info.reasonAdmitted);
            else cmd.Parameters.AddWithValue("@r", System.DBNull.Value);

            if (info.dateDischarged != null)
                cmd.Parameters.AddWithValue("@dd", info.dateDischarged.ToString());
            else cmd.Parameters.AddWithValue("@dd", System.DBNull.Value.ToString());

            if (info.primaryDoc != null)
                cmd.Parameters.AddWithValue("@pd", info.primaryDoc);
            else cmd.Parameters.AddWithValue("@pd", System.DBNull.Value);

            if (info.docNotes != null)
                cmd.Parameters.AddWithValue("@dn", info.docNotes);
            else cmd.Parameters.AddWithValue("@dn", System.DBNull.Value);

            if (info.medStaffNotes.allergies != null)
                cmd.Parameters.AddWithValue("@a", info.medStaffNotes.allergies);
            else cmd.Parameters.AddWithValue("@a", System.DBNull.Value);

            if (info.medStaffNotes.nurseNotes != null)
                cmd.Parameters.AddWithValue("@mn", info.medStaffNotes.nurseNotes);
            else cmd.Parameters.AddWithValue("@mn", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@x", System.DBNull.Value);
            cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);

            cmd.ExecuteNonQuery();


            Console.WriteLine("updated treatment");



            cmdText = "IF NOT EXISTS(SELECT location from ScheduledProcedures where idNum = @idn) " +
                      "INSERT INTO  ScheduledProcedures Values(@pid, @what, convert(datetime, @when)," +
                             " @who, @whr, @idn) " +
                       "else " +
                       "UPDATE ScheduledProcedures SET scheduledProcedure = @what, whenScheduled = convert(datetime, @when), " +
                             " patientId = @pid, performedBy = @who, location = @whr WHERE idNum = @idn";
            cmd = new SqlCommand(cmdText, cnn);
            foreach (MedProcedure proc in info.procedures)
            {

                cmd.Parameters.AddWithValue("@what", proc.what);
                Console.WriteLine(proc.when.ToString());
                cmd.Parameters.AddWithValue("@when", proc.when.ToString());
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@who", proc.who);
                cmd.Parameters.AddWithValue("@whr", proc.where);
                if (proc.id == 0)
                {
                    procIndex++;
                    proc.id = procIndex;
                }
                cmd.Parameters.AddWithValue("@idn", proc.id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            Console.WriteLine("updated procedures");


            cmdText = "IF NOT EXISTS (SELECT drugName from Prescriptions where drugID = @did) " +
                      " INSERT INTO Prescriptions Values(@did, @dn, @ndc, @sig, @pp, @pd, @c, @pid) " +
                      " ELSE " +
                      " UPDATE prescriptions SET patientID = @pid, drugName = @dn, NDC = @ndc, " +
                      "SIG = @sig, prescribingPhysician = @pp, prescribedDate = convert(datetime, @pd), cost = @c " +
                      " WHERE drugID = @did ";

            cmd = new SqlCommand(cmdText, cnn);
            foreach (PrescDrug drug in info.prescriptions.prescriptions)
            {
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@dn", drug.drug.name);
                cmd.Parameters.AddWithValue("@ndc", drug.ndc);
                cmd.Parameters.AddWithValue("@sig", drug.SIG);
                cmd.Parameters.AddWithValue("@pp", drug.prescribingPhysician);
                cmd.Parameters.AddWithValue("@pd", drug.dateFilled);
                cmd.Parameters.AddWithValue("@c", drug.drug.cost);
                if (drug.id == 0)
                {
                    drugIndex++;
                    drug.id = drugIndex;
                }
                cmd.Parameters.AddWithValue("@did", drug.id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            Console.WriteLine("updated drugs");

            cmdText = "IF NOT EXISTS(SELECT pHeight from patientStats where idNum = @idNum) " +
                      "INSERT INTO patientStats " +
                      "values(@pid, @ph , @pw ,  @sp ,  @dp ,  @hr , @t, @idNum , @n) " +
                      "else " +
                      "UPDATE patientStats SET patientID = @pid, pHeight = @ph, pWeight = @pw, " +
                      "systolicPressure = @sp, diastolicPressure = @dp, heartRate = @hr, " +
                      "timeRead = @t, nurse = @n WHERE idNum = @idNum";



            cmd = new SqlCommand(cmdText, cnn);

            foreach (MedStaffNotes.patientStats stats in info.medStaffNotes.statList)
            {
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@ph", stats.patientHeight);
                cmd.Parameters.AddWithValue("@pw", stats.patientWeight);
                cmd.Parameters.AddWithValue("@sp", stats.bloodPressureSys);
                cmd.Parameters.AddWithValue("@dp", stats.bloodPressureDia);
                cmd.Parameters.AddWithValue("@hr", stats.heartrate);
                cmd.Parameters.AddWithValue("@t", stats.time.Date);
                cmd.Parameters.AddWithValue("@n", stats.nurse);

                if (stats.idNum == 0)
                {
                    statsIndex++;
                    cmd.Parameters.AddWithValue("@idNum", statsIndex);
                }
                else cmd.Parameters.AddWithValue("@idNum", stats.idNum);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            //}
            //catch (Exception ex)
            //{

            //}
        }

        static void updateTreatmentInfo()
        {
            //try
            //{
            PatientTreatmentInfo info = PIMS.Program.currentPatient.treatment;

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            String cmdText = "IF NOT EXISTS(SELECT patientID from treatment where patientID = @pid) " +
                             "INSERT INTO  treatment values(@pid, convert(datetime,ISNULL(@da, '1-1-1970 0:00'))," +
                             "@r, convert(datetime,ISNULL(@dd, '1-1-1970 0:00')), @pd, @dn, @a, @x, @x, @mn, @dreason, @dia)" +
                             "else " +
                             " UPDATE treatment SET dateAdmitted = convert(datetime,ISNULL(@da, '1-1-1970 0:00')), reason = @r, dateDischarged = convert(datetime, ISNULL(@dd, '1-1-1970 0:00'))," +
                             " primaryDoctor = @pd, doctorNotes = @dn, allergies = @a, medStaffNotes = @mn, dischargeReason = @dreason, diagnosis = @dia" +
                             " WHERE patientID = @pid";

            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            if (info.dateAdmitted != null)
                cmd.Parameters.AddWithValue("@da", info.dateAdmitted.ToString());
            else cmd.Parameters.AddWithValue("@da", System.DBNull.Value.ToString());

            if (info.reasonAdmitted != null)
                cmd.Parameters.AddWithValue("@r", info.reasonAdmitted);
            else cmd.Parameters.AddWithValue("@r", System.DBNull.Value);

            if (info.dateDischarged != null)
                cmd.Parameters.AddWithValue("@dd", info.dateDischarged.ToString());
            else cmd.Parameters.AddWithValue("@dd", System.DBNull.Value.ToString());

            if (info.primaryDoc != null)
                cmd.Parameters.AddWithValue("@pd", info.primaryDoc);
            else cmd.Parameters.AddWithValue("@pd", System.DBNull.Value);

            if (info.docNotes != null)
                cmd.Parameters.AddWithValue("@dn", info.docNotes);
            else cmd.Parameters.AddWithValue("@dn", System.DBNull.Value);

            if (info.medStaffNotes.allergies != null)
                cmd.Parameters.AddWithValue("@a", info.medStaffNotes.allergies);
            else cmd.Parameters.AddWithValue("@a", System.DBNull.Value);

            if (info.medStaffNotes.nurseNotes != null)
                cmd.Parameters.AddWithValue("@mn", info.medStaffNotes.nurseNotes);
            else cmd.Parameters.AddWithValue("@mn", System.DBNull.Value);

            if (info.diagnosis != null)
                cmd.Parameters.AddWithValue("@dia", info.diagnosis);
            else cmd.Parameters.AddWithValue("@dia", System.DBNull.Value);

            if (info.reasonDischarged != null)
                cmd.Parameters.AddWithValue("@dreason", info.reasonDischarged);
            else cmd.Parameters.AddWithValue("@dreason", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@x", System.DBNull.Value);
            cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);

            cmd.ExecuteNonQuery();


            Console.WriteLine("updated treatment");



            cmdText = "IF NOT EXISTS(SELECT location from ScheduledProcedures where idNum = @idn) " +
                      "INSERT INTO  ScheduledProcedures Values(@pid, @what, convert(datetime, @when)," +
                             " @who, @whr, @idn) " +
                       "else " +
                       "UPDATE ScheduledProcedures SET scheduledProcedure = @what, whenScheduled = convert(datetime, @when), " +
                             " patientId = @pid, performedBy = @who, location = @whr WHERE idNum = @idn";
            cmd = new SqlCommand(cmdText, cnn);
            foreach (MedProcedure proc in info.procedures)
            {

                cmd.Parameters.AddWithValue("@what", proc.what);
                Console.WriteLine(proc.when.ToString());
                cmd.Parameters.AddWithValue("@when", proc.when.ToString());
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@who", proc.who);
                cmd.Parameters.AddWithValue("@whr", proc.where);
                if (proc.id == 0)
                {
                    procIndex++;
                    proc.id = procIndex;
                }
                cmd.Parameters.AddWithValue("@idn", proc.id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            Console.WriteLine("updated procedures");


            cmdText = "IF NOT EXISTS (SELECT drugName from Prescriptions where drugID = @did) " +
                      " INSERT INTO Prescriptions Values(@did, @dn, @ndc, @sig, @pp, @pd, @c, @pid) " +
                      " ELSE " +
                      " UPDATE prescriptions SET patientID = @pid, drugName = @dn, NDC = @ndc, " +
                      "SIG = @sig, prescribingPhysician = @pp, prescribedDate = convert(datetime, @pd), cost = @c " +
                      " WHERE drugID = @did ";

            cmd = new SqlCommand(cmdText, cnn);
            foreach (PrescDrug drug in info.prescriptions.prescriptions)
            {
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@dn", drug.drug.name);
                cmd.Parameters.AddWithValue("@ndc", drug.ndc);
                cmd.Parameters.AddWithValue("@sig", drug.SIG);
                cmd.Parameters.AddWithValue("@pp", drug.prescribingPhysician);
                cmd.Parameters.AddWithValue("@pd", drug.dateFilled);
                cmd.Parameters.AddWithValue("@c", drug.drug.cost);
                if (drug.id == 0)
                {
                    drugIndex++;
                    drug.id = drugIndex;
                }
                cmd.Parameters.AddWithValue("@did", drug.id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            Console.WriteLine("updated drugs");

            cmdText = "IF NOT EXISTS(SELECT pHeight from patientStats where idNum = @idNum) " +
                      "INSERT INTO patientStats " +
                      "values(@pid, @ph , @pw ,  @sp ,  @dp ,  @hr , @t, @idNum , @n) " +
                      "else " +
                      "UPDATE patientStats SET patientID = @pid, pHeight = @ph, pWeight = @pw, " +
                      "systolicPressure = @sp, diastolicPressure = @dp, heartRate = @hr, " +
                      "timeRead = @t, nurse = @n WHERE idNum = @idNum";



            cmd = new SqlCommand(cmdText, cnn);

            foreach (MedStaffNotes.patientStats stats in info.medStaffNotes.statList)
            {
                cmd.Parameters.AddWithValue("@pid", PIMS.Program.currentPatient.directory.patientID);
                cmd.Parameters.AddWithValue("@ph", stats.patientHeight);
                cmd.Parameters.AddWithValue("@pw", stats.patientWeight);
                cmd.Parameters.AddWithValue("@sp", stats.bloodPressureSys);
                cmd.Parameters.AddWithValue("@dp", stats.bloodPressureDia);
                cmd.Parameters.AddWithValue("@hr", stats.heartrate);
                cmd.Parameters.AddWithValue("@t", stats.time.Date);
                cmd.Parameters.AddWithValue("@n", stats.nurse);

                if (stats.idNum == 0)
                {
                    statsIndex++;
                    cmd.Parameters.AddWithValue("@idNum", statsIndex);
                }
                else cmd.Parameters.AddWithValue("@idNum", stats.idNum);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            //}
            //catch (Exception ex)
            //{

            //}
        }

        //Takes Patient object and creates a new patient using the patient object
        //Returns database generated patientID as a string
        public static String insertNewPatient(Patient P)
        {
            Console.WriteLine("CREATING PATIENT");
            //create patientid 
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            SqlCommand cmd;
            cmd = new SqlCommand("CreatePatient", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", P.directory.fName);
            cmd.Parameters.AddWithValue("@mname", P.directory.lName);
            cmd.Parameters.AddWithValue("@lname", P.directory.mName);
            cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(P.directory.DOB.Date.ToShortDateString()));
            cmd.Parameters.AddWithValue("@gender", P.directory.gender ? "M" : "F");
            cmd.Parameters.AddWithValue("@patientAddress", P.directory.strAddress);
            cmd.Parameters.AddWithValue("@patientZip", P.directory.zip);
            cmd.Parameters.AddWithValue("@patientState", P.directory.state);
            cmd.Parameters.AddWithValue("@patientCity", P.directory.city);
            cmd.Parameters.AddWithValue("@phone1", P.directory.phoneNum1);
            cmd.Parameters.AddWithValue("@phone2", P.directory.phoneNum2);
            cmd.Parameters.AddWithValue("@work", P.directory.workphone);
            cmd.Parameters.AddWithValue("@emergencyName", P.directory.emerContact1.name);
            cmd.Parameters.AddWithValue("@emergencyNum", P.directory.emerContact1.phoneNum);
            cmd.Parameters.AddWithValue("@emergencyName2", P.directory.emerContact2.name);
            cmd.Parameters.AddWithValue("@emergencyNum2", P.directory.emerContact2.phoneNum);
            cmd.Parameters.AddWithValue("@visitorList", P.directory.fName);
            cmd.Parameters.AddWithValue("@patientID", P.directory.patientID);

            cmd.ExecuteReader();
            cmd.Parameters.Clear();
            cnn.Close();
            return P.directory.patientID.ToString();
            //   return id.ToString();

        }//end create patient
        public static void addUser(User user)
        {

            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            string cmdText = //"IF NOT EXISTS(SELECT userid from Staff where userid = @uid) " +
                      "INSERT INTO Staff values(@sid, @sn, @pos, @uid, @unit, @pw) ";


            SqlCommand cmd = new SqlCommand(cmdText, cnn);

            cmd.Parameters.AddWithValue("@sid", user.staffID);
            cmd.Parameters.AddWithValue("@sn", user.name);
            cmd.Parameters.AddWithValue("@pos", user.position);
            cmd.Parameters.AddWithValue("@unit", user.unit);
            cmd.Parameters.AddWithValue("@uid", user.username);
            cmd.Parameters.AddWithValue("@pw", user.password);

            cmd.ExecuteNonQuery();
        }
    }
}



