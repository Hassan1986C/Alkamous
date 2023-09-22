using Alkamous.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_Terms : Form
    {
        ClsOperationsofTerms OperationsofTerms = new ClsOperationsofTerms();
        public static string WhoSendOrderTerms = "Frm_CustomersAddNewInvoices";
        public Frm_Terms()
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

            DGVTerms.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            DGVTerms.RowHeadersVisible = false;
            DGVTerms.Columns[0].Visible = false;


            DGVTerms.Columns[1].HeaderText = "Terms English";
            DGVTerms.Columns[2].HeaderText = "Terms Arabic";

            DGVTerms.Columns[1].Width = (int)(DGVTerms.Width * 0.5);
            DGVTerms.Columns[2].Width = (int)(DGVTerms.Width * 0.5);


            // Set the font and alignment for the first column
            DGVTerms.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12);
            DGVTerms.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Set the font and alignment for the second column
            DGVTerms.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12);
            DGVTerms.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            // Set the wrap mode for the first and second columns
            DGVTerms.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGVTerms.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Set the auto-size mode for the rows to adjust the height based on the text
            DGVTerms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Manually set the height of any rows that exceed the default maximum height
            DGVTerms.RowTemplate.Height = 50; // set a default height for rows



            foreach (DataGridViewRow row in DGVTerms.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    DGVTerms.Rows[row.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }


        private void LoadData(string Search = "..........")
        {
            try
            {
                DataTable ResultOfData = null;
                if (Search == "..........")
                {
                    ResultOfData = OperationsofTerms.Get_AllTerms();
                }
                else
                {
                    ResultOfData = OperationsofTerms.Get_AllTerm_BySearch(Search);
                }

                DGVTerms.DataSource = ResultOfData;
                LbCount.Text = DGVTerms.RowCount.ToString();
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

        private void Frm_Terms_Load(object sender, EventArgs e)
        {
            TxtSearch.Focus();
            LoadData();
            DGVColumnHeaderTextAndWidth();

        }


        private void DGVTerms_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    Model.CTB_Terms MCTB_Terms = new Model.CTB_Terms("ct0r2");
            //    if (WhoSendOrderTerms == "Frm_CustomersAddNewInvoices")
            //    {
            //        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtTerm_En.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_En].Value.ToString();
            //        Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.TxtTerms_Ar.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_Ar].Value.ToString();

            //    }
            //    else
            //    {

            //        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtTerm_En.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_En].Value.ToString();
            //        Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.TxtTerms_Ar.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_Ar].Value.ToString();
            //    }
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
            //    Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void LbCount_Click(object sender, EventArgs e)
        {

        }

        private void AddSelectedTerms()
        {
            try
            {

                Model.CTB_Terms MCTB_Terms = new Model.CTB_Terms("ct0r2");
                if (WhoSendOrderTerms == "Frm_CustomersAddNewInvoices")
                {

                    // normall way by using For with DGVTerms.SelectedRows.Count
                    //for (int i = DGVTerms.SelectedRows.Count; i > 0; i--)
                    //{
                    //    Frm_CustomersAddNewInvoices.dtTermsInvoices.Rows.Add("**", DGVTerms.SelectedRows[i - 1].Cells[MCTB_Terms.Term_En].Value.ToString(),
                    //              DGVTerms.SelectedRows[i - 1].Cells[MCTB_Terms.Term_Ar].Value.ToString());
                    //}

                    foreach (DataGridViewRow row in DGVTerms.SelectedRows.Cast<DataGridViewRow>().Reverse())
                    {
                        Frm_CustomersAddNewInvoices.dtTermsInvoices.Rows.Add("", row.Cells[MCTB_Terms.Term_En].Value.ToString(),
                                                                                 row.Cells[MCTB_Terms.Term_Ar].Value.ToString());

                    }
                    var UpdateLbCountTerms = Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.DGVTermsInvose.Rows.Count.ToString();
                    Frm_CustomersAddNewInvoices.FrmCustomerAddNewInvoices.LbCountTerms.Text = UpdateLbCountTerms;
                }
                else
                {
                    // normall way by using For with DGVTerms.SelectedRows.Count
                    //for (int i = DGVTerms.SelectedRows.Count; i > 0; i--)
                    //{
                    //    Frm_CustomersUpdateInvoices.dtTermsInvoices.Rows.Add("**", DGVTerms.SelectedRows[i - 1].Cells[MCTB_Terms.Term_En].Value.ToString(),
                    //              DGVTerms.SelectedRows[i - 1].Cells[MCTB_Terms.Term_Ar].Value.ToString());
                    //}

                    foreach (DataGridViewRow row in DGVTerms.SelectedRows.Cast<DataGridViewRow>().Reverse())
                    {
                        Frm_CustomersUpdateInvoices.dtTermsInvoices.Rows.Add("", row.Cells[MCTB_Terms.Term_En].Value.ToString(),
                                                                                 row.Cells[MCTB_Terms.Term_Ar].Value.ToString());
                    }
                    var UpdateLbCountTerms = Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.DGVTermsInvose.Rows.Count.ToString();
                    Frm_CustomersUpdateInvoices.FrmCustomersUpdateInvoices.LbCountTerms.Text = UpdateLbCountTerms;
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

        private void BtnAddSelect_Click(object sender, EventArgs e)
        {
            AddSelectedTerms();
        }

        private void BtnUnSelectAll_Click(object sender, EventArgs e)
        {
            DGVTerms.ClearSelection();
        }

    }
}
