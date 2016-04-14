namespace PIMS
{
    partial class OfficeStaffLeftSideButtons
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
            this.profileInformationButton = new System.Windows.Forms.Button();
            this.insuranceInformationButton = new System.Windows.Forms.Button();
            this.billingInformationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationButton = new System.Windows.Forms.Button();
            this.approvedVisitorsButton = new System.Windows.Forms.Button();
            this.editInsuranceButton = new System.Windows.Forms.Button();
            this.editBillingButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editLocationButton = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.BackColor = System.Drawing.SystemColors.Control;
            groupBox3.Controls.Add(this.exitButton);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox3.Location = new System.Drawing.Point(42, 592);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(211, 61);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Close Application";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(62, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newSearchButton
            // 
            this.newSearchButton.Location = new System.Drawing.Point(69, 29);
            this.newSearchButton.Name = "newSearchButton";
            this.newSearchButton.Size = new System.Drawing.Size(151, 23);
            this.newSearchButton.TabIndex = 7;
            this.newSearchButton.Text = "Search For A New Patient";
            this.newSearchButton.UseVisualStyleBackColor = true;
            this.newSearchButton.Click += new System.EventHandler(this.newSearchButton_Click);
            // 
            // profileInformationButton
            // 
            this.profileInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileInformationButton.Location = new System.Drawing.Point(18, 36);
            this.profileInformationButton.Name = "profileInformationButton";
            this.profileInformationButton.Size = new System.Drawing.Size(173, 23);
            this.profileInformationButton.TabIndex = 6;
            this.profileInformationButton.Text = "Profile";
            this.profileInformationButton.UseVisualStyleBackColor = true;
            this.profileInformationButton.Click += new System.EventHandler(this.profileInformationButton_Click);
            // 
            // insuranceInformationButton
            // 
            this.insuranceInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceInformationButton.Location = new System.Drawing.Point(18, 117);
            this.insuranceInformationButton.Name = "insuranceInformationButton";
            this.insuranceInformationButton.Size = new System.Drawing.Size(173, 23);
            this.insuranceInformationButton.TabIndex = 1;
            this.insuranceInformationButton.Text = "Insurance";
            this.insuranceInformationButton.UseVisualStyleBackColor = true;
            this.insuranceInformationButton.Click += new System.EventHandler(this.insuranceInformationButton_Click);
            // 
            // billingInformationButton
            // 
            this.billingInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingInformationButton.Location = new System.Drawing.Point(18, 77);
            this.billingInformationButton.Name = "billingInformationButton";
            this.billingInformationButton.Size = new System.Drawing.Size(173, 23);
            this.billingInformationButton.TabIndex = 0;
            this.billingInformationButton.Text = "Billing";
            this.billingInformationButton.UseVisualStyleBackColor = true;
            this.billingInformationButton.Click += new System.EventHandler(this.billingInformationButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(69, 74);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(151, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back To Search Results";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationButton);
            this.groupBox1.Controls.Add(this.approvedVisitorsButton);
            this.groupBox1.Controls.Add(this.profileInformationButton);
            this.groupBox1.Controls.Add(this.insuranceInformationButton);
            this.groupBox1.Controls.Add(this.billingInformationButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 239);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // locationButton
            // 
            this.locationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationButton.Location = new System.Drawing.Point(20, 156);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(173, 23);
            this.locationButton.TabIndex = 11;
            this.locationButton.Text = "Location";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // approvedVisitorsButton
            // 
            this.approvedVisitorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedVisitorsButton.Location = new System.Drawing.Point(20, 198);
            this.approvedVisitorsButton.Name = "approvedVisitorsButton";
            this.approvedVisitorsButton.Size = new System.Drawing.Size(173, 23);
            this.approvedVisitorsButton.TabIndex = 10;
            this.approvedVisitorsButton.Text = "Approved Visitors";
            this.approvedVisitorsButton.UseVisualStyleBackColor = true;
            this.approvedVisitorsButton.Click += new System.EventHandler(this.approvedVisitorsButton_Click);
            // 
            // editInsuranceButton
            // 
            this.editInsuranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInsuranceButton.Location = new System.Drawing.Point(16, 107);
            this.editInsuranceButton.Name = "editInsuranceButton";
            this.editInsuranceButton.Size = new System.Drawing.Size(173, 23);
            this.editInsuranceButton.TabIndex = 9;
            this.editInsuranceButton.Text = "Insurance Information";
            this.editInsuranceButton.UseVisualStyleBackColor = true;
            this.editInsuranceButton.Click += new System.EventHandler(this.editInsuranceButton_Click);
            // 
            // editBillingButton
            // 
            this.editBillingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBillingButton.Location = new System.Drawing.Point(16, 67);
            this.editBillingButton.Name = "editBillingButton";
            this.editBillingButton.Size = new System.Drawing.Size(173, 23);
            this.editBillingButton.TabIndex = 8;
            this.editBillingButton.Text = "Billing Information";
            this.editBillingButton.UseVisualStyleBackColor = true;
            this.editBillingButton.Click += new System.EventHandler(this.editBillingButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileButton.Location = new System.Drawing.Point(16, 29);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(173, 23);
            this.editProfileButton.TabIndex = 7;
            this.editProfileButton.Text = "Profile Information";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editLocationButton);
            this.groupBox2.Controls.Add(this.editProfileButton);
            this.groupBox2.Controls.Add(this.editInsuranceButton);
            this.groupBox2.Controls.Add(this.editBillingButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // editLocationButton
            // 
            this.editLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLocationButton.Location = new System.Drawing.Point(16, 148);
            this.editLocationButton.Name = "editLocationButton";
            this.editLocationButton.Size = new System.Drawing.Size(173, 23);
            this.editLocationButton.TabIndex = 10;
            this.editLocationButton.Text = "Location Information";
            this.editLocationButton.UseVisualStyleBackColor = true;
            this.editLocationButton.Click += new System.EventHandler(this.editLocationButton_Click);
            // 
            // OfficeStaffLeftSideButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.newSearchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfficeStaffLeftSideButtons";
            this.Size = new System.Drawing.Size(322, 673);
            groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newSearchButton;
        private System.Windows.Forms.Button profileInformationButton;
        private System.Windows.Forms.Button insuranceInformationButton;
        private System.Windows.Forms.Button billingInformationButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editInsuranceButton;
        private System.Windows.Forms.Button editBillingButton;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button approvedVisitorsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button editLocationButton;
    }
}
