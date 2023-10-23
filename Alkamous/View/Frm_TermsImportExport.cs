using Alkamous.Controller;
using Alkamous.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_TermsImportExport : Form
    {

        ClsOperationsofTerms OperationsofTerms = new ClsOperationsofTerms();

        List<CTB_Terms> csvDataList = null;

        public Frm_TermsImportExport()
        {
            InitializeComponent();
            ResetToDefault();
        }

        private void CheckedIsSelected(string WhoSender)
        {
            //directly assign the result
            bool Result = WhoSender == "ExportTerms";

            txtNewPth.Text = "";
            csvDataList = null;

            BtnExportTerms.Checked = Result;
            BtnImportTerms.Checked = !(Result);

            BtnExportTerms.Enabled = !(Result);
            BtnImportTerms.Enabled = (Result);

            BtnSaveConfiguration.Enabled = false;
        }

        private bool CheckInputAndPath()
        {
            if ((BtnExportTerms.Checked == false) & (BtnImportTerms.Checked == false))
            {
                MessageBox.Show("please select one of the options of below");
                return false;
            }
            else if (txtNewPth.Text == string.Empty)
            {
                MessageBox.Show("please select the Path");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetToDefault()
        {

            csvDataList = null;
            txtNewPth.Text = "";

            BtnExportTerms.Checked = false;
            BtnImportTerms.Checked = false;

            BtnExportTerms.Enabled = true;
            BtnImportTerms.Enabled = true;

            BtnSaveConfiguration.Enabled = false;


        }

        private void BtnSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (CheckInputAndPath())
            {
                Cursor.Current = Cursors.WaitCursor;

                if (BtnExportTerms.Checked)
                {
                    DownloadTermsToServer();
                }
                else
                {
                    UploadTermsToServer();
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnResetToDefault_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private void BtnOpenPath_Click(object sender, EventArgs e)
        {
            if ((BtnExportTerms.Checked == false) & (BtnImportTerms.Checked == false))
            {
                MessageBox.Show("please select one of the options of below");
                return;
            }
            if (BtnExportTerms.Checked)
            {
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                FBD.Description = "Choose the path To Export the CSV File";

                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    txtNewPth.Text = FBD.SelectedPath;
                    BtnSaveConfiguration.Enabled = true;
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Select Terms CSV file",
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txtNewPth.Text = filePath;

                    string[] lines = File.ReadAllLines(filePath, Encoding.Default);

                    if (lines.Length < 1)
                    {
                        MessageBox.Show("File is empty.", "Error");
                        return;
                    }

                    var headerColumns = lines[0].Split(',');

                    if (headerColumns.Length < 2 || headerColumns[0] != "Terms En" || headerColumns[1] != "Terms Ar")
                    {
                        MessageBox.Show("Header columns must be 'Terms En' and 'Terms Ar'.", "Error");
                        return;
                    }


                    BtnSaveConfiguration.Enabled = true;

                    csvDataList = new List<CTB_Terms>();

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] csvValues = lines[i].Split(',');

                        if (csvValues.Length == 2)
                        {
                            CTB_Terms cTB_Terms = new CTB_Terms
                            {
                                Term_En = csvValues[0],
                                Term_Ar = csvValues[1],
                            };

                            csvDataList.Add(cTB_Terms);
                        }
                    }
                }
            }
        }

        private void BtnExportTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnExportTerms.Checked)
            {
                CheckedIsSelected("ExportTerms");
            }
        }

        private void BtnImportTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnImportTerms.Checked)
            {
                CheckedIsSelected("ImportTerms");
            }
        }

        private void UploadTermsToServer()
        {

            if (csvDataList != null)
            {
                foreach (var _terms in csvDataList)
                {
                    OperationsofTerms.Add_TermLIST(_terms);
                }
                OperationsofTerms.InsertBulk();
                MessageBox.Show("Terms has been imported successfully");
                return;
            }
            MessageBox.Show("failed try later");

        }

        private void DownloadTermsToServer()
        {
            string strPath = txtNewPth.Text.Trim();
            DataTable ResultOfData = new DataTable();
            ResultOfData = OperationsofTerms.Get_AllTerms();

            StringBuilder strLog = new StringBuilder();
            string ExportData = "";
            //// loop for rows data to append in CSV 
            for (int i = 0; i < ResultOfData.Rows.Count; i++)
            {
                ExportData = "";
                for (int j = 1; j < ResultOfData.Columns.Count; j++)
                {
                    ExportData += ResultOfData.Rows[i][j].ToString() + ",";
                }
                strLog.AppendLine(ExportData);
            }

            File.AppendAllText(strPath + "\\" + "Terms.CSV", strLog + DateTime.Now.ToString() + "\r\n", Encoding.UTF8);


        }


    }
}
















