namespace PIMS
{
    partial class StartLeftSideButtons
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
            this.newSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOffButton = new System.Windows.Forms.Button();
            closeApplicationGroupBox = new System.Windows.Forms.GroupBox();
            closeApplicationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeApplicationGroupBox
            // 
            closeApplicationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            closeApplicationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            closeApplicationGroupBox.Controls.Add(this.exitButton);
            closeApplicationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closeApplicationGroupBox.Location = new System.Drawing.Point(36, 854);
            closeApplicationGroupBox.Name = "closeApplicationGroupBox";
            closeApplicationGroupBox.Size = new System.Drawing.Size(191, 68);
            closeApplicationGroupBox.TabIndex = 7;
            closeApplicationGroupBox.TabStop = false;
            closeApplicationGroupBox.Text = "Close Application";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(45, 28);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newSearchButton
            // 
            this.newSearchButton.Location = new System.Drawing.Point(36, 73);
            this.newSearchButton.Name = "newSearchButton";
            this.newSearchButton.Size = new System.Drawing.Size(175, 23);
            this.newSearchButton.TabIndex = 6;
            this.newSearchButton.Text = "Search For A New Patient";
            this.newSearchButton.UseVisualStyleBackColor = true;
            this.newSearchButton.Click += new System.EventHandler(this.newSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a patient ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "to view their information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logOffButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 747);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Off";
            // 
            // logOffButton
            // 
            this.logOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffButton.Location = new System.Drawing.Point(45, 29);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(75, 23);
            this.logOffButton.TabIndex = 5;
            this.logOffButton.Text = "Log Off";
            this.logOffButton.UseVisualStyleBackColor = true;
            this.logOffButton.Click += new System.EventHandler(this.logOffButton_Click);
            // 
            // StartLeftSideButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(closeApplicationGroupBox);
            this.Controls.Add(this.newSearchButton);
            this.Name = "StartLeftSideButtons";
            this.Size = new System.Drawing.Size(345, 966);
            closeApplicationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logOffButton;
    }
}
