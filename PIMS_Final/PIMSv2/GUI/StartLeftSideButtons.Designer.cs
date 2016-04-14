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
            closeApplicationGroupBox = new System.Windows.Forms.GroupBox();
            closeApplicationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeApplicationGroupBox
            // 
            closeApplicationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            closeApplicationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            closeApplicationGroupBox.Controls.Add(this.exitButton);
            closeApplicationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closeApplicationGroupBox.Location = new System.Drawing.Point(36, 595);
            closeApplicationGroupBox.Name = "closeApplicationGroupBox";
            closeApplicationGroupBox.Size = new System.Drawing.Size(175, 61);
            closeApplicationGroupBox.TabIndex = 7;
            closeApplicationGroupBox.TabStop = false;
            closeApplicationGroupBox.Text = "Close Application";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(57, 19);
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
            // StartLeftSideButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(closeApplicationGroupBox);
            this.Controls.Add(this.newSearchButton);
            this.Name = "StartLeftSideButtons";
            this.Size = new System.Drawing.Size(345, 700);
            closeApplicationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
