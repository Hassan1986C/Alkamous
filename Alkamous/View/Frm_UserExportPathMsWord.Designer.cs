namespace Alkamous.View
{
    partial class Frm_UserExportPathMsWord
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
            this.BtnSaveConfiguration = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnOpenPath = new System.Windows.Forms.Button();
            this.BtnNewPath = new System.Windows.Forms.CheckBox();
            this.BtnDefultPath = new System.Windows.Forms.CheckBox();
            this.txtNewPth = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnSaveConfiguration);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(176, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(796, 111);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
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
            this.BtnSaveConfiguration.Location = new System.Drawing.Point(139, 34);
            this.BtnSaveConfiguration.Name = "BtnSaveConfiguration";
            this.BtnSaveConfiguration.Size = new System.Drawing.Size(541, 62);
            this.BtnSaveConfiguration.TabIndex = 7;
            this.BtnSaveConfiguration.Text = "Save Configuration Setting";
            this.BtnSaveConfiguration.UseVisualStyleBackColor = false;
            this.BtnSaveConfiguration.Click += new System.EventHandler(this.BtnSaveConfiguration_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnOpenPath);
            this.groupBox3.Controls.Add(this.BtnNewPath);
            this.groupBox3.Controls.Add(this.BtnDefultPath);
            this.groupBox3.Controls.Add(this.txtNewPth);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(176, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(796, 222);
            this.groupBox3.TabIndex = 50;
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
            this.BtnOpenPath.Visible = false;
            this.BtnOpenPath.Click += new System.EventHandler(this.BtnOpenPath_Click);
            // 
            // BtnNewPath
            // 
            this.BtnNewPath.AutoSize = true;
            this.BtnNewPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewPath.Location = new System.Drawing.Point(43, 101);
            this.BtnNewPath.Name = "BtnNewPath";
            this.BtnNewPath.Size = new System.Drawing.Size(455, 27);
            this.BtnNewPath.TabIndex = 28;
            this.BtnNewPath.Text = "Choose a New Path to Export The Word File.";
            this.BtnNewPath.UseVisualStyleBackColor = true;
            this.BtnNewPath.CheckedChanged += new System.EventHandler(this.BtnNewPath_CheckedChanged);
            // 
            // BtnDefultPath
            // 
            this.BtnDefultPath.AutoSize = true;
            this.BtnDefultPath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefultPath.Location = new System.Drawing.Point(43, 51);
            this.BtnDefultPath.Name = "BtnDefultPath";
            this.BtnDefultPath.Size = new System.Drawing.Size(700, 27);
            this.BtnDefultPath.TabIndex = 27;
            this.BtnDefultPath.Text = "Default Path To Export Ms Word File ( on the same Application folder)";
            this.BtnDefultPath.UseVisualStyleBackColor = true;
            this.BtnDefultPath.CheckedChanged += new System.EventHandler(this.BtnDefultPath_CheckedChanged);
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
            this.txtNewPth.Visible = false;
            // 
            // Frm_UserExportPathMsWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 699);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_UserExportPathMsWord";
            this.Text = "Frm_UserExportPathMsWord";
            this.Load += new System.EventHandler(this.Frm_UserExportPathMsWord_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnSaveConfiguration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNewPth;
        private System.Windows.Forms.CheckBox BtnNewPath;
        private System.Windows.Forms.CheckBox BtnDefultPath;
        private System.Windows.Forms.Button BtnOpenPath;
    }
}