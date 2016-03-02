namespace PIMS
{
    partial class billingGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Charges,
            this.AmountOwed,
            this.InsurancePaid,
            this.DueDate,
            this.AmountPaid});
            this.dataGridView1.Location = new System.Drawing.Point(23, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 20);
            this.textBox1.TabIndex = 45;
            // 
            // queryLabel
            // 
            this.queryLabel.AccessibleDescription = "queryLabel";
            this.queryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(20, 222);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(341, 13);
            this.queryLabel.TabIndex = 44;
            this.queryLabel.Text = "Search for a Patient, Enter a Presscription number or select a Function ";
            // 
            // Charges
            // 
            this.Charges.HeaderText = "Charges";
            this.Charges.Name = "Charges";
            // 
            // AmountOwed
            // 
            this.AmountOwed.HeaderText = "Amount Owed";
            this.AmountOwed.Name = "AmountOwed";
            // 
            // InsurancePaid
            // 
            this.InsurancePaid.HeaderText = "Insurance Paid";
            this.InsurancePaid.Name = "InsurancePaid";
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            // 
            // billingGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 270);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "billingGrid";
            this.Text = "Billing Information";
            this.Load += new System.EventHandler(this.billingGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
    }
}