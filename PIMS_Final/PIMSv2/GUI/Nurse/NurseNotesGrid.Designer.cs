namespace PIMS
{
    partial class NurseNotesGrid
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nurseNotesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateAllergiesButton = new System.Windows.Forms.Button();
            this.updateNurseNotesButton = new System.Windows.Forms.Button();
            this.addStat = new System.Windows.Forms.Button();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nurseNotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Nurse Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Allergies:";
            // 
            // nurseNotesDataGridView
            // 
            this.nurseNotesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nurseNotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseNotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.nurse,
            this.dateTime,
            this.height,
            this.weight,
            this.bp,
            this.hr});
            this.nurseNotesDataGridView.Location = new System.Drawing.Point(17, 33);
            this.nurseNotesDataGridView.Name = "nurseNotesDataGridView";
            this.nurseNotesDataGridView.RowHeadersWidth = 35;
            this.nurseNotesDataGridView.Size = new System.Drawing.Size(839, 313);
            this.nurseNotesDataGridView.TabIndex = 90;
            this.nurseNotesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nurseNotesDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Select";
            this.Column1.IndeterminateValue = "false";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // id
            // 
            this.id.HeaderText = "Id Number";
            this.id.Name = "id";
            // 
            // nurse
            // 
            this.nurse.HeaderText = "Nurse";
            this.nurse.Name = "nurse";
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date/Time";
            this.dateTime.Name = "dateTime";
            // 
            // height
            // 
            this.height.HeaderText = "Height";
            this.height.Name = "height";
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            // 
            // bp
            // 
            this.bp.HeaderText = "Blood Pressure";
            this.bp.Name = "bp";
            // 
            // hr
            // 
            this.hr.HeaderText = "Heart Rate";
            this.hr.Name = "hr";
            // 
            // updateAllergiesButton
            // 
            this.updateAllergiesButton.Location = new System.Drawing.Point(409, 364);
            this.updateAllergiesButton.Name = "updateAllergiesButton";
            this.updateAllergiesButton.Size = new System.Drawing.Size(129, 23);
            this.updateAllergiesButton.TabIndex = 96;
            this.updateAllergiesButton.Text = "Update Allergies";
            this.updateAllergiesButton.UseVisualStyleBackColor = true;
            this.updateAllergiesButton.Click += new System.EventHandler(this.updateAllergiesButton_Click);
            // 
            // updateNurseNotesButton
            // 
            this.updateNurseNotesButton.Location = new System.Drawing.Point(412, 466);
            this.updateNurseNotesButton.Name = "updateNurseNotesButton";
            this.updateNurseNotesButton.Size = new System.Drawing.Size(126, 23);
            this.updateNurseNotesButton.TabIndex = 95;
            this.updateNurseNotesButton.Text = "Update Nurse Notes";
            this.updateNurseNotesButton.UseVisualStyleBackColor = true;
            this.updateNurseNotesButton.Click += new System.EventHandler(this.updateNurseNotesButton_Click);
            // 
            // addStat
            // 
            this.addStat.Location = new System.Drawing.Point(729, 560);
            this.addStat.Name = "addStat";
            this.addStat.Size = new System.Drawing.Size(127, 23);
            this.addStat.TabIndex = 97;
            this.addStat.Text = "Add New Stat";
            this.addStat.UseVisualStyleBackColor = true;
            this.addStat.Click += new System.EventHandler(this.addStat_Click);
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.Location = new System.Drawing.Point(121, 364);
            this.allergiesTextBox.Multiline = true;
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(226, 83);
            this.allergiesTextBox.TabIndex = 98;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(121, 468);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(226, 115);
            this.notesTextBox.TabIndex = 99;
            // 
            // NurseNotesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.allergiesTextBox);
            this.Controls.Add(this.addStat);
            this.Controls.Add(this.updateAllergiesButton);
            this.Controls.Add(this.updateNurseNotesButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nurseNotesDataGridView);
            this.Name = "NurseNotesGrid";
            this.Size = new System.Drawing.Size(933, 637);
            ((System.ComponentModel.ISupportInitialize)(this.nurseNotesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView nurseNotesDataGridView;
        private System.Windows.Forms.Button updateAllergiesButton;
        private System.Windows.Forms.Button updateNurseNotesButton;
        private System.Windows.Forms.Button addStat;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn bp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr;
    }
}
