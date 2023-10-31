using Alkamous.Controller;
using Alkamous.Model;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomerInfoImportExport : Form
    {

        ClsOperationsofCustomerInfo operationsofCustomerInfo = new ClsOperationsofCustomerInfo();
        List<CTB_CustomerInfo> csvDataList = null;

        public Frm_CustomerInfoImportExport()
        {
            InitializeComponent();
            ResetToDefault();
        }

        private void CheckedIsSelected(string WhoSender)
        {
            //directly assign the result
            bool Result = WhoSender == "ExportCustomers";

            txtNewPth.Text = "";
            csvDataList = null;

            BtnExportCustomers.Checked = Result;
            BtnImportCustomers.Checked = !(Result);

            BtnExportCustomers.Enabled = !(Result);
            BtnImportCustomers.Enabled = (Result);

            BtnSaveConfiguration.Enabled = false;
        }

        private bool CheckInputAndPath()
        {
            if ((BtnExportCustomers.Checked == false) & (BtnImportCustomers.Checked == false))
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

            BtnExportCustomers.Checked = false;
            BtnImportCustomers.Checked = false;

            BtnExportCustomers.Enabled = true;
            BtnImportCustomers.Enabled = true;

            BtnSaveConfiguration.Enabled = false;


        }

        private void BtnExportCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnExportCustomers.Checked)
            {
                CheckedIsSelected("ExportCustomers");
            }
        }

        private void BtnImportCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnImportCustomers.Checked)
            {
                CheckedIsSelected("ImportCustomers");
            }
        }

        private void BtnOpenPath_Click(object sender, EventArgs e)
        {
            if ((BtnExportCustomers.Checked == false) & (BtnImportCustomers.Checked == false))
            {
                MessageBox.Show("please select one of the options above");
                return;
            }
            if (BtnExportCustomers.Checked)
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
                    Title = "Select Customers CSV file"
                })
                {
                    if (_openFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string filePath = _openFileDialog.FileName;
                    txtNewPth.Text = filePath;

                    using (var reader = new StreamReader(filePath, Encoding.Default))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CTB_CustomerInfo>().ToList();

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

        private void BtnSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (CheckInputAndPath())
            {
                Cursor.Current = Cursors.WaitCursor;

                if (BtnExportCustomers.Checked)
                {
                    ExportCustomersData();
                    ResetToDefault();
                }
                else
                {
                    AddCustomersToServer();
                    ResetToDefault();
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnResetToDefault_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }


        private void AddCustomersToServer()
        {

            try
            {
                if (csvDataList != null)
                {
                    int totalCustomers = csvDataList.Count; ;
                    int importedCustomers = 0;

                    foreach (var _Customers in csvDataList)
                    {
                        if (!operationsofCustomerInfo.Check_CustomerInfo_NotDuplicate(_Customers.Customer_Mob))
                        {
                            operationsofCustomerInfo.Add_CustomerInfo(_Customers);
                            importedCustomers++;
                        }
                    }

                    MessageBox.Show($"{importedCustomers} Customers has been imported successfully from {totalCustomers} Customers");
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

        private void ExportCustomersData()
        {
            try
            {

                DataTable ResultOfData = new DataTable();
                ResultOfData = operationsofCustomerInfo.Get_All();

                if (ResultOfData.Rows.Count > 0)
                {
                    string strPath = txtNewPth.Text.Trim();
                    string csvFilePath = Path.Combine(strPath, "ALKAMOUS Customers.CSV");

                    int TotalRows = ResultOfData.Rows.Count;

                    csvDataList = ResultOfData.ConvertDataTableToList<CTB_CustomerInfo>();


                    using (var fileStream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write))
                    {
                        using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                        {
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {

                                csv.WriteRecords(csvDataList);

                            }
                            MessageBox.Show($"{TotalRows} Customers has been Export successfully", "Info");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($" NO Customers Export !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
