using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.Repository;
using PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns;


namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.COA
{
   public class cls_COA_P
    {

       DATASET.ACC_DATASET.cls_DataSet objcls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
       BLL.ACC_BLL.cls_TBL_COA objcls_TBL_COA = new BLL.ACC_BLL.cls_TBL_COA();
       frm_COA objfrm_COA = null;
       GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
       GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
       public  cls_COA_P(frm_COA pobjfrm_COA)
       {

           objfrm_COA = pobjfrm_COA;
           loadCOA();
          
          
       }


      public void loadCOA()
       {
           dt_COA = loadData();
           initiateCOATable();
           for (int x = 0; x < objfrm_COA.TL_COA.Nodes.Count; x++)
               objfrm_COA.TL_COA.Nodes[x].ExpandAll();
       }



     public  bool  addNewNode( string pParentId, int pLevelNo , int pPlanId , string pNature ,  int pCOA_type )
       {

           int temp_Get_Max = objcls_DataSet.f_GETMAX("PerLevel1", 0, 0, 0, pParentId, "", "");
           string temp_format = GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[pLevelNo][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_ACC_PLAN_DEF.TBL_ACC_PLAN_DEF_format].ToString();
           string temp_FormatedMax = GEN.GEN_GEN.GenericClasses.Strings.cls_String.getProperCodeFormat(temp_format, temp_Get_Max);

           

           if (temp_FormatedMax != "N")
           {
               string temp_tempUID = GEN.ACC_GEN.Generics.cls_GACCFunctions.getCompleteCOAID(pParentId, temp_FormatedMax, (pLevelNo));
                          
               dt_COA.Rows.Add(
                               pParentId, 
                               temp_tempUID, 
                               "",  
                               temp_tempUID, 
                               temp_FormatedMax,
                               pCOA_type, 
                               pNature, 
                               false, 
                               false,
                               false
                               );
              
               return true;
           }
           else
               return false;
       }




     public void InsertValues(TreeListNode PobjNode , string Pstatus, string pChildOrSbling, int pCOA_definationPlanID)
     {

         
         try
         {
             //if (Convert.ToBoolean(objfrm_COA.TL_COA.FocusedNode[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly]))
             //{
             //    objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_delete_rights, "D_R");
             //}

             TreeListNode objTreeListNode_Focused = PobjNode == null ? objfrm_COA.TL_COA.FocusedNode : PobjNode;
             
             //if (pIsUpdate && !PisLastNode &&!Convert.ToBoolean(objfrm_COA.TL_COA.FocusedNode[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly]))
             //{
             //    objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_update_rights, "D_R");
             //    return;
             //}


             DataSet ds = objcls_TBL_COA.insertionDirect(
             
             objTreeListNode_Focused.Level,
             objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID).ToString(),
             objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID).ToString(),
             pCOA_definationPlanID,
             //Convert.ToInt16(objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID).ToString()),
             objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name).ToString(),
             Convert.ToInt16(objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type).ToString()),
           
             objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature).ToString(),
             false,
             //Convert.ToBoolean(objTreeListNode_Focused.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction).ToString())
             Pstatus,
             pChildOrSbling,
             false,
             false
             );
             if (ds == null)
             {
                 objfrm_COA.TL_COA.Nodes.Remove(objTreeListNode_Focused);
                 objcls_MessageBox.MessageBoxStatic("BLL_E");
                 return;
             }
             if (ds.Tables[0].Rows[0][0].ToString() == "ok")
             {
                 objTreeListNode_Focused.SetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved, true);
             }
             else
             {
                 objfrm_COA.TL_COA.Nodes.Remove(objTreeListNode_Focused);
                 objcls_MessageBox.MessageBoxStatic("BLL_E");
                 return;
             
             }
         }
         catch (Exception ex)
         { 
         }
         
     }
       



     public DataTable loadData()
     {
         //PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA.Clear();
         objcls_DataSet.f_TBL_COA("A_Type", "", "", "", 0, 0, 0, 0,false,false,false,false ,false);
         DataTable dDT = objcls_DataSet.g_TBL_COA.Tables[0];

         //for (int x = 0; x < dDT.Rows.Count; x++)
         //{

         //    PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA.Rows.Add
         //    (

         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_prefix],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_description],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature],
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive],
         //      true,
         //      dDT.Rows[x][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly]


         //    );

         //}

         return dDT;

     }



     public string settingValuesThenDelete( string pCOA_UID)
     {
        try
         {
            bool isaAddedDirectly = Convert.ToBoolean(objfrm_COA.TL_COA.FocusedNode[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly]);

            if (!isaAddedDirectly && !objfrm_COA.TL_COA.FocusedNode.HasChildren)
             {
                 objcls_TBL_COA.STATUS = "D";
                 objcls_TBL_COA.COA_UID = pCOA_UID;

                 return objcls_TBL_COA.deletion();
             }

             else
             {
                  return objcls_MessageBox.error_delete_rights;
             }
         }
         catch (Exception ex)
         {

             return ex.Message.ToString();

         }

        
     }


     public void focusedNodeChanged(TreeListNode PFocusedNode)
     {

         try
         {
             

             bool isFixed = GEN.ACC_GEN.Generics.cls_GACCFunctions.isFixed(PFocusedNode.Level);
             bool isAddedDirectly = Convert.ToBoolean(PFocusedNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly));
             bool hasChildNode = PFocusedNode.HasChildren;

             //if (isFixed)
             //    objfrm_COA.TL_COA.OptionsBehavior.Editable = false;


             if (isFixed || !isAddedDirectly )
             {

                 objfrm_COA.isAllowDeletionForCurrentNode = false;
                 objfrm_COA.isAllowUpdationForCurrentNode = false;
                 //objfrm_COA.TL_COA.OptionsBehavior.Editable = false;

             }
             else
             { 
                 objfrm_COA.isAllowUpdationForCurrentNode = true;
                 //objfrm_COA.TL_COA.OptionsBehavior.Editable = true;
                 if(hasChildNode)
                     objfrm_COA.isAllowDeletionForCurrentNode = false;
                 else
                     objfrm_COA.isAllowDeletionForCurrentNode = true;
             
             }
             

         }
         catch (Exception ex)
         {

         }

     }

     public void enableDisableTree(bool pEnableDeisable)
     {
         objfrm_COA.TL_COA.OptionsBehavior.Editable = pEnableDeisable;

     }

     public  void deleteCOA()
     {
         
         try
         {
             

             string ExecuteString = settingValuesThenDelete(
                 objfrm_COA.TL_COA.FocusedNode[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID].ToString()
                 );

             if (ExecuteString == "ok")
             {
                 objfrm_COA.TL_COA.DeleteNode(objfrm_COA.TL_COA.FocusedNode);
                 obj_cls_MessageBox.MessageBoxStatic("D_S");
             }
             else
             {

                 objcls_MessageBox.MessageBoxDynamics(ExecuteString, "D_R");
             }

         }
         catch (Exception ex)
         { 
         
         }
     }

     public DataTable dt_COA = null;
     public DataTable initiateCOATable()
     {

         #region Table Defination

         //if (dt_COA == null)
         //{
         //    dt_COA = new DataTable("Data");

             
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelNo, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_description, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type, typeof(int));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature, typeof(string));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isActive, typeof(bool));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved, typeof(bool));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly, typeof(bool));
         //    dt_COA.Columns.Add(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction, typeof(bool));
             
         //}

         #endregion

         objfrm_COA.TL_COA.DataSource = dt_COA;

         objfrm_COA.TL_COA.ParentFieldName = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID;
         objfrm_COA.TL_COA.KeyFieldName = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID;
         objfrm_COA.TL_COA.OptionsBehavior.AllowExpandOnDblClick = true;

         DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition objStyleFormatCondition = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
         objStyleFormatCondition.Appearance.BackColor = System.Drawing.Color.Black;
         objStyleFormatCondition.Appearance.ForeColor = System.Drawing.Color.White;
         objStyleFormatCondition.Appearance.Options.UseBackColor = true;
         objStyleFormatCondition.Appearance.Options.UseForeColor = true;
         objStyleFormatCondition.ApplyToRow = true;
         objStyleFormatCondition.Column = objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved];
         objStyleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
         objStyleFormatCondition.Value1 = false;
         objfrm_COA.TL_COA.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] { objStyleFormatCondition });

         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].ColumnEdit =

             GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(
             PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, 
             PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_ID, 
             PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, 
             PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_ID, 
             "Names", 
             "Codes", 
             GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_TypesInformation, 
             PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_name, 
             GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopHeightlarge, 
             GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthlarge, 
             100,
             cls_CTBL_TYPE_PLAN_DEF.TYPE_PLAN_DEF_ID,
             false,
             true,
                false

             );
        
         
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].Width = 150;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].OptionsColumn.FixedWidth = true;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type].Caption = "Type";

         RepositoryItemRadioGroup repository = new RepositoryItemRadioGroup();

         repository.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Debit", "Debit"),
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Credit", "Credit")});
         repository.Name = "repositoryItemRadioGroup1";

         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].ColumnEdit = repository;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].Width = 130;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].OptionsColumn.FixedWidth = true;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature].Caption = "Nature";

     
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].Caption = "Account Code";
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].Width = 150;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.FixedWidth = true;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.ReadOnly = true;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].OptionsColumn.AllowFocus = false;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_COA_TUID].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name].Width = 300;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name].Caption = "Account Name";

         if (GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_isTransactionFixed)
         {
             objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Visible = false;
         }
         else
         {
             objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Width = 100;
             objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].OptionsColumn.FixedWidth = true;
             objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_IsTransaction].Caption = "Is Transaction";
         }

         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_A_isSaved].Visible = false;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_levelID].Visible = false;
         objfrm_COA.TL_COA.Columns[PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_isAddedDirectly].Visible = false;
         

         return dt_COA;
     }

    }
}
