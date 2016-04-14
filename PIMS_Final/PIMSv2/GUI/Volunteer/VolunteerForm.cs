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
    public partial class VolunteerForm : UserControl
    {
        PIMSController.Patient patient;

        public VolunteerForm()
        {
            InitializeComponent();

            patient = Program.currentPatient;

            this.idBox.Text = patient.directory.patientID;
            this.lastNameTextBox.Text = patient.directory.lName;
            this.firstNameTextBox.Text = patient.directory.fName;
            this.middleNameTextBox.Text = patient.directory.mName;
            this.dobTextBox.Text = patient.directory.DOB.ToString(@"MM\/dd\/yyyy");
            if (patient.directory.gender)
                this.genderTextBox.Text = "M";
            else
                this.genderTextBox.Text = "F";
            this.faciltiyTextBox.Text = patient.directory.location.floor;
            this.roomNumberTextBox.Text = patient.directory.location.roomNum;
            this.bedNumberTextBox.Text = patient.directory.location.bedNum;
            this.inPatientTextBox.Text = patient.directory.isAdmitted ? "Y" : "N";

            this.idBox.ReadOnly = true;
            this.lastNameTextBox.ReadOnly = true;
            this.firstNameTextBox.ReadOnly = true;
            this.middleNameTextBox.ReadOnly = true;
            this.dobTextBox.ReadOnly = true;
            this.genderTextBox.ReadOnly = true;
            this.faciltiyTextBox.ReadOnly = true;
            this.roomNumberTextBox.ReadOnly = true;
            this.bedNumberTextBox.ReadOnly = true;
            this.inPatientTextBox.ReadOnly = true;
        }        
    }
}
