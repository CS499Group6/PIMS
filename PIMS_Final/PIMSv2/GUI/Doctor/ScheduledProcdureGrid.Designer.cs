namespace PIMS
{
    partial class ScheduledProcdureGrid
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
            this.procedureDataGridView = new System.Windows.Forms.DataGridView();
            this.addProcedureButton = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.where = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // procedureDataGridView
            // 
            this.procedureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.procedureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procedureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.procedure,
            this.date,
            this.time,
            this.who,
            this.where});
            this.procedureDataGridView.Location = new System.Drawing.Point(31, 49);
            this.procedureDataGridView.Name = "procedureDataGridView";
            this.procedureDataGridView.Size = new System.Drawing.Size(827, 367);
            this.procedureDataGridView.TabIndex = 3;
            this.procedureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.procedureDataGridView_CellContentClick);
            // 
            // addProcedureButton
            // 
            this.addProcedureButton.Location = new System.Drawing.Point(551, 486);
            this.addProcedureButton.Name = "addProcedureButton";
            this.addProcedureButton.Size = new System.Drawing.Size(134, 23);
            this.addProcedureButton.TabIndex = 4;
            this.addProcedureButton.Text = "Add Procedure Button";
            this.addProcedureButton.UseVisualStyleBackColor = true;
            this.addProcedureButton.Click += new System.EventHandler(this.addProcedureButton_Click);
            // 
            // select
            // 
            this.select.FalseValue = "false";
            this.select.HeaderText = "Select";
            this.select.IndeterminateValue = "false";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.TrueValue = "true";
            // 
            // id
            // 
            this.id.HeaderText = "ID Number";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // procedure
            // 
            this.procedure.HeaderText = "Procedure";
            this.procedure.Name = "procedure";
            this.procedure.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
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
            // ScheduledProcdureGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addProcedureButton);
            this.Controls.Add(this.procedureDataGridView);
            this.Name = "ScheduledProcdureGrid";
            this.Size = new System.Drawing.Size(893, 624);
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView procedureDataGridView;
        private System.Windows.Forms.Button addProcedureButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn who;
        private System.Windows.Forms.DataGridViewTextBoxColumn where;
    }
}
