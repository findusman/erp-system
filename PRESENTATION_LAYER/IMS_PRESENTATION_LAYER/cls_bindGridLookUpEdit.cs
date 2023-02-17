using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER
{
      class cls_bindGridLookUpEdit
      {

            public static bool TBL_UNITS(GridLookUpEdit objGridLookUpEdit, string pStatus, string pID)
            {

                  DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                  obj_cls_DataSet.f_TBL_UNITS(pStatus, pID);
                  DataSet ds = obj_cls_DataSet.g_TBL_UNITS;

                  if (ds == null)
                  {

                        return false;
                  }

                  GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                      objGridLookUpEdit,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                      "Names",
                      "IDs",
                      ds,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                      100,
                      BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                      true,
                      true,
                      false

                      );

                  return true;


            }
           
            
            public static bool TBL_PACKINGS_MAIN(GridLookUpEdit objGridLookUpEdit)
            {

                  DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                  obj_cls_DataSet.f_TBL_PACKINGS_MAIN("L", "");
                  DataSet ds = obj_cls_DataSet.g_TBL_PACKINGS_MAIN;

                  if (ds == null)
                  {

                        return false;
                  }

                  GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                      objGridLookUpEdit,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.PACKING_MAIN_name,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.priPACKING_MAIN_ID,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.PACKING_MAIN_name,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.priPACKING_MAIN_ID,
                      "Names",
                      "IDs",
                      ds,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.priPACKING_MAIN_ID,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                      100,
                      BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_CTBL_PACKINGS_MAIN.priPACKING_MAIN_ID,
                      false,
                      true,
                      true

                      );

                  return true;


            }

            public static bool TBL_VEHICLE_MAKERS(GridLookUpEdit objGridLookUpEdit)
            {

                  DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                  obj_cls_DataSet.f_TBL_VEHICLE_MAKERS("L", "");
                  DataSet ds = obj_cls_DataSet.g_TBL_VEHICLE_MAKERS;

                  if (ds == null)
                  {

                        return false;
                  }

                  GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                      objGridLookUpEdit,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.VEHICLE_MAKER_name,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.priVEHICLE_MAKER_ID,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.VEHICLE_MAKER_name,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.priVEHICLE_MAKER_ID,
                      "Names",
                      "IDs",
                      ds,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.priVEHICLE_MAKER_ID,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                      GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                      100,
                      BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.priVEHICLE_MAKER_ID,
                      false,
                      true,
                      false

                      );

                  return true;


            }



            public static bool TBL_DEPARTMENTS(object pControl,bool isAddAll)
            {
                  DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();
                  obj_cls_DataSet.f_TBL_DEPARTMENTS("L", "");
                  DataSet ds = obj_cls_DataSet.g_TBL_DEPARTMENTS;

                  if (ds == null)
                  {
                     return false;
                  }

                  if (isAddAll)
                        GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.addAllvalue(ds,BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name);
                  
                  Type obj_TYPE = pControl.GetType();
                  if (obj_TYPE == typeof(RepositoryItemGridLookUpEdit))
                  {
                        RepositoryItemGridLookUpEdit objRepositoryItemGridLookUpEdit = (RepositoryItemGridLookUpEdit)pControl;

                        if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(ds))
                        {

                            GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(

                            objRepositoryItemGridLookUpEdit,
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                            "Names",
                            "IDs",
                            ds.Tables[0],
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID ,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightlarge,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthSmall,
                            100,
                            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
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
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                      "Names",
                      "IDs",
                      ds,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
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
            public static bool TBL_DEPARTMENTSParent(object pControl, bool isAddAll)
            {
                  DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();
                  obj_cls_DataSet.f_TBL_DEPARTMENTS("L_parentsOnly", "");
                  DataSet ds = obj_cls_DataSet.g_TBL_DEPARTMENTS;

                  if (ds == null)
                  {
                        return false;
                  }
                  if (isAddAll)
                        GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.addAllvalue(ds, BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID, BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name);
                

                  Type obj_TYPE = pControl.GetType();
                  if (obj_TYPE == typeof(RepositoryItemGridLookUpEdit))
                  {
                        RepositoryItemGridLookUpEdit objRepositoryItemGridLookUpEdit = (RepositoryItemGridLookUpEdit)pControl;

                        if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(ds))
                        {

                              GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(

                              objRepositoryItemGridLookUpEdit,
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                              "Names",
                              "IDs",
                              ds.Tables[0],
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                              GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightlarge,
                              GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthSmall,
                              100,
                              BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
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
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_name,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
                      "Names",
                      "IDs",
                      ds,
                      BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.priDEPARTMENT_ID,
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
