using Alkamous.Controller;
using Alkamous.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_ProductsAddDeleteUpdate : Form
    {
        ClsOperationsofProducts OperationsofProducts = new ClsOperationsofProducts();


        public Frm_ProductsAddDeleteUpdate()
        {
            InitializeComponent();
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


            foreach (DataGridViewRow row in DGVProducts.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    DGVProducts.Rows[row.Index].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }


        private bool CheckDataEntry()
        {
            var textBoxes = groupBox1.Controls.OfType<TextBox>();
            foreach (var txt in textBoxes)
            {
                txt.BackColor = Color.White;
                if (string.IsNullOrEmpty(txt.Text))
                {
                    txt.Focus();
                    txt.BackColor = Color.Ivory;
                    MessageBox.Show("All fields required");
                    return false;
                }
            }

            if (!ValidateInputPrice())
            {
                return false;
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
                LbCount.Text = DGVProducts.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }



        private void LbCount_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ProductsAddDeleteUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVColumnHeaderTextAndWidth();
        }



        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVProducts.RowCount > 0)
                {
                    CTB_Products MCTB_Products = new CTB_Products("ct0r2");
                    if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                        + Environment.NewLine + "product_Id    : " + DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString()
                        + Environment.NewLine + "product_NameEn   : " + DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString()
                        + Environment.NewLine + "product_NameAr     : " + DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString()
                        , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        bool Result = OperationsofProducts.Delete_Product(DGVProducts.CurrentRow.Cells[0].Value.ToString());
                        if (Result)
                        {
                            Chelp.RegisterUsersActionLogs("Delete prodect", TxtProductId.Text);
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
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private CTB_Products AssignValuesToClass()
        {
            CTB_Products MTB_Products = new CTB_Products
            {
                product_Id = TxtProductId.Text,
                product_NameAr = TxtProductNameAr.Text,
                product_NameEn = TxtProductNameEn.Text,
                product_Price = TxtProductPrice.Text,
                product_Unit = TxtProductUnit.Text
            };
            return MTB_Products;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataEntry())
                {

                    if (OperationsofProducts.Check_ProductIdNotDuplicate(TxtProductId.Text))
                    {
                        TxtProductId.Focus();
                        TxtProductId.SelectAll();
                        MessageBox.Show($"Product Id {TxtProductId.Text} already exists");
                        return;
                    }

                    CTB_Products MTB_Products = AssignValuesToClass();

                    var result = OperationsofProducts.Add_Product(MTB_Products);
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Add prodect", TxtProductId.Text);
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



        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataEntry())
                {

                    CTB_Products MTB_Products = AssignValuesToClass();
                    var result = OperationsofProducts.Update_Product(MTB_Products);
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Update prodect", TxtProductId.Text);
                        MessageBox.Show(" Data Updated Successfully ");
                        ClearAllTestBox();
                        CheckWhoSendOrder(false);
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("No");
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }


        private void MoveToNextText(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }




        private void TxtProductPrice_Validated(object sender, EventArgs e)
        {
            ValidateInputPrice();
        }

        private bool ValidateInputPrice()
        {
            int dotCount = TxtProductPrice.Text.Count(c => c == '.');
            if (TxtProductPrice.Text != "" && dotCount <= 1)
            {
                TxtProductPrice.Text = Convert.ToString(string.Format("{0:###,###,##0.00}", (Convert.ToDouble(TxtProductPrice.Text))));
                TxtProductPrice.SelectionStart = TxtProductPrice.Text.Length;
                TxtProductPrice.SelectionLength = 0;
                return true;
            }
            else
            {
                TxtProductPrice.Focus();
                MessageBox.Show("the dot you add more than one check your price again, please");
                return false;
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

        private void CheckWhoSendOrder(bool sender)
        {
            TxtProductId.Enabled = (!sender);
            BtnEditProduct.Enabled = sender;

            BtnCancelEdit.Visible = sender;
            BtnAddProduct.Visible = (!sender);
            BtnDeleteProduct.Visible = (!sender);
        }

        private void DGVProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CTB_Products MCTB_Products = new CTB_Products("ct0r2");
                TxtProductId.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Id].Value.ToString();
                TxtProductNameEn.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameEn].Value.ToString();
                TxtProductNameAr.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_NameAr].Value.ToString();
                TxtProductPrice.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Price].Value.ToString();
                TxtProductUnit.Text = DGVProducts.CurrentRow.Cells[MCTB_Products.product_Unit].Value.ToString();
                CheckWhoSendOrder(true);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            CheckWhoSendOrder(false);
            ClearAllTestBox();
            LoadData();
        }

        private void Btn_HintAndInfo_Click(object sender, EventArgs e)
        {
            var Result = "";
            Result += $"on product Name should apply the below info  \n\n";
            Result += $"1- Product category + 2 product type + 3 Product information \n\n";
            Result += $"Example \n";
            Result += $"Product category = Evolis or Fargo or Elka or etc \n";
            Result += $"product type = Primacy 2 or HID 5600 or  etc \n";
            Result += $"Product information = duplex 300DPI or single 300DPI or Re- transfer or etc  \n";
            Result += $"---------------------------------------------------------------- \n";
            Result += $"Evolis Primacy 2 duplex 300DPI .... \n";
            Result += $"Fargo HID 5600 duplex 600DPI Re- transfer .... \n";
            Result += $"Evolis Primacy 2 Ribbon YMCKO 300 print/Roll .... \n";

            MessageBox.Show(Result, "Info on how to add new products For Easest Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TxtProductNameAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
