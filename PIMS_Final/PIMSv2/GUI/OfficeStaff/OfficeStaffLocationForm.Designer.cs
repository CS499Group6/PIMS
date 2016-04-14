namespace PIMS
{
    partial class OfficeStaffLocationForm
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
            this.unitBox = new System.Windows.Forms.TextBox();
            this.bedBox = new System.Windows.Forms.TextBox();
            this.roomBox = new System.Windows.Forms.TextBox();
            this.floorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(124, 127);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(100, 20);
            this.unitBox.TabIndex = 17;
            // 
            // bedBox
            // 
            this.bedBox.Location = new System.Drawing.Point(124, 95);
            this.bedBox.Name = "bedBox";
            this.bedBox.Size = new System.Drawing.Size(100, 20);
            this.bedBox.TabIndex = 16;
            // 
            // roomBox
            // 
            this.roomBox.Location = new System.Drawing.Point(124, 61);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(100, 20);
            this.roomBox.TabIndex = 15;
            // 
            // floorBox
            // 
            this.floorBox.Location = new System.Drawing.Point(124, 29);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(100, 20);
            this.floorBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Floor Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bed Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Room Number:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(124, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.bedBox);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.floorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "LocationForm";
            this.Size = new System.Drawing.Size(388, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.TextBox bedBox;
        private System.Windows.Forms.TextBox roomBox;
        private System.Windows.Forms.TextBox floorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}
