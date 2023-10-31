using System;

namespace Alkamous.Model
{
    public class CTB_Consumable
    {
        public string Consumable_AutoNum { get; set; }

        public string Consumable_Number { get; set; }

        public string Consumable_product_Id { get; set; }

        public string Consumable_Unit { get; set; }

        public string Consumable_QTY { get; set; }

        public string Consumable_Price { get; set; }

        public string Consumable_Amount { get; set; }


        public CTB_Consumable()
        {
            Consumable_AutoNum = "@Consumable_AutoNum";
            Consumable_Number = "@Consumable_Number";
            Consumable_product_Id = "@Consumable_product_Id";
            Consumable_Unit = "@Consumable_Unit";
            Consumable_QTY = "@Consumable_QTY";
            Consumable_Price = "@Consumable_Price";
            Consumable_Amount = "@Consumable_Amount";
        }

        public CTB_Consumable(string ct0r2)
        {
            Consumable_AutoNum = "Consumable_AutoNum";
            Consumable_Number = "Consumable_Number";
            Consumable_product_Id = "Consumable_product_Id";
            Consumable_Unit = "Consumable_Unit";
            Consumable_QTY = "Consumable_QTY";
            Consumable_Price = "Consumable_Price";
            Consumable_Amount = "Consumable_Amount";
        }


    }
}
