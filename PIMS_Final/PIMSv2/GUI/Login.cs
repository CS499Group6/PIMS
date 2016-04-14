using System;
using System.Windows.Forms;

namespace PIMS
{
    public partial class Login : UserControl
    {
        // Default Constructor
        public Login()
        {
            InitializeComponent();
        }
        
        // Will log a user into the system
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Addisn the user and password taken from the text box's on the login form
            string user = userNameTextBox.Text;
            string pass = passwordTextBox.Text;

            if (PIMSController.SQLcommands.checkLogin(user, pass))
            {
                if (user != "admin")
                {

                    Program.myForm.splitContainer1.Panel2.Controls.Clear();
                    // Add PatientSearch to Panel2;
                    Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
                }
                else
                {
                    // Clear contents of Panel2
                    Program.myForm.splitContainer1.Panel2.Controls.Clear();
                    // Add AdminForm to Panel2
                    Program.myForm.splitContainer1.Panel2.Controls.Add(new AdminForm());
                }
            }
            else
            {
                Console.WriteLine("login failed");
            }
        }
    }
}
