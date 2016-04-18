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
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();//you need this
            var myWordDoc = app.Documents.Open(@"F:\PIMS_Final\PIMS DISCHARGE FORM.docx", ReadOnly: false, Visible: true);//filepath of document
            app.Visible = true;

            Microsoft.Office.Interop.Word.Find fndlastName = myWordDoc.ActiveWindow.Selection.Find;
            fndlastName.Text = "@lname";
            fndlastName.Replacement.Text = Program.currentPatient.directory.lName.ToString();
            fndlastName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            /*
            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find fndfirstName = myWordDoc.ActiveWindow.Selection.Find;
            fndfirstName.Text = "@fname";
            fndfirstName.Replacement.Text = Program.currentPatient.directory.fName.ToString();
            fndfirstName.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            */
            myWordDoc.SaveAs2(@"F:\PIMS_Final\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Discharge Form.docx");
            myWordDoc.PrintPreview();

            updateMyPatient();
        }

        private void updateMyPatient()
        {
            Program.currentPatient.treatment.dateDischarged = this.dateTimePicker1.Value;
            Program.currentPatient.treatment.reasonDischarged = this.reasonDischargeTextBox.Text;

            Program.currentPatient.directory.isAdmitted = false;
            Program.currentPatient.directory.location.roomNum = 0;
            Program.currentPatient.directory.location.bedNum = 0;
            Program.currentPatient.directory.location.unit = null;

            //PIMSController.SQLcommands.u
        }
    }
}
