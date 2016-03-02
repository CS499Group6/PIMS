namespace PIMS
{
    partial class nurseNotesGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allergies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.HeartRate,
            this.Allergies,
            this.NurseNotes,
            this.BloodPressure,
            this.Height,
            this.Weight});
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.abboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 1;
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
            // abboutToolStripMenuItem
            // 
            this.abboutToolStripMenuItem.Name = "abboutToolStripMenuItem";
            this.abboutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.abboutToolStripMenuItem.Text = "Abbout";
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Date/Time";
            this.DateTime.Name = "DateTime";
            // 
            // HeartRate
            // 
            this.HeartRate.HeaderText = "Heart Rate";
            this.HeartRate.Name = "HeartRate";
            // 
            // Allergies
            // 
            this.Allergies.HeaderText = "Allergies";
            this.Allergies.Name = "Allergies";
            // 
            // NurseNotes
            // 
            this.NurseNotes.HeaderText = "Nurse Notes";
            this.NurseNotes.Name = "NurseNotes";
            // 
            // BloodPressure
            // 
            this.BloodPressure.HeaderText = "Blood Pressure";
            this.BloodPressure.Name = "BloodPressure";
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // nurseNotesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 307);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "nurseNotesGrid";
            this.Text = "Nurse Notes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allergies;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}