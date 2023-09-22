
namespace Alkamous.Model
{
    public class CTB_CustomerInfo
    {
        public string Customer_AutoNum { get; set; }

        public string Customer_Company { get; set; }

        public string Customer_Name { get; set; }

        public string Customer_Mob { get; set; }

        public string Customer_Email { get; set; }


        public CTB_CustomerInfo()
        {
            Customer_AutoNum = "@Customer_AutoNum";
            Customer_Company = "@Customer_Company";
            Customer_Name = "@Customer_Name";
            Customer_Mob = "@Customer_Mob";
            Customer_Email = "@Customer_Email";
        }


    }
}
