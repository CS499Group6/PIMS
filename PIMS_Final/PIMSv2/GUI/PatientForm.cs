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
    public partial class PatientForm : UserControl
    {
        PIMSController.Patient patient;

        public PatientForm()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            this.idTextBox.Text = patient.directory.patientID;
            this.lastNameTextBox.Text = patient.directory.lName;
            this.firstNameTextBox.Text = patient.directory.fName;
            this.middleNameTextBox.Text = patient.directory.mName;
            this.dobTextBox.Text = patient.directory.DOB.ToString(@"MM\/dd\/yyyy");
            if (patient.directory.gender)
                this.genderTextBox.Text = "M";
            else
                this.genderTextBox.Text = "F";
            this.addressTextBox.Text = patient.directory.strAddress;
            this.cityTextBox.Text = patient.directory.city;
            this.stateTextBox.Text = patient.directory.state;
            this.zipTextBox.Text = patient.directory.zip;
            this.primaryPhoneTextBox.Text = patient.directory.phoneNum1;
            this.secondaryPhoneTextBox.Text = patient.directory.phoneNum2;
            this.contactName1TextBox.Text = patient.directory.emerContact1.name;
            this.contactPhone1TextBox.Text = patient.directory.emerContact1.phoneNum;
            this.contactName2TextBox.Text = patient.directory.emerContact2.name;
            this.contactPhone2TextBox.Text = patient.directory.emerContact2.phoneNum;
        }

        public void makeReadOnly()
        {
            this.idTextBox.ReadOnly = true;
            this.lastNameTextBox.ReadOnly = true;
            this.firstNameTextBox.ReadOnly = true;
            this.middleNameTextBox.ReadOnly = true;
            this.dobTextBox.ReadOnly = true;
            this.genderTextBox.ReadOnly = true;
            this.addressTextBox.ReadOnly = true;
            this.cityTextBox.ReadOnly = true;
            this.stateTextBox.ReadOnly = true;
            this.zipTextBox.ReadOnly = true;
            this.primaryPhoneTextBox.ReadOnly = true;
            this.secondaryPhoneTextBox.ReadOnly = true;
            this.contactName1TextBox.ReadOnly = true;
            this.contactPhone1TextBox.ReadOnly = true;
            this.contactName2TextBox.ReadOnly = true;
            this.contactPhone2TextBox.ReadOnly = true;
        }

        private void print_click(object sender, EventArgs e)
        {
            PIMSController.PrintInfo document = new PIMSController.PrintInfo(); //instantiate new printInfo object to print page
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("MyFile.txt"))
            {

                file.WriteLine("PATIENT ADDRESS\n");
                String address = String.Format("{0}, {1} {2}\n{3} \n{4}, {5} \n{6}\n\n", patient.directory.lName, patient.directory.fName, patient.directory.mName, patient.directory.strAddress,
                    patient.directory.city, patient.directory.state, patient.directory.zip);
                file.WriteLine(address);

                file.WriteLine("PATIENT INFORMATION\n");


                file.WriteLine(String.Format("{0, -25}{1, -25} \n{2, -25}{3, -25} \n{4, -25}{5, -25} \n{6, -25}{7, -25} \n{8, -25}{9, -25} \n{10, -25}{11, -25} \n{12, -25}{13, -25} \n{14, -25}{15, -25} \n{16, -25}{17, -25} \n", 
                    "Patient ID:", patient.directory.patientID, 
                    "Date of Birth:", patient.directory.DOB.Date.ToString("d"), 
                    "Gender:", patient.directory.gender ? "M":"F", 
                    "Primary Phone:", patient.directory.phoneNum1, 
                    "Secondary Phone:", patient.directory.phoneNum2, 
                    "Emergency Contact:", patient.directory.emerContact1, 
                    "Emergency Contact Number:", patient.directory.emerContact1.phoneNum,
                    "Emergency Contact:", patient.directory.emerContact2, 
                    "Emergency Contact Number:", patient.directory.emerContact2.phoneNum));

            }

            document.printButton_Click(); //call print function in print class 
        }
        
    }
}
