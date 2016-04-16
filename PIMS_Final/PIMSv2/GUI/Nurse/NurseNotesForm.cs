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
    public partial class NurseNotesForm : UserControl
    {
        int count = 1;

        // Default Constructor
        public NurseNotesForm(PIMSController.MedStaffNotes.patientStats stat)
        {
            InitializeComponent();

            updateStatDisplay(stat);

            allergiesTextBox.Text = Program.currentPatient.treatment.allergies;
            notesTextBox.Text = Program.currentPatient.treatment.medStaffNotes.nurseNotes;
        }

         // Makes the patient's medical stats not editable
        public void makeReadOnly()
        {
            dateTextBox.ReadOnly = true;
            nurseTextBox.ReadOnly = true;
            heightTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            bpTextBox.ReadOnly = true;
            heartRateTextBox.ReadOnly = true;
            allergiesTextBox.ReadOnly = true;
            notesTextBox.ReadOnly = true;
        }

        // Makes the patient's medical stats editable
        public void makeReadable()
        {
            dateTextBox.ReadOnly = false;
            nurseTextBox.ReadOnly = false;
            heightTextBox.ReadOnly = false;
            weightTextBox.ReadOnly = false;
            bpTextBox.ReadOnly = false;
            heartRateTextBox.ReadOnly = false;
            allergiesTextBox.ReadOnly = false;
            notesTextBox.ReadOnly = false;
        }

        private void updateStatDisplay(PIMSController.MedStaffNotes.patientStats stat)
        {
            if (Program.currentPatient.treatment.medStaffNotes.statList.Count > 0)
            {
                dateTextBox.Text = stat.time.ToString();
                //nurseTextBox.Text = stat.nurse;
                heightTextBox.Text = stat.patientHeight.ToString();
                weightTextBox.Text = stat.patientWeight.ToString();
                bpTextBox.Text = (stat.bloodPressureSys + "/" + stat.bloodPressureDia).ToString();
                heartRateTextBox.Text = stat.heartrate.ToString();
            }
        }

        // Will allow a nurse or doctor to update patient stats
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Update Stats")
            {
                // Makes the patient's medical stats editable
                makeReadable();
                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Stats";
                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save Stats")
            {
            //    Program.currentPatient.treatment.medStaffNotes.nurseNdateTextBox;
            //    heightTextBox;
            //    weightTextBox;
            //    bpTextBox;
            //    heartRateTextBox;
            //    Program.currentPatient.treatment.allergies = allergiesTextBox.Text;
            //    Program.currentPatient.treatment.medStaffNotes.nurseNotes = notesTextBox.Text;

                PIMSController.SQLcommands.updatePatient();

                // Makes the patient's profile text box's not editable
                makeReadOnly();
                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Update Stats";

                // Display information message
                MessageBox.Show("Patient's medical stats have been updated!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
