using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofTermsInvoices : ITerms_Invoices
    {
        private readonly string ProcedureName = "SP_TB_Terms_Invoices";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Terms_Invoices MTB_Terms_Invoices = new CTB_Terms_Invoices();


        List<SortedList> Listofsortedlis = new List<SortedList>();
        public void Add_NewTerms_InvoiceLIST(CTB_Terms_Invoices item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewTerms_Invoice" },
                { MTB_Terms_Invoices.Term_Invoice_Number, item.Term_Invoice_Number },
                {MTB_Terms_Invoices.Term_En , item.Term_En },
                {MTB_Terms_Invoices.Term_Ar , item.Term_Ar },

            };

            Listofsortedlis.Add(SL);
        }

        public void InsertBulk()
        {
            int result = DAL.RunProcedureBulk(ProcedureName, Listofsortedlis);
            // System.Windows.Forms.MessageBox.Show($"the result {result}");
            Listofsortedlis.Clear();
        }



        public void Delete_Terms_Invoice(string Term_Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_Terms_Invoice" },
                { MTB_Terms_Invoices.Term_Invoice_Number, Term_Invoice_Number },
            };

            DAL.RunProcedure(ProcedureName, SL);
        }

        public DataTable Get_AllTerms_Invoice(int PageNumber = 1, int PageSize = 50)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllTerm_BySearch" },
                {"@PageNumber",PageNumber },
                {"@PageSize",PageSize},
                {"@PageSize",PageSize},

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllTerms_Invoice_ByTerm_Invoice_Number(string Term_Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllTerms_Invoice_ByTerm_Invoice_Number" },
                {MTB_Terms_Invoices.Term_Invoice_Number,Term_Invoice_Number},

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }



        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }


    }
}
