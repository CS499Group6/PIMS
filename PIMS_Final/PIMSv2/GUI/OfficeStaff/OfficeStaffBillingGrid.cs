﻿using System;
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
            // make sure just 1 is selected since it wont take radio buttons

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

                // Clear contents of Panel1
                Program.myForm.splitContainer1.Panel1.Controls.Clear();
                // Add LeftSideButtons to Panel2
                Program.myForm.splitContainer1.Panel1.Controls.Add(new BillingForm());
            }
        }

        private void print_click(object sender, EventArgs e)
        {
            PIMSController.PrintInfo document = new PIMSController.PrintInfo(); //instantiate new printInfo object to print page
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("MyFile.txt"))
            {

                file.WriteLine("PATIENT BILLING ADDRESS\n");
                String address = String.Format("{0}, {1} \n{2} \n{3}, {4} \n{5}\n\n", patient.directory.lName, patient.directory.fName, patient.directory.strAddress,
                    patient.directory.city, patient.directory.state, patient.directory.zip);
                file.WriteLine(address);

                file.WriteLine("BILLING REPORT\n");


                file.WriteLine(String.Format("{0, -15}{1, 12}{2, 12}{3, 12}{4, 12}{5, 12}\n", "Billing Item", "Cost", "Paid", "Covered", "Amount Due", "Date Due"));


                foreach (PIMSController.BillingLineItem item in patient.billing.items)
                {
                    file.WriteLine(String.Format("{0, -15}{1, 12:.00}{2, 12:.00}{3, 12:.00}{4, 12:.00}{5, 12}\n", item.item, ((float)item.cost) / 100, ((float)item.paid) / 100, ((float)item.insPaid) / 100, ((float)(item.cost - item.paid - item.insPaid)) / 100, item.dueDate.Date.ToString("d")));
                }

            }

            document.printButton_Click(); //call print function in print class 
        }
    }
}