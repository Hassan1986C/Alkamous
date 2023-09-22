using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofInvoices : IInvoices
    {
        private readonly string ProcedureName = "SP_TB_Invoices";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Invoices MTB_Invoices = new CTB_Invoices();
        List<SortedList> Listofsortedlis = new List<SortedList>();
        

        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public bool Add_NewInvoice(CTB_Invoices item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewInvoice" },
                { MTB_Invoices.Invoice_Number, item.Invoice_Number },
                { MTB_Invoices.Invoice_product_Id, item.Invoice_product_Id },
                { MTB_Invoices.Invoice_Unit, item.Invoice_Unit},
                { MTB_Invoices.Invoice_QTY , item.Invoice_QTY },
                { MTB_Invoices.Invoice_Price ,item. Invoice_Price },
                { MTB_Invoices.Invoice_Amount, item.Invoice_Amount },
            };

            return CheckResult(SL);
        }

        public void Add_NewInvoiceLIST(CTB_Invoices item)
        {

            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewInvoice" },
                { MTB_Invoices.Invoice_Number, item.Invoice_Number },
                { MTB_Invoices.Invoice_product_Id, item.Invoice_product_Id },
                { MTB_Invoices.Invoice_Unit, item.Invoice_Unit},
                { MTB_Invoices.Invoice_QTY , item.Invoice_QTY },
                { MTB_Invoices.Invoice_Price , item.Invoice_Price },
                { MTB_Invoices.Invoice_Amount, item.Invoice_Amount },
            };

            Listofsortedlis.Add(SL);

        }

        public void InsertBulk()
        {
            int result = DAL.RunProcedureBulk(ProcedureName, Listofsortedlis);
            Listofsortedlis.Clear();
        }

        public DataTable Get_Invoice_ByInvoice_Number(string Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_Invoice_ByInvoice_Number" },

                {MTB_Invoices.Invoice_Number, Invoice_Number}
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public void Delete_InvoiceByInvoice_Number(string Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_InvoiceByInvoice_Number" },
                { MTB_Invoices.Invoice_Number, Invoice_Number},

            };

            CheckResult(SL);
        }

    }
}
