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
        PIMSController.Patient patient;


        public patientForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            curUser = PimsMain.Program.currentUser;
            patient = PimsMain.Program.currentPatient;

            if (curUser is PIMSController.Doctor ||
                curUser is PIMSController.MedStaff)
            {
                editToolStripMenuItem.Enabled = false;
                treatmentToolStripMenuItem.Enabled = true;
                billingToolStripMenuItem.Enabled = true;
                button1.Visible = false;
            }
            else if(curUser is PIMSController.OfficeStaff)
            {
                editToolStripMenuItem.Enabled = true;
                treatmentToolStripMenuItem.Enabled = false;
                billingToolStripMenuItem.Enabled = true;
            }
            else
            {
                // Shouldn't ever happen, but just in case
                MessageBox.Show("Invalid User! Closing Program",
                     "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // currentPatient = patient;
           // currentPatient = PimsMain.Program.currentPatient;
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

        public patientForm(bool isNew)
       {
            InitializeComponent();
            this.ControlBox = false;
            curUser = PimsMain.Program.currentUser;
            patient = new PIMSController.Patient();
            PimsMain.Program.currentPatient = patient;


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
            doctorNotesForm theseDocNotes = new doctorNotesForm();
            theseDocNotes.Visible = true;
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nurseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nurseNotes theseNurseNotes = new nurseNotes();
            theseNurseNotes.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PIMSController.Patient patient = PimsMain.Program.currentPatient;

            patient.directory.lName = lastNameTextBox.Text;
            patient.directory.fName = firstNameTextBox.Text;
            patient.directory.mName = middleNameTextBox.Text;
            patient.directory.DOB = Convert.ToDateTime(dobTextBox.Text);
            if (patient.directory.gender)
                this.genderTextBox.Text = "M";
            else
                this.genderTextBox.Text = "F";
            if (genderTextBox.Text.ToUpper() == "M")
                patient.directory.gender = true;
            else if (genderTextBox.Text.ToUpper() == "F")
                patient.directory.gender = false;
            patient.directory.strAddress = addressTextBox.Text;
            patient.directory.city = cityTextBox.Text;
            patient.directory.state = stateTextBox.Text;
            patient.directory.zip = zipTextBox.Text;
            patient.directory.phoneNum1 = primaryPhoneTextBox.Text;

            patient.directory.phoneNum2 = secondaryPhoneTextBox.Text;
            patient.directory.emerContact1.name = contactName1TextBox.Text;
            patient.directory.emerContact1.phoneNum = contactPhone1TextBox.Text;
            patient.directory.emerContact2.name = contactName2TextBox.Text;
            patient.directory.emerContact2.phoneNum = contactPhone2TextBox.Text;

            PIMSController.SQLcommands.updatePatient(patient);
        }

        private void insuranceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insuranceForm insForm = new insuranceForm();
            insForm.Visible = true;
            // hide this one
            this.Hide();

        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionGrid drugs = new prescriptionGrid();
            drugs.Visible = true;
            this.Hide();
        }

        private void scheduledProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.GUI.SchedProcForm procForm = new PimsMain.GUI.SchedProcForm();
            procForm.Visible = true;
            this.Hide();
        }

        private void detailedBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid();
            sumBill.Visible = true;
            this.Hide();
        }

        private void summaryBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid(false);
            sumBill.Visible = true;
            this.Hide();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String lastNameQuery = queryBar.Text.ToUpper();
            PimsMain.Program.currentPatient = null;
            //Open MainGrid
            if (PimsMain.Program.currentUser is PIMSController.Volunteer)
            {
                volunteerGrid volGrid = new volunteerGrid(lastNameQuery);
                volGrid.Visible = true;
                this.Hide();
            }
            else if (PimsMain.Program.currentUser is PIMSController.Doctor ||
                    PimsMain.Program.currentUser is PIMSController.MedStaff ||
                    PimsMain.Program.currentUser is PIMSController.OfficeStaff)
            {
                mainGrid MainGrid = new mainGrid(lastNameQuery);
                MainGrid.Visible = true;
                //Hide mainForm
                this.Hide();
            }
            else
            {
                // This case should not happen, but here just in case
                MessageBox.Show("Invalid User! Closing Program",
                        "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorsGrid visitors = new visitorsGrid();
            visitors.Visible = true;
            this.Hide();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locationForm location = new locationForm();
            location.Visible = true;
            this.Hide();
        }

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // does nothing intentionally
        }
    }
}
