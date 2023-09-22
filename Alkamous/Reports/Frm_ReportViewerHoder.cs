using Alkamous.Controller;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Alkamous.Reports
{
    public partial class Frm_ReportViewerHoder : Form
    {
        public static ReportDocument reportDocument;
        public static string FileNameOfPDF = "PortableDocFormat.pdf";

        public Frm_ReportViewerHoder()
        {
            InitializeComponent();

            try
            {
                // مهنم لوضع اكون للبرنامج
                Icon = Icon.ExtractAssociatedIcon($"{System.Diagnostics.Process.GetCurrentProcess().ProcessName}.exe");
            }
            catch (Exception ex)
            {
                Chelp.WriteErrorLog("ICon =>" + ex.Message);
            }
        }



        private void BtnExportToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "PDF|*.pdf";
            SFD.FileName = FileNameOfPDF;
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, SFD.FileName);
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Export Completed", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
