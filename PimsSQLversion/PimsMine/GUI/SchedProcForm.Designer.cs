namespace PimsMain.GUI
{
    partial class SchedProcForm
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
            this.addNewProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.procedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.where = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.treatmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProcedureToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewProcedureToolStripMenuItem
            // 
            this.addNewProcedureToolStripMenuItem.Name = "addNewProcedureToolStripMenuItem";
            this.addNewProcedureToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewProcedureToolStripMenuItem.Text = "Add new procedure";
            this.addNewProcedureToolStripMenuItem.Click += new System.EventHandler(this.addNewProcedureToolStripMenuItem_Click);
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorNotesToolStripMenuItem,
            this.nurseNotesToolStripMenuItem,
            this.prescriptionInfoToolStripMenuItem,
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
            // prescriptionInfoToolStripMenuItem
            // 
            this.prescriptionInfoToolStripMenuItem.Name = "prescriptionInfoToolStripMenuItem";
            this.prescriptionInfoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.prescriptionInfoToolStripMenuItem.Text = "Prescription Info";
            this.prescriptionInfoToolStripMenuItem.Click += new System.EventHandler(this.prescriptionInfoToolStripMenuItem_Click);
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
            this.detailedBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detailedBillToolStripMenuItem.Text = "Detailed Bill";
            this.detailedBillToolStripMenuItem.Click += new System.EventHandler(this.detailedBillToolStripMenuItem_Click);
            // 
            // summaryBillToolStripMenuItem
            // 
            this.summaryBillToolStripMenuItem.Name = "summaryBillToolStripMenuItem";
            this.summaryBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryBillToolStripMenuItem.Text = "Summary Bill";
            this.summaryBillToolStripMenuItem.Click += new System.EventHandler(this.summaryBillToolStripMenuItem_Click);
            // 
            // insuranceInfoToolStripMenuItem
            // 
            this.insuranceInfoToolStripMenuItem.Name = "insuranceInfoToolStripMenuItem";
            this.insuranceInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insuranceInfoToolStripMenuItem.Text = "Insurance Info";
            this.insuranceInfoToolStripMenuItem.Click += new System.EventHandler(this.insuranceInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedure,
            this.date,
            this.who,
            this.where});
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(490, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // procedure
            // 
            this.procedure.HeaderText = "Procedure";
            this.procedure.Name = "procedure";
            this.procedure.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "When";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // who
            // 
            this.who.HeaderText = "Performed by";
            this.who.Name = "who";
            this.who.ReadOnly = true;
            // 
            // where
            // 
            this.where.HeaderText = "Location";
            this.where.Name = "where";
            this.where.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search for new Patient";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
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
            // visitorsToolStripMenuItem
            // 
            this.visitorsToolStripMenuItem.Name = "visitorsToolStripMenuItem";
            this.visitorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorsToolStripMenuItem.Text = "Visitors";
            this.visitorsToolStripMenuItem.Click += new System.EventHandler(this.visitorsToolStripMenuItem_Click);
            // 
            // SchedProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SchedProcForm";
            this.Text = "Scheduled Procedures";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn who;
        private System.Windows.Forms.DataGridViewTextBoxColumn where;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorsToolStripMenuItem;
    }
}