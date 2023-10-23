namespace Alkamous.View
{
    partial class Frm_TermsImportExport
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnResetToDefault = new System.Windows.Forms.Button();
            this.BtnSaveConfiguration = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnOpenPath = new System.Windows.Forms.Button();
            this.BtnImportTerms = new System.Windows.Forms.CheckBox();
            this.BtnExportTerms = new System.Windows.Forms.CheckBox();
            this.txtNewPth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnResetToDefault);
            this.groupBox4.Controls.Add(this.BtnSaveConfiguration);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(153, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(796, 111);
            this.groupBox4.TabIndex = 53;
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
            this.groupBox3.Controls.Add(this.BtnOpenPath);
            this.groupBox3.Controls.Add(this.BtnImportTerms);
            this.groupBox3.Controls.Add(this.BtnExportTerms);
            this.groupBox3.Controls.Add(this.txtNewPth);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(153, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(796, 222);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
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
            this.BtnOpenPath.Location = new System.Drawing.Point(43, 164);
            this.BtnOpenPath.Name = "BtnOpenPath";
            this.BtnOpenPath.Size = new System.Drawing.Size(75, 34);
            this.BtnOpenPath.TabIndex = 52;
            this.BtnOpenPath.Text = "...";
            this.BtnOpenPath.UseVisualStyleBackColor = false;
            this.BtnOpenPath.Click += new System.EventHandler(this.BtnOpenPath_Click);
            // 
            // BtnImportTerms
            // 
            this.BtnImportTerms.AutoSize = true;
            this.BtnImportTerms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportTerms.Location = new System.Drawing.Point(43, 101);
            this.BtnImportTerms.Name = "BtnImportTerms";
            this.BtnImportTerms.Size = new System.Drawing.Size(313, 27);
            this.BtnImportTerms.TabIndex = 28;
            this.BtnImportTerms.Text = "Import Terms Data CSV terms";
            this.BtnImportTerms.UseVisualStyleBackColor = true;
            this.BtnImportTerms.CheckedChanged += new System.EventHandler(this.BtnImportTerms_CheckedChanged);
            // 
            // BtnExportTerms
            // 
            this.BtnExportTerms.AutoSize = true;
            this.BtnExportTerms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportTerms.Location = new System.Drawing.Point(43, 47);
            this.BtnExportTerms.Name = "BtnExportTerms";
            this.BtnExportTerms.Size = new System.Drawing.Size(250, 27);
            this.BtnExportTerms.TabIndex = 27;
            this.BtnExportTerms.Text = "Export Terms Data CSV";
            this.BtnExportTerms.UseVisualStyleBackColor = true;
            this.BtnExportTerms.CheckedChanged += new System.EventHandler(this.BtnExportTerms_CheckedChanged);
            // 
            // txtNewPth
            // 
            this.txtNewPth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPth.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNewPth.Location = new System.Drawing.Point(125, 164);
            this.txtNewPth.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPth.Name = "txtNewPth";
            this.txtNewPth.ReadOnly = true;
            this.txtNewPth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPth.Size = new System.Drawing.Size(649, 28);
            this.txtNewPth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(300, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 34);
            this.label1.TabIndex = 54;
            this.label1.Text = "select one of the operations below :-";
            // 
            // Frm_TermsImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TermsImportExport";
            this.Text = "Frm_TermsImportExport";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnSaveConfiguration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnOpenPath;
        private System.Windows.Forms.TextBox txtNewPth;
        private System.Windows.Forms.CheckBox BtnImportTerms;
        private System.Windows.Forms.CheckBox BtnExportTerms;
        private System.Windows.Forms.Button BtnResetToDefault;
        private System.Windows.Forms.Label label1;
    }
}