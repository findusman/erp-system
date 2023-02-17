using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace GEN.IMS_GEN.Generics
{
    public class cls_IMSGlobalClass
    {

        //        Default Account
        public static string GV_ACCFirstLevelForITEM_CAT = "01";
        public static string GV_ACCSecondLevelForITEM_CAT = "01";


        public static string GV_ITEMFirstLevelForITEM_CAT = "01";
        public static string GV_ITEMSecondLevelForITEM_CAT = "01";


        public static string getItemPrefixID()
        {
            return GV_ITEMFirstLevelForITEM_CAT + "-" +GV_ITEMSecondLevelForITEM_CAT + "-";
         
        }
        public static int GV_DefaultCOATypeForITEM_CAT = 1;
        public static int GV_DefaultCOATypeForITEM = 1;

        #region Units

        public static int? GV_MaxUnitLevel = 3;


        #endregion
      

    }
}
