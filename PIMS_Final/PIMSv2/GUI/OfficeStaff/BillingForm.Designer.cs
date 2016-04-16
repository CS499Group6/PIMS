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
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.itemNameBox = new System.Windows.Forms.Label();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dueTextBox = new System.Windows.Forms.TextBox();
            this.insPaidTextBox = new System.Windows.Forms.TextBox();
            this.paidTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printButon
            // 
            this.printButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButon.Location = new System.Drawing.Point(266, 218);
            this.printButon.Name = "printButon";
            this.printButon.Size = new System.Drawing.Size(75, 23);
            this.printButon.TabIndex = 1;
            this.printButon.Text = "Print";
            this.printButon.UseVisualStyleBackColor = true;
            this.printButon.Click += new System.EventHandler(this.printButon_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(203, 72);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 59;
            // 
            // itemNameBox
            // 
            this.itemNameBox.AutoSize = true;
            this.itemNameBox.Location = new System.Drawing.Point(124, 75);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(61, 13);
            this.itemNameBox.TabIndex = 58;
            this.itemNameBox.Text = "Item Name:";
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(107, 218);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(138, 23);
            this.saveUpdateButton.TabIndex = 57;
            this.saveUpdateButton.Text = "Update Billing Line Item";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Insurance Paid:";
            // 
            // dueTextBox
            // 
            this.dueTextBox.Location = new System.Drawing.Point(203, 178);
            this.dueTextBox.Name = "dueTextBox";
            this.dueTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueTextBox.TabIndex = 54;
            // 
            // insPaidTextBox
            // 
            this.insPaidTextBox.Location = new System.Drawing.Point(203, 124);
            this.insPaidTextBox.Name = "insPaidTextBox";
            this.insPaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.insPaidTextBox.TabIndex = 53;
            // 
            // paidTextBox
            // 
            this.paidTextBox.Location = new System.Drawing.Point(203, 152);
            this.paidTextBox.Name = "paidTextBox";
            this.paidTextBox.Size = new System.Drawing.Size(100, 20);
            this.paidTextBox.TabIndex = 52;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(203, 98);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Amount Paid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Charges:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(203, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 61;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(124, 49);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(61, 13);
            this.idLabel.TabIndex = 60;
            this.idLabel.Text = "ID Number:";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dueTextBox);
            this.Controls.Add(this.insPaidTextBox);
            this.Controls.Add(this.paidTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButon);
            this.Name = "BillingForm";
            this.Size = new System.Drawing.Size(610, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printButon;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label itemNameBox;
        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dueTextBox;
        private System.Windows.Forms.TextBox insPaidTextBox;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}
