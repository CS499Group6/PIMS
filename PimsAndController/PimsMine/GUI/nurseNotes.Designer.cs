namespace PIMS
{
    partial class nurseNotes
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBar = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.htLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.bpTextBox = new System.Windows.Forms.TextBox();
            this.heartRateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.allergiesTextBox = new System.Windows.Forms.RichTextBox();
            this.nurseReportButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newerStatsButton = new System.Windows.Forms.Button();
            this.prevStatsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updateNurseNotesButton = new System.Windows.Forms.Button();
            this.updateAllergiesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // queryBar
            // 
            this.queryBar.Location = new System.Drawing.Point(87, 474);
            this.queryBar.Name = "queryBar";
            this.queryBar.Size = new System.Drawing.Size(509, 20);
            this.queryBar.TabIndex = 49;
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(84, 458);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 48;
            this.queryLabel.Text = "Search for a Patient, Enter a Prescription number or select a Function ";
            // 
            // htLabel
            // 
            this.htLabel.AutoSize = true;
            this.htLabel.Location = new System.Drawing.Point(90, 58);
            this.htLabel.Name = "htLabel";
            this.htLabel.Size = new System.Drawing.Size(41, 13);
            this.htLabel.TabIndex = 50;
            this.htLabel.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Weight:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Blood Pressure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Heart Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Allergies:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(137, 58);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 55;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(137, 82);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 56;
            // 
            // bpTextBox
            // 
            this.bpTextBox.Location = new System.Drawing.Point(137, 108);
            this.bpTextBox.Name = "bpTextBox";
            this.bpTextBox.Size = new System.Drawing.Size(100, 20);
            this.bpTextBox.TabIndex = 57;
            // 
            // heartRateTextBox
            // 
            this.heartRateTextBox.Location = new System.Drawing.Point(138, 134);
            this.heartRateTextBox.Name = "heartRateTextBox";
            this.heartRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.heartRateTextBox.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nurse Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(138, 210);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(282, 169);
            this.notesTextBox.TabIndex = 61;
            this.notesTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Date/Time:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(137, 34);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 63;
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.Location = new System.Drawing.Point(138, 161);
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(282, 43);
            this.allergiesTextBox.TabIndex = 64;
            this.allergiesTextBox.Text = "";
            // 
            // nurseReportButton
            // 
            this.nurseReportButton.Location = new System.Drawing.Point(137, 401);
            this.nurseReportButton.Name = "nurseReportButton";
            this.nurseReportButton.Size = new System.Drawing.Size(283, 23);
            this.nurseReportButton.TabIndex = 65;
            this.nurseReportButton.Text = "Print Report";
            this.nurseReportButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newerStatsButton
            // 
            this.newerStatsButton.Location = new System.Drawing.Point(749, 63);
            this.newerStatsButton.Name = "newerStatsButton";
            this.newerStatsButton.Size = new System.Drawing.Size(75, 23);
            this.newerStatsButton.TabIndex = 67;
            this.newerStatsButton.Text = "Newer Stats";
            this.newerStatsButton.UseVisualStyleBackColor = true;
            this.newerStatsButton.Click += new System.EventHandler(this.newerStatsButton_Click);
            // 
            // prevStatsButton
            // 
            this.prevStatsButton.Location = new System.Drawing.Point(749, 34);
            this.prevStatsButton.Name = "prevStatsButton";
            this.prevStatsButton.Size = new System.Drawing.Size(75, 23);
            this.prevStatsButton.TabIndex = 68;
            this.prevStatsButton.Text = "Older Stats";
            this.prevStatsButton.UseVisualStyleBackColor = true;
            this.prevStatsButton.Click += new System.EventHandler(this.prevStatsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Save Stats";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateNurseNotesButton
            // 
            this.updateNurseNotesButton.Location = new System.Drawing.Point(695, 355);
            this.updateNurseNotesButton.Name = "updateNurseNotesButton";
            this.updateNurseNotesButton.Size = new System.Drawing.Size(126, 23);
            this.updateNurseNotesButton.TabIndex = 70;
            this.updateNurseNotesButton.Text = "Update Notes";
            this.updateNurseNotesButton.UseVisualStyleBackColor = true;
            // 
            // updateAllergiesButton
            // 
            this.updateAllergiesButton.Location = new System.Drawing.Point(695, 181);
            this.updateAllergiesButton.Name = "updateAllergiesButton";
            this.updateAllergiesButton.Size = new System.Drawing.Size(129, 23);
            this.updateAllergiesButton.TabIndex = 71;
            this.updateAllergiesButton.Text = "Update Allergies";
            this.updateAllergiesButton.UseVisualStyleBackColor = true;
            // 
            // nurseNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 546);
            this.Controls.Add(this.updateAllergiesButton);
            this.Controls.Add(this.updateNurseNotesButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prevStatsButton);
            this.Controls.Add(this.newerStatsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nurseReportButton);
            this.Controls.Add(this.allergiesTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heartRateTextBox);
            this.Controls.Add(this.bpTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htLabel);
            this.Controls.Add(this.queryBar);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "nurseNotes";
            this.Text = "Nurse Notes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox queryBar;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label htLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox bpTextBox;
        private System.Windows.Forms.TextBox heartRateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.RichTextBox allergiesTextBox;
        private System.Windows.Forms.Button nurseReportButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newerStatsButton;
        private System.Windows.Forms.Button prevStatsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateNurseNotesButton;
        private System.Windows.Forms.Button updateAllergiesButton;
    }
}