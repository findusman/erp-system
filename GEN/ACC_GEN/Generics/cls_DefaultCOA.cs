using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GEN.ACC_GEN.Generics
{
    public class cls_DefaultCOA
    {

        public string initiateCOA(DataSet pcls_COA)
        {

            DataTable dtTemp = pcls_COA.Tables[0];
            return "ok";
        }

        public static string Assets = null;
        public static string Bank_Accounts = null;
        public static string Business_Purchase = null;
        public static string Business_Sales = null;

        public static string Cash_Accounts = null;
        public static string Cash_Purchase = null;
        public static string Cash_Purchase_Discount = null;
        public static string Cash_Purchase_Returns = null;

        public static string Cash_Sales = null;
        public static string Cash_Sales_Discount = null;
        public static string Cash_Sales_Return = null;
        public static string Credit_Purchase = null;

        public static string Credit_Purchase_Discount = null;
        public static string Credit_Purchase_Returns = null;
        public static string Credit_Sales = null;
        public static string Credit_Sales_Discount = null;

        public static string Credit_Sales_Return = null;
        public static string Current_Assets = null;
        public static string Current_Liabilities = null;
        public static string Customers = null;

        public static string Equity = null;
        public static string Expense = null;
        public static string Fixed_Assets = null;
        public static string Fixed_Liabilities = null;

        public static string Income = null;
        public static string Inventory = null;
        public static string Liability = null;
        public static string Purchase = null;

        public static string Purchase_Discount = null;
        public static string Purchase_Return = null;
        public static string Sales =null;
        public static string Sales_Discount = null;

        public static string Sales_Retun = null;
        public static string Suppliers = null;

        public static string Parent_Of_Customer = "Parent Of Customer";
        public static string Parent_Of_Supplier = "Parent Of Supplier";
        public static string Department = "Departments";
    }

}

