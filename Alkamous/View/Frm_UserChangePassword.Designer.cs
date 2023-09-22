namespace Alkamous.View
{
    partial class Frm_UserChangePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbPassLevel = new System.Windows.Forms.Label();
            this.BtnSavePassword = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtConformpass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.BtnAutoLogin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAutoLogin);
            this.groupBox1.Controls.Add(this.BtnShowPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LbPassLevel);
            this.groupBox1.Controls.Add(this.BtnSavePassword);
            this.groupBox1.Controls.Add(this.txtOldPass);
            this.groupBox1.Controls.Add(this.txtConformpass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Location = new System.Drawing.Point(118, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.AutoSize = true;
            this.BtnShowPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowPassword.Location = new System.Drawing.Point(539, 261);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(179, 27);
            this.BtnShowPassword.TabIndex = 14;
            this.BtnShowPassword.Text = "Show Password";
            this.BtnShowPassword.UseVisualStyleBackColor = true;
            this.BtnShowPassword.CheckedChanged += new System.EventHandler(this.BtnShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Password";
            // 
            // LbPassLevel
            // 
            this.LbPassLevel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassLevel.Location = new System.Drawing.Point(155, 173);
            this.LbPassLevel.Name = "LbPassLevel";
            this.LbPassLevel.Size = new System.Drawing.Size(563, 59);
            this.LbPassLevel.TabIndex = 10;
            this.LbPassLevel.Text = "Password Level";
            this.LbPassLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPassLevel.Visible = false;
            // 
            // BtnSavePassword
            // 
            this.BtnSavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.BtnSavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSavePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSavePassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSavePassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavePassword.ForeColor = System.Drawing.Color.White;
            this.BtnSavePassword.Location = new System.Drawing.Point(155, 495);
            this.BtnSavePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSavePassword.Name = "BtnSavePassword";
            this.BtnSavePassword.Size = new System.Drawing.Size(566, 72);
            this.BtnSavePassword.TabIndex = 9;
            this.BtnSavePassword.Text = "Save Changes";
            this.BtnSavePassword.UseVisualStyleBackColor = false;
            this.BtnSavePassword.Click += new System.EventHandler(this.BtnSavePassword_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(155, 89);
            this.txtOldPass.MaxLength = 20;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(566, 40);
            this.txtOldPass.TabIndex = 8;
            // 
            // txtConformpass
            // 
            this.txtConformpass.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConformpass.Location = new System.Drawing.Point(155, 391);
            this.txtConformpass.MaxLength = 20;
            this.txtConformpass.Name = "txtConformpass";
            this.txtConformpass.Size = new System.Drawing.Size(566, 40);
            this.txtConformpass.TabIndex = 7;
            this.txtConformpass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(155, 292);
            this.txtNewPass.MaxLength = 20;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(566, 40);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // BtnAutoLogin
            // 
            this.BtnAutoLogin.AutoSize = true;
            this.BtnAutoLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutoLogin.Location = new System.Drawing.Point(173, 451);
            this.BtnAutoLogin.Name = "BtnAutoLogin";
            this.BtnAutoLogin.Size = new System.Drawing.Size(296, 27);
            this.BtnAutoLogin.TabIndex = 15;
            this.BtnAutoLogin.Text = "Enable Auto Login Features";
            this.BtnAutoLogin.UseVisualStyleBackColor = true;
            this.BtnAutoLogin.CheckedChanged += new System.EventHandler(this.BtnAutoLogin_CheckedChanged);
            // 
            // Frm_UserChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 695);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_UserChangePassword";
            this.Text = "Frm_UserChangePassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox BtnShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbPassLevel;
        private System.Windows.Forms.Button BtnSavePassword;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtConformpass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.CheckBox BtnAutoLogin;
    }
}