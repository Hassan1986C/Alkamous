using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System;
using System.Collections;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofProducts : IProducts
    {
        private readonly string ProcedureName = "SP_TB_Products";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Products MTB_Products = new CTB_Products();


        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public DataTable Get_AllProduct_BySearch(string search, int PageNumber = 1, int PageSize = 50)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllProduct_BySearch" },
                {"@PageNumber",PageNumber },
                {"@PageSize",PageSize},
                {MTB_Products.product_NameAr,search },

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public bool Add_Product(CTB_Products item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewProduct" },
                { MTB_Products.product_Id, item.product_Id },
                { MTB_Products.product_NameAr, item.product_NameAr },
                { MTB_Products.product_NameEn, item.product_NameEn },
                { MTB_Products.product_Price, item.product_Price },
                { MTB_Products.product_Unit, item.product_Unit },
            };

            return CheckResult(SL);
        }

        public bool Update_Product(CTB_Products item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_Product" },
                { MTB_Products.product_Id, item.product_Id },
                { MTB_Products.product_NameAr, item.product_NameAr },
                { MTB_Products.product_NameEn, item.product_NameEn },
                { MTB_Products.product_Price, item.product_Price },
                { MTB_Products.product_Unit, item.product_Unit },
            };

            return CheckResult(SL);
        }

        public bool Delete_Product(string product_Id)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_Product" },
                { MTB_Products.product_Id,product_Id},
            };

            return CheckResult(SL);
        }

        public DataTable Get_countProduct()
        {
            SortedList SL = new SortedList
                {
                { "@Check", "Get_countProduct" },
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }


        public DataTable Get_Product_product_Id(string product_Id, int PageNumber = 1, int PageSize = 50)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_Product_product_Id" },
                {"@PageNumber",PageNumber },
                {"@PageSize",PageSize},
                {MTB_Products.product_Id,product_Id },

            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_AllProduct(int PageNumber = 1, int PageSize = 5000)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllProduct" },
                { "@PageNumber", PageNumber },
                { "@PageSize", PageSize },
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public bool Check_ProductIdNotDuplicate(string product_Id)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Check_ProductIdNotDuplicate" },
                 { MTB_Products.product_Id, product_Id },

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
