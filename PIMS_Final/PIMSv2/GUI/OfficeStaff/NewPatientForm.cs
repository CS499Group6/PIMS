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
    public partial class NewPatientForm : UserControl
    {
        PIMSController.Patient patient;

        public NewPatientForm()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            if (patient != null)
            {
                this.idTextBox.Text = patient.directory.patientID;
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
        }

        public void makeReadOnly()
        {
            this.idTextBox.ReadOnly = true;
            this.lastNameTextBox.ReadOnly = true;
            this.firstNameTextBox.ReadOnly = true;
            this.middleNameTextBox.ReadOnly = true;
            this.dobTextBox.ReadOnly = true;
            this.genderTextBox.ReadOnly = true;
            this.addressTextBox.ReadOnly = true;
            this.cityTextBox.ReadOnly = true;
            this.stateTextBox.ReadOnly = true;
            this.zipTextBox.ReadOnly = true;
            this.primaryPhoneTextBox.ReadOnly = true;
            this.secondaryPhoneTextBox.ReadOnly = true;
            this.contactName1TextBox.ReadOnly = true;
            this.contactPhone1TextBox.ReadOnly = true;
            this.contactName2TextBox.ReadOnly = true;
            this.contactPhone2TextBox.ReadOnly = true;
        }

        public void makeReadable()
        {
            this.idTextBox.ReadOnly = false;
            this.lastNameTextBox.ReadOnly = false;
            this.firstNameTextBox.ReadOnly = false;
            this.middleNameTextBox.ReadOnly = false;
            this.dobTextBox.ReadOnly = false;
            this.genderTextBox.ReadOnly = false;
            this.addressTextBox.ReadOnly = false;
            this.cityTextBox.ReadOnly = false;
            this.stateTextBox.ReadOnly = false;
            this.zipTextBox.ReadOnly = false;
            this.primaryPhoneTextBox.ReadOnly = false;
            this.secondaryPhoneTextBox.ReadOnly = false;
            this.contactName1TextBox.ReadOnly = false;
            this.contactPhone1TextBox.ReadOnly = false;
            this.contactName2TextBox.ReadOnly = false;
            this.contactPhone2TextBox.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PIMSController.PatientDirInfo dir;
            Boolean createNew = false;

            if (Program.currentPatient == null)
            {
                Console.WriteLine("create new patient true");

                Program.currentPatient = new PIMSController.Patient();
                createNew = true;
            }
            dir = Program.currentPatient.directory;

           // Program.currentPatient.directory.patientID = this.idTextBox.Text;
            Program.currentPatient.directory.lName = this.lastNameTextBox.Text;
            Program.currentPatient.directory.fName = this.firstNameTextBox.Text;
            Program.currentPatient.directory.mName = this.middleNameTextBox.Text;
            Program.currentPatient.directory.DOB = Convert.ToDateTime(this.dobTextBox.Text);
            if (this.genderTextBox.Text.ToUpper().Equals("M"))
                Program.currentPatient.directory.gender = true;
            else Program.currentPatient.directory.gender = false;
            Program.currentPatient.directory.strAddress = this.addressTextBox.Text;
            Program.currentPatient.directory.city = this.cityTextBox.Text;
            Program.currentPatient.directory.state = this.stateTextBox.Text;
            Program.currentPatient.directory.zip = this.zipTextBox.Text;
            Program.currentPatient.directory.phoneNum1 = this.primaryPhoneTextBox.Text;
            Program.currentPatient.directory.phoneNum2 = this.secondaryPhoneTextBox.Text;
            Program.currentPatient.directory.emerContact1.name = this.contactName1TextBox.Text;
            Program.currentPatient.directory.emerContact1.phoneNum = this.contactPhone1TextBox.Text;
            Program.currentPatient.directory.emerContact2.name = this.contactName2TextBox.Text;
            Program.currentPatient.directory.emerContact2.phoneNum = this.contactPhone2TextBox.Text;

            if (createNew)
            {

                Console.WriteLine(Program.currentPatient.directory.fName);
                Program.currentPatient.directory.patientID = PIMSController.SQLcommands.createPatient(Program.currentPatient);
                Console.WriteLine("Id num is");
                Console.WriteLine(Program.currentPatient.directory.patientID);
            }
            else
            {
                PIMSController.SQLcommands.updatePatient(Program.currentPatient);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
