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
    public partial class LeftSideButtons : UserControl
    {
        PIMSController.User currUser;

        // Default Constructor
        public LeftSideButtons()
        {
            InitializeComponent();

            currUser = Program.currentUser;
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
                groupBox2.Text = "Edit Selected Patients:";
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
            // Add PatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(Program.lastNameQuery));
        }

        private void profileInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            PatientForm patientForm = new PatientForm();

            // Add PatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(patientForm);

            patientForm.makeReadOnly();
        }

        private void billingInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new BillingGrid());
        }

        private void insuranceInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            InsuranceForm insuranceForm = new InsuranceForm();

            // Add InsuranceGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(insuranceForm);

            insuranceForm.makeReadOnly();
        }

        private void treatmentInformationButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new TreatmentForm());
        }

        private void approvedVisitorsButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new VisitorsGrid());
        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;
            Program.currentUser = null;

            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add Login form to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new Login());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
