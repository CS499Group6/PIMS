namespace PIMS
{
    partial class billingGrid
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.DueDate,
            this.Charges,
            this.InsurancePaid,
            this.AmountPaid,
            this.AmountOwed});
            this.DGV.Location = new System.Drawing.Point(23, 38);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 35;
            this.DGV.Size = new System.Drawing.Size(637, 294);
            this.DGV.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.treatmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorNotesToolStripMenuItem,
            this.nurseNotesToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.scheduledProceduresToolStripMenuItem});
            this.treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            this.treatmentToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.treatmentToolStripMenuItem.Text = "Treatment";
            // 
            // doctorNotesToolStripMenuItem
            // 
            this.doctorNotesToolStripMenuItem.Name = "doctorNotesToolStripMenuItem";
            this.doctorNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.doctorNotesToolStripMenuItem.Text = "Doctor Notes";
            this.doctorNotesToolStripMenuItem.Click += new System.EventHandler(this.doctorNotesToolStripMenuItem_Click);
            // 
            // nurseNotesToolStripMenuItem
            // 
            this.nurseNotesToolStripMenuItem.Name = "nurseNotesToolStripMenuItem";
            this.nurseNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nurseNotesToolStripMenuItem.Text = "Nurse Notes";
            this.nurseNotesToolStripMenuItem.Click += new System.EventHandler(this.nurseNotesToolStripMenuItem_Click);
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            this.prescriptionsToolStripMenuItem.Click += new System.EventHandler(this.prescriptionsToolStripMenuItem_Click);
            // 
            // scheduledProceduresToolStripMenuItem
            // 
            this.scheduledProceduresToolStripMenuItem.Name = "scheduledProceduresToolStripMenuItem";
            this.scheduledProceduresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.scheduledProceduresToolStripMenuItem.Text = "Scheduled Procedures";
            this.scheduledProceduresToolStripMenuItem.Click += new System.EventHandler(this.scheduledProceduresToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailedBillingToolStripMenuItem,
            this.summaryBillingToolStripMenuItem,
            this.insuranceInfoToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // detailedBillingToolStripMenuItem
            // 
            this.detailedBillingToolStripMenuItem.Name = "detailedBillingToolStripMenuItem";
            this.detailedBillingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.detailedBillingToolStripMenuItem.Text = "Detailed Billing";
            this.detailedBillingToolStripMenuItem.Click += new System.EventHandler(this.detailedBillingToolStripMenuItem_Click);
            // 
            // summaryBillingToolStripMenuItem
            // 
            this.summaryBillingToolStripMenuItem.Name = "summaryBillingToolStripMenuItem";
            this.summaryBillingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.summaryBillingToolStripMenuItem.Text = "Summary Billing";
            this.summaryBillingToolStripMenuItem.Click += new System.EventHandler(this.summaryBillingToolStripMenuItem_Click);
            // 
            // insuranceInfoToolStripMenuItem
            // 
            this.insuranceInfoToolStripMenuItem.Name = "insuranceInfoToolStripMenuItem";
            this.insuranceInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.insuranceInfoToolStripMenuItem.Text = "Insurance Info";
            this.insuranceInfoToolStripMenuItem.Click += new System.EventHandler(this.insuranceInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.logOffToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(23, 380);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(509, 20);
            this.searchBox.TabIndex = 45;
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(20, 364);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(341, 13);
            this.queryLabel.TabIndex = 44;
            this.queryLabel.Text = "Search for a Patient, Enter a Presscription number or select a Function ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            // 
            // billingGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "billingGrid";
            this.Text = "Billing Information";
            this.Load += new System.EventHandler(this.billingGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}