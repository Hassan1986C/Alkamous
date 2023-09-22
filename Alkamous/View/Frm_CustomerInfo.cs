using Alkamous.Controller;
using Alkamous.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomerInfo : Form
    {
        ClsOperationsofCustomerInfo OperationsofCustomerInfo = new ClsOperationsofCustomerInfo();
        string AutoNumValue = "";

        public Frm_CustomerInfo()
        {
            InitializeComponent();
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


        private bool CheckDataEntry()
        {
            var textBoxes = groupBox1.Controls.OfType<TextBox>();
            foreach (var txt in textBoxes)
            {
                txt.BackColor = Color.White;
                if (string.IsNullOrEmpty(txt.Text) || (txt.Text.Length > 51))
                {
                    txt.Focus();
                    txt.BackColor = Color.Ivory;
                    MessageBox.Show($@"All fields required and maximum 50 characters", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void ClearAllTestBox()
        {
            var textBoxes = groupBox1.Controls.OfType<TextBox>();
            foreach (var txt in textBoxes)
            {
                txt.Clear();
            }
            TxtSearch.Clear();
        }

        private void CheckWhoSendOrder(bool sender)
        {
            BtnEdit.Enabled = sender;
            BtnCancelEdit.Visible = sender;
            BtnAdd.Visible = (!sender);
            BtnDelete.Visible = (!sender);
        }

        private CTB_CustomerInfo AssignValuesToClass()
        {
            CTB_CustomerInfo MTB_CustomerInfo = new CTB_CustomerInfo
            {
                Customer_AutoNum = AutoNumValue,
                Customer_Company = TxtCompany.Text,
                Customer_Name = TxtName.Text,
                Customer_Email = TxtEmail.Text,
                Customer_Mob = TxtMobile.Text,

            };
            return MTB_CustomerInfo;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataEntry())
                {

                    if (OperationsofCustomerInfo.Check_CustomerInfo_NotDuplicate(TxtMobile.Text))
                    {
                        TxtMobile.Focus();
                        TxtMobile.SelectAll();
                        MessageBox.Show($"The Mobile {TxtMobile.Text} already exists");
                        return;
                    }


                    CTB_CustomerInfo MTB_CustomerInfo = AssignValuesToClass();
                    var result = OperationsofCustomerInfo.Add_CustomerInfo(MTB_CustomerInfo);
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Add Customer Info", TxtCompany.Text);
                        MessageBox.Show("Data Added Successfully");
                        ClearAllTestBox();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sorry There is an error try later and re-open the software again");
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataEntry())
                {

                    //if (OperationsofCustomerInfo.Check_CustomerInfo_NotDuplicate(TxtMobile.Text))
                    //{
                    //    TxtMobile.Focus();
                    //    TxtMobile.SelectAll();
                    //    MessageBox.Show($"The Mobile {TxtMobile.Text} already exists");
                    //    return;
                    //}


                    CTB_CustomerInfo MTB_CustomerInfo = AssignValuesToClass();
                    var result = OperationsofCustomerInfo.Update_CustomerInfo(MTB_CustomerInfo);
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Update Customer Info", TxtCompany.Text);
                        MessageBox.Show("Data Update Successfully");

                        ClearAllTestBox();
                        CheckWhoSendOrder(false);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sorry There is an error try later and re-open the software again");
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

        private void Frm_CTB_CustomerInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVColumnHeaderTextAndWidth();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }

        #endregion



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCustomerInfo.RowCount > 0)
                {

                    if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                        + Environment.NewLine + "Company    : " + DGVCustomerInfo.CurrentRow.Cells[1].Value.ToString()
                        + Environment.NewLine + "Name   : " + DGVCustomerInfo.CurrentRow.Cells[2].Value.ToString()

                        , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        bool Result = OperationsofCustomerInfo.Delete_CustomerInfo(DGVCustomerInfo.CurrentRow.Cells[0].Value.ToString());
                        if (Result)
                        {
                            Chelp.RegisterUsersActionLogs("Delete Customer Info", DGVCustomerInfo.CurrentRow.Cells[1].Value.ToString());
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
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            CheckWhoSendOrder(false);
            ClearAllTestBox();
            LoadData();
        }

        private void DGVCustomerInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                AutoNumValue = DGVCustomerInfo.CurrentRow.Cells[0].Value.ToString();
                TxtCompany.Text = DGVCustomerInfo.CurrentRow.Cells[1].Value.ToString();
                TxtName.Text = DGVCustomerInfo.CurrentRow.Cells[2].Value.ToString();
                TxtMobile.Text = DGVCustomerInfo.CurrentRow.Cells[3].Value.ToString();
                TxtEmail.Text = DGVCustomerInfo.CurrentRow.Cells[4].Value.ToString();

                CheckWhoSendOrder(true);
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

