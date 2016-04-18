namespace PIMS
{
    partial class LoginLeftSideButtons
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
            System.Windows.Forms.GroupBox closeApplicationGroupBox;
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOffButton = new System.Windows.Forms.Button();
            closeApplicationGroupBox = new System.Windows.Forms.GroupBox();
            closeApplicationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeApplicationGroupBox
            // 
            closeApplicationGroupBox.AutoSize = true;
            closeApplicationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            closeApplicationGroupBox.Controls.Add(this.exitButton);
            closeApplicationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closeApplicationGroupBox.Location = new System.Drawing.Point(15, 164);
            closeApplicationGroupBox.Name = "closeApplicationGroupBox";
            closeApplicationGroupBox.Size = new System.Drawing.Size(186, 71);
            closeApplicationGroupBox.TabIndex = 12;
            closeApplicationGroupBox.TabStop = false;
            closeApplicationGroupBox.Text = "Close Application";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(57, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.logOffButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 71);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Off";
            // 
            // logOffButton
            // 
            this.logOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffButton.Location = new System.Drawing.Point(57, 29);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(75, 23);
            this.logOffButton.TabIndex = 5;
            this.logOffButton.Text = "Log Off";
            this.logOffButton.UseVisualStyleBackColor = true;
            this.logOffButton.Click += new System.EventHandler(this.logOffButton_Click);
            // 
            // LoginLeftSideButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(closeApplicationGroupBox);
            this.Name = "LoginLeftSideButtons";
            this.Size = new System.Drawing.Size(214, 314);
            closeApplicationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logOffButton;
        private System.Windows.Forms.Button exitButton;
    }
}
