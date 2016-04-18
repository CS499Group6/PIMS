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
    public partial class VisitorsGrid : UserControl
    {
        // Default Constructor
        public VisitorsGrid()
        {
            InitializeComponent();

            // Do not allow users to add new rows to visitorDataGridView
            visitorDataGridView.AllowUserToAddRows = false;

            // If the current user is not an OfficeStaff
            // Don't allow the user to see various items
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                nameTextBox.Visible = false;
                addVisitorButton.Visible = false;
                removeVisitorButton.Visible = false;

                this.visitorDataGridView.Columns[0].Visible = false;
            }

            // Fill the visitorDataGridView with the list of the patient's approved visitors
            fillVisitorDataGridView();
        }

        // Will fill the visitorDataGridView with the list of the patient's approved visitors
        private void fillVisitorDataGridView()
        {
            foreach (PIMSController.Visitor visitor in Program.currentPatient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, visitor.name);
            }
        }

        // Will allow the Office Staff user to add approved vistor's to the patient's profile
        private void addVisitorButton_Click(object sender, EventArgs e)
        {
            PIMSController.Visitor visitor = new PIMSController.Visitor();

            visitor.name = nameTextBox.Text;

            Program.currentPatient.directory.visitors.Add(visitor);
            PIMSController.SQLcommands.updatePatient();

            visitorDataGridView.Rows.Clear();

            foreach (PIMSController.Visitor person in Program.currentPatient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, person.name);
            }

            nameTextBox.Text = "";
        }

        // Will allow the Office Staff user to remove approved vistor's from the patient's profile
        private void removeVisitorButton_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            foreach (DataGridViewRow row in visitorDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    names.Add(row.Cells[1].Value.ToString());
                }
            }

            foreach (string name in names.ToList())
            {
                foreach (PIMSController.Visitor visitor in Program.currentPatient.directory.visitors)
                {
                    if (name.Equals(visitor.name))
                    {
                        Program.currentPatient.directory.visitors.Remove(visitor);
                        break;
                    }
                }
            }

            visitorDataGridView.Rows.Clear();

            PIMSController.SQLcommands.updatePatient();

            foreach (PIMSController.Visitor person in Program.currentPatient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, person.name);
            }
        }
    }
}
