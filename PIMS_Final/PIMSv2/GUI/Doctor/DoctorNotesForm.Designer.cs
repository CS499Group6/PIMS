namespace PIMS
{
    partial class DoctorNotesForm
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
            this.doctorsNotesTextBox = new System.Windows.Forms.TextBox();
            this.doctorsNotesLabel = new System.Windows.Forms.Label();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.primaryPhysTextBox = new System.Windows.Forms.TextBox();
            this.attendingPhysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reasonAdmittanceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doctorsNotesTextBox
            // 
            this.doctorsNotesTextBox.Location = new System.Drawing.Point(143, 214);
            this.doctorsNotesTextBox.Multiline = true;
            this.doctorsNotesTextBox.Name = "doctorsNotesTextBox";
            this.doctorsNotesTextBox.Size = new System.Drawing.Size(432, 231);
            this.doctorsNotesTextBox.TabIndex = 0;
            // 
            // doctorsNotesLabel
            // 
            this.doctorsNotesLabel.AutoSize = true;
            this.doctorsNotesLabel.Location = new System.Drawing.Point(57, 214);
            this.doctorsNotesLabel.Name = "doctorsNotesLabel";
            this.doctorsNotesLabel.Size = new System.Drawing.Size(80, 13);
            this.doctorsNotesLabel.TabIndex = 1;
            this.doctorsNotesLabel.Text = "Doctor\'s Notes:";
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(422, 509);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(117, 23);
            this.saveUpdateButton.TabIndex = 2;
            this.saveUpdateButton.Text = "Update Notes";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(293, 509);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // primaryPhysTextBox
            // 
            this.primaryPhysTextBox.Location = new System.Drawing.Point(151, 95);
            this.primaryPhysTextBox.Name = "primaryPhysTextBox";
            this.primaryPhysTextBox.Size = new System.Drawing.Size(200, 20);
            this.primaryPhysTextBox.TabIndex = 4;
            // 
            // attendingPhysTextBox
            // 
            this.attendingPhysTextBox.Location = new System.Drawing.Point(151, 50);
            this.attendingPhysTextBox.Name = "attendingPhysTextBox";
            this.attendingPhysTextBox.Size = new System.Drawing.Size(200, 20);
            this.attendingPhysTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primary Care Physician:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attending Physician:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date of Admittance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reason for Admittance:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // reasonAdmittanceTextBox
            // 
            this.reasonAdmittanceTextBox.Location = new System.Drawing.Point(151, 173);
            this.reasonAdmittanceTextBox.Name = "reasonAdmittanceTextBox";
            this.reasonAdmittanceTextBox.Size = new System.Drawing.Size(208, 20);
            this.reasonAdmittanceTextBox.TabIndex = 8;
            // 
            // DoctorNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reasonAdmittanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendingPhysTextBox);
            this.Controls.Add(this.primaryPhysTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.doctorsNotesLabel);
            this.Controls.Add(this.doctorsNotesTextBox);
            this.Name = "DoctorNotesForm";
            this.Size = new System.Drawing.Size(671, 557);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doctorsNotesTextBox;
        private System.Windows.Forms.Label doctorsNotesLabel;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox primaryPhysTextBox;
        private System.Windows.Forms.TextBox attendingPhysTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox reasonAdmittanceTextBox;
    }
}
