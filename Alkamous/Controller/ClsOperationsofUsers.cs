using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.Controller
{
    // this interface created to apply the Solid principle Design pattern
    public class ClsOperationsofUsers : IUsers<CTB_Users>
    {

        private readonly string ProcedureName = "SP_TB_Users";
        DataAccessLayer DAL = new DataAccessLayer();


        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public bool AddNew(CTB_Users item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewUser" },
                { "@UserName", item.UserName },
                { "@UserPassword", item.UserPassword  },
                { "@UserAESKey", item.UserAESKey  },
                { "@UserAESIV", item.UserAESIV  },
            };

            return CheckResult(SL);
        }

        public bool Delete(CTB_Users item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Delete_User" },
                { "@UserName", item.UserName },

            };

            return CheckResult(SL);
        }

        public bool Update(CTB_Users item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Update_User" },
                { "@UserName", item.UserName },
                { "@UserPassword", item.UserPassword  },
                { "@UserAESKey", item.UserAESKey  },
                { "@UserAESIV", item.UserAESIV  },
            };

            return CheckResult(SL);
        }

        public DataTable Get_ALLData()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_ALLUsers" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            return dt;

        }



        public List<CTB_Users> Get_ALL()
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_ALLUsers" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);

            if (dt.Rows.Count > 0)
            {
                var Mylist = dt.ConvertDataTableToList<CTB_Users>();

                return Mylist;
            }
            else
            {
                return null;
            }
        }

        public CTB_Users Get_AllBySearch(string Text)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Get_UsersByUserName" },
                { "@UserName", Text },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);
            if (dt.Rows.Count > 0)
            {
                var Mylist = dt.ConvertDataTableToList<CTB_Users>();
                return Mylist[0];
            }
            else
            {
                return null;
            }
        }

        public CTB_Users Get_ByID(string Text)
        {
            throw new NotImplementedException();
        }

        public T AddAA<T>(string text)
        {
            throw new NotImplementedException();
        }

        public DataTable selectedBBB<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
