namespace Alkamous.View
{
    partial class Frm_UsersLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVUserLOG = new System.Windows.Forms.DataGridView();
            this.BtnDeleteALLUserLOG = new System.Windows.Forms.Button();
            this.txtWhyDelete = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserLOG)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCount
            // 
            this.LbCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCount.ForeColor = System.Drawing.Color.White;
            this.LbCount.Location = new System.Drawing.Point(745, 28);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(140, 41);
            this.LbCount.TabIndex = 7;
            this.LbCount.Text = "0";
            this.LbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(46, 28);
            this.TxtSearch.MaxLength = 40;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(693, 41);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVUserLOG
            // 
            this.DGVUserLOG.AllowUserToAddRows = false;
            this.DGVUserLOG.AllowUserToDeleteRows = false;
            this.DGVUserLOG.AllowUserToOrderColumns = true;
            this.DGVUserLOG.AllowUserToResizeRows = false;
            this.DGVUserLOG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUserLOG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUserLOG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUserLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserLOG.Location = new System.Drawing.Point(46, 82);
            this.DGVUserLOG.MultiSelect = false;
            this.DGVUserLOG.Name = "DGVUserLOG";
            this.DGVUserLOG.ReadOnly = true;
            this.DGVUserLOG.RowTemplate.Height = 26;
            this.DGVUserLOG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUserLOG.Size = new System.Drawing.Size(1058, 605);
            this.DGVUserLOG.TabIndex = 5;
            // 
            // BtnDeleteALLUserLOG
            // 
            this.BtnDeleteALLUserLOG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteALLUserLOG.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeleteALLUserLOG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteALLUserLOG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDeleteALLUserLOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteALLUserLOG.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteALLUserLOG.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteALLUserLOG.Location = new System.Drawing.Point(892, 28);
            this.BtnDeleteALLUserLOG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDeleteALLUserLOG.Name = "BtnDeleteALLUserLOG";
            this.BtnDeleteALLUserLOG.Size = new System.Drawing.Size(212, 41);
            this.BtnDeleteALLUserLOG.TabIndex = 39;
            this.BtnDeleteALLUserLOG.Text = "Delete ALL LOG";
            this.BtnDeleteALLUserLOG.UseVisualStyleBackColor = false;
            this.BtnDeleteALLUserLOG.Click += new System.EventHandler(this.BtnDeleteALLUserLOG_Click);
            // 
            // txtWhyDelete
            // 
            this.txtWhyDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWhyDelete.BackColor = System.Drawing.Color.White;
            this.txtWhyDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhyDelete.ForeColor = System.Drawing.Color.Black;
            this.txtWhyDelete.Location = new System.Drawing.Point(510, 705);
            this.txtWhyDelete.MaxLength = 40;
            this.txtWhyDelete.Name = "txtWhyDelete";
            this.txtWhyDelete.Size = new System.Drawing.Size(594, 32);
            this.txtWhyDelete.TabIndex = 40;
            this.txtWhyDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(144, 705);
            this.txtCode.MaxLength = 40;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(152, 32);
            this.txtCode.TabIndex = 41;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 709);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Add the Reason";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "The Code";
            // 
            // Frm_UsersLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 767);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtWhyDelete);
            this.Controls.Add(this.BtnDeleteALLUserLOG);
            this.Controls.Add(this.LbCount);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVUserLOG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_UsersLog";
            this.Text = "Frm_UsersLog";
            this.Load += new System.EventHandler(this.Frm_UsersLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserLOG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVUserLOG;
        private System.Windows.Forms.Button BtnDeleteALLUserLOG;
        private System.Windows.Forms.TextBox txtWhyDelete;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}