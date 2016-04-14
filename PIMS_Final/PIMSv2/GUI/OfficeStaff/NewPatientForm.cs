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
        // Default Constructor
        public NewPatientForm()
        {
            InitializeComponent();

            // If we have a current patient, add profile information about the patient to various profile text box's
            if (Program.currentPatient != null)
            {
                this.idTextBox.Text = Program.currentPatient.directory.patientID;
                this.lastNameTextBox.Text = Program.currentPatient.directory.lName;
                this.firstNameTextBox.Text = Program.currentPatient.directory.fName;
                this.middleNameTextBox.Text = Program.currentPatient.directory.mName;
                this.dobTextBox.Text = Program.currentPatient.directory.DOB.ToString(@"MM\/dd\/yyyy");
                if (Program.currentPatient.directory.gender)
                    this.genderTextBox.Text = "M";
                else
                    this.genderTextBox.Text = "F";
                this.addressTextBox.Text = Program.currentPatient.directory.strAddress;
                this.cityTextBox.Text = Program.currentPatient.directory.city;
                this.stateTextBox.Text = Program.currentPatient.directory.state;
                this.zipTextBox.Text = Program.currentPatient.directory.zip;
                this.primaryPhoneTextBox.Text = Program.currentPatient.directory.phoneNum1;
                this.secondaryPhoneTextBox.Text = Program.currentPatient.directory.phoneNum2;
                this.contactName1TextBox.Text = Program.currentPatient.directory.emerContact1.name;
                this.contactPhone1TextBox.Text = Program.currentPatient.directory.emerContact1.phoneNum;
                this.contactName2TextBox.Text = Program.currentPatient.directory.emerContact2.name;
                this.contactPhone2TextBox.Text = Program.currentPatient.directory.emerContact2.phoneNum;

                // Makes the patient's profile text box's not editable
                makeReadOnly();
            }
        }

        // Makes the patient's profile text box's not editable
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

        // Makes the patient's profile text box's editable
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

        // Will allow the Office Staff user to update a patient's profile information
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Update")
            {
                // Makes the patient's profile text box's editable
                makeReadable();
                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save";
                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save")
            {
                Boolean createNew = false;

                // Check to see if we have a current patient
                // If we don't, create a new patient
                if (Program.currentPatient == null)
                {
                    Program.currentPatient = new PIMSController.Patient();
                    createNew = true;
                }

                // Assign various profile information to the curent patient
                Program.currentPatient.directory.patientID = this.idTextBox.Text;
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

                //// This is a new patient
                //// Create a new patient
                //if (createNew)
                //    PIMSController.SQLcommands.createPatient();
                //// This is an existing patient
                //// Update the exisitng patient
                //else
                //    PIMSController.SQLcommands.updatePatient(Program.currentPatient);

                // Makes the patient's profile text box's not editable
                makeReadOnly();
                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Update";

                // Display information message
                MessageBox.Show("Patient's profile information has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
