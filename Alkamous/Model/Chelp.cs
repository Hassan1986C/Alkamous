using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alkamous.Model
{
    public class Chelp
    {

        public static void WriteErrorLog(string strErrorText, string strFileName = "ErrorLog.txt")
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory;

                string logFilePath = Path.Combine(strPath, strFileName);

                using (StreamWriter sw = new StreamWriter(logFilePath, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{DateTime.UtcNow.ToString()} - {strErrorText}");
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, write an error message to the console
                System.Windows.Forms.MessageBox.Show($"Error in WriteErrorLog: {ex.Message}");
            }
        }

        #region Open and close rest form
        public void ShowForm(Form form)
        {
            try
            {
                CloseAllFormsExceptMain();

                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                View.Frm_Main.FrmMain.PainleContener.Controls.Add(form);
                View.Frm_Main.FrmMain.PainleContener.Tag = form;
                form.Show();
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                WriteErrorLog($"ShowForm => {ex.Message}");
            }
        }

        private void CloseAllFormsExceptMain()
        {
            var formsToClose = Application.OpenForms.Cast<Form>().Where(frm => frm.Name != "Frm_Main").ToList();

            foreach (var form in formsToClose)
            {
                form.Close();
            }
        }

        public bool CheckOpened(string frmName)
        {
            try
            {
                return Application.OpenForms.Cast<Form>().Any(frm => frm.Name == frmName);
            }
            catch (Exception ex)
            {
                WriteErrorLog($"CheckOpened {ex.Message}");
                return false;
            }
        }
        #endregion


        /// <summary>
        /// Format currency to USD or IQD
        /// </summary>
        /// <param name="input"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string Format_PriceAndAmount(string input, string currency)
        {
            int dotCount = input.Count(c => c == '.');
            string output = new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());

            if (dotCount <= 1 && decimal.TryParse(output, out decimal value))
            {
                if (currency == "USD")
                {
                    return string.Format("{0:#,##0.00}", value);
                }
                else
                {
                    return string.Format("{0:#,##0}", value);
                }
            }

            return "";
        }


        /// <summary>
        /// CalculateAmount
        /// </summary>
        /// <param name="QTY"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public static string CalculateAmount(string QTY, string Price, string currency)
        {
            if (QTY != string.Empty && Price != string.Empty)
            {
                Decimal Amount = Convert.ToDecimal(Price) * Convert.ToInt32(QTY);
                return Chelp.Format_PriceAndAmount(Convert.ToString(Amount), currency); ;
            }
            return "0";
        }


        #region Exchange if select USD or IQD and updated TxtProduct_Price.Text and TxtAmount.Text
        /// <summary>
        /// here using Tuple<> to return data
        /// </summary>
        /// <param name="TxtExchange"></param>
        /// <param name="TxtTaxes"></param>
        /// <param name="TxtProduct_Price"></param>
        /// <param name="TxtAmount"></param>
        /// <param name="TxtQTY"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static (string STxtPrice, string STxtAmount) ExchangeAndTaxesToForward(string TxtExchange, string TxtTaxes,
            string TxtProduct_Price, string TxtAmount, string TxtQTY, string currency)
        {
            Decimal Taxes = 0;
            Decimal Ex = 0;
            int QTY = 0;
            Decimal Product_Price = 0;
            Decimal Amount = 0;
            Decimal Product_PriceUpdated = 0;
            Decimal AmountUpdated = 0;

            if (!(string.IsNullOrEmpty(TxtExchange)))
            {
                Ex = Convert.ToDecimal(TxtExchange);
            }

            if (!(string.IsNullOrEmpty(TxtTaxes)))
            {
                Taxes = Convert.ToDecimal(TxtTaxes) / 100m;
            }

            Product_Price = (Convert.ToDecimal(TxtProduct_Price));
            Amount = (Convert.ToDecimal(TxtAmount));
            QTY = (Convert.ToInt32(TxtQTY));

            if (Ex != 0)
            {
                if (Taxes != 0)
                {
                    var Product_PriceWithEXchage = Product_Price * Ex;

                    var Product_PriceWithEXchageWithTaxes = Product_PriceWithEXchage * Taxes;

                    Product_PriceUpdated = Product_PriceWithEXchageWithTaxes + Product_PriceWithEXchage;
                }

                else
                {
                    Product_PriceUpdated = Product_Price * Ex;
                }

            }
            else
            {
                if (Taxes != 0)
                {
                    var Product_PriceWithTaxes = Product_Price * Taxes;

                    Product_PriceUpdated = Product_PriceWithTaxes + Product_Price;
                }
                else
                {
                    Product_PriceUpdated = Product_Price;
                }
            }

            // full TxtAmount.Text by milt Product_PriceUpdated * QTY
            AmountUpdated = Product_PriceUpdated * QTY;

            string STxtPrice = Chelp.Format_PriceAndAmount(Product_PriceUpdated.ToString(), currency);
            string STxtAmount = Chelp.Format_PriceAndAmount(AmountUpdated.ToString(), currency);
            return (STxtPrice, STxtAmount);
        }
        #endregion


        #region Update TxtTotalAmount
        public static string DGVProductsChangededReSumTotalAmount(string Currency, DataGridView DGV)
        {
            Decimal TotalAmount = 0;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                TotalAmount += Convert.ToDecimal(row.Cells[6].Value);
            }

            return Model.Chelp.Format_PriceAndAmount(TotalAmount.ToString(), Currency);

        }
        #endregion

    }
}

