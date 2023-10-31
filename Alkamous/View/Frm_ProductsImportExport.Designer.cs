namespace Alkamous.View
{
    partial class Frm_ProductsImportExport
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnResetToDefault = new System.Windows.Forms.Button();
            this.BtnSaveConfiguration = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbWaitSaveFile = new System.Windows.Forms.Label();
            this.BtnOpenPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImportProducts = new System.Windows.Forms.CheckBox();
            this.BtnExportProducts = new System.Windows.Forms.CheckBox();
            this.txtNewPth = new System.Windows.Forms.TextBox();
            this.BtnBackToImportAndExport = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(448, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 70);
            this.label2.TabIndex = 58;
            this.label2.Text = "Products";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnResetToDefault);
            this.groupBox4.Controls.Add(this.BtnSaveConfiguration);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(159, 423);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(796, 111);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            // 
            // BtnResetToDefault
            // 
            this.BtnResetToDefault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnResetToDefault.BackColor = System.Drawing.Color.Green;
            this.BtnResetToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetToDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnResetToDefault.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnResetToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetToDefault.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetToDefault.ForeColor = System.Drawing.Color.White;
            this.BtnResetToDefault.Location = new System.Drawing.Point(573, 34);
            this.BtnResetToDefault.Name = "BtnResetToDefault";
            this.BtnResetToDefault.Size = new System.Drawing.Size(201, 62);
            this.BtnResetToDefault.TabIndex = 46;
            this.BtnResetToDefault.Text = "Reset To Default";
            this.BtnResetToDefault.UseVisualStyleBackColor = false;
            this.BtnResetToDefault.Click += new System.EventHandler(this.BtnResetToDefault_Click);
            // 
            // BtnSaveConfiguration
            // 
            this.BtnSaveConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnSaveConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSaveConfiguration.FlatAppearance.BorderSize = 0;
            this.BtnSaveConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveConfiguration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveConfiguration.ForeColor = System.Drawing.Color.White;
            this.BtnSaveConfiguration.Location = new System.Drawing.Point(43, 34);
            this.BtnSaveConfiguration.Name = "BtnSaveConfiguration";
            this.BtnSaveConfiguration.Size = new System.Drawing.Size(294, 62);
            this.BtnSaveConfiguration.TabIndex = 7;
            this.BtnSaveConfiguration.Text = "Start Processing ...";
            this.BtnSaveConfiguration.UseVisualStyleBackColor = false;
            this.BtnSaveConfiguration.Click += new System.EventHandler(this.BtnSaveConfiguration_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbWaitSaveFile);
            this.groupBox3.Controls.Add(this.BtnOpenPath);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BtnImportProducts);
            this.groupBox3.Controls.Add(this.BtnExportProducts);
            this.groupBox3.Controls.Add(this.txtNewPth);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(159, 157);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(796, 260);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // LbWaitSaveFile
            // 
            this.LbWaitSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWaitSaveFile.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWaitSaveFile.Location = new System.Drawing.Point(7, 21);
            this.LbWaitSaveFile.Name = "LbWaitSaveFile";
            this.LbWaitSaveFile.Size = new System.Drawing.Size(782, 226);
            this.LbWaitSaveFile.TabIndex = 59;
            this.LbWaitSaveFile.Text = "Please Wait Until the processing Finish ...";
            this.LbWaitSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOpenPath
            // 
            this.BtnOpenPath.BackColor = System.Drawing.Color.Green;
            this.BtnOpenPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnOpenPath.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnOpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenPath.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenPath.ForeColor = System.Drawing.Color.White;
            this.BtnOpenPath.Location = new System.Drawing.Point(43, 200);
            this.BtnOpenPath.Name = "BtnOpenPath";
            this.BtnOpenPath.Size = new System.Drawing.Size(75, 34);
            this.BtnOpenPath.TabIndex = 52;
            this.BtnOpenPath.Text = "...";
            this.BtnOpenPath.UseVisualStyleBackColor = false;
            this.BtnOpenPath.Click += new System.EventHandler(this.BtnOpenPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(138, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "select one of the operations below :-";
            // 
            // BtnImportProducts
            // 
            this.BtnImportProducts.AutoSize = true;
            this.BtnImportProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportProducts.Location = new System.Drawing.Point(43, 137);
            this.BtnImportProducts.Name = "BtnImportProducts";
            this.BtnImportProducts.Size = new System.Drawing.Size(341, 27);
            this.BtnImportProducts.TabIndex = 28;
            this.BtnImportProducts.Text = "Import Products Data CSV terms";
            this.BtnImportProducts.UseVisualStyleBackColor = true;
            this.BtnImportProducts.CheckedChanged += new System.EventHandler(this.BtnImportProducts_CheckedChanged);
            // 
            // BtnExportProducts
            // 
            this.BtnExportProducts.AutoSize = true;
            this.BtnExportProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportProducts.Location = new System.Drawing.Point(43, 83);
            this.BtnExportProducts.Name = "BtnExportProducts";
            this.BtnExportProducts.Size = new System.Drawing.Size(278, 27);
            this.BtnExportProducts.TabIndex = 27;
            this.BtnExportProducts.Text = "Export Products Data CSV";
            this.BtnExportProducts.UseVisualStyleBackColor = true;
            this.BtnExportProducts.CheckedChanged += new System.EventHandler(this.BtnExportProducts_CheckedChanged);
            // 
            // txtNewPth
            // 
            this.txtNewPth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPth.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNewPth.Location = new System.Drawing.Point(125, 200);
            this.txtNewPth.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPth.Name = "txtNewPth";
            this.txtNewPth.ReadOnly = true;
            this.txtNewPth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPth.Size = new System.Drawing.Size(649, 28);
            this.txtNewPth.TabIndex = 5;
            // 
            // BtnBackToImportAndExport
            // 
            this.BtnBackToImportAndExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBackToImportAndExport.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnBackToImportAndExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackToImportAndExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnBackToImportAndExport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBackToImportAndExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToImportAndExport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToImportAndExport.ForeColor = System.Drawing.Color.White;
            this.BtnBackToImportAndExport.Location = new System.Drawing.Point(159, 550);
            this.BtnBackToImportAndExport.Name = "BtnBackToImportAndExport";
            this.BtnBackToImportAndExport.Size = new System.Drawing.Size(796, 62);
            this.BtnBackToImportAndExport.TabIndex = 47;
            this.BtnBackToImportAndExport.Text = "Back TO Import And Export Form";
            this.BtnBackToImportAndExport.UseVisualStyleBackColor = false;
            this.BtnBackToImportAndExport.Click += new System.EventHandler(this.BtnBackToImportAndExport_Click);
            // 
            // Frm_ProductsImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.BtnBackToImportAndExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ProductsImportExport";
            this.Text = "Frm_ProductsImportExport";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnResetToDefault;
        private System.Windows.Forms.Button BtnSaveConfiguration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnOpenPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BtnImportProducts;
        private System.Windows.Forms.CheckBox BtnExportProducts;
        private System.Windows.Forms.TextBox txtNewPth;
        private System.Windows.Forms.Button BtnBackToImportAndExport;
        public System.Windows.Forms.Label LbWaitSaveFile;
    }
}