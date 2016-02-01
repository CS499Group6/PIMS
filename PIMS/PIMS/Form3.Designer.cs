namespace PIMS
{
    partial class patientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.primaryPhoneLabel = new System.Windows.Forms.Label();
            this.secondaryPhoneLabel = new System.Windows.Forms.Label();
            this.contactName2Label = new System.Windows.Forms.Label();
            this.contactName1Label = new System.Windows.Forms.Label();
            this.contactPhone1Label = new System.Windows.Forms.Label();
            this.contactPhone2Label = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.primaryPhoneTextBox = new System.Windows.Forms.TextBox();
            this.secondaryPhoneTextBox = new System.Windows.Forms.TextBox();
            this.contactName1TextBox = new System.Windows.Forms.TextBox();
            this.contactPhone1TextBox = new System.Windows.Forms.TextBox();
            this.contactName2TextBox = new System.Windows.Forms.TextBox();
            this.contactPhone2TextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.queryBar = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(89, 36);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "1. Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(90, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "2. First Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(50, 114);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(112, 13);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "4. DOB (mm/dd/yyyy):";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(78, 88);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(84, 13);
            this.middleNameLabel.TabIndex = 4;
            this.middleNameLabel.Text = "3. Middle Name:";
            this.middleNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(108, 166);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(54, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "5. Adress:";
            this.addressLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(125, 192);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "6. City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(118, 218);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(44, 13);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "7. Sate:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(125, 244);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(37, 13);
            this.zipLabel.TabIndex = 8;
            this.zipLabel.Text = "8. Zip:";
            this.zipLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // primaryPhoneLabel
            // 
            this.primaryPhoneLabel.AutoSize = true;
            this.primaryPhoneLabel.Location = new System.Drawing.Point(72, 270);
            this.primaryPhoneLabel.Name = "primaryPhoneLabel";
            this.primaryPhoneLabel.Size = new System.Drawing.Size(90, 13);
            this.primaryPhoneLabel.TabIndex = 10;
            this.primaryPhoneLabel.Text = "9. Primary Phone:";
            // 
            // secondaryPhoneLabel
            // 
            this.secondaryPhoneLabel.AutoSize = true;
            this.secondaryPhoneLabel.Location = new System.Drawing.Point(49, 296);
            this.secondaryPhoneLabel.Name = "secondaryPhoneLabel";
            this.secondaryPhoneLabel.Size = new System.Drawing.Size(113, 13);
            this.secondaryPhoneLabel.TabIndex = 11;
            this.secondaryPhoneLabel.Text = "10. Secondary Phone:";
            // 
            // contactName2Label
            // 
            this.contactName2Label.AutoSize = true;
            this.contactName2Label.Location = new System.Drawing.Point(54, 374);
            this.contactName2Label.Name = "contactName2Label";
            this.contactName2Label.Size = new System.Drawing.Size(108, 13);
            this.contactName2Label.TabIndex = 12;
            this.contactName2Label.Text = "13. Contact Name(2):";
            // 
            // contactName1Label
            // 
            this.contactName1Label.AutoSize = true;
            this.contactName1Label.Location = new System.Drawing.Point(54, 322);
            this.contactName1Label.Name = "contactName1Label";
            this.contactName1Label.Size = new System.Drawing.Size(108, 13);
            this.contactName1Label.TabIndex = 14;
            this.contactName1Label.Text = "11. Contact Name(1):";
            // 
            // contactPhone1Label
            // 
            this.contactPhone1Label.AutoSize = true;
            this.contactPhone1Label.Location = new System.Drawing.Point(51, 348);
            this.contactPhone1Label.Name = "contactPhone1Label";
            this.contactPhone1Label.Size = new System.Drawing.Size(111, 13);
            this.contactPhone1Label.TabIndex = 15;
            this.contactPhone1Label.Text = "12. Contact Phone(1):";
            // 
            // contactPhone2Label
            // 
            this.contactPhone2Label.AutoSize = true;
            this.contactPhone2Label.Location = new System.Drawing.Point(51, 400);
            this.contactPhone2Label.Name = "contactPhone2Label";
            this.contactPhone2Label.Size = new System.Drawing.Size(111, 13);
            this.contactPhone2Label.TabIndex = 16;
            this.contactPhone2Label.Text = "14. Contact Phone(2):";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AccessibleName = "lastNameBox";
            this.lastNameTextBox.Location = new System.Drawing.Point(171, 36);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 17;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AccessibleName = "firstNameBox";
            this.firstNameTextBox.Location = new System.Drawing.Point(171, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 18;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.AccessibleName = "middleNameBox";
            this.middleNameTextBox.Location = new System.Drawing.Point(171, 88);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 19;
            // 
            // dobTextBox
            // 
            this.dobTextBox.AccessibleName = "dobBox";
            this.dobTextBox.Location = new System.Drawing.Point(171, 114);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobTextBox.TabIndex = 20;
            // 
            // addressTextBox
            // 
            this.addressTextBox.AccessibleName = "addressBox";
            this.addressTextBox.Location = new System.Drawing.Point(170, 166);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 21;
            // 
            // cityTextBox
            // 
            this.cityTextBox.AccessibleName = "cityBox";
            this.cityTextBox.Location = new System.Drawing.Point(170, 192);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 22;
            // 
            // stateTextBox
            // 
            this.stateTextBox.AccessibleName = "stateBox";
            this.stateTextBox.Location = new System.Drawing.Point(171, 218);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 23;
            // 
            // zipTextBox
            // 
            this.zipTextBox.AccessibleName = "zipBox";
            this.zipTextBox.Location = new System.Drawing.Point(171, 244);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 24;
            this.zipTextBox.TextChanged += new System.EventHandler(this.zipBox_TextChanged);
            // 
            // primaryPhoneTextBox
            // 
            this.primaryPhoneTextBox.AccessibleName = "primaryPhoneBox";
            this.primaryPhoneTextBox.Location = new System.Drawing.Point(171, 270);
            this.primaryPhoneTextBox.Name = "primaryPhoneTextBox";
            this.primaryPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryPhoneTextBox.TabIndex = 25;
            // 
            // secondaryPhoneTextBox
            // 
            this.secondaryPhoneTextBox.AccessibleName = "secondaryPhoneBox";
            this.secondaryPhoneTextBox.Location = new System.Drawing.Point(171, 296);
            this.secondaryPhoneTextBox.Name = "secondaryPhoneTextBox";
            this.secondaryPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryPhoneTextBox.TabIndex = 26;
            // 
            // contactName1TextBox
            // 
            this.contactName1TextBox.AccessibleName = "contactName1";
            this.contactName1TextBox.Location = new System.Drawing.Point(171, 322);
            this.contactName1TextBox.Name = "contactName1TextBox";
            this.contactName1TextBox.Size = new System.Drawing.Size(100, 20);
            this.contactName1TextBox.TabIndex = 27;
            // 
            // contactPhone1TextBox
            // 
            this.contactPhone1TextBox.AccessibleName = "contactPhone1";
            this.contactPhone1TextBox.Location = new System.Drawing.Point(171, 348);
            this.contactPhone1TextBox.Name = "contactPhone1TextBox";
            this.contactPhone1TextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPhone1TextBox.TabIndex = 28;
            // 
            // contactName2TextBox
            // 
            this.contactName2TextBox.Location = new System.Drawing.Point(171, 374);
            this.contactName2TextBox.Name = "contactName2TextBox";
            this.contactName2TextBox.Size = new System.Drawing.Size(100, 20);
            this.contactName2TextBox.TabIndex = 29;
            // 
            // contactPhone2TextBox
            // 
            this.contactPhone2TextBox.Location = new System.Drawing.Point(171, 400);
            this.contactPhone2TextBox.Name = "contactPhone2TextBox";
            this.contactPhone2TextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPhone2TextBox.TabIndex = 30;
            // 
            // genderTextBox
            // 
            this.genderTextBox.AccessibleName = "genderBox";
            this.genderTextBox.Location = new System.Drawing.Point(171, 140);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(23, 20);
            this.genderTextBox.TabIndex = 31;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(105, 140);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(57, 13);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "5. Gender:";
            // 
            // queryBar
            // 
            this.queryBar.AccessibleName = "queryBar";
            this.queryBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryBar.Location = new System.Drawing.Point(181, 452);
            this.queryBar.Name = "queryBar";
            this.queryBar.Size = new System.Drawing.Size(345, 20);
            this.queryBar.TabIndex = 33;
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(178, 436);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(336, 13);
            this.queryLabel.TabIndex = 34;
            this.queryLabel.Text = "Search for a Patient, Enter a Perscription number or select a Function ";
            // 
            // patientForm
            // 
            this.AccessibleName = "patientForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 498);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.queryBar);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.contactPhone2TextBox);
            this.Controls.Add(this.contactName2TextBox);
            this.Controls.Add(this.contactPhone1TextBox);
            this.Controls.Add(this.contactName1TextBox);
            this.Controls.Add(this.secondaryPhoneTextBox);
            this.Controls.Add(this.primaryPhoneTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.contactPhone2Label);
            this.Controls.Add(this.contactPhone1Label);
            this.Controls.Add(this.contactName1Label);
            this.Controls.Add(this.contactName2Label);
            this.Controls.Add(this.secondaryPhoneLabel);
            this.Controls.Add(this.primaryPhoneLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "patientForm";
            this.Text = "PIMS";
            this.Load += new System.EventHandler(this.patientForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label primaryPhoneLabel;
        private System.Windows.Forms.Label secondaryPhoneLabel;
        private System.Windows.Forms.Label contactName2Label;
        private System.Windows.Forms.Label contactName1Label;
        private System.Windows.Forms.Label contactPhone1Label;
        private System.Windows.Forms.Label contactPhone2Label;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox primaryPhoneTextBox;
        private System.Windows.Forms.TextBox secondaryPhoneTextBox;
        private System.Windows.Forms.TextBox contactName1TextBox;
        private System.Windows.Forms.TextBox contactPhone1TextBox;
        private System.Windows.Forms.TextBox contactName2TextBox;
        private System.Windows.Forms.TextBox contactPhone2TextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox queryBar;
        private System.Windows.Forms.Label queryLabel;
    }
}