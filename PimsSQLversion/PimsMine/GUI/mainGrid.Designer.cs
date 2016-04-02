namespace PIMS
{
    partial class mainGrid
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientQueryDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientQueryDataGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(34, 556);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 39;
            this.queryLabel.Text = "Search for a Patient, Enter a Prescription number or select a Function ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 572);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // patientQueryDataGridView
            // 
            this.patientQueryDataGridView.AllowUserToAddRows = false;
            this.patientQueryDataGridView.AllowUserToDeleteRows = false;
            this.patientQueryDataGridView.AllowUserToResizeColumns = false;
            this.patientQueryDataGridView.AllowUserToResizeRows = false;
            this.patientQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientQueryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.patNum,
            this.lastName,
            this.firstName,
            this.middleName,
            this.DOB,
            this.facNum,
            this.roomNum,
            this.Bed});
            this.patientQueryDataGridView.Location = new System.Drawing.Point(12, 37);
            this.patientQueryDataGridView.Name = "patientQueryDataGridView";
            this.patientQueryDataGridView.Size = new System.Drawing.Size(859, 488);
            this.patientQueryDataGridView.TabIndex = 40;
            this.patientQueryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientQueryDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "selectBox";
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Select";
            this.Column1.IndeterminateValue = "false";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            this.Column1.Width = 50;
            // 
            // patNum
            // 
            this.patNum.DataPropertyName = "patientID";
            this.patNum.HeaderText = "Patient ID";
            this.patNum.Name = "patNum";
            this.patNum.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // middleName
            // 
            this.middleName.HeaderText = "Middle Name";
            this.middleName.Name = "middleName";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB mm/dd/yyyy";
            this.DOB.Name = "DOB";
            // 
            // facNum
            // 
            this.facNum.HeaderText = "Facility";
            this.facNum.Name = "facNum";
            // 
            // roomNum
            // 
            this.roomNum.HeaderText = "Room #";
            this.roomNum.Name = "roomNum";
            // 
            // Bed
            // 
            this.Bed.HeaderText = "Bed #";
            this.Bed.Name = "Bed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 41;
            this.button1.Text = "Go to Patient Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
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
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientFormToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.visitorListToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewPatientToolStripMenuItem.Text = "Add new patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // doctorNotesToolStripMenuItem
            // 
            this.doctorNotesToolStripMenuItem.Name = "doctorNotesToolStripMenuItem";
            this.doctorNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.doctorNotesToolStripMenuItem.Text = "Doctor Notes";
            // 
            // nurseNotesToolStripMenuItem
            // 
            this.nurseNotesToolStripMenuItem.Name = "nurseNotesToolStripMenuItem";
            this.nurseNotesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nurseNotesToolStripMenuItem.Text = "Nurse Notes";
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
            // detailedBillToolStripMenuItem
            // 
            this.detailedBillToolStripMenuItem.Name = "detailedBillToolStripMenuItem";
            this.detailedBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detailedBillToolStripMenuItem.Text = "Detailed Bill";
            // 
            // summaryBillToolStripMenuItem
            // 
            this.summaryBillToolStripMenuItem.Name = "summaryBillToolStripMenuItem";
            this.summaryBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryBillToolStripMenuItem.Text = "Summary Bill";
            // 
            // insuranceInfoToolStripMenuItem
            // 
            this.insuranceInfoToolStripMenuItem.Name = "insuranceInfoToolStripMenuItem";
            this.insuranceInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insuranceInfoToolStripMenuItem.Text = "Insurance Info";
            // 
            // patientFormToolStripMenuItem
            // 
            this.patientFormToolStripMenuItem.Name = "patientFormToolStripMenuItem";
            this.patientFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientFormToolStripMenuItem.Text = "Patient Form";
            this.patientFormToolStripMenuItem.Click += new System.EventHandler(this.patientFormToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // visitorListToolStripMenuItem
            // 
            this.visitorListToolStripMenuItem.Name = "visitorListToolStripMenuItem";
            this.visitorListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorListToolStripMenuItem.Text = "Visitor list";
            this.visitorListToolStripMenuItem.Click += new System.EventHandler(this.visitorListToolStripMenuItem_Click);
            // 
            // mainGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientQueryDataGridView);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainGrid";
            this.Text = "Patient Query";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientQueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView patientQueryDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn facNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}