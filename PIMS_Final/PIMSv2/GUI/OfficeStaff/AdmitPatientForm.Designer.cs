namespace PIMS
{
    partial class AdmitPatientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reasonAdmittanceTextBox = new System.Windows.Forms.TextBox();
            this.admitPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of Admittance:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reason for Admittance:";
            // 
            // reasonAdmittanceTextBox
            // 
            this.reasonAdmittanceTextBox.Location = new System.Drawing.Point(182, 177);
            this.reasonAdmittanceTextBox.Name = "reasonAdmittanceTextBox";
            this.reasonAdmittanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.reasonAdmittanceTextBox.TabIndex = 10;
            // 
            // admitPatient
            // 
            this.admitPatient.Location = new System.Drawing.Point(240, 231);
            this.admitPatient.Name = "admitPatient";
            this.admitPatient.Size = new System.Drawing.Size(108, 23);
            this.admitPatient.TabIndex = 9;
            this.admitPatient.Text = "Admit Patient";
            this.admitPatient.UseVisualStyleBackColor = true;
            this.admitPatient.Click += new System.EventHandler(this.admitPatient_Click);
            // 
            // AdmitPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonAdmittanceTextBox);
            this.Controls.Add(this.admitPatient);
            this.Name = "AdmitPatientForm";
            this.Size = new System.Drawing.Size(486, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reasonAdmittanceTextBox;
        private System.Windows.Forms.Button admitPatient;
    }
}
