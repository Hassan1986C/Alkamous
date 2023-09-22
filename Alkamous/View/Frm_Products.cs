using Alkamous.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_Products : Form
    {
        ClsOperationsofProducts OperationsofProducts = new ClsOperationsofProducts();
        public static string WhoSendOrderProducts = "Frm_CustomersAddNewInvoices";
        public static string ButtonAskProducts = "BtnShowAllProdcts";
        public Frm_Products()
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



        private void ReColoreDGV(DataGridView dataGridView)
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    dataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void DGVColumnHeaderTextAndWidth()
        {

            DGVProducts.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 4, 0, 4);
            //DGVProducts.EnableHeadersVisualStyles = false;
            //DGVProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            //DGVProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            DGVProducts.RowHeadersVisible = false;
            DGVProducts.Columns[0].HeaderText = "invoice No";
            DGVProducts.Columns[1].HeaderText = "Product Name English";
            DGVProducts.Columns[2].HeaderText = "Product Name Arabic";
            DGVProducts.Columns[3].HeaderText = "pric";
            DGVProducts.Columns[4].HeaderText = "Unit";

            DGVProducts.Columns[0].Width = 25;
            DGVProducts.Columns[1].Width = 60;
            DGVProducts.Columns[2].Width = 60;
            DGVProducts.Columns[3].Width = 15;
            DGVProducts.Columns[4].Width = 60;

            DGVProducts.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGVProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void LoadData(string Search = "..........")
        {
            try
            {
                DataTable ResultOfData = null;
                if (Search == "..........")
                {
                    ResultOfData = OperationsofProducts.Get_AllProduct(1, 5000);
                }
                else
                {
                    ResultOfData = OperationsofProducts.Get_AllProduct_BySearch(Search, 1, 5000);
                }

                DGVProducts.DataSource = ResultOfData;
                ReColoreDGV(DGVProducts);
                LbCount.Text = DGVProducts.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }

        private void Frm_Products_Load(object sender, EventArgs e)
        {

            LoadData();
            DGVColumnHeaderTextAndWidth();


        }

        private void DGVProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Model.CTB_Products MCTB_Products = new Model.CTB_Products("ct0r2");
                if (WhoSendOrderProducts == "Frm_CustomersAddNewInvoices")
                {

                    if (ButtonAskProducts == "BtnShowAllProdcts")
                    {
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_Id.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_NameEn.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_NameAr.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_Price.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Price].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_Unit.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Unit].Value.ToString();
                    }
                    else
                    {
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_IdConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_NameEnConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_NameArConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_PriceConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Price].Value.ToString();
                        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtProduct_UnitConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Unit].Value.ToString();

                    }

                }
                else
                {

                    if (ButtonAskProducts == "BtnShowAllProdcts")
                    {
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_Id.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_NameEn.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_NameAr.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_Price.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Price].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_Unit.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Unit].Value.ToString();
                    }
                    else
                    {
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_IdConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_NameEnConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_NameArConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_PriceConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Price].Value.ToString();
                        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtProduct_UnitConsumable.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Unit].Value.ToString();
                    }

                }
                Close();
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
