using Alkamous.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomerInfoLoad : Form
    {
        ClsOperationsofCustomerInfo OperationsofCustomerInfo = new ClsOperationsofCustomerInfo();
        public static string WhoSendOrderProducts = "Frm_CustomersAddNewInvoices";

        public Frm_CustomerInfoLoad()
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

        private void DGVColumnHeaderTextAndWidth()
        {

            DGVCustomerInfo.RowHeadersVisible = false;
            DGVCustomerInfo.Columns[0].Visible = false;
            DGVCustomerInfo.Columns[1].HeaderText = "Company";
            DGVCustomerInfo.Columns[2].HeaderText = "Name ";
            DGVCustomerInfo.Columns[3].HeaderText = "Mobil";
            DGVCustomerInfo.Columns[4].HeaderText = "Email";


            DGVCustomerInfo.Columns[1].Width = 75;
            DGVCustomerInfo.Columns[2].Width = 75;
            DGVCustomerInfo.Columns[3].Width = 75;
            DGVCustomerInfo.Columns[4].Width = 100;

            foreach (DataGridViewRow row in DGVCustomerInfo.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    DGVCustomerInfo.Rows[row.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }


        #region LoadData And Search

        private void LoadData(string Search = "..........")
        {
            try
            {
                DataTable ResultOfData = null;
                if (Search == "..........")
                {
                    ResultOfData = OperationsofCustomerInfo.Get_All();
                }
                else
                {
                    ResultOfData = OperationsofCustomerInfo.Get_BySearch(Search);
                }

                DGVCustomerInfo.DataSource = ResultOfData;
                DGVCustomerInfo.AutoGenerateColumns = true;
                LbCount.Text = DGVCustomerInfo.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_CustomerInfoLoad_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVColumnHeaderTextAndWidth();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }


        #endregion

        private void DGVCustomerInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (WhoSendOrderProducts == "Frm_CustomersAddNewInvoices")
                {

                    Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtCustomer_Company.Text = DGVCustomerInfo.CurrentRow.Cells[1].Value.ToString();
                    Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtCustomer_Name.Text = DGVCustomerInfo.CurrentRow.Cells[2].Value.ToString();
                    Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtCustomer_Email.Text = DGVCustomerInfo.CurrentRow.Cells[4].Value.ToString();
                    Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtCustomer_Mob.Text = DGVCustomerInfo.CurrentRow.Cells[3].Value.ToString();

                }
                else
                {

                    Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtCustomer_Company.Text = DGVCustomerInfo.CurrentRow.Cells[1].Value.ToString();
                    Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtCustomer_Name.Text = DGVCustomerInfo.CurrentRow.Cells[2].Value.ToString();
                    Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtCustomer_Email.Text = DGVCustomerInfo.CurrentRow.Cells[4].Value.ToString();
                    Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtCustomer_Mob.Text = DGVCustomerInfo.CurrentRow.Cells[3].Value.ToString();

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
