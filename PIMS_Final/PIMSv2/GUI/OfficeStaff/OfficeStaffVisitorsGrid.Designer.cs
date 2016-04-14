namespace PIMS
{
    partial class OfficeStaffVisitorsGrid
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
            this.visitorDataGridView = new System.Windows.Forms.DataGridView();
            this.selectBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vistiors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addVisitorButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.removeVisitorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorDataGridView
            // 
            this.visitorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.visitorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBox,
            this.vistiors});
            this.visitorDataGridView.Location = new System.Drawing.Point(14, 18);
            this.visitorDataGridView.Name = "visitorDataGridView";
            this.visitorDataGridView.Size = new System.Drawing.Size(293, 281);
            this.visitorDataGridView.TabIndex = 39;
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
            // addVisitorButton
            // 
            this.addVisitorButton.Location = new System.Drawing.Point(341, 76);
            this.addVisitorButton.Name = "addVisitorButton";
            this.addVisitorButton.Size = new System.Drawing.Size(75, 23);
            this.addVisitorButton.TabIndex = 43;
            this.addVisitorButton.Text = "Add visitor";
            this.addVisitorButton.UseVisualStyleBackColor = true;
            this.addVisitorButton.Click += new System.EventHandler(this.addVisitorButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(341, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 42;
            // 
            // removeVisitorButton
            // 
            this.removeVisitorButton.Location = new System.Drawing.Point(14, 320);
            this.removeVisitorButton.Name = "removeVisitorButton";
            this.removeVisitorButton.Size = new System.Drawing.Size(186, 23);
            this.removeVisitorButton.TabIndex = 44;
            this.removeVisitorButton.Text = "Remove selected visitors";
            this.removeVisitorButton.UseVisualStyleBackColor = true;
            this.removeVisitorButton.Click += new System.EventHandler(this.removeVisitorButton_Click);
            // 
            // OfficeStaffVisitorsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeVisitorButton);
            this.Controls.Add(this.addVisitorButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.visitorDataGridView);
            this.Name = "OfficeStaffVisitorsGrid";
            this.Size = new System.Drawing.Size(623, 366);
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visitorDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn vistiors;
        private System.Windows.Forms.Button addVisitorButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button removeVisitorButton;
    }
}
