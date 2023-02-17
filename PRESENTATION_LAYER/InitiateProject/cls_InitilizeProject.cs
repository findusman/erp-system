using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PRESENTATION_LAYER.InitiateProject
{
    public class cls_InitilizeProject
    {

          DATASET.GEN_DATASET.cls_DataSet objcls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
          GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
      
        public void initialize(string pUserRightID)
        {

               //GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID = pUserRightID;
               GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

               DataSet ds = objcls_DataSet.f_TBL_RIGHTS_MAIN("Load All Rights To Be Assigned", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID_RIGHTS_MAIN_rightAssigner);
              if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
              {
                    obj_cls_MessageBox.MessageBoxStatic("INI_E");
                    return ;
              }

              GEN.GEN_GEN.GenericClasses.cls_GENGlobalDataTables.TBL_rightsMain = ds.Tables[0].Copy();
              GEN.GEN_GEN.GenericClasses.cls_GENGlobalDataTables.TBL_rightsDetail_Visible_NonActions = ds.Tables[1].Copy();
              GEN.GEN_GEN.GenericClasses.cls_GENGlobalDataTables.TBL_rightsDetail_Visible_Actions = ds.Tables[2].Copy();
              GEN.GEN_GEN.GenericClasses.cls_GENGlobalDataTables.TBL_rightsDetail_Value = ds.Tables[3].Copy();



            //cls_initializeImage obj_cls_initializeImage = new cls_initializeImage();
           // bool is_All_Images_Loded_Propoerly = obj_cls_initializeImage.loadgimages();




        }


       

    }
}
