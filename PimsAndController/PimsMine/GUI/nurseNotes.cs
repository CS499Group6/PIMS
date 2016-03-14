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
    public partial class nurseNotes : Form
    {
        PIMSController.User curUser;
        PIMSController.Patient curPatient;
        int count = 1;

        private void updateStatDisplay()
        {

            PIMSController.MedStaffNotes.patientStats stats =
                curPatient.treatment.medStaffNotes.statList[curPatient.treatment.medStaffNotes.statList.Count - count];
            dateTextBox.Text = stats.time.ToString();
            heightTextBox.Text = stats.patientHeight.ToString();
            weightTextBox.Text = stats.patientWeight.ToString();
            bpTextBox.Text = (stats.bloodPressureSys + "/" + stats.bloodPressureDia).ToString();
            heartRateTextBox.Text = stats.heartrate.ToString();
        }
        public nurseNotes(PIMSController.Patient patient, PIMSController.User user)
        {
            InitializeComponent();
            curPatient = patient;
            curUser = user;

            updateStatDisplay();
            allergiesTextBox.Text = patient.treatment.medStaffNotes.allergies;
            notesTextBox.Text = patient.treatment.medStaffNotes.nurseNotes;

            if(curUser is PIMSController.MedStaff)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox && ctrl != queryBar)
                    {
                        ((TextBox)ctrl).ReadOnly = false;
                        ((TextBox)ctrl).BackColor = SystemColors.Window;
                    }
                }
            }
            else
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox && ctrl != queryBar)
                    {
                        ((TextBox)ctrl).ReadOnly = true;
                        ((TextBox)ctrl).BackColor = SystemColors.Control;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prevStatsButton_Click(object sender, EventArgs e)
        {
            count++;
            if(count > curPatient.treatment.medStaffNotes.statList.Count)
            {
                count = 1;
            }

            updateStatDisplay();

        }

        private void newerStatsButton_Click(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = curPatient.treatment.medStaffNotes.statList.Count;
            }

            updateStatDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] bp = bpTextBox.Text.Split('/');
            curPatient.treatment.medStaffNotes.statList.Add(
                new PIMSController.MedStaffNotes.patientStats(DateTime.Now,
                                                              int.Parse(weightTextBox.Text),
                                                              int.Parse(heightTextBox.Text),
                                                              int.Parse(bp[0]),
                                                              int.Parse(bp[1]),
                                                              int.Parse(heartRateTextBox.Text)
                        ));
        }
    }
}
