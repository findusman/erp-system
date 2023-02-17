﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS
{
      public class cls_TBL_PRODUCTS_P
      {

            Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false, isAutoGeneratedOption = false;

            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

            DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet_IMS = new DATASET.IMS_DATASET.cls_DataSet();

            GEN.GEN_GEN.Look.frlLOOKUP obj_frlLOOKUP = null;

            BLL.IMS_BLL.TBL_PRODUCTS.cls_TBL_PRODUCTS obj_cls_TBL_PRODUCTS = new BLL.IMS_BLL.TBL_PRODUCTS.cls_TBL_PRODUCTS();

            frm_TBL_PRODUCTS obj_frm_TBL_PRODUCTS = null;

            DataTable dt_Datanavigator = new DataTable();

            void InitializeComponents(frm_TBL_PRODUCTS pobj_frm_TBL_PRODUCTS, String pID)
            {

                  obj_frm_TBL_PRODUCTS = pobj_frm_TBL_PRODUCTS;
                  GEN.GEN_GEN.GenericClasses.cls_CustomeForm.applyPropertiesOnXtraForm(obj_frm_TBL_PRODUCTS, 'A');
                  obj_cls_TBL_PRODUCTS.obj_XtraForm = pobj_frm_TBL_PRODUCTS;

                  if (!obj_cls_TBL_PRODUCTS.Open())
                        obj_frm_TBL_PRODUCTS.Close();



                  if (pID == "N")
                        Referesh("True");
                  else
                  {
                      Referesh("True");

                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.Text = pID;

                        selection("V", obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.Text.Trim());

                  }

            }


            public cls_TBL_PRODUCTS_P(frm_TBL_PRODUCTS pobj_frm_TBL_PRODUCTS, String pID, GEN.GEN_GEN.GenericClasses.Form.Gen_Form pObjGenForm, bool pIs_DisturbanceOnce)//VVVParamVVV
            {
                  ObjGenForm = pObjGenForm;
                  isDisturebedOnce = pIs_DisturbanceOnce;
                  InitializeComponents(pobj_frm_TBL_PRODUCTS, pID);

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

                        if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                        {
                              value = obj_cls_MessageBox.error_selection_msg;
                              return false;
                        }

                  }
                  else
                  {
                        if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                        {
                              if (!isAllowedInsertion)
                              {
                                    value = obj_cls_MessageBox.error_insert_rights;
                                    return false;

                              }

                        }
                        if (obj_frm_TBL_PRODUCTS.DBStatus == 'U')
                        {
                              if (!isAllowedUpdation)
                              {
                                    value = obj_cls_MessageBox.error_update_rights;
                                    return false;

                              }

                        }

                        if (Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.EditValue) == "")
                        {
                              value = obj_cls_MessageBox.error_Name_msg;
                              obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.Focus();
                              obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red;
                              return false;
                        }


                        //department
                        if (Convert.ToString(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.EditValue) == "")
                        {
                              value = "First provide Department in order to perform action";
                              obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.Focus();
                              obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red;
                              return false;
                        }

                        //packing
                        if (Convert.ToString(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue) == "")
                        {
                              value = "First provide Packing in order to perform action";
                              obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.Focus();
                              obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red;
                              return false;
                        }
                  }

                  if (obj_frm_TBL_PRODUCTS.DBStatus == 'U')
                        if (Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue) == "")
                        {
                              value = obj_cls_MessageBox.error_ID_msg;
                              return false;
                        }
                  if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                        if (!obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Checked && Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue) == "")
                        {
                              value = obj_cls_MessageBox.error_ID_msg;
                              return false;
                        }


                  value = "N";
                  return true;
            }




            public void getMax()
            {
                  if (obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Checked)
                  {

                        int tempID = obj_cls_DataSet_IMS.f_GETMAX("TBL_PRODUCTS", 0, 0, 0, "", "", "");
                        obj_frm_TBL_PRODUCTS.maxID = tempID.ToString();
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.Text = obj_frm_TBL_PRODUCTS.maxID;

                  }
            }



            public void loadGridLookUpEdit(string Status)
            {

                  if (Status == "TBL_PACKINGS_MAIN")

                        IMS_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_PACKINGS_MAIN(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing);

                  if (Status == "TBL_DEPARTMENTS")
                        IMS_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_DEPARTMENTS(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department,false);
                  //string str = obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.Properties.GetKeyValue(0).ToString();
                  //obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue = str;

                  //         addMaxLevel();


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
                              obj_cls_TBL_PRODUCTS.STATUS = "D";
                              obj_cls_TBL_PRODUCTS.PRODUCT_ID = Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue);
                        }
                        {

                              obj_cls_TBL_PRODUCTS.Is_Auto_Generated = obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Checked;

                              if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                              {

                                    if (!obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Checked)
                                          obj_cls_TBL_PRODUCTS.PRODUCT_ID = Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue);
                              }
                              else
                                    obj_cls_TBL_PRODUCTS.PRODUCT_ID = Convert.ToString(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue);


                              obj_cls_TBL_PRODUCTS.PRODUCT_name = obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.EditValue.ToString().Trim();
                              obj_cls_TBL_PRODUCTS.PRODUCT_packing = obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue.ToString().Trim();
                              obj_cls_TBL_PRODUCTS.PRODUCT_defaultLevel = obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_defaultLevel.EditValue.ToString().Trim();
                              obj_cls_TBL_PRODUCTS.PRODUCT_department = obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.EditValue.ToString().Trim();
                              obj_cls_TBL_PRODUCTS.PRODUCT_saleRate = Convert.ToDecimal(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_saleRate.EditValue.ToString().Trim() == "" ? "0" : obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_saleRate.EditValue.ToString().Trim());
                              obj_cls_TBL_PRODUCTS.PRODUCT_purchaseRate = Convert.ToDecimal(obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_purchaseRate.EditValue.ToString().Trim() == "" ? "0" : obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_purchaseRate.EditValue.ToString().Trim());
                              obj_cls_TBL_PRODUCTS.PRODUCT_barCode = obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_barCode.EditValue.ToString().Trim();
                              obj_cls_TBL_PRODUCTS.PRODUCT_isService = obj_frm_TBL_PRODUCTS.CheckEdit_PRODUCT_isService.Checked;


                              DataRow _Dr = (obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.Properties.GetRowByKeyValue(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.EditValue) as DataRowView).Row;
                              obj_cls_TBL_PRODUCTS.DEPARTMETN_COA = _Dr[BLL.IMS_BLL.TBL_DEPARTMENTS.cls_CTBL_DEPARTMENTS.DEPARTMENT_COA].ToString();

                        
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

                        obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Checked = (Boolean)dt_Main.Rows[0][GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.Is_Auto_Generated];



                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_name];
                        obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_packing];
                        addMaxLevel();
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_defaultLevel.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_defaultLevel];
                        obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_department];
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_saleRate.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_saleRate];
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_purchaseRate.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_purchaseRate];
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_barCode.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_barCode];
                        obj_frm_TBL_PRODUCTS.CheckEdit_PRODUCT_isService.EditValue = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_isService];
                        obj_cls_TBL_PRODUCTS.PRODUCT_COA = dt_Main.Rows[0][BLL.IMS_BLL.TBL_PRODUCTS.cls_CTBL_PRODUCTS.PRODUCT_COA].ToString();
                        obj_frm_TBL_PRODUCTS.DBStatus = 'U';
                        obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Enabled = false;
                        //obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.Enabled = false;

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



                        loadGridLookUpEdit("TBL_PACKINGS_MAIN");
                        loadGridLookUpEdit("TBL_DEPARTMENTS");

                        obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Visible = isAutoGeneratedOption;

                        if (!isAllowedInsertion && !isAllowedUpdation)
                              obj_frm_TBL_PRODUCTS.SimpleButton_Save.Enabled = false;
                        if (!isAllowedDeletion)
                              obj_frm_TBL_PRODUCTS.SimpleButton_Delete.Enabled = false;

                        selection("N", "");
                        Referesh("False");

                  }
                  else if (isComplete == "Partial")
                  {
                        selection("N", "");
                        Referesh("False");

                  }


                  ObjGenForm.GenRefresh();
                  obj_frm_TBL_PRODUCTS.DBStatus = 'I';
                  obj_frm_TBL_PRODUCTS.CheckEdit_Is_AutoGenegereted.Enabled = true;
                  obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_department.Enabled = true;
                  //obj_frm_TBL_PRODUCTS.CheckEdit_navigate.Checked = false;
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





                  obj_cls_TBL_PRODUCTS.PRODUCT_ID = obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.Text;

                  if (obj_cls_TBL_PRODUCTS.deletion())
                  {
                        Referesh("Partial");
                        if (isDisturebedOnce)
                              obj_frm_TBL_PRODUCTS.Close();
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

                  if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                  {

                        if (obj_cls_MessageBox.MessageBoxStatic("I_Q") == "no")
                        {
                              return;
                        }

                        if (obj_cls_TBL_PRODUCTS.insertionUpdation('I'))
                        {
                              Referesh("Partial");
                              if (isDisturebedOnce)
                                    obj_frm_TBL_PRODUCTS.Close();
                        }


                  }

                  else if (obj_frm_TBL_PRODUCTS.DBStatus == 'U')
                  {

                        if (obj_cls_MessageBox.MessageBoxStatic("U_Q") == "no")
                        {
                              return;
                        }

                        if (obj_cls_TBL_PRODUCTS.insertionUpdation('U'))
                        {
                              Referesh("Partial");
                              if (isDisturebedOnce)
                                    obj_frm_TBL_PRODUCTS.Close();
                        }
                  }

            }


            public void Rate_Adjustment()
            {
                if (XtraMessageBox.Show("You want to adjust rates..?", "DM", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    obj_cls_TBL_PRODUCTS.Rate_Adjustment();

                    obj_cls_MessageBox.MessageBoxStatic("I_S");


                }
            }


            public void selection(string pStatus, string pId)
            {

                  if (pStatus == "N")
                  {
                        if (pId == "")
                        {
                              obj_cls_DataSet_IMS.f_TBL_PRODUCTS("L", pId);
                              DataSet ds = obj_cls_DataSet_IMS.g_TBL_PRODUCTS;
                              if (ds == null)
                              {
                                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                                    Referesh("False");
                                    return;

                              }

                              dt_Datanavigator = ds.Tables[0].Copy();
                              obj_frm_TBL_PRODUCTS.DataNavigator_Navigate.DataSource = dt_Datanavigator;
                        }
                        else
                        {

                              string ID = dt_Datanavigator.Rows[Convert.ToInt32(pId)][0].ToString();
                              selection("V", ID);
                        }
                  }
                  else if (pStatus == "A")
                  {

                        obj_cls_DataSet_IMS.f_TBL_PRODUCTS("A", pId);
                        DataSet ds = obj_cls_DataSet_IMS.g_TBL_PRODUCTS;

                        if (ds == null)
                        {
                              obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                              Referesh("False");
                              return;

                        }


                        obj_frlLOOKUP = new GEN.GEN_GEN.Look.frlLOOKUP(ds, 4, true, "150,150,150,150,150,150,150,150,150", 1);
                        obj_frlLOOKUP.ShowDialog();
                        string value = GEN.GEN_GEN.Look.frlLOOKUP.value;
                        if (value != "")
                        {
                              string[] cols_values = value.Split('|');
                              obj_frm_TBL_PRODUCTS.CheckEdit_navigate.Checked = false;
                              selection("V", cols_values[0]);
                        }

                  }
                  else
                  {

                        obj_frm_TBL_PRODUCTS.maxID = obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.Text = pId;
                        obj_cls_DataSet_IMS.f_TBL_PRODUCTS("V", pId);
                        DataSet ds = obj_cls_DataSet_IMS.g_TBL_PRODUCTS;
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

            public void addMaxLevel()
            {
              

                  try
                  {
                        obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_defaultLevel.Properties.Items.Clear();
                        if (obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue != null)
                        {
                              DataRow _Dr = (obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.Properties.GetRowByKeyValue(obj_frm_TBL_PRODUCTS.GridLookUpEdit_PRODUCT_packing.EditValue) as DataRowView).Row;
                              String _Value = _Dr[2].ToString();

                              for (int i = 0; i < Convert.ToInt32(_Value); i++)
                                    obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_defaultLevel.Properties.Items.Add((i + 1).ToString());
                              obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_defaultLevel.SelectedIndex = 0;
                        }
                  }
                  catch { }

            }


            //VVVGRIDINFOVVV


            public void printPriceTag()
            {
                try
                {
                    if (obj_frm_TBL_PRODUCTS.DBStatus == 'I')
                        return;


                    for (int x = 0; x < Convert.ToInt32(obj_frm_TBL_PRODUCTS.textEdit_printHowMany.EditValue); x++)
                    {
                        PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Reports.Sales.SaleInvoice.DM.rpt_barCodePrint r =
                            new PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Reports.Sales.SaleInvoice.DM.rpt_barCodePrint(
                                "",
                                obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_ID.EditValue.ToString()
                              , obj_frm_TBL_PRODUCTS.TextEdit_PRODUCT_name.EditValue.ToString()
                              
                              );
                        
                        DevExpress.XtraReports.UI.ReportPrintTool objt = new DevExpress.XtraReports.UI.ReportPrintTool(r);
                        objt.Print();
                    }
                }
                catch (Exception ex)
                {


                }

            }
     


      }
}