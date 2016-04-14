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
    public partial class NewPatientLeftSideButtonscs : UserControl
    {
        public NewPatientLeftSideButtonscs()
        {
            InitializeComponent();
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            NewPatientForm newPatientForm = new NewPatientForm();

            // Add PatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(newPatientForm);

            newPatientForm.makeReadable();
        }

        private void editBillingButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new BillingForm());
        }

        private void editInsuranceButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            NewInsuranceForm newInsuranceForm = new NewInsuranceForm();

            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(newInsuranceForm);

            newInsuranceForm.makeReadable();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
