using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class doctorNotesForm : Form
    {
        PIMSController.User curUser;
        PIMSController.Patient curPatient;
        public doctorNotesForm(PIMSController.Patient patient, PIMSController.User user)
        {
            InitializeComponent();
            curUser = user;
            curPatient = patient;
            if (user is PIMSController.Doctor)
            {
                docNotesTextBox.ReadOnly = false;
            }
            else
            {
                docNotesTextBox.ReadOnly = true;
            }
            docNotesTextBox.Text = curPatient.treatment.docNotes;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            curPatient.treatment.docNotes = docNotesTextBox.Text;
            // TODO: SQL query to write updates 
        }
    }
}
