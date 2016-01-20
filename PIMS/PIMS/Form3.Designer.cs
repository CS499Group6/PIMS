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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.primaryPhoneBox = new System.Windows.Forms.TextBox();
            this.secondaryPhoneBox = new System.Windows.Forms.TextBox();
            this.contactName1 = new System.Windows.Forms.TextBox();
            this.contactPhone1 = new System.Windows.Forms.TextBox();
            this.contactName2 = new System.Windows.Forms.TextBox();
            this.contactPhone2 = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Last Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "4. DOB (mm/dd/yyyy):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3. Middle Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "5. Adress:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "6. City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "7. Sate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "8. Zip:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "9. Primary Phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "10. Secondary Phone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "13. Contact Name(2):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "11. Contact Name(1):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "12. Contact Phone(1):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "14. Contact Phone(2):";
            // 
            // lastNameBox
            // 
            this.lastNameBox.AccessibleName = "lastNameBox";
            this.lastNameBox.Location = new System.Drawing.Point(171, 36);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 17;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // firstNameBox
            // 
            this.firstNameBox.AccessibleName = "firstNameBox";
            this.firstNameBox.Location = new System.Drawing.Point(171, 62);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 18;
            // 
            // middleNameBox
            // 
            this.middleNameBox.AccessibleName = "middleNameBox";
            this.middleNameBox.Location = new System.Drawing.Point(171, 88);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameBox.TabIndex = 19;
            // 
            // dobBox
            // 
            this.dobBox.AccessibleName = "dobBox";
            this.dobBox.Location = new System.Drawing.Point(171, 114);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(100, 20);
            this.dobBox.TabIndex = 20;
            // 
            // addressBox
            // 
            this.addressBox.AccessibleName = "addressBox";
            this.addressBox.Location = new System.Drawing.Point(170, 166);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 21;
            // 
            // cityBox
            // 
            this.cityBox.AccessibleName = "cityBox";
            this.cityBox.Location = new System.Drawing.Point(170, 192);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 22;
            // 
            // stateBox
            // 
            this.stateBox.AccessibleName = "stateBox";
            this.stateBox.Location = new System.Drawing.Point(171, 218);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 20);
            this.stateBox.TabIndex = 23;
            // 
            // zipBox
            // 
            this.zipBox.AccessibleName = "zipBox";
            this.zipBox.Location = new System.Drawing.Point(171, 244);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 20);
            this.zipBox.TabIndex = 24;
            this.zipBox.TextChanged += new System.EventHandler(this.zipBox_TextChanged);
            // 
            // primaryPhoneBox
            // 
            this.primaryPhoneBox.AccessibleName = "primaryPhoneBox";
            this.primaryPhoneBox.Location = new System.Drawing.Point(171, 270);
            this.primaryPhoneBox.Name = "primaryPhoneBox";
            this.primaryPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.primaryPhoneBox.TabIndex = 25;
            // 
            // secondaryPhoneBox
            // 
            this.secondaryPhoneBox.AccessibleName = "secondaryPhoneBox";
            this.secondaryPhoneBox.Location = new System.Drawing.Point(171, 296);
            this.secondaryPhoneBox.Name = "secondaryPhoneBox";
            this.secondaryPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryPhoneBox.TabIndex = 26;
            // 
            // contactName1
            // 
            this.contactName1.AccessibleName = "contactName1";
            this.contactName1.Location = new System.Drawing.Point(171, 322);
            this.contactName1.Name = "contactName1";
            this.contactName1.Size = new System.Drawing.Size(100, 20);
            this.contactName1.TabIndex = 27;
            // 
            // contactPhone1
            // 
            this.contactPhone1.AccessibleName = "contactPhone1";
            this.contactPhone1.Location = new System.Drawing.Point(171, 348);
            this.contactPhone1.Name = "contactPhone1";
            this.contactPhone1.Size = new System.Drawing.Size(100, 20);
            this.contactPhone1.TabIndex = 28;
            // 
            // contactName2
            // 
            this.contactName2.Location = new System.Drawing.Point(171, 374);
            this.contactName2.Name = "contactName2";
            this.contactName2.Size = new System.Drawing.Size(100, 20);
            this.contactName2.TabIndex = 29;
            // 
            // contactPhone2
            // 
            this.contactPhone2.Location = new System.Drawing.Point(171, 400);
            this.contactPhone2.Name = "contactPhone2";
            this.contactPhone2.Size = new System.Drawing.Size(100, 20);
            this.contactPhone2.TabIndex = 30;
            // 
            // genderBox
            // 
            this.genderBox.AccessibleName = "genderBox";
            this.genderBox.Location = new System.Drawing.Point(171, 140);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(23, 20);
            this.genderBox.TabIndex = 31;
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
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.contactPhone2);
            this.Controls.Add(this.contactName2);
            this.Controls.Add(this.contactPhone1);
            this.Controls.Add(this.contactName1);
            this.Controls.Add(this.secondaryPhoneBox);
            this.Controls.Add(this.primaryPhoneBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "patientForm";
            this.Text = "PIMS";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox dobBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox primaryPhoneBox;
        private System.Windows.Forms.TextBox secondaryPhoneBox;
        private System.Windows.Forms.TextBox contactName1;
        private System.Windows.Forms.TextBox contactPhone1;
        private System.Windows.Forms.TextBox contactName2;
        private System.Windows.Forms.TextBox contactPhone2;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox queryBar;
        private System.Windows.Forms.Label queryLabel;
    }
}