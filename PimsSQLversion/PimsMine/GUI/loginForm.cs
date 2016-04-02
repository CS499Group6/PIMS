using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        //this code will execute when the form 1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //this code is for the menue bar executes when "File" is clicked
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //This code is for the Exit button under the menue bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*This code executes when the "Login" button is pressed
        when pressed transitions to main form(form2).

        Needs to interface with the database
        ex: check employee id and password match inputs from text box
        */
        private void button1_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            //bool userFound = false;
            //List<PIMSController.User> users = PIMSController.SQLcommands.getUserList();
            if(PIMSController.SQLcommands.checkLogin(username, password))
            {
                mainForm MainForm = new mainForm();
                MainForm.Visible = true;
               //Hide loginForm
                this.Hide();
            }
            else
            {
               MessageBox.Show("Invalid password!\nPlease check your info and try again.",
               "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        //    foreach (PIMSController.User loginUser in users)
        //    {
        //        if(loginUser.username == username)
        //        {
        //            userFound = true;
        //            if(loginUser.password == password)
        //            {
        //                PimsMain.Program.currentUser = loginUser;
                        
        //                //Open MainForm
        //                if(loginUser is PIMSController.Admin)
        //                {
        //                    // TODO: create user screen
        //                }
        //                mainForm MainForm = new mainForm();
        //                MainForm.Visible = true;
        //                //Hide loginForm
        //                this.Hide();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid password!\nPlease check your info and try again.",
        //                "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                break;
        //            }
        //        }
        //    }
        //    {
        //        if (!userFound)
        //        {
        //            MessageBox.Show("User not found!\nPlease check your info and try again.",
        //                "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

    }
    }
}
