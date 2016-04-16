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
    public partial class BillingForm : UserControl
    {
        // Default Constructor
        public BillingForm(PIMSController.BillingLineItem item)
        {
            InitializeComponent();

            // Do not allow user to edit the idTextBox
            this.idTextBox.ReadOnly = true;

            // If we have line items to add
            // Add them
            if (item.itemId != 0)
            {
                this.idTextBox.Text = item.itemId.ToString();
                this.itemTextBox.Text = item.item;
                this.costTextBox.Text = Math.Round(((float)item.cost / 100.0), 2).ToString();
                this.insPaidTextBox.Text = Math.Round(((float)item.insPaid / 100.0), 2).ToString();
                this.paidTextBox.Text = Math.Round(((float)item.paid / 100.0), 2).ToString();
                this.dueTextBox.Text = item.dueDate.ToString(@"MM\/dd\/yyyy");
            }
            // This is a new billing line item
            else
            {
                // Set the new line item id in Controller

                // Makes the patient's medical stats editable
                makeReadable();

                saveUpdateButton.Text = "Save New Billing Line Item";
            }

            // Makes the billing text box's not editable
            makeReadOnly();
        }

        // Makes the billing text box's not editable
        public void makeReadOnly()
        {
            this.itemTextBox.ReadOnly = true;
            this.costTextBox.ReadOnly = true;
            this.insPaidTextBox.ReadOnly = true;
            this.paidTextBox.ReadOnly = true;
            this.dueTextBox.ReadOnly = true;
        }

        // Makes the billing text box's editable
        public void makeReadable()
        {
            this.itemTextBox.ReadOnly = false;
            this.costTextBox.ReadOnly = false;
            this.insPaidTextBox.ReadOnly = false;
            this.paidTextBox.ReadOnly = false;
            this.dueTextBox.ReadOnly = false;
        }

        // Will allow the Office Staff user to update a patient's billing information
        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            if (saveUpdateButton.Text == "Update Billing Line Item")
            {
                // Makes the billing text box's editable
                makeReadable();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Save Billing Line Item";

                // Exit out of this function
                return;
            }
            else if (saveUpdateButton.Text == "Save Billing Line Item" || saveUpdateButton.Text == "Save New Billing Line Item")
            {
                //Program.currentPatient.billing.items
                    // = itemTextBox.Text;
                // = costTextBox.Text;
                // = insPaidTextBox.Text;;
                // = paidTextBox.Text;
                // = dueTextBox.Text;

                PIMSController.SQLcommands.updatePatient();

                // Makes the billing text box's not editable
                makeReadOnly();

                // Change the saveUpdateButton text
                saveUpdateButton.Text = "Update Billing Line Item";

                // Display information message
                MessageBox.Show("Patient's billing line item has been saved!",
                "Information saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Will allow the Office Staff to print the patient's billing information
        private void printButon_Click(object sender, EventArgs e)
        {

        }       
    }
}
