using Alkamous.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_TermsAddDeleteUpdate : Form
    {
        ClsOperationsofTerms OperationsofTerms = new ClsOperationsofTerms();

        public Frm_TermsAddDeleteUpdate()
        {
            InitializeComponent();
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
            TxtAutoNumber.Clear();
        }

        private void CheckWhoSendOrder(bool sender)
        {

            BtnEditProduct.Enabled = sender;
            BtnCancelEdit.Visible = sender;
            BtnAddProduct.Visible = (!sender);
            BtnDeleteProduct.Visible = (!sender);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataEntry())
                {

                    var result = OperationsofTerms.Add_Term(TxtTerm_En.Text.Trim(), TxtTerms_Ar.Text.Trim());
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Add Terms", TxtTerms_Ar.Text.Trim());
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
                    var result = OperationsofTerms.Update_Term(TxtAutoNumber.Text, TxtTerm_En.Text.Trim(), TxtTerms_Ar.Text.Trim());
                    if (result)
                    {
                        Chelp.RegisterUsersActionLogs("Update Terms", TxtTerms_Ar.Text.Trim());
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

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTerms.RowCount > 0)
                {
                    Model.CTB_Terms MCTB_Terms = new Model.CTB_Terms("ct0r2");
                    if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                        + Environment.NewLine + "Terms English   : " + DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_En].Value.ToString()
                        + Environment.NewLine + "Terms Arabic    : " + DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_Ar].Value.ToString()
                        , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        bool Result = OperationsofTerms.Delete_Term(DGVTerms.CurrentRow.Cells[0].Value.ToString());
                        if (Result)
                        {
                            Chelp.RegisterUsersActionLogs("Delete Terms", TxtTerms_Ar.Text.Trim());
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

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            CheckWhoSendOrder(false);
            ClearAllTestBox();
            LoadData();
        }

        private void DGVTerms_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Model.CTB_Terms MCTB_Terms = new Model.CTB_Terms("ct0r2");
                TxtAutoNumber.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_AutoNum].Value.ToString();
                TxtTerm_En.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_En].Value.ToString();
                TxtTerms_Ar.Text = DGVTerms.CurrentRow.Cells[MCTB_Terms.Term_Ar].Value.ToString();
                CheckWhoSendOrder(true);
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_TermsAddDeleteUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVColumnHeaderTextAndWidth();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(TxtSearch.Text.Trim());
        }
    }
}
