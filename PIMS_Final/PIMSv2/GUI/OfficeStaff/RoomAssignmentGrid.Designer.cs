namespace PIMS
{
    partial class RoomAssignmentGrid
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
            this.roomAssignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bedsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomAssignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomAssignmentDataGridView
            // 
            this.roomAssignmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomAssignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomAssignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bedsAvailable,
            this.roomNumber,
            this.unit,
            this.facility});
            this.roomAssignmentDataGridView.Location = new System.Drawing.Point(18, 22);
            this.roomAssignmentDataGridView.Name = "roomAssignmentDataGridView";
            this.roomAssignmentDataGridView.RowHeadersWidth = 35;
            this.roomAssignmentDataGridView.Size = new System.Drawing.Size(537, 362);
            this.roomAssignmentDataGridView.TabIndex = 3;
            this.roomAssignmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomAssignmentDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Select";
            this.Column1.IndeterminateValue = "false";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // bedsAvailable
            // 
            this.bedsAvailable.HeaderText = "Number of Beds Available";
            this.bedsAvailable.Name = "bedsAvailable";
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.Name = "roomNumber";
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            // 
            // facility
            // 
            this.facility.HeaderText = "Facility";
            this.facility.Name = "facility";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(417, 413);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(138, 23);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign Room to Patient";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // RoomAssignmentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.roomAssignmentDataGridView);
            this.Name = "RoomAssignmentGrid";
            this.Size = new System.Drawing.Size(735, 526);
            ((System.ComponentModel.ISupportInitialize)(this.roomAssignmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomAssignmentDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn facility;
        private System.Windows.Forms.Button assignButton;
    }
}
