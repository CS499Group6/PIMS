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
    public partial class ScheduledProcedureForm : UserControl
    {
        PIMSController.MedProcedure tempProc;

        // Default Constructor
        public ScheduledProcedureForm(PIMSController.MedProcedure proc)
        {
            tempProc = proc;

            InitializeComponent();

            // If the text == "Update Procedure"
            // Do not allow Doctor to see the cancelButton
            if (saveUpdateButton.Text == "Update Procedure")
            {
                this.cancelButton.Visible = false;
            }

            // The text == "Save New Procedure"
            // The Docotor might not want to enter in a new procedure
            // Allow them to see the cancelButton
            if (saveUpdateButton.Text == "Save New Procedure")
            {
                this.cancelButton.Visible = true;
            }

            // If we have procdures to add
            // Add them
            if (proc.id != 0)
            {
                this.dateTimePicker1.Value = proc.when;
                this.dateTimePicker2.Value = proc.when;
                this.procdureTextBox.Text = proc.what;
                this.perforedByTextBox.Text = proc.who;
                this.locationTextBox.Text = proc.where;

                // Makes the patient's procdure text box's not editable
                makeReadOnly();
            }
            // This is a new procdure
            else
            {
                // Set the physicianTextBox 
                // Makes the patient's prescription text box's editable
                makeReadable();

                saveUpdateButton.Text = "Save New Procedure";
            }
        }

        // Makes the patient's procdure text box's not editable
        public void makeReadOnly()
        {
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.procdureTextBox.ReadOnly = true;
            this.perforedByTextBox.ReadOnly = true;
            this.locationTextBox.ReadOnly = true;
        }

         // Makes the patient's procdure text box's editable
        public void makeReadable()
        {
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.procdureTextBox.ReadOnly = false;
            this.perforedByTextBox.ReadOnly = false;
            this.locationTextBox.ReadOnly = false;
        }

        // Will allow the Doctor to update patient's procedure
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            tempProc.what = this.procdureTextBox.Text;
            tempProc.who = this.perforedByTextBox.Text;
            tempProc.where = this.locationTextBox.Text;
            tempProc.when = this.dateTimePicker1.Value.Date + this.dateTimePicker2.Value.TimeOfDay;

            if (saveUpdateButton.Text == "Update Procedure")
            {
                // Makes the patient's procdure text box's editable
                makeReadable();

                // Allow the Doctor to see the cancelButton
                cancelButton.Visible = true;

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Procedure";

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save New Procedure")
            {
                PIMSController.SQLcommands.procIndex++;
                tempProc.id = PIMSController.SQLcommands.procIndex;

                Program.currentPatient.treatment.procedures.Add(tempProc);
            }
            PIMSController.SQLcommands.updatePatient();

            // Makes the patient's procdure text box's not editable
            makeReadOnly();

            // Do not allow the Doctor to see the cancelButton
            cancelButton.Visible = false;

            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Update Procedure";

            // Display information message
            MessageBox.Show("Patient's procedure has been updated!",
            "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Allow the Docotr to not update the procdure
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Save Procedure")
            {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add ScheduledProcedureGrid to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new ScheduledProcdureGrid());
            }
            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Save Procedure";

            // Do not allow the Doctor to see the cancelButton
            cancelButton.Visible = false;

            // Makes the patient's procdure text box's not editable
            makeReadOnly();
        }
    }
}
