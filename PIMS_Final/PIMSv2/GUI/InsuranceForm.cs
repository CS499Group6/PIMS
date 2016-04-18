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
    public partial class InsuranceForm : UserControl
    {
        // Default Constructor
        public InsuranceForm()
        {
            InitializeComponent();

            // If the current user is not an OfficeStaff
            // Don't allow the user to see the saveUpdateButton
            if (!(Program.currentUser is PIMSController.OfficeStaff))
            {
                this.saveUpdateButton.Visible = false;
                this.cancelButton.Visible = false;
            }

            this.cancelButton.Visible = false;

            typeComboBox.Items.Add("Medical");
            typeComboBox.Items.Add("Dental");
            typeComboBox.Items.Add("Prescriptions");
            typeComboBox.Items.Add("Vision");

            // If we have a current patient, add insuracne information about the patient to various insurance text box's
            if (Program.currentPatient != null)
            {
                if (Program.currentPatient.billing.insurance.provider == null || Program.currentPatient.billing.insurance.provider == "")
                {
                    this.printButton.Visible = false;
                }

                this.providerTextBox.Text = Program.currentPatient.billing.insurance.provider;
                this.binTextBox.Text = Program.currentPatient.billing.insurance.bin;
                this.idTextBox.Text = Program.currentPatient.billing.insurance.id;
                this.pcnTextBox.Text = Program.currentPatient.billing.insurance.pcn;
                this.groupTextBox.Text = Program.currentPatient.billing.insurance.groupNum;

                if (Program.currentPatient.billing.insurance.insuranceType == "Medical")
                {
                    this.typeComboBox.Text = "Medical";
                }
                else if (Program.currentPatient.billing.insurance.insuranceType == "Dental")
                {
                    this.typeComboBox.Text = "Dental";
                }
                else if (Program.currentPatient.billing.insurance.insuranceType == "Prescriptions")
                {
                    this.typeComboBox.Text = "Prescriptions";
                }
                else if (Program.currentPatient.billing.insurance.insuranceType == "Vision")
                {
                    this.typeComboBox.Text = "Vision";
                }

                // Makes the patient's insurance information not editable
                makeReadOnly();
            }
        }

        // Makes the patient's insurance information not editable
        public void makeReadOnly()
        {
            this.providerTextBox.ReadOnly = true;
            this.binTextBox.ReadOnly = true;
            this.idTextBox.ReadOnly = true;
            this.pcnTextBox.ReadOnly = true;
            this.groupTextBox.ReadOnly = true;
            this.typeComboBox.Enabled = false;
        }

        // Makes the patient's insurance information editable
        public void makeReadable()
        {
            this.providerTextBox.ReadOnly = false;
            this.binTextBox.ReadOnly = false;
            this.idTextBox.ReadOnly = false;
            this.pcnTextBox.ReadOnly = false;
            this.groupTextBox.ReadOnly = false;
            this.typeComboBox.Enabled = true;
        }

        // Will allow the Office Staff user to update a patient's insurance information
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Update")
            {
                // Makes the patient's profile text box's editable
                makeReadable();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save";

                this.cancelButton.Visible = true;

                // Allow the Office Staff user to see the cancelButton
                this.cancelButton.Visible = true;

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save")
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox && (((TextBox)ctrl).Text == "" || ((TextBox)ctrl).Text == ""))
                    {
                        MessageBox.Show("Patient's insurance information text box's must all contain data!",
                        "Not enough information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }

                // Assign various insurance information to the current patient
                Program.currentPatient.billing.insurance.provider = providerTextBox.Text;
                Program.currentPatient.billing.insurance.bin = binTextBox.Text;
                Program.currentPatient.billing.insurance.id = idTextBox.Text;
                Program.currentPatient.billing.insurance.pcn = pcnTextBox.Text;
                Program.currentPatient.billing.insurance.groupNum = groupTextBox.Text;
                Program.currentPatient.billing.insurance.insuranceType = typeComboBox.Text;

                // Makes the patient's profile text box's not editable
                PIMSController.SQLcommands.updatePatient();

                if (Program.currentPatient.billing.insurance.provider != null && Program.currentPatient.billing.insurance.provider != "")
                {
                    this.printButton.Visible = true;
                }

                makeReadOnly();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Update";

                this.cancelButton.Visible = false;

                // Display information message
                MessageBox.Show("Patient's insurance information has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will toggle the saveUpdateButton Text and the cancelButton Visability
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.saveUpdateButton.Text = "Update";

            this.cancelButton.Visible = false;

            makeReadOnly();
        }

        // Will allow the user to print the patient's insurance information
        private void printButton_Click(object sender, EventArgs e)
        {
            string noInfo = "Information not provided";

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var myWordDoc = app.Documents.Open(@"F:\PIMS_Final\FORMS\PIMS INSURANCE FORM.docx", ReadOnly: false, Visible: true);
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

            Microsoft.Office.Interop.Word.Find findProvider = myWordDoc.ActiveWindow.Selection.Find;
            findProvider.Text = "@provider";

            if (Program.currentPatient.billing.insurance.provider.ToString() == "")
            {
                findProvider.Replacement.Text = noInfo;
            }
            else
            {
                findProvider.Replacement.Text = Program.currentPatient.billing.insurance.provider.ToString();
            }
            findProvider.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findBIN = myWordDoc.ActiveWindow.Selection.Find;
            findBIN.Text = "@bin";

            if (Program.currentPatient.billing.insurance.bin.ToString() == "")
            {
                findBIN.Replacement.Text = noInfo;
            }
            else
            {
                findBIN.Replacement.Text = Program.currentPatient.billing.insurance.bin.ToString();
            }
            findBIN.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findID = myWordDoc.ActiveWindow.Selection.Find;
            findID.Text = "@id";

            if (Program.currentPatient.billing.insurance.id.ToString() == "")
            {
                findID.Replacement.Text = noInfo;
            }
            else
            {
                findID.Replacement.Text = Program.currentPatient.billing.insurance.id.ToString();
            }
            findID.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findPCN = myWordDoc.ActiveWindow.Selection.Find;
            findPCN.Text = "@pcn";

            if (Program.currentPatient.billing.insurance.pcn.ToString() == "")
            {
                findPCN.Replacement.Text = noInfo;
            }
            else
            {
                findPCN.Replacement.Text = Program.currentPatient.billing.insurance.pcn.ToString();
            }
            findPCN.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findGroup = myWordDoc.ActiveWindow.Selection.Find;
            findGroup.Text = "@group";

            if (Program.currentPatient.billing.insurance.groupNum.ToString() == "")
            {
                findGroup.Replacement.Text = noInfo;
            }
            else
            {
                findGroup.Replacement.Text = Program.currentPatient.billing.insurance.groupNum.ToString();
            }
            findGroup.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            Microsoft.Office.Interop.Word.Find findTpye = myWordDoc.ActiveWindow.Selection.Find;
            findTpye.Text = "@type";

            if (Program.currentPatient.billing.insurance.insuranceType.ToString() == "")
            {
                findTpye.Replacement.Text = noInfo;
            }
            else
            {
                findTpye.Replacement.Text = Program.currentPatient.billing.insurance.insuranceType.ToString();
            }
            findTpye.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            myWordDoc.SaveAs2(@"F:\PIMS_Final\" + Program.currentPatient.directory.lName + "." + Program.currentPatient.directory.fName + ".Insurance Information.pdf");
            myWordDoc.PrintPreview();
        }
    }
}
