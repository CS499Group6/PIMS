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
        PIMSController.User curUser;
        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
        PIMSController.Patient selectedPatient = null;
        public mainGrid(String lastNameQuery, PIMSController.User user)
        {
            InitializeComponent();
            curUser = user;

            patients.Add(new PIMSController.Patient());
            patients.Add(new PIMSController.Patient());
            patients.Add(new PIMSController.Patient());

            Boolean found = false;
            foreach (var myPatient in patients)
            {
                if (myPatient.directory.lName.ToUpper().StartsWith(lastNameQuery))
                {
                    found = true;
                    String firstName = myPatient.directory.fName;
                    string middleName = myPatient.directory.mName;
                    string dateOfBirth = myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy");
                    string lastName = myPatient.directory.lName;

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
              //  Console.WriteLine(row.Cells[0].Value.ToString());
             //   Console.WriteLine(row.Cells[0].Value.Equals(false));
                //DataRow currentRow = ((DataRowView)row.DataBoundItem).Row;
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = row.Cells[1].Value.ToString();
                    Console.WriteLine(count);
                    Console.WriteLine(currentID);
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please select a row.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one row.",
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
                patientForm myPatientForm = new patientForm(selectedPatient, curUser);
                myPatientForm.Visible = true;
                // hide this one
                this.Hide();

            }

        }
    }
    }

