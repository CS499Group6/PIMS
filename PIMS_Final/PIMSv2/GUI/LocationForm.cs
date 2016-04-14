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
    public partial class LocationForm : UserControl
    {
        // Default Constructor
        public LocationForm()
        {
            InitializeComponent();

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                saveUpdateButton.Visible = false;
            }

            // If we have a current patient, add location information about the patient to various location text box's
            if (Program.currentPatient != null)
            {
                floorTextBox.Text = Program.currentPatient.directory.location.floor;
                roomTextBox.Text = Program.currentPatient.directory.location.roomNum;
                bedTextBox.Text = Program.currentPatient.directory.location.bedNum;
                unitTextBox.Text = Program.currentPatient.directory.location.unit;
            }
            
            // Makes the patient's location text box's not editable
            makeReadOnly();
        }

        // Makes the patient's location text box's not editable
        public void makeReadOnly()
        {
            floorTextBox.ReadOnly = true;
            roomTextBox.ReadOnly = true;
            bedTextBox.ReadOnly = true;
            unitTextBox.ReadOnly = true;
        }

        // Makes the patient's location text box's editable
        public void makeReadable()
        {
            floorTextBox.ReadOnly = false;
            roomTextBox.ReadOnly = false;
            bedTextBox.ReadOnly = false;
            unitTextBox.ReadOnly = false;
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

                // Assign various location information to the current patient

                Program.currentPatient.directory.location.floor = floorTextBox.Text;
                Program.currentPatient.directory.location.roomNum = roomTextBox.Text;
                Program.currentPatient.directory.location.bedNum = bedTextBox.Text;
                Program.currentPatient.directory.location.unit = unitTextBox.Text;

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
                MessageBox.Show("Patient's location information has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will allow the user to print the patient's insurance information
        private void printButton_Click(object sender, EventArgs e)
        {

        }    
    }
}
