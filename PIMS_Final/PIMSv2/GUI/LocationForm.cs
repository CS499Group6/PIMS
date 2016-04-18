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
    public partial class LocationForm : UserControl
    {
        // Default Constructor
        public LocationForm()
        {
            InitializeComponent();

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                updateButton.Visible = false;
                save.Visible = false;
            }

            if (Program.currentPatient.directory.location.bedNum == 0 || Program.currentPatient.directory.location.bedNum == null)
            {
                this.printButton.Visible = false;
                this.save.Visible = false;
            }

            floorTextBox.Text = Program.currentPatient.directory.location.floor.ToString();
            roomTextBox.Text = Program.currentPatient.directory.location.roomNum.ToString();
            bedTextBox.Text = Program.currentPatient.directory.location.bedNum.ToString();
            unitTextBox.Text = Program.currentPatient.directory.location.unit;
            
            // Makes the patient's location text box's not editable
            makeReadOnly();
        }

        // Makes the patient's location text box's not editable
        public void makeReadOnly()
        {
            floorTextBox.ReadOnly = true;
            roomTextBox.ReadOnly = true;
            bedTextBox.ReadOnly = true;
            unitTextBox.ReadOnly = true;
        }

        // Makes the patient's location text box's editable
        public void makeReadable()
        {
            floorTextBox.ReadOnly = false;
            roomTextBox.ReadOnly = false;
            bedTextBox.ReadOnly = false;
            unitTextBox.ReadOnly = false;
        }

        // Will allow the Office Staff user to update a patient's profile information
        private void updateButton_Click(object sender, EventArgs e)
        {
                // Clear contents of Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Clear();
                // Add PatientSearch to Panel2
                Program.myForm.splitContainer1.Panel2.Controls.Add(new RoomAssignmentGrid());
                return;           
        }


        private void save_Click(object sender, EventArgs e)
        {
            Boolean createNew = false;

            // Check to see if we have a current patient
            // If we don't, create a new patient
            if (Program.currentPatient == null)
            {
                Program.currentPatient = new PIMSController.Patient();
                createNew = true;
            }

            // Assign various location information to the current patient

            Program.currentPatient.directory.location.floor = Int32.Parse(floorTextBox.Text);
            Program.currentPatient.directory.location.roomNum = Int32.Parse(roomTextBox.Text);
            Program.currentPatient.directory.location.bedNum = Int32.Parse(bedTextBox.Text);
            Program.currentPatient.directory.location.unit = unitTextBox.Text;

       
            //// Update the Patient's Location information
             PIMSController.SQLcommands.updatePatientLocation(Program.currentPatient);

            // Makes the patient's profile text box's not editable
            makeReadOnly();

            // Change the saveUpdateButton text
            updateButton.Text = "Update";

            this.save.Visible = false;

            // Display information message
            MessageBox.Show("Patient's location information has been saved!",
            "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   

        // Will allow the user to print the patient's insurance information
        private void printButton_Click(object sender, EventArgs e)
        {
            if (Program.currentPatient.directory.location.bedNum == 0 || Program.currentPatient.directory.location.bedNum == null)
            {
                // Display information message
                MessageBox.Show("Patient is not admitted in the hospital.\n There is no need to print this information.",
                "No information to print!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string noInfo = "Information not provided";

                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                var myWordDoc = app.Documents.Open(@"F:\PIMS_Final\FORMS\PIMS LOCATION FORM.docx", ReadOnly: false, Visible: true);
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

                myWordDoc.SaveAs2(@"F:\PIMS_Final\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Location Information.pdf");
                myWordDoc.PrintPreview();
            }
        }
    }
}
