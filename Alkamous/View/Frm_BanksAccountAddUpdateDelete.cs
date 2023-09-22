using Alkamous.Controller;
using Alkamous.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_BanksAccountAddUpdateDelete : Form
    {

        CTB_Banks MTB_Banks = new CTB_Banks();
        ClsOperationsofBanks clsOperationsofBanks = new ClsOperationsofBanks();

        public Frm_BanksAccountAddUpdateDelete()
        {
            InitializeComponent();
        }

        private void DGVColumnHeaderTextAndWidth()
        {

            DGVBanks.Columns[0].HeaderText = "AutoNumber";
            DGVBanks.Columns[1].HeaderText = "Definition";
            DGVBanks.Columns[2].HeaderText = "Bank_Name";
            DGVBanks.Columns[3].HeaderText = "Currency";

            DGVBanks.RowHeadersVisible = false;
            DGVBanks.Columns[0].Visible = false;

            DGVBanks.Columns[1].Width = 100;
            DGVBanks.Columns[2].Width = 100;
            DGVBanks.Columns[3].Width = 100;


            foreach (DataGridViewRow row in DGVBanks.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    DGVBanks.Rows[row.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }


        private bool CheckDataInpute()
        {

            foreach (Control item in groupBoxAcount.Controls)
            {
                if (item is TextBox text)
                {
                    if (string.IsNullOrEmpty(text.Text))
                    {
                        text.Focus();
                        MessageBox.Show("all the fields required");
                        return false;
                    }
                }

            }
            if (string.IsNullOrEmpty(TxtCurrency.Text))
            {

                MessageBox.Show("the Currency is required");
                return false;
            }

            return true;
        }

        private void DataFilling()
        {

            MTB_Banks.Bank_Definition = TxtBank_Definition.Text;
            MTB_Banks.Bank_Beneficiary_Name = TxtBeneficiary_Name.Text;
            MTB_Banks.Bank_Bank_Name = TxtBank_Name.Text;
            MTB_Banks.Bank_Branch = TxtBranch.Text;
            MTB_Banks.Bank_Branch_Code = TxtBranch_Code.Text;
            MTB_Banks.Bank_Bank_Address = TxtBank_Address.Text;
            MTB_Banks.Bank_Swift_Code = TxtSwift_Code.Text;
            MTB_Banks.Bank_Account_Number = TxtAccount_Number.Text;
            MTB_Banks.Bank_IBAN_Number = TxtIBAN_Number.Text;
            MTB_Banks.Bank_COUNTRY = TxtCOUNTRY.Text;
            MTB_Banks.Bank_Account_currency = TxtCurrency.Text;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (clsOperationsofBanks.Check_Bank_DefinitionNotDuplicate(TxtBank_Definition.Text))
            {
                MessageBox.Show("this Definition already exist ");
                return;
            }

            if (!CheckDataInpute())
            {
                return;
            }

            DataFilling();
            var result = MessageBox.Show("Do you want add this Definition", " Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            if (result)
            {
                if (clsOperationsofBanks.Add_Acount(MTB_Banks))
                {

                    Chelp.RegisterUsersActionLogs("Add New Account", $"{TxtBank_Name.Text}");
                    LoadData();
                    MessageBox.Show("Added");
                    ClearAllTextBox();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void ClearAllTextBox()
        {
            foreach (Control control in groupBoxAcount.Controls)
            {
                if (control is TextBox txtBox)
                {
                    txtBox.Clear();
                }
            }
        }

        private void CheckWhoSendOrder(bool sender)
        {
            BtnEdit.Enabled = sender;
            BtnCancelEdit.Visible = sender;
            BtnAdd.Visible = (!sender);
            BtnDelete.Visible = (!sender);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DataFilling();
            if (clsOperationsofBanks.Update_Acount(MTB_Banks))
            {

                Chelp.RegisterUsersActionLogs("Update Account", $"{TxtBank_Name.Text}");
                LoadData();
                MessageBox.Show("update");
                ClearAllTextBox();
                CheckWhoSendOrder(false);

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                + Environment.NewLine + DGVBanks.CurrentRow.Cells["Bank_Definition"].Value.ToString()
                + Environment.NewLine + "currency   : " + DGVBanks.CurrentRow.Cells["Bank_Account_currency"].Value.ToString()
                , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                string txtAccount = DGVBanks.CurrentRow.Cells[1].Value.ToString();
                bool Result = clsOperationsofBanks.Delete_Acount(DGVBanks.CurrentRow.Cells["Bank_Definition"].Value.ToString());
                if (Result)
                {
                    Chelp.RegisterUsersActionLogs("Delete Account", txtAccount);
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }

        private void LoadData(string Search = "..........")
        {
            try
            {

                DataTable ResultOfData = null;
                if (Search == "..........")
                {
                    ResultOfData = clsOperationsofBanks.Get_All();
                }
                else
                {
                    ResultOfData = clsOperationsofBanks.Get_BySearch(Search);

                }
                if (ResultOfData != null)
                {

                    DGVBanks.DataSource = ResultOfData;

                }

                LbCount.Text = DGVBanks.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_BanksAccountAddUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVColumnHeaderTextAndWidth();
            TxtCurrency.SelectedIndex = 0;
        }

        private void DGVBanks_DoubleClick(object sender, EventArgs e)
        {
            if (DGVBanks.Rows.Count > 0)
            {

                var result = clsOperationsofBanks.Get_ByBank_Definition(DGVBanks.CurrentRow.Cells["Bank_Definition"].Value.ToString());


                TxtBank_Definition.Text = result.Rows[0]["Bank_Definition"].ToString();
                TxtBeneficiary_Name.Text = result.Rows[0]["Bank_Beneficiary_Name"].ToString();
                TxtBank_Name.Text = result.Rows[0]["Bank_Bank_Name"].ToString();
                TxtBranch.Text = result.Rows[0]["Bank_Branch"].ToString();
                TxtBranch_Code.Text = result.Rows[0]["Bank_Branch_Code"].ToString();
                TxtBank_Address.Text = result.Rows[0]["Bank_Bank_Address"].ToString();
                TxtSwift_Code.Text = result.Rows[0]["Bank_Swift_Code"].ToString();
                TxtAccount_Number.Text = result.Rows[0]["Bank_Account_Number"].ToString();
                TxtIBAN_Number.Text = result.Rows[0]["Bank_IBAN_Number"].ToString();
                TxtCOUNTRY.Text = result.Rows[0]["Bank_COUNTRY"].ToString();
                TxtCurrency.Text = result.Rows[0]["Bank_Account_currency"].ToString();
                CheckWhoSendOrder(true);
            }

        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            CheckWhoSendOrder(false);

        }
    }
}
