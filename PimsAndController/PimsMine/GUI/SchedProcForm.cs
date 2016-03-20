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
    public partial class SchedProcForm : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public SchedProcForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;

            foreach (PIMSController.MedProcedure proc in patient.treatment.procedures)
            {
                dataGridView1.Rows.Add(proc.what, proc.when.ToString("f"),
                                       proc.who, proc.where);

            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProcedureForm addProcForm = new AddProcedureForm();
            addProcForm.Visible = true;
            this.Hide();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
            this.Hide();
        }

        private void detailedBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.billingGrid sumBill = new PIMS.billingGrid();
            sumBill.Visible = true;
            this.Hide();
        }

        private void summaryBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.billingGrid sumBill = new PIMS.billingGrid(false);
            sumBill.Visible = true;
            this.Hide();
        }

        private void insuranceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.insuranceForm insForm = new PIMS.insuranceForm();
            insForm.Visible = true;
            // hide this one
            this.Hide();
        }

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.visitorsGrid visitors = new PIMS.visitorsGrid();
            visitors.Visible = true;
            this.Hide();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.locationForm location = new PIMS.locationForm();
            location.Visible = true;
            this.Hide();
        }

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.patientForm patient = new PIMS.patientForm();
            patient.Visible = true;
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
    }
}
