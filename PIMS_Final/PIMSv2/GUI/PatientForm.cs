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
    public partial class PatientForm : UserControl
    {
        // bool to toggle features if patient is new or existing
        bool createNew = false;

        // Default Constructor
        public PatientForm()
        {
            InitializeComponent();

            this.genderComboBox.Items.Add("M");
            this.genderComboBox.Items.Add("F");

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                saveUpdateButton.Visible = false;
                cancelButton.Visible = false;
            }

            // Do not allow Office Staff user to see the cancelButton at this time
            if (saveUpdateButton.Text == "Update Profile Information")
            {
                cancelButton.Visible = false;
            }
         
            // If we have a current patient
            // Add profile information about the patient to various profile text box's
            if (Program.currentPatient != null)
            {
                this.lastNameTextBox.Text = Program.currentPatient.directory.lName;
                this.firstNameTextBox.Text = Program.currentPatient.directory.fName;
                this.middleNameTextBox.Text = Program.currentPatient.directory.mName;
                this.dateTimePicker.Value = Program.currentPatient.directory.DOB;
                if (Program.currentPatient.directory.gender)
                    this.genderComboBox.Text = "M";
                else
                    this.genderComboBox.Text = "F";
                this.addressTextBox.Text = Program.currentPatient.directory.strAddress;
                this.cityTextBox.Text = Program.currentPatient.directory.city;
                this.stateTextBox.Text = Program.currentPatient.directory.state;
                this.zipTextBox.Text = Program.currentPatient.directory.zip;
                this.primaryPhoneTextBox.Text = Program.currentPatient.directory.phoneNum1;
                this.cellPhoneTextBox.Text = Program.currentPatient.directory.phoneNum2;
                this.workPhoneTextBox.Text = Program.currentPatient.directory.workphone;
                this.contactName1TextBox.Text = Program.currentPatient.directory.emerContact1.name;
                this.contactPhone1TextBox.Text = Program.currentPatient.directory.emerContact1.phoneNum;
                this.contactName2TextBox.Text = Program.currentPatient.directory.emerContact2.name;
                this.contactPhone2TextBox.Text = Program.currentPatient.directory.emerContact2.phoneNum;

                // Make the patient's profile text box's not editable
                makeReadOnly();

                // Change the text to the saveUpdateButton
                saveUpdateButton.Text = "Update Profile Information";
            }
            else
            {
                // Make the patient's profile text box's editable
                makeReadable();

                // Office Staff user is not allowed to save the new profile information 
                // Until text has been entered into the lastNameTextBox
                saveUpdateButton.Visible = false;
                createNew = true;
            }
        }

        // If text has been entered into the lastNameTextBox
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (createNew)
            {
                // Update the saveUpdateButton
                saveUpdateButton.Visible = true;
                saveUpdateButton.Text = "Save Profile Information";
            }
        }

        // Makes the patient's profile text box's not editable
        public void makeReadOnly()
        {
            this.lastNameTextBox.ReadOnly = true;
            this.firstNameTextBox.ReadOnly = true;
            this.middleNameTextBox.ReadOnly = true;
            this.dateTimePicker.Enabled = false;
            this.genderComboBox.Enabled = false;
            this.addressTextBox.ReadOnly = true;
            this.cityTextBox.ReadOnly = true;
            this.stateTextBox.ReadOnly = true;
            this.zipTextBox.ReadOnly = true;
            this.primaryPhoneTextBox.ReadOnly = true;
            this.cellPhoneTextBox.ReadOnly = true;
            this.workPhoneTextBox.ReadOnly = true;
            this.contactName1TextBox.ReadOnly = true;
            this.contactPhone1TextBox.ReadOnly = true;
            this.contactName2TextBox.ReadOnly = true;
            this.contactPhone2TextBox.ReadOnly = true;
        }

        // Makes the patient's profile text box's editable
        public void makeReadable()
        {
            this.lastNameTextBox.ReadOnly = false;
            this.firstNameTextBox.ReadOnly = false;
            this.middleNameTextBox.ReadOnly = false;
            this.dateTimePicker.Enabled = true;
            this.genderComboBox.Enabled = true;
            this.addressTextBox.ReadOnly = false;
            this.cityTextBox.ReadOnly = false;
            this.stateTextBox.ReadOnly = false;
            this.zipTextBox.ReadOnly = false;
            this.primaryPhoneTextBox.ReadOnly = false;
            this.cellPhoneTextBox.ReadOnly = false;
            this.workPhoneTextBox.ReadOnly = false;
            this.contactName1TextBox.ReadOnly = false;
            this.contactPhone1TextBox.ReadOnly = false;
            this.contactName2TextBox.ReadOnly = false;
            this.contactPhone2TextBox.ReadOnly = false;
        }

        // Will allow the Office Staff user to update a patient's profile information
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Update Profile Information")
            {
                // Make the patient's profile text box's editable
                makeReadable();

                // Allow Office Staff user to see the cancelButton
                cancelButton.Visible = true;

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Profile Information";

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save Profile Information")
            {
                if (!(this.lastNameTextBox.Text == "" && this.firstNameTextBox.Text == ""))
                {
                    // Check to see if we have a current patient
                    if (Program.currentPatient == null)
                    {
                        createNew = true;
                        Program.currentPatient = new PIMSController.Patient();

                        PIMSController.SQLcommands.patientIndex++;
                        Program.currentPatient.directory.patientID = PIMSController.SQLcommands.patientIndex.ToString();
                    }

                    // Assign various profile information to the current patient
                    Program.currentPatient.directory.lName = this.lastNameTextBox.Text;
                    Program.currentPatient.directory.fName = this.firstNameTextBox.Text;
                    Program.currentPatient.directory.mName = this.middleNameTextBox.Text;
                    Program.currentPatient.directory.DOB = this.dateTimePicker.Value;
                    if (this.genderComboBox.Text.Equals("M"))
                        Program.currentPatient.directory.gender = true;
                    else Program.currentPatient.directory.gender = false;
                    Program.currentPatient.directory.strAddress = this.addressTextBox.Text;
                    Program.currentPatient.directory.city = this.cityTextBox.Text;
                    Program.currentPatient.directory.state = this.stateTextBox.Text;
                    Program.currentPatient.directory.zip = this.zipTextBox.Text;
                    Program.currentPatient.directory.phoneNum1 = this.primaryPhoneTextBox.Text;
                    Program.currentPatient.directory.phoneNum2 = this.cellPhoneTextBox.Text;
                    Program.currentPatient.directory.workphone = this.workPhoneTextBox.Text;
                    Program.currentPatient.directory.emerContact1.name = this.contactName1TextBox.Text;
                    Program.currentPatient.directory.emerContact1.phoneNum = this.contactPhone1TextBox.Text;
                    Program.currentPatient.directory.emerContact2.name = this.contactName2TextBox.Text;
                    Program.currentPatient.directory.emerContact2.phoneNum = this.contactPhone2TextBox.Text;

                    // If we already had a patient
                    // Just update their information
                    if (!createNew)
                    {
                        PIMSController.SQLcommands.updatePatient();
                    }
                    // Create new patient and set patientID with value generated by SQL commands class
                    else
                    {
                        Program.currentPatient.directory.patientID = PIMSController.SQLcommands.insertNewPatient(Program.currentPatient);
                        createNew = false;
                    }
                    // Makes the patient's profile text box's not editable
                    makeReadOnly();

                    // Change the saveUpdateButton text
                    saveUpdateButton.Text = "Update Profile Information";

                    // Display information message
                    MessageBox.Show("Patient's profile information has been saved!",
                    "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Display error message
                    MessageBox.Show("Patient's first name and last name must be filled out!",
                     "Not enough data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Will allow the office staff user to not update the patient's profile
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (!(this.lastNameTextBox.Text == null))
            {
                // Do not allow the Office Staff user to see the cancelButton
                cancelButton.Visible = false;

                // Make the patient's profile text box's not editable
                makeReadOnly();
            }
            else
            {
                Program.currentPatient = null;

                // Clear contents of Panel1 and Panel2
                Program.myForm.splitContainer1.Panel1.Controls.Clear();
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add PatientSearch to Panel2;
                Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
            }
        }

        // Will allow the user to print the patient's profile information
        private void printButton_Click(object sender, EventArgs e)
        {
            string noInfo = "Information not provided";

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var myWordDoc = app.Documents.Open(@"F:\PIMS_Final\FORMS\PIMS PROFILE FORM.docx", ReadOnly: false, Visible: true);
            app.Visible = true;

            Microsoft.Office.Interop.Word.Find fndLastName = myWordDoc.ActiveWindow.Selection.Find;
            fndLastName.Text = "@lname";

            if (Program.currentPatient.directory.lName.ToString() == "")
            {
                fndLastName.Replacement.Text = noInfo;
            }
            else
            {
                fndLastName.Replacement.Text = Program.currentPatient.directory.lName.ToString();
            }
            fndLastName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndFirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndFirstName.Text = "@fname";

            if (Program.currentPatient.directory.fName.ToString() == "")
            {
                fndFirstName.Replacement.Text = noInfo;
            }
            else
            {
                fndFirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            }
            fndFirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndDOB = myWordDoc.ActiveWindow.Selection.Find;
            fndDOB.Text = "@dob";

            if (Program.currentPatient.directory.DOB.Date.ToShortDateString() == "")
            {
                fndDOB.Replacement.Text = noInfo;
            }
            else
            {
                fndDOB.Replacement.Text = Program.currentPatient.directory.DOB.Date.ToShortDateString();
            }
            fndDOB.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findGender = myWordDoc.ActiveWindow.Selection.Find;
            findGender.Text = "@gender";
            findGender.Replacement.Text = Program.currentPatient.directory.gender ? "M" : "F";
            findGender.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndStreet = myWordDoc.ActiveWindow.Selection.Find;
            fndStreet.Text = "@street";

            if (Program.currentPatient.directory.strAddress.ToString() == "")
            {
                fndStreet.Replacement.Text = noInfo;
            }
            else
            {
                fndStreet.Replacement.Text = Program.currentPatient.directory.strAddress.ToString();
            }
            fndStreet.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCity = myWordDoc.ActiveWindow.Selection.Find;
            findCity.Text = "@city";

            if (Program.currentPatient.directory.city.ToString() == "")
            {
                findCity.Replacement.Text = noInfo;
            }
            else
            {
                findCity.Replacement.Text = Program.currentPatient.directory.city.ToString();
            }
            findCity.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findState = myWordDoc.ActiveWindow.Selection.Find;
            findState.Text = "@state";

            if (Program.currentPatient.directory.state.ToString() == "")
            {
                findState.Replacement.Text = noInfo;
            }
            else
            {
                findState.Replacement.Text = Program.currentPatient.directory.state.ToString();
            }
            findState.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findZip = myWordDoc.ActiveWindow.Selection.Find;
            findZip.Text = "@zip";

            if (Program.currentPatient.directory.zip.ToString() == "")
            {
                findZip.Replacement.Text = noInfo;
            }
            else
            {
                findZip.Replacement.Text = Program.currentPatient.directory.zip.ToString();
            }
            findZip.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone1 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone1.Text = "@phone1";

            if (Program.currentPatient.directory.phoneNum1.ToString() == "")
            {
                findPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findPhone1.Replacement.Text = Program.currentPatient.directory.phoneNum1.ToString();
            }
            findPhone1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone2 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone2.Text = "@phone2";

            if (Program.currentPatient.directory.phoneNum2.ToString() == "")
            {
                findPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findPhone2.Replacement.Text = Program.currentPatient.directory.phoneNum2.ToString();
            }
            findPhone2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone3 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone3.Text = "@phone3";

            if (Program.currentPatient.directory.workphone.ToString() == "")
            {
                findPhone3.Replacement.Text = noInfo;
            }
            else
            {
                findPhone3.Replacement.Text = Program.currentPatient.directory.workphone.ToString();
            }
            findPhone3.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCName1 = myWordDoc.ActiveWindow.Selection.Find;
            findCName1.Text = "@cName1";

            if (Program.currentPatient.directory.emerContact1.name.ToString() == "")
            {
                findCName1.Replacement.Text = noInfo;
            }
            else
            {
                findCName1.Replacement.Text = Program.currentPatient.directory.emerContact1.name.ToString();
            }
            findCName1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCPhone1 = myWordDoc.ActiveWindow.Selection.Find;
            findCPhone1.Text = "@cPhone1";

            if (Program.currentPatient.directory.emerContact1.phoneNum.ToString() == "")
            {
                findCPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findCPhone1.Replacement.Text = Program.currentPatient.directory.emerContact1.phoneNum.ToString();
            }
            findCPhone1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCName2 = myWordDoc.ActiveWindow.Selection.Find;
            findCName2.Text = "@cName2";

            if (Program.currentPatient.directory.emerContact2.name.ToString() == "")
            {
                findCName2.Replacement.Text = noInfo;
            }
            else
            {
                findCName2.Replacement.Text = Program.currentPatient.directory.emerContact2.name.ToString();
            }
            findCName2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCPhone2 = myWordDoc.ActiveWindow.Selection.Find;
            findCPhone2.Text = "@cPhone2";

            if (Program.currentPatient.directory.emerContact2.phoneNum.ToString() == "")
            {
                findCPhone2.Replacement.Text = noInfo;
            }
            else
            {
                findCPhone2.Replacement.Text = Program.currentPatient.directory.emerContact2.phoneNum.ToString();
            }
            findCPhone2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            myWordDoc.SaveAs2(@"F:\PIMS_Final\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Profile Information.pdf");
            myWordDoc.PrintPreview();
        }
    }
}
