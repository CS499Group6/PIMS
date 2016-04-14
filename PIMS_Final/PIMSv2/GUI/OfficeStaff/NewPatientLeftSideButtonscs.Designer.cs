namespace PIMS
{
    partial class NewPatientLeftSideButtons
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
            System.Windows.Forms.GroupBox groupBox3;
            this.exitButton = new System.Windows.Forms.Button();
            this.newSearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editInsuranceButton = new System.Windows.Forms.Button();
            this.editBillingButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.BackColor = System.Drawing.SystemColors.Control;
            groupBox3.Controls.Add(this.exitButton);
            groupBox3.Location = new System.Drawing.Point(75, 446);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(191, 61);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Close Application";
            // 
            // exitButton
            // 
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
            this.newSearchButton.Location = new System.Drawing.Point(93, 28);
            this.newSearchButton.Name = "newSearchButton";
            this.newSearchButton.Size = new System.Drawing.Size(151, 23);
            this.newSearchButton.TabIndex = 11;
            this.newSearchButton.Text = "Search For A New Patient";
            this.newSearchButton.UseVisualStyleBackColor = true;
            this.newSearchButton.Click += new System.EventHandler(this.newSearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editInsuranceButton);
            this.groupBox1.Controls.Add(this.editBillingButton);
            this.groupBox1.Controls.Add(this.editProfileButton);
            this.groupBox1.Location = new System.Drawing.Point(64, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 209);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // editInsuranceButton
            // 
            this.editInsuranceButton.Location = new System.Drawing.Point(29, 160);
            this.editInsuranceButton.Name = "editInsuranceButton";
            this.editInsuranceButton.Size = new System.Drawing.Size(151, 23);
            this.editInsuranceButton.TabIndex = 9;
            this.editInsuranceButton.Text = "Edit Insurance Information";
            this.editInsuranceButton.UseVisualStyleBackColor = true;
            this.editInsuranceButton.Click += new System.EventHandler(this.editInsuranceButton_Click);
            // 
            // editBillingButton
            // 
            this.editBillingButton.Location = new System.Drawing.Point(29, 101);
            this.editBillingButton.Name = "editBillingButton";
            this.editBillingButton.Size = new System.Drawing.Size(151, 23);
            this.editBillingButton.TabIndex = 8;
            this.editBillingButton.Text = "Edit Billing Information";
            this.editBillingButton.UseVisualStyleBackColor = true;
            this.editBillingButton.Click += new System.EventHandler(this.editBillingButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.Location = new System.Drawing.Point(29, 41);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(151, 23);
            this.editProfileButton.TabIndex = 7;
            this.editProfileButton.Text = "Edit Profile Information";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // NewPatientLeftSideButtonscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.newSearchButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPatientLeftSideButtonscs";
            this.Size = new System.Drawing.Size(341, 534);
            groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newSearchButton;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editInsuranceButton;
        private System.Windows.Forms.Button editBillingButton;
        private System.Windows.Forms.Button editProfileButton;
    }
}
