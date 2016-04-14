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
        }

        private void billingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomAssignmentDataGridView.CellValueChanged += roomAssignmentDataGridView_CellValueChanged;
        }

        private void roomAssignmentDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
