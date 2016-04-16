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

            InitializeComponent();

            // If we have drugs to add
            // Add them
            if (drug.id != 0)
            {
                this.drugTextBox.Text = drug.name;
                this.ndcTextBox.Text = drug.ndc;
                this.sigTextBox.Text = drug.SIG;
                this.priceTextBox.Text = drug.cost.ToString();
                this.physicianTextBox.Text = drug.prescribingPhysician;
                this.dateTextBox.Text = drug.dateFilled.ToString(@"MM\/dd\/yyyy");

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
            this.drugTextBox.ReadOnly = true;
            this.ndcTextBox.ReadOnly = true;
            this.sigTextBox.ReadOnly = true;
            this.priceTextBox.ReadOnly = true;
            this.physicianTextBox.ReadOnly = true;
            this.dateTextBox.ReadOnly = true;
        }

        // Makes the patient's prescription text box's editable
        public void makeReadable()
        {
            this.drugTextBox.ReadOnly = false;
            this.ndcTextBox.ReadOnly = false;
            this.sigTextBox.ReadOnly = false;
            this.priceTextBox.ReadOnly = false;
            this.physicianTextBox.ReadOnly = false;
            this.dateTextBox.ReadOnly = false;
        }

        // Will allow the Doctor or MedicalStaff to update a patient's prescriptions
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            tempDrug.name = this.drugTextBox.Text;
            tempDrug.ndc = this.ndcTextBox.Text;
            tempDrug.SIG = this.sigTextBox.Text;
            tempDrug.cost = int.Parse(this.priceTextBox.Text);
            tempDrug.prescribingPhysician = this.physicianTextBox.Text;
            tempDrug.dateFilled = Convert.ToDateTime(this.dateTextBox.Text);

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
                PIMSController.SQLcommands.statsIndex++;
                tempDrug.id = PIMSController.SQLcommands.statsIndex;

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
