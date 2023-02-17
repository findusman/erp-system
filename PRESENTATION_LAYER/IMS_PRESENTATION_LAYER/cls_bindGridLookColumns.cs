using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER
{
    class cls_bindGridLookColumns
    {


          public static bool TBL_DEPARTMENTS(GridColumn pGridColumn)
          {


                RepositoryItemGridLookUpEdit objRepositoryItemGridLookUpEdit = new RepositoryItemGridLookUpEdit();
                IMS_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_DEPARTMENTSParent(objRepositoryItemGridLookUpEdit,false);
                pGridColumn.ColumnEdit = objRepositoryItemGridLookUpEdit;
                return true;
          

          }


          public static bool TBL_SUPPLIERS(GridLookUpEdit objGridLookUpEdit)
          {

                DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_SUPPLIERS("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_SUPPLIERS;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.IMS_BLL.TBL_SUPPLIERS.cls_CTBL_SUPPLIERS.SUPPLIER_name,
                    BLL.IMS_BLL.TBL_SUPPLIERS.cls_CTBL_SUPPLIERS.priSUPPLIER_ID,
                    BLL.IMS_BLL.TBL_SUPPLIERS.cls_CTBL_SUPPLIERS.SUPPLIER_name,
                    BLL.IMS_BLL.TBL_SUPPLIERS.cls_CTBL_SUPPLIERS.priSUPPLIER_ID,
                    "Names",
                    "IDs",
                    ds,
                    BLL.IMS_BLL.TBL_SUPPLIERS.cls_CTBL_SUPPLIERS.priSUPPLIER_ID,
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
          public static bool TBL_CUSTOMERS(GridLookUpEdit objGridLookUpEdit)
          {

                DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_CUSTOMERS("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_CUSTOMERS;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.IMS_BLL.TBL_CUSTOMERS.cls_CTBL_CUSTOMERS.CUSTOMER_name,
                    BLL.IMS_BLL.TBL_CUSTOMERS.cls_CTBL_CUSTOMERS.priCUSTOMER_ID,
                    BLL.IMS_BLL.TBL_CUSTOMERS.cls_CTBL_CUSTOMERS.CUSTOMER_name,
                    BLL.IMS_BLL.TBL_CUSTOMERS.cls_CTBL_CUSTOMERS.priCUSTOMER_ID,
                    "Names",
                    "IDs",
                    ds,
                    BLL.IMS_BLL.TBL_CUSTOMERS.cls_CTBL_CUSTOMERS.priCUSTOMER_ID,
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




          public static bool TBL_PRODUCTS(GridLookUpEdit objGridLookUpEdit, string pDisplayMember)
          {

                DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_PRODUCTS("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_PRODUCTS;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    pDisplayMember,//BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_name,
                    BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.priPRODUCT_ID,
                    BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_name,
                    BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_COA,
                    "Names",
                    "Code",
                    ds,
                    BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.priPRODUCT_ID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    100,
                    BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.priPRODUCT_ID,
                    false,
                    true,
                    true

                    );

                return true;


          }
          public static bool TBL_PRODUCTScostRateHistory(GridLookUpEdit objGridLookUpEdit,string pPRODUCTS_ID)
          {

                DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_PRODUCTS("Product Cost Rate History", pPRODUCTS_ID);
                DataSet ds = obj_cls_DataSet.g_TBL_PRODUCTS;

                if (ds == null)
                {

                      return false;
                }

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    objGridLookUpEdit,
                    BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                    BLL.IMS_BLL.TBL_STOCKS.cls_CTBL_STOCKS.priSTOCK_ID,
                    BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                    BLL.IMS_BLL.TBL_STOCKS.cls_CTBL_STOCKS.priSTOCK_ID,
                    "Names",
                    "Code",
                    ds,
                    BLL.IMS_BLL.TBL_STOCKS.cls_CTBL_STOCKS.priSTOCK_ID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    100,
                    BLL.IMS_BLL.TBL_STOCKS.cls_CTBL_STOCKS.priSTOCK_ID + "," + BLL.IMS_BLL.TBL_STOCKS.cls_CTBL_STOCKS.STOCK_unit,
                    false,
                    true,
                    true

                    );

                return true;


          }
    
    
    }
}
