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
    public partial class OfficeStaffLeftSideButtons : UserControl
    {
        public OfficeStaffLeftSideButtons()
        {
            InitializeComponent();
        }

        public void addGroupBoxText()
        {
            try
            {
                groupBox1.Text = "View " + Program.currentPatient.directory.fName + " " + Program.currentPatient.directory.lName + "'s:";
                groupBox2.Text = "Edit " + Program.currentPatient.directory.fName + " " + Program.currentPatient.directory.lName + "'s:";
            }

            catch (Exception ex)
            {
                groupBox1.Text = "View Selected Patients:";
            }
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add ResultsGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(Program.lastNameQuery));
        }

        private void profileInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            PatientForm patientForm = new PatientForm();

            // Add patientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(patientForm);

            patientForm.makeReadOnly();
        }

        private void billingInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add OfficeStaffBillingGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new OfficeStaffBillingGrid());
        }

        private void insuranceInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            InsuranceForm insuranceForm = new InsuranceForm();

            // Add insuranceForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(insuranceForm);

            insuranceForm.makeReadOnly();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {

        }

        private void approvedVisitorsButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new OfficeStaffVisitorsGrid());
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            NewPatientForm newPatientForm = new NewPatientForm();

            // Add newPatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(newPatientForm);

            newPatientForm.makeReadable();
        }

        private void editBillingButton_Click(object sender, EventArgs e)
        {

        }

        private void editInsuranceButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            NewInsuranceForm newInsuranceForm = new NewInsuranceForm();

            // Add newInsuranceForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(newInsuranceForm);

            newInsuranceForm.makeReadable();
        }

        private void editLocationButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
