using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*---Insurance Edit/Entry Form---

    */

namespace PIMS
{

    public partial class insuranceForm : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public insuranceForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;
            button1.Hide();
            foreach(Control ctrl in this.Controls)
            {
               if (ctrl is TextBox && ctrl.Name != "textBox1")
               {
                  ((TextBox)ctrl).ReadOnly = true;
                  ((TextBox)ctrl).BackColor = SystemColors.Control;
               }
            }
            ProviderBox.Text = patient.billing.insurance.provider;
            binBox.Text = patient.billing.insurance.bin;
            pcnBox.Text = patient.billing.insurance.pcn;
            groupBox.Text = patient.billing.insurance.groupNum;
            idBox.Text = patient.billing.insurance.id;

            if(!(user is PIMSController.OfficeStaff))
            {
                fileToolStripMenuItem1.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient.billing.insurance.groupNum = groupBox.Text;
            patient.billing.insurance.id = idBox.Text;
            patient.billing.insurance.pcn = pcnBox.Text;
            patient.billing.insurance.provider = ProviderBox.Text;
            patient.billing.insurance.bin = binBox.Text;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insuranceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIMS.insuranceForm insForm = new PIMS.insuranceForm();
            insForm.Visible = true;
            // hide this one
            this.Hide();
        }

        private void doctorNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorNotesForm theseDocNotes = new doctorNotesForm();
            theseDocNotes.Visible = true;
            this.Hide();
        }

        private void nurseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nurseNotes theseNurseNotes = new nurseNotes();
            theseNurseNotes.Visible = true;
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button1.Visible = true;
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
            ProviderBox.Text = patient.billing.insurance.provider;
            binBox.Text = patient.billing.insurance.bin;
            pcnBox.Text = patient.billing.insurance.pcn;
            groupBox.Text = patient.billing.insurance.groupNum;
            idBox.Text = patient.billing.insurance.id;
            this.button1.Visible = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl != textBox1)
                {
                    ((TextBox)ctrl).ReadOnly = true;
                    ((TextBox)ctrl).BackColor = SystemColors.Control;
                }
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
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

        private void treatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void patientFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientForm patient = new patientForm();
            patient.Visible = true;
            this.Hide();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locationForm location = new locationForm();
            location.Visible = true;
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String lastNameQuery = textBox1.Text.ToUpper();
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
    }
}
