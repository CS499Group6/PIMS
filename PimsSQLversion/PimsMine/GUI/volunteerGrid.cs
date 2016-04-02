using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIMS
{
    public partial class volunteerGrid : Form
    {
        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
        PIMSController.Patient selectedPatient = null;
        public volunteerGrid(string lastNameQuery)
        {
            InitializeComponent();
            this.ControlBox = false;

            //patients = PIMSController.SQLcommands.getPatientList();


            fillVolDGV(lastNameQuery);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.volDGV.DataSource = null;
            this.volDGV.Rows.Clear();
            this.volDGV.Refresh();
            fillVolDGV(textBox1.Text.ToUpper());
        }

        private void fillVolDGV(string lastNameQuery)
        {
            List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
            patients = PIMSController.SQLcommands.getPatientList();

            Boolean found = false;
            foreach (var myPatient in patients)
            {
                if (lastNameQuery.Length > 2 && myPatient.directory.lName.ToUpper().StartsWith(lastNameQuery))
                {
                    found = true;
                    String firstName = myPatient.directory.fName;
                    string middleName = myPatient.directory.mName;
                    string dateOfBirth = myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy");
                    string lastName = myPatient.directory.lName;

                    volDGV.Rows.Add(null,
                                    myPatient.directory.patientID,
                                    myPatient.directory.lName,
                                    myPatient.directory.fName,
                                    myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy"),
                                    myPatient.directory.location.unit,
                                    myPatient.directory.location.roomNum,
                                    myPatient.directory.location.bedNum);

                }
            }

            if (!found)
            {
                MessageBox.Show("Patient not found in database! \n Please search for a new patient using at least 3 letters of last name",
                    "Patient not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            string currentID = "";
            int count = 0;
            // make sure just 1 is selected since it wont take radio buttons
            foreach (DataGridViewRow row in volDGV.Rows)
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
                    if (currentID != null && myPatient.directory.patientID == currentID)
                    {
                        selectedPatient = myPatient;
                    }
                }
                if (selectedPatient != null)
                {
                    PimsMain.Program.currentPatient = selectedPatient;
                    visitorsGrid visitors = new visitorsGrid();
                    visitors.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Selection Error, Please try again.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    
}
