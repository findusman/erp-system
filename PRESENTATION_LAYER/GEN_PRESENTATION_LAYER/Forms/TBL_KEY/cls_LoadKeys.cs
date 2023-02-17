using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_KEY
{
      public class cls_LoadKeys
    {
            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
          


            public   bool loadKeysWithValues()
            {
                  try
                  {

                        DATASET.GEN_DATASET.cls_DataSet objcls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
                        objcls_DataSet.f_TBL_DEFAULT_ACCT("A", "", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, 0, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);


                        GEN.GEN_GEN.GenericClasses.cls_KeysWithValue obj_cls_KeysWithValue = new GEN.GEN_GEN.GenericClasses.cls_KeysWithValue();
                        if (!obj_cls_KeysWithValue.loadKeysWithValues(objcls_DataSet.g_TBL_DEFAULT_ACCT.Tables[0])) 
                        {

                              obj_cls_MessageBox.MessageBoxStatic("Key_Are_Not_Properly_Loaded");
                        }


                  }
                  catch (Exception ex)
                  { 
                  
                  }
 
                 return false;
            }


    }
}
