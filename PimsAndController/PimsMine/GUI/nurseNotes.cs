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
    public partial class nurseNotes : Form
    {
        PIMSController.User user;
        PIMSController.Patient patient;
        int count = 1;

        private void updateStatDisplay()
        {

            PIMSController.MedStaffNotes.patientStats stats =
                patient.treatment.medStaffNotes.statList[patient.treatment.medStaffNotes.statList.Count - count];
            dateTextBox.Text = stats.time.ToString();
            heightTextBox.Text = stats.patientHeight.ToString();
            weightTextBox.Text = stats.patientWeight.ToString();
            bpTextBox.Text = (stats.bloodPressureSys + "/" + stats.bloodPressureDia).ToString();
            heartRateTextBox.Text = stats.heartrate.ToString();
        }
        public nurseNotes()
        {
            InitializeComponent();
            this.ControlBox = false;

            user = PimsMain.Program.currentUser;
            patient = PimsMain.Program.currentPatient;

            updateStatDisplay();
            allergiesTextBox.Text = patient.treatment.medStaffNotes.allergies;
            notesTextBox.Text = patient.treatment.medStaffNotes.nurseNotes;

            if(user is PIMSController.MedStaff)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox && ctrl != searchBox)
                    {
                        ((TextBox)ctrl).ReadOnly = false;
                        ((TextBox)ctrl).BackColor = SystemColors.Window;
                    }
                    if(ctrl is Button)
                    {
                        ((Button)ctrl).Visible = false;
                    }
                }
            }
            else
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox && ctrl != searchBox)
                    {
                        ((TextBox)ctrl).ReadOnly = true;
                        ((TextBox)ctrl).BackColor = SystemColors.Control;
                        button2.Enabled = false;
                        updateAllergiesButton.Enabled = false;
                        updateNurseNotesButton.Enabled = false;
                        button2.Visible = false;
                        updateNurseNotesButton.Visible = false;
                        updateAllergiesButton.Visible = false;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prevStatsButton_Click(object sender, EventArgs e)
        {
            count++;
            if(count > patient.treatment.medStaffNotes.statList.Count)
            {
                count = 1;
            }

            updateStatDisplay();

        }

        private void newerStatsButton_Click(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = patient.treatment.medStaffNotes.statList.Count;
            }

            updateStatDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] bp = bpTextBox.Text.Split('/');
            patient.treatment.medStaffNotes.statList.Add(
                new PIMSController.MedStaffNotes.patientStats(DateTime.Now,
                                                              int.Parse(weightTextBox.Text),
                                                              int.Parse(heightTextBox.Text),
                                                              int.Parse(bp[0]),
                                                              int.Parse(bp[1]),
                                                              int.Parse(heartRateTextBox.Text)
                        ));
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

        private void visitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitorsGrid visitors = new visitorsGrid();
            visitors.Visible = true;
            this.Hide();
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
            insuranceForm insForm = new insuranceForm();
            insForm.Visible = true;
            // hide this one
            this.Hide();
        }

        private void summaryBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid(false);
            sumBill.Visible = true;
            this.Hide();
        }

        private void detailedBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid();
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
            prescriptionGrid drugs = new prescriptionGrid();
            drugs.Visible = true;
            this.Hide();
        }

        private void nurseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Does nothing intentionally
        }

        private void doctorNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorNotesForm theseDocNotes = new doctorNotesForm();
            theseDocNotes.Visible = true;
            this.Hide();
        }

        private void editModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly = false;
                    ((TextBox)ctrl).BackColor = SystemColors.Window;
                }
            }
        }

        private void viewModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMSController.MedStaffNotes.patientStats stats =
                patient.treatment.medStaffNotes.statList[patient.treatment.medStaffNotes.statList.Count - count];
            dateTextBox.Text = stats.time.ToString();
            heightTextBox.Text = stats.patientHeight.ToString();
            weightTextBox.Text = stats.patientWeight.ToString();
            bpTextBox.Text = (stats.bloodPressureSys + "/" + stats.bloodPressureDia).ToString();
            heartRateTextBox.Text = stats.heartrate.ToString();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl != searchBox)
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

        private void updateNurseNotesButton_Click(object sender, EventArgs e)
        {
            patient.treatment.medStaffNotes.nurseNotes = notesTextBox.Text;
            PIMSController.SQLcommands.updatePatient(patient);

        }

        private void updateAllergiesButton_Click(object sender, EventArgs e)
        {
            patient.treatment.medStaffNotes.allergies = allergiesTextBox.Text;
            PIMSController.SQLcommands.updatePatient(patient);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
