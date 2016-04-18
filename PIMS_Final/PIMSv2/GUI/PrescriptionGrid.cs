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
    public partial class PrescriptionGrid : UserControl
    {
        // Default Constructor
        public PrescriptionGrid()
        {
            InitializeComponent();

            // If the current user is not an Doctor
            // Don't allow the user to see the addPrescriptionButton
            if (!(Program.currentUser is PIMSController.Doctor))
            {
                addCurrentPrescriptionButton.Visible = false;
                addNewPrescriptionButton.Visible = false;

                this.prescriptionDataGridView.Columns[0].Visible = false;
            }

            // Do not allow users to add new rows to prescriptionDataGridView
            prescriptionDataGridView.AllowUserToAddRows = false;

            // Add a new event handler
            prescriptionDataGridView.CellValueChanged += prescriptionDataGridView_CellValueChanged;

            // Fill the prescriptionDataGridView with the list of the patient's prescriptions
            fillPresriptionDataGridView();
        }

        // Will fill the prescriptionDataGridView with the list of the patient's prescriptions
        private void fillPresriptionDataGridView()
        {
            foreach (PIMSController.PrescDrug drug in Program.currentPatient.treatment.prescriptions.prescriptions)
            {
                prescriptionDataGridView.Rows.Add(null, drug.id, drug.drug.name, drug.SIG, ((float)drug.drug.cost / 100).ToString("N2"),
                    drug.dateFilled.ToString(@"MM\/dd\/yyyy"), drug.prescribingPhysician);
            }
        }

        // If the resultsDataGridView is clicked
        // Commit that edit
        private void prescriptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prescriptionDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // The cell was selected
        private void prescriptionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int currentID = 0;
            int count = 0;

            foreach (DataGridViewRow row in prescriptionDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = (int)row.Cells[1].Value;
                }

            }
            if (count == 0)
            {
                MessageBox.Show("Please select a prescription.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one prescription.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (PIMSController.PrescDrug drug in Program.currentPatient.treatment.prescriptions.prescriptions)
                {
                    if (currentID != 0 && drug.id == currentID && drug.prescribingPhysician == Program.currentUser.name)
                    {
                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add PrescriptionForm to Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new PrescriptionForm(drug));
                    }
                    else
                    {

                        
                        foreach (DataGridViewRow row in prescriptionDataGridView.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                            {
                                row.Cells[0].Value = false;
                            }
                        }
                        MessageBox.Show("You can not edit a prescription that you did not prescribe.",
                        "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Allow the user to add a new prescription for the patient
        private void addNewPrescriptionButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PrescriptionForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PrescriptionForm(new PIMSController.PrescDrug()));
        }

        // Allow the Docotor to add a current prescription for the patient
        private void addCurrentPrescriptionButton_Click(object sender, EventArgs e)
        {
            PIMSController.PrescDrug drug = new PIMSController.PrescDrug();
            drug.prescribingPhysician = "new";

            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PrescriptionForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PrescriptionForm(drug));
        }

        // Will allow the user to print all the patient's prescriptions
        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
