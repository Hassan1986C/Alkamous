namespace Alkamous.View
{
    partial class Frm_BanksAccountAddUpdateDelete
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
            this.groupBoxAcount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBank_Definition = new System.Windows.Forms.TextBox();
            this.TxtCurrency = new System.Windows.Forms.ComboBox();
            this.TxtSwift_Code = new System.Windows.Forms.TextBox();
            this.TxtCOUNTRY = new System.Windows.Forms.TextBox();
            this.TxtIBAN_Number = new System.Windows.Forms.TextBox();
            this.TxtAccount_Number = new System.Windows.Forms.TextBox();
            this.TxtBranch = new System.Windows.Forms.TextBox();
            this.TxtBranch_Code = new System.Windows.Forms.TextBox();
            this.TxtBank_Address = new System.Windows.Forms.TextBox();
            this.TxtBank_Name = new System.Windows.Forms.TextBox();
            this.TxtBeneficiary_Name = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LbCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGVBanks = new System.Windows.Forms.DataGridView();
            this.BtnCancelEdit = new System.Windows.Forms.Button();
            this.groupBoxAcount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAcount
            // 
            this.groupBoxAcount.Controls.Add(this.label1);
            this.groupBoxAcount.Controls.Add(this.TxtBank_Definition);
            this.groupBoxAcount.Controls.Add(this.TxtCurrency);
            this.groupBoxAcount.Controls.Add(this.TxtSwift_Code);
            this.groupBoxAcount.Controls.Add(this.TxtCOUNTRY);
            this.groupBoxAcount.Controls.Add(this.TxtIBAN_Number);
            this.groupBoxAcount.Controls.Add(this.TxtAccount_Number);
            this.groupBoxAcount.Controls.Add(this.TxtBranch);
            this.groupBoxAcount.Controls.Add(this.TxtBranch_Code);
            this.groupBoxAcount.Controls.Add(this.TxtBank_Address);
            this.groupBoxAcount.Controls.Add(this.TxtBank_Name);
            this.groupBoxAcount.Controls.Add(this.TxtBeneficiary_Name);
            this.groupBoxAcount.Controls.Add(this.label22);
            this.groupBoxAcount.Controls.Add(this.label21);
            this.groupBoxAcount.Controls.Add(this.label20);
            this.groupBoxAcount.Controls.Add(this.label19);
            this.groupBoxAcount.Controls.Add(this.label18);
            this.groupBoxAcount.Controls.Add(this.label17);
            this.groupBoxAcount.Controls.Add(this.label16);
            this.groupBoxAcount.Controls.Add(this.label15);
            this.groupBoxAcount.Controls.Add(this.label14);
            this.groupBoxAcount.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAcount.Name = "groupBoxAcount";
            this.groupBoxAcount.Size = new System.Drawing.Size(1073, 449);
            this.groupBoxAcount.TabIndex = 19;
            this.groupBoxAcount.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Definition :";
            // 
            // TxtBank_Definition
            // 
            this.TxtBank_Definition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBank_Definition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBank_Definition.Location = new System.Drawing.Point(213, 36);
            this.TxtBank_Definition.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBank_Definition.MaxLength = 50;
            this.TxtBank_Definition.Name = "TxtBank_Definition";
            this.TxtBank_Definition.Size = new System.Drawing.Size(681, 30);
            this.TxtBank_Definition.TabIndex = 0;
            // 
            // TxtCurrency
            // 
            this.TxtCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCurrency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrency.FormattingEnabled = true;
            this.TxtCurrency.Items.AddRange(new object[] {
            "USD",
            "IQD",
            "AED"});
            this.TxtCurrency.Location = new System.Drawing.Point(903, 36);
            this.TxtCurrency.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCurrency.Name = "TxtCurrency";
            this.TxtCurrency.Size = new System.Drawing.Size(160, 32);
            this.TxtCurrency.TabIndex = 10;
            // 
            // TxtSwift_Code
            // 
            this.TxtSwift_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSwift_Code.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSwift_Code.Location = new System.Drawing.Point(213, 283);
            this.TxtSwift_Code.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtSwift_Code.MaxLength = 50;
            this.TxtSwift_Code.Name = "TxtSwift_Code";
            this.TxtSwift_Code.Size = new System.Drawing.Size(850, 30);
            this.TxtSwift_Code.TabIndex = 6;
            // 
            // TxtCOUNTRY
            // 
            this.TxtCOUNTRY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCOUNTRY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCOUNTRY.Location = new System.Drawing.Point(213, 406);
            this.TxtCOUNTRY.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtCOUNTRY.MaxLength = 50;
            this.TxtCOUNTRY.Name = "TxtCOUNTRY";
            this.TxtCOUNTRY.Size = new System.Drawing.Size(850, 30);
            this.TxtCOUNTRY.TabIndex = 9;
            // 
            // TxtIBAN_Number
            // 
            this.TxtIBAN_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtIBAN_Number.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIBAN_Number.Location = new System.Drawing.Point(213, 365);
            this.TxtIBAN_Number.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtIBAN_Number.MaxLength = 50;
            this.TxtIBAN_Number.Name = "TxtIBAN_Number";
            this.TxtIBAN_Number.Size = new System.Drawing.Size(850, 30);
            this.TxtIBAN_Number.TabIndex = 8;
            // 
            // TxtAccount_Number
            // 
            this.TxtAccount_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtAccount_Number.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccount_Number.Location = new System.Drawing.Point(213, 324);
            this.TxtAccount_Number.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtAccount_Number.MaxLength = 50;
            this.TxtAccount_Number.Name = "TxtAccount_Number";
            this.TxtAccount_Number.Size = new System.Drawing.Size(850, 30);
            this.TxtAccount_Number.TabIndex = 7;
            // 
            // TxtBranch
            // 
            this.TxtBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBranch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBranch.Location = new System.Drawing.Point(213, 160);
            this.TxtBranch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBranch.MaxLength = 50;
            this.TxtBranch.Name = "TxtBranch";
            this.TxtBranch.Size = new System.Drawing.Size(850, 30);
            this.TxtBranch.TabIndex = 3;
            // 
            // TxtBranch_Code
            // 
            this.TxtBranch_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBranch_Code.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBranch_Code.Location = new System.Drawing.Point(213, 201);
            this.TxtBranch_Code.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBranch_Code.MaxLength = 50;
            this.TxtBranch_Code.Name = "TxtBranch_Code";
            this.TxtBranch_Code.Size = new System.Drawing.Size(850, 30);
            this.TxtBranch_Code.TabIndex = 4;
            // 
            // TxtBank_Address
            // 
            this.TxtBank_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBank_Address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBank_Address.Location = new System.Drawing.Point(213, 242);
            this.TxtBank_Address.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBank_Address.MaxLength = 50;
            this.TxtBank_Address.Name = "TxtBank_Address";
            this.TxtBank_Address.Size = new System.Drawing.Size(850, 30);
            this.TxtBank_Address.TabIndex = 5;
            // 
            // TxtBank_Name
            // 
            this.TxtBank_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBank_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBank_Name.Location = new System.Drawing.Point(213, 119);
            this.TxtBank_Name.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBank_Name.MaxLength = 50;
            this.TxtBank_Name.Name = "TxtBank_Name";
            this.TxtBank_Name.Size = new System.Drawing.Size(850, 30);
            this.TxtBank_Name.TabIndex = 2;
            // 
            // TxtBeneficiary_Name
            // 
            this.TxtBeneficiary_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBeneficiary_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBeneficiary_Name.Location = new System.Drawing.Point(213, 78);
            this.TxtBeneficiary_Name.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtBeneficiary_Name.MaxLength = 50;
            this.TxtBeneficiary_Name.Name = "TxtBeneficiary_Name";
            this.TxtBeneficiary_Name.Size = new System.Drawing.Size(850, 30);
            this.TxtBeneficiary_Name.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(43, 415);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 17);
            this.label22.TabIndex = 8;
            this.label22.Text = "COUNTRY";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "IBAN Number  :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "Account Number :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "Swift Code :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 251);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Bank Address :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Branch Code :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Branch :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Bank Name : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Beneficiary Name :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(225, 487);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(174, 43);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(408, 487);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(174, 43);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(591, 487);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(174, 43);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete ";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LbCount
            // 
            this.LbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCount.ForeColor = System.Drawing.Color.White;
            this.LbCount.Location = new System.Drawing.Point(968, 548);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(117, 41);
            this.LbCount.TabIndex = 38;
            this.LbCount.Text = "0";
            this.LbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Black;
            this.TxtSearch.Location = new System.Drawing.Point(18, 548);
            this.TxtSearch.MaxLength = 40;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(944, 41);
            this.TxtSearch.TabIndex = 4;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVBanks
            // 
            this.DGVBanks.AllowUserToAddRows = false;
            this.DGVBanks.AllowUserToDeleteRows = false;
            this.DGVBanks.AllowUserToOrderColumns = true;
            this.DGVBanks.AllowUserToResizeRows = false;
            this.DGVBanks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBanks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBanks.Location = new System.Drawing.Point(18, 596);
            this.DGVBanks.MultiSelect = false;
            this.DGVBanks.Name = "DGVBanks";
            this.DGVBanks.ReadOnly = true;
            this.DGVBanks.RowTemplate.Height = 26;
            this.DGVBanks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBanks.Size = new System.Drawing.Size(1071, 160);
            this.DGVBanks.TabIndex = 37;
            this.DGVBanks.DoubleClick += new System.EventHandler(this.DGVBanks_DoubleClick);
            // 
            // BtnCancelEdit
            // 
            this.BtnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCancelEdit.BackColor = System.Drawing.Color.Green;
            this.BtnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.BtnCancelEdit.Location = new System.Drawing.Point(770, 487);
            this.BtnCancelEdit.Name = "BtnCancelEdit";
            this.BtnCancelEdit.Size = new System.Drawing.Size(174, 43);
            this.BtnCancelEdit.TabIndex = 3;
            this.BtnCancelEdit.Text = "Cancel Edit";
            this.BtnCancelEdit.UseVisualStyleBackColor = false;
            this.BtnCancelEdit.Visible = false;
            this.BtnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // Frm_BanksAccountAddUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 853);
            this.Controls.Add(this.BtnCancelEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LbCount);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVBanks);
            this.Controls.Add(this.groupBoxAcount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BanksAccountAddUpdateDelete";
            this.Text = "Frm_BanksAccountAddUpdateDelete";
            this.Load += new System.EventHandler(this.Frm_BanksAccountAddUpdateDelete_Load);
            this.groupBoxAcount.ResumeLayout(false);
            this.groupBoxAcount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBanks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcount;
        private System.Windows.Forms.TextBox TxtSwift_Code;
        private System.Windows.Forms.TextBox TxtCOUNTRY;
        private System.Windows.Forms.TextBox TxtIBAN_Number;
        private System.Windows.Forms.TextBox TxtAccount_Number;
        private System.Windows.Forms.TextBox TxtBranch;
        private System.Windows.Forms.TextBox TxtBranch_Code;
        private System.Windows.Forms.TextBox TxtBank_Address;
        private System.Windows.Forms.TextBox TxtBank_Name;
        private System.Windows.Forms.TextBox TxtBeneficiary_Name;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVBanks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBank_Definition;
        private System.Windows.Forms.ComboBox TxtCurrency;
        private System.Windows.Forms.Button BtnCancelEdit;
    }
}