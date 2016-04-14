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
        public static VolunteerLeftSideButtons volunteerLeftSideButton;
        public static OfficeStaffLeftSideButtons officeStaffLeftSideButton;
        public static NewPatientLeftSideButtonscs newPatientLeftSideButtons;

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
            leftSideButton = new LeftSideButtons();
            volunteerLeftSideButton = new VolunteerLeftSideButtons();
            officeStaffLeftSideButton = new OfficeStaffLeftSideButtons();
            newPatientLeftSideButtons = new NewPatientLeftSideButtonscs();

            Application.Run(myForm);
        }
    }
}
