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
            string name = nameTextBox.Text;
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            PIMSController.User user;

            switch(userTypeComboBox.SelectedIndex)
            {

                case 0:
                    //New user is a doctor
                    user = new PIMSController.Doctor();
                    user.position = "doc";
                    break;
                case 1:
                    //New user is medical staff
                    user = new PIMSController.MedStaff();
                    user.position = "med";
                    break;
                case 2:
                    //New user is office staff
                    user = new PIMSController.OfficeStaff();
                    user.position = "off";
                    break;
                case 3:
                    //New user is a volunteer
                    user = new PIMSController.Volunteer();
                    user.position = "vol";
                    break;
                default:
                    MessageBox.Show("Error Creating User.\nPlease Try Again");
                    return;
                  
            }

            user.name = name;
            user.username = userName;
            user.password = password;
            user.unit = " ";
            PIMSController.SQLcommands.staffIndex++;
            user.staffID = PIMSController.SQLcommands.staffIndex.ToString();

            PIMSController.SQLcommands.addUser(user);

        }
    }
}
