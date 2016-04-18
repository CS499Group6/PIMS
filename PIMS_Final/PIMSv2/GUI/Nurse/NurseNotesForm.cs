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
        PIMSController.MedStaffNotes.patientStats tempStat;

        // Default Constructor
        public NurseNotesForm(PIMSController.MedStaffNotes.patientStats stat)
        {
            tempStat = stat;

            InitializeComponent();

            // If the current user is not a MedicalStaff
            // Don't allow the user to see the saveUpdatebutton
            if (!(Program.currentUser is PIMSController.MedStaff))
            {
                saveUpdateButton.Visible = false;
                cancelButton.Visible = false;
            }

            // If the text == "Update Stat"
            // Do not allow Office staff user to see the cancelButton
            if (saveUpdateButton.Text == "Update Stat")
            {
                this.cancelButton.Visible = false;
            }

            // The text == "Save New Stat"
            // The MedicalStaff user might not want to enter in a new stat
            // Allow them to see the cancelButton
            if (saveUpdateButton.Text == "Save New Stat")
            {
                this.cancelButton.Visible = true;
            }

            // Do not allow user to edit nurseTextBox and dateTimePicker
            this.nurseTextBox.ReadOnly = true;
            this.dateTimePicker1.Enabled = true;

            // If we have stat's to add
            // Add them
            if (stat.idNum != 0)
            {
                if (Program.currentPatient.treatment.medStaffNotes.statList.Count > 0)
                {
                    this.nurseTextBox.Text = stat.nurse;
                    this.dateTimePicker1.Value = stat.time;
                    this.heightTextBox.Text = stat.patientHeight.ToString();
                    this.diaTextBox.Text = stat.bloodPressureDia.ToString();
                    this.sysTextBox.Text = stat.bloodPressureDia.ToString();
                    this.weightTextBox.Text = stat.patientWeight.ToString();
                    this.diaTextBox.Text = stat.bloodPressureDia.ToString();
                    this.sysTextBox.Text = stat.bloodPressureSys.ToString();
                    this.heartRateTextBox.Text = stat.heartrate.ToString();
                } 

                // Make the patient's medical stats not editable
                makeReadOnly();
            }
            // This is a new stat
            else
            {
                this.dateTimePicker1.Value = DateTime.Now;
                this.nurseTextBox.Text = Program.currentUser.name;
                
                // Make the patient's medical stats editable
                makeReadable();

                saveUpdateButton.Text = "Save New Stat";
            }
        }

         // Makes the patient's medical stats not editable
        public void makeReadOnly()
        {
            this.dateTimePicker1.Enabled = false;
            this.heightTextBox.ReadOnly = true;
            this.weightTextBox.ReadOnly = true;
            this.diaTextBox.ReadOnly = true;
            this.sysTextBox.ReadOnly = true;
            this.heartRateTextBox.ReadOnly = true;
        }

        // Makes the patient's medical stats editable
        public void makeReadable()
        {            
            this.dateTimePicker1.Enabled = true;
            this.heightTextBox.ReadOnly = false;
            this.weightTextBox.ReadOnly = false;
            this.diaTextBox.ReadOnly = false;
            this.sysTextBox.ReadOnly = false; 
            this.heartRateTextBox.ReadOnly = false;
        }

        // Will allow the MedicalStaff user to update patient's stats
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            tempStat.nurse = this.nurseTextBox.Text;
            tempStat.time = DateTime.Now;
            tempStat.patientHeight = int.Parse(this.heightTextBox.Text);
            tempStat.patientWeight = int.Parse(this.weightTextBox.Text);
            tempStat.bloodPressureDia = int.Parse(this.diaTextBox.Text);
            tempStat.bloodPressureSys = int.Parse(this.sysTextBox.Text);
            tempStat.heartrate = int.Parse(this.heartRateTextBox.Text);

            if (saveUpdateButton.Text == "Update Stat")
            {
                // Make the patient's medical stats editable
                makeReadable();

                // Allow the MedicalStaff user to see the cancelButton
                cancelButton.Visible = true;

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Stat";

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

            // Make the patient's profile text box's not editable
            makeReadOnly();

            // Do not allow the MedicalStaff user to see the cancelButton
            cancelButton.Visible = false;

            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Update Stat";

            // Display information message
            MessageBox.Show("Patient's medical stat has been updated!",
            "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Will allow the MedicalStaff to not update a stat on the patient
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Save Stat")
            {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add LeftSideButtons to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new NurseNotesGrid());
            }
            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Save Stat";

            // Do not allow the Doctor to see the cancelButton
            cancelButton.Visible = false;

            // Make the patient's medical stats not editable
            makeReadOnly();
        }
    }
}
