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
                this.dateTimePicker1.Value = Program.currentPatient.directory.DOB;
                if (Program.currentPatient.directory.gender)
                    this.genderTextBox.Text = "M";
                else
                    this.genderTextBox.Text = "F";
                this.faciltiyTextBox.Text = Program.currentPatient.directory.location.floor.ToString();
                this.roomNumberTextBox.Text = Program.currentPatient.directory.location.roomNum.ToString();
                this.bedNumberTextBox.Text = Program.currentPatient.directory.location.bedNum.ToString();
                this.inPatientTextBox.Text = Convert.ToBoolean(Program.currentPatient.directory.location.bedNum) ? "Y" : "N";
            }

            // Makes the patient's profile text box's not editable
            makeReadOnly();
        }

        // Makes the patient's profile text box's not editable
        public void makeReadOnly()
        {
            this.lastNameTextBox.ReadOnly = true;
            this.firstNameTextBox.ReadOnly = true;
            this.middleNameTextBox.ReadOnly = true;
            this.dateTimePicker1.Enabled = false;
            this.genderTextBox.ReadOnly = true;
            this.faciltiyTextBox.ReadOnly = true;
            this.roomNumberTextBox.ReadOnly = true;
            this.bedNumberTextBox.ReadOnly = true;
            this.inPatientTextBox.ReadOnly = true;
        }

        // Will allow the Volunteer to print the patient's information
        private void printButon_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient.directory.location.bedNum != 0 && Program.currentPatient.directory.location.bedNum != null)
            {
                string noInfo = "Information not provided";

                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                var myWordDoc = app.Documents.Open(@"F:\PIMS_Final\FORMS\PIMS VOLUNTEER FORM.docx", ReadOnly: false, Visible: true);
                app.Visible = true;

                Microsoft.Office.Interop.Word.Find fndLastName = myWordDoc.ActiveWindow.Selection.Find;
                fndLastName.Text = "@lname";

                if (Program.currentPatient.directory.lName.ToString() == "")
                {
                    fndLastName.Replacement.Text = noInfo;
                }
                else
                {
                    fndLastName.Replacement.Text = Program.currentPatient.directory.lName.ToString();
                }
                fndLastName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find fndFirstName = myWordDoc.ActiveWindow.Selection.Find;
                fndFirstName.Text = "@fname";

                if (Program.currentPatient.directory.fName.ToString() == "")
                {
                    fndFirstName.Replacement.Text = noInfo;
                }
                else
                {
                    fndFirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
                }
                fndFirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find fndDOB = myWordDoc.ActiveWindow.Selection.Find;
                fndDOB.Text = "@dob";

                if (Program.currentPatient.directory.DOB.Date.ToShortDateString() == "")
                {
                    fndDOB.Replacement.Text = noInfo;
                }
                else
                {
                    fndDOB.Replacement.Text = Program.currentPatient.directory.DOB.Date.ToShortDateString();
                }
                fndDOB.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find findGender = myWordDoc.ActiveWindow.Selection.Find;
                findGender.Text = "@gender";
                findGender.Replacement.Text = Program.currentPatient.directory.gender ? "M" : "F";
                findGender.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find findFloor = myWordDoc.ActiveWindow.Selection.Find;
                findFloor.Text = "@floor";

                if (Program.currentPatient.directory.location.floor.ToString() == "")
                {
                    findFloor.Replacement.Text = noInfo;
                }
                else
                {
                    findFloor.Replacement.Text = Program.currentPatient.directory.location.floor.ToString();
                }
                findFloor.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find findRoom = myWordDoc.ActiveWindow.Selection.Find;
                findRoom.Text = "@room";

                if (Program.currentPatient.directory.location.floor.ToString() == "")
                {
                    findRoom.Replacement.Text = noInfo;
                }
                else
                {
                    findRoom.Replacement.Text = Program.currentPatient.directory.location.floor.ToString();
                }
                findRoom.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find findBed = myWordDoc.ActiveWindow.Selection.Find;
                findBed.Text = "@bed";

                if (Program.currentPatient.directory.location.bedNum.ToString() == "")
                {
                    findBed.Replacement.Text = noInfo;
                }
                else
                {
                    findBed.Replacement.Text = Program.currentPatient.directory.location.bedNum.ToString();
                }
                findBed.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                Microsoft.Office.Interop.Word.Find findUnit = myWordDoc.ActiveWindow.Selection.Find;
                findUnit.Text = "@unit";

                if (Program.currentPatient.directory.location.unit.ToString() == "")
                {
                    findUnit.Replacement.Text = noInfo;
                }
                else
                {
                    findUnit.Replacement.Text = Program.currentPatient.directory.location.unit.ToString();
                }
                findUnit.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

                myWordDoc.SaveAs2(@"F:\PIMS_Final\FORMS\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Volunteer Information.pdf");
                myWordDoc.PrintPreview();
            }
            else
            {
                // Display information message
                MessageBox.Show("Patient is not admitted in the hospital.\n There is no need to print this information.",
                "No information to print!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
