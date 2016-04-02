using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*---Patient Perscription list---
the purpose of this form is to show 
perscription data and allow doctors or pharmacy staff
to select a perscription to edit or add a new perscription
*/


namespace PIMS
{
    public partial class prescriptionGrid : Form
    {
        PIMSController.User user;
        PIMSController.Patient patient;
        public prescriptionGrid()
        {
            InitializeComponent();
            this.ControlBox = false;

            user = PimsMain.Program.currentUser;
            patient = PimsMain.Program.currentPatient;

            foreach(PIMSController.PrescDrug drug in patient.treatment.prescriptions.prescriptions)
            {
                DGV.Rows.Add(drug.id, drug.name, drug.ndc, drug.cost, drug.dateFilled.ToString(@"MM\/dd\/yyyy"));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            billingGrid sumBill = new billingGrid();
            sumBill.Visible = true;
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PimsMain.Program.currentPatient = null;
            PimsMain.Program.currentUser = null;
            PIMS.loginForm login = new PIMS.loginForm();
            login.Visible = true;
            this.Hide();
        }
    }
}
