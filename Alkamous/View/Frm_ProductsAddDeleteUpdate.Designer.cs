namespace Alkamous.View
{
    partial class Frm_ProductsAddDeleteUpdate
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
            this.LbCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnEditProduct = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.TxtProductNameAr = new System.Windows.Forms.TextBox();
            this.TxtProductNameEn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.TxtProductUnit = new System.Windows.Forms.TextBox();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_HintAndInfo = new System.Windows.Forms.Button();
            this.BtnCancelEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCount
            // 
            this.LbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCount.ForeColor = System.Drawing.Color.White;
            this.LbCount.Location = new System.Drawing.Point(967, 460);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(117, 41);
            this.LbCount.TabIndex = 7;
            this.LbCount.Text = "0";
            this.LbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbCount.Click += new System.EventHandler(this.LbCount_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(17, 460);
            this.TxtSearch.MaxLength = 40;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(944, 41);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToAddRows = false;
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.AllowUserToOrderColumns = true;
            this.DGVProducts.AllowUserToResizeRows = false;
            this.DGVProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(13, 506);
            this.DGVProducts.MultiSelect = false;
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowTemplate.Height = 26;
            this.DGVProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProducts.Size = new System.Drawing.Size(1071, 317);
            this.DGVProducts.TabIndex = 5;
            this.DGVProducts.DoubleClick += new System.EventHandler(this.DGVProducts_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "product_AR";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.BtnAddProduct.Location = new System.Drawing.Point(143, 398);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(174, 43);
            this.BtnAddProduct.TabIndex = 33;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnEditProduct
            // 
            this.BtnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditProduct.Enabled = false;
            this.BtnEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditProduct.ForeColor = System.Drawing.Color.White;
            this.BtnEditProduct.Location = new System.Drawing.Point(339, 398);
            this.BtnEditProduct.Name = "BtnEditProduct";
            this.BtnEditProduct.Size = new System.Drawing.Size(174, 43);
            this.BtnEditProduct.TabIndex = 34;
            this.BtnEditProduct.Text = "Edit";
            this.BtnEditProduct.UseVisualStyleBackColor = false;
            this.BtnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(535, 398);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(174, 43);
            this.BtnDeleteProduct.TabIndex = 35;
            this.BtnDeleteProduct.Text = "Delete ";
            this.BtnDeleteProduct.UseVisualStyleBackColor = false;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // TxtProductNameAr
            // 
            this.TxtProductNameAr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductNameAr.Location = new System.Drawing.Point(7, 188);
            this.TxtProductNameAr.Multiline = true;
            this.TxtProductNameAr.Name = "TxtProductNameAr";
            this.TxtProductNameAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtProductNameAr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtProductNameAr.Size = new System.Drawing.Size(920, 120);
            this.TxtProductNameAr.TabIndex = 2;
            this.TxtProductNameAr.TextChanged += new System.EventHandler(this.TxtProductNameAr_TextChanged);
            // 
            // TxtProductNameEn
            // 
            this.TxtProductNameEn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductNameEn.Location = new System.Drawing.Point(7, 60);
            this.TxtProductNameEn.Multiline = true;
            this.TxtProductNameEn.Name = "TxtProductNameEn";
            this.TxtProductNameEn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtProductNameEn.Size = new System.Drawing.Size(920, 120);
            this.TxtProductNameEn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "product_Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "product_EN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price USD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtProductId
            // 
            this.TxtProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductId.Location = new System.Drawing.Point(7, 17);
            this.TxtProductId.Margin = new System.Windows.Forms.Padding(10);
            this.TxtProductId.Multiline = true;
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(536, 35);
            this.TxtProductId.TabIndex = 0;
            // 
            // TxtProductUnit
            // 
            this.TxtProductUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductUnit.Location = new System.Drawing.Point(532, 318);
            this.TxtProductUnit.Multiline = true;
            this.TxtProductUnit.Name = "TxtProductUnit";
            this.TxtProductUnit.Size = new System.Drawing.Size(300, 35);
            this.TxtProductUnit.TabIndex = 4;
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductPrice.Location = new System.Drawing.Point(7, 318);
            this.TxtProductPrice.Multiline = true;
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(300, 35);
            this.TxtProductPrice.TabIndex = 3;
            this.TxtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberandDotByKeyPress);
            this.TxtProductPrice.Validated += new System.EventHandler(this.TxtProductPrice_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "product_Id ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Btn_HintAndInfo);
            this.groupBox1.Controls.Add(this.TxtProductId);
            this.groupBox1.Controls.Add(this.TxtProductNameEn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtProductNameAr);
            this.groupBox1.Controls.Add(this.TxtProductPrice);
            this.groupBox1.Controls.Add(this.TxtProductUnit);
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(311, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "$";
            // 
            // Btn_HintAndInfo
            // 
            this.Btn_HintAndInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.Btn_HintAndInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_HintAndInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_HintAndInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_HintAndInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HintAndInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HintAndInfo.ForeColor = System.Drawing.Color.White;
            this.Btn_HintAndInfo.Location = new System.Drawing.Point(609, 19);
            this.Btn_HintAndInfo.Name = "Btn_HintAndInfo";
            this.Btn_HintAndInfo.Size = new System.Drawing.Size(318, 34);
            this.Btn_HintAndInfo.TabIndex = 45;
            this.Btn_HintAndInfo.Text = "Hint and Info";
            this.Btn_HintAndInfo.UseVisualStyleBackColor = false;
            this.Btn_HintAndInfo.Click += new System.EventHandler(this.Btn_HintAndInfo_Click);
            // 
            // BtnCancelEdit
            // 
            this.BtnCancelEdit.BackColor = System.Drawing.Color.Green;
            this.BtnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.BtnCancelEdit.Location = new System.Drawing.Point(535, 398);
            this.BtnCancelEdit.Name = "BtnCancelEdit";
            this.BtnCancelEdit.Size = new System.Drawing.Size(174, 43);
            this.BtnCancelEdit.TabIndex = 45;
            this.BtnCancelEdit.Text = "Cancel Edit";
            this.BtnCancelEdit.UseVisualStyleBackColor = false;
            this.BtnCancelEdit.Visible = false;
            this.BtnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // Frm_ProductsAddDeleteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 853);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.BtnCancelEdit);
            this.Controls.Add(this.BtnEditProduct);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.LbCount);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Frm_ProductsAddDeleteUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ProductsAddDeleteUpdate";
            this.Load += new System.EventHandler(this.Frm_ProductsAddDeleteUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnEditProduct;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.TextBox TxtProductNameAr;
        private System.Windows.Forms.TextBox TxtProductNameEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.TextBox TxtProductUnit;
        private System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelEdit;
        private System.Windows.Forms.Button Btn_HintAndInfo;
        private System.Windows.Forms.Label label5;
    }
}