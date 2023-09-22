using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System;
using System.Collections;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofCustomers : ICustomers
    {
        private readonly string ProcedureName = "SP_TB_Customers";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Customers MTB_Customers = new CTB_Customers();



        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }



        public bool Add_Customer(CTB_Customers item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewCustomer" },

                {MTB_Customers.Customer_Invoice_Number , item.Customer_Invoice_Number },
                {MTB_Customers.Customer_Company , item.Customer_Company },
                {MTB_Customers.Customer_Name  , item.Customer_Name },
                {MTB_Customers.Customer_Mob  , item.Customer_Mob },
                {MTB_Customers.Customer_Email , item.Customer_Email },
                {MTB_Customers.Customer_Currency ,item. Customer_Currency },
                {MTB_Customers.Customer_ExchangeRate , item.Customer_ExchangeRate },
                {MTB_Customers.Customer_Taxes , item.Customer_Taxes },
                {MTB_Customers.Customer_DateTime , item.Customer_DateTime },
                {MTB_Customers.Customer_Quote_Valid , item.Customer_Quote_Valid },
                {MTB_Customers.Customer_Payment_Terms , item.Customer_Payment_Terms },
                {MTB_Customers.Customer_Discount , item.Customer_Discount },
                {MTB_Customers.Customer_BankAccount , item.Customer_BankAccount },
                {MTB_Customers.Customer_Language , item.Customer_Language },
                {MTB_Customers.Customer_Note , item.Customer_Note },
            };

            return CheckResult(SL);

        }

        public bool Update_CustomerData(CTB_Customers item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_CustomerData" },
                {MTB_Customers.Customer_Invoice_Number , item.Customer_Invoice_Number },
                {MTB_Customers.Customer_Company , item.Customer_Company },
                {MTB_Customers.Customer_Name  , item.Customer_Name },
                {MTB_Customers.Customer_Mob  , item.Customer_Mob },
                {MTB_Customers.Customer_Email , item.Customer_Email },
                {MTB_Customers.Customer_Currency ,item. Customer_Currency },
                {MTB_Customers.Customer_ExchangeRate , item.Customer_ExchangeRate },
                {MTB_Customers.Customer_Taxes , item.Customer_Taxes },
                {MTB_Customers.Customer_DateTime , item.Customer_DateTime },
                {MTB_Customers.Customer_Quote_Valid , item.Customer_Quote_Valid },
                {MTB_Customers.Customer_Payment_Terms , item.Customer_Payment_Terms },
                {MTB_Customers.Customer_Discount , item.Customer_Discount },
                {MTB_Customers.Customer_BankAccount , item.Customer_BankAccount },
                {MTB_Customers.Customer_Language , item.Customer_Language },
                {MTB_Customers.Customer_Note , item.Customer_Note },
            };

            return CheckResult(SL);
        }

        public bool Delete_CustomerData(string Customer_Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_CustomerData" },
                {MTB_Customers.Customer_Invoice_Number , Customer_Invoice_Number },

            };

            return CheckResult(SL);
        }

        public DataTable Get_MaxCustomer_AutoNum()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_MaxCustomer_AutoNum" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllCustomer()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllCustomer" },


            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_countCustomer()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_countCustomer" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_CustomerDetails_ByCustomer_Invoice_Number(string Customer_Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_CustomerDetails_ByCustomer_Invoice_Number" },
                {MTB_Customers.Customer_Invoice_Number, Customer_Invoice_Number}

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllCustomer_BySearch(string Customer_Invoice_Number, int PageNumber = 1, int PageSize = 50)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllCustomer_BySearch" },
                {"@PageNumber",PageNumber },
                {"@PageSize",PageSize},
                {MTB_Customers.Customer_Invoice_Number, Customer_Invoice_Number}
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllCustomer(int PageNumber = 1, int PageSize = 50)
        {
            throw new NotImplementedException();
        }

        public bool Check_Customer_Invoice_NumberNotDuplicate(string Customer_Invoice_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Check_Customer_Invoice_NumberNotDuplicate" },
                { MTB_Customers.Customer_Invoice_Number, Customer_Invoice_Number },

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
