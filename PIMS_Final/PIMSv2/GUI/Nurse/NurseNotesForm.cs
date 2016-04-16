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

        PIMSController.MedStaffNotes.patientStats tempStat;

        // Default Constructor
        public NurseNotesForm(PIMSController.MedStaffNotes.patientStats stat)
        {
            tempStat = stat;

            InitializeComponent();

            // Do not allow user to edit nurseTextBox and dateTextBox
            this.nurseTextBox.ReadOnly = false;
            this.dateTextBox.ReadOnly = false;

            // If we have stat's to add
            // Add them
            if (stat.idNum != 0)
            {
                if (Program.currentPatient.treatment.medStaffNotes.statList.Count > 0)
                {
                    this.nurseTextBox.Text = stat.nurse;
                    this.dateTextBox.Text = stat.time.ToString();
                    this.heightTextBox.Text = stat.patientHeight.ToString();
                    this.diaTextBox.Text = stat.bloodPressureDia.ToString();
                    this.sysTextBox.Text = stat.bloodPressureDia.ToString();
                    this.weightTextBox.Text = stat.patientWeight.ToString();
                    this.diaTextBox.Text = stat.bloodPressureDia.ToString();
                    this.sysTextBox.Text = stat.bloodPressureSys.ToString();
                    this.heartRateTextBox.Text = stat.heartrate.ToString();
                } 
                
                allergiesTextBox.Text = Program.currentPatient.treatment.allergies;
                notesNotesTextBox.Text = Program.currentPatient.treatment.medStaffNotes.nurseNotes;

                // Makes the patient's medical stats not editable
                makeReadOnly();
            }
            // This is a new stat
            else
            {
                // Set the new stat id in Controller

                this.dateTextBox.Text = DateTime.Now.ToString();
                this.nurseTextBox.Text = Program.currentUser.name;

                allergiesTextBox.Text = Program.currentPatient.treatment.allergies;
                notesNotesTextBox.Text = Program.currentPatient.treatment.medStaffNotes.nurseNotes;
                
                // Makes the patient's medical stats editable
                makeReadable();

                saveUpdateButton.Text = "Save New Stat";
            }
        }

         // Makes the patient's medical stats not editable
        public void makeReadOnly()
        {
            this.nurseTextBox.ReadOnly = true;
            this.dateTextBox.ReadOnly = true;
            this.heightTextBox.ReadOnly = true;
            this.weightTextBox.ReadOnly = true;
            this.diaTextBox.ReadOnly = true;
            this.sysTextBox.ReadOnly = true;
            this.heartRateTextBox.ReadOnly = true;
            this.allergiesTextBox.ReadOnly = true;
            this.notesNotesTextBox.ReadOnly = true;
        }

        // Makes the patient's medical stats editable
        public void makeReadable()
        {
            this.nurseTextBox.ReadOnly = false;
            this.dateTextBox.ReadOnly = false;
            this.heightTextBox.ReadOnly = false;
            this.weightTextBox.ReadOnly = false;
            this.diaTextBox.ReadOnly = false;
            this.sysTextBox.ReadOnly = false; 
            this.heartRateTextBox.ReadOnly = false;
            this.allergiesTextBox.ReadOnly = false;
            this.notesNotesTextBox.ReadOnly = false;
        }

        // Will allow a Doctor or MedicalStaff to update patient's stats
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            tempStat.nurse = this.nurseTextBox.Text;
            tempStat.time = DateTime.Now;
            tempStat.patientHeight = int.Parse(this.heightTextBox.Text);
            tempStat.patientWeight = int.Parse(this.weightTextBox.Text);
            tempStat.bloodPressureDia = int.Parse(this.diaTextBox.Text);
            tempStat.bloodPressureSys = int.Parse(this.sysTextBox.Text);
            tempStat.heartrate = int.Parse(this.heartRateTextBox.Text);
            Program.currentPatient.treatment.allergies = this.allergiesTextBox.Text;
            Program.currentPatient.treatment.medStaffNotes.nurseNotes = this.notesNotesTextBox.Text;

            if (saveUpdateButton.Text == "Update Stats")
            {
                // Makes the patient's medical stats editable
                makeReadable();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Stats";

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save New Stat")
            {
                PIMSController.SQLcommands.statsIndex++;
                tempStat.idNum = PIMSController.SQLcommands.statsIndex;

                Program.currentPatient.treatment.medStaffNotes.statList.Add(tempStat);
            }

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
