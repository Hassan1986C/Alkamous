using Alkamous.Controller;
using Alkamous.Model;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_ProductsImportExport : Form
    {

        ClsOperationsofProducts operationsofProducts = new ClsOperationsofProducts();
        List<CTB_Products> csvDataList = null;

        public Frm_ProductsImportExport()
        {
            InitializeComponent();
            ResetToDefault();
        }

        private void ResetToDefault()
        {

            csvDataList = null;
            txtNewPth.Text = "";

            BtnExportProducts.Checked = false;
            BtnImportProducts.Checked = false;

            BtnExportProducts.Enabled = true;
            BtnImportProducts.Enabled = true;

            BtnSaveConfiguration.Enabled = false;
            LbWaitSaveFile.Visible = false;


        }

        private void CheckedIsSelected(string WhoSender)
        {
            //directly assign the result
            bool Result = WhoSender == "ExportProducts";

            txtNewPth.Text = "";
            csvDataList = null;

            BtnExportProducts.Checked = Result;
            BtnImportProducts.Checked = !(Result);

            BtnExportProducts.Enabled = !(Result);
            BtnImportProducts.Enabled = (Result);

            BtnSaveConfiguration.Enabled = false;
        }

        private bool CheckInputAndPath()
        {
            if ((BtnExportProducts.Checked == false) & (BtnImportProducts.Checked == false))
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

        private void BtnResetToDefault_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private async void BtnSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (CheckInputAndPath())
            {
                Cursor.Current = Cursors.WaitCursor;
                LbWaitSaveFile.Visible = true;

                if (BtnExportProducts.Checked)
                {
                    BtnSaveConfiguration.Enabled = false;
                    BtnBackToImportAndExport.Enabled = false;
                    BtnResetToDefault.Enabled = false;

                    await ExportProductsData();

                    BtnSaveConfiguration.Enabled = true;
                    BtnBackToImportAndExport.Enabled = true;
                    BtnResetToDefault.Enabled = true;
                }
                else
                {

                    AddProductsToServer();
                }
                ResetToDefault();


            }
        }

        private void BtnExportProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnExportProducts.Checked)
            {
                CheckedIsSelected("ExportProducts");
            }
        }

        private void BtnImportProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnImportProducts.Checked)
            {
                CheckedIsSelected("ImportProducts");
            }
        }

        private void BtnOpenPath_Click(object sender, EventArgs e)
        {
            if ((BtnExportProducts.Checked == false) & (BtnImportProducts.Checked == false))
            {
                MessageBox.Show("please select one of the options above");
                return;
            }
            if (BtnExportProducts.Checked)
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
                    Title = "Select Products CSV file"
                })
                {
                    if (_openFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string filePath = _openFileDialog.FileName;
                    txtNewPth.Text = filePath;

                    using (var reader = new StreamReader(filePath, Encoding.Default))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CTB_Products>().ToList();

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

        private async Task ExportProductsData()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                await Task.Run(() =>
                {


                    DataTable ResultOfData = new DataTable();
                    ResultOfData = operationsofProducts.Get_AllProduct();

                    if (ResultOfData.Rows.Count > 0)
                    {
                        string strPath = txtNewPth.Text.Trim();
                        string csvFilePath = Path.Combine(strPath, "ALKAMOUS Products.CSV");

                        int TotalRows = ResultOfData.Rows.Count;

                        csvDataList = ResultOfData.ConvertDataTableToList<CTB_Products>();


                        using (var fileStream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write))
                        {
                            using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                            {
                                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                                {

                                    csv.WriteRecords(csvDataList);

                                }
                                MessageBox.Show($"{TotalRows} Products has been Export successfully", "Info");

                            }
                        }
                        Debug.WriteLine("Total Rows " + TotalRows);
                    }
                    else
                    {
                        MessageBox.Show($" NO Products Export !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                });
                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                Debug.WriteLine($"Time elapsed: {elapsedTime.TotalMilliseconds} ms");
            }
            catch (Exception ex)
            {

                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        private void AddProductsToServer()
        {
            try
            {
                if (csvDataList != null)
                {
                    int totalProducts = csvDataList.Count; ;
                    int importedProducts = 0;

                    foreach (var _Products in csvDataList)
                    {
                        if (!operationsofProducts.Check_ProductIdNotDuplicate(_Products.product_Id))
                        {
                            operationsofProducts.Add_Product(_Products);
                            importedProducts++;
                        }
                    }
                    MessageBox.Show($"{importedProducts} Products has been imported successfully from {totalProducts} Products");
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

        private void BtnBackToImportAndExport_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CustomersOptionsImportExportForm"))
                    return;

                chelp.ShowForm(new Frm_CustomersOptionsImportExportForm());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

    }
}
