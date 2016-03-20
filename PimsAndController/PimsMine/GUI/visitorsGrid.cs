using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*--- Visitor info form
the purpose of this form is to display the approved list of visitors for a
specific patient 
*/
namespace PIMS
{
    public partial class visitorsGrid : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public visitorsGrid()
        {
            InitializeComponent();
            this.ControlBox = false;
            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;

            foreach (PIMSController.Visitor visitor in patient.directory.visitors)
            {
                dgv.Rows.Add(null, visitor.name);
            }
            if (user is PIMSController.Volunteer)
            {
                treatmentToolStripMenuItem.Enabled = false;
                billingToolStripMenuItem.Enabled = false;
                directoryToolStripMenuItem.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                nameBox.Visible = false;

            }
            else
            {
                volunteerGridToolStripMenuItem.Enabled = false;
            }
            if(user is PIMSController.OfficeStaff)
            {
                treatmentToolStripMenuItem.Enabled = false;
            }
            if(user is PIMSController.Doctor || user is PIMSController.MedStaff)
            {
                button1.Visible = false;
                button2.Visible = false;
                nameBox.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Doing nothing on purpose here
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locationForm location = new locationForm();
            location.Visible = true;
            this.Hide();
        }

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientForm patient = new patientForm();
            patient.Visible = true;
            this.Hide();
        }

        private void insuranceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.insuranceForm insForm = new PIMS.insuranceForm();
            insForm.Visible = true;
            // hide this one
            this.Hide();
        }

        private void summaryBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.billingGrid sumBill = new PIMS.billingGrid(false);
            sumBill.Visible = true;
            this.Hide();
        }

        private void detailedBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.billingGrid sumBill = new PIMS.billingGrid();
            sumBill.Visible = true;
            this.Hide();
        }

        private void scheduledProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.GUI.SchedProcForm procForm = new PimsMain.GUI.SchedProcForm();
            procForm.Visible = true;
            this.Hide();
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.prescriptionGrid drugs = new PIMS.prescriptionGrid();
            drugs.Visible = true;
            this.Hide();
        }

        private void nurseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.nurseNotes theseNurseNotes = new PIMS.nurseNotes();
            theseNurseNotes.Visible = true;
            this.Hide();
        }

        private void doctorNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.doctorNotesForm theseDocNotes = new PIMS.doctorNotesForm();
            theseDocNotes.Visible = true;
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String lastNameQuery = searchBox.Text.ToUpper();
            PimsMain.Program.currentPatient = null;
            //Open MainGrid
            if (PimsMain.Program.currentUser is PIMSController.Volunteer)
            {
                volunteerGrid volGrid = new volunteerGrid(lastNameQuery);
                volGrid.Visible = true;
                this.Hide();
            }
            else if (PimsMain.Program.currentUser is PIMSController.Doctor ||
                    PimsMain.Program.currentUser is PIMSController.MedStaff ||
                    PimsMain.Program.currentUser is PIMSController.OfficeStaff)
            {
                mainGrid MainGrid = new mainGrid(lastNameQuery);
                MainGrid.Visible = true;
                //Hide mainForm
                this.Hide();
            }
            else
            {
                // This case should not happen, but here just in case
                MessageBox.Show("Invalid User! Closing Program",
                        "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PIMSController.Visitor visitor = new PIMSController.Visitor();
            visitor.name = nameBox.Text;
            patient.directory.visitors.Add(visitor);
            PIMSController.SQLcommands.updatePatient(patient);

            dgv.Rows.Clear();
            foreach (PIMSController.Visitor person in patient.directory.visitors)
            {
                dgv.Rows.Add(null, person.name);
            }
            nameBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    names.Add(row.Cells[1].Value.ToString());
                }
            }
            foreach (string name in names.ToList())
            {
                foreach (PIMSController.Visitor visitor in patient.directory.visitors)
                {
                    if (name.Equals(visitor.name))
                    {
                        patient.directory.visitors.Remove(visitor);
                        break;
                    }
                    
                }
            }
            dgv.Rows.Clear();
            foreach (PIMSController.Visitor person in patient.directory.visitors)
            {
                dgv.Rows.Add(null, person.name);
            }
        }

        private void volunteerGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            volunteerGrid vol = new volunteerGrid(PimsMain.Program.currentPatient.directory.lName.ToUpper());
            
            vol.Visible = true;
            this.Hide();
        }
    }
}
