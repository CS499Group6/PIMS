namespace PIMS
{
    partial class prescriptionGrid
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
            this.queryLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(94, 531);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 39;
            this.queryLabel.Text = "Search for a Patient, Enter a Prescription number or select a Function ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 547);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 38;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.treatmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPrescriptionToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // addNewPrescriptionToolStripMenuItem
            // 
            this.addNewPrescriptionToolStripMenuItem.Name = "addNewPrescriptionToolStripMenuItem";
            this.addNewPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addNewPrescriptionToolStripMenuItem.Text = "Add new prescription";
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsNotesToolStripMenuItem,
            this.nursesNotesToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.scheduledProceduresToolStripMenuItem});
            this.treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            this.treatmentToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.treatmentToolStripMenuItem.Text = "Treatment";
            // 
            // doctorsNotesToolStripMenuItem
            // 
            this.doctorsNotesToolStripMenuItem.Name = "doctorsNotesToolStripMenuItem";
            this.doctorsNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.doctorsNotesToolStripMenuItem.Text = "Doctor\'s Notes";
            // 
            // nursesNotesToolStripMenuItem
            // 
            this.nursesNotesToolStripMenuItem.Name = "nursesNotesToolStripMenuItem";
            this.nursesNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nursesNotesToolStripMenuItem.Text = "Nurse\'s Notes";
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            // 
            // scheduledProceduresToolStripMenuItem
            // 
            this.scheduledProceduresToolStripMenuItem.Name = "scheduledProceduresToolStripMenuItem";
            this.scheduledProceduresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.scheduledProceduresToolStripMenuItem.Text = "Scheduled Procedures";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailedBillToolStripMenuItem,
            this.summaryBillToolStripMenuItem,
            this.insuranceInfoToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // detailedBillToolStripMenuItem
            // 
            this.detailedBillToolStripMenuItem.Name = "detailedBillToolStripMenuItem";
            this.detailedBillToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.detailedBillToolStripMenuItem.Text = "Detailed Bill";
            // 
            // summaryBillToolStripMenuItem
            // 
            this.summaryBillToolStripMenuItem.Name = "summaryBillToolStripMenuItem";
            this.summaryBillToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.summaryBillToolStripMenuItem.Text = "Summary Bill";
            this.summaryBillToolStripMenuItem.Click += new System.EventHandler(this.summaryBillToolStripMenuItem_Click);
            // 
            // insuranceInfoToolStripMenuItem
            // 
            this.insuranceInfoToolStripMenuItem.Name = "insuranceInfoToolStripMenuItem";
            this.insuranceInfoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.insuranceInfoToolStripMenuItem.Text = "Insurance Info";
            this.insuranceInfoToolStripMenuItem.Click += new System.EventHandler(this.insuranceInfoToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientFormToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.visitorsToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // patientFormToolStripMenuItem
            // 
            this.patientFormToolStripMenuItem.Name = "patientFormToolStripMenuItem";
            this.patientFormToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.patientFormToolStripMenuItem.Text = "Patient Form";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // visitorsToolStripMenuItem
            // 
            this.visitorsToolStripMenuItem.Name = "visitorsToolStripMenuItem";
            this.visitorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.visitorsToolStripMenuItem.Text = "Visitors";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNum,
            this.drugName,
            this.NDC,
            this.Column1,
            this.fillDate});
            this.DGV.Location = new System.Drawing.Point(22, 40);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(593, 452);
            this.DGV.TabIndex = 41;
            // 
            // idNum
            // 
            this.idNum.HeaderText = "ID#";
            this.idNum.Name = "idNum";
            // 
            // drugName
            // 
            this.drugName.HeaderText = "Drug Name";
            this.drugName.Name = "drugName";
            this.drugName.Width = 150;
            // 
            // NDC
            // 
            this.NDC.HeaderText = "NDC";
            this.NDC.Name = "NDC";
            this.NDC.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Price";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // fillDate
            // 
            this.fillDate.HeaderText = "Date Filled mm/dd/yyyy";
            this.fillDate.Name = "fillDate";
            // 
            // prescriptionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 599);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "prescriptionGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription Information";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fillDate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorsToolStripMenuItem;
    }
}