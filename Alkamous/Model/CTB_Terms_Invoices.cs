

namespace Alkamous.Model
{
    public class CTB_Terms_Invoices
    {
        public string Term_Invoice_Number { get; set; }

        public string Term_En { get; set; }

        public string Term_Ar { get; set; }

        public CTB_Terms_Invoices()
        {

            Term_Invoice_Number = "@Term_Invoice_Number";
            Term_En = "@Term_En";
            Term_Ar = "@Term_Ar";

        }

        public CTB_Terms_Invoices(string ct0r2)
        {
            Term_Invoice_Number = "Term_Invoice_Number";
            Term_En = "Term_En";
            Term_Ar = "Term_Ar";
        }


        public CTB_Terms_Invoices(string Term_Invoice_Number, string Term_En, string Term_Ar)
        {

        }
    }
}
