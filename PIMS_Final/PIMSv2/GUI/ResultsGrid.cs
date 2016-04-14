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

        public ResultsGrid(String lastNameQuery)
        {
            InitializeComponent();

            Program.lastNameQuery = lastNameQuery;

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            patients = PIMSController.SQLcommands.getPatientList();

            fillDGV(lastNameQuery);
        }

        private void fillDGV(string query)
        {
            foreach (PIMSController.Patient myPatient in patients)
            {
                if (query.Length > 2 && myPatient.directory.lName.ToUpper().StartsWith(query))
                {
                       dataGridView1.Rows.Add(null,
                                                      myPatient.directory.patientID,
                                                      myPatient.directory.lName,
                                                      myPatient.directory.fName,
                                                      myPatient.directory.mName,
                                                      myPatient.directory.DOB.ToString(@"MM\/dd\/yyyy"),
                                                      myPatient.directory.phoneNum1,
                                                      myPatient.directory.phoneNum2,
                                                      myPatient.directory.isAdmitted ? "Y" : "N");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string currentID = "";
            int count = 0;
            // make sure just 1 is selected since it wont take radio buttons

            foreach (DataGridViewRow row in dataGridView1.Rows)
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
    }
}
