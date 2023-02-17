using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEN;
using System.Data;


namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT
{
    public class cls_TBL_DEFAULT_ACCT_P
    {

        Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false;
        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;
        GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;
        
        DataSet ds = new DataSet();
        DataTable dt_DefaultAccounts;
        int defId = 0;
        string defAcctKey = "";
        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        DATASET.GEN_DATASET.cls_DataSet objcls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
        GEN.GEN_GEN.Look.frlLOOKUP objfrlLOOKUP = null;
        BLL.GEN_BLL.cls_TBL_DEFAULT_ACCT objcls_TBL_DEFAULT_ACCT = new BLL.GEN_BLL.cls_TBL_DEFAULT_ACCT();
        frm_TBL_DEFAULT_ACCT objfrm_TBL_DEFAULT_ACCT = null;

        void InitializeComponents(frm_TBL_DEFAULT_ACCT pobjfrm_TBL_DEFAULT_ACCT)
        {
            objfrm_TBL_DEFAULT_ACCT = pobjfrm_TBL_DEFAULT_ACCT;
            GEN.GEN_GEN.GenericClasses.cls_CustomeForm.applyPropertiesOnXtraForm(objfrm_TBL_DEFAULT_ACCT, 'A');

        }

        public void initiateGrid()
        {
            objcls_DataSet.f_TBL_DEFAULT_ACCT("A", "", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, 0, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
            DataSet ds_DefaultAccounts = objcls_DataSet.g_TBL_DEFAULT_ACCT;

            if (ds_DefaultAccounts == null)
            {
                objcls_MessageBox.MessageBoxStatic("BLL_E");
                Referesh(false);
                return;

            }


            DATASET.ACC_DATASET.cls_DataSet obj_cls_DataSet_ACC = new DATASET.ACC_DATASET.cls_DataSet();
            DATASET.GEN_DATASET.cls_DataSet obj_cls_DataSet_GEN = new DATASET.GEN_DATASET.cls_DataSet();
            obj_cls_DataSet_ACC.f_TBL_COA("C", "", "", "", 0, 0, 0, 0, true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, true, true, false);

            DataSet ds_COA = obj_cls_DataSet_ACC.g_TBL_COA;
            obj_cls_DataSet_GEN.f_TBL_KEY("N", "");
            DataSet ds_Keys = obj_cls_DataSet_GEN.g_TBL_KEY;

            if (ds_COA == null)
            {
                objcls_MessageBox.MessageBoxStatic("BLL_E");
                Referesh(false);
                return;

            }

            if (ds_Keys == null)
            {
                objcls_MessageBox.MessageBoxStatic("BLL_E");
                Referesh(false);
                return;

            }
          
            DataTable dt_COA = ds_COA.Tables[0];
            dt_DefaultAccounts = ds_DefaultAccounts.Tables[0];
            objfrm_TBL_DEFAULT_ACCT.grdControl.DataSource = dt_DefaultAccounts;
            objfrm_TBL_DEFAULT_ACCT.grdView.PopulateColumns();
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key].Caption = "Key";
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key].Width = 120;
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key].Tag = "N|N|Y|Y";
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key].MinWidth = 120;
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key].ColumnEdit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(
                 
                  BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_value, BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key, 
                  BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_value, BLL.GEN_BLL.TBL_KEY.cls_CTBL_KEY.KEY_key, 
                  "Key", 
                  "Value", 
                  ds_Keys.Tables[0] /*  objDs.f_TBL_GEN_FORM('L', "0", "Matching", false).Tables[0] */  , 
                  PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH, 
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, 
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthSmall,
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, 
                  "KEY_value", 
                  true, 
                  true, 
                  false);
          
            
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Caption = "Account Code";
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ColumnEdit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID, "Account Code", "Value", dt_COA /*  objDs.f_TBL_GEN_FORM('L', "0", "Matching", false).Tables[0] */  , PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthSmall, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name, true, true, false);
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Width = 120;
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].Tag = "N|N|N|N";
            objfrm_TBL_DEFAULT_ACCT.grdView.Columns[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].MinWidth = 120;
          


        }


        public cls_TBL_DEFAULT_ACCT_P(frm_TBL_DEFAULT_ACCT pobjfrm_TBL_DEFAULT_ACCT, GEN.GEN_GEN.GenericClasses.Form.Gen_Form pObjGenForm, GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView pObjGenGrid)
        {

            ObjGenForm = pObjGenForm;
            ObjGenGrid = pObjGenGrid;
            InitializeComponents(pobjfrm_TBL_DEFAULT_ACCT);

        }

        public bool validate(out string value)
        {

            if (objfrm_TBL_DEFAULT_ACCT.DBStatus == 'I')
            {
                if (!isAllowedInsertion)
                {
                    value = objcls_MessageBox.error_insert_rights;
                    return false;

                }

            }
            if (objfrm_TBL_DEFAULT_ACCT.DBStatus == 'U')
            {
                if (!isAllowedUpdation)
                {
                    value = objcls_MessageBox.error_update_rights;
                    return false;

                }

            }


            //if (dt_COA.Rows.Count <= 0)
            //{
            //    value = objcls_MessageBox.error_DEF_Table_No_provide_msg;
            //    return false;
            //}



            value = "N";
            return true;
        }

        public void getMax()
        {

            //int tempID = objcls_DataSet.f_GETMAX("TBL_DEFAULT_ACCT", 0, 0, 0, "", "", "");
            //objfrm_TBL_DEFAULT_ACCT.maxID =  tempID.ToString();
            //objfrm_TBL_DEFAULT_ACCT.TextEdit_DEFAULT_ACCT_ID.Text = objfrm_TBL_DEFAULT_ACCT.maxID;
        }

        public void loadGridLookUpEdit(char Status)
        {
            if (Status == 'A')
            {


            }

        }
        public string valueGetting()
        {

            try
            {

                string validate_value = "";
                if (!validate(out validate_value))
                {

                    if (validate_value == "N")
                        return "V_P";
                    else
                        return validate_value;

                }

                objcls_TBL_DEFAULT_ACCT.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
                objcls_TBL_DEFAULT_ACCT.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
                 objcls_TBL_DEFAULT_ACCT.DEFAULT_ACCT_isDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                 BLL.GEN_BLL.cls_TBL_DEFAULT_ACCT.dt_DEF = dt_DefaultAccounts;

               
                 foreach (DataRow row in dt_DefaultAccounts.Rows)
                 {
                     if (row[0].ToString() != String.Empty && row[1].ToString() == String.Empty )
                     {
                         return "V_P";
                         
                     }
                     else if (row[1].ToString() != String.Empty && row[0].ToString() == String.Empty)
                     {
                         return "V_P";
                     }
                 }


            }
            catch (Exception ex)
            {

                return ex.Message;

            }

            return "ok";

        }
      
        public void Referesh(bool isComplete)
        {

            objfrm_TBL_DEFAULT_ACCT.DBStatus = 'I';

            if (isComplete)
            {


                try
                {

                    DataRow[] drr = MDIClassic.dtRightsButton.Select(" [Parent Key] = '" + objfrm_TBL_DEFAULT_ACCT.Tag + "'");
                    foreach (DataRow d in drr)
                    {
                        if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_del == d["Primary Key"].ToString())
                        {
                            isAllowedDeletion = true;
                        }
                        else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_insert == d["Primary Key"].ToString())
                        {
                            isAllowedInsertion = true;
                        }
                        else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_update == d["Primary Key"].ToString())
                        {
                            isAllowedUpdation = true;
                        }
                    }

                }
                catch
                {
                    //throw;
                }

                if (!isAllowedInsertion && !isAllowedUpdation)
                    objfrm_TBL_DEFAULT_ACCT.SimpleButton_Save.Enabled = false;
               

               

                ObjGenGrid.Formatting();

                
            }

            ObjGenForm.GenRefresh();
        }


      


        public void Save()
        {


            string executeFunctions = "";

            if (objfrm_TBL_DEFAULT_ACCT.DBStatus == 'I')
            {

                executeFunctions = valueGetting();

                if (executeFunctions != "ok")
                {
                    if (executeFunctions != "N")
                    {
                        if (executeFunctions == "V_P")
                        {
                            objcls_MessageBox.MessageBoxStatic("VP_E");
                            return;
                        }
                        else
                        {
                            objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                            return;

                        }
                    }
                }


                if (executeFunctions == "ok")
                {

                    if (objcls_MessageBox.MessageBoxStatic("I_Q") == "no")
                    {
                        return;
                    }

                    if (!objcls_TBL_DEFAULT_ACCT.insertion())
                    {
                        objcls_MessageBox.MessageBoxStatic("BLL_E");
                        Referesh(false);
                        return;
                    }

                    if (executeFunctions == "ok")
                    {
                        isDisturebedOnce = true;
                        Referesh(false);
                        objcls_MessageBox.MessageBoxStatic("I_S");
                     //   bindGrid();

                    }
                    else
                    {
                        objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");

                        return;

                    }
                }
                else
                {

                    objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                    Referesh(false);

                }


            }


            

        }

       
    }
}