namespace Alkamous.View
{
    partial class Frm_CustomersOptionsForm
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
            this.BtnCustomersUpdateInvoices = new System.Windows.Forms.Button();
            this.BtnCustomersAddNewInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCustomersUpdateInvoices
            // 
            this.BtnCustomersUpdateInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnCustomersUpdateInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomersUpdateInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCustomersUpdateInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCustomersUpdateInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomersUpdateInvoices.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomersUpdateInvoices.ForeColor = System.Drawing.Color.White;
            this.BtnCustomersUpdateInvoices.Location = new System.Drawing.Point(561, 205);
            this.BtnCustomersUpdateInvoices.Name = "BtnCustomersUpdateInvoices";
            this.BtnCustomersUpdateInvoices.Size = new System.Drawing.Size(337, 272);
            this.BtnCustomersUpdateInvoices.TabIndex = 7;
            this.BtnCustomersUpdateInvoices.Text = "Edit - Delete - Report";
            this.BtnCustomersUpdateInvoices.UseVisualStyleBackColor = false;
            this.BtnCustomersUpdateInvoices.Click += new System.EventHandler(this.BtnCustomersUpdateInvoices_Click);
            // 
            // BtnCustomersAddNewInvoices
            // 
            this.BtnCustomersAddNewInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnCustomersAddNewInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomersAddNewInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCustomersAddNewInvoices.FlatAppearance.BorderSize = 0;
            this.BtnCustomersAddNewInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCustomersAddNewInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomersAddNewInvoices.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomersAddNewInvoices.ForeColor = System.Drawing.Color.White;
            this.BtnCustomersAddNewInvoices.Location = new System.Drawing.Point(141, 205);
            this.BtnCustomersAddNewInvoices.Name = "BtnCustomersAddNewInvoices";
            this.BtnCustomersAddNewInvoices.Size = new System.Drawing.Size(337, 272);
            this.BtnCustomersAddNewInvoices.TabIndex = 6;
            this.BtnCustomersAddNewInvoices.Text = "Add New Quotation";
            this.BtnCustomersAddNewInvoices.UseVisualStyleBackColor = false;
            this.BtnCustomersAddNewInvoices.Click += new System.EventHandler(this.BtnCustomersAddNewInvoices_Click);
            // 
            // Frm_CustomersOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 746);
            this.Controls.Add(this.BtnCustomersUpdateInvoices);
            this.Controls.Add(this.BtnCustomersAddNewInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CustomersOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CustomersOptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomersUpdateInvoices;
        private System.Windows.Forms.Button BtnCustomersAddNewInvoices;
    }
}