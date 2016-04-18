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
    public partial class ScheduledProcdureGrid : UserControl
    {
        public ScheduledProcdureGrid()
        {
            InitializeComponent();

            // If the current user is not a Doctor
            // Don't allow the user to see the addProcedureButton
            if (!(Program.currentUser is PIMSController.Doctor))
            {
                addProcedureButton.Visible = false;

                this.procedureDataGridView.Columns[0].Visible = false;
            }

            foreach (PIMSController.MedProcedure proc in Program.currentPatient.treatment.procedures)
            {
                string date = proc.when.Date.ToShortDateString();
                string time = proc.when.TimeOfDay.ToString();

                procedureDataGridView.Rows.Add(null, proc.id, proc.what, date, time, proc.who, proc.where);
            }

            // Do not allow users to add new rows to scheduledProcdureGrid
            procedureDataGridView.AllowUserToAddRows = false;

            // Add a new event handler
            procedureDataGridView.CellValueChanged += procedureDataGridView_CellValueChanged;

        }

        // Will allow the Doctor to create a new Procedure
        private void addProcedureButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add LeftSideButtons to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ScheduledProcedureForm(new PIMSController.MedProcedure()));
        }

        // If the scheduledProcdureGrid is clicked
        // Commit that edit
        private void procedureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            procedureDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }


        // The cell was selected
        private void procedureDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int currentID = 0;
            int count = 0;

            foreach (DataGridViewRow row in procedureDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = (int)row.Cells[1].Value;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please select a procedure.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one procedure.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (PIMSController.MedProcedure proc in Program.currentPatient.treatment.procedures)
                {
                    if (proc.id == currentID)
                    {
                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add LeftSideButtons to Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new ScheduledProcedureForm(proc));
                    }
                }
            }
        }      
    }
}
