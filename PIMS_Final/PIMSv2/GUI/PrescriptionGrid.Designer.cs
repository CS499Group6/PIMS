namespace PIMS
{
    partial class PrescriptionGrid
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
            this.prescriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribingPhysician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPrescriptionButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptionDataGridView
            // 
            this.prescriptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.drug,
            this.ndc,
            this.cost,
            this.prescribedDate,
            this.prescribingPhysician});
            this.prescriptionDataGridView.Location = new System.Drawing.Point(19, 27);
            this.prescriptionDataGridView.Name = "prescriptionDataGridView";
            this.prescriptionDataGridView.Size = new System.Drawing.Size(969, 352);
            this.prescriptionDataGridView.TabIndex = 1;
            this.prescriptionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptionDataGridView_CellContentClick);
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
            this.id.HeaderText = "ID Number";
            this.id.Name = "id";
            // 
            // drug
            // 
            this.drug.HeaderText = "Drug";
            this.drug.Name = "drug";
            // 
            // ndc
            // 
            this.ndc.HeaderText = "NDC";
            this.ndc.Name = "ndc";
            // 
            // cost
            // 
            this.cost.HeaderText = "Price";
            this.cost.Name = "cost";
            // 
            // prescribedDate
            // 
            this.prescribedDate.HeaderText = "Prescribed Date";
            this.prescribedDate.Name = "prescribedDate";
            // 
            // prescribingPhysician
            // 
            this.prescribingPhysician.HeaderText = "Prescribing Physician";
            this.prescribingPhysician.Name = "prescribingPhysician";
            // 
            // addPrescriptionButton
            // 
            this.addPrescriptionButton.Location = new System.Drawing.Point(656, 410);
            this.addPrescriptionButton.Name = "addPrescriptionButton";
            this.addPrescriptionButton.Size = new System.Drawing.Size(116, 23);
            this.addPrescriptionButton.TabIndex = 2;
            this.addPrescriptionButton.Text = "Add Prescription";
            this.addPrescriptionButton.UseVisualStyleBackColor = true;
            this.addPrescriptionButton.Click += new System.EventHandler(this.addPrescriptionButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(821, 410);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(137, 23);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print All Prescriptions";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // PrescriptionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.addPrescriptionButton);
            this.Controls.Add(this.prescriptionDataGridView);
            this.Name = "PrescriptionGrid";
            this.Size = new System.Drawing.Size(1018, 480);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prescriptionDataGridView;
        private System.Windows.Forms.Button addPrescriptionButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribingPhysician;
        private System.Windows.Forms.Button printButton;
    }
}
