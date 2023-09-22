namespace Alkamous.View
{
    partial class Frm_Main
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
            this.BtnConnection = new System.Windows.Forms.Button();
            this.PainleContener = new System.Windows.Forms.Panel();
            this.panelLesft = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LbServerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBUserName = new System.Windows.Forms.Label();
            this.LBData = new System.Windows.Forms.Label();
            this.LBTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNewQuotation = new System.Windows.Forms.Button();
            this.BtnCustomerInfo = new System.Windows.Forms.Button();
            this.BtnManage = new System.Windows.Forms.Button();
            this.panelLesft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnection
            // 
            this.BtnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(146)))));
            this.BtnConnection.CausesValidation = false;
            this.BtnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnection.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnection.ForeColor = System.Drawing.Color.White;
            this.BtnConnection.Location = new System.Drawing.Point(9, 423);
            this.BtnConnection.Name = "BtnConnection";
            this.BtnConnection.Size = new System.Drawing.Size(143, 70);
            this.BtnConnection.TabIndex = 0;
            this.BtnConnection.Text = "Settings";
            this.BtnConnection.UseVisualStyleBackColor = false;
            this.BtnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // PainleContener
            // 
            this.PainleContener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PainleContener.BackColor = System.Drawing.SystemColors.Control;
            this.PainleContener.Location = new System.Drawing.Point(161, 0);
            this.PainleContener.Name = "PainleContener";
            this.PainleContener.Size = new System.Drawing.Size(1131, 935);
            this.PainleContener.TabIndex = 2;
            // 
            // panelLesft
            // 
            this.panelLesft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLesft.AutoSize = true;
            this.panelLesft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.panelLesft.Controls.Add(this.PicLogo);
            this.panelLesft.Controls.Add(this.LbServerName);
            this.panelLesft.Controls.Add(this.label5);
            this.panelLesft.Controls.Add(this.LBUserName);
            this.panelLesft.Controls.Add(this.LBData);
            this.panelLesft.Controls.Add(this.LBTime);
            this.panelLesft.Controls.Add(this.label1);
            this.panelLesft.Controls.Add(this.BtnConnection);
            this.panelLesft.Controls.Add(this.BtnNewQuotation);
            this.panelLesft.Controls.Add(this.BtnCustomerInfo);
            this.panelLesft.Controls.Add(this.BtnManage);
            this.panelLesft.Location = new System.Drawing.Point(0, 0);
            this.panelLesft.Name = "panelLesft";
            this.panelLesft.Size = new System.Drawing.Size(158, 981);
            this.panelLesft.TabIndex = 1;
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicLogo.Image = global::Alkamous.Properties.Resources.LOGOAlkamous;
            this.PicLogo.Location = new System.Drawing.Point(27, 32);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(111, 111);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // LbServerName
            // 
            this.LbServerName.AutoSize = true;
            this.LbServerName.BackColor = System.Drawing.Color.Transparent;
            this.LbServerName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbServerName.ForeColor = System.Drawing.Color.White;
            this.LbServerName.Location = new System.Drawing.Point(8, 554);
            this.LbServerName.Name = "LbServerName";
            this.LbServerName.Size = new System.Drawing.Size(71, 17);
            this.LbServerName.TabIndex = 13;
            this.LbServerName.Text = "server Ip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "User Name";
            // 
            // LBUserName
            // 
            this.LBUserName.AutoSize = true;
            this.LBUserName.BackColor = System.Drawing.Color.Transparent;
            this.LBUserName.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUserName.ForeColor = System.Drawing.Color.White;
            this.LBUserName.Location = new System.Drawing.Point(8, 622);
            this.LBUserName.Name = "LBUserName";
            this.LBUserName.Size = new System.Drawing.Size(54, 17);
            this.LBUserName.TabIndex = 11;
            this.LBUserName.Text = "userId";
            // 
            // LBData
            // 
            this.LBData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBData.AutoSize = true;
            this.LBData.BackColor = System.Drawing.Color.Transparent;
            this.LBData.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBData.ForeColor = System.Drawing.Color.White;
            this.LBData.Location = new System.Drawing.Point(8, 695);
            this.LBData.Name = "LBData";
            this.LBData.Size = new System.Drawing.Size(40, 17);
            this.LBData.TabIndex = 10;
            this.LBData.Text = "Date";
            // 
            // LBTime
            // 
            this.LBTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBTime.AutoSize = true;
            this.LBTime.BackColor = System.Drawing.Color.Transparent;
            this.LBTime.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTime.ForeColor = System.Drawing.Color.White;
            this.LBTime.Location = new System.Drawing.Point(8, 668);
            this.LBTime.Name = "LBTime";
            this.LBTime.Size = new System.Drawing.Size(41, 17);
            this.LBTime.TabIndex = 9;
            this.LBTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Name ";
            // 
            // BtnNewQuotation
            // 
            this.BtnNewQuotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(146)))));
            this.BtnNewQuotation.CausesValidation = false;
            this.BtnNewQuotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewQuotation.Enabled = false;
            this.BtnNewQuotation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnNewQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewQuotation.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewQuotation.ForeColor = System.Drawing.Color.White;
            this.BtnNewQuotation.Location = new System.Drawing.Point(9, 251);
            this.BtnNewQuotation.Name = "BtnNewQuotation";
            this.BtnNewQuotation.Size = new System.Drawing.Size(143, 69);
            this.BtnNewQuotation.TabIndex = 7;
            this.BtnNewQuotation.Text = "Quotation";
            this.BtnNewQuotation.UseVisualStyleBackColor = false;
            this.BtnNewQuotation.Click += new System.EventHandler(this.BtnNewQuotation_Click);
            // 
            // BtnCustomerInfo
            // 
            this.BtnCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(146)))));
            this.BtnCustomerInfo.CausesValidation = false;
            this.BtnCustomerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomerInfo.Enabled = false;
            this.BtnCustomerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.BtnCustomerInfo.Location = new System.Drawing.Point(9, 165);
            this.BtnCustomerInfo.Name = "BtnCustomerInfo";
            this.BtnCustomerInfo.Size = new System.Drawing.Size(143, 69);
            this.BtnCustomerInfo.TabIndex = 5;
            this.BtnCustomerInfo.Text = "Clint Info";
            this.BtnCustomerInfo.UseVisualStyleBackColor = false;
            this.BtnCustomerInfo.Click += new System.EventHandler(this.BtnCustomerInfo_Click);
            // 
            // BtnManage
            // 
            this.BtnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(146)))));
            this.BtnManage.CausesValidation = false;
            this.BtnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnManage.Enabled = false;
            this.BtnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManage.ForeColor = System.Drawing.Color.White;
            this.BtnManage.Location = new System.Drawing.Point(9, 337);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(143, 69);
            this.BtnManage.TabIndex = 4;
            this.BtnManage.Text = "Manage";
            this.BtnManage.UseVisualStyleBackColor = false;
            this.BtnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 935);
            this.Controls.Add(this.panelLesft);
            this.Controls.Add(this.PainleContener);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panelLesft.ResumeLayout(false);
            this.panelLesft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel PainleContener;
        private System.Windows.Forms.Label LbServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBData;
        private System.Windows.Forms.Label LBTime;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnConnection;
        public System.Windows.Forms.Button BtnManage;
        public System.Windows.Forms.Button BtnCustomerInfo;
        public System.Windows.Forms.Button BtnNewQuotation;
        public System.Windows.Forms.Panel panelLesft;
        public System.Windows.Forms.Label LBUserName;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}