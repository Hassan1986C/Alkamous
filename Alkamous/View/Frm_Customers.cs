using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_Customers : Form
    {
        #region
        Controller.ClsOperationsofCustomers OperationsofCustomers = new Controller.ClsOperationsofCustomers();
        Controller.ClsOperationsofInvoices OperationsofInvoices = new Controller.ClsOperationsofInvoices();
        Controller.ClsOperationsofConsumable OperationsofConsumable = new Controller.ClsOperationsofConsumable();
        Controller.ClsOperationsofTermsInvoices OperationsofTermsInvoices = new Controller.ClsOperationsofTermsInvoices();
        Controller.ClsOperationsofBanks OperationsofBanks = new Controller.ClsOperationsofBanks();
        Model.CTB_Invoices MCTB_Invoices = new Model.CTB_Invoices();
        Controller.CLSExportDataToWordFile CLSExportDataToWordFile = new Controller.CLSExportDataToWordFile();

        DataTable dt = new DataTable();
        private static Frm_Customers frmCustomer;
        #endregion

        public static Frm_Customers FrmCustomer  // this methode to make a new form same as orgnal from
        {
            get { return frmCustomer; }
        }

        public Frm_Customers()
        {
            InitializeComponent();
            frmCustomer = this;

        }

        private void Frm_Customers_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVCustomers.RowHeadersVisible = false;
        }

        #region LoadData And Search

        private void LoadData(string Search = "..........")
        {
            try
            {
                DataTable ResultOfData = null;
                if (Search == "..........")
                {
                    ResultOfData = OperationsofCustomers.Get_AllCustomer();
                }
                else
                {
                    ResultOfData = OperationsofCustomers.Get_AllCustomer_BySearch(Search, 1, 5000);
                }

                DGVCustomers.DataSource = ResultOfData;
                DGVCustomers.AutoGenerateColumns = true;
                LbCount.Text = DGVCustomers.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }

        #endregion

        private void BtnShowQuotationReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCustomers.RowCount > 0)
                {
                    MessageBox.Show("optional consumable not supported yet On PDF ");
                    Model.CTB_Customers MCTB_Customers = new Model.CTB_Customers("ct0r2");
                    string InvosNO = DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString();
                    ShowReport(InvosNO);

                }
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Controller.Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteRowFromDGVProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCustomers.RowCount > 0)
                {
                    Model.CTB_Customers MCTB_Customers = new Model.CTB_Customers("ct0r2");
                    if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                        + Environment.NewLine + "Invoice Number    : " + DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString()
                        + Environment.NewLine + "Name   : " + DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Name].Value.ToString()

                        , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        bool Result = OperationsofCustomers.Delete_CustomerData(DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString());
                        if (Result)
                        {
                            OperationsofInvoices.Delete_InvoiceByInvoice_Number(DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString());
                            OperationsofConsumable.Delete_ConsumableByConsumable_Number(DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString());
                            OperationsofTermsInvoices.Delete_Terms_Invoice(DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString());

                            Controller.Chelp.RegisterUsersActionLogs("Delete Quotation", DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString());
                            MessageBox.Show("Data Deleted Successfully ");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, there is a mistake !!");
                        }
                        Cursor.Current = Cursors.Default;
                    }

                }
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Controller.Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCustomers.RowCount > 0)
                {
                    Model.CTB_Customers MCTB_Customers = new Model.CTB_Customers("ct0r2");
                    Frm_CustomersUpdateInvoices.Invoice_NumberToGetData = DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString();

                    Controller.Chelp chelp = new Controller.Chelp();
                    chelp.ShowForm(new Frm_CustomersUpdateInvoices());
                }
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Controller.Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        #region ShowReport

        private void ShowReport(string InvoiceNumber)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                LocalDataSet.DataSetForReport dtSet = new LocalDataSet.DataSetForReport();

                #region Customer

                DataTable dtTB_CustomerReport = new DataTable();
                dtTB_CustomerReport = OperationsofCustomers.Get_CustomerDetails_ByCustomer_Invoice_Number(InvoiceNumber);

                string MyCurrency = dtTB_CustomerReport.Rows[0]["Customer_Currency"].ToString();
                string MyAccountBankSelected = dtTB_CustomerReport.Rows[0]["Customer_BankAccount"].ToString();
                string MyDiscount = dtTB_CustomerReport.Rows[0]["Customer_Discount"].ToString();
                string MyInvoice_Number = dtTB_CustomerReport.Rows[0]["Customer_Invoice_Number"].ToString();
                string MyCompanyName = dtTB_CustomerReport.Rows[0]["Customer_Company"].ToString();
                string MyCustomerName = dtTB_CustomerReport.Rows[0]["Customer_Name"].ToString();

                string PDFName = $"Quotation #{MyInvoice_Number} For {(MyCompanyName != "" ? MyCompanyName : MyCustomerName)}.pdf";
                //Quotation #  2020331 Primacy Duplex - Melli iran bank
                dtSet.TB_Customers.Rows.Add(
                dtTB_CustomerReport.Rows[0]["Customer_AutoNum"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Invoice_Number"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Company"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Name"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Mob"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Email"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Currency"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_DateTime"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Quote_Valid"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Payment_Terms"].ToString(),
                dtTB_CustomerReport.Rows[0]["Customer_Discount"].ToString()
                );

                #endregion

                #region Invoices
                DataTable dtTB_InvoicesReport = new DataTable();
                dtTB_InvoicesReport = OperationsofInvoices.Get_Invoice_ByInvoice_Number(InvoiceNumber);



                Decimal Total = 0;
                for (int i = 0; i < dtTB_InvoicesReport.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dtTB_InvoicesReport.Rows[i]["Invoice_Amount"]);
                }

                Decimal TotalAmount = 0;

                TotalAmount = Total - Convert.ToDecimal(MyDiscount);

                List<Controller.CurrencyInfo> currencies = new List<Controller.CurrencyInfo>();
                currencies.Add(new Controller.CurrencyInfo(Controller.CurrencyInfo.Currencies.Dollar));
                currencies.Add(new Controller.CurrencyInfo(Controller.CurrencyInfo.Currencies.IRAQ));

                int SelectUSDORIQD = MyCurrency == "USD" ? 0 : 1;

                Controller.ToWord TotalAmountToWord = new Controller.ToWord(TotalAmount, currencies[SelectUSDORIQD]);

                for (int i = 0; i < dtTB_InvoicesReport.Rows.Count; i++)
                {
                    dtSet.TB_Invoices.Rows.Add(dtTB_InvoicesReport.Rows[i]["product_Id"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["product_NameEn"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["product_NameAr"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["Invoice_QTY"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["Invoice_Unit"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["Invoice_Price"].ToString(),
                                               dtTB_InvoicesReport.Rows[i]["Invoice_Amount"].ToString(),
                                               Controller.Chelp.Format_PriceAndAmount(Total.ToString(), MyCurrency),
                                               Controller.Chelp.Format_PriceAndAmount(TotalAmount.ToString(), MyCurrency),
                                               TotalAmountToWord.ConvertToEnglish()
                                               );
                }

                #endregion

                #region Terms

                DataTable dtTB_Terms_InvoicesReport = new DataTable();
                dtTB_Terms_InvoicesReport = OperationsofTermsInvoices.Get_AllTerms_Invoice_ByTerm_Invoice_Number(InvoiceNumber);

                StringBuilder builderEN = new StringBuilder();
                StringBuilder builderAR = new StringBuilder();
                if (dtTB_Terms_InvoicesReport.Rows.Count > 0)
                {
                    builderEN.Append("Terms").Append(Environment.NewLine);
                    builderAR.Append("الشروط").Append(Environment.NewLine);

                    for (int i = 0; i < dtTB_Terms_InvoicesReport.Rows.Count; i++)
                    {
                        builderEN.Append("  -  ").
                                Append(dtTB_Terms_InvoicesReport.Rows[i]["Term_En"].ToString()).
                                Append(Environment.NewLine);

                        builderAR.Append("  -  ").
                                  Append(dtTB_Terms_InvoicesReport.Rows[i]["Term_Ar"].ToString()).
                                  Append(Environment.NewLine);
                    }
                }
                dtSet.TB_Terms_Invoices.Rows.Add(InvoiceNumber, builderEN, builderAR);

                #endregion

                #region Bank

                DataTable dtTB_BankAccountReport = new DataTable();

                var SelectResult = MyAccountBankSelected;
                if (SelectResult != "Select No Account Bank")
                {
                    dtTB_BankAccountReport = OperationsofBanks.Get_ByBank_Definition(SelectResult);

                    dtSet.TB_BANKAccount.Rows.Add(
                    dtTB_BankAccountReport.Rows[0]["Bank_Definition"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Beneficiary_Name"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Bank_Name"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Branch"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Branch_Code"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Bank_Address"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Swift_Code"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Account_Number"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_IBAN_Number"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_COUNTRY"].ToString(),
                    dtTB_BankAccountReport.Rows[0]["Bank_Account_currency"].ToString()
                    );
                }

                #endregion

                #region Frm_ReportViewerHoder and CustomersInvoiceReport

                Reports.Frm_ReportViewerHoder frm = new Reports.Frm_ReportViewerHoder();
                Reports.CustomersInvoiceReport repot = new Reports.CustomersInvoiceReport();

                repot.SetDataSource(dtSet);

                //  مصدر التقرير من الداتاسيت التي تم تعبة بياناتها من الداتا تيبل
                frm.crystalReportViewer1.ReportSource = repot;  // repot هو التقرير نخسة منه
                frm.crystalReportViewer1.Refresh(); // تحديث التقرير

                // this to send repot and file name to Frm_ReportViewerHoder
                Reports.Frm_ReportViewerHoder.reportDocument = repot;
                Reports.Frm_ReportViewerHoder.FileNameOfPDF = PDFName;

                frm.ShowDialog();

                #endregion

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        private void DGVCustomers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVCustomers.RowCount > 0)
                {
                    Model.CTB_Customers MCTB_Customers = new Model.CTB_Customers("ct0r2");
                    string InvosNO = DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString();
                    ShowReport(InvosNO);

                }
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Controller.Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExportAsWordFile_Click(object sender, EventArgs e)
        {
            if (DGVCustomers.RowCount > 0)
            {
                Model.CTB_Customers MCTB_Customers = new Model.CTB_Customers("ct0r2");
                string InvosNO = DGVCustomers.CurrentRow.Cells[MCTB_Customers.Customer_Invoice_Number].Value.ToString();
                               

                CLSExportDataToWordFile.ExportDataToWord(InvosNO);

               
            }
        }
    }
}
