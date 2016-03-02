using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*---Insurance Selection Form--
the purpose of this form is to 
allow staff to select and edit a 
patients insurance information
*/
namespace PIMS
{
    public partial class insuranceGrid : Form
    {
        public insuranceGrid()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
