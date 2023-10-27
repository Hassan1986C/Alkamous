
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Collections.Generic;
using Alkamous.Controller;
using Alkamous.Model;
using System.Linq;

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
                    ExportTermsData();
                    ResetToDefault();
                }
                else
                {
                    AddTermsToServer();
                    ResetToDefault();
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
                MessageBox.Show("please select one of the options above");
                return;
            }
            if (BtnExportTerms.Checked)
            {
                using (var folderBrowser = new FolderBrowserDialog
                {
                    Description = "Choose the path to export the CSV File"
                })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        txtNewPth.Text = folderBrowser.SelectedPath;
                        BtnSaveConfiguration.Enabled = true;
                    }
                }
            }
            else
            {
                using (var _openFileDialog = new OpenFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Select Terms CSV file"
                })
                {
                    if (_openFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string filePath = _openFileDialog.FileName;
                    txtNewPth.Text = filePath;

                    using (var reader = new StreamReader(filePath, Encoding.Default))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CTB_Terms>().ToList();

                        if (records.Count > 0)
                        {
                            BtnSaveConfiguration.Enabled = true;
                            csvDataList = records;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the CSV file.", "Error");
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

        private void AddTermsToServer()
        {

            try
            {
                if (csvDataList != null)
                {
                    int TotalRows = csvDataList.Count;
                    foreach (var _terms in csvDataList)
                    {
                        OperationsofTerms.Add_TermLIST(_terms);
                    }
                    OperationsofTerms.InsertBulk();
                    MessageBox.Show($"{TotalRows} Terms has been imported successfully");
                    return;
                }
                MessageBox.Show("failed try later");
            }
            catch (Exception ex)
            {

                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }


        private void ExportTermsData()
        {
            try
            {

                DataTable ResultOfData = new DataTable();
                ResultOfData = OperationsofTerms.Get_AllTerms();

                if (ResultOfData.Rows.Count > 0)
                {
                    string strPath = txtNewPth.Text.Trim();
                    string csvFilePath = Path.Combine(strPath, "ALKAMOUS Terms.CSV");

                    int TotalRows = ResultOfData.Rows.Count;

                    csvDataList = ResultOfData.ToList<CTB_Terms>();


                    using (var fileStream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write))
                    {
                        using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                        {
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {

                                csv.WriteRecords(csvDataList);

                            }
                            MessageBox.Show($"{TotalRows} Terms has been Export successfully", "Info");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($" NO Terms Export !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }


    }

}
















