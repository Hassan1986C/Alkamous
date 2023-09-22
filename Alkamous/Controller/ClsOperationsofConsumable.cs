using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofConsumable : IConsumable
    {

        private readonly string ProcedureName = "SP_TB_Consumable";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_Consumable MTB_Consumable = new CTB_Consumable();
        List<SortedList> Listofsortedlis = new List<SortedList>();


        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public void Add_NewConsumableLIST(CTB_Consumable item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewConsumable" },

                {MTB_Consumable.Consumable_Number , item.Consumable_Number },
                {MTB_Consumable.Consumable_product_Id , item.Consumable_product_Id },
                {MTB_Consumable.Consumable_Unit , item.Consumable_Unit },
                {MTB_Consumable.Consumable_QTY , item.Consumable_QTY },
                {MTB_Consumable.Consumable_Price , item.Consumable_Price },
                {MTB_Consumable.Consumable_Amount  , item.Consumable_Amount  },
            };

            Listofsortedlis.Add(SL);
        }

        public void InsertBulk()
        {
            int result = DAL.RunProcedureBulk(ProcedureName, Listofsortedlis);
            Listofsortedlis.Clear();
        }

        public void Delete_ConsumableByConsumable_Number(string Consumable_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_ConsumableByConsumable_Number" },
                { MTB_Consumable.Consumable_Number, Consumable_Number },

            };

            CheckResult(SL);
        }

        public DataTable Get_Consumable_ByConsumable_Number(string Consumable_Number)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_Consumable_ByConsumable_Number" },

                { MTB_Consumable.Consumable_Number, Consumable_Number },
            };

            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }
    }
}
