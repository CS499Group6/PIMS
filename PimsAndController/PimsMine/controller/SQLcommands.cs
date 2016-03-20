using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class SQLcommands
    {
        public static List<Patient> patients = null;
        public static List<User> getUserList()
        {
            List<User> users = new List<User>();

            // TODO: replace this list with getting and creating users
            // from SQL information
            User a = new Doctor();
            a.username = "Brandon";
            a.password = "1234";
            User b = new Volunteer();
            b.username = "Ina";
            b.password = "1234";
            User c = new OfficeStaff();
            c.username = "Max";
            c.password = "1234";
            User d = new MedStaff();
            d.username = "Jennifer";
            d.password = "1234";
            User e = new Admin();
            e.username = "Admin";
            e.password = "1234";

            users.Add(a);
            users.Add(b);
            users.Add(c);
            users.Add(d);
            users.Add(e);


            return users;
        }

        public static List<Patient> getPatientList()
        {
            if (patients == null)
            {
                patients = new List<Patient>();

                // TODO: replace with SQL fetching

                Patient a = new Patient();
                Patient b = new Patient();
                Patient c = new Patient();

                patients.Add(a);
                patients.Add(b);
                patients.Add(c);
            }
            return patients;
        }

        public static void updatePatient(Patient patient)
        {
            //TODO: SQL update this patient info
        }
    }
}
