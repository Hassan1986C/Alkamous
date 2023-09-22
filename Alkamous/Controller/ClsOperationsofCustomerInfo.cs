using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System;
using System.Collections;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofCustomerInfo : ICustomerInfo
    {
        private readonly string ProcedureName = "SP_TB_CustomersInfo";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_CustomerInfo MTB_CustomerInfo = new CTB_CustomerInfo();

        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }


        public bool Add_CustomerInfo(CTB_CustomerInfo item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_CustomerInfo" },
                {MTB_CustomerInfo.Customer_Company , item.Customer_Company },
                {MTB_CustomerInfo.Customer_Name  , item.Customer_Name },
                {MTB_CustomerInfo.Customer_Mob  , item.Customer_Mob },
                {MTB_CustomerInfo.Customer_Email  , item.Customer_Email },
            };

            return CheckResult(SL);
        }

        public bool Update_CustomerInfo(CTB_CustomerInfo item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_CustomerInfo" },

                {MTB_CustomerInfo.Customer_AutoNum , item.Customer_AutoNum },
                {MTB_CustomerInfo.Customer_Company , item.Customer_Company },
                {MTB_CustomerInfo.Customer_Name  , item.Customer_Name },
                {MTB_CustomerInfo.Customer_Mob  , item.Customer_Mob },
                {MTB_CustomerInfo.Customer_Email  , item.Customer_Email },
            };

            return CheckResult(SL);
        }

        public bool Delete_CustomerInfo(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_CustomerInfo" },

                {MTB_CustomerInfo.Customer_AutoNum , Text },

            };

            return CheckResult(SL);
        }

        public DataTable Get_All()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllCustomerInfo" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_BySearch(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllCustomerInfo_BySearch" },
                {MTB_CustomerInfo.Customer_Name , Text },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public bool Check_CustomerInfo_NotDuplicate(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Check_CustomerInfoNotDuplicate" },
                { MTB_CustomerInfo.Customer_Mob, Text},

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            int result = Convert.ToInt16(dt.Rows[0][0]);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
