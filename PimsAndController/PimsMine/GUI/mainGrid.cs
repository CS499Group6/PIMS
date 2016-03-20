using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ---Patient query form----
The purpose for this form is for doctors, 
nurses and office staff to select a 
patient afer a search from the query box */
namespace PIMS
{
    public partial class mainGrid : Form
    {
        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
        PIMSController.Patient selectedPatient = null;
        PIMSController.User user;
        public mainGrid(String lastNameQuery)
        {
            InitializeComponent();
            this.ControlBox = false;
            user            = PimsMain.Program.currentUser;

            fileToolStripMenuItem1.Enabled     = false;
            treatmentToolStripMenuItem.Enabled = false;
            billingToolStripMenuItem.Enabled   = false;
            directoryToolStripMenuItem.Enabled = false;

            patients = PIMSController.SQLcommands.getPatientList();

            fillDGV(lastNameQuery);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientQueryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentID = "";
            int count = 0;
            // make sure just 1 is selected since it wont take radio buttons
            foreach (DataGridViewRow row in patientQueryDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = row.Cells[1].Value.ToString();
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please select a patient.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one patient.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (PIMSController.Patient myPatient in patients)
                {
                    if(currentID != null && myPatient.directory.patientID == currentID)
                    {
                        selectedPatient = myPatient;
                    }
                }

                // open patient grid
                PimsMain.Program.currentPatient = selectedPatient;
                patientForm myPatientForm = new patientForm();
                myPatientForm.Visible = true;
                // hide this one
                this.Hide();

            }

        }
        private void fillDGV(string query)
        {
            patients = PIMSController.SQLcommands.getPatientList();

            Boolean found = false;
            foreach (var myPatient in patients)
            {
                if (query.Length > 2 && myPatient.directory.lName.ToUpper().StartsWith(query))
                {
                    found = true;
                    String firstName = myPatient.directory.fName;
                    string middleName = myPatient.directory.mName;
                    string dateOfBirth = myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy");
                    string lastName = myPatient.directory.lName;
                    for(int i = 1; i < 9; i++)
                    {
                        patientQueryDataGridView.Columns[i].ReadOnly = true;
                    }
                    patientQueryDataGridView.Rows.Add(null,
                                                      myPatient.directory.patientID,
                                                      myPatient.directory.lName,
                                                      myPatient.directory.fName,
                                                      myPatient.directory.mName,
                                                      myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy"),
                                                      myPatient.directory.location.unit,
                                                      myPatient.directory.location.roomNum,
                                                      myPatient.directory.location.bedNum);


                }
            }
            if (!found)
            {
                MessageBox.Show("Patient not found in database! \n Please search for a new patient",
                    "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.patientQueryDataGridView.DataSource = null;
            this.patientQueryDataGridView.Rows.Clear();
            this.patientQueryDataGridView.Refresh();
            fillDGV(textBox1.Text.ToUpper());
            textBox1.Text = "";
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
            this.Hide();
        }

        private void visitorListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientForm patient = new patientForm(true);
            patient.Visible = true;
            this.Hide();
        }
    }
    }

