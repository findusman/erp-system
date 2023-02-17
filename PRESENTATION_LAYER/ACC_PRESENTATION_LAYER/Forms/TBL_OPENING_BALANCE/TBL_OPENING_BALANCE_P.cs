﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
using BLL.ACC_BLL.TBL_OPENING_BALANCE;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE
{
      public class cls_TBL_OPENING_BALANCE_P
      {

            Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false, isAutoGeneratedOption = false;

            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;



            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

            DATASET.ACC_DATASET.cls_DataSet obj_cls_DataSet_ACC = new DATASET.ACC_DATASET.cls_DataSet();

            GEN.GEN_GEN.Look.frlLOOKUP obj_frlLOOKUP = null;

            BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_TBL_OPENING_BALANCE obj_cls_TBL_OPENING_BALANCE = new BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_TBL_OPENING_BALANCE();

            frm_TBL_OPENING_BALANCE obj_frm_TBL_OPENING_BALANCE = null;

            DataTable dt_Datanavigator = new DataTable();
            DataTable DT_dataTableForGrid = new DataTable();


            void InitializeComponents(frm_TBL_OPENING_BALANCE pobj_frm_TBL_OPENING_BALANCE, String pID)
            {

                  obj_frm_TBL_OPENING_BALANCE = pobj_frm_TBL_OPENING_BALANCE;
                  GEN.GEN_GEN.GenericClasses.cls_CustomeForm.applyPropertiesOnXtraForm(obj_frm_TBL_OPENING_BALANCE, 'A');
                  obj_cls_TBL_OPENING_BALANCE.obj_XtraForm = pobj_frm_TBL_OPENING_BALANCE;

                  if (!obj_cls_TBL_OPENING_BALANCE.Open())
                        obj_frm_TBL_OPENING_BALANCE.Close();



                  if (pID == "N")
                        Referesh("True");
                  else
                  {
                        obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID = pID;

                        selection("V", obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID);

                  }

            }


            public cls_TBL_OPENING_BALANCE_P(frm_TBL_OPENING_BALANCE pobj_frm_TBL_OPENING_BALANCE, String pID, GEN.GEN_GEN.GenericClasses.Form.Gen_Form pObjGenForm, GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView pObjGenGrid, bool pIs_DisturbanceOnce)//VVVParamVVV
            {
                  ObjGenForm = pObjGenForm;
                  ObjGenGrid = pObjGenGrid;
                  isDisturebedOnce = pIs_DisturbanceOnce;
                  InitializeComponents(pobj_frm_TBL_OPENING_BALANCE, pID);

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

                        if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'I')
                        {
                              value = obj_cls_MessageBox.error_selection_msg;
                              return false;
                        }

                  }
                  else
                  {
                        if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'I')
                        {
                              if (!isAllowedInsertion)
                              {
                                    value = obj_cls_MessageBox.error_insert_rights;
                                    return false;

                              }

                        }
                        if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'U')
                        {
                              if (!isAllowedUpdation)
                              {
                                    value = obj_cls_MessageBox.error_update_rights;
                                    return false;

                              }

                        }




                        double tmpDebit = Convert.ToDouble(obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].SummaryItem.SummaryValue.ToString());
                        double tmpCredit = Convert.ToDouble(obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].SummaryItem.SummaryValue.ToString());
                        string tmpNumericFormat = obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].DisplayFormat.FormatString;
                        string tmpStrDebit = tmpDebit.ToString(tmpNumericFormat);
                        string tmpStrCredit = tmpCredit.ToString(tmpNumericFormat);


                        if (tmpStrDebit != tmpStrCredit)
                        {
                              value = obj_cls_MessageBox.error_debit_credit_not_equal;
                              return false;
                        }


                  }

                  //if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'U')
                  //      if (Convert.ToString(obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.EditValue) == "")
                  //      {
                  //            value = obj_cls_MessageBox.error_ID_msg;
                  //            return false;
                  //      }
                  //if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'I')
                  //      if (!obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Checked && Convert.ToString(obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.EditValue) == "")
                  //      {
                  //            value = obj_cls_MessageBox.error_ID_msg;
                  //            return false;
                  //      }


                  value = "N";
                  return true;
            }




            public void getMax()
            {
                  //if (obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Checked)
                  //{

                  //      int tempID = obj_cls_DataSet_ACC.f_GETMAX("TBL_OPENING_BALANCE", 0, 0, 0, "", "", "");
                  //      obj_frm_TBL_OPENING_BALANCE.maxID = tempID.ToString();
                  //      obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.Text = obj_frm_TBL_OPENING_BALANCE.maxID;

                  //}
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

                        //if (pIs_Delete)
                        //{
                        //      obj_cls_TBL_OPENING_BALANCE.STATUS = "D";
                        //      obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID = Convert.ToString(obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.EditValue);
                        //}
                        {
                              obj_cls_TBL_OPENING_BALANCE.dt_Detail = DT_dataTableForGrid;
                             // obj_cls_TBL_OPENING_BALANCE.Is_Auto_Generated = obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Checked;

                              ////if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'I')
                              ////{

                              ////      if (!obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Checked)
                              ////            obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID = Convert.ToString(obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.EditValue);
                              ////}
                              //else
                              //      obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID = Convert.ToString(obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.EditValue);


                              //obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_name = obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_name.EditValue.ToString().Trim();
                             

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
                        DT_dataTableForGrid = ds.Tables[1].Copy();
                        initiateGrid(false);
                        //obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Checked = (Boolean)dt_Main.Rows[0][GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.Is_Auto_Generated];



                        //obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_name.EditValue = dt_Main.Rows[0][BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_CTBL_OPENING_BALANCE.FINANCIAL_YEAR_name];
                        //obj_frm_TBL_OPENING_BALANCE.DateEdit_FINANCIAL_YEAR_fromDate.EditValue = dt_Main.Rows[0][BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_CTBL_OPENING_BALANCE.FINANCIAL_YEAR_fromDate];
                        //obj_frm_TBL_OPENING_BALANCE.DateEdit_FINANCIAL_YEAR_fromTo.EditValue = dt_Main.Rows[0][BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_CTBL_OPENING_BALANCE.FINANCIAL_YEAR_fromTo];
                        //obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_lastFinancialYear.EditValue = dt_Main.Rows[0][BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_CTBL_OPENING_BALANCE.FINANCIAL_YEAR_lastFinancialYear];
                        //obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_narration.EditValue = dt_Main.Rows[0][BLL.ACC_BLL.TBL_OPENING_BALANCE.cls_CTBL_OPENING_BALANCE.FINANCIAL_YEAR_narration];

                        obj_frm_TBL_OPENING_BALANCE.DBStatus = 'U';
                        //obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Enabled = false;
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




                        //obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Visible = isAutoGeneratedOption;

                        if (!isAllowedInsertion && !isAllowedUpdation)
                              obj_frm_TBL_OPENING_BALANCE.SimpleButton_Save.Enabled = false;
                         initiateGrid(true);
                        selection("V", obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID);
                        Referesh("False");

                  }
                  else if (isComplete == "Partial")
                  {
                        selection("N", "");
                        Referesh("False");

                  }


                  //ObjGenForm.GenRefresh();
                  //obj_frm_TBL_OPENING_BALANCE.DBStatus = 'U';
                  ////obj_frm_TBL_OPENING_BALANCE.CheckEdit_Is_AutoGenegereted.Enabled = true;
                  ////obj_frm_TBL_OPENING_BALANCE.CheckEdit_navigate.Checked = false;
                  //getMax();
                  //DT_dataTableForGrid.Rows.Clear();

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





                  //obj_cls_TBL_OPENING_BALANCE.FINANCIAL_YEAR_ID = obj_frm_TBL_OPENING_BALANCE.TextEdit_FINANCIAL_YEAR_ID.Text;

                  if (obj_cls_TBL_OPENING_BALANCE.deletion())
                  {
                        Referesh("Partial");
                        if (isDisturebedOnce)
                              obj_frm_TBL_OPENING_BALANCE.Close();
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

                  if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'I')
                  {

                        if (obj_cls_MessageBox.MessageBoxStatic("I_Q") == "no")
                        {
                              return;
                        }

                        if (obj_cls_TBL_OPENING_BALANCE.insertionUpdation('I'))
                        {
                              Referesh("True");
                              if (isDisturebedOnce)
                                    obj_frm_TBL_OPENING_BALANCE.Close();
                        }


                  }

                  else if (obj_frm_TBL_OPENING_BALANCE.DBStatus == 'U')
                  {

                        if (obj_cls_MessageBox.MessageBoxStatic("U_Q") == "no")
                        {
                              return;
                        }

                        if (obj_cls_TBL_OPENING_BALANCE.insertionUpdation('U'))
                        {
                              Referesh("True");
                              if (isDisturebedOnce)
                                    obj_frm_TBL_OPENING_BALANCE.Close();
                        }
                  }

            }

            public void selection(string pStatus, string pId)
            {

                  if (pStatus == "N")
                  {
                        if (pId == "")
                        {
                              //obj_cls_DataSet_ACC.f_TBL_OPENING_BALANCE("L", pId);
                              //DataSet ds = obj_cls_DataSet_ACC.g_TBL_OPENING_BALANCE;
                              //if (ds == null)
                              //{
                              //      obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                              //      Referesh("False");
                              //      return;

                              //}

                              //dt_Datanavigator = ds.Tables[0].Copy();
                              //obj_frm_TBL_OPENING_BALANCE.DataNavigator_Navigate.DataSource = dt_Datanavigator;
                        }
                        else
                        {

                              //string ID = dt_Datanavigator.Rows[Convert.ToInt32(pId)][cls_CTBL_OPENING_BALANCE.priFINANCIAL_YEAR_ID].ToString();
                              //selection("V", ID);
                        }
                  }
                  else if (pStatus == "A")
                  {

                        //obj_cls_DataSet_ACC.f_TBL_OPENING_BALANCE("A", pId);
                        //DataSet ds = obj_cls_DataSet_ACC.g_TBL_OPENING_BALANCE;

                        //if (ds == null)
                        //{
                        //      obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        //      Referesh("False");
                        //      return;

                        //}


                        //obj_frlLOOKUP = new GEN.GEN_GEN.Look.frlLOOKUP(ds, 4, true, "150,150,150,150,150,150", 1);
                        //obj_frlLOOKUP.ShowDialog();
                        //string value = GEN.GEN_GEN.Look.frlLOOKUP.value;
                        //if (value != "")
                        //{
                        //      string[] cols_values = value.Split('|');
                        //      obj_frm_TBL_OPENING_BALANCE.CheckEdit_navigate.Checked = false;
                        //      selection("V", cols_values[0]);
                        //}

                  }
                  else if (pStatus == "G")
                  {
                        obj_cls_DataSet_ACC.f_TBL_FINANCIAL_YEAR("G", pId);
                        DataSet ds = obj_cls_DataSet_ACC.g_TBL_FINANCIAL_YEAR;
                        if (ds == null)
                        {
                              obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                              Referesh("False");
                              return;

                        }

                        DT_dataTableForGrid = ds.Tables[0].Copy();
                  }
                  else
                  {

                        obj_cls_DataSet_ACC.f_TBL_FINANCIAL_YEAR("V", pId);
                        DataSet ds = obj_cls_DataSet_ACC.g_TBL_FINANCIAL_YEAR;
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

            public void initiateGrid(bool isNew)
            {
                  if (isNew)
                        selection("G", "");
                  obj_frm_TBL_OPENING_BALANCE.GridControl_TBL_OPENING_BALANCE.DataSource = DT_dataTableForGrid;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.PopulateColumns();

                  //GEN.GEN_GEN.GenericClasses.Grid.cls_GridAppearance.setAppearance(obj_frm_TBL_TEMP_MAIN.GridView_TBL_TEMP_DET, "I");

                  // OPENING_BALANCE_COA

                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA].Caption = "Accounts";
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA].OptionsColumn.FixedWidth = false;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA].Width = 100;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA].Tag = "N|N|N|Y";
                  ACC_PRESENTATION_LAYER.cls_bindGridLookColumns.TBL_COA(
                        obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA]
                        , "L_Type_Transaction_Active"
                        , ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name
                        );

                  // OPENING_BALANCE_debit

                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].Caption = "Debit";
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].OptionsColumn.FixedWidth = true;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].Width = 100;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].Tag = "N2|S|N|N";


                  // OPENING_BALANCE_credit

                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].Caption = "Credit";
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].OptionsColumn.FixedWidth = true;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].Width = 100;
                  obj_frm_TBL_OPENING_BALANCE.GridView_TBL_OPENING_BALANCE.Columns[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].Tag = "N2|S|N|N";






                  ObjGenGrid.Formatting();
            }


            //VVVGRIDINFOVVV



      }
}
