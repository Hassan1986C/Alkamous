
namespace Alkamous.Model
{
    public class CTB_Banks
    {
        public string Bank_AutoNumber { get; set; }

        public string Bank_Definition { get; set; }

        public string Bank_Beneficiary_Name { get; set; }

        public string Bank_Bank_Name { get; set; }

        public string Bank_Branch { get; set; }

        public string Bank_Branch_Code { get; set; }

        public string Bank_Bank_Address { get; set; }

        public string Bank_Swift_Code { get; set; }

        public string Bank_Account_Number { get; set; }

        public string Bank_IBAN_Number { get; set; }

        public string Bank_COUNTRY { get; set; }

        public string Bank_Account_currency { get; set; }


        public CTB_Banks()
        {

        }

        public CTB_Banks(string Bank_AutoNumber, string Bank_Definition, string Bank_Beneficiary_Name, string Bank_Bank_Name, string Bank_Branch, string Bank_Branch_Code,
            string Bank_Bank_Address, string Bank_Swift_Cod, string Bank_Account_Number, string Bank_IBAN_Number, string Bank_COUNTRY, string Bank_Account_currency)
        {
            this.Bank_AutoNumber = Bank_AutoNumber;

            this.Bank_Definition = Bank_Definition;
            this.Bank_Beneficiary_Name = Bank_Beneficiary_Name;
            this.Bank_Bank_Name = Bank_Bank_Name;
            this.Bank_Branch = Bank_Branch;
            this.Bank_Branch_Code = Bank_Branch_Code;
            this.Bank_Bank_Address = Bank_Bank_Address;
            this.Bank_Swift_Code = Bank_Swift_Code;
            this.Bank_Account_Number = Bank_Account_Number;
            this.Bank_IBAN_Number = Bank_IBAN_Number;
            this.Bank_COUNTRY = Bank_COUNTRY;
            this.Bank_Account_currency = Bank_Account_currency;
        }

    }


}
