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
    public partial class BillingGrid : UserControl
    {
        // Default Constructor
        public BillingGrid()
        {
            InitializeComponent();

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the Select Column
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                this.billingDataGridView.Columns[0].Visible = false;
                this.billingDataGridView.Columns[1].Visible = false;
            }

            billingDataGridView.CellValueChanged += billingDataGridView_CellValueChanged;

            int costSum = 0;
            int insPaidSum = 0;
            int paidSum = 0;
            int owedSum = 0;

            foreach (PIMSController.BillingLineItem item in Program.currentPatient.billing.items)
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

         // Will allow the user to print the patient's billing information
        private void printButton_Click(object sender, EventArgs e)
        {
            // Instantiate new printInfo object to print page
            PIMSController.PrintInfo document = new PIMSController.PrintInfo(); 

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("MyFile.txt"))
            {

                file.WriteLine("PATIENT BILLING ADDRESS\n");
                String address = String.Format("{0}, {1} \n{2} \n{3}, {4} \n{5}\n\n", Program.currentPatient.directory.lName, Program.currentPatient.directory.fName, Program.currentPatient.directory.strAddress,
                    Program.currentPatient.directory.city, Program.currentPatient.directory.state, Program.currentPatient.directory.zip);
                file.WriteLine(address);

                file.WriteLine("BILLING REPORT\n");

                file.WriteLine(String.Format("{0, -15}{1, 12}{2, 12}{3, 12}{4, 12}{5, 12}\n", "Billing Item", "Cost", "Paid", "Covered", "Amount Due", "Date Due"));

                foreach (PIMSController.BillingLineItem item in Program.currentPatient.billing.items)
                {
                    file.WriteLine(String.Format("{0, -15}{1, 12:.00}{2, 12:.00}{3, 12:.00}{4, 12:.00}{5, 12}\n", item.item, ((float)item.cost) / 100, ((float)item.paid) / 100, ((float)item.insPaid) / 100, ((float)(item.cost - item.paid - item.insPaid)) / 100, item.dueDate.Date.ToString("d")));
                }

            }

            // Call the print function in the print class
            document.printButton_Click();
        }
    }
}
