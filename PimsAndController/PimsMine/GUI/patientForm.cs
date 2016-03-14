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
    public partial class patientForm : Form
    {
        PIMSController.User curUser;
        PIMSController.Patient currentPatient;
        public patientForm(PIMSController.Patient patient, PIMSController.User user)
        {
            InitializeComponent();
            curUser = user;

            if(curUser is PIMSController.Volunteer)
            {
                menuStrip1.Enabled = false;
            }
            else if (curUser is PIMSController.OfficeStaff)
            {
                treatmentToolStripMenuItem.Enabled = false;
            }
            else if (curUser is PIMSController.Doctor || curUser is PIMSController.MedStaff)
            {

            }

            currentPatient = patient;
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl != queryBar)
                {
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = SystemColors.Control;
                }
            }

            this.lastNameTextBox.Text = patient.directory.lName;
            this.firstNameTextBox.Text = patient.directory.fName;
            this.middleNameTextBox.Text = patient.directory.mName;
            this.dobTextBox.Text = patient.directory.DOB.ToString(@"MM\/dd\/yyyy");
            if (patient.directory.gender)
                this.genderTextBox.Text = "M";
            else
                this.genderTextBox.Text = "F";
            this.addressTextBox.Text = patient.directory.strAddress;
            this.cityTextBox.Text = patient.directory.city;
            this.stateTextBox.Text = patient.directory.state;
            this.zipTextBox.Text = patient.directory.zip;
            this.primaryPhoneTextBox.Text = patient.directory.phoneNum1;
            this.secondaryPhoneTextBox.Text = patient.directory.phoneNum2;
            this.contactName1TextBox.Text = patient.directory.emerContact1.name;
            this.contactPhone1TextBox.Text = patient.directory.emerContact1.phoneNum;
            this.contactName2TextBox.Text = patient.directory.emerContact2.name;
            this.contactPhone2TextBox.Text = patient.directory.emerContact2.phoneNum;
        }
        //when pressed will close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void patientForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly = false;
                    ((TextBox)ctrl).BackColor = SystemColors.Window;
                }
            }
        }

        private void viewInfoOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl != queryBar)
                {
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = SystemColors.Control;
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorNotesForm theseDocNotes = new doctorNotesForm(currentPatient, curUser);
            theseDocNotes.Visible = true;
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nurseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nurseNotes theseNurseNotes = new nurseNotes(currentPatient, curUser);
            theseNurseNotes.Visible = true;
            this.Hide();
        }
    }
}
