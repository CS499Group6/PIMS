namespace PIMS
{
    partial class PrescriptionForm
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
            this.printButon = new System.Windows.Forms.Button();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.physicianTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ndcTextBox = new System.Windows.Forms.TextBox();
            this.drugTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sigTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printButon
            // 
            this.printButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButon.Location = new System.Drawing.Point(711, 527);
            this.printButon.Name = "printButon";
            this.printButon.Size = new System.Drawing.Size(75, 23);
            this.printButon.TabIndex = 2;
            this.printButon.Text = "Print";
            this.printButon.UseVisualStyleBackColor = true;
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(232, 382);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(132, 23);
            this.saveUpdateButton.TabIndex = 67;
            this.saveUpdateButton.Text = "Update Prescription";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(231, 342);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(171, 20);
            this.dateTextBox.TabIndex = 66;
            // 
            // physicianTextBox
            // 
            this.physicianTextBox.Location = new System.Drawing.Point(231, 299);
            this.physicianTextBox.Name = "physicianTextBox";
            this.physicianTextBox.Size = new System.Drawing.Size(171, 20);
            this.physicianTextBox.TabIndex = 65;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 569);
            this.splitter1.TabIndex = 63;
            this.splitter1.TabStop = false;
            // 
            // ndcTextBox
            // 
            this.ndcTextBox.Location = new System.Drawing.Point(230, 110);
            this.ndcTextBox.Name = "ndcTextBox";
            this.ndcTextBox.Size = new System.Drawing.Size(172, 20);
            this.ndcTextBox.TabIndex = 62;
            // 
            // drugTextBox
            // 
            this.drugTextBox.Location = new System.Drawing.Point(230, 75);
            this.drugTextBox.Name = "drugTextBox";
            this.drugTextBox.Size = new System.Drawing.Size(172, 20);
            this.drugTextBox.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Prescribing Physician:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Prescribed Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "SIG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "NDC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Drug:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "mm/dd/yyyy";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(230, 258);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(172, 20);
            this.priceTextBox.TabIndex = 72;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(191, 258);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 71;
            this.priceLabel.Text = "Price:";
            // 
            // sigTextBox
            // 
            this.sigTextBox.Location = new System.Drawing.Point(232, 146);
            this.sigTextBox.Multiline = true;
            this.sigTextBox.Name = "sigTextBox";
            this.sigTextBox.Size = new System.Drawing.Size(170, 94);
            this.sigTextBox.TabIndex = 73;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sigTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.physicianTextBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ndcTextBox);
            this.Controls.Add(this.drugTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButon);
            this.Name = "PrescriptionForm";
            this.Size = new System.Drawing.Size(803, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButon;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox physicianTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox ndcTextBox;
        private System.Windows.Forms.TextBox drugTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox sigTextBox;
    }
}
