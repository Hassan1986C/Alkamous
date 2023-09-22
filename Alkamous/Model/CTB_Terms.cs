

namespace Alkamous.Model
{
    public class CTB_Terms
    {
        public string Term_AutoNum { get; set; }

        public string Term_En { get; set; }

        public string Term_Ar { get; set; }


        public CTB_Terms()
        {
            Term_AutoNum = "@Term_AutoNum";
            Term_En = "@Term_En";
            Term_Ar = "@Term_Ar";
        }


        public CTB_Terms(string ct0r2)
        {
            Term_AutoNum = "Term_AutoNum";
            Term_En = "Term_En";
            Term_Ar = "Term_Ar";
        }



    }

}
