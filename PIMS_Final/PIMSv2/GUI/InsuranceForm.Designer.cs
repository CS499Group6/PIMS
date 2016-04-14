namespace PIMS
{
    partial class InsuranceForm
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
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.pcnTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.binTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(141, 254);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.saveUpdateButton.TabIndex = 61;
            this.saveUpdateButton.Text = "Update";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(141, 206);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(211, 21);
            this.typeComboBox.TabIndex = 60;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(141, 167);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(211, 20);
            this.groupTextBox.TabIndex = 59;
            // 
            // pcnTextBox
            // 
            this.pcnTextBox.Location = new System.Drawing.Point(141, 134);
            this.pcnTextBox.Name = "pcnTextBox";
            this.pcnTextBox.Size = new System.Drawing.Size(211, 20);
            this.pcnTextBox.TabIndex = 58;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(141, 98);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(211, 20);
            this.idTextBox.TabIndex = 57;
            // 
            // providerTextBox
            // 
            this.providerTextBox.Location = new System.Drawing.Point(141, 36);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(211, 20);
            this.providerTextBox.TabIndex = 56;
            // 
            // binTextBox
            // 
            this.binTextBox.Location = new System.Drawing.Point(141, 66);
            this.binTextBox.Name = "binTextBox";
            this.binTextBox.Size = new System.Drawing.Size(211, 20);
            this.binTextBox.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Insurance Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "PCN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "BIN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Provider:";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(243, 254);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 62;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // NewInsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.pcnTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.providerTextBox);
            this.Controls.Add(this.binTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewInsuranceForm";
            this.Size = new System.Drawing.Size(494, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox pcnTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.TextBox binTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printButton;
    }
}
