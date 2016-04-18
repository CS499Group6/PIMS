namespace PIMS
{
    partial class ScheduledProcedureForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.perforedByTextBox = new System.Windows.Forms.TextBox();
            this.procdureTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.htLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 109;
            this.dateTimePicker1.Value = new System.DateTime(2016, 4, 17, 14, 53, 11, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(136, 194);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(129, 20);
            this.locationTextBox.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Date:";
            // 
            // perforedByTextBox
            // 
            this.perforedByTextBox.Location = new System.Drawing.Point(137, 156);
            this.perforedByTextBox.Name = "perforedByTextBox";
            this.perforedByTextBox.Size = new System.Drawing.Size(130, 20);
            this.perforedByTextBox.TabIndex = 104;
            // 
            // procdureTextBox
            // 
            this.procdureTextBox.Location = new System.Drawing.Point(136, 121);
            this.procdureTextBox.Name = "procdureTextBox";
            this.procdureTextBox.Size = new System.Drawing.Size(130, 20);
            this.procdureTextBox.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Performed By:";
            // 
            // htLabel
            // 
            this.htLabel.AutoSize = true;
            this.htLabel.Location = new System.Drawing.Point(63, 121);
            this.htLabel.Name = "htLabel";
            this.htLabel.Size = new System.Drawing.Size(59, 13);
            this.htLabel.TabIndex = 99;
            this.htLabel.Text = "Procedure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Time:";
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(127, 236);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(113, 23);
            this.saveUpdateButton.TabIndex = 112;
            this.saveUpdateButton.Text = "Update Procedure";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(127, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 23);
            this.cancelButton.TabIndex = 113;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 114;
            // 
            // ScheduledProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.perforedByTextBox);
            this.Controls.Add(this.procdureTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htLabel);
            this.Name = "ScheduledProcedureForm";
            this.Size = new System.Drawing.Size(554, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox perforedByTextBox;
        private System.Windows.Forms.TextBox procdureTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label htLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
