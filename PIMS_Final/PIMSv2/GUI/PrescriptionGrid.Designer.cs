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
            this.addCurrentPrescriptionButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.addNewPrescriptionButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ndc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribingPhysician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptionDataGridView
            // 
            this.prescriptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ndc,
            this.drug,
            this.sig,
            this.cost,
            this.prescribedDate,
            this.prescribingPhysician});
            this.prescriptionDataGridView.Location = new System.Drawing.Point(19, 27);
            this.prescriptionDataGridView.Name = "prescriptionDataGridView";
            this.prescriptionDataGridView.Size = new System.Drawing.Size(1092, 352);
            this.prescriptionDataGridView.TabIndex = 1;
            this.prescriptionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptionDataGridView_CellContentClick);
            // 
            // addCurrentPrescriptionButton
            // 
            this.addCurrentPrescriptionButton.Location = new System.Drawing.Point(600, 410);
            this.addCurrentPrescriptionButton.Name = "addCurrentPrescriptionButton";
            this.addCurrentPrescriptionButton.Size = new System.Drawing.Size(172, 23);
            this.addCurrentPrescriptionButton.TabIndex = 2;
            this.addCurrentPrescriptionButton.Text = "Add Current Prescription";
            this.addCurrentPrescriptionButton.UseVisualStyleBackColor = true;
            this.addCurrentPrescriptionButton.Click += new System.EventHandler(this.addCurrentPrescriptionButton_Click);
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
            // addNewPrescriptionButton
            // 
            this.addNewPrescriptionButton.Location = new System.Drawing.Point(600, 454);
            this.addNewPrescriptionButton.Name = "addNewPrescriptionButton";
            this.addNewPrescriptionButton.Size = new System.Drawing.Size(172, 23);
            this.addNewPrescriptionButton.TabIndex = 4;
            this.addNewPrescriptionButton.Text = "Add New Prescription";
            this.addNewPrescriptionButton.UseVisualStyleBackColor = true;
            this.addNewPrescriptionButton.Click += new System.EventHandler(this.addNewPrescriptionButton_Click);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Select";
            this.Column1.IndeterminateValue = "false";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // ndc
            // 
            this.ndc.HeaderText = "NDC";
            this.ndc.Name = "ndc";
            // 
            // drug
            // 
            this.drug.HeaderText = "Drug";
            this.drug.Name = "drug";
            // 
            // sig
            // 
            this.sig.HeaderText = "SIG";
            this.sig.Name = "sig";
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
            // PrescriptionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addNewPrescriptionButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.addCurrentPrescriptionButton);
            this.Controls.Add(this.prescriptionDataGridView);
            this.Name = "PrescriptionGrid";
            this.Size = new System.Drawing.Size(1129, 516);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prescriptionDataGridView;
        private System.Windows.Forms.Button addCurrentPrescriptionButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button addNewPrescriptionButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndc;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug;
        private System.Windows.Forms.DataGridViewTextBoxColumn sig;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribingPhysician;
    }
}
