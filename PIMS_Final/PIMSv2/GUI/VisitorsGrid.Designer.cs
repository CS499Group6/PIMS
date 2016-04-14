namespace PIMS
{
    partial class VisitorsGrid
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
            this.vistiors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorDataGridView
            // 
            this.visitorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.visitorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vistiors});
            this.visitorDataGridView.Location = new System.Drawing.Point(16, 12);
            this.visitorDataGridView.Name = "visitorDataGridView";
            this.visitorDataGridView.Size = new System.Drawing.Size(156, 322);
            this.visitorDataGridView.TabIndex = 39;
            // 
            // vistiors
            // 
            this.vistiors.HeaderText = "Approved Vistors";
            this.vistiors.Name = "vistiors";
            this.vistiors.ReadOnly = true;
            this.vistiors.Width = 112;
            // 
            // VisitorsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visitorDataGridView);
            this.Name = "VisitorsGrid";
            this.Size = new System.Drawing.Size(323, 352);
            ((System.ComponentModel.ISupportInitialize)(this.visitorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vistiors;
    }
}
