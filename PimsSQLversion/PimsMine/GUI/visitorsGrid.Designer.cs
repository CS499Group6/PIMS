namespace PIMS
{
    partial class visitorsGrid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.volunteerGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.selectBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vistiors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volunteerGridToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // volunteerGridToolStripMenuItem
            // 
            this.volunteerGridToolStripMenuItem.Name = "volunteerGridToolStripMenuItem";
            this.volunteerGridToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.volunteerGridToolStripMenuItem.Text = "Volunteer Grid";
            this.volunteerGridToolStripMenuItem.Click += new System.EventHandler(this.volunteerGridToolStripMenuItem_Click);
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorNotesToolStripMenuItem,
            this.nurseNotesToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.scheduledProceduresToolStripMenuItem});
            this.treatmentToolStripMenuItem.Name = "treatmentToolStripMenuItem";
            this.treatmentToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
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
            this.detailedBillToolStripMenuItem.Click += new System.EventHandler(this.detailedBillToolStripMenuItem_Click);
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
            this.patientFormToolStripMenuItem.Click += new System.EventHandler(this.patientFormToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // visitorsToolStripMenuItem
            // 
            this.visitorsToolStripMenuItem.Name = "visitorsToolStripMenuItem";
            this.visitorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.visitorsToolStripMenuItem.Text = "Visitors";
            this.visitorsToolStripMenuItem.Click += new System.EventHandler(this.visitorsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Exit";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(23, 477);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 37;
            this.queryLabel.Text = "Search for a Patient, Enter a Prescription number or select a Function ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(26, 493);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(444, 20);
            this.searchBox.TabIndex = 36;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBox,
            this.vistiors});
            this.dgv.Location = new System.Drawing.Point(26, 27);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(444, 385);
            this.dgv.TabIndex = 38;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectBox
            // 
            this.selectBox.FalseValue = "false";
            this.selectBox.HeaderText = "Select";
            this.selectBox.IndeterminateValue = "false";
            this.selectBox.Name = "selectBox";
            this.selectBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectBox.TrueValue = "true";
            this.selectBox.Width = 43;
            // 
            // vistiors
            // 
            this.vistiors.HeaderText = "Approved Vistors";
            this.vistiors.Name = "vistiors";
            this.vistiors.ReadOnly = true;
            this.vistiors.Width = 112;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(503, 491);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(503, 74);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(123, 20);
            this.nameBox.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Add visitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Remove selected visitors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // visitorsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "visitorsGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approved Visitors";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn vistiors;
        private System.Windows.Forms.ToolStripMenuItem volunteerGridToolStripMenuItem;
    }
}