namespace Alkamous.Reports
{
    partial class Frm_ReportViewerHoder
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CustomersInvoiceReport1 = new Alkamous.Reports.CustomersInvoiceReport();
            this.BtnExportToPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayBackgroundEdge = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CustomersInvoiceReport1;
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1412, 638);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BtnExportToPDF
            // 
            this.BtnExportToPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnExportToPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportToPDF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExportToPDF.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnExportToPDF.Location = new System.Drawing.Point(651, 12);
            this.BtnExportToPDF.Name = "BtnExportToPDF";
            this.BtnExportToPDF.Size = new System.Drawing.Size(331, 34);
            this.BtnExportToPDF.TabIndex = 1;
            this.BtnExportToPDF.Text = "&Export To PDF ";
            this.BtnExportToPDF.UseVisualStyleBackColor = true;
            this.BtnExportToPDF.Click += new System.EventHandler(this.BtnExportToPDF_Click);
            // 
            // Frm_ReportViewerHoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 638);
            this.Controls.Add(this.BtnExportToPDF);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_ReportViewerHoder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ReportViewerHoder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CustomersInvoiceReport CustomersInvoiceReport1;
        private System.Windows.Forms.Button BtnExportToPDF;
    }
}