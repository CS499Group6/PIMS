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
    public partial class billingGrid : Form
    {
        PIMSController.Patient patient;
        PIMSController.User user;
        PIMSController.PrintInfo document = new PIMSController.PrintInfo(); //instantiate new printInfo object to print page
        public billingGrid()
        {
            InitializeComponent();
            this.ControlBox = false;
            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;
            int costSum = 0;
            int insPaidSum= 0;
            int paidSum = 0;
            int owedSum = 0;
            Console.WriteLine("billing grid constructer!");
            if(!(user is PIMSController.OfficeStaff))
            {
                fileToolStripMenuItem.Enabled = false;
            }
            int i = 0;
            foreach(PIMSController.BillingLineItem item in patient.billing.items)
            {
                Console.WriteLine(i++);
                int owed = item.cost - item.insPaid - item.paid;
                owedSum += owed;
                costSum += item.cost;
                insPaidSum += item.insPaid;
                paidSum += item.paid;
                DGV.Rows.Add(item.item, 
                             item.dueDate.ToString(@"MM\/dd\/yyyy"),
                             Math.Round(((float)item.cost/ 100.0),2),
                             Math.Round(((float)item.insPaid / 100.0),2),
                             Math.Round(((float)item.paid / 100.0),2),
                             Math.Round(((float)owed / 100.0),2));
                              
            }
            DGV.Rows.Add("Totals", null,
                          Math.Round(((float)costSum / 100.0), 2),
                          Math.Round(((float)insPaidSum / 100.0), 2),
                          Math.Round(((float)paidSum / 100.0), 2),
                          Math.Round(((float)owedSum / 100.0), 2));

        }

        public billingGrid(bool summary)
        {
            InitializeComponent();
            this.ControlBox = false;
            patient = PimsMain.Program.currentPatient;
            user = PimsMain.Program.currentUser;
            int costSum = 0;
            int insPaidSum = 0;
            int paidSum = 0;
            int owedSum = 0;

            if (!(user is PIMSController.OfficeStaff))
            {
                fileToolStripMenuItem.Enabled = false;
            }

            foreach (PIMSController.BillingLineItem item in patient.billing.items)
            {
                int owed = item.cost - item.insPaid - item.paid;
                owedSum += owed;
                costSum += item.cost;
                insPaidSum += item.insPaid;
                paidSum += item.paid;

            }
            DGV.Rows.Add("Totals", null,
                          Math.Round(((float)costSum / 100.0), 2),
                          Math.Round(((float)insPaidSum / 100.0), 2),
                          Math.Round(((float)paidSum / 100.0), 2),
                          Math.Round(((float)owedSum / 100.0), 2));

        }

        private void billingGrid_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingForm billItem = new billingForm();
            billItem.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void detailedBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid();
            sumBill.Visible = true;
            this.Hide();
        }

        private void summaryBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingGrid sumBill = new billingGrid(false);
            sumBill.Visible = true;
            this.Hide();
        }

        private void insuranceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insuranceForm insForm = new insuranceForm();
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

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //create textfile and write information to the textfile.

            document.printButton_Click(); //call print function in print class

            //delete textfile after printing is complete
        }
    }
}
