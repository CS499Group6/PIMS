using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Word;

namespace PIMS
{
    public partial class OfficeStaffLeftSideButtons : UserControl
    {
        // Default Constructor
        public OfficeStaffLeftSideButtons()
        {
            InitializeComponent();
        }

        // Add text to groupBox1
        public void addGroupBoxText()
        {
            try
            {
                groupBox1.Text = "View " + Program.currentPatient.directory.fName + " " + Program.currentPatient.directory.lName + "'s:";
            }
            catch (Exception ex)
            {
                groupBox1.Text = "View Selected Patients:";
            }
        }

        // Will allow the Office Staff user to search for a new patent
        private void newSearchButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;

            // Clear contents of Panel and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
        }

        // Will go back to the search results
        private void backButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add StartLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new StartLeftSideButtons());
            // Add ResultsGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(Program.lastNameQuery));
        }

        // Will display the current patient's profile information
        private void profileInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add NewPatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientForm());
        }

        // Will display the current patient's billing information
        private void billingInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add OfficeStaffBillingGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new BillingGrid());
        }

        // Will display the current patient's insurance information
        private void insuranceInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add NewInsuranceForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new InsuranceForm());
        }

        // Will display the current patient's location
        private void locationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add NewInsuranceForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new LocationForm());
        }

        // Will display the current patient's list of approved visitors
        private void approvedVisitorsButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new VisitorsGrid());
        }

        // Will log the Office Staff user off of the server
        private void logOffButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;
            Program.currentUser = null;

            Program.myForm.label2.Text = "";

            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add Login form to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new Login());
        }

        private void dischargeButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add DischargeForm form to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new DischargePatientForm());
        }

        // Will exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
