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

        // Default Constructor
        public PatientSearch()
        {
            InitializeComponent();

            patients = PIMSController.SQLcommands.getPatientList();

            // Add a new event handler
            searchTextBox.KeyDown += searchTextBox_KeyDown;
        }

        // A key press event has happened
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the key press event was an "Enter" key
            if (e.KeyCode == Keys.Return)
            {
                // Allow the user to search for a patient
                searchButton_Click(sender, e);
            }
        }

        // When the PatientSearch form loads into the splitContainer1
        private void PatientSearch_Load(object sender, EventArgs e)
        {
            // Set the active control to the searchTextBox
            this.ActiveControl = searchTextBox;
        }

        // Will allow the user to search for a new patient
        private void searchButton_Click(object sender, EventArgs e)
        {
            string lastNameQuery = searchTextBox.Text.ToUpper();
            string newLastNameQuery = lastNameQuery.Replace(".", "");

            Console.WriteLine("newLastName = ", newLastNameQuery);

            Boolean found = false;

            // Make sure we have at least 3 characters
            if (newLastNameQuery.Length < 3)
            {
                // Display error message
                MessageBox.Show("Please enter in at least 3 letters of the patient's last name",
                "Not enough characters!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                searchTextBox.Clear();
            }

            // We have at least 3 charcters to use to query the database
            else
            {
                // For all patient's in the database
                foreach (PIMSController.Patient myPatient in patients)
                {
                    // If the current patient in myPatient is the patient the user searched for
                    if (newLastNameQuery.Length > 2 && (myPatient.directory.lName.ToUpper().StartsWith(newLastNameQuery) || 
                                                        myPatient.directory.fName.ToUpper().StartsWith(newLastNameQuery)))
                    {
                        found = true;
                    }   
                }
                // Patient was not found in the database
                if (!found)
                {
                    // If the current user is Office Staff
                    // Allow them the option to create a new patient
                    if (Program.currentUser is PIMSController.OfficeStaff)
                    {
                        DialogResult dialogResult = MessageBox.Show("Would you like to create a new patient?", "Patient not found in database!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Program.currentPatient = null;

                            // Clear contents of Panel1
                            Program.myForm.splitContainer1.Panel1.Controls.Clear();
                            // Add the newPatientLeftSideButtons to the Panel1
                            Program.myForm.splitContainer1.Panel1.Controls.Add(Program.newPatientLeftSideButton);

                            // Clear contents of Panel2
                            Program.myForm.splitContainer1.Panel2.Controls.Clear();
                            // Add the PatientForm to the Panel2
                            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientForm());
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            // Clear contents of Panel2
                            Program.myForm.splitContainer1.Panel2.Controls.Clear();
                            // Add the PatientSerach to the Panel2
                            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
                        }
                    }
                    // Current user is not an Office Staff
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
                // Patient was found in the database
                else if (found)
                {
                    // Open a ResultsGrid depending on current user type
                    if (PIMS.Program.currentUser is PIMSController.Volunteer)
                    {
                        // Clear contents of Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Clear();
                        // Add StartLeftSideButtons to the Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Add(new StartLeftSideButtons());

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the volunteerResultsGrid to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new VolunteerResultsGrid(newLastNameQuery));
                    }
                    else if (Program.currentUser is PIMSController.Doctor ||
                            Program.currentUser is PIMSController.MedStaff ||
                            Program.currentUser is PIMSController.OfficeStaff)
                    {
                        // Clear contents of Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Clear();
                        // Add the StartLeftSideButtons to the Panel1
                        Program.myForm.splitContainer1.Panel1.Controls.Add(new StartLeftSideButtons());

                        // Clear contents of Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Clear();
                        // Add the ResultsGrid form to the Panel2
                        Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(newLastNameQuery));
                    }
                }
            }
        }
    }
}
