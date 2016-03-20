using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*---Perscription entry form------
the purpose of this form is to allow doctors or pharmacy staff
to enter perscription
data
*/



namespace PIMS
{
    public partial class prescriptionForm : Form
    {
        public prescriptionForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
