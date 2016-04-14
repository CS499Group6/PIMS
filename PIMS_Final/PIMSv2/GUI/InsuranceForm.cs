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
    public partial class InsuranceForm : UserControl
    {
        PIMSController.Patient patient;

        public InsuranceForm()
        {
            InitializeComponent();
            
            patient = Program.currentPatient;

            providerTextBox.Text = patient.billing.insurance.provider;
            binTextBox.Text = patient.billing.insurance.bin;
            idTextBox.Text = patient.billing.insurance.id;
            pcnTextBox.Text = patient.billing.insurance.pcn;
            groupTextBox.Text = patient.billing.insurance.groupNum;
            typeTextBox.Text = patient.billing.insurance.insuranceType;
        }

        public void makeReadOnly()
        {
            providerTextBox.ReadOnly = true;
            binTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;
            pcnTextBox.ReadOnly = true;
            groupTextBox.ReadOnly = true;
            typeTextBox.ReadOnly = true;
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

                file.WriteLine("PATIENT INSURANCE INFORMATION\n");


                file.WriteLine(String.Format("{0, 15}: {1, 15} \n{2, 15}: {3, 15} \n{4, 15}: {5, 15} \n{6, 15}: {7, 15} \n{8, 15}: {9, 15} \n {10, 15}: {11, 15} \n", 
                    "Provider", patient.insurance.provider, 
                    "BIN", patient.insurance.bin, 
                    "ID", patient.insurance.id, 
                    "PCN", patient.insurance.pcn, 
                    "Group Number", patient.insurance.groupNum, 
                    "Insurance Type", patient.insurance.insuranceType));

            }

            document.printButton_Click(); //call print function in print class 
        }
    }
}
