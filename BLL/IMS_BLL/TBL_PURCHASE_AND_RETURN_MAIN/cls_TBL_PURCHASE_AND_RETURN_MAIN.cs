using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_PURCHASE_AND_RETURN_MAIN
{

      public class cls_TBL_PURCHASE_AND_RETURN_MAIN
      {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
            public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
            BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            public DataTable dt_Detail = new System.Data.DataTable();
            public DataTable dt_DetailVCH = new System.Data.DataTable();

            string ExeState = "";

            private string pSTATUS;
            public String STATUS
            {
                  get { return pSTATUS; }
                  set { pSTATUS = value; }
            }

            private int pSTOCK_maxID = 0;

            public int STOCK_maxID
            {
                  get { return pSTOCK_maxID; }
                  set { pSTOCK_maxID = value; }
            }



            private string pPURCHASE_AND_RETURN_MAIN_ID = string.Empty;

            public string PURCHASE_AND_RETURN_MAIN_ID
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_ID; }
                  set { pPURCHASE_AND_RETURN_MAIN_ID = value; }
            }




            private string pPURCHASE_AND_RETURN_MAIN_supplierID = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_supplierID
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_supplierID; }
                  set { pPURCHASE_AND_RETURN_MAIN_supplierID = value; }
            }


            private string pPURCHASE_AND_RETURN_MAIN_VCHID = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_VCHID
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_VCHID; }
                  set { pPURCHASE_AND_RETURN_MAIN_VCHID = value; }
            }


            private string pPURCHASE_AND_RETURN_MAIN_cashOrCredit = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_cashOrCredit
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_cashOrCredit; }
                  set { pPURCHASE_AND_RETURN_MAIN_cashOrCredit = value; }
            }


            private string pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_purchaseOrReturn
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn; }
                  set { pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn = value; }
            }


            private DateTime pPURCHASE_AND_RETURN_MAIN_date = DateTime.Now;
            public DateTime PURCHASE_AND_RETURN_MAIN_date
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_date; }
                  set { pPURCHASE_AND_RETURN_MAIN_date = value; }
            }


            private string pPURCHASE_AND_RETURN_MAIN_reference = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_reference
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_reference; }
                  set { pPURCHASE_AND_RETURN_MAIN_reference = value; }
            }


            private string pPURCHASE_AND_RETURN_MAIN_narration = string.Empty;
            public string PURCHASE_AND_RETURN_MAIN_narration
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_narration; }
                  set { pPURCHASE_AND_RETURN_MAIN_narration = value; }
            }



            private String pPURCHASE_AND_RETURN_DETAILS_mainID;

            public String PURCHASE_AND_RETURN_DETAILS_mainID
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_mainID; }
                  set { pPURCHASE_AND_RETURN_DETAILS_mainID = value; }
            }
            private int pPURCHASE_AND_RETURN_DETAILS_orderingID;

            public int PURCHASE_AND_RETURN_DETAILS_orderingID
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_orderingID; }
                  set { pPURCHASE_AND_RETURN_DETAILS_orderingID = value; }
            }


            private string pPURCHASE_AND_RETURN_DETAILS_itemID = string.Empty;
            public string PURCHASE_AND_RETURN_DETAILS_itemID
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_itemID; }
                  set { pPURCHASE_AND_RETURN_DETAILS_itemID = value; }
            }


            private decimal pPURCHASE_AND_RETURN_DETAILS_purchasePrice = 0;
            public decimal PURCHASE_AND_RETURN_DETAILS_purchasePrice
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_purchasePrice; }
                  set { pPURCHASE_AND_RETURN_DETAILS_purchasePrice = value; }
            }


            private decimal pPURCHASE_AND_RETURN_DETAILS_QTY = 0;
            public decimal PURCHASE_AND_RETURN_DETAILS_QTY
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_QTY; }
                  set { pPURCHASE_AND_RETURN_DETAILS_QTY = value; }
            }


            private decimal pPURCHASE_AND_RETURN_DETAILS_total = 0;
            public decimal PURCHASE_AND_RETURN_DETAILS_total
            {
                  get { return pPURCHASE_AND_RETURN_DETAILS_total; }
                  set { pPURCHASE_AND_RETURN_DETAILS_total = value; }
            }



            private decimal pPURCHASE_AND_RETURN_MAIN_totalAmount = 0;
            public decimal PURCHASE_AND_RETURN_MAIN_totalAmount
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_totalAmount; }
                  set { pPURCHASE_AND_RETURN_MAIN_totalAmount = value; }
            }


            private decimal pPURCHASE_AND_RETURN_MAIN_totalPayableAmount = 0;
            public decimal PURCHASE_AND_RETURN_MAIN_totalPayableAmount
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_totalPayableAmount; }
                  set { pPURCHASE_AND_RETURN_MAIN_totalPayableAmount = value; }
            }


            private decimal pPURCHASE_AND_RETURN_MAIN_discountAmount = 0;
            public decimal PURCHASE_AND_RETURN_MAIN_discountAmount
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_discountAmount; }
                  set { pPURCHASE_AND_RETURN_MAIN_discountAmount = value; }
            }


            private decimal pPURCHASE_AND_RETURN_MAIN_paidAmount = 0;
            public decimal PURCHASE_AND_RETURN_MAIN_paidAmount
            {
                  get { return pPURCHASE_AND_RETURN_MAIN_paidAmount; }
                  set { pPURCHASE_AND_RETURN_MAIN_paidAmount = value; }
            }


            private bool pIs_Auto_Generated = true;

            public bool Is_Auto_Generated
            {
                  get { return pIs_Auto_Generated; }
                  set { pIs_Auto_Generated = value; }
            }

            private string pUser_ID = string.Empty;

            public string User_ID
            {
                  get { return pUser_ID; }
                  set { pUser_ID = value; }
            }

            private string padd = string.Empty;

            public string add
            {
                  get { return padd; }
                  set { padd = value; }
            }


            bool insertUpdateOnlyPurchase(

                      SqlCommand pobj_SqlCommand,
                      DAL.DALCustome pobj_DALCustome,
                      char pProcedureStatus,
                  string pParentID,
                  out string pChildID

                  )
            {
                  pChildID = "";
                  SqlParameter[] sql_param = new SqlParameter[17];

                  sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[2] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[2].Value = PURCHASE_AND_RETURN_MAIN_ID;


                  sql_param[3] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_supplierID", SqlDbType.NVarChar);
                  sql_param[3].Value = PURCHASE_AND_RETURN_MAIN_supplierID;

                  sql_param[4] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_VCHID", SqlDbType.NVarChar);
                  sql_param[4].Value = pParentID;

                  sql_param[5] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_cashOrCredit", SqlDbType.NVarChar);
                  sql_param[5].Value = PURCHASE_AND_RETURN_MAIN_cashOrCredit;

                  sql_param[6] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_purchaseOrReturn", SqlDbType.NVarChar);
                  sql_param[6].Value = PURCHASE_AND_RETURN_MAIN_purchaseOrReturn;

                  sql_param[7] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_date", SqlDbType.DateTime);
                  sql_param[7].Value = PURCHASE_AND_RETURN_MAIN_date;

                  sql_param[8] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_totalAmount", SqlDbType.Float);
                  sql_param[8].Value = PURCHASE_AND_RETURN_MAIN_totalAmount;

                  sql_param[9] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_totalPayableAmount", SqlDbType.Float);
                  sql_param[9].Value = PURCHASE_AND_RETURN_MAIN_totalPayableAmount;

                  sql_param[10] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_discountAmount", SqlDbType.Float);
                  sql_param[10].Value = PURCHASE_AND_RETURN_MAIN_discountAmount;

                  sql_param[11] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_paidAmount", SqlDbType.Float);
                  sql_param[11].Value = PURCHASE_AND_RETURN_MAIN_paidAmount;

                  sql_param[12] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_reference", SqlDbType.NVarChar);
                  sql_param[12].Value = PURCHASE_AND_RETURN_MAIN_reference;

                  sql_param[13] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_narration", SqlDbType.NVarChar);
                  sql_param[13].Value = PURCHASE_AND_RETURN_MAIN_narration;

                  sql_param[14] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                  sql_param[14].Value = Is_Auto_Generated;

                  sql_param[15] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
                  sql_param[15].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  sql_param[16] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                  sql_param[16].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                  DataSet ds = new DataSet();

                  if (pProcedureStatus == 'I')
                        ds = pobj_DALCustome.selection("sp_TBL_PURCHASE_AND_RETURN_MAIN_insertion", sql_param, pobj_SqlCommand,PURCHASE_AND_RETURN_MAIN_purchaseOrReturn == "Opening" ? true : false);
                  else
                        ds = pobj_DALCustome.selection("sp_TBL_PURCHASE_AND_RETURN_MAIN_updation", sql_param, pobj_SqlCommand, PURCHASE_AND_RETURN_MAIN_purchaseOrReturn == "Opening" ? true : false);
                  if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                  {

                        pobj_DALCustome.transactioRollBack();
                        pobj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                        return false;
                  }
                  else
                  {
                        ExeState = ds.Tables[0].Rows[0][0].ToString();
                        pChildID = ds.Tables[0].Rows[0][1].ToString();

                        if (pChildID != "N" && ExeState == "ok")
                        {


                              PURCHASE_AND_RETURN_MAIN_ID = pChildID;
                              PURCHASE_AND_RETURN_DETAILS_orderingID = 0;
                              foreach (DataRow dr in dt_Detail.Rows)
                              {


                                    sql_param = new SqlParameter[11];

                                    sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                                    sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                                    sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                                    sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                                    sql_param[2] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_mainID", SqlDbType.NVarChar);
                                    sql_param[2].Value = PURCHASE_AND_RETURN_MAIN_ID;

                                    sql_param[3] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_orderingID", SqlDbType.Int);
                                    sql_param[3].Value = PURCHASE_AND_RETURN_DETAILS_orderingID;


                                    sql_param[4] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_itemID", SqlDbType.NVarChar);
                                    sql_param[4].Value = dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.A_PURCHASE_AND_RETURN_DETAILS_itemCode];

                                    sql_param[5] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_itemUnit", SqlDbType.NVarChar);
                                    sql_param[5].Value = dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.A_PURCHASE_AND_RETURN_DETAILS_itemUnitCode];


                                    sql_param[6] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_purchasePrice", SqlDbType.Float);
                                    sql_param[6].Value = Convert.ToDouble(dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_purchasePrice]) == 0 ? 1 : dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_purchasePrice];
                                    sql_param[7] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_QTY", SqlDbType.Float);
                                    sql_param[7].Value = Convert.ToDouble(dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_QTY]) == 0 ? 1 : dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_QTY];
                                    sql_param[8] = new SqlParameter("@PURCHASE_AND_RETURN_DETAILS_total", SqlDbType.Float);
                                    sql_param[8].Value = Convert.ToDouble(dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_total]) == 0 ? 1 : dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_total];



                                    sql_param[9] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                                    sql_param[9].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                                    sql_param[10] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                                    sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;



                                    ds = pobj_DALCustome.selection("sp_PURCHASE_AND_RETURN_DETAILS_insertion", sql_param, pobj_SqlCommand, false);

                                    if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                                    {

                                          pobj_DALCustome.transactioRollBack();
                                          pobj_DALCustome.closeconnection();
                                          obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                                          return false;
                                    }
                                    else
                                    {
                                          ExeState = ds.Tables[0].Rows[0][0].ToString();

                                          if (ExeState == "ok")
                                          {
                                                PURCHASE_AND_RETURN_DETAILS_orderingID++;
                                                continue;
                                          }
                                          else
                                          {
                                                pobj_DALCustome.transactioRollBack();
                                                pobj_DALCustome.closeconnection();
                                                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                                                return false;

                                          }

                                    }

                              }


                        }
                  }

                  return true;


            }


            public bool insertionUpdation(char pProcedureStatus)
            {

                if (dt_Detail.Rows.Count < 1)
                {
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                    return false;
                }



               

                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  BLL.ACC_BLL.TBL_VCH_MAIN.cls_TBL_VCH_MAIN obj_cls_TBL_VCH_MAIN = new ACC_BLL.TBL_VCH_MAIN.cls_TBL_VCH_MAIN();



                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }


                  string ParentID = "", ChildID = "";


                  if (PURCHASE_AND_RETURN_MAIN_purchaseOrReturn != "Opening")
                  {
                        if (

                              !obj_cls_TBL_VCH_MAIN.insertionUpdationOnlyVCH(

                                          obj_SqlCommand,
                                          obj_DALCustome,
                                          pProcedureStatus,
                                          PURCHASE_AND_RETURN_MAIN_VCHID,
                                          PURCHASE_AND_RETURN_MAIN_narration,
                                          pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn == "Purchase" ? "PI" : "PR",
                                          PURCHASE_AND_RETURN_MAIN_date,
                                          "",
                                          "",//VCH_reference,
                                          "",//VCH_chequeNo,
                                          true,//VCH_isApproved,
                                          true,//VCH_isEffectOnFinance,
                                          Is_Auto_Generated,
                                          dt_DetailVCH,
                                          out ParentID
                              )
                           )
                              return false;
                  }
                  PURCHASE_AND_RETURN_MAIN_VCHID = ParentID;


                  if (
                        !insertUpdateOnlyPurchase(

                                                      obj_SqlCommand,
                                                      obj_DALCustome,
                                                      pProcedureStatus,
                                                      ParentID,
                                                      out ChildID
                                                )
                     )
                        return false;
                 
                  PURCHASE_AND_RETURN_DETAILS_mainID = ChildID;

                  BLL.IMS_BLL.TBL_STOCKS.cls_TBL_STOCKS obj_cls_TBL_STOCKS = new TBL_STOCKS.cls_TBL_STOCKS();

                  obj_cls_TBL_STOCKS.STOCK_stockAddRemoveStatus = add;

                  if (
                        !obj_cls_TBL_STOCKS.InsertUpdateOnlyStockPurchase(

                          obj_SqlCommand,
                          obj_DALCustome,
                          dt_Detail,
                          PURCHASE_AND_RETURN_DETAILS_mainID,//pSTOCK_transactionID        ,
                          PURCHASE_AND_RETURN_MAIN_VCHID,//pSTOCK_VCHID                     ,
                          PURCHASE_AND_RETURN_MAIN_purchaseOrReturn,//pSTOCK_transactionParentType     ,
                          PURCHASE_AND_RETURN_MAIN_cashOrCredit,//pSTOCK_transactionChildType,
                          PURCHASE_AND_RETURN_MAIN_date,
                          pProcedureStatus == 'I' ? -1 : STOCK_maxID,////STOCK_date                      ,
                          "",
                          PURCHASE_AND_RETURN_MAIN_narration//pSTOCK_stockLocationID

                      ))
                   return false;






                  string Log_description = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogDescription : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogDescription;
                  string Log_event = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogEvent : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogEvent;

                  if (obj_cls_TBL_LOG.insertion(PURCHASE_AND_RETURN_DETAILS_mainID, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
                  {

                        obj_DALCustome.transactioCommit();
                        obj_DALCustome.closeconnection();
                        if (pProcedureStatus == 'I')
                              obj_cls_MessageBox.MessageBoxStatic("I_S");
                        else
                              obj_cls_MessageBox.MessageBoxStatic("U_S");
                        return true;
                  }
                  else
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        return false;

                  }



                  return false;

            }

            public bool Open()
            {
                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");
                        return false;
                  }

                  if (obj_cls_TBL_LOG.insertion("O", obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_ScreenOpenedLogDescription, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_ScreenOpenedLogEvent, obj_SqlCommand, obj_DALCustome, true))
                  {

                        obj_DALCustome.transactioCommit();
                        obj_DALCustome.closeconnection();
                        return true;
                  }
                  else
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        return false;

                  }


            }




            public bool deletion()
            {
                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  SqlParameter[] sql_param = new SqlParameter[4];

                  sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
                  sql_param[0].Value = STATUS;

                  sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[3] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = PURCHASE_AND_RETURN_MAIN_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_PURCHASE_AND_RETURN_MAIN_deletion", sql_param, obj_SqlCommand, true);

                  if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                  {

                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                        return false;
                  }
                  else
                  {
                        ExeState = ds.Tables[0].Rows[0][0].ToString();
                        string Id = ds.Tables[0].Rows[0][1].ToString();

                        if (Id != "N")
                        {

                              string Log_description = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogDescription;
                              string Log_event = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogEvent;

                              if (obj_cls_TBL_LOG.insertion(Id, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
                              {

                                    obj_DALCustome.transactioCommit();
                                    obj_DALCustome.closeconnection();
                                    obj_cls_MessageBox.MessageBoxStatic("D_S");
                                    return true;
                              }
                              else
                              {
                                    obj_DALCustome.transactioRollBack();
                                    obj_DALCustome.closeconnection();
                                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                                    return false;

                              }
                        }
                        else
                        {
                              obj_DALCustome.transactioCommit();
                              obj_DALCustome.closeconnection();

                              obj_cls_MessageBox.MessageBoxDynamics(ExeState, "D_E");

                              return false;

                        }


                  }
                  return false;
            }


            public DataSet selection()
            {

                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        return null;
                  }

                  SqlParameter[] sql_param = new SqlParameter[7];

                  sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
                  sql_param[0].Value = STATUS;

                  sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[3] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_cashOrCredit", SqlDbType.NVarChar);
                  sql_param[3].Value = PURCHASE_AND_RETURN_MAIN_cashOrCredit;

                  sql_param[4] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_purchaseOrReturn", SqlDbType.NVarChar);
                  sql_param[4].Value = PURCHASE_AND_RETURN_MAIN_purchaseOrReturn;

                  sql_param[5] = new SqlParameter("@PURCHASE_AND_RETURN_MAIN_ID", SqlDbType.NVarChar);
                  sql_param[5].Value = PURCHASE_AND_RETURN_MAIN_ID;

                  sql_param[6] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[6].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_PURCHASE_AND_RETURN_MAIN_selection", sql_param, obj_SqlCommand, true);

                  if (ds != null)
                  {

                        obj_DALCustome.transactioCommit();
                        obj_DALCustome.closeconnection();
                        return ds;
                  }
                  else
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        return null;

                  }

                  return ds;

            }

      }
}
