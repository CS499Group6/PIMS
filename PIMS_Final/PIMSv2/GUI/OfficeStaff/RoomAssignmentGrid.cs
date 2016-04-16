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
    public partial class RoomAssignmentGrid : UserControl
    {
        // Default Constructor
        public RoomAssignmentGrid()
        {
            InitializeComponent();

            // Do not allow users to add new rows to roomAssignmentDataGridView
            roomAssignmentDataGridView.AllowUserToAddRows = false;

            // Add a new event handler
            roomAssignmentDataGridView.CellValueChanged += roomAssignmentDataGridView_CellValueChanged;
        }

        // If the resultsDataGridView is clicked
        // Commit that edit
        private void roomAssignmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomAssignmentDataGridView.CellValueChanged += roomAssignmentDataGridView_CellValueChanged;
        }

        // The cell was selected
        private void roomAssignmentDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.currentPatient != null)
            {
                foreach (DataGridViewRow row in roomAssignmentDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                    {
                        Program.currentPatient.directory.location.bedNum = row.Cells[1].Value.ToString();
                        Program.currentPatient.directory.location.roomNum = row.Cells[2].Value.ToString();
                        Program.currentPatient.directory.location.unit = row.Cells[3].Value.ToString();
                    }
                }
            }

            //// This is a new patient
            //// Create a new patient
            //if (createNew)
            //    PIMSController.SQLcommands.createPatient();
            //// This is an existing patient
            //// Update the exisitng patient
            //else
            //    PIMSController.SQLcommands.updatePatient(Program.currentPatient);
        }

        private void assignButton_Click(object sender, EventArgs e)
        {

        }
    }
}
