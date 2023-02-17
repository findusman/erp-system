﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_VEHICLE_MAKERS
{
    public class cls_TBL_VEHICLE_MAKERS_P
    {

        Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false, isAutoGeneratedOption = false;

        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;

        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

        DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet_IMS = new DATASET.IMS_DATASET.cls_DataSet();

        GEN.GEN_GEN.Look.frlLOOKUP obj_frlLOOKUP = null;

        BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_TBL_VEHICLE_MAKERS obj_cls_TBL_VEHICLE_MAKERS = new BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_TBL_VEHICLE_MAKERS();

        frm_TBL_VEHICLE_MAKERS obj_frm_TBL_VEHICLE_MAKERS = null;

        DataTable dt_Datanavigator = new DataTable();

        void InitializeComponents(frm_TBL_VEHICLE_MAKERS pobj_frm_TBL_VEHICLE_MAKERS, String pID)
        {

            obj_frm_TBL_VEHICLE_MAKERS = pobj_frm_TBL_VEHICLE_MAKERS;
            GEN.GEN_GEN.GenericClasses.cls_CustomeForm.applyPropertiesOnXtraForm(obj_frm_TBL_VEHICLE_MAKERS, 'A');
            obj_cls_TBL_VEHICLE_MAKERS.obj_XtraForm = pobj_frm_TBL_VEHICLE_MAKERS;

            if (!obj_cls_TBL_VEHICLE_MAKERS.Open())
                obj_frm_TBL_VEHICLE_MAKERS.Close();



            if (pID == "N")
                Referesh("True");
            else
            {
                obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.Text = pID;

                selection("V", obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.Text.Trim());

            }

        }


        public cls_TBL_VEHICLE_MAKERS_P(frm_TBL_VEHICLE_MAKERS pobj_frm_TBL_VEHICLE_MAKERS, String pID, GEN.GEN_GEN.GenericClasses.Form.Gen_Form pObjGenForm, bool pIs_DisturbanceOnce)//VVVParamVVV
        {
            ObjGenForm = pObjGenForm;
            isDisturebedOnce = pIs_DisturbanceOnce;
            InitializeComponents(pobj_frm_TBL_VEHICLE_MAKERS, pID);

        }


        public bool validate(out string value, bool pIs_Delete)
        {
            if (pIs_Delete)
            {

                if (!isAllowedDeletion)
                {
                    value = obj_cls_MessageBox.error_delete_rights;
                    return false;

                }

                if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'I')
                {
                    value = obj_cls_MessageBox.error_selection_msg;
                    return false;
                }

            }
            else
            {
                if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'I')
                {
                    if (!isAllowedInsertion)
                    {
                        value = obj_cls_MessageBox.error_insert_rights;
                        return false;

                    }

                }
                if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'U')
                {
                    if (!isAllowedUpdation)
                    {
                        value = obj_cls_MessageBox.error_update_rights;
                        return false;

                    }

                }

                if (Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_name.EditValue) == "")
                {
                    value = obj_cls_MessageBox.error_Name_msg;
                    obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_name.Focus();
                    return false;
                }
            }

            if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'U')
                if (Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.EditValue) == "")
                {
                    value = obj_cls_MessageBox.error_ID_msg;
                    return false;
                }
            if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'I')
                if (!obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Checked && Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.EditValue) == "")
                {
                    value = obj_cls_MessageBox.error_ID_msg;
                    return false;
                }


            value = "N";
            return true;
        }




        public void getMax()
        {
            if (obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Checked)
            {

                int tempID = obj_cls_DataSet_IMS.f_GETMAX("TBL_VEHICLE_MAKERS", 0, 0, 0, "", "", "");
                obj_frm_TBL_VEHICLE_MAKERS.maxID = tempID.ToString();
                obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.Text = obj_frm_TBL_VEHICLE_MAKERS.maxID;

            }
        }



        public void loadGridLookUpEdit(string Status)
        {



        }

        public string valueGetting(bool pIs_Delete)
        {

            try
            {

                string validate_value = "";

                if (!validate(out validate_value, pIs_Delete))
                {

                    if (validate_value == "N")
                        return "V_P";
                    else
                        return validate_value;

                }

                if (pIs_Delete)
                {
                    obj_cls_TBL_VEHICLE_MAKERS.STATUS = "D";
                    obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_ID = Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.EditValue);
                }
                {

                    obj_cls_TBL_VEHICLE_MAKERS.Is_Auto_Generated = obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Checked;

                    if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'I')
                    {

                        if (!obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Checked)
                            obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_ID = Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.EditValue);
                    }
                    else
                        obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_ID = Convert.ToString(obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.EditValue);


                    obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_name = obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_name.EditValue.ToString().Trim();
                    obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_narration = obj_frm_TBL_VEHICLE_MAKERS.MemoEdit_VEHICLE_MAKER_narration.EditValue.ToString().Trim();


                }



            }
            catch (Exception ex)
            {

                return ex.Message;

            }

            return "ok";

        }
        public string valueSetting(DataSet ds)
        {

            try
            {

                DataTable dt_Main = ds.Tables[0];

                obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Checked = (Boolean)dt_Main.Rows[0][GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.Is_Auto_Generated];



                obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_name.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.VEHICLE_MAKER_name];
                obj_frm_TBL_VEHICLE_MAKERS.MemoEdit_VEHICLE_MAKER_narration.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_CTBL_VEHICLE_MAKERS.VEHICLE_MAKER_narration];

                obj_frm_TBL_VEHICLE_MAKERS.DBStatus = 'U';
                obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Enabled = false;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

            return "ok";

        }


        public void Referesh(String isComplete)
        {

            if (isComplete == "True")
            {

                //try
                //{
                //    //DataRow[] drr = MDIClassic.dtRightsButton.Select(" [Parent Key] = '" + obj_frm_TBL_PRODUCTS_2.Tag + "'");
                //    foreach (DataRow d in drr)
                //    {
                //        if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_del == d["Primary Key"].ToString())
                //        {
                //            isAllowedDeletion = true;
                //        }
                //        else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_insert == d["Primary Key"].ToString())
                //        {
                //            isAllowedInsertion = true;
                //        }
                //        else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_update == d["Primary Key"].ToString())
                //        {
                //            isAllowedUpdation = true;
                //        }
                //    }

                //}
                //catch (Exception ex)
                //{
                //    //throw;
                //}




                obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Visible = isAutoGeneratedOption;

                if (!isAllowedInsertion && !isAllowedUpdation)
                    obj_frm_TBL_VEHICLE_MAKERS.SimpleButton_Save.Enabled = false;
                if (!isAllowedDeletion)
                    obj_frm_TBL_VEHICLE_MAKERS.SimpleButton_Delete.Enabled = false;

                selection("N", "");
                Referesh("False");

            }
            else if (isComplete == "Partial")
            {
                selection("N", "");
                Referesh("False");

            }


            ObjGenForm.GenRefresh();
            obj_frm_TBL_VEHICLE_MAKERS.DBStatus = 'I';
            obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_Is_AutoGenegereted.Enabled = true;
            //obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_navigate.Checked = false;
            getMax();

        }

        public void Delete()
        {

            string executeFunctions = valueGetting(true);

            if (executeFunctions != "ok")
            {
                if (executeFunctions != "N")
                {
                    if (executeFunctions == "V_P")
                    {
                        obj_cls_MessageBox.MessageBoxStatic("VP_E");
                        return;
                    }
                    else
                    {
                        obj_cls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                        return;

                    }
                }
            }


            if (obj_cls_MessageBox.MessageBoxStatic("D_Q") == "no")
            {

                return;

            }





            obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_ID = obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.Text;

            if (obj_cls_TBL_VEHICLE_MAKERS.deletion())
            {
                Referesh("Partial");
                if (isDisturebedOnce)
                    obj_frm_TBL_VEHICLE_MAKERS.Close();
            }

        }

        public void Save()
        {


            string executeFunctions = valueGetting(false);

            if (executeFunctions != "ok")
            {
                if (executeFunctions != "N")
                {
                    if (executeFunctions == "V_P")
                    {
                        obj_cls_MessageBox.MessageBoxStatic("VP_E");
                        return;
                    }
                    else
                    {
                        obj_cls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                        return;

                    }
                }
            }

            if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'I')
            {

                if (obj_cls_MessageBox.MessageBoxStatic("I_Q") == "no")
                {
                    return;
                }

                if (obj_cls_TBL_VEHICLE_MAKERS.insertionUpdation('I'))
                {
                    Referesh("Partial");
                    if (isDisturebedOnce)
                        obj_frm_TBL_VEHICLE_MAKERS.Close();
                }


            }

            else if (obj_frm_TBL_VEHICLE_MAKERS.DBStatus == 'U')
            {

                if (obj_cls_MessageBox.MessageBoxStatic("U_Q") == "no")
                {
                    return;
                }

                if (obj_cls_TBL_VEHICLE_MAKERS.insertionUpdation('U'))
                {
                    Referesh("Partial");
                    if (isDisturebedOnce)
                        obj_frm_TBL_VEHICLE_MAKERS.Close();
                }
            }

        }

        public void selection(string pStatus, string pId)
        {

            if (pStatus == "N")
            {
                if (pId == "")
                {
                    obj_cls_DataSet_IMS.f_TBL_VEHICLE_MAKERS("L", pId);
                    DataSet ds = obj_cls_DataSet_IMS.g_TBL_VEHICLE_MAKERS;
                    if (ds == null)
                    {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        Referesh("False");
                        return;

                    }

                    dt_Datanavigator = ds.Tables[0].Copy();
                    obj_frm_TBL_VEHICLE_MAKERS.DataNavigator_Navigate.DataSource = dt_Datanavigator;
                }
                else
                {

                    string ID = dt_Datanavigator.Rows[Convert.ToInt32(pId)][0].ToString();
                    selection("V", ID);
                }
            }
            else if (pStatus == "A")
            {

                obj_cls_DataSet_IMS.f_TBL_VEHICLE_MAKERS("A", pId);
                DataSet ds = obj_cls_DataSet_IMS.g_TBL_VEHICLE_MAKERS;

                if (ds == null)
                {
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                    Referesh("False");
                    return;

                }


                obj_frlLOOKUP = new GEN.GEN_GEN.Look.frlLOOKUP(ds, 4, true, "150,150,150", 1);
                obj_frlLOOKUP.ShowDialog();
                string value = GEN.GEN_GEN.Look.frlLOOKUP.value;
                if (value != "")
                {
                    string[] cols_values = value.Split('|');
                    obj_frm_TBL_VEHICLE_MAKERS.CheckEdit_navigate.Checked = false;
                    selection("V", cols_values[0]);
                }

            }
            else
            {

                obj_frm_TBL_VEHICLE_MAKERS.maxID = obj_frm_TBL_VEHICLE_MAKERS.TextEdit_VEHICLE_MAKER_ID.Text = pId;
                obj_cls_DataSet_IMS.f_TBL_VEHICLE_MAKERS("V", pId);
                DataSet ds = obj_cls_DataSet_IMS.g_TBL_VEHICLE_MAKERS;
                string executeFunctions = "";

                if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                {
                    executeFunctions = valueSetting(ds);
                }
                else
                {

                    obj_cls_MessageBox.MessageBoxStatic("TB_E");
                    Referesh("False");
                    return;

                }


                if (executeFunctions != "ok")
                {
                    obj_cls_MessageBox.MessageBoxDynamics(executeFunctions, "S_E");
                    return;

                    Referesh("False");


                }


            }

        }



        //VVVGRIDINFOVVV



    }
}
