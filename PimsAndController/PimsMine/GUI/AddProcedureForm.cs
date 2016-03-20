using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimsMain.GUI
{
    public partial class AddProcedureForm : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public AddProcedureForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PIMSController.MedProcedure proc = new PIMSController.MedProcedure();
            proc.who = whoBox.Text;
            proc.when = Convert.ToDateTime(whenBox.Text);
            proc.where = whereBox.Text;
            proc.what = whatBox.Text;

            patient.treatment.procedures.Add(proc);

            PIMSController.SQLcommands.updatePatient(patient);

            SchedProcForm procedure = new SchedProcForm();
            procedure.Visible = true;
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void whatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void whenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void secheduledProceduresToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.patientForm patient = new PIMS.patientForm();
            patient.Visible = true;
            this.Hide();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.locationForm location = new PIMS.locationForm();
            location.Visible = true;
            this.Hide();
        }

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.visitorsGrid visitors = new PIMS.visitorsGrid();
            visitors.Visible = true;
            this.Hide();
        }
    }
}
