using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class AdminForm : UserControl
    {
        // Deafult Constructor
        public AdminForm()
        {
            InitializeComponent();

            this.userTypeComboBox.Items.Add("Doctor");
            this.userTypeComboBox.Items.Add("Medical Staff");
            this.userTypeComboBox.Items.Add("Office Staff");
            this.userTypeComboBox.Items.Add("Volunteer");
        }

        // Will allow the Admin to create a new user
        private void createUserButton_Click(object sender, EventArgs e)
        {
            // Need to implement add user
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            switch(userTypeComboBox.SelectedIndex)
            {
                case 0:
                    //New user is a doctor
                    break;
                case 1:
                    //New user is medical staff
                    break;
                case 2:
                    //New user is office staff
                    break;
                case 3:
                    //New user is a volunteer
                    break;
                default:
                    break;
            }
        }
    }
}
