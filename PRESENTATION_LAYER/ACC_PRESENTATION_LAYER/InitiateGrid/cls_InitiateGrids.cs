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
using DevExpress.XtraEditors.Repository;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid
{
   public class cls_InitiateGrids
    {
       public static DataTable dt_COA = null;
       public static DataTable dt_VCH = null;



      public static DataTable initiateCOATable(TreeList dTreeList,DataTable dt)
      {

          #region Table Defination


                dt_COA = new DataTable("Data");

                dt_COA.Columns.Clear();
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_prefix, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_description, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type, typeof(int));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature, typeof(string));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive, typeof(bool));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved, typeof(bool));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly, typeof(bool));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction, typeof(bool));
                dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelNo, typeof(string));



          #endregion

                dt_COA = dt;
                dTreeList.DataSource = dt_COA;

                dTreeList.ParentFieldName = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID;
                dTreeList.KeyFieldName = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID;
                dTreeList.OptionsBehavior.AllowExpandOnDblClick = true;
                      
                DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition objStyleFormatCondition = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
                objStyleFormatCondition.Appearance.BackColor = System.Drawing.Color.Black;
                objStyleFormatCondition.Appearance.ForeColor = System.Drawing.Color.White;
                objStyleFormatCondition.Appearance.Options.UseBackColor = true;
                objStyleFormatCondition.Appearance.Options.UseForeColor = true;
                objStyleFormatCondition.ApplyToRow = true;
                objStyleFormatCondition.Column = dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved];
                objStyleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
                objStyleFormatCondition.Value1 = false;
                dTreeList.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] { objStyleFormatCondition });

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].ColumnEdit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryLookUpEdit(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_ID, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_ID, "Names", "Codes", GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_TypesInformation, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopHeightSmall, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthSmall, 100);
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].Width = 150;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].OptionsColumn.FixedWidth = true;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].Caption = "Type";

                RepositoryItemRadioGroup repository = new RepositoryItemRadioGroup();

                repository.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Debit", "Debit"),
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Credit", "Credit")});
                repository.Name = "repositoryItemRadioGroup1";

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].ColumnEdit = repository;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].Width = 130;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].OptionsColumn.FixedWidth = true;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].Caption = "Nature";

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive].Width = 70;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive].OptionsColumn.FixedWidth = true;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive].Caption = "Active";
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive].Visible = false;

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].Caption = "Account Code";
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].Width = 150;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.FixedWidth = true;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.ReadOnly = true;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.AllowFocus = false;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name].Width = 300;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name].Caption = "Account Name";

                if (GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_isTransactionFixed)
                {
                    dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Visible= false;
                }
                else
                {
                    dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Width = 100;
                    dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].OptionsColumn.FixedWidth = true;
                    dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Caption = "Transaction";
                }

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_description].Caption = "Description";

                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly].Caption = "Allow Deletion";
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_prefix].Visible = false;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved].Visible = false;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID].Visible = false;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly].Visible = false;
                dTreeList.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelNo].Visible = false;
             
 

                return dt_COA;
       }

    

       




    }
}
