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
    public partial class NewInsuranceForm : UserControl
    {
        public NewInsuranceForm()
        {
            InitializeComponent();

            if (Program.currentPatient != null)
            {
                providerTextBox.Text = Program.currentPatient.billing.insurance.provider;
                binTextBox.Text = Program.currentPatient.billing.insurance.bin;
                idTextBox.Text = Program.currentPatient.billing.insurance.id;
                pcnTextBox.Text = Program.currentPatient.billing.insurance.pcn;
                groupTextBox.Text = Program.currentPatient.billing.insurance.groupNum;
                //typeComboBox.Items.Add("");
            }
        }

        public void makeReadOnly()
        {
            providerTextBox.ReadOnly = true;
            binTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;
            pcnTextBox.ReadOnly = true;
            groupTextBox.ReadOnly = true;
        }

        public void makeReadable()
        {
            providerTextBox.ReadOnly = false;
            binTextBox.ReadOnly = false;
            idTextBox.ReadOnly = false;
            pcnTextBox.ReadOnly = false;
            groupTextBox.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient.billing.insurance.provider = providerTextBox.Text;
            Program.currentPatient.billing.insurance.bin = binTextBox.Text;
            Program.currentPatient.billing.insurance.id = idTextBox.Text;
            Program.currentPatient.billing.insurance.pcn = pcnTextBox.Text;
            Program.currentPatient.billing.insurance.groupNum = groupTextBox.Text;
            Program.currentPatient.billing.insurance.insuranceType = typeComboBox.Text;
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
