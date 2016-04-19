using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace PIMS
{
    public partial class DischargePatientForm : UserControl
    {
        // Default Constructor
        public DischargePatientForm()
        {
            InitializeComponent();

            this.dateTimePicker1.Enabled = false;
        }
        
        // Will print discharge paper's for the patient
        private void dischargePatient_Click(object sender, EventArgs e)
        {
            updateMyPatient();

            string noInfo = "Information not provided";

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();//you need this
            var myWordDoc = app.Documents.Open(@"C:\Users\Ina\Desktop\PIMS\PIMS_Final\PIMSv2\FORMS\PIMS DISCHARGE FORM.docx", ReadOnly: false, Visible: true);//filepath of document
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

            Microsoft.Office.Interop.Word.Find fndStreet = myWordDoc.ActiveWindow.Selection.Find;
            fndStreet.Text = "@street";

            if (Program.currentPatient.directory.strAddress.ToString() == "")
            {
                fndStreet.Replacement.Text = noInfo;
            }
            else
            {
                fndStreet.Replacement.Text = Program.currentPatient.directory.strAddress.ToString();
            }
            fndStreet.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCity = myWordDoc.ActiveWindow.Selection.Find;
            findCity.Text = "@city";

            if (Program.currentPatient.directory.city.ToString() == "")
            {
                findCity.Replacement.Text = noInfo;
            }
            else
            {
                findCity.Replacement.Text = Program.currentPatient.directory.city.ToString();
            }
            findCity.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findState = myWordDoc.ActiveWindow.Selection.Find;
            findState.Text = "@state";

            if (Program.currentPatient.directory.state.ToString() == "")
            {
                findState.Replacement.Text = noInfo;
            }
            else
            {
                findState.Replacement.Text = Program.currentPatient.directory.state.ToString();
            }
            findState.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findZip = myWordDoc.ActiveWindow.Selection.Find;
            findZip.Text = "@zip";

            if (Program.currentPatient.directory.zip.ToString() == "")
            {
                findZip.Replacement.Text = noInfo;
            }
            else
            {
                findZip.Replacement.Text = Program.currentPatient.directory.zip.ToString();
            }
            findZip.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone1 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone1.Text = "@phone1";

            if (Program.currentPatient.directory.phoneNum1.ToString() == "")
            {
                findPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findPhone1.Replacement.Text = Program.currentPatient.directory.phoneNum1.ToString();
            }
            findPhone1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone2 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone2.Text = "@phone2";

            if (Program.currentPatient.directory.phoneNum2.ToString() == "")
            {
                findPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findPhone2.Replacement.Text = Program.currentPatient.directory.phoneNum2.ToString();
            }
            findPhone2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhone3 = myWordDoc.ActiveWindow.Selection.Find;
            findPhone3.Text = "@phone3";

            if (Program.currentPatient.directory.workphone.ToString() == "")
            {
                findPhone3.Replacement.Text = noInfo;
            }
            else
            {
                findPhone3.Replacement.Text = Program.currentPatient.directory.workphone.ToString();
            }
            findPhone3.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCName1 = myWordDoc.ActiveWindow.Selection.Find;
            findCName1.Text = "@cName1";

            if (Program.currentPatient.directory.emerContact1.name.ToString() == "")
            {
                findCName1.Replacement.Text = noInfo;
            }
            else
            {
                findCName1.Replacement.Text = Program.currentPatient.directory.emerContact1.name.ToString();
            }
            findCName1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCPhone1 = myWordDoc.ActiveWindow.Selection.Find;
            findCPhone1.Text = "@cPhone1";

            if (Program.currentPatient.directory.emerContact1.phoneNum.ToString() == "")
            {
                findCPhone1.Replacement.Text = noInfo;
            }
            else
            {
                findCPhone1.Replacement.Text = Program.currentPatient.directory.emerContact1.phoneNum.ToString();
            }
            findCPhone1.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCName2 = myWordDoc.ActiveWindow.Selection.Find;
            findCName2.Text = "@cName2";

            if (Program.currentPatient.directory.emerContact2.name.ToString() == "")
            {
                findCName2.Replacement.Text = noInfo;
            }
            else
            {
                findCName2.Replacement.Text = Program.currentPatient.directory.emerContact2.name.ToString();
            }
            findCName2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findCPhone2 = myWordDoc.ActiveWindow.Selection.Find;
            findCPhone2.Text = "@cPhone2";

            if (Program.currentPatient.directory.emerContact2.phoneNum.ToString() == "")
            {
                findCPhone2.Replacement.Text = noInfo;
            }
            else
            {
                findCPhone2.Replacement.Text = Program.currentPatient.directory.emerContact2.phoneNum.ToString();
            }
            findCPhone2.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPrimPhys = myWordDoc.ActiveWindow.Selection.Find;
            findPrimPhys.Text = "@primDr";
            findPrimPhys.Replacement.Text = Program.currentPatient.treatment.primaryDoc;
            findPrimPhys.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPhys = myWordDoc.ActiveWindow.Selection.Find;
            findPhys.Text = "@dr";
            findPhys.Replacement.Text = Program.currentPatient.treatment.attendingDoc;
            findPhys.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findDis = myWordDoc.ActiveWindow.Selection.Find;
            findDis.Text = "@reasonDischarge";
            findDis.Replacement.Text = Program.currentPatient.treatment.reasonDischarged.ToString();
            findDis.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findDiagnosis = myWordDoc.ActiveWindow.Selection.Find;
            findDiagnosis.Text = "@diagnosis";
            findDiagnosis.Replacement.Text = Program.currentPatient.treatment.diagnosis;
            findDiagnosis.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            myWordDoc.SaveAs2(@"C:\Users\Ina\Desktop\PIMS\PIMS_Final\PIMSv2\FORMS\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Discharge Form.docx");
            myWordDoc.PrintPreview();

            // Display information message
            MessageBox.Show("Patient has been discharged!",
                "Patient discharged!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add ResultsGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(Program.lastNameQuery));
        }

        // Will update the patient
        private void updateMyPatient()
        {
            Program.currentPatient.treatment.dateDischarged = this.dateTimePicker1.Value;
            Program.currentPatient.treatment.reasonDischarged = this.reasonDischargeTextBox.Text;

            Program.currentPatient.directory.isAdmitted = false;
            Program.currentPatient.directory.location.roomNum = 0;
            Program.currentPatient.directory.location.unit = null;
       
            PIMSController.SQLcommands.dischargePatientLocation(Program.currentPatient);
            Program.currentPatient.directory.location.bedNum = null;
            PIMSController.SQLcommands.updatePatient();
            PIMSController.SQLcommands.buildPatient(Program.currentPatient.directory.patientID);
        }

        // Will allow the Doctor to not discharge the patient
        private void cancelDischargeButton_Click(object sender, EventArgs e)
        {
            // Clear contents of Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Clear();
            // Add ResultsGrid to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new ResultsGrid(Program.lastNameQuery));
        }
    }
}
