namespace Alkamous.View
{
    partial class Frm_Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.BtnShowQuotationReport = new System.Windows.Forms.Button();
            this.BtnDeleteRowFromDGVProducts = new System.Windows.Forms.Button();
            this.BtnEditRow = new System.Windows.Forms.Button();
            this.BtnExportAsWordFile = new System.Windows.Forms.Button();
            this.LbWaitSaveFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By invo   product_Name - Company - product_Unit";
            // 
            // LbCount
            // 
            this.LbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCount.ForeColor = System.Drawing.Color.White;
            this.LbCount.Location = new System.Drawing.Point(939, 43);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(140, 41);
            this.LbCount.TabIndex = 8;
            this.LbCount.Text = "0";
            this.LbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(21, 43);
            this.TxtSearch.MaxLength = 40;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(912, 41);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.AllowUserToAddRows = false;
            this.DGVCustomers.AllowUserToDeleteRows = false;
            this.DGVCustomers.AllowUserToOrderColumns = true;
            this.DGVCustomers.AllowUserToResizeRows = false;
            this.DGVCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGVCustomers.Location = new System.Drawing.Point(21, 90);
            this.DGVCustomers.MultiSelect = false;
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.ReadOnly = true;
            this.DGVCustomers.RowTemplate.Height = 26;
            this.DGVCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomers.Size = new System.Drawing.Size(1058, 646);
            this.DGVCustomers.TabIndex = 6;
            this.DGVCustomers.DoubleClick += new System.EventHandler(this.DGVCustomers_DoubleClick);
            // 
            // BtnShowQuotationReport
            // 
            this.BtnShowQuotationReport.BackColor = System.Drawing.Color.Green;
            this.BtnShowQuotationReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowQuotationReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnShowQuotationReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.BtnShowQuotationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowQuotationReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowQuotationReport.ForeColor = System.Drawing.Color.White;
            this.BtnShowQuotationReport.Location = new System.Drawing.Point(555, 752);
            this.BtnShowQuotationReport.Name = "BtnShowQuotationReport";
            this.BtnShowQuotationReport.Size = new System.Drawing.Size(219, 52);
            this.BtnShowQuotationReport.TabIndex = 46;
            this.BtnShowQuotationReport.Text = "Show Report";
            this.BtnShowQuotationReport.UseVisualStyleBackColor = false;
            this.BtnShowQuotationReport.Click += new System.EventHandler(this.BtnShowQuotationReport_Click);
            // 
            // BtnDeleteRowFromDGVProducts
            // 
            this.BtnDeleteRowFromDGVProducts.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeleteRowFromDGVProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteRowFromDGVProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDeleteRowFromDGVProducts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.BtnDeleteRowFromDGVProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteRowFromDGVProducts.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteRowFromDGVProducts.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteRowFromDGVProducts.Location = new System.Drawing.Point(21, 749);
            this.BtnDeleteRowFromDGVProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDeleteRowFromDGVProducts.Name = "BtnDeleteRowFromDGVProducts";
            this.BtnDeleteRowFromDGVProducts.Size = new System.Drawing.Size(283, 52);
            this.BtnDeleteRowFromDGVProducts.TabIndex = 47;
            this.BtnDeleteRowFromDGVProducts.Text = "Delete Row";
            this.BtnDeleteRowFromDGVProducts.UseVisualStyleBackColor = false;
            this.BtnDeleteRowFromDGVProducts.Click += new System.EventHandler(this.BtnDeleteRowFromDGVProducts_Click);
            // 
            // BtnEditRow
            // 
            this.BtnEditRow.BackColor = System.Drawing.Color.Navy;
            this.BtnEditRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditRow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEditRow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.BtnEditRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditRow.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.BtnEditRow.ForeColor = System.Drawing.Color.White;
            this.BtnEditRow.Location = new System.Drawing.Point(793, 751);
            this.BtnEditRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditRow.Name = "BtnEditRow";
            this.BtnEditRow.Size = new System.Drawing.Size(283, 52);
            this.BtnEditRow.TabIndex = 48;
            this.BtnEditRow.Text = "Edit Row";
            this.BtnEditRow.UseVisualStyleBackColor = false;
            this.BtnEditRow.Click += new System.EventHandler(this.BtnEditRow_Click);
            // 
            // BtnExportAsWordFile
            // 
            this.BtnExportAsWordFile.BackColor = System.Drawing.Color.Teal;
            this.BtnExportAsWordFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportAsWordFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportAsWordFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExportAsWordFile.ForeColor = System.Drawing.Color.White;
            this.BtnExportAsWordFile.Location = new System.Drawing.Point(323, 749);
            this.BtnExportAsWordFile.Name = "BtnExportAsWordFile";
            this.BtnExportAsWordFile.Size = new System.Drawing.Size(213, 55);
            this.BtnExportAsWordFile.TabIndex = 49;
            this.BtnExportAsWordFile.Text = "Save As Word";
            this.BtnExportAsWordFile.UseVisualStyleBackColor = false;
            this.BtnExportAsWordFile.Click += new System.EventHandler(this.BtnExportAsWordFile_Click);
            // 
            // LbWaitSaveFile
            // 
            this.LbWaitSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWaitSaveFile.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWaitSaveFile.Location = new System.Drawing.Point(47, 325);
            this.LbWaitSaveFile.Name = "LbWaitSaveFile";
            this.LbWaitSaveFile.Size = new System.Drawing.Size(972, 232);
            this.LbWaitSaveFile.TabIndex = 50;
            this.LbWaitSaveFile.Text = "Please Wait Until the processing Finish ...";
            this.LbWaitSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbWaitSaveFile.Visible = false;
            // 
            // Frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 853);
            this.Controls.Add(this.LbWaitSaveFile);
            this.Controls.Add(this.BtnExportAsWordFile);
            this.Controls.Add(this.BtnEditRow);
            this.Controls.Add(this.BtnDeleteRowFromDGVProducts);
            this.Controls.Add(this.BtnShowQuotationReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbCount);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Customers";
            this.Text = "Frm_Customers";
            this.Load += new System.EventHandler(this.Frm_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.Button BtnShowQuotationReport;
        private System.Windows.Forms.Button BtnDeleteRowFromDGVProducts;
        private System.Windows.Forms.Button BtnEditRow;
        private System.Windows.Forms.Button BtnExportAsWordFile;
        public System.Windows.Forms.Label LbWaitSaveFile;
    }
}