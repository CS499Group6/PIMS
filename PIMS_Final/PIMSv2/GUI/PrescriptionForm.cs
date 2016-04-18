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
    public partial class PrescriptionForm : UserControl
    {
        PIMSController.PrescDrug tempDrug;

        // Default Constructor
        public PrescriptionForm(PIMSController.PrescDrug drug)
        {
            tempDrug = drug;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            InitializeComponent();

            BindingSource bs = new BindingSource();
            bs.DataSource = PIMS.Program.drugs;
            comboBox1.DataSource = bs;

            if (drug.prescribingPhysician != "new")
            {
                this.physicanTextBox.Text = Program.currentUser.name;
            }

            // If we have drugs to add
            // Add them
            if (drug.id != 0)
            {
                this.comboBox1.Text = drug.drug.name;
                this.sigTextBox.Text = drug.SIG;
                this.dateTimePicker1.Value = drug.dateFilled;

                // Makes the patient's prescription text box's not editable
                makeReadOnly();
            }
            // This is a new drug
            else
            {
                // Makes the patient's prescription text box's editable
                makeReadable();

                saveUpdateButton.Text = "Save New Prescription";
            }
        }

        // Makes the patient's prescription text box's not editable
        public void makeReadOnly()
        {
            this.sigTextBox.ReadOnly = true;
            this.dateTimePicker1.Enabled = false;
            this.comboBox1.Enabled = false;

        }

        // Makes the patient's prescription text box's editable
        public void makeReadable()
        {
            this.sigTextBox.ReadOnly = false;
            this.dateTimePicker1.Enabled = true;
            this.comboBox1.Enabled = true;
        }

        // Will allow the Doctor or MedicalStaff to update a patient's prescriptions
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            tempDrug.ndc = PIMSController.SQLcommands.drugIndex.ToString();
            tempDrug.SIG = this.sigTextBox.Text;
            tempDrug.drug = (PIMS.Controller.Drug)comboBox1.SelectedValue;
            tempDrug.dateFilled = this.dateTimePicker1.Value;
            tempDrug.prescribingPhysician = this.physicanTextBox.Text;

            if (tempDrug.prescribingPhysician == null)
            {
                tempDrug.prescribingPhysician = Program.currentUser.name;
            }
            
            if (saveUpdateButton.Text == "Update Prescription")
            {
                // Makes the patient's medical stats editable
                makeReadable();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Prescription";

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save New Prescription")
            {
                PIMSController.SQLcommands.drugIndex++;
                tempDrug.id = PIMSController.SQLcommands.drugIndex;
                tempDrug.ndc = PIMSController.SQLcommands.drugIndex.ToString();

                Program.currentPatient.treatment.prescriptions.prescriptions.Add(tempDrug);
            }
            PIMSController.SQLcommands.updatePatient();

            // Makes the patient's prescription text box's not editable
            makeReadOnly();

            // Change the saveUpdateButton text
            saveUpdateButton.Text = "Update Prescription";

            // Display information message
            MessageBox.Show("Patient's prescriptions have been updated!",
            "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
