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
    public partial class doctorNotesForm : Form
    {
        PIMSController.User user;
        PIMSController.Patient patient;
        public doctorNotesForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            user    = PimsMain.Program.currentUser;
            patient = PimsMain.Program.currentPatient;

            if (user is PIMSController.Doctor)
            {
                docNotesTextBox.ReadOnly = false;
            }
            else
            {
                docNotesTextBox.ReadOnly = true;
            }
            docNotesTextBox.Text = patient.treatment.docNotes;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            patient.treatment.docNotes = docNotesTextBox.Text;
            PIMSController.SQLcommands.updatePatient(patient);

        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
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

        private void prescriptionInfoToolStripMenuItem_Click(object sender, EventArgs e)
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
                PIMS.volunteerGrid volGrid = new PIMS.volunteerGrid(lastNameQuery);
                volGrid.Visible = true;
                this.Hide();
            }
            else if (PimsMain.Program.currentUser is PIMSController.Doctor ||
                    PimsMain.Program.currentUser is PIMSController.MedStaff ||
                    PimsMain.Program.currentUser is PIMSController.OfficeStaff)
            {
                PIMS.mainGrid MainGrid = new PIMS.mainGrid(lastNameQuery);
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
    }
}
