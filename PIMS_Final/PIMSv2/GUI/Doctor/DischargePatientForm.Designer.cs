namespace PIMS
{
    partial class DischargePatientForm
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
            this.dischargePatient = new System.Windows.Forms.Button();
            this.reasonDischargeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cancelDischargeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dischargePatient
            // 
            this.dischargePatient.Location = new System.Drawing.Point(202, 179);
            this.dischargePatient.Name = "dischargePatient";
            this.dischargePatient.Size = new System.Drawing.Size(108, 23);
            this.dischargePatient.TabIndex = 0;
            this.dischargePatient.Text = "Discharge Patient";
            this.dischargePatient.UseVisualStyleBackColor = true;
            this.dischargePatient.Click += new System.EventHandler(this.dischargePatient_Click);
            // 
            // reasonDischargeTextBox
            // 
            this.reasonDischargeTextBox.Location = new System.Drawing.Point(169, 129);
            this.reasonDischargeTextBox.Name = "reasonDischargeTextBox";
            this.reasonDischargeTextBox.Size = new System.Drawing.Size(200, 20);
            this.reasonDischargeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reason for Discharge:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of Discharge:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time of Discharge:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // cancelDischargeButton
            // 
            this.cancelDischargeButton.Location = new System.Drawing.Point(202, 225);
            this.cancelDischargeButton.Name = "cancelDischargeButton";
            this.cancelDischargeButton.Size = new System.Drawing.Size(108, 23);
            this.cancelDischargeButton.TabIndex = 9;
            this.cancelDischargeButton.Text = "Cancel Discharge";
            this.cancelDischargeButton.UseVisualStyleBackColor = true;
            this.cancelDischargeButton.Click += new System.EventHandler(this.cancelDischargeButton_Click);
            // 
            // DischargePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelDischargeButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonDischargeTextBox);
            this.Controls.Add(this.dischargePatient);
            this.Name = "DischargePatientForm";
            this.Size = new System.Drawing.Size(428, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dischargePatient;
        private System.Windows.Forms.TextBox reasonDischargeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button cancelDischargeButton;
    }
}
