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
    }
}
