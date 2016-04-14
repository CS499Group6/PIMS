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
    public partial class InsuranceForm : UserControl
    {
        PIMSController.Patient patient;

        public InsuranceForm()
        {
            InitializeComponent();
            
            patient = Program.currentPatient;

            providerTextBox.Text = patient.billing.insurance.provider;
            binTextBox.Text = patient.billing.insurance.bin;
            idTextBox.Text = patient.billing.insurance.id;
            pcnTextBox.Text = patient.billing.insurance.pcn;
            groupTextBox.Text = patient.billing.insurance.groupNum;
            typeTextBox.Text = patient.billing.insurance.insuranceType;
        }

        public void makeReadOnly()
        {
            providerTextBox.ReadOnly = true;
            binTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;
            pcnTextBox.ReadOnly = true;
            groupTextBox.ReadOnly = true;
            typeTextBox.ReadOnly = true;
        }
    }
}
