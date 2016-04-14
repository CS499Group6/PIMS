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
    public partial class OfficeStaffVisitorsGrid : UserControl
    {
        PIMSController.Patient patient;

        public OfficeStaffVisitorsGrid()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            foreach (PIMSController.Visitor visitor in patient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, visitor.name);
            }
        }

        private void addVisitorButton_Click(object sender, EventArgs e)
        {
            PIMSController.Visitor visitor = new PIMSController.Visitor();

            visitor.name = nameBox.Text;
            patient.directory.visitors.Add(visitor);
            PIMSController.SQLcommands.updatePatient(patient);

            visitorDataGridView.Rows.Clear();
            foreach (PIMSController.Visitor person in patient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, person.name);
            }
            nameBox.Text = "";
        }

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
                foreach (PIMSController.Visitor visitor in patient.directory.visitors)
                {
                    if (name.Equals(visitor.name))
                    {
                        patient.directory.visitors.Remove(visitor);
                        break;
                    }
                }
            }
            visitorDataGridView.Rows.Clear();
            foreach (PIMSController.Visitor person in patient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(null, person.name);
            }
        }
    }
}
