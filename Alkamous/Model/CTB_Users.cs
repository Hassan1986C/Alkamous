namespace Alkamous.Model
{
    public class CTB_Users
    {
        public string User_AutoNum { get; set; }
        public string UserName { get; set; }
        public byte[] UserPassword { get; set; }
        public byte[] UserAESKey { get; set; }
        public byte[] UserAESIV { get; set; }

        public CTB_Users()
        {

        }
        public CTB_Users(string User_AutoNum, string UserName, byte[] UserPassword, byte[] UserAESKey, byte[] UserAESIV)
        {
            this.User_AutoNum = User_AutoNum;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserAESKey = UserAESKey;
            this.UserAESIV = UserAESIV;
        }
    }
}
