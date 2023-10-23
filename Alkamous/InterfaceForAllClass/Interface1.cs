using Alkamous.Model;
using System.Collections.Generic;
using System.Data;

namespace Alkamous.InterfaceForAllClass
{

    interface ICustomerInfo
    {
        bool Add_CustomerInfo(CTB_CustomerInfo item);
        bool Update_CustomerInfo(CTB_CustomerInfo item);
        bool Delete_CustomerInfo(string Text);
        DataTable Get_All();
        DataTable Get_BySearch(string Text);
        bool Check_CustomerInfo_NotDuplicate(string Text);

    }

    interface ICustomers
    {
        bool Add_Customer(CTB_Customers item);
        bool Update_CustomerData(CTB_Customers item);
        bool Delete_CustomerData(string Customer_Invoice_Number);
        DataTable Get_MaxCustomer_AutoNum();
        DataTable Get_AllCustomer(int PageNumber = 1, int PageSize = 50);
        DataTable Get_countCustomer();
        DataTable Get_AllCustomer_BySearch(string Customer_Invoice_Number, int PageNumber = 1, int PageSize = 50);
        DataTable Get_CustomerDetails_ByCustomer_Invoice_Number(string Customer_Invoice_Number);
        bool Check_Customer_Invoice_NumberNotDuplicate(string Customer_Invoice_Number);
    }

    interface IInvoices
    {
        bool Add_NewInvoice(CTB_Invoices item);
        void Add_NewInvoiceLIST(CTB_Invoices item);
        void InsertBulk();
        void Delete_InvoiceByInvoice_Number(string Invoice_Number);
        DataTable Get_Invoice_ByInvoice_Number(string Invoice_Number);
    }

    interface IConsumable
    {
        void Add_NewConsumableLIST(CTB_Consumable item);
        void InsertBulk();
        void Delete_ConsumableByConsumable_Number(string Consumable_Number);
        DataTable Get_Consumable_ByConsumable_Number(string Consumable_Number);
    }

    interface ITerms_Invoices
    {
        void Add_NewTerms_InvoiceLIST(CTB_Terms_Invoices item);
        void InsertBulk();
        void Delete_Terms_Invoice(string Term_Invoice_Number);
        DataTable Get_AllTerms_Invoice(int PageNumber = 1, int PageSize = 50);
        DataTable Get_AllTerms_Invoice_ByTerm_Invoice_Number(string Term_Invoice_Number);
    }

    interface IBankAccounts
    {
        bool Add_Acount(CTB_Banks item);
        bool Update_Acount(CTB_Banks item);
        bool Delete_Acount(string Text);
        DataTable Get_All();
        DataTable Get_BySearch(string Text);
        DataTable Get_ByBank_Definition(string Text);
        bool Check_Bank_DefinitionNotDuplicate(string Text);

    }

    interface ITerms
    {
        bool Add_Term(string Term_En, string Term_Ar);
        void Add_TermLIST(CTB_Terms item);
        bool Update_Term(string Term_AutoNum, string Term_En, string Term_Ar);
        bool Delete_Term(string Term_AutoNum);
        DataTable Get_AllTerm_BySearch(string search);
        DataTable Get_AllTerms();
    }

    interface IProducts
    {
        bool Add_Product(CTB_Products item);
        bool Update_Product(CTB_Products item);
        bool Delete_Product(string product_Id);
        DataTable Get_countProduct();
        DataTable Get_AllProduct(int PageNumber = 1, int PageSize = 5000);
        DataTable Get_AllProduct_BySearch(string search, int PageNumber = 1, int PageSize = 50);
        DataTable Get_Product_product_Id(string product_Id, int PageNumber = 1, int PageSize = 50);
        bool Check_ProductIdNotDuplicate(string product_Id);
    }


    //this interface created to apply the Solid principle Design pattern
    /// <summary>
    /// for All both
    /// </summary>
    /// <typeparam name="T">class Name person or employ or ..</typeparam>
    interface IUsers<T> /*where T : class*/
    {
        bool AddNew(T item);
        bool Delete(T item);
        bool Update(T item);
        T Get_AllBySearch(string Text);
        T Get_ByID(string Text);
        List<T> Get_ALL();

    }

}
