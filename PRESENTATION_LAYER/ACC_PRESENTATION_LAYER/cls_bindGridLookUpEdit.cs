using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER
{
    class cls_bindGridLookUpEdit
    {


          public static bool TBL_FINANCIAL_YEAR(GridLookUpEdit objGridLookUpEdit)
          {

                DATASET.ACC_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_FINANCIAL_YEAR("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_FINANCIAL_YEAR;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_CTBL_FINANCIAL_YEAR.FINANCIAL_YEAR_name,
                    BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_CTBL_FINANCIAL_YEAR.priFINANCIAL_YEAR_ID,
                    BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_CTBL_FINANCIAL_YEAR.FINANCIAL_YEAR_name,
                    BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_CTBL_FINANCIAL_YEAR.priFINANCIAL_YEAR_ID,
                    "Names",
                    "IDs",
                    ds,
                    BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_CTBL_FINANCIAL_YEAR.priFINANCIAL_YEAR_ID,
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

          public static bool TBL_COA_FinancialAndTransaction(object pControl , string pDisplayMember )
          {
                DATASET.ACC_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
                obj_cls_DataSet.f_TBL_COA(
                      "L_Type_Transaction_Active",
                      "",
                      "",
                      "",
                      0,
                      0,
                      0,
                      0,
                      false,
                      false,
                      true,
                      true,
                      false);
                DataSet ds = obj_cls_DataSet.g_TBL_COA;

                if (ds == null)
                {
                      return false;
                }


                Type obj_TYPE = pControl.GetType();
                if (obj_TYPE == typeof(RepositoryItemGridLookUpEdit))
                {
                      RepositoryItemGridLookUpEdit objRepositoryItemGridLookUpEdit = (RepositoryItemGridLookUpEdit)pControl;

                      if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(ds))
                      {

                            GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(

                            objRepositoryItemGridLookUpEdit,
                            pDisplayMember,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            "Names",
                            "IDs",
                            ds.Tables[0],
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightlarge,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthSmall,
                            100,
                            "",
                            false,
                            true,
                            false

                            );
                      }
                }
                if (obj_TYPE == typeof(GridLookUpEdit))
                {
                      GridLookUpEdit objGridLookUpEdit = (GridLookUpEdit)pControl;


                      GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    pDisplayMember,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            "Names",
                            "IDs",
                    ds,
                    ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    100,
                    BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                    false,
                    true,
                    true

                    );
                }









                return true;


          }
       

    }
}
