using Alkamous.InterfaceForAllClass;
using Alkamous.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.Controller
{
    public class ClsOperationsofUserLogFile : IUsers<CTB_UserLog>
    {

        private readonly string ProcedureName = "SP_TB_UsersLog";
        DataAccessLayer DAL = new DataAccessLayer();
        CTB_UserLog MTB_UserLog = new CTB_UserLog();


        private bool CheckResult(SortedList SL)
        {
            int result = DAL.RunProcedure(ProcedureName, SL);
            return result == 1;
        }

        public bool AddNew(CTB_UserLog item)
        {
            SortedList SL = new SortedList
            {
                { "@Check", "Add_NewUserLog" },
                { MTB_UserLog.UserLog_UserName, item.UserLog_UserName },
                { MTB_UserLog.UserLog_Opration_type, item.UserLog_Opration_type},
                { MTB_UserLog.UserLog_opration, item.UserLog_opration},
            };

            return CheckResult(SL);
        }

        public bool Delete(CTB_UserLog item)
        {

            SortedList SL = new SortedList
            {
                { "@Check", "Delete_AllUsersLog" },
            };

            return CheckResult(SL);
        }

        public bool Update(CTB_UserLog item)
        {
            throw new NotImplementedException();
        }

        public List<CTB_UserLog> Get_ALL()
        {

            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllUserLog" },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);

            if (dt.Rows.Count > 0)
            {
                var Mylist = dt.ConvertDataTableToList<CTB_UserLog>();

                return Mylist;
            }
            else
            {
                return null;
            }

        }

        public List<CTB_UserLog> Get_AllLOGBySearc(string Text)
        {

            SortedList SL = new SortedList
            {
                { "@Check", "Get_AllUserLogs_BySearch" },
                { "@UserLog_UserName", Text },

            };
            DataTable dt = DAL.SelectDB(ProcedureName, SL);

            if (dt.Rows.Count > 0)
            {
                var Mylist = dt.ConvertDataTableToList<CTB_UserLog>();

                return Mylist;
            }
            else
            {
                return null;
            }

        }

        public CTB_UserLog Get_AllBySearch(string Text)
        {
            throw new NotImplementedException();
        }

        public CTB_UserLog Get_ByID(string Text)
        {
            throw new NotImplementedException();
        }
    }
}
