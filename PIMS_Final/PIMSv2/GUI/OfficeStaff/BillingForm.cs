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
    public partial class BillingForm : UserControl
    {
        public BillingForm()
        {
            InitializeComponent();

            if (Program.currentPatient != null)
            {
                // Billing is done funky!

                //itemBox.Text = 
                //costBox.Text = 
                //insPaidBox.Text = 
                //paidBox.Text = 
                //dueBox.Text = 
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //itemBox.Text;
            //costBox.Text;
            //insPaidBox.Text;
            //paidBox.Text;
            //dueBox.Text;
        }

        private void printButon_Click(object sender, EventArgs e)
        {

        }       
    }
}
