using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Alkamous.Controller
{
    public class CLSExportDataToWordFile
    {
        #region Declare Variables For CLS Of Operations

        ClsOperationsofCustomers OperationsofCustomers = new ClsOperationsofCustomers();
        ClsOperationsofInvoices OperationsofInvoices = new ClsOperationsofInvoices();
        ClsOperationsofConsumable OperationsofConsumable = new ClsOperationsofConsumable();
        ClsOperationsofTermsInvoices OperationsofTermsInvoices = new ClsOperationsofTermsInvoices();
        ClsOperationsofBanks OperationsofBanks = new ClsOperationsofBanks();

        #endregion

        #region Declare Variables For Microsoft.Office.Interop.Word

        Microsoft.Office.Interop.Word.Application wordApp = null;
        Microsoft.Office.Interop.Word.Document aDoc = null;
        Microsoft.Office.Interop.Word.Table table = null;
        Microsoft.Office.Interop.Word.Bookmarks ReplaceBookmarks = null;

        #endregion

        public void ExportDataToWord(string InvoiceNumber)
        {

            // open the document Template word File
            object fileName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Temp\TempFile.docx");

            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application { Visible = false };
                aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: false);
                aDoc.Activate();
                ReplaceBookmarks = aDoc.Bookmarks;

                Cursor.Current = Cursors.WaitCursor;
                View.Frm_Customers.FrmCustomer.LbWaitSaveFile.Visible = true;

                #region Customer

                DataTable dtTB_CustomerReport = new DataTable();
                dtTB_CustomerReport = OperationsofCustomers.Get_CustomerDetails_ByCustomer_Invoice_Number(InvoiceNumber);

                string Customer_AutoNum = dtTB_CustomerReport.Rows[0]["Customer_AutoNum"].ToString();
                string Customer_Invoice_Number = dtTB_CustomerReport.Rows[0]["Customer_Invoice_Number"].ToString();
                string Customer_Company = dtTB_CustomerReport.Rows[0]["Customer_Company"].ToString();
                string Customer_Name = dtTB_CustomerReport.Rows[0]["Customer_Name"].ToString();
                string Customer_Mob = dtTB_CustomerReport.Rows[0]["Customer_Mob"].ToString();
                string Customer_Email = dtTB_CustomerReport.Rows[0]["Customer_Email"].ToString();
                string Customer_Currency = dtTB_CustomerReport.Rows[0]["Customer_Currency"].ToString();
                string Customer_DateTime = dtTB_CustomerReport.Rows[0]["Customer_DateTime"].ToString();
                string Customer_Quote_Valid = dtTB_CustomerReport.Rows[0]["Customer_Quote_Valid"].ToString();
                string Customer_Payment_Terms = dtTB_CustomerReport.Rows[0]["Customer_Payment_Terms"].ToString();
                string Customer_Discount = dtTB_CustomerReport.Rows[0]["Customer_Discount"].ToString();
                string Customer_BankAccount = dtTB_CustomerReport.Rows[0]["Customer_BankAccount"].ToString();
                string Customer_Language = dtTB_CustomerReport.Rows[0]["Customer_Language"].ToString();
                string PaymentASTermsCostem = dtTB_CustomerReport.Rows[0]["Customer_Note"].ToString();
                int Customer_ValOfPaymentInAdv = int.TryParse(PaymentASTermsCostem, out Customer_ValOfPaymentInAdv) ? Customer_ValOfPaymentInAdv : 100;


                string ExportFileName = $"Quotation #{Customer_Invoice_Number} For {(Customer_Company != "" ? Customer_Company : Customer_Name)}";


                ReplaceBookmarks["Customer_Invoice_Number"].Range.Text = Customer_Invoice_Number;
                ReplaceBookmarks["Customer_Company"].Range.Text = Customer_Company;
                ReplaceBookmarks["Customer_Name"].Range.Text = Customer_Name;
                ReplaceBookmarks["Customer_Mob"].Range.Text = Customer_Mob;
                ReplaceBookmarks["Customer_Email"].Range.Text = Customer_Email;
                ReplaceBookmarks["Customer_Currency"].Range.Text = Customer_Currency;
                ReplaceBookmarks["Customer_DateTime"].Range.Text = Customer_DateTime;
                ReplaceBookmarks["Customer_Quote_Valid"].Range.Text = $"{Customer_Quote_Valid} Days";
                ReplaceBookmarks["Customer_Payment_Terms"].Range.Text = Customer_Payment_Terms;

                #endregion

                #region Invoices

                DataTable dtTB_InvoicesReport = new DataTable();
                dtTB_InvoicesReport = OperationsofInvoices.Get_Invoice_ByInvoice_Number(InvoiceNumber);


                table = aDoc.Tables[2];
                object objmissval = System.Reflection.Missing.Value;


                for (int i = 0; i < dtTB_InvoicesReport.Rows.Count; i++)
                {
                    // to add new rows to tables
                    table.Rows.Add(ref objmissval);

                    table.Cell(2 + i, 1).Range.Text = (1 + i).ToString();
                    table.Cell(2 + i, 2).Range.Text = dtTB_InvoicesReport.Rows[i]["product_Id"].ToString();
                    table.Cell(2 + i, 4).Range.Text = dtTB_InvoicesReport.Rows[i]["Invoice_QTY"].ToString();
                    table.Cell(2 + i, 5).Range.Text = dtTB_InvoicesReport.Rows[i]["Invoice_Unit"].ToString();
                    table.Cell(2 + i, 6).Range.Text = dtTB_InvoicesReport.Rows[i]["Invoice_Price"].ToString();
                    table.Cell(2 + i, 7).Range.Text = dtTB_InvoicesReport.Rows[i]["Invoice_Amount"].ToString();

                }

                // set color to header of table
                table.Rows[1].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;


                #region TO get the total and total amount 
                // to get the total and total amount
                Decimal Total = 0;
                for (int i = 0; i < dtTB_InvoicesReport.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dtTB_InvoicesReport.Rows[i]["Invoice_Amount"]);
                }

                Decimal TotalAmount = 0;

                TotalAmount = Total - Convert.ToDecimal(Customer_Discount);

                List<CurrencyInfo> currencies = new List<CurrencyInfo>();
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Dollar));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.IRAQ));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.AED));


                int SelectCurrency = 0;

                switch (Customer_Currency)
                {
                    case "USD":
                        SelectCurrency = 0;
                        break;

                    case "IQD":
                        SelectCurrency = 1;
                        break;

                    case "AED":
                        SelectCurrency = 2;
                        break;
                }


                ToWord TotalAmountToWord = new ToWord(TotalAmount, currencies[SelectCurrency]);


                #region check Discount for Client - check if there is No Discount for Client 

                if ((Customer_Discount == "0") || (Customer_Discount == "0.00"))
                {

                    #region Check Payment_Terms in ADVANCE 100% without Discount

                    if (Customer_ValOfPaymentInAdv == 100)
                    {
                        table.Rows.Add(ref objmissval);

                        table.Cell(table.Rows.Count, 1).Merge(table.Cell(table.Rows.Count, 2));
                        table.Cell(table.Rows.Count, 2).Merge(table.Cell(table.Rows.Count, 4));
                        table.Cell(table.Rows.Count, 3).Merge(table.Cell(table.Rows.Count, 4));

                        // set color to table
                        table.Rows[table.Rows.Count].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;

                        // Set the text for the merged cell
                        table.Cell(table.Rows.Count, 1).Range.Text = $"Total Amount {Customer_Currency} :";
                        table.Cell(table.Rows.Count, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        if (Customer_Language == "Arabic")
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count, 2).Range.Text = TotalAmountToWord.ConvertToArabic();
                            table.Cell(table.Rows.Count, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                        }
                        else
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count, 2).Range.Text = TotalAmountToWord.ConvertToEnglish();
                            table.Cell(table.Rows.Count, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }


                        table.Cell(table.Rows.Count, 3).Range.Text = Chelp.Format_PriceAndAmount(TotalAmount.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count, 3).Range.Font.Size = 13;
                        table.Cell(table.Rows.Count, 3).Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorRed;

                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            table.Rows.Add(ref objmissval);
                        }

                        table.Cell(table.Rows.Count, 1).Merge(table.Cell(table.Rows.Count, 5));
                        table.Cell(table.Rows.Count, 2).Merge(table.Cell(table.Rows.Count, 3));

                        table.Cell(table.Rows.Count - 1, 1).Merge(table.Cell(table.Rows.Count - 1, 5));
                        table.Cell(table.Rows.Count - 1, 2).Merge(table.Cell(table.Rows.Count - 1, 3));

                        table.Cell(table.Rows.Count - 2, 1).Merge(table.Cell(table.Rows.Count - 2, 2));
                        table.Cell(table.Rows.Count - 2, 2).Merge(table.Cell(table.Rows.Count - 2, 4));
                        table.Cell(table.Rows.Count - 2, 3).Merge(table.Cell(table.Rows.Count - 2, 4));

                        // set color of table
                        table.Rows[table.Rows.Count - 2].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;
                        ////////////////////////////////////////////////////////////////////////////////////////


                        decimal PaymentInADVANCE = 0;
                        decimal PaymentOnDELIVERY = 0;
                        string InADVANCEPercentage = "";
                        string OnDELIVERYPercentage = "";

                        (PaymentInADVANCE, PaymentOnDELIVERY, InADVANCEPercentage, OnDELIVERYPercentage) = Chelp.PaymentTermsSettings(TotalAmount, Customer_ValOfPaymentInAdv);


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count, 1).Range.Text = $"{OnDELIVERYPercentage} ON DELIVERY ";
                        table.Cell(table.Rows.Count, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        table.Cell(table.Rows.Count, 2).Range.Text = Chelp.Format_PriceAndAmount(PaymentOnDELIVERY.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count, 2).Range.Font.Size = 10;



                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 1, 1).Range.Text = $"{InADVANCEPercentage} IN ADVANCE ";
                        table.Cell(table.Rows.Count - 1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        table.Cell(table.Rows.Count - 1, 2).Range.Text = Chelp.Format_PriceAndAmount(PaymentInADVANCE.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count - 1, 2).Range.Font.Size = 10;




                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 2, 1).Range.Text = $"Total Amount {Customer_Currency} :";
                        table.Cell(table.Rows.Count - 2, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        if (Customer_Language == "Arabic")
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count - 2, 2).Range.Text = TotalAmountToWord.ConvertToArabic();
                            table.Cell(table.Rows.Count - 2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                        }
                        else
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count - 2, 2).Range.Text = TotalAmountToWord.ConvertToEnglish();
                            table.Cell(table.Rows.Count - 2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }


                        table.Cell(table.Rows.Count - 2, 3).Range.Text = Chelp.Format_PriceAndAmount(TotalAmount.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count - 2, 3).Range.Font.Size = 13;
                        table.Cell(table.Rows.Count - 2, 3).Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorRed;
                    }

                    #endregion

                }
                else
                {

                    #region Check Payment_Terms in ADVANCE with Discount

                    if (Customer_ValOfPaymentInAdv == 100)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            table.Rows.Add(ref objmissval);

                        }

                        table.Cell(table.Rows.Count, 1).Merge(table.Cell(table.Rows.Count, 2));
                        table.Cell(table.Rows.Count, 2).Merge(table.Cell(table.Rows.Count, 4));
                        table.Cell(table.Rows.Count, 3).Merge(table.Cell(table.Rows.Count, 4));

                        table.Cell(table.Rows.Count - 1, 1).Merge(table.Cell(table.Rows.Count - 1, 2));
                        table.Cell(table.Rows.Count - 1, 2).Merge(table.Cell(table.Rows.Count - 1, 4));
                        table.Cell(table.Rows.Count - 1, 3).Merge(table.Cell(table.Rows.Count - 1, 4));


                        table.Cell(table.Rows.Count - 2, 1).Merge(table.Cell(table.Rows.Count - 2, 2));
                        table.Cell(table.Rows.Count - 2, 2).Merge(table.Cell(table.Rows.Count - 2, 4));
                        table.Cell(table.Rows.Count - 2, 3).Merge(table.Cell(table.Rows.Count - 2, 4));


                        // set color of table
                        table.Rows[table.Rows.Count].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count, 1).Range.Text = $"Total Amount {Customer_Currency} :";
                        table.Cell(table.Rows.Count, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                        if (Customer_Language == "Arabic")
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count, 2).Range.Text = TotalAmountToWord.ConvertToArabic();
                            table.Cell(table.Rows.Count, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                        }
                        else
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count, 2).Range.Text = TotalAmountToWord.ConvertToEnglish();
                            table.Cell(table.Rows.Count, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }

                        table.Cell(table.Rows.Count, 3).Range.Text = Chelp.Format_PriceAndAmount(TotalAmount.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count, 3).Range.Font.Size = 13;
                        table.Cell(table.Rows.Count, 3).Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorRed;



                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 1, 1).Range.Text = $"Discount : ";
                        table.Cell(table.Rows.Count - 1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(table.Rows.Count - 1, 3).Range.Text = Customer_Discount;


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 2, 1).Range.Text = $"Total :";
                        table.Cell(table.Rows.Count - 2, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(table.Rows.Count - 2, 3).Range.Text = Chelp.Format_PriceAndAmount(Total.ToString(), Customer_Currency);

                    }
                    else
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            table.Rows.Add(ref objmissval);
                        }

                        table.Cell(table.Rows.Count, 1).Merge(table.Cell(table.Rows.Count, 5));
                        table.Cell(table.Rows.Count, 2).Merge(table.Cell(table.Rows.Count, 3));

                        table.Cell(table.Rows.Count - 1, 1).Merge(table.Cell(table.Rows.Count - 1, 5));
                        table.Cell(table.Rows.Count - 1, 2).Merge(table.Cell(table.Rows.Count - 1, 3));

                        table.Cell(table.Rows.Count - 2, 1).Merge(table.Cell(table.Rows.Count - 2, 2));
                        table.Cell(table.Rows.Count - 2, 2).Merge(table.Cell(table.Rows.Count - 2, 4));
                        table.Cell(table.Rows.Count - 2, 3).Merge(table.Cell(table.Rows.Count - 2, 4));

                        table.Cell(table.Rows.Count - 3, 1).Merge(table.Cell(table.Rows.Count - 3, 2));
                        table.Cell(table.Rows.Count - 3, 2).Merge(table.Cell(table.Rows.Count - 3, 4));
                        table.Cell(table.Rows.Count - 3, 3).Merge(table.Cell(table.Rows.Count - 3, 4));

                        table.Cell(table.Rows.Count - 4, 1).Merge(table.Cell(table.Rows.Count - 4, 2));
                        table.Cell(table.Rows.Count - 4, 2).Merge(table.Cell(table.Rows.Count - 4, 4));
                        table.Cell(table.Rows.Count - 4, 3).Merge(table.Cell(table.Rows.Count - 4, 4));


                        // set color of table
                        table.Rows[table.Rows.Count - 2].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;
                        ////////////////////////////////////////////////////////////////////////////////////////


                        decimal PaymentInADVANCE = 0;
                        decimal PaymentOnDELIVERY = 0;
                        string InADVANCEPercentage = "";
                        string OnDELIVERYPercentage = "";

                        (PaymentInADVANCE, PaymentOnDELIVERY, InADVANCEPercentage, OnDELIVERYPercentage) = Chelp.PaymentTermsSettings(TotalAmount, Customer_ValOfPaymentInAdv);


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count, 1).Range.Text = $"{OnDELIVERYPercentage} ON DELIVERY ";
                        table.Cell(table.Rows.Count, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        table.Cell(table.Rows.Count, 2).Range.Text = Chelp.Format_PriceAndAmount(PaymentOnDELIVERY.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count, 2).Range.Font.Size = 10;



                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 1, 1).Range.Text = $"{InADVANCEPercentage} IN ADVANCE ";
                        table.Cell(table.Rows.Count - 1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                        table.Cell(table.Rows.Count - 1, 2).Range.Text = Chelp.Format_PriceAndAmount(PaymentInADVANCE.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count - 1, 2).Range.Font.Size = 10;



                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 2, 1).Range.Text = $"Total Amount {Customer_Currency} :";
                        table.Cell(table.Rows.Count - 2, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                        if (Customer_Language == "Arabic")
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count - 2, 2).Range.Text = TotalAmountToWord.ConvertToArabic();
                            table.Cell(table.Rows.Count - 2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                        }
                        else
                        {
                            // in case we need to set the TotalAmountToWord in arabioc languge just use . TotalAmountToWord.ConvertToArabic()
                            table.Cell(table.Rows.Count - 2, 2).Range.Text = TotalAmountToWord.ConvertToEnglish();
                            table.Cell(table.Rows.Count - 2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }

                        table.Cell(table.Rows.Count - 2, 3).Range.Text = Chelp.Format_PriceAndAmount(TotalAmount.ToString(), Customer_Currency);
                        table.Cell(table.Rows.Count - 2, 3).Range.Font.Size = 13;
                        table.Cell(table.Rows.Count - 2, 3).Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorRed;


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 3, 1).Range.Text = $"Discount : ";
                        table.Cell(table.Rows.Count - 3, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(table.Rows.Count - 3, 3).Range.Text = Customer_Discount;


                        //// Set the text for the merged cell
                        table.Cell(table.Rows.Count - 4, 1).Range.Text = $"Total :";
                        table.Cell(table.Rows.Count - 4, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(table.Rows.Count - 4, 3).Range.Text = Chelp.Format_PriceAndAmount(Total.ToString(), Customer_Currency);

                    }

                    #endregion
                }

                #endregion

                #endregion


                int NextArCell = 2;
                for (int i = 0; i < dtTB_InvoicesReport.Rows.Count; i++)
                {
                    if (Customer_Language == "English")
                    {
                        // Set the alignment of the second column cells to left
                        table.Cell(2 + i, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(2 + i, 3).Range.Text = dtTB_InvoicesReport.Rows[i]["product_NameEn"].ToString();
                    }
                    else if (Customer_Language == "Arabic")
                    {
                        // Set the text direction to right                              

                        table.Cell(2 + i, 3).Range.ParagraphFormat.ReadingOrder = Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderRtl;
                        table.Cell(2 + i, 3).Range.Text = dtTB_InvoicesReport.Rows[i]["product_NameAr"].ToString();
                        table.Cell(2 + i, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                    else
                    {

                        // Set the alignment of the second column cells to left
                        table.Cell(NextArCell, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        table.Cell(NextArCell, 3).Range.Text = dtTB_InvoicesReport.Rows[i]["product_NameEn"].ToString();

                        // Split the cell 2 cells
                        table.Cell(NextArCell, 3).Split(2, 1);

                        // Set the text direction to right                        
                        table.Cell(NextArCell + 1, 3).Range.ParagraphFormat.ReadingOrder = Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderRtl;
                        table.Cell(NextArCell + 1, 3).Range.Text = dtTB_InvoicesReport.Rows[i]["product_NameAr"].ToString();


                        NextArCell = NextArCell + 2;

                    }
                }


                #endregion

                #region Consumable


                DataTable dtTB_ConsumableReport = new DataTable();
                dtTB_ConsumableReport = OperationsofConsumable.Get_Consumable_ByConsumable_Number(InvoiceNumber);
                table = aDoc.Tables[3];
                if (dtTB_ConsumableReport.Rows.Count > 0)
                {
                    for (int i = 0; i < dtTB_ConsumableReport.Rows.Count; i++)
                    {

                        // to add new rows to tables
                        table.Rows.Add(ref objmissval);

                        table.Cell(3 + i, 1).Range.Text = (1 + i).ToString();
                        table.Cell(3 + i, 2).Range.Text = dtTB_ConsumableReport.Rows[i]["product_Id"].ToString();
                        table.Cell(3 + i, 4).Range.Text = dtTB_ConsumableReport.Rows[i]["Consumable_QTY"].ToString();
                        table.Cell(3 + i, 5).Range.Text = dtTB_ConsumableReport.Rows[i]["Consumable_Unit"].ToString();
                        table.Cell(3 + i, 6).Range.Text = dtTB_ConsumableReport.Rows[i]["Consumable_Price"].ToString();
                        table.Cell(3 + i, 7).Range.Text = dtTB_ConsumableReport.Rows[i]["Consumable_Amount"].ToString();

                    }

                    // set color to header of table
                    table.Rows[2].Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;

                    NextArCell = 3;
                    for (int i = 0; i < dtTB_ConsumableReport.Rows.Count; i++)
                    {
                        if (Customer_Language == "English")
                        {
                            // table header
                            table.Cell(1, 1).Range.Text = "Optional consumables";


                            // Set the alignment of the second column cells to left
                            table.Cell(3 + i, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                            table.Cell(3 + i, 3).Range.Text = dtTB_ConsumableReport.Rows[i]["product_NameEn"].ToString();
                        }
                        else if (Customer_Language == "Arabic")
                        {
                            // table header
                            table.Cell(1, 1).Range.Text = "مواد اختيارية";

                            // Set the text direction to right

                            table.Cell(3 + i, 3).Range.ParagraphFormat.ReadingOrder = Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderRtl;
                            table.Cell(3 + i, 3).Range.Text = dtTB_ConsumableReport.Rows[i]["product_NameAr"].ToString();
                            table.Cell(3 + i, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }
                        else
                        {
                            // table header
                            table.Cell(1, 1).Range.Text = "Optional consumables  -  مواد اختيارية";




                            // Set the alignment of the second column cells to left
                            table.Cell(NextArCell, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                            table.Cell(NextArCell, 3).Range.Text = dtTB_ConsumableReport.Rows[i]["product_NameEn"].ToString();


                            // Split the cell 2 cells
                            table.Cell(NextArCell, 3).Split(2, 1);

                            // Set the text direction to right                            
                            table.Cell(NextArCell + 1, 3).Range.ParagraphFormat.ReadingOrder = Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderRtl;
                            table.Cell(NextArCell + 1, 3).Range.Text = dtTB_ConsumableReport.Rows[i]["product_NameAr"].ToString();


                            NextArCell = NextArCell + 2;

                        }
                    }
                }
                else
                {
                    table.Delete();
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



                    if (Customer_Language == "English")
                    {
                        ReplaceBookmarks["Terms_and_conditions_Arabic"].Range.Delete();
                        ReplaceBookmarks["Terms_and_conditions_English"].Range.Text = builderEN.ToString();

                    }
                    else if (Customer_Language == "Arabic")
                    {

                        ReplaceBookmarks["Terms_and_conditions_English"].Range.Delete();
                        ReplaceBookmarks["Terms_and_conditions_Arabic"].Range.Text = builderAR.ToString();
                    }
                    else
                    {
                        ReplaceBookmarks["Terms_and_conditions_English"].Range.Text = builderEN.ToString();
                        ReplaceBookmarks["Terms_and_conditions_Arabic"].Range.Text = builderAR.ToString();

                    }
                }
                else
                {
                    ReplaceBookmarks["Terms_and_conditions_English"].Range.Delete();
                    ReplaceBookmarks["Terms_and_conditions_Arabic"].Range.Delete();
                }


                #endregion

                #region Bank

                int checkConsumabl = dtTB_ConsumableReport.Rows.Count;
                if (checkConsumabl > 0)
                {
                    table = aDoc.Tables[4];
                }
                else
                {
                    table = aDoc.Tables[3];
                }

                var SelectResult = Customer_BankAccount;

                if (SelectResult != "Select No Account Bank")
                {


                    DataTable dtTB_BankAccountReport = new DataTable();
                    dtTB_BankAccountReport = OperationsofBanks.Get_ByBank_Definition(SelectResult);


                    table.Cell(1, 1).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Definition"].ToString();

                    table.Cell(2, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Beneficiary_Name"].ToString();

                    table.Cell(3, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Bank_Name"].ToString();

                    table.Cell(4, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Branch"].ToString();

                    table.Cell(5, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Branch_Code"].ToString();

                    table.Cell(6, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Bank_Address"].ToString();

                    table.Cell(7, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Swift_Code"].ToString();

                    table.Cell(8, 1).Range.Text = $"Account Number {Customer_Currency}";
                    table.Cell(8, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_Account_Number"].ToString();

                    table.Cell(9, 1).Range.Text = $"IBAN Number {Customer_Currency}";
                    table.Cell(9, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_IBAN_Number"].ToString();

                    table.Cell(10, 2).Range.Text = dtTB_BankAccountReport.Rows[0]["Bank_COUNTRY"].ToString();


                }
                else
                {
                    table.Delete();
                }

                #endregion

                #region Logic Code to Save File


                string FullPathExport = string.Empty;

                // Export The Word File To path already user selected
                if (Directory.Exists(Path.Combine($@"{Properties.Settings.Default.ExportPath}")))
                {
                    FullPathExport = $@"{Properties.Settings.Default.ExportPath}";
                }
                else
                {
                    string folderName = "Export_File";

                    if (!Directory.Exists(Path.Combine(Application.StartupPath, folderName)))
                    {
                        // Create the folder if it doesn't exist
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, folderName));
                    }

                    FullPathExport = Path.Combine(Application.StartupPath, folderName);
                }

                fileName = Path.Combine(FullPathExport, $"{ExportFileName}.docx");

                aDoc.SaveAs2(fileName);

                MessageBox.Show("Export Completed", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // opens the folder in explorer
                Process.Start(FullPathExport);
                #endregion

            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog("ExportDataToWord => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the document and the application
                if (aDoc != null)
                {
                    aDoc.Close();
                    wordApp.Quit();
                }

                View.Frm_Customers.FrmCustomer.LbWaitSaveFile.Visible = false;
                Cursor.Current = Cursors.Default;
            }


        }
    }
}
