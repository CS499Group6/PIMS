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

            // Add a new event handler
            passwordTextBox.KeyDown += passwordTextBox_KeyDown;   
        }

        // A key press event has happened
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the key press event was an "Enter" key
            if (e.KeyCode == Keys.Return)
            {
                // Log the uer into the system
                loginButton_Click(sender, e);
            }
        }

        // When the Login form loads into the splitContainer1
        private void Login_Load(object sender, EventArgs e)
        {
            // Set the active control to the userNameTextBox
            this.ActiveControl = userNameTextBox;
        }
        
        // Will log a user into the system
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Assign the user and password taken from the text box's on the login form
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
                    Program.myForm.label2.Text = "Welcome, " + Program.currentUser.name + "!";
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
