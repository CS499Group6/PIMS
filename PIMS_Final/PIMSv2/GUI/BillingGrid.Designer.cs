namespace PIMS
{
    partial class BillingGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.billingGridDataView = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billingGridDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // billingGridDataView
            // 
            this.billingGridDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingGridDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGridDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.DueDate,
            this.Charges,
            this.InsurancePaid,
            this.AmountPaid,
            this.AmountOwed});
            this.billingGridDataView.Location = new System.Drawing.Point(16, 17);
            this.billingGridDataView.Name = "billingGridDataView";
            this.billingGridDataView.RowHeadersWidth = 35;
            this.billingGridDataView.Size = new System.Drawing.Size(637, 320);
            this.billingGridDataView.TabIndex = 1;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            // 
            // Charges
            // 
            this.Charges.HeaderText = "Charges";
            this.Charges.Name = "Charges";
            // 
            // InsurancePaid
            // 
            this.InsurancePaid.HeaderText = "Insurance Paid";
            this.InsurancePaid.Name = "InsurancePaid";
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            // 
            // AmountOwed
            // 
            this.AmountOwed.HeaderText = "Amount Owed";
            this.AmountOwed.Name = "AmountOwed";
            // 
            // BillingGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.billingGridDataView);
            this.Name = "BillingGrid";
            this.Size = new System.Drawing.Size(711, 526);
            ((System.ComponentModel.ISupportInitialize)(this.billingGridDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billingGridDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
    }
}
