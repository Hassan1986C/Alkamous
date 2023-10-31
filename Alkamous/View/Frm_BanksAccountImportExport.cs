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
    public partial class Frm_BanksAccountImportExport : Form
    {
        ClsOperationsofBanks OperationsofBanks = new ClsOperationsofBanks();
        List<CTB_Banks> csvDataList = null;
        public Frm_BanksAccountImportExport()
        {
            InitializeComponent();
            ResetToDefault();
        }

        private void CheckedIsSelected(string WhoSender)
        {
            //directly assign the result
            bool Result = WhoSender == "ExportBanks";

            txtNewPth.Text = "";
            csvDataList = null;

            BtnExportBanksAccount.Checked = Result;
            BtnImportBanksAccount.Checked = !(Result);

            BtnExportBanksAccount.Enabled = !(Result);
            BtnImportBanksAccount.Enabled = (Result);

            BtnSaveConfiguration.Enabled = false;
        }

        private bool CheckInputAndPath()
        {
            if ((BtnExportBanksAccount.Checked == false) & (BtnImportBanksAccount.Checked == false))
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

            BtnExportBanksAccount.Checked = false;
            BtnImportBanksAccount.Checked = false;

            BtnExportBanksAccount.Enabled = true;
            BtnImportBanksAccount.Enabled = true;

            BtnSaveConfiguration.Enabled = false;


        }

        private void BtnExportBanksAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnExportBanksAccount.Checked)
            {
                CheckedIsSelected("ExportBanks");
            }
        }

        private void BtnImportBanksAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnImportBanksAccount.Checked)
            {
                CheckedIsSelected("ImportBanks");
            }
        }

        private void BtnOpenPath_Click(object sender, EventArgs e)
        {
            if ((BtnExportBanksAccount.Checked == false) & (BtnImportBanksAccount.Checked == false))
            {
                MessageBox.Show("please select one of the options above");
                return;
            }
            if (BtnExportBanksAccount.Checked)
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
                    Title = "Select Banks CSV file"
                })
                {
                    if (_openFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string filePath = _openFileDialog.FileName;
                    txtNewPth.Text = filePath;

                    using (var reader = new StreamReader(filePath, Encoding.Default))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        var records = csv.GetRecords<CTB_Banks>().ToList();

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

                if (BtnExportBanksAccount.Checked)
                {
                    ExportBanksData();
                    ResetToDefault();
                }
                else
                {
                    AddBanksToServer();
                    ResetToDefault();
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnResetToDefault_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }

        private void AddBanksToServer()
        {

            try
            {
                if (csvDataList != null)
                {
                    int totalBancks = csvDataList.Count; ;
                    int importedBanks = 0;

                    foreach (var _Banks in csvDataList)
                    {
                        if (!OperationsofBanks.Check_Bank_DefinitionNotDuplicate(_Banks.Bank_Definition))
                        {
                            OperationsofBanks.Add_Acount(_Banks);
                            importedBanks++;
                        }
                    }

                    MessageBox.Show($"{importedBanks} Customers has been imported successfully from {totalBancks} Customers");
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

        private void ExportBanksData()
        {
            try
            {

                DataTable ResultOfData = new DataTable();
                ResultOfData = OperationsofBanks.Get_All();

                if (ResultOfData.Rows.Count > 0)
                {
                    string strPath = txtNewPth.Text.Trim();
                    string csvFilePath = Path.Combine(strPath, "ALKAMOUS Banks Accounts.CSV");

                    int TotalRows = ResultOfData.Rows.Count;


                    csvDataList = new List<CTB_Banks>();

                    for (int i = 0; i < ResultOfData.Rows.Count; i++)
                    {


                        var BanckAccountResult = OperationsofBanks.Get_ByBank_Definition(ResultOfData.Rows[i][1].ToString());

                        var Tempclass = new CTB_Banks
                        {
                            Bank_AutoNumber = BanckAccountResult.Rows[0]["Bank_AutoNumber"].ToString(),
                            Bank_Definition = BanckAccountResult.Rows[0]["Bank_Definition"].ToString(),
                            Bank_Beneficiary_Name = BanckAccountResult.Rows[0]["Bank_Beneficiary_Name"].ToString(),
                            Bank_Bank_Name = BanckAccountResult.Rows[0]["Bank_Bank_Name"].ToString(),
                            Bank_Branch = BanckAccountResult.Rows[0]["Bank_Branch"].ToString(),
                            Bank_Branch_Code = BanckAccountResult.Rows[0]["Bank_Branch_Code"].ToString(),
                            Bank_Bank_Address = BanckAccountResult.Rows[0]["Bank_Bank_Address"].ToString(),
                            Bank_Swift_Code = BanckAccountResult.Rows[0]["Bank_Swift_Code"].ToString(),
                            Bank_Account_Number = BanckAccountResult.Rows[0]["Bank_Account_Number"].ToString(),
                            Bank_IBAN_Number = BanckAccountResult.Rows[0]["Bank_IBAN_Number"].ToString(),
                            Bank_COUNTRY = BanckAccountResult.Rows[0]["Bank_COUNTRY"].ToString(),
                            Bank_Account_currency = BanckAccountResult.Rows[0]["Bank_Account_currency"].ToString(),
                        };

                        csvDataList.Add(Tempclass);

                    }


                    using (var fileStream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write))
                    {
                        using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                        {
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {

                                csv.WriteRecords(csvDataList);

                            }
                            MessageBox.Show($"{TotalRows} Banks has been Export successfully", "Info");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($" NO Banks Export !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
