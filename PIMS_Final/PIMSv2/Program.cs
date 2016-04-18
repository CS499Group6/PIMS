using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    static class Program
    {

        public static PIMSController.User currentUser;
        public static PIMSController.Patient currentPatient;
        public static PimsForm myForm;
        public static LeftSideButtons leftSideButton;
        public static OfficeStaffLeftSideButtons officeStaffLeftSideButton;
        public static NewPatientLeftSideButtons newPatientLeftSideButton;
        public static List<PIMS.Controller.Drug> drugs = new List<PIMS.Controller.Drug>();
        public static List<PIMSController.HospLocation> locations = new List<PIMSController.HospLocation>();

        public static string lastNameQuery = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myForm = new PimsForm();
            myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            leftSideButton = new LeftSideButtons();
            officeStaffLeftSideButton = new OfficeStaffLeftSideButtons();
            newPatientLeftSideButton = new NewPatientLeftSideButtons();

            PIMSController.SQLcommands.initValues();

            Application.Run(myForm);
        }
    }
}
