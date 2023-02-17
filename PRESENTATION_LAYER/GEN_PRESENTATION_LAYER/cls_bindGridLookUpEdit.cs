using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER
{
    class cls_bindGridLookUpEdit
    {





          public static bool TBL_RIGHTS_MAIN(GridLookUpEdit objGridLookUpEdit)
          {

                DATASET.GEN_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_RIGHTS_MAIN("L", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID_RIGHTS_MAIN_rightAssigner);
                DataSet ds = obj_cls_DataSet.g_TBL_RIGHTS_MAIN;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.RIGHTS_MAIN_name,
                    BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.priRIGHTS_MAIN_ID,
                    BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.RIGHTS_MAIN_name,
                    BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.priRIGHTS_MAIN_ID,
                    "Names",
                    "IDs",
                    ds,
                    BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.priRIGHTS_MAIN_ID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    100,
                    "",
                    false,
                    true,
                    true

                    );

                return true;


          }


          public static bool TBL_RIGHTS_TEMPLATE(GridLookUpEdit objGridLookUpEdit)
          {

                DATASET.GEN_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_RIGHTS_TEMPLATE("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_RIGHTS_TEMPLATE;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_name,
                    BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_primaryKey,
                    BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_name,
                    BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_primaryKey,
                    "Names",
                    "IDs",
                    ds,
                    BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_primaryKey,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    100,
                    "",
                    false,
                    true,
                    true

                    );

                return true;


          }  


        public static bool TBL_KEYS_TYPES(GridLookUpEdit objGridLookUpEdit)
        {

            DATASET.GEN_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();


            obj_cls_DataSet.f_TBL_KEYS_TYPES("L", "");
            DataSet ds = obj_cls_DataSet.g_TBL_KEYS_TYPES;

            if (ds == null)
            {

                return false;
            }

            GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                objGridLookUpEdit,
                BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
                BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
                BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
                BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
                "Names",
                "Names",
                ds,
                BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                100,
                "",
                false,
                true,
                true

                );

            return true;


        }
      
        //public static bool TBL_KEYS_TYPES(GridLookUpEdit objGridLookUpEdit)
        //{
        //    DATASET.GEN_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();

        //    obj_cls_DataSet.f_TBL_KEYS_TYPES("L", "");
        //    DataSet ds = obj_cls_DataSet.g_TBL_KEYS_TYPES;

        //        if (ds == null)
        //        {
        //            return false;
        //        }

        //        GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

        //            objGridLookUpEdit,
        //            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
        //            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
        //            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
        //            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
        //            "Names",
        //            "Names",
        //            ds,
        //            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_CTBL_KEYS_TYPES.KEYS_TYPES_name,
        //            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
        //            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
        //            100,
        //            "",
        //            false,
        //            true,
        //            true

        //            );
        //        return true;
        //    }

    }
}
