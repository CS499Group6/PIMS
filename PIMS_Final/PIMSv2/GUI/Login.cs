using System;
using System.Windows.Forms;

namespace PIMS
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Have to assign these to strings before passing them to function
            // or they don't work
            string user = userNameTextBox.Text;
            string pass = passwordTextBox.Text;

            if (PIMSController.SQLcommands.checkLogin(user, pass))
            {
                if (user != "admin")
                {
                    // Clear contents of Panel2
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
