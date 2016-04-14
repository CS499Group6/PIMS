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
            PatientForm newPatientForm = new PatientForm();

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

            InsuranceForm newInsuranceForm = new InsuranceForm();

            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(newInsuranceForm);

            newInsuranceForm.makeReadable();
        }

        private void assignRoomButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new RoomAssignmentGrid());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
