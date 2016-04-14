namespace PIMS
{
    partial class BillingForm
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
            this.itemBox = new System.Windows.Forms.TextBox();
            this.itemNameBox = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dueBox = new System.Windows.Forms.TextBox();
            this.insPaidBox = new System.Windows.Forms.TextBox();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printButon
            // 
            this.printButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButon.Location = new System.Drawing.Point(196, 172);
            this.printButon.Name = "printButon";
            this.printButon.Size = new System.Drawing.Size(75, 23);
            this.printButon.TabIndex = 1;
            this.printButon.Text = "Print";
            this.printButon.UseVisualStyleBackColor = true;
            this.printButon.Click += new System.EventHandler(this.printButon_Click);
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(124, 24);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(100, 20);
            this.itemBox.TabIndex = 59;
            // 
            // itemNameBox
            // 
            this.itemNameBox.AutoSize = true;
            this.itemNameBox.Location = new System.Drawing.Point(25, 27);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(61, 13);
            this.itemNameBox.TabIndex = 58;
            this.itemNameBox.Text = "Item Name:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(102, 172);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 57;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Insurance Paid:";
            // 
            // dueBox
            // 
            this.dueBox.Location = new System.Drawing.Point(124, 130);
            this.dueBox.Name = "dueBox";
            this.dueBox.Size = new System.Drawing.Size(100, 20);
            this.dueBox.TabIndex = 54;
            // 
            // insPaidBox
            // 
            this.insPaidBox.Location = new System.Drawing.Point(124, 76);
            this.insPaidBox.Name = "insPaidBox";
            this.insPaidBox.Size = new System.Drawing.Size(100, 20);
            this.insPaidBox.TabIndex = 53;
            // 
            // paidBox
            // 
            this.paidBox.Location = new System.Drawing.Point(124, 104);
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(100, 20);
            this.paidBox.TabIndex = 52;
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(124, 50);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(100, 20);
            this.costBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Amount Paid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Charges:";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dueBox);
            this.Controls.Add(this.insPaidBox);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButon);
            this.Name = "BillingForm";
            this.Size = new System.Drawing.Size(495, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printButon;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Label itemNameBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dueBox;
        private System.Windows.Forms.TextBox insPaidBox;
        private System.Windows.Forms.TextBox paidBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
