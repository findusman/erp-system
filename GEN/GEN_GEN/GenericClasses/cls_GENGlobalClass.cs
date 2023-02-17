using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace GEN.GEN_GEN.GenericClasses
{
    public class cls_GENGlobalClass
    {


        public static String GV_RightID;
       

        public static string GV_CMP_ID = null;
        public static string GV_BRC_ID = null;
        public static string GV_USER_ID = "";
        public static string GV_RightID_RIGHTS_MAIN_rightAssigner = "";
        
        public static Boolean GV_isDeleted = false;

        public static string formatForDefaultDateTimeValuesInRights = "dd-MM-yyyy hh:mm ss tt";
     
          

        public static string GV_PID = null;

        public static string GV_RightLevel;
        

        public static string GV_COA_nature = "";
        public static int GV_COA_type = 0;

        
        public static char GV_levelSeparator ;

        public static string GV_COMPANY_NAME = "786 Software Technologies";

        public static DateTime GV_DefaultFromDate = DateTime.Now;
        public static DateTime GV_DefaultToDate = DateTime.Now;
        public static string GV_DefaultCOA = "01-01-03-0001";

        public static DateTime GV_FinancialYearFromDate = Convert.ToDateTime("1/1/2014");
        public static DateTime GV_FinancialYearToDate = Convert.ToDateTime("12/31/2014");

        public static String formatN1 = "N1";//"#.0";
        public static String formatN2 = "N1"; //"#.00";
        public static String formatN3 = "N1";//"#.000";
        public static String formatN4 = "N1";//"#.0000";



        //        Default Account
        public static string GV_ACCFirstLevelForITEM_CAT = "01";
        public static string GV_ACCSecondLevelForITEM_CAT = "01";

        public static int GV_DefaultCOATypeForITEM_CAT = 1;

        public static int GV_GridLookUpEditPopWidthSmall = 300;
        public static int GV_GridLookUpEditPopWidthMedium = 400;
        public static int GV_GridLookUpEditPopWidthlarge = 500;

        public static int GV_GridLookUpEditPopHeightSmall = 15;
        public static int GV_GridLookUpEditPopHeightMedium = 25;
        public static int GV_GridLookUpEditPopHeightlarge = 35;

        public static int GV_RepositoryLookUpEditPopWidthSmall = 300;
        public static int GV_RepositoryLookUpEditPopWidthMedium = 400;
        public static int GV_RepositoryLookUpEditPopWidthlarge = 500;

        public static int GV_RepositoryLookUpEditPopHeightSmall = 15;
        public static int GV_RepositoryLookUpEditPopHeightMedium = 25;
        public static int GV_RepositoryLookUpEditPopHeightlarge = 35;

        public static int GV_RepositoryGridLookUpEditPopHeight = 1000;
        public static int GV_RepositoryGridLookUpEditPopWidth = 700;
        public static int GV_RepositoryGridLookUpEditPopValueMemberWidth = 100;



        public static string GV_InsertRifhtStatus = "insert";
        public static string GV_DeleteRifhtStatus = "delete";
        public static string GV_UpdateRifhtStatus = "update";
        public static string GV_PrintRifhtStatus = "print";
        public static Boolean GV_ColumnVisible = false;



        public static string Is_Auto_Generated = "Is_Auto_Generated";



        public static string GV_InsertLogDescription = "Record is inserted.";
        public static string GV_DeleteLogDescription = "Record is deleted.";
        public static string GV_UpdateLogDescription = "Record is updated.";
        public static string GV_ScreenOpenedLogDescription = "Screen is opened.";

        public static string GV_InsertLogEvent = "Insertion";
        public static string GV_DeleteLogEvent = "Deletion";
        public static string GV_UpdateLogEvent = "Updation";
        public static string GV_ScreenOpenedLogEvent = "Opening";

    }
}
