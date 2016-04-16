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
    public partial class NurseNotesGrid : UserControl
    {
        int count = 1;

        public NurseNotesGrid()
        {
            InitializeComponent();

            allergiesTextBox.Text = Program.currentPatient.treatment.allergies;
            notesTextBox.Text = Program.currentPatient.treatment.medStaffNotes.nurseNotes;

            // Do not allow users to add new rows to nurseNotesDataGridView
            nurseNotesDataGridView.AllowUserToAddRows = false;

            // Add a new event handler
            nurseNotesDataGridView.CellValueChanged += nurseNotesDataGridView_CellValueChanged;

            fillNurseNotesDataGridView();

            // Makes the various treatment text box's not editable
            makeReadOnly();
        }

        // Makes the various treatment text box's not editable
        private void makeReadOnly()
        {
            allergiesTextBox.ReadOnly = true;
            notesTextBox.ReadOnly = true;
        }

        // Will fill the nurseNotesDataGridView with the list of nurse's notes
        private void fillNurseNotesDataGridView()
        {
            PIMSController.MedStaffNotes.patientStats stats =
                Program.currentPatient.treatment.medStaffNotes.statList[Program.currentPatient.treatment.medStaffNotes.statList.Count - count];

            nurseNotesDataGridView.Rows.Add(null, stats.idNum, "Nurse", stats.time,
                                                                                    stats.patientHeight,
                                                                                    stats.patientWeight,
                                                                                    (stats.bloodPressureSys + "/" + stats.bloodPressureDia).ToString(),
                                                                                    stats.heartrate.ToString());
        }

        // If the nurseNotesDataGridView is clicked
        // Commit that edit
        private void nurseNotesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nurseNotesDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // The cell was selected
        private void nurseNotesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int currentID = 0;
            int count = 0;

            foreach (DataGridViewRow row in nurseNotesDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = (int)row.Cells[1].Value;
                }
                Console.WriteLine("Test");
            }
            if (count == 0)
            {
                MessageBox.Show("Please select a stat.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one stat.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Console.WriteLine("Test2");
                foreach (PIMSController.MedStaffNotes.patientStats stat in Program.currentPatient.treatment.medStaffNotes.statList)
                {
                    if (stat.idNum == currentID)
                    {
                        Console.WriteLine("Test");
                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add LeftSideButtons to Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new NurseNotesForm(stat));
                    }
                }
            }
        }

        // Will update the patient's allergies
        private void updateAllergiesButton_Click(object sender, EventArgs e)
        {
            if (updateAllergiesButton.Text == "Update Allergies")
            {
                // Makes the allergiesTextBox editable
                allergiesTextBox.ReadOnly = false;

                // Change the updateAllergiesButton text
                updateAllergiesButton.Text = "Save Allergies";

                // Exit out of this function
                return;
            }
            else if (updateAllergiesButton.Text == "Save Allergies")
            {
                // Update allergies in the database
                Program.currentPatient.treatment.medStaffNotes.allergies = allergiesTextBox.Text;
                PIMSController.SQLcommands.updatePatient();

                // Makes the allergiesTextBox not editable
                allergiesTextBox.ReadOnly = true;

                // Change the saveUpdateButton text
                updateAllergiesButton.Text = "Update Allergies";
            }
        }

        // Will update the nurse's notes
        private void updateNurseNotesButton_Click(object sender, EventArgs e)
        {
            if (updateNurseNotesButton.Text == "Update Nurse Notes")
            {
                // Makes the notesTextBox not editable
                notesTextBox.ReadOnly = false;

                // Change the updateNurseNotesButton text
                updateNurseNotesButton.Text = "Save Nurse Notes";

                // Exit out of this function
                return;
            }
            else if (updateAllergiesButton.Text == "Save Nurse Notes")
            {
                // Update nurse note's in the database
                Program.currentPatient.treatment.medStaffNotes.nurseNotes = notesTextBox.Text;
                PIMSController.SQLcommands.updatePatient();

                // Makes the allergiesTextBox editable
                allergiesTextBox.ReadOnly = true;

                // Change the updateAllergiesButton text
                updateAllergiesButton.Text = "Update Nurse Notes";
            }
        }

        private void addStat_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add LeftSideButtons to Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Add(new NurseNotesForm(new PIMSController.MedStaffNotes.patientStats()));
        }

       
    }
}
