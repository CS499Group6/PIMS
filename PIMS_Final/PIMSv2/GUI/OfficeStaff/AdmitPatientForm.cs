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
    public partial class AdmitPatientForm : UserControl
    {
        // Default Constructor
        public AdmitPatientForm()
        {
            InitializeComponent();
        }

        // Will allow the Office Staff user to admit the patient
        private void admitPatient_Click(object sender, EventArgs e)
        {
            Program.currentPatient.treatment.dateAdmitted = this.dateTimePicker1.Value;
            Program.currentPatient.treatment.reasonAdmitted = this.reasonAdmittanceTextBox.Text;

            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add PatientSearch to Panel2;
            Program.myForm.splitContainer1.Panel2.Controls.Add(new RoomAssignmentGrid());
        }
    }
}
