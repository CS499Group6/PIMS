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
    public partial class NewInsuranceForm : UserControl
    {
        // Default Constructor
        public NewInsuranceForm()
        {
            InitializeComponent();

            // If we have a current patient, add insuracne information about the patient to various insurance text box's
            if (Program.currentPatient != null)
            {
                providerTextBox.Text = Program.currentPatient.insurance.provider;
                binTextBox.Text = Program.currentPatient.insurance.bin;
                idTextBox.Text = Program.currentPatient.insurance.id;
                pcnTextBox.Text = Program.currentPatient.insurance.pcn;
                groupTextBox.Text = Program.currentPatient.insurance.groupNum;
                //typeComboBox.Items.Add("");

                // Makes the patient's insurance text box's not editable
                makeReadOnly();
            }
        }

        // Makes the patient's insurance text box's not editable
        public void makeReadOnly()
        {
            providerTextBox.ReadOnly = true;
            binTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;
            pcnTextBox.ReadOnly = true;
            groupTextBox.ReadOnly = true;
        }

        // Makes the patient's insurance text box's editable
        public void makeReadable()
        {
            providerTextBox.ReadOnly = false;
            binTextBox.ReadOnly = false;
            idTextBox.ReadOnly = false;
            pcnTextBox.ReadOnly = false;
            groupTextBox.ReadOnly = false;
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

                // Assign various insurance information to the curent patient
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
                MessageBox.Show("Patient's profile information has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will allow the Office Staff to print the patient's billing information
        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
