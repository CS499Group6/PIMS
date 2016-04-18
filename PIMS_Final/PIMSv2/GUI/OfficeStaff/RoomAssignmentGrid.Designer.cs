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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomAssignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomAssignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomAssignmentDataGridView
            // 
            this.roomAssignmentDataGridView.AllowUserToAddRows = false;
            this.roomAssignmentDataGridView.AllowUserToDeleteRows = false;
            this.roomAssignmentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roomAssignmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomAssignmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomAssignmentDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.roomAssignmentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomAssignmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomAssignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomAssignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit,
            this.floor,
            this.roomNumber,
            this.bedNo,
            this.bedsAvailable,
            this.select});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomAssignmentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomAssignmentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.roomAssignmentDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roomAssignmentDataGridView.Location = new System.Drawing.Point(18, 22);
            this.roomAssignmentDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.roomAssignmentDataGridView.MultiSelect = false;
            this.roomAssignmentDataGridView.Name = "roomAssignmentDataGridView";
            this.roomAssignmentDataGridView.RowHeadersVisible = false;
            this.roomAssignmentDataGridView.RowHeadersWidth = 35;
            this.roomAssignmentDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roomAssignmentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roomAssignmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomAssignmentDataGridView.Size = new System.Drawing.Size(713, 485);
            this.roomAssignmentDataGridView.TabIndex = 3;
            this.roomAssignmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomAssignmentDataGridView_CellContentClick);
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.Width = 130;
            // 
            // floor
            // 
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.Width = 130;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Width = 130;
            // 
            // bedNo
            // 
            this.bedNo.HeaderText = "Bed";
            this.bedNo.Name = "bedNo";
            this.bedNo.Width = 130;
            // 
            // bedsAvailable
            // 
            this.bedsAvailable.HeaderText = "Availability";
            this.bedsAvailable.Name = "bedsAvailable";
            this.bedsAvailable.Width = 130;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.select.Text = "Assign";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 45;
            // 
            // RoomAssignmentGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomAssignmentDataGridView);
            this.Name = "RoomAssignmentGrid";
            this.Size = new System.Drawing.Size(751, 526);
            ((System.ComponentModel.ISupportInitialize)(this.roomAssignmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomAssignmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsAvailable;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}
