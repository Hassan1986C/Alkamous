﻿using Alkamous.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomersAddNewInvoices : Form
    {
        #region Declare variables
        ClsOperationsofCustomers OperationsofCustomers = new ClsOperationsofCustomers();
        ClsOperationsofInvoices OperationsofInvoices = new ClsOperationsofInvoices();
        ClsOperationsofConsumable OperationsofConsumable = new ClsOperationsofConsumable();
        ClsOperationsofTermsInvoices OperationsofTermsInvoices = new ClsOperationsofTermsInvoices();


        private static Frm_CustomersAddNewInvoices frmCustomerAddNewInvoices;
        public static DataTable dtProducts = new DataTable();
        public static DataTable dtProductsConsumable = new DataTable();
        public static DataTable dtTermsInvoices = new DataTable();
        #endregion

        // this methode to make a new form same as orgnal from
        public static Frm_CustomersAddNewInvoices FrmCustomerAddNewInvoices
        {
            get { return frmCustomerAddNewInvoices; }
        }

        public ClsOperationsofCustomers OperationsofCustomers1 { get => OperationsofCustomers; set => OperationsofCustomers = value; }

        public Frm_CustomersAddNewInvoices()
        {
            InitializeComponent();
            frmCustomerAddNewInvoices = this;

        }

        #region DGVColumnHeaderTextAndWidth

        private void DGVColumnHeaderTextAndWidthProductes()
        {
            try
            {
                Model.CTB_Products MCTB_Products = new Model.CTB_Products("ct0r2");


                DGVProducts.RowHeadersVisible = false;

                using (dtProducts = new DataTable())
                {
                    dtProducts.Columns.Add(MCTB_Products.product_Id);
                    dtProducts.Columns.Add(MCTB_Products.product_NameEn);
                    dtProducts.Columns.Add(MCTB_Products.product_NameAr);
                    dtProducts.Columns.Add("Invoice_QTY");
                    dtProducts.Columns.Add("Invoice_Unit");
                    dtProducts.Columns.Add(MCTB_Products.product_Price);
                    dtProducts.Columns.Add("Invoice_Amount");

                    DGVProducts.DataSource = dtProducts;
                }


                DGVProducts.Columns[0].HeaderText = "Code";
                DGVProducts.Columns[1].HeaderText = "product En";
                DGVProducts.Columns[2].HeaderText = "product Ar";
                DGVProducts.Columns[3].HeaderText = "QTY";
                DGVProducts.Columns[4].HeaderText = "Unit";
                DGVProducts.Columns[5].HeaderText = "Price";
                DGVProducts.Columns[6].HeaderText = "Amount";


                // Set the font and alignment for the first column                
                DGVProducts.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Set the font and alignment for the second column               
                DGVProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DGVProducts.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGVProducts.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                DGVProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Manually set the height of any rows that exceed the default maximum height
                DGVProducts.RowTemplate.Height = 50; // set a default height for rows

            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVColumnHeaderTextAndWidthProductesConsumable()
        {
            try
            {
                Model.CTB_Products MCTB_Products = new Model.CTB_Products("ct0r2");


                DGVProductsConsumable.RowHeadersVisible = false;

                using (dtProductsConsumable = new DataTable())
                {
                    dtProductsConsumable.Columns.Add(MCTB_Products.product_Id);
                    dtProductsConsumable.Columns.Add(MCTB_Products.product_NameEn);
                    dtProductsConsumable.Columns.Add(MCTB_Products.product_NameAr);
                    dtProductsConsumable.Columns.Add("Invoice_QTY");
                    dtProductsConsumable.Columns.Add("Consumable_Unit");
                    dtProductsConsumable.Columns.Add(MCTB_Products.product_Price);
                    dtProductsConsumable.Columns.Add("Invoice_Amount");

                    DGVProductsConsumable.DataSource = dtProductsConsumable;
                }


                DGVProductsConsumable.Columns[0].HeaderText = "Code";
                DGVProductsConsumable.Columns[1].HeaderText = "product En";
                DGVProductsConsumable.Columns[2].HeaderText = "product Ar";
                DGVProductsConsumable.Columns[3].HeaderText = "QTY";
                DGVProductsConsumable.Columns[4].HeaderText = "Unit";
                DGVProductsConsumable.Columns[5].HeaderText = "Price";
                DGVProductsConsumable.Columns[6].HeaderText = "Amount";


                // Set the font and alignment for the first column                
                DGVProductsConsumable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Set the font and alignment for the second column               
                DGVProductsConsumable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DGVProductsConsumable.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGVProductsConsumable.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                DGVProductsConsumable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Manually set the height of any rows that exceed the default maximum height
                DGVProductsConsumable.RowTemplate.Height = 50; // set a default height for rows

            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVColumnHeaderTextAndWidthTermsInvo()
        {
            Model.CTB_Terms_Invoices MCTB_Terms_Invoices = new Model.CTB_Terms_Invoices("ct0r2");



            using (dtTermsInvoices = new DataTable())
            {
                dtTermsInvoices.Columns.Add(MCTB_Terms_Invoices.Term_Invoice_Number);
                dtTermsInvoices.Columns.Add(MCTB_Terms_Invoices.Term_En);
                dtTermsInvoices.Columns.Add(MCTB_Terms_Invoices.Term_Ar);
                DGVTermsInvose.DataSource = dtTermsInvoices;
            }

            DGVTermsInvose.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            DGVTermsInvose.RowHeadersVisible = false;
            DGVTermsInvose.Columns[0].Visible = false;


            DGVTermsInvose.Columns[1].HeaderText = "Terms English";
            DGVTermsInvose.Columns[2].HeaderText = "Terms Arabic";

            // Set the font and alignment for the first column
            DGVTermsInvose.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12);
            DGVTermsInvose.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Set the font and alignment for the second column
            DGVTermsInvose.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12);
            DGVTermsInvose.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            // Set the wrap mode for the first and second columns
            DGVTermsInvose.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVTermsInvose.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Set the auto-size mode for the rows to adjust the height based on the text
            DGVTermsInvose.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Manually set the height of any rows that exceed the default maximum height
            DGVTermsInvose.RowTemplate.Height = 50; // set a default height for rows


            //DGVTermsInvose.Columns[1].Width = (int)(DGVTermsInvose.Width * 0.5);
            //DGVTermsInvose.Columns[2].Width = (int)(DGVTermsInvose.Width * 0.5);

        }

        #endregion

        #region MoveToNextText and AddQtyAndPriceAndAmountToDG by sender

        private void MoveToNextText(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                TextBox textBox = sender as TextBox;
                if (!(string.IsNullOrEmpty(textBox.Text)))
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                    e.Handled = e.SuppressKeyPress = true;
                }

                //prepare to add the Qty & price & amount to DGVProducts 
                AddQtyAndPriceAndAmountToDGV(textBox.Name);
            }
        }

        private void AddQtyAndPriceAndAmountToDGV(string SenderName)
        {
            //check who sender
            if (SenderName == "TxtProduct_Id" || SenderName == "TxtProduct_NameAr" ||
                SenderName == "TxtProduct_NameEn" || SenderName == "TxtQTY" || SenderName == "TxtProduct_Unit" ||
                SenderName == "TxtProduct_Price" || SenderName == "TxtAmount")
            {
                AddDataToDatagradviweAfterCheck();
            }
            else
            {
                AddDataToDatagradviweAfterCheckConsumable();
            }

        }

        private void AddDataToDatagradviweAfterCheck()
        {

            TxtAmount.Text = Chelp.CalculateAmount(TxtQTY.Text, TxtProduct_Price.Text, TxtCustomer_Currency.Text);

            foreach (var textBox in new[] { TxtProduct_Id, TxtQTY, TxtProduct_Price, TxtAmount })
            {
                if (string.IsNullOrEmpty(textBox.Text) || (textBox.Text == "0") || (textBox.Text == "0.00"))
                {
                    textBox.Focus();
                    return;
                }
            }

            if (TxtAmount.Focused)
            {
                ExchangeAndTaxesToForward();

                AddNewRowsToDataTable();

                DGVProductsChangededReSumTotalAmount();

            }

        }

        private void AddDataToDatagradviweAfterCheckConsumable()
        {

            TxtAmountConsumable.Text = Controller.Chelp.CalculateAmount(TxtQTYConsumable.Text, TxtProduct_PriceConsumable.Text, TxtCustomer_Currency.Text);

            foreach (var textBox in new[] { TxtProduct_IdConsumable, TxtQTYConsumable, TxtProduct_PriceConsumable, TxtAmountConsumable })
            {
                if (string.IsNullOrEmpty(textBox.Text) || (textBox.Text == "0") || (textBox.Text == "0.00"))
                {
                    textBox.Focus();
                    return;
                }
            }

            if (TxtAmountConsumable.Focused)
            {
                ExchangeAndTaxesToForwardConsumable();

                AddNewRowsToDataTableConsumable();

                ClearTextBoxAfterAddedDataToDGVProducts(groupBoxConsumable);
            }

        }

        #endregion

        #region Exchange if select USD or IQD and updated TxtProduct_Price.Text and TxtAmount.Text

        private void ExchangeAndTaxesToForward()
        {
            var (STxtPrice, STxtAmount) = Controller.Chelp.ExchangeAndTaxesToForward(TxtExchange.Text, TxtTaxes.Text,
                  TxtProduct_Price.Text, TxtAmount.Text, TxtQTY.Text, TxtCustomer_Currency.Text);

            TxtProduct_Price.Text = STxtPrice;
            TxtAmount.Text = STxtAmount;
        }

        private void ExchangeAndTaxesToForwardConsumable()
        {
            var (STxtPrice, STxtAmount) = Controller.Chelp.ExchangeAndTaxesToForward(TxtExchange.Text, TxtTaxes.Text,
                  TxtProduct_PriceConsumable.Text, TxtAmountConsumable.Text, TxtQTYConsumable.Text, TxtCustomer_Currency.Text);

            TxtProduct_PriceConsumable.Text = STxtPrice;
            TxtAmountConsumable.Text = STxtAmount;
        }

        #endregion

        #region Update TxtTotalAmount

        private void DGVProductsChangededReSumTotalAmount(bool WhoSendOrder = true)
        {
            if (WhoSendOrder)
            {
                ClearTextBoxAfterAddedDataToDGVProducts(groupBoxAddDataToDGV);
            }

            TxtTotalAmount.Text = Controller.Chelp.DGVProductsChangededReSumTotalAmount(TxtCustomer_Currency.Text, DGVProducts);

        }
        #endregion

        #region Add Products TO DataGridView DGVProducts 

        private void AddNewRowsToDataTable()
        {
            try
            {
                for (int i = 0; i < DGVProducts.Rows.Count; i++)
                {
                    if (DGVProducts.Rows[i].Cells[0].Value.ToString().Trim() == TxtProduct_Id.Text.Trim())
                    {
                        MessageBox.Show("The Product already on the list !!");
                        return;
                    }
                }


                dtProducts.Rows.Add(
                            TxtProduct_Id.Text,
                            TxtProduct_NameEn.Text,
                            TxtProduct_NameAr.Text,
                            TxtQTY.Text,
                            TxtProduct_Unit.Text,
                            TxtProduct_Price.Text,
                            TxtAmount.Text);
                DGVProducts.DataSource = dtProducts;
                LbCountProdects.Text = DGVProducts.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Add Consumable TO DataGridView DGVProductsConsumable

        private void AddNewRowsToDataTableConsumable()
        {
            try
            {
                for (int i = 0; i < DGVProductsConsumable.Rows.Count; i++)
                {
                    if (DGVProductsConsumable.Rows[i].Cells[0].Value.ToString().Trim() == TxtProduct_IdConsumable.Text.Trim())
                    {
                        MessageBox.Show("The Product already on the list !!");
                        return;
                    }
                }


                dtProductsConsumable.Rows.Add(
                            TxtProduct_IdConsumable.Text,
                            TxtProduct_NameEnConsumable.Text,
                            TxtProduct_NameArConsumable.Text,
                            TxtQTYConsumable.Text,
                            TxtProduct_UnitConsumable.Text,
                            TxtProduct_PriceConsumable.Text,
                            TxtAmountConsumable.Text);
                DGVProductsConsumable.DataSource = dtProductsConsumable;
                LbCountProdectsConsumable.Text = DGVProductsConsumable.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Add Terms TO DataGridView DGVTermsInvose 

        private void BtnShowFrm_Terms_Click(object sender, EventArgs e)
        {
            Frm_Terms frm = new Frm_Terms();
            Frm_Terms.WhoSendOrderTerms = "Frm_CustomersAddNewInvoices";
            frm.ShowDialog();
        }

        private void BtnAddToDVG_Click(object sender, EventArgs e)
        {
            AddTermsInvoicesToDGVTermsinv();
        }

        private void AddTermsInvoicesToDGVTermsinv()
        {
            if (!(string.IsNullOrEmpty(TxtTerm_En.Text) && string.IsNullOrEmpty(TxtTerms_Ar.Text)))
            {
                dtTermsInvoices.Columns[1].MaxLength = 5000;
                dtTermsInvoices.Columns[2].MaxLength = 5000;
                dtTermsInvoices.Rows.Add("", TxtTerm_En.Text, TxtTerms_Ar.Text);
                DGVTermsInvose.DataSource = dtTermsInvoices;
                LbCountTerms.Text = DGVTermsInvose.RowCount.ToString();
                TxtTerm_En.Clear();
                TxtTerms_Ar.Clear();
            }
        }

        #endregion

        #region Add BankAcount
        int DataHaveBeenloaded = 0;
        private void Load_ALLBankAccount()
        {
            if (DataHaveBeenloaded == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                Controller.ClsOperationsofBanks bnk = new Controller.ClsOperationsofBanks();
                var result = bnk.Get_All();

                txtSelectAcount.Items.Add("Select No Account Bank");

                for (int i = 0; i < result.Rows.Count; i++)
                {
                    txtSelectAcount.Items.Add(result.Rows[i]["Bank_Definition"]);
                }

                DataHaveBeenloaded++;
                Cursor.Current = Cursors.Default;
            }


        }

        private void txtSelectAcount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataHaveBeenloaded > 0)
            {
                if (txtSelectAcount.SelectedIndex == -1)
                {
                    return;
                }
                Controller.ClsOperationsofBanks bnk = new Controller.ClsOperationsofBanks();
                var SelectResult = txtSelectAcount.SelectedItem.ToString();
                if (SelectResult == "Select No Account Bank")
                {
                    foreach (Control control in groupBoxAcount.Controls)
                    {
                        if (control is TextBox txtBox)
                        {
                            txtBox.Clear();
                        }
                    }
                }
                else
                {
                    var result = bnk.Get_ByBank_Definition(SelectResult);
                    TxtBeneficiary_Name.Text = result.Rows[0]["Bank_Beneficiary_Name"].ToString();
                    TxtBank_Name.Text = result.Rows[0]["Bank_Bank_Name"].ToString();
                    TxtBranch.Text = result.Rows[0]["Bank_Branch"].ToString();
                    TxtBranch_Code.Text = result.Rows[0]["Bank_Branch_Code"].ToString();
                    TxtBank_Address.Text = result.Rows[0]["Bank_Bank_Address"].ToString();
                    TxtSwift_Code.Text = result.Rows[0]["Bank_Swift_Code"].ToString();
                    TxtAccount_Number.Text = result.Rows[0]["Bank_Account_Number"].ToString();
                    TxtIBAN_Number.Text = result.Rows[0]["Bank_IBAN_Number"].ToString();
                    TxtCOUNTRY.Text = result.Rows[0]["Bank_COUNTRY"].ToString();
                }
            }
        }

        #endregion

        #region Add Customer & Invoices & Terms & BankAccount & Consumable TO SQL DBMS

        private bool AddCustomerToDataBaseSQL()
        {

            try
            {

                Model.CTB_Customers MTB_Customers = new Model.CTB_Customers();
                MTB_Customers.Customer_Invoice_Number = TxtCustomer_Invoice.Text;
                MTB_Customers.Customer_Company = TxtCustomer_Company.Text;
                MTB_Customers.Customer_Name = TxtCustomer_Name.Text;
                MTB_Customers.Customer_Mob = TxtCustomer_Mob.Text;
                MTB_Customers.Customer_Email = TxtCustomer_Email.Text;
                MTB_Customers.Customer_Currency = TxtCustomer_Currency.Text;
                MTB_Customers.Customer_ExchangeRate = TxtExchange.Text != "" ? TxtExchange.Text : "0";
                MTB_Customers.Customer_Taxes = TxtTaxes.Text != "" ? TxtTaxes.Text : "0";
                MTB_Customers.Customer_DateTime = TxtCustomer_DateTime.Text;
                MTB_Customers.Customer_Quote_Valid = TxtCustomer_Quote_Valid.Text;
                MTB_Customers.Customer_Payment_Terms = TxtCustomer_Payment_Terms.Text;
                MTB_Customers.Customer_Discount = TxtDiscount.Text;
                MTB_Customers.Customer_BankAccount = txtSelectAcount.SelectedItem.ToString();
                MTB_Customers.Customer_Language = TxtCustomer_Language.Text;
                MTB_Customers.Customer_Note = TXTValOfPaymentInAdv.Text;
                return
                      OperationsofCustomers1.Add_Customer(MTB_Customers);


            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
                return false;
            }

        }



        private void AddInvoicesDetilsToDataBaseSQL()
        {
            try
            {
                if (DGVProducts.RowCount > 0)
                {

                    for (int i = 0; i < DGVProducts.RowCount; i++)
                    {
                        Model.CTB_Invoices cTB_Invoices = new Model.CTB_Invoices();

                        cTB_Invoices.Invoice_Number = TxtCustomer_Invoice.Text;
                        cTB_Invoices.Invoice_product_Id = DGVProducts.Rows[i].Cells[0].Value.ToString();
                        cTB_Invoices.Invoice_Unit = DGVProducts.Rows[i].Cells[4].Value.ToString();
                        cTB_Invoices.Invoice_QTY = DGVProducts.Rows[i].Cells[3].Value.ToString();
                        cTB_Invoices.Invoice_Price = DGVProducts.Rows[i].Cells[5].Value.ToString();
                        cTB_Invoices.Invoice_Amount = DGVProducts.Rows[i].Cells[6].Value.ToString();

                        OperationsofInvoices.Add_NewInvoiceLIST(cTB_Invoices);
                    }

                    OperationsofInvoices.InsertBulk();
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }


        }

        private void AddConsumableDetilsToDataBaseSQL()
        {


            try
            {
                if (DGVProductsConsumable.RowCount > 0)
                {

                    for (int i = 0; i < DGVProductsConsumable.RowCount; i++)
                    {

                        Model.CTB_Consumable cTB_Consumable = new Model.CTB_Consumable();

                        cTB_Consumable.Consumable_Number = TxtCustomer_Invoice.Text;
                        cTB_Consumable.Consumable_product_Id = DGVProductsConsumable.Rows[i].Cells[0].Value.ToString();
                        cTB_Consumable.Consumable_Unit = DGVProductsConsumable.Rows[i].Cells[4].Value.ToString();
                        cTB_Consumable.Consumable_QTY = DGVProductsConsumable.Rows[i].Cells[3].Value.ToString();
                        cTB_Consumable.Consumable_Price = DGVProductsConsumable.Rows[i].Cells[5].Value.ToString();
                        cTB_Consumable.Consumable_Amount = DGVProductsConsumable.Rows[i].Cells[6].Value.ToString();

                        OperationsofConsumable.Add_NewConsumableLIST(cTB_Consumable);
                    }

                    OperationsofConsumable.InsertBulk();
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }


        }

        private void AddTermsDetilsToDataBaseSQL()
        {

            try
            {
                for (int i = 0; i < DGVTermsInvose.Rows.Count; i++)
                {
                    Model.CTB_Terms_Invoices cTB_Terms_Invoices = new Model.CTB_Terms_Invoices();
                    cTB_Terms_Invoices.Term_Invoice_Number = TxtCustomer_Invoice.Text.Trim();
                    cTB_Terms_Invoices.Term_En = DGVTermsInvose.Rows[i].Cells[1].Value.ToString();
                    cTB_Terms_Invoices.Term_Ar = DGVTermsInvose.Rows[i].Cells[2].Value.ToString();
                    OperationsofTermsInvoices.Add_NewTerms_InvoiceLIST(cTB_Terms_Invoices);
                }
                OperationsofTermsInvoices.InsertBulk();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }



        #endregion

        #region Buttons Click

        private void BtnSaveData_Click(object sender, EventArgs e)
        {

            try
            {


                if (CheckDataEntryFileds())
                {
                    if (OperationsofCustomers1.Check_Customer_Invoice_NumberNotDuplicate(TxtCustomer_Invoice.Text))
                    {
                        TxtCustomer_Invoice.Focus();
                        MessageBox.Show($"QUOTATION NO  {TxtCustomer_Invoice.Text}  already exists");
                        return;
                    }


                    var TotalAmount = Convert.ToDecimal(TxtTotalAmount.Text);
                    var Discount = Convert.ToDecimal(TxtDiscount.Text);
                    if (TotalAmount < Discount)
                    {
                        MessageBox.Show($"The Discount {Discount} Bigger than TotalAmount {TotalAmount}");
                        return;
                    }

                    var TotalWithDiscount = TotalAmount - Discount;


                    decimal PaymentInADVANCE = 0;
                    decimal PaymentOnDELIVERY = 0;
                    string InADVANCEPercentage = "";
                    string OnDELIVERYPercentage = "";
                    int PaymentASTermsCostem = int.TryParse(TXTValOfPaymentInAdv.Text, out PaymentASTermsCostem) ? PaymentASTermsCostem : 100;


                    (PaymentInADVANCE, PaymentOnDELIVERY, InADVANCEPercentage, OnDELIVERYPercentage) = Chelp.PaymentTermsSettings(TotalWithDiscount, PaymentASTermsCostem);

                    string TotalWithDiscountwithformate = Chelp.Format_PriceAndAmount(TotalWithDiscount.ToString(), TxtCustomer_Currency.Text);
                    string PaymentInADVANCEwithformate = Chelp.Format_PriceAndAmount(PaymentInADVANCE.ToString(), TxtCustomer_Currency.Text);
                    string PaymentOnDELIVERYwithformate = Chelp.Format_PriceAndAmount(PaymentOnDELIVERY.ToString(), TxtCustomer_Currency.Text);

                    if (TxtCustomer_Payment_Terms.Text == "As per Terms" & PaymentASTermsCostem == 100)
                    {
                        PaymentInADVANCEwithformate = "As per Terms";
                        PaymentOnDELIVERYwithformate = "As per Terms";
                    }

                    var Result = "";
                    Result += $" Save Quotation  {TxtCustomer_Invoice.Text} \n\n";
                    Result += $" Total                =  {TxtTotalAmount.Text} \n";
                    Result += $" Discount         =  {TxtDiscount.Text} \n";
                    Result += $"- - - - - - - - - - - - - - - - - - - - - - - - \n";
                    Result += $"Total Amount  =  {TotalWithDiscountwithformate}  {TxtCustomer_Currency.Text} \n";
                    Result += $"IN ADVANCE    =  {PaymentInADVANCEwithformate} \n";
                    Result += $"ON DELIVERY   =  {PaymentOnDELIVERYwithformate} \n";



                    if (MessageBox.Show(Result, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        Cursor.Current = Cursors.WaitCursor;

                        if (AddCustomerToDataBaseSQL())
                        {

                            AddInvoicesDetilsToDataBaseSQL();

                            AddConsumableDetilsToDataBaseSQL();

                            AddTermsDetilsToDataBaseSQL();

                            Chelp.RegisterUsersActionLogs("Add Quotation", TxtCustomer_Invoice.Text);

                            ClearAllTextAndGroipBoxDataForNew();

                            MessageBox.Show("Data Added Successfully", "Data Saved");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, the data could not be saved successfully.", "Data Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Cursor.Current = Cursors.Default;

                    }

                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowAllProdcts_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Products frm = new Frm_Products();
                Frm_Products.WhoSendOrderProducts = "Frm_CustomersAddNewInvoices";
                Frm_Products.ButtonAskProducts = "BtnShowAllProdcts";
                frm.ShowDialog();
                TxtQTY.Focus();
                TxtQTY.Clear();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowAllProdctsForCounsumables_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Products frm = new Frm_Products();
                Frm_Products.WhoSendOrderProducts = "Frm_CustomersAddNewInvoices";
                Frm_Products.ButtonAskProducts = "BtnShowAllProdctsForCounsumables";
                frm.ShowDialog();
                TxtQTYConsumable.Focus();
                TxtQTYConsumable.Clear();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowAllCustomerInfo_Click(object sender, EventArgs e)
        {
            Frm_CustomerInfoLoad frm = new Frm_CustomerInfoLoad();
            Frm_CustomerInfoLoad.WhoSendOrderProducts = "Frm_CustomersAddNewInvoices";
            frm.ShowDialog();
        }

        private void BtnClearAllData_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure will Clear All temporary Data to prepare a new quotation ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ClearAllTextAndGroipBoxDataForNew();

                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAllTextAndGroipBoxDataForNew()
        {
            try
            {
                foreach (var groupBox in new[] { groupBoxCustomerInfo, groupBoxInvosNumberAndCurrency, groupBoxAddDataToDGV, groupBoxConsumable })
                {
                    foreach (var control in groupBox.Controls)
                    {
                        if (control is TextBox txtBox)
                        {
                            txtBox.Clear();
                        }
                        else if (control is ComboBox comboBox)
                        {
                            comboBox.SelectedIndex = 0;
                        }
                    }

                }

                foreach (var dataTable in new[] { dtProducts, dtProductsConsumable, dtTermsInvoices })
                {
                    dataTable.Clear();
                }
                foreach (var dataGridView in new[] { DGVProducts, DGVProductsConsumable, DGVTermsInvose })
                {
                    dataGridView.Refresh();
                }



                TxtTerm_En.Text = "";
                TxtTerms_Ar.Text = "";

                TxtDiscount.Text = "0";
                tabControlCustomers.SelectedIndex = 0;
                TxtCustomer_Name.Focus();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region ExChangeAndTaxes

        private void TxtCustomer_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrencySettings(TxtCustomer_Currency.Text);
        }

        private void CurrencySettings(string Currency)
        {
            bool boolResult = Currency == "USD" ? false : true;


            switch (Currency)
            {
                case "USD":

                    LbCustomer_Currency.Text = "USD";
                    break;

                case "IQD":

                    LbCustomer_Currency.Text = "IQD";
                    break;

                case "AED":

                    LbCustomer_Currency.Text = "AED";
                    break;

            }


            LbExchange.Visible = boolResult;
            TxtExchange.Visible = boolResult;
            TxtExchange.Clear();

            LBTaxes.Visible = boolResult;
            TxtTaxes.Visible = boolResult;
            TxtTaxes.Clear();

            TxtExchange.Focus();


        }

        private void tabControlCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DGVProducts.RowCount > 0)
            {
                TxtCustomer_Currency.Enabled = false;
                TxtExchange.Enabled = false;
                TxtTaxes.Enabled = false;
            }
            else
            {
                TxtCustomer_Currency.Enabled = true;
                TxtExchange.Enabled = true;
                TxtTaxes.Enabled = true;
            }
        }

        #endregion

        #region KeyPress OnlyNumber and OnlyNumberand with Dot and CountDots


        private void OnlyNumberByKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        public static int CountDots(string text)
        {
            Regex dotRegex = new Regex("\\.");
            MatchCollection matches = dotRegex.Matches(text);
            return matches.Count;
        }

        private void OnlyNumberandDotByKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46)
            {
                TextBox Textsender = (TextBox)sender;
                if (CountDots(Textsender.Text) == 1)
                    e.Handled = true;
            }
        }
        #endregion

        #region DeleteRowFromDGVBySender

        private void BtnDeleteRowTerms_Click(object sender, EventArgs e)
        {
            DeleteRowFromDGVBySender(DGVTermsInvose, dtTermsInvoices);
            LbCountTerms.Text = DGVTermsInvose.RowCount.ToString();
        }

        private void BtnDeleteRowFromDGVProducts_Click(object sender, EventArgs e)
        {
            DeleteRowFromDGVBySender(DGVProducts, dtProducts);
            LbCountProdects.Text = DGVProducts.RowCount.ToString();
            DGVProductsChangededReSumTotalAmount();

        }

        private void BtnDeleteRowFromDGVProductsConsumable_Click(object sender, EventArgs e)
        {
            DeleteRowFromDGVBySender(DGVProductsConsumable, dtProductsConsumable);
            LbCountProdectsConsumable.Text = DGVProductsConsumable.RowCount.ToString();
        }

        private void DeleteRowFromDGVBySender(DataGridView DGVSender, DataTable dt)
        {
            try
            {
                if (DGVSender.RowCount > 0)
                {
                    int rowindex = DGVSender.CurrentRow.Index;
                    dt.Rows.RemoveAt(rowindex);
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Move Rows Up And Down
        private void BtnUpMoveRows_Click(object sender, EventArgs e)
        {

            try
            {
                MoveRowUp(DGVProducts, dtProducts);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDownMoveRows_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowDown(DGVProducts, dtProducts);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnMoveTermRowUp_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowUp(DGVTermsInvose, dtTermsInvoices);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMoveTermRowDown_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowDown(DGVTermsInvose, dtTermsInvoices);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMoveConsumableRowUP_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowUp(DGVProductsConsumable, dtProductsConsumable);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMoveConsumableRowDown_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowDown(DGVProductsConsumable, dtProductsConsumable);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void MoveRowUp(DataGridView dgv, DataTable dt)
        {
            if (dgv.Rows.Count == 0) return;

            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

            if (rowIndex == 0) return;

            DataRow NewRowHolder = dt.NewRow();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                NewRowHolder[i] = dgv.Rows[rowIndex].Cells[i].Value;
            }

            dt.Rows.RemoveAt(rowIndex);
            dt.Rows.InsertAt(NewRowHolder, rowIndex - 1);

            dgv.ClearSelection();
            dgv.Rows[rowIndex - 1].Selected = true;

        }

        private void MoveRowDown(DataGridView dgv, DataTable dt)
        {
            if (dgv.Rows.Count == 0) return;

            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;


            if (rowIndex < dgv.Rows.Count - 1)
            {

                DataRow NewRowHolder = dt.NewRow();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    NewRowHolder[i] = dgv.Rows[rowIndex].Cells[i].Value;
                }

                dt.Rows.RemoveAt(rowIndex);
                dt.Rows.InsertAt(NewRowHolder, rowIndex + 1);

                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Selected = true;
            }
        }
        #endregion



        private void Frm_CustomersAddNewInvoices_Load(object sender, EventArgs e)
        {

            TxtCustomer_Payment_Terms.DisplayMember = "Text";
            TxtCustomer_Payment_Terms.ValueMember = "Value";
            TxtCustomer_Payment_Terms.DataSource = Chelp.LoadDataToComboBox();

            DGVColumnHeaderTextAndWidthProductes();
            DGVColumnHeaderTextAndWidthProductesConsumable();
            DGVColumnHeaderTextAndWidthTermsInvo();
            Load_ALLBankAccount();


            txtSelectAcount.SelectedIndex = 0;
            TxtCustomer_Currency.SelectedIndex = 0;
            TxtCustomer_Language.SelectedIndex = 0;
            TxtCustomer_Payment_Terms.SelectedIndex = 0;
        }

        private void ClearTextBoxAfterAddedDataToDGVProducts(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Clear();
                }
            }
        }

        private bool CheckDataEntryFileds()
        {
            if (string.IsNullOrEmpty(TxtCustomer_Name.Text))
            {

                tabControlCustomers.SelectedIndex = 0;
                TxtCustomer_Name.Focus();
                MessageBox.Show("Customer Name required", "Message");

                return false;
            }
            else if (string.IsNullOrEmpty(TxtCustomer_Invoice.Text))
            {
                tabControlCustomers.SelectedIndex = 0;
                TxtCustomer_Invoice.Focus();
                MessageBox.Show("Customer Invoice No required", "Message");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtCustomer_Quote_Valid.Text))
            {
                tabControlCustomers.SelectedIndex = 0;
                TxtCustomer_Quote_Valid.Focus();
                MessageBox.Show("Customer Quote Valid required", "Message");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtCustomer_Payment_Terms.Text))
            {
                tabControlCustomers.SelectedIndex = 0;
                TxtCustomer_Payment_Terms.Focus();
                MessageBox.Show("Payment Terms required", "Message");
                return false;
            }
            else if (TxtCustomer_Currency.Text == "IQD")
            {
                if (string.IsNullOrEmpty(TxtExchange.Text))
                {
                    tabControlCustomers.SelectedIndex = 0;
                    TxtExchange.Focus();
                    MessageBox.Show("EX change required", "Message");
                    return false;
                }
            }
            else if (DGVProducts.RowCount == 0)
            {
                tabControlCustomers.SelectedIndex = 1;
                MessageBox.Show("Insert One Products to Invoice it is required", "Message");
                return false;
            }
            else if (DGVTermsInvose.RowCount == 0)
            {
                string MyMessage = "Do you want to Save without terms";
                if (MessageBox.Show(MyMessage, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    tabControlCustomers.SelectedIndex = 3;
                    return false;
                }

            }

            return true;
        }

        private void DGVProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVProducts.RowCount > 0)
                {

                    TxtProduct_Id.Text = DGVProducts.CurrentRow.Cells["product_Id"].Value.ToString();
                    TxtProduct_NameEn.Text = DGVProducts.CurrentRow.Cells["product_NameEn"].Value.ToString();
                    TxtProduct_NameAr.Text = DGVProducts.CurrentRow.Cells["product_NameAr"].Value.ToString();
                    TxtProduct_Unit.Text = DGVProducts.CurrentRow.Cells["Invoice_Unit"].Value.ToString();
                    DeleteRowFromDGVBySender(DGVProducts, dtProducts);
                    LbCountProdects.Text = DGVProducts.RowCount.ToString();
                    DGVProductsChangededReSumTotalAmount(false);
                    TxtQTY.Focus();
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVProductsConsumable_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVProductsConsumable.RowCount > 0)
                {

                    TxtProduct_IdConsumable.Text = DGVProductsConsumable.CurrentRow.Cells[0].Value.ToString();
                    TxtProduct_NameEnConsumable.Text = DGVProductsConsumable.CurrentRow.Cells[1].Value.ToString();
                    TxtProduct_NameArConsumable.Text = DGVProductsConsumable.CurrentRow.Cells[2].Value.ToString();
                    TxtProduct_UnitConsumable.Text = DGVProductsConsumable.CurrentRow.Cells[4].Value.ToString();
                    DeleteRowFromDGVBySender(DGVProductsConsumable, dtProductsConsumable);
                    LbCountProdectsConsumable.Text = DGVProductsConsumable.RowCount.ToString();
                    TxtQTYConsumable.Focus();
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Controller.Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVTermsInvose_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGVTermsInvose.RowCount > 0)
                {

                    TxtTerm_En.Text = DGVTermsInvose.CurrentRow.Cells[1].Value.ToString();
                    TxtTerms_Ar.Text = DGVTermsInvose.CurrentRow.Cells[2].Value.ToString();

                    DeleteRowFromDGVBySender(DGVTermsInvose, dtTermsInvoices);
                    LbCountTerms.Text = DGVTermsInvose.RowCount.ToString();

                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtExchange_Validated(object sender, EventArgs e)
        {
            TxtExchange.Text = Chelp.Format_PriceAndAmount(TxtExchange.Text, TxtCustomer_Currency.Text);
        }

        private void TxtDiscount_Validated(object sender, EventArgs e)
        {
            TxtDiscount.Text = Chelp.Format_PriceAndAmount(TxtDiscount.Text, TxtCustomer_Currency.Text);
        }

        private void TxtCustomer_Payment_Terms_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTValOfPaymentInAdv.Text = TxtCustomer_Payment_Terms.SelectedValue.ToString();
            Payment_TermsSettings(TxtCustomer_Payment_Terms.Text);
        }

        private void Payment_TermsSettings(string Payment_Terms)
        {
            bool boolResult = Payment_Terms == "As per Terms" ? true : false;
            LBAsPerTerms.Visible = boolResult;
            TXTValOfPaymentInAdv.Visible = boolResult;
            if (boolResult)
            {
                TXTValOfPaymentInAdv.Clear();
                TXTValOfPaymentInAdv.Focus();
            }

        }


        private bool CheckFormBeforeClosing()
        {
            if (groupBoxCustomerInfo.Controls.OfType<TextBox>().Any(txtBox => !string.IsNullOrEmpty(txtBox.Text)))
                return true;

            if (new[] { dtProducts, dtProductsConsumable, dtTermsInvoices }.Any(dataTable => dataTable.Rows.Count > 0))
                return true;

            if (new[] { DGVProducts, DGVProductsConsumable, DGVTermsInvose }.Any(dataGridView => dataGridView.Rows.Count > 0))
                return true;

            return false;
        }

        private void Frm_CustomersAddNewInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckFormBeforeClosing())
            {
                if (MessageBox.Show("Do you want to exit, you will lose your temporary data ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}