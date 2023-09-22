namespace Alkamous.View
{
    partial class Frm_Terms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVTerms = new System.Windows.Forms.DataGridView();
            this.BtnAddSelect = new System.Windows.Forms.Button();
            this.BtnUnSelectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTerms)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCount
            // 
            this.LbCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCount.ForeColor = System.Drawing.Color.White;
            this.LbCount.Location = new System.Drawing.Point(932, 12);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(139, 41);
            this.LbCount.TabIndex = 8;
            this.LbCount.Text = "0";
            this.LbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbCount.Click += new System.EventHandler(this.LbCount_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(12, 12);
            this.TxtSearch.MaxLength = 40;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(913, 41);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVTerms
            // 
            this.DGVTerms.AllowUserToAddRows = false;
            this.DGVTerms.AllowUserToDeleteRows = false;
            this.DGVTerms.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTerms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTerms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DGVTerms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTerms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTerms.Location = new System.Drawing.Point(12, 59);
            this.DGVTerms.Name = "DGVTerms";
            this.DGVTerms.ReadOnly = true;
            this.DGVTerms.RowTemplate.Height = 26;
            this.DGVTerms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTerms.Size = new System.Drawing.Size(1058, 658);
            this.DGVTerms.TabIndex = 6;
            this.DGVTerms.DoubleClick += new System.EventHandler(this.DGVTerms_DoubleClick);
            // 
            // BtnAddSelect
            // 
            this.BtnAddSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddSelect.BackColor = System.Drawing.Color.Navy;
            this.BtnAddSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAddSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSelect.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSelect.ForeColor = System.Drawing.Color.White;
            this.BtnAddSelect.Location = new System.Drawing.Point(648, 740);
            this.BtnAddSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddSelect.Name = "BtnAddSelect";
            this.BtnAddSelect.Size = new System.Drawing.Size(351, 55);
            this.BtnAddSelect.TabIndex = 42;
            this.BtnAddSelect.Text = "Add Selection";
            this.BtnAddSelect.UseVisualStyleBackColor = false;
            this.BtnAddSelect.Click += new System.EventHandler(this.BtnAddSelect_Click);
            // 
            // BtnUnSelectAll
            // 
            this.BtnUnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUnSelectAll.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnUnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUnSelectAll.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnSelectAll.ForeColor = System.Drawing.Color.White;
            this.BtnUnSelectAll.Location = new System.Drawing.Point(89, 740);
            this.BtnUnSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUnSelectAll.Name = "BtnUnSelectAll";
            this.BtnUnSelectAll.Size = new System.Drawing.Size(352, 55);
            this.BtnUnSelectAll.TabIndex = 41;
            this.BtnUnSelectAll.Text = "Unselect all";
            this.BtnUnSelectAll.UseVisualStyleBackColor = false;
            this.BtnUnSelectAll.Click += new System.EventHandler(this.BtnUnSelectAll_Click);
            // 
            // Frm_Terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 806);
            this.Controls.Add(this.BtnAddSelect);
            this.Controls.Add(this.BtnUnSelectAll);
            this.Controls.Add(this.LbCount);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVTerms);
            this.Name = "Frm_Terms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Terms";
            this.Load += new System.EventHandler(this.Frm_Terms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTerms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVTerms;
        private System.Windows.Forms.Button BtnAddSelect;
        private System.Windows.Forms.Button BtnUnSelectAll;
    }
}