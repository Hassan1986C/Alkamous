

namespace Alkamous.Model
{
    public class CTB_UserLog
    {

        public string UserLog_Autonum { get; set; }
        public string UserLog_UserName { get; set; }
        public string UserLog_Opration_type { get; set; }
        public string UserLog_opration { get; set; }
        public string UserLog_datatime { get; set; }

        public CTB_UserLog()
        {
            UserLog_Autonum = "@UserLog_Autonum";
            UserLog_UserName = "@UserLog_UserName";
            UserLog_Opration_type = "@UserLog_Opration_type";
            UserLog_opration = "@UserLog_opration";
            UserLog_datatime = "@UserLog_datatime";
        }
        public CTB_UserLog(string ctos2)
        {
            UserLog_Autonum = "UserLog_Autonum";
            UserLog_UserName = "UserLog_UserName";
            UserLog_Opration_type = "UserLog_Opration_type";
            UserLog_opration = "UserLog_opration";
            UserLog_datatime = "UserLog_datatime";
        }

        public CTB_UserLog(string UserLog_UserName, string UserLog_Opration_type, string UserLog_opration)
        {
            this.UserLog_UserName = UserLog_UserName;
            this.UserLog_Opration_type = UserLog_Opration_type;
            this.UserLog_opration = UserLog_opration;
        }

    }
}
