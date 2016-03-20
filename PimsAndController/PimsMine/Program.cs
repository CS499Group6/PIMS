using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimsMain
{
    static class Program
    {
        public static PIMSController.User    currentUser;
        public static PIMSController.Patient currentPatient;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PIMS.loginForm());
        }
    }
}
