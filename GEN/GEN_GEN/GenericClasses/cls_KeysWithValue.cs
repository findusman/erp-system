using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GEN.GEN_GEN.GenericClasses
{
      public class cls_KeysWithValue
      {
            public static DataTable dt_KeysWithValues = null;

            public static string Parent_Of_Departments = "";
            public static string Parent_Of_Customer = "";
            public static string Parent_Of_Supplier = "";
            
            public static string Credit_Sales = "";
            public static string Credit_Sales_Returns = "";
            public static string Credit_Purchase = "";
            public static string Credit_Purchase_Return = "";
            
            public static string Sales_Discount = "";
            public static string Purchase_Discount = "";
            
            public static string Cash_In_Hand = "";



            public bool loadKeysWithValues(DataTable dtTable)
            {
                  try
                  {

                        dt_KeysWithValues = dtTable;

                        if ((Parent_Of_Departments = returnValueAgainstKey("Parent_Of_Departments")) == "") return false;
                        if ((Parent_Of_Customer = returnValueAgainstKey("Parent_Of_Customer")) == "") return false;
                        if ((Parent_Of_Supplier = returnValueAgainstKey("Parent_Of_Supplier")) == "") return false;
                        if ((Credit_Sales = returnValueAgainstKey("Credit_Sales")) == "") return false;
                        if ((Credit_Sales_Returns = returnValueAgainstKey("Credit_Sales_Returns")) == "") return false;
                        if ((Credit_Purchase = returnValueAgainstKey("Credit_Purchase")) == "") return false;
                        if ((Credit_Purchase_Return = returnValueAgainstKey("Credit_Purchase_Return")) == "") return false;
                        if ((Sales_Discount = returnValueAgainstKey("Sales_Discount")) == "") return false;
                        if ((Purchase_Discount = returnValueAgainstKey("Purchase_Discount")) == "") return false;
                        if ((Cash_In_Hand = returnValueAgainstKey("Cash_In_Hand")) == "") return false;


                  }
                  catch (Exception ex)
                  { 
                  
                  }
 
                 return true;
            }


            string returnValueAgainstKey(string pKEY_key)
            {

                  DataRow[] tmpdr = dt_KeysWithValues.Select("KEY_key = '" + pKEY_key + "'");

                  if (tmpdr.Length > 0)
                        return tmpdr[0]["DEFAULT_ACCT_CODE"].ToString();
                  else
                        return "";

            }
      }
}
