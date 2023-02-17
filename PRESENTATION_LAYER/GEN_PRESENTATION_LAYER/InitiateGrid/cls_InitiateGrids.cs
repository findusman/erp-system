using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.InitiateGrid
{
    public class cls_InitiateGrids
    {
        public static DataTable dt_RIGHTS = null;


   


        public static DataTable initiateCOATable(GridControl pDataGrid, GridView pGridView, bool pIsTableCreated, DataTable dt)
        {
            #region Table Defination

            if (!pIsTableCreated)
            {
                //dt.Columns.Add("CMP_ID", typeof(int));
                //dt.Columns.Add("BRC_ID", typeof(int));
                dt.Columns.Clear();
                dt.Columns.Add(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY, typeof(string));
                dt.Columns.Add(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE, typeof(string));
                dt.Columns.Add(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH, typeof(string));
                dt.Columns.Add(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID, typeof(string));
                dt.Columns.Add(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_isParent, typeof(bool));
                //dt.Columns.Add("DEFAULT_ACCT_isDeleted", typeof(bool));
            }

            #endregion

            pDataGrid.DataSource = dt;
            pGridView.PopulateColumns();

            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].Visible = false;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_isParent].Visible = false;

            DATASET.GEN_DATASET.cls_DataSet objDs = new DATASET.GEN_DATASET.cls_DataSet();
            DATASET.ACC_DATASET.cls_DataSet objDsAcc = new DATASET.ACC_DATASET.cls_DataSet();
            objDsAcc.f_TBL_COA("C", "", "", "", 0, 0, 0, 0, true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, true, true, false);

            objDs.f_TBL_DEFAULT_ACCT("V", "Acc", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, 0, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
            DataTable dT_COA = objDs.g_TBL_DEFAULT_ACCT.Tables[0];

            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].Caption = "Key";
           // pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ColumnEdit = pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ColumnEdit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_KEY.cls_CTBL_KEY.GEN_FORM_value, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_KEY.cls_CTBL_KEY.GEN_FORM_key, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_KEY.cls_CTBL_KEY.GEN_FORM_value, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_KEY.cls_CTBL_KEY.GEN_FORM_key, "Account Name", "Value", objDs.f_TBL_KEY("V", "key", "Acc", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, 0, false).Tables[0], PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthSmall, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_KEY.cls_CTBL_KEY.GEN_FORM_value, true, true, true);
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].Width = 120;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].Tag = "D|N|N";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].MinWidth = 120;

            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Caption = "Account Code";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ColumnEdit = pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ColumnEdit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, "Key", "Value", objDsAcc.g_TBL_COA.Tables[0] /*  objDs.f_TBL_GEN_FORM('L', "0", "Matching", false).Tables[0] */  , PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthSmall, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, "", false, true, true);
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Width = 120;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Tag = "D|N|N";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].MinWidth = 120;
            
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].Caption = "Matching Code";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].Width = 120;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].Tag = "D|N|N";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].MinWidth = 120;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH].Visible = false;

            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].Caption = "Code";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].Width = 120;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].Tag = "N|N|N";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_ID].MinWidth = 120;

            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_isParent].Caption = "Is Parent";
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_isParent].Width = 75;
            pGridView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_isParent].OptionsColumn.FixedWidth = true;


            return dt;
        }
    }
}

