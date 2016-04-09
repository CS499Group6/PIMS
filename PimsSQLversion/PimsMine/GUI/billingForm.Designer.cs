namespace PIMS
{
    partial class billingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.insPaidBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dueBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.itemNameBox = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Charges:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount Paid:";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(122, 65);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(100, 20);
            this.costBox.TabIndex = 2;
            // 
            // paidBox
            // 
            this.paidBox.Location = new System.Drawing.Point(122, 119);
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(100, 20);
            this.paidBox.TabIndex = 3;
            // 
            // insPaidBox
            // 
            this.insPaidBox.Location = new System.Drawing.Point(122, 91);
            this.insPaidBox.Name = "insPaidBox";
            this.insPaidBox.Size = new System.Drawing.Size(100, 20);
            this.insPaidBox.TabIndex = 5;
            this.insPaidBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insurance Paid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Due Date:";
            // 
            // dueBox
            // 
            this.dueBox.Location = new System.Drawing.Point(122, 145);
            this.dueBox.Name = "dueBox";
            this.dueBox.Size = new System.Drawing.Size(100, 20);
            this.dueBox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.treatmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // treatmentToolStripMenuItem
            // 
            this.treatmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorNotesToolStripMenuItem,
            this.nurseNotesToolStripMenuItem,
            this.prescriptionInfoToolStripMenuItem,
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(26, 250);
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
            this.queryLabel.Location = new System.Drawing.Point(23, 237);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 44;
            this.queryLabel.Text = "Search for a Patient, Enter a Prescription number or select a Function ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemNameBox
            // 
            this.itemNameBox.AutoSize = true;
            this.itemNameBox.Location = new System.Drawing.Point(23, 42);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(59, 13);
            this.itemNameBox.TabIndex = 47;
            this.itemNameBox.Text = "Item name:";
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(122, 39);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(100, 20);
            this.itemBox.TabIndex = 48;
            // 
            // billingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 285);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dueBox);
            this.Controls.Add(this.insPaidBox);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "billingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Information";
            this.Load += new System.EventHandler(this.billingForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox paidBox;
        private System.Windows.Forms.TextBox insPaidBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dueBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem treatmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label itemNameBox;
        private System.Windows.Forms.TextBox itemBox;
    }
}