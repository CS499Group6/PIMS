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
    public partial class locationForm : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public locationForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;

            floorBox.Text = patient.directory.location.floor;
            unitBox.Text = patient.directory.location.unit;
            bedBox.Text = patient.directory.location.bedNum;
            roomBox.Text = patient.directory.location.roomNum;

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox && ctrl.Name != "searchBox")
                {
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = SystemColors.Control;
                }
            }
            if(!(user is PIMSController.OfficeStaff))
            {
                fileToolStripMenuItem1.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient.directory.location.floor = floorBox.Text;
            patient.directory.location.unit = unitBox.Text;
            patient.directory.location.bedNum = bedBox.Text;
            patient.directory.location.roomNum = roomBox.Text;
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

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientForm patient = new patientForm();
            patient.Visible = true;
            this.Hide();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // does nothing intentionally
        }

        private void editModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "searchBox")
                {
                    ((TextBox)ctrl).ReadOnly = false;
                    ((TextBox)ctrl).BackColor = SystemColors.Window;
                }
            }
        }

        private void viewModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            floorBox.Text = patient.directory.location.floor;
            unitBox.Text = patient.directory.location.unit;
            bedBox.Text = patient.directory.location.bedNum;
            roomBox.Text = patient.directory.location.roomNum;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "searchBox")
                {
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = SystemColors.Control;
                }
            }
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

        private void visitorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorsGrid visitors = new visitorsGrid();
            visitors.Visible = true;
            this.Hide();
        }
    }
}
