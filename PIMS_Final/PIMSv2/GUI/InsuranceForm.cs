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
    public partial class InsuranceForm : UserControl
    {
        // Default Constructor
        public InsuranceForm()
        {
            InitializeComponent();

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                saveUpdateButton.Visible = false;
            }

            // If we have a current patient, add insuracne information about the patient to various insurance text box's
            if (Program.currentPatient != null)
            {
                this.providerTextBox.Text = Program.currentPatient.insurance.provider;
                this.binTextBox.Text = Program.currentPatient.insurance.bin;
                this.idTextBox.Text = Program.currentPatient.insurance.id;
                this.pcnTextBox.Text = Program.currentPatient.insurance.pcn;
                this.groupTextBox.Text = Program.currentPatient.insurance.groupNum;

                if (Program.currentPatient.insurance.insuranceType == "Medical")
                {
                    this.typeComboBox.Text = "Medical";
                }
                else if (Program.currentPatient.insurance.insuranceType == "Dental")
                {
                    this.typeComboBox.Text = "Dental";
                }
                else if (Program.currentPatient.insurance.insuranceType == "Prescriptions")
                {
                    this.typeComboBox.Text = "Prescriptions";
                }
                else if (Program.currentPatient.insurance.insuranceType == "Vision")
                {
                    this.typeComboBox.Text = "Vision";
                }

                // Makes the patient's insurance information not editable
                makeReadOnly();
            }
        }

        // Makes the patient's insurance information not editable
        public void makeReadOnly()
        {
            this.providerTextBox.ReadOnly = true;
            this.binTextBox.ReadOnly = true;
            this.idTextBox.ReadOnly = true;
            this.pcnTextBox.ReadOnly = true;
            this.groupTextBox.ReadOnly = true;
            this.typeComboBox.Enabled = true;
        }

        // Makes the patient's insurance information editable
        public void makeReadable()
        {
            this.providerTextBox.ReadOnly = false;
            this.binTextBox.ReadOnly = false;
            this.idTextBox.ReadOnly = false;
            this.pcnTextBox.ReadOnly = false;
            this.groupTextBox.ReadOnly = false;
            this.typeComboBox.Enabled = false;
        }

        // Will allow the Office Staff user to update a patient's insurance information
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

                // Assign various insurance information to the current patient
                Program.currentPatient.insurance.provider = providerTextBox.Text;
                Program.currentPatient.insurance.bin = binTextBox.Text;
                Program.currentPatient.insurance.id = idTextBox.Text;
                Program.currentPatient.insurance.pcn = pcnTextBox.Text;
                Program.currentPatient.insurance.groupNum = groupTextBox.Text;
                Program.currentPatient.insurance.insuranceType = typeComboBox.Text;

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
                MessageBox.Show("Patient's insurance information has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will allow the user to print the patient's insurance information
        private void printButton_Click(object sender, EventArgs e)
        {
            // Instantiate new printInfo object to print page
            PIMSController.PrintInfo document = new PIMSController.PrintInfo(); 

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("MyFile.txt"))
            {

                file.WriteLine("PATIENT BILLING ADDRESS\n");
                String address = String.Format("{0}, {1} \n{2} \n{3}, {4} \n{5}\n\n", Program.currentPatient.directory.lName, Program.currentPatient.directory.fName, Program.currentPatient.directory.strAddress,
                    Program.currentPatient.directory.city, Program.currentPatient.directory.state, Program.currentPatient.directory.zip);
                file.WriteLine(address);

                file.WriteLine("PATIENT INSURANCE INFORMATION\n");

                file.WriteLine(String.Format("{0, 15}: {1, 15} \n{2, 15}: {3, 15} \n{4, 15}: {5, 15} \n{6, 15}: {7, 15} \n{8, 15}: {9, 15} \n {10, 15}: {11, 15} \n",
                    "Provider", Program.currentPatient.insurance.provider,
                    "BIN", Program.currentPatient.insurance.bin,
                    "ID", Program.currentPatient.insurance.id,
                    "PCN", Program.currentPatient.insurance.pcn,
                    "Group Number", Program.currentPatient.insurance.groupNum,
                    "Insurance Type", Program.currentPatient.insurance.insuranceType));
            }

            // Call the print function in the print class
            document.printButton_Click();
        }
    }
}
