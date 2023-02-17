using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_PURCHASE_AND_RETURN_MAIN
{

      public class cls_CTBL_PURCHASE_AND_RETURN_MAIN
      {

            public static string priPURCHASE_AND_RETURN_MAIN_ID = "PURCHASE_AND_RETURN_MAIN_ID";
            public static string maxPURCHASE_AND_RETURN_MAIN_maxID = "PURCHASE_AND_RETURN_MAIN_maxID";

            public static string PURCHASE_AND_RETURN_MAIN_supplierID = "PURCHASE_AND_RETURN_MAIN_supplierID";
            public static string PURCHASE_AND_RETURN_MAIN_VCHID = "PURCHASE_AND_RETURN_MAIN_VCHID";
            public static string PURCHASE_AND_RETURN_MAIN_cashOrCredit = "PURCHASE_AND_RETURN_MAIN_cashOrCredit";
            public static string PURCHASE_AND_RETURN_MAIN_purchaseOrReturn = "PURCHASE_AND_RETURN_MAIN_purchaseOrReturn";
            public static string PURCHASE_AND_RETURN_MAIN_date = "PURCHASE_AND_RETURN_MAIN_date";
            public static string PURCHASE_AND_RETURN_MAIN_reference = "PURCHASE_AND_RETURN_MAIN_reference";
            public static string PURCHASE_AND_RETURN_MAIN_narration = "PURCHASE_AND_RETURN_MAIN_narration";

            
            public static string PURCHASE_AND_RETURN_MAIN_totalAmount = "PURCHASE_AND_RETURN_MAIN_totalAmount";
            public static string PURCHASE_AND_RETURN_MAIN_totalPayableAmount = "PURCHASE_AND_RETURN_MAIN_totalPayableAmount";
            public static string PURCHASE_AND_RETURN_MAIN_discountAmount = "PURCHASE_AND_RETURN_MAIN_discountAmount";
            public static string PURCHASE_AND_RETURN_MAIN_paidAmount = "PURCHASE_AND_RETURN_MAIN_paidAmount";


            public static string priPURCHASE_AND_RETURN_DETAILS_ID = "PURCHASE_AND_RETURN_DETAILS_ID";
            public static string forPURCHASE_AND_RETURN_DETAILS_mainID = "PURCHASE_AND_RETURN_DETAILS_mainID";

            public static string A_PURCHASE_AND_RETURN_DETAILS_itemCOA = "A_PURCHASE_AND_RETURN_DETAILS_itemCOA";
            public static string A_PURCHASE_AND_RETURN_DETAILS_itemName = "A_PURCHASE_AND_RETURN_DETAILS_itemName";
            public static string A_PURCHASE_AND_RETURN_DETAILS_itemCode = "A_PURCHASE_AND_RETURN_DETAILS_itemCode";

            public static string PURCHASE_AND_RETURN_DETAILS_itemUnit = "PURCHASE_AND_RETURN_DETAILS_itemUnit";
            public static string A_PURCHASE_AND_RETURN_DETAILS_itemUnitCode = "A_PURCHASE_AND_RETURN_DETAILS_itemUnitCode";





            public static string PURCHASE_AND_RETURN_DETAILS_purchasePrice = "PURCHASE_AND_RETURN_DETAILS_purchasePrice";
            public static string PURCHASE_AND_RETURN_DETAILS_QTY = "PURCHASE_AND_RETURN_DETAILS_QTY";
            public static string PURCHASE_AND_RETURN_DETAILS_total = "PURCHASE_AND_RETURN_DETAILS_total";



      }
}
