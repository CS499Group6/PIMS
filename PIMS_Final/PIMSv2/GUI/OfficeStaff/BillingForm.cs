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
    public partial class BillingForm : UserControl
    {
        // Default Constructor
        public BillingForm(PIMSController.BillingLineItem item)
        {
            InitializeComponent();

            // If we have a current patient, add billing information about the patient to various billing text box's
            if (Program.currentPatient != null)
            {
                itemTextBox.Text = item.item;
                costTextBox.Text = Math.Round(((float)item.cost / 100.0), 2).ToString();
                insPaidTextBox.Text = Math.Round(((float)item.insPaid / 100.0), 2).ToString();
                paidTextBox.Text = Math.Round(((float)item.paid / 100.0), 2).ToString();
                dueTextBox.Text = item.dueDate.ToString(@"MM\/dd\/yyyy");
            }

            makeReadOnly();
        }

        // Makes the patient's billing text box's not editable
        public void makeReadOnly()
        {
            itemTextBox.ReadOnly = true;
            costTextBox.ReadOnly = true;
            insPaidTextBox.ReadOnly = true;
            paidTextBox.ReadOnly = true;
            dueTextBox.ReadOnly = true;
        }

        // Makes the patient's billing text box's editable
        public void makeReadable()
        {
            itemTextBox.ReadOnly = false;
            costTextBox.ReadOnly = false;
            insPaidTextBox.ReadOnly = false;
            paidTextBox.ReadOnly = false;
            dueTextBox.ReadOnly = false;
        }

        // Will allow the Office Staff user to update a patient's billing information
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
                // = itemTextBox.Text;
                // = costTextBox.Text;
                // = insPaidTextBox.Text;;
                // = paidTextBox.Text;
                // = dueTextBox.Text;

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
        private void printButon_Click(object sender, EventArgs e)
        {

        }       
    }
}
