

namespace Alkamous.Model
{
    public class CTB_Invoices
    {
        public string Invoice_AutoNum { get; set; }

        public string Invoice_Number { get; set; }

        public string Invoice_product_Id { get; set; }

        public string Invoice_Unit { get; set; }

        public string Invoice_QTY { get; set; }

        public string Invoice_Price { get; set; }

        public string Invoice_Amount { get; set; }


        public CTB_Invoices()
        {
            Invoice_AutoNum = "@Invoice_AutoNum";
            Invoice_Number = "@Invoice_Number";
            Invoice_product_Id = "@Invoice_product_Id";
            Invoice_Unit = "@Invoice_Unit";
            Invoice_QTY = "@Invoice_QTY";
            Invoice_Price = "@Invoice_Price";
            Invoice_Amount = "@Invoice_Amount";
        }

        public CTB_Invoices(string ct0r2)
        {
            Invoice_AutoNum = "Invoice_AutoNum";
            Invoice_Number = "Invoice_Number";
            Invoice_product_Id = "Invoice_product_Id";
            Invoice_Unit = "Invoice_Unit";
            Invoice_QTY = "Invoice_QTY";
            Invoice_Price = "Invoice_Price";
            Invoice_Amount = "Invoice_Amount";
        }
    }
}
