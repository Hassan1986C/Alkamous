using Alkamous.Model;
using System;
using System.Collections;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofBanks : InterfaceForAllClass.IBankAccounts
    {

        private readonly string ProcedureName = "SP_TB_Bank";
        DataAccessLayer DAL = new DataAccessLayer();


        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public bool Add_Acount(CTB_Banks item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewAccount" },
                { "@Bank_Definition", item.Bank_Definition  },
                { "@Bank_Beneficiary_Name ", item.Bank_Beneficiary_Name },
                { "@Bank_Bank_Name", item.Bank_Bank_Name  },
                { "@Bank_Branch", item. Bank_Branch  },
                { "@Bank_Branch_Code", item.Bank_Branch_Code  },
                { "@Bank_Bank_Address", item.Bank_Bank_Address  },
                { "@Bank_Swift_Code ", item.Bank_Swift_Code  },
                { "@Bank_Account_Number", item.Bank_Account_Number},
                { "@Bank_IBAN_Number", item.Bank_IBAN_Number},
                { "@Bank_COUNTRY", item.Bank_COUNTRY  },
                { "@Bank_Account_currency", item.Bank_Account_currency  },
            };

            return CheckResult(SL);
        }

        public bool Update_Acount(CTB_Banks item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_Account" },
                { "@Bank_AutoNumber", item.Bank_AutoNumber },
                { "@Bank_Definition", item.Bank_Definition  },
                { "@Bank_Beneficiary_Name ", item.Bank_Beneficiary_Name },
                { "@Bank_Bank_Name", item.Bank_Bank_Name  },
                { "@Bank_Branch", item. Bank_Branch  },
                { "@Bank_Branch_Code", item.Bank_Branch_Code  },
                { "@Bank_Bank_Address", item.Bank_Bank_Address  },
                { "@Bank_Swift_Code ", item.Bank_Swift_Code  },
                { "@Bank_Account_Number", item.Bank_Account_Number},
                { "@Bank_IBAN_Number", item.Bank_IBAN_Number},
                { "@Bank_COUNTRY", item.Bank_COUNTRY  },
                { "@Bank_Account_currency", item.Bank_Account_currency },

            };

            return CheckResult(SL);
        }

        public bool Delete_Acount(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_Account" },
                { "@Bank_Definition",Text},
            };

            return CheckResult(SL);
        }

        public DataTable Get_All()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_ALLAccount" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;

        }

        public DataTable Get_BySearch(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_BySearchAccount" },
                { "@Bank_Bank_Name", Text },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public DataTable Get_ByBank_Definition(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_ByBank_Definition" },
                { "@Bank_Definition", Text },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;
        }

        public bool Check_Bank_DefinitionNotDuplicate(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Check_Bank_DefinitionNotDuplicate" },
                { "@Bank_Definition", Text },

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
