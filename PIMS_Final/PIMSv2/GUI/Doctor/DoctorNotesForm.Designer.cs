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
            this.SuspendLayout();
            // 
            // doctorsNotesTextBox
            // 
            this.doctorsNotesTextBox.Location = new System.Drawing.Point(148, 50);
            this.doctorsNotesTextBox.Multiline = true;
            this.doctorsNotesTextBox.Name = "doctorsNotesTextBox";
            this.doctorsNotesTextBox.Size = new System.Drawing.Size(432, 231);
            this.doctorsNotesTextBox.TabIndex = 0;
            // 
            // doctorsNotesLabel
            // 
            this.doctorsNotesLabel.AutoSize = true;
            this.doctorsNotesLabel.Location = new System.Drawing.Point(54, 50);
            this.doctorsNotesLabel.Name = "doctorsNotesLabel";
            this.doctorsNotesLabel.Size = new System.Drawing.Size(80, 13);
            this.doctorsNotesLabel.TabIndex = 1;
            this.doctorsNotesLabel.Text = "Doctor\'s Notes:";
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(419, 308);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(117, 23);
            this.saveUpdateButton.TabIndex = 2;
            this.saveUpdateButton.Text = "Update Notes";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(290, 308);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DoctorNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
