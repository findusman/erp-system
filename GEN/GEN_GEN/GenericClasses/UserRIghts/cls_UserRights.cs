using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEN.GEN_GEN.GenericClasses.UserRIghts
{
    public class cls_UserRights
    {


        public static List<List<String>> setRights(String pFormName, String pStatus)
        {
            List<List<String>> tmpAll = new List<List<String>>();

            List<String> tmp = new List<String>();
            tmp.Add("True");
            tmp.Add(cls_GENGlobalClass.GV_InsertRifhtStatus);
            tmpAll.Add(tmp);

            List<String> tmp1 = new List<String>();
            tmp1.Add("True");
            tmp1.Add(cls_GENGlobalClass.GV_UpdateRifhtStatus);
            tmpAll.Add(tmp1);


            List<String> tmm2 = new List<String>();
            tmm2.Add("True");
            tmm2.Add(cls_GENGlobalClass.GV_DeleteRifhtStatus);
            tmpAll.Add(tmm2);


            List<String> tmp3 = new List<String>();
            tmp3.Add("True");
            tmp3.Add(cls_GENGlobalClass.GV_PrintRifhtStatus);
            tmpAll.Add(tmp3);



            return tmpAll;

        }
        public static bool isThisScreenAllowed(String pFormName, String pStatus)
        {


            return true;
        }

    }
}
