﻿namespace PIMS
{
    partial class OfficeStaffBillingGrid
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
            this.billingDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.Item,
            this.DueDate,
            this.Charges,
            this.InsurancePaid,
            this.AmountPaid,
            this.AmountOwed});
            this.billingDataGridView.Location = new System.Drawing.Point(13, 20);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.RowHeadersWidth = 35;
            this.billingDataGridView.Size = new System.Drawing.Size(837, 320);
            this.billingDataGridView.TabIndex = 2;
            this.billingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingGridDataView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Select";
            this.Column1.IndeterminateValue = "false";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // id
            // 
            this.id.HeaderText = "Id Number";
            this.id.Name = "id";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            // 
            // Charges
            // 
            this.Charges.HeaderText = "Charges";
            this.Charges.Name = "Charges";
            // 
            // InsurancePaid
            // 
            this.InsurancePaid.HeaderText = "Insurance Paid";
            this.InsurancePaid.Name = "InsurancePaid";
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.Name = "AmountPaid";
            // 
            // AmountOwed
            // 
            this.AmountOwed.HeaderText = "Amount Owed";
            this.AmountOwed.Name = "AmountOwed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.print_click);
            // 
            // OfficeStaffBillingGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.billingDataGridView);
            this.Name = "OfficeStaffBillingGrid";
            this.Size = new System.Drawing.Size(875, 573);
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
        private System.Windows.Forms.Button button1;
    }
}