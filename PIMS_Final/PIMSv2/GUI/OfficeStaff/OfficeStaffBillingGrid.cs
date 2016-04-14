using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class OfficeStaffBillingGrid : UserControl
    {
        PIMSController.Patient patient;

        List<PIMSController.Patient> patients = new List<PIMSController.Patient>();
        PIMSController.Patient selectedPatient = null;

        public OfficeStaffBillingGrid()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            billingDataGridView.CellValueChanged += billingDataGridView_CellValueChanged;

            int costSum = 0;
            int insPaidSum = 0;
            int paidSum = 0;
            int owedSum = 0;

            foreach (PIMSController.BillingLineItem item in patient.billing.items)
            {
                int owed = item.cost - item.insPaid - item.paid;
                owedSum += owed;
                costSum += item.cost;
                insPaidSum += item.insPaid;
                paidSum += item.paid;
                billingDataGridView.Rows.Add(null, item.itemId, item.item,
                             item.dueDate.ToString(@"MM\/dd\/yyyy"),
                             Math.Round(((float)item.cost / 100.0), 2),
                             Math.Round(((float)item.insPaid / 100.0), 2),
                             Math.Round(((float)item.paid / 100.0), 2),
                             Math.Round(((float)owed / 100.0), 2));
            }

        }

        private void billingGridDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            billingDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void billingDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string currentID = "";
            int count = 0;

            foreach (DataGridViewRow row in billingDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals("true"))
                {
                    count++;
                    currentID = row.Cells[1].Value.ToString();
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Please select a patient.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count != 1)
            {
                MessageBox.Show("Please select only one patient.",
                    "Row selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //foreach (PIMSController.Patient myPatient in patients)
                //{
                //    if (currentID != null && myPatient.directory.patientID == currentID)
                //    {
                //        selectedPatient = myPatient;
                //    }
                //}

                //Program.currentPatient = PIMSController.SQLcommands.buildPatient(selectedPatient.directory.patientID);

                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add LeftSideButtons to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new BillingForm());
            }
        }
    }
}
