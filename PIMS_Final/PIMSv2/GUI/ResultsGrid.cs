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
    public partial class ResultsGrid : UserControl
    {
        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
        PIMSController.Patient selectedPatient = null;

        // Deafualt Constructor
        public ResultsGrid(String lastNameQuery)
        {
            InitializeComponent();

            Program.lastNameQuery = lastNameQuery;

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                addPatientButton.Visible = false;
            }

            resultsDataGridView.CellValueChanged += dataGridView1_CellValueChanged;

            patients = PIMSController.SQLcommands.getPatientList();

            fillDGV(lastNameQuery);
        }

        // Will fill the dataGridView with the list of available patient's
        private void fillDGV(string query)
        {
            foreach (PIMSController.Patient myPatient in patients)
            {
                if (query.Length > 2 && myPatient.directory.lName.ToUpper().StartsWith(query))
                {
                       resultsDataGridView.Rows.Add(null,
                                                      myPatient.directory.patientID,
                                                      myPatient.directory.lName,
                                                      myPatient.directory.fName,
                                                      myPatient.directory.mName,
                                                      myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy"),
                                                      myPatient.directory.gender,
                                                      myPatient.directory.phoneNum1,
                                                      myPatient.directory.phoneNum2,
                                                      myPatient.directory.location.roomNum,
                                                      myPatient.directory.location.bedNum,
                                                      myPatient.directory.location.floor,
                                                      myPatient.directory.isAdmitted ? "Y" : "N");
                }
            }
        }


        // If the resultsDataGridView is clicked
        // Commit that edit
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resultsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string currentID = "";
            int count = 0;
            // make sure just 1 is selected since it wont take radio buttons

            foreach (DataGridViewRow row in resultsDataGridView.Rows)
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

                Program.currentPatient = PIMSController.SQLcommands.buildPatient(selectedPatient.directory.patientID);

                if (Program.currentUser is PIMSController.OfficeStaff)
                {
                    // Clear contents of Panel1
                    Program.myForm.splitContainer1.Panel1.Controls.Clear();
                    // Add LeftSideButtons to Panel2
                    Program.myForm.splitContainer1.Panel1.Controls.Add(Program.officeStaffLeftSideButton);

                    // Call the addGroupBoxText function in officeStaffLeftSideButton
                    Program.officeStaffLeftSideButton.addGroupBoxText();
                }
                else
                {
                    // Clear contents of Panel1
                    Program.myForm.splitContainer1.Panel1.Controls.Clear();
                    // Add LeftSideButtons to Panel2
                    Program.myForm.splitContainer1.Panel1.Controls.Add(Program.leftSideButton);

                    // Call the addGroupBoxText function in leftSideButton
                    Program.leftSideButton.addGroupBoxText();
                }
            }
        }

        // Will allow the Office Staff to add anew patient if they are not in the ResultsGrid
        private void addPatientButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add NewPatientLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new NewPatientLeftSideButtons());
            // Add PatientForm to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientForm());
        }
    }
}
