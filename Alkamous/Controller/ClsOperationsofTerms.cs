using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System.Collections;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofTerms : ITerms
    {
        private readonly string ProcedureName = "SP_TB_Terms";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Terms MTB_Terms = new CTB_Terms();

        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public bool Add_Term(string Term_En, string Term_Ar)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewTerm" },
                {MTB_Terms.Term_En , Term_En },
                {MTB_Terms.Term_Ar , Term_Ar },

            };

            return CheckResult(SL);
        }

        public bool Update_Term(string Term_AutoNum, string Term_En, string Term_Ar)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_Term" },
                {MTB_Terms.Term_AutoNum , Term_AutoNum },
                {MTB_Terms.Term_En , Term_En },
                {MTB_Terms.Term_Ar , Term_Ar },

            };

            return CheckResult(SL);
        }

        public bool Delete_Term(string Term_AutoNum)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_Term" },
                {MTB_Terms.Term_AutoNum , Term_AutoNum },

            };

            return CheckResult(SL);
        }

        public DataTable Get_AllTerm_BySearch(string search)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllTerm_BySearch" },

                {MTB_Terms.Term_En,search},

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllTerms()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllTerms" },
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

    }
}
