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
    public partial class DoctorNotesForm : UserControl
    {
        // Default Constructor
        public DoctorNotesForm()
        {
            InitializeComponent();

            // If the current user is not a Doctor
            // Don't allow the user to see the saveUpdatebutton
            if (!(Program.currentUser is PIMSController.Doctor))
            {
                saveUpdateButton.Visible = false;
                cancelButton.Visible = false;
            }

            // Do not allow the Doctor to see the cancelButton at this time
            if (saveUpdateButton.Text == "Update Notes")
            {
                this.cancelButton.Visible = false;
            }

            this.doctorsNotesTextBox.Text = Program.currentPatient.treatment.docNotes;

            // Makes the doctorNotesTextBox not editable
            makeReadOnly();
        }
        
        // Makes the doctorNotesTextBox not editable
        public void makeReadOnly()
        {
            this.doctorsNotesTextBox.ReadOnly = true;
        }

        // Makes the doctorNotesTextBox editable
        public void makeReadable()
        {
            this.doctorsNotesTextBox.ReadOnly = false;
        }

        // Will allow the Doctor to update notes on the patient
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient.treatment.docNotes = this.doctorsNotesTextBox.Text;

            if (saveUpdateButton.Text == "Update Notes")
            {
                // Make the doctorNotesTextBox editable
                makeReadable();

                // Allow the Doctor to see the cancelButton
                cancelButton.Visible = true;

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Notes";

                // Exit out of this function
                return;
            }

            PIMSController.SQLcommands.updatePatient();

            // Make the doctorNotesTextBox not editable
            makeReadOnly();

            // Do not allow the Doctor to see the cancelButton
            cancelButton.Visible = false;

            // Display information message
            MessageBox.Show("Notes on the patient have been updated!",
            "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Update Notes";
        }

        // Will allow the Doctor to not update the notes on the patient
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Update Notes";
            
            // Do not allow the Doctor to see the cancelButton
            cancelButton.Visible = false;

            // Make the doctorNotesTextBox not editable
            makeReadOnly();
        }
    }
}
