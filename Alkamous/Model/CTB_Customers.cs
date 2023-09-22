
namespace Alkamous.Model
{
    public class CTB_Customers : CTB_CustomerInfo
    {
        public string Customer_Invoice_Number { get; set; }

        public string Customer_Currency { get; set; }

        public string Customer_ExchangeRate { get; set; }

        public string Customer_Taxes { get; set; }

        public string Customer_DateTime { get; set; }

        public string Customer_Quote_Valid { get; set; }

        public string Customer_Payment_Terms { get; set; }

        public string Customer_Discount { get; set; }

        public string Customer_BankAccount { get; set; }

        public string Customer_Language { get; set; }

        public string Customer_Note { get; set; }

        public string Customer_Note2 { get; set; }


        public CTB_Customers()
        {
            Customer_AutoNum = "@Customer_AutoNum";
            Customer_Invoice_Number = "@Customer_Invoice_Number";
            Customer_Company = "@Customer_Company";
            Customer_Name = "@Customer_Name";
            Customer_Mob = "@Customer_Mob";
            Customer_Email = "@Customer_Email";
            Customer_Currency = "@Customer_Currency";
            Customer_ExchangeRate = "@Customer_ExchangeRate";
            Customer_Taxes = "@Customer_Taxes";
            Customer_DateTime = "@Customer_DateTime";
            Customer_Quote_Valid = "@Customer_Quote_Valid";
            Customer_Payment_Terms = "@Customer_Payment_Terms";
            Customer_Discount = "@Customer_Discount";
            Customer_BankAccount = "@Customer_BankAccount";
            Customer_Language = "@Customer_Language";
            Customer_Note = "@Customer_Note";
            Customer_Note2 = "@Customer_Note2";
        }

        public CTB_Customers(string ct0r2)
        {
            Customer_AutoNum = "Customer_AutoNum";
            Customer_Invoice_Number = "Customer_Invoice_Number";
            Customer_Company = "Customer_Company";
            Customer_Name = "Customer_Name";
            Customer_Mob = "Customer_Mob";
            Customer_Email = "Customer_Email";
            Customer_Currency = "Customer_Currency";
            Customer_ExchangeRate = "Customer_ExchangeRate";
            Customer_Taxes = "Customer_Taxes";
            Customer_DateTime = "Customer_DateTime";
            Customer_Quote_Valid = "Customer_Quote_Valid";
            Customer_Payment_Terms = "Customer_Payment_Terms";
            Customer_Discount = "Customer_Discount";
            Customer_BankAccount = "Customer_BankAccount";
            Customer_Language = "Customer_Language";
            Customer_Note = "Customer_Note";
            Customer_Note2 = "Customer_Note2";
        }
    }
}
