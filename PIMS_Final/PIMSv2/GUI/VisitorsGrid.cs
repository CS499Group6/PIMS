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
        PIMSController.Patient patient;

        public VisitorsGrid()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            foreach (PIMSController.Visitor visitor in patient.directory.visitors)
            {
                visitorDataGridView.Rows.Add(visitor.name);
            }
        }
    }
}
