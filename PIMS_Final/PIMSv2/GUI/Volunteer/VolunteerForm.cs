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

        // Default Constructor
        public VolunteerForm()
        {
            InitializeComponent();

            // If we have a current patient, add profile information about the patient to various profile text box's
            if (Program.currentPatient != null)
            {
                this.lastNameTextBox.Text = Program.currentPatient.directory.lName;
                this.firstNameTextBox.Text = Program.currentPatient.directory.fName;
                this.middleNameTextBox.Text = Program.currentPatient.directory.mName;
                this.dobTextBox.Text = Program.currentPatient.directory.DOB.ToString(@"MM\/dd\/yyyy");
                if (Program.currentPatient.directory.gender)
                    this.genderTextBox.Text = "M";
                else
                    this.genderTextBox.Text = "F";
                this.faciltiyTextBox.Text = Program.currentPatient.directory.location.floor;
                this.roomNumberTextBox.Text = Program.currentPatient.directory.location.roomNum;
                this.bedNumberTextBox.Text = Program.currentPatient.directory.location.bedNum;
                this.inPatientTextBox.Text = Program.currentPatient.directory.isAdmitted ? "Y" : "N";
            }

            // Makes the patient's profile text box's not editable
            makeReadOnly();
        }

        // Makes the patient's profile text box's not editable
        public void makeReadOnly()
        {
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
