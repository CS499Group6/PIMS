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
    public partial class NewPatientLeftSideButtons : UserControl
    {
        // Default Constructor
        public NewPatientLeftSideButtons()
        {
            InitializeComponent();

            addGroupBoxText();
        }

        // Add text to groupBox1
        public void addGroupBoxText()
        {
            try
            {
                groupBox1.Text = "Add information to new patient:";
            }
            catch (Exception ex)
            {
                groupBox1.Text = "View Selected Patients:";
            }
        }

        // Will allow the Office Staff user to serach for a new patient
        private void newSearchButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
        }

        // Will allow the Office Staff user to edit the patient's profile information
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;

            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientForm());
        }

        // Will allow the Office Staff user to edit the patient's billing information
        private void editBillingButton_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient != null)
            {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add BillingForm to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new BillingForm(new PIMSController.BillingLineItem()));
            }
            else
            {
                // Display information message
                MessageBox.Show("You must create a new patient before proceeding! \n Do this by going to 'Edit Profile Information'!",
                "No Patient!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will allow the Office Staff user to edit the patient's insurance information
        private void editInsuranceButton_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient != null)
            {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add InsuranceForm to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new InsuranceForm());
            }
            else
            {
                // Display information message
                MessageBox.Show("You must create a new patient before proceeding! \n Do this by going to 'Edit Profile Information'!",
                "No Patient!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will display the current patient's list of approved visitors
        private void addVisitorsButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new VisitorsGrid());
        }

        // Will allow the Office Staff user to assign the patient a room
        private void assignRoomButton_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient != null)
            {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add PatientSearch to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new RoomAssignmentGrid());
            }
            else
            {
                // Display information message
                MessageBox.Show("You must create a new patient before proceeding! \n Do this by going to 'Edit Profile Information'!",
                "No Patient!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
