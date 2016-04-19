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

            this.dateTimePicker1.Enabled = false;

            // If the current user is not a Doctor
            // Don't allow the user to see various items
            if (!(Program.currentUser is PIMSController.Doctor))
            {
                this.saveUpdateButton.Visible = false;
                this.cancelButton.Visible = false;
                this.attendingPhysTextBox.Visible = false;
                this.label2.Visible = false;
            }
            else
            {
                this.attendingPhysTextBox.Text = Program.currentUser.name;
            }

            // Do not allow the Doctor to see the cancelButton at this time
            if (saveUpdateButton.Text == "Update Notes")
            {
                this.cancelButton.Visible = false;
            }

            this.doctorsNotesTextBox.Text = Program.currentPatient.treatment.docNotes;
            this.primaryPhysTextBox.Text = Program.currentPatient.treatment.primaryDoc;

            if (Program.currentPatient.treatment.dateAdmitted != null)
            {
                this.dateTimePicker1.Value = (DateTime)Program.currentPatient.treatment.dateAdmitted;
            }
            else
            {
                this.dateTimePicker1.Value = DateTime.Today;
                this.dateTimePicker1.Enabled = false;
            }

            if ((Program.currentPatient.treatment.reasonAdmitted != null && Program.currentPatient.treatment.reasonAdmitted != ""))
            {
                this.reasonAdmittanceTextBox.Text = Program.currentPatient.treatment.reasonAdmitted;
            }

            if ((Program.currentPatient.treatment.diagnosis != null && Program.currentPatient.treatment.diagnosis != ""))
            {
                this.diagnosisTextBox.Text = Program.currentPatient.treatment.diagnosis;
            }

            // Do not allow the user to edit the attendingPhysTextBox
            this.attendingPhysTextBox.ReadOnly = true;

            // Makes the doctorNotesTextBox not editable
            makeReadOnly();
        }
        
        // Makes the doctorNotesTextBox not editable
        public void makeReadOnly()
        {
            this.doctorsNotesTextBox.ReadOnly = true;
            this.primaryPhysTextBox.ReadOnly = true;
            this.reasonAdmittanceTextBox.ReadOnly = true;
            this.diagnosisTextBox.ReadOnly = true;
            this.dateTimePicker1.Enabled = false;
        }

        // Makes the doctorNotesTextBox editable
        public void makeReadable()
        {
            this.doctorsNotesTextBox.ReadOnly = false;
            this.primaryPhysTextBox.ReadOnly = false;
            this.reasonAdmittanceTextBox.ReadOnly = false;
            this.diagnosisTextBox.ReadOnly = false;
            this.dateTimePicker1.Enabled = true;
        }

        // Will allow the Doctor to update notes on the patient
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient.treatment.docNotes = this.doctorsNotesTextBox.Text;
            Program.currentPatient.treatment.primaryDoc = this.primaryPhysTextBox.Text;
            Program.currentPatient.treatment.attendingDoc = this.attendingPhysTextBox.Text;
            Program.currentPatient.treatment.reasonAdmitted = this.reasonAdmittanceTextBox.Text;
            Program.currentPatient.treatment.dateAdmitted = this.dateTimePicker1.Value;
            Program.currentPatient.treatment.diagnosis = this.diagnosisTextBox.Text;

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
