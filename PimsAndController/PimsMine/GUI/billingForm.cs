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
    public partial class billingForm : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        public billingForm()
        {
            InitializeComponent();
            this.ControlBox = false;

            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void prescriptionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionGrid drugs = new prescriptionGrid();
            drugs.Visible = true;
            this.Hide();

        }

        private void scheduledProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.GUI.SchedProcForm procForm = new PimsMain.GUI.SchedProcForm();
            procForm.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PIMSController.BillingLineItem item = new PIMSController.BillingLineItem();
            item.item = itemBox.Text;
            item.cost = Convert.ToInt32(Convert.ToDouble(costBox.Text) * 100);
            item.insPaid = Convert.ToInt32(Convert.ToDouble(insPaidBox.Text) * 100);
            item.paid = Convert.ToInt32(Convert.ToDouble(paidBox.Text) * 100);
            item.owed = item.cost - item.insPaid - item.paid;
            item.dueDate = Convert.ToDateTime(dueBox.Text);

            patient.billing.items.Add(item);
            PIMSController.SQLcommands.updatePatient(patient);

            billingGrid sumBill = new billingGrid();
            sumBill.Visible = true;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
