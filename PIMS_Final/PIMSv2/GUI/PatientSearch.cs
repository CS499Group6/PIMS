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
    public partial class PatientSearch : UserControl
    {
        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();

        public PatientSearch()
        {
            InitializeComponent();

            patients = PIMSController.SQLcommands.getPatientList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String lastNameQuery = searchBox.Text.ToUpper();

            Boolean found = false;
            foreach (PIMSController.Patient myPatient in patients)
            {
                if (lastNameQuery.Length > 2 && myPatient.directory.lName.ToUpper().StartsWith(lastNameQuery))
                {
                    found = true;
                }
            }
            if (!found)
            {
                if(Program.currentUser is PIMSController.OfficeStaff)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to create a new patient?", "Patient not found in database!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Add the newPatientLeftSideButtons to the Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Add(Program.newPatientLeftSideButtons);

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the PatientForm to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new NewPatientForm());
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the PatientSerach to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
                    }
                }
                else
                {
                    MessageBox.Show("Patient not found in database! \n Please search for a new patient",
                   "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear contents of Panel2
                    Program.myForm.splitContainer1.Panel2.Controls.Clear();
                    // Add the PatientSerach to the Panel2
                    Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
                }
            }
            else if (found)
            {
                if (searchBox.Text != "")
                {
                    // Open grid depending on currentUser type
                    if (PIMS.Program.currentUser is PIMSController.Volunteer)
                    {
                        // Clear contents of Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Clear();
                        // Add StartLeftSideButtons to the Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Add(new StartLeftSideButtons());

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the volunteerResultsGrid to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new VolunteerResultsGrid(lastNameQuery));
                    }
                    else if (Program.currentUser is PIMSController.Doctor ||
                            Program.currentUser is PIMSController.MedStaff ||
                            Program.currentUser is PIMSController.OfficeStaff)
                    {
                        // Add the StartLeftSideButtons to the Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Add(new StartLeftSideButtons());

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the ResultsGrid form to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(lastNameQuery));
                    }
                    else
                    {
                        MessageBox.Show("Invalid User! Closing Program",
                                "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter in a patient's name",
                         "No information entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
