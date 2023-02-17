using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN
{

      public class cls_TBL_SALES_AND_RETURN_MAIN
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



            private string pSALES_AND_RETURN_MAIN_ID = string.Empty;

            public string SALES_AND_RETURN_MAIN_ID
            {
                  get { return pSALES_AND_RETURN_MAIN_ID; }
                  set { pSALES_AND_RETURN_MAIN_ID = value; }
            }




            private string pSALES_AND_RETURN_MAIN_supplierID = string.Empty;
            public string SALES_AND_RETURN_MAIN_supplierID
            {
                  get { return pSALES_AND_RETURN_MAIN_supplierID; }
                  set { pSALES_AND_RETURN_MAIN_supplierID = value; }
            }


            private string pSALES_AND_RETURN_MAIN_VCHID = string.Empty;
            public string SALES_AND_RETURN_MAIN_VCHID
            {
                  get { return pSALES_AND_RETURN_MAIN_VCHID; }
                  set { pSALES_AND_RETURN_MAIN_VCHID = value; }
            }


            private string pSALES_AND_RETURN_MAIN_cashOrCredit = string.Empty;
            public string SALES_AND_RETURN_MAIN_cashOrCredit
            {
                  get { return pSALES_AND_RETURN_MAIN_cashOrCredit; }
                  set { pSALES_AND_RETURN_MAIN_cashOrCredit = value; }
            }


            private string pSALES_AND_RETURN_MAIN_SALESOrReturn = string.Empty;
            public string SALES_AND_RETURN_MAIN_SALESOrReturn
            {
                  get { return pSALES_AND_RETURN_MAIN_SALESOrReturn; }
                  set { pSALES_AND_RETURN_MAIN_SALESOrReturn = value; }
            }

        private string pMessage_Limit = string.Empty;
        public string Message_Limit
        {
            get { return pMessage_Limit; }
            set { pMessage_Limit = value; }
        }

        private string pPhone = string.Empty;
        public string Phone
        {
            get { return pPhone; }
            set { pPhone = value; }
        }


        private DateTime pSALES_AND_RETURN_MAIN_date = DateTime.Now;
            public DateTime SALES_AND_RETURN_MAIN_date
            {
                  get { return pSALES_AND_RETURN_MAIN_date; }
                  set { pSALES_AND_RETURN_MAIN_date = value; }
            }


            private string pSALES_AND_RETURN_MAIN_reference = string.Empty;
            public string SALES_AND_RETURN_MAIN_reference
            {
                  get { return pSALES_AND_RETURN_MAIN_reference; }
                  set { pSALES_AND_RETURN_MAIN_reference = value; }
            }


            private string pSALES_AND_RETURN_MAIN_narration = string.Empty;
            public string SALES_AND_RETURN_MAIN_narration
            {
                  get { return pSALES_AND_RETURN_MAIN_narration; }
                  set { pSALES_AND_RETURN_MAIN_narration = value; }
            }



            private String pSALES_AND_RETURN_DETAILS_mainID;

            public String SALES_AND_RETURN_DETAILS_mainID
            {
                  get { return pSALES_AND_RETURN_DETAILS_mainID; }
                  set { pSALES_AND_RETURN_DETAILS_mainID = value; }
            }
            private int pSALES_AND_RETURN_DETAILS_orderingID;

            public int SALES_AND_RETURN_DETAILS_orderingID
            {
                  get { return pSALES_AND_RETURN_DETAILS_orderingID; }
                  set { pSALES_AND_RETURN_DETAILS_orderingID = value; }
            }


            private string pSALES_AND_RETURN_DETAILS_itemID = string.Empty;
            public string SALES_AND_RETURN_DETAILS_itemID
            {
                  get { return pSALES_AND_RETURN_DETAILS_itemID; }
                  set { pSALES_AND_RETURN_DETAILS_itemID = value; }
            }


            private decimal pSALES_AND_RETURN_DETAILS_SALESPrice = 0;
            public decimal SALES_AND_RETURN_DETAILS_SALESPrice
            {
                  get { return pSALES_AND_RETURN_DETAILS_SALESPrice; }
                  set { pSALES_AND_RETURN_DETAILS_SALESPrice = value; }
            }

            private decimal pSALES_AND_RETURN_DETAILS_costPrice = 0;
            public decimal SALES_AND_RETURN_DETAILS_costPrice
            {
                  get { return pSALES_AND_RETURN_DETAILS_costPrice; }
                  set { pSALES_AND_RETURN_DETAILS_costPrice = value; }
            }

            private decimal pSALES_AND_RETURN_DETAILS_QTY = 0;
            public decimal SALES_AND_RETURN_DETAILS_QTY
            {
                  get { return pSALES_AND_RETURN_DETAILS_QTY; }
                  set { pSALES_AND_RETURN_DETAILS_QTY = value; }
            }


            private decimal pSALES_AND_RETURN_DETAILS_total = 0;
            public decimal SALES_AND_RETURN_DETAILS_total
            {
                  get { return pSALES_AND_RETURN_DETAILS_total; }
                  set { pSALES_AND_RETURN_DETAILS_total = value; }
            }



            private decimal pSALES_AND_RETURN_MAIN_totalAmount = 0;
            public decimal SALES_AND_RETURN_MAIN_totalAmount
            {
                  get { return pSALES_AND_RETURN_MAIN_totalAmount; }
                  set { pSALES_AND_RETURN_MAIN_totalAmount = value; }
            }


            private decimal pSALES_AND_RETURN_MAIN_totalPayableAmount = 0;
            public decimal SALES_AND_RETURN_MAIN_totalPayableAmount
            {
                  get { return pSALES_AND_RETURN_MAIN_totalPayableAmount; }
                  set { pSALES_AND_RETURN_MAIN_totalPayableAmount = value; }
            }


            private decimal pSALES_AND_RETURN_MAIN_discountAmount = 0;
            public decimal SALES_AND_RETURN_MAIN_discountAmount
            {
                  get { return pSALES_AND_RETURN_MAIN_discountAmount; }
                  set { pSALES_AND_RETURN_MAIN_discountAmount = value; }
            }


            private decimal pSALES_AND_RETURN_MAIN_paidAmount = 0;
            public decimal SALES_AND_RETURN_MAIN_paidAmount
            {
                  get { return pSALES_AND_RETURN_MAIN_paidAmount; }
                  set { pSALES_AND_RETURN_MAIN_paidAmount = value; }
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



            private String pSALES_AND_RETURN_MAIN_Maker;

            public String SALES_AND_RETURN_MAIN_Maker
            {
                  get { return pSALES_AND_RETURN_MAIN_Maker; }
                  set { pSALES_AND_RETURN_MAIN_Maker = value; }
            }

        private String pNext_Milleage;

        public String Next_Milleage
        {
            get { return pNext_Milleage; }
            set { pNext_Milleage = value; }
        }

        
            private String pSALES_AND_RETURN_MAIN_Model;

            public String SALES_AND_RETURN_MAIN_Model
            {
                  get { return pSALES_AND_RETURN_MAIN_Model; }
                  set { pSALES_AND_RETURN_MAIN_Model = value; }
            }
            private String pSALES_AND_RETURN_MAIN_Mileage;

            public String SALES_AND_RETURN_MAIN_Mileage
            {
                  get { return pSALES_AND_RETURN_MAIN_Mileage; }
                  set { pSALES_AND_RETURN_MAIN_Mileage = value; }
            }
            private String pSALES_AND_RETURN_MAIN_VehicleNumber;

            public String SALES_AND_RETURN_MAIN_VehicleNumber
            {
                  get { return pSALES_AND_RETURN_MAIN_VehicleNumber; }
                  set { pSALES_AND_RETURN_MAIN_VehicleNumber = value; }
            }  

            bool insertUpdateOnlySALES(

                      SqlCommand pobj_SqlCommand,
                      DAL.DALCustome pobj_DALCustome,
                      char pProcedureStatus,
                  string pParentID,
                  out string pChildID,
                   out string pID

                  )
            {
                  pID = "";

                  pChildID = "";
                  SqlParameter[] sql_param = new SqlParameter[24];

                  sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[2] = new SqlParameter("@SALES_AND_RETURN_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[2].Value = SALES_AND_RETURN_MAIN_ID;


                  sql_param[3] = new SqlParameter("@SALES_AND_RETURN_MAIN_supplierID", SqlDbType.NVarChar);
                  sql_param[3].Value = SALES_AND_RETURN_MAIN_supplierID;

                  sql_param[4] = new SqlParameter("@SALES_AND_RETURN_MAIN_VCHID", SqlDbType.NVarChar);
                  sql_param[4].Value = pParentID;

                  sql_param[5] = new SqlParameter("@SALES_AND_RETURN_MAIN_cashOrCredit", SqlDbType.NVarChar);
                  sql_param[5].Value = SALES_AND_RETURN_MAIN_cashOrCredit;

                  sql_param[6] = new SqlParameter("@SALES_AND_RETURN_MAIN_SALESOrReturn", SqlDbType.NVarChar);
                  sql_param[6].Value = SALES_AND_RETURN_MAIN_SALESOrReturn;

                  sql_param[7] = new SqlParameter("@SALES_AND_RETURN_MAIN_date", SqlDbType.DateTime);
                  sql_param[7].Value = SALES_AND_RETURN_MAIN_date;

                  sql_param[8] = new SqlParameter("@SALES_AND_RETURN_MAIN_totalAmount", SqlDbType.Float);
                  sql_param[8].Value = SALES_AND_RETURN_MAIN_totalAmount;

                  sql_param[9] = new SqlParameter("@SALES_AND_RETURN_MAIN_totalPayableAmount", SqlDbType.Float);
                  sql_param[9].Value = SALES_AND_RETURN_MAIN_totalPayableAmount;

                  sql_param[10] = new SqlParameter("@SALES_AND_RETURN_MAIN_discountAmount", SqlDbType.Float);
                  sql_param[10].Value = SALES_AND_RETURN_MAIN_discountAmount;

                  sql_param[11] = new SqlParameter("@SALES_AND_RETURN_MAIN_paidAmount", SqlDbType.Float);
                  sql_param[11].Value = SALES_AND_RETURN_MAIN_paidAmount;

                  sql_param[12] = new SqlParameter("@SALES_AND_RETURN_MAIN_reference", SqlDbType.NVarChar);
                  sql_param[12].Value = SALES_AND_RETURN_MAIN_reference;

                  sql_param[13] = new SqlParameter("@SALES_AND_RETURN_MAIN_narration", SqlDbType.NVarChar);
                  sql_param[13].Value = SALES_AND_RETURN_MAIN_narration;
                 
                  sql_param[14] = new SqlParameter("@SALES_AND_RETURN_MAIN_Maker", SqlDbType.NVarChar);
                  sql_param[14].Value = SALES_AND_RETURN_MAIN_Maker;

                  sql_param[15] = new SqlParameter("@SALES_AND_RETURN_MAIN_Model", SqlDbType.NVarChar);
                  sql_param[15].Value = SALES_AND_RETURN_MAIN_Model;

                  sql_param[16] = new SqlParameter("@SALES_AND_RETURN_MAIN_Mileage", SqlDbType.NVarChar);
                  sql_param[16].Value = SALES_AND_RETURN_MAIN_Mileage;

                  sql_param[17] = new SqlParameter("@SALES_AND_RETURN_MAIN_VehicleNumber", SqlDbType.NVarChar);
                  sql_param[17].Value = SALES_AND_RETURN_MAIN_VehicleNumber;

                  sql_param[18] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                  sql_param[18].Value = Is_Auto_Generated;

                  sql_param[19] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
                  sql_param[19].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  sql_param[20] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                  sql_param[20].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;

            sql_param[21] = new SqlParameter("@phone", SqlDbType.NVarChar);
            sql_param[21].Value = Phone;
            sql_param[22] = new SqlParameter("@Message_Limit", SqlDbType.NVarChar);
            sql_param[22].Value = Message_Limit;
            sql_param[23] = new SqlParameter("@Next_Milleage", SqlDbType.NVarChar);
            sql_param[23].Value = Next_Milleage;

            DataSet ds = new DataSet();

                  if (pProcedureStatus == 'I')
                        ds = pobj_DALCustome.selection("sp_TBL_SALES_AND_RETURN_MAIN_insertion", sql_param, pobj_SqlCommand, false);
                  else
                        ds = pobj_DALCustome.selection("sp_TBL_SALES_AND_RETURN_MAIN_updation", sql_param, pobj_SqlCommand, false);
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
                        pID = pChildID;
                        if (pChildID != "N" && ExeState == "ok")
                        {


                              SALES_AND_RETURN_MAIN_ID = pChildID;
                              SALES_AND_RETURN_DETAILS_orderingID = 0;
                              foreach (DataRow dr in dt_Detail.Rows)
                              {


                                    sql_param = new SqlParameter[12];

                                    sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                                    sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                                    sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                                    sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                                    sql_param[2] = new SqlParameter("@SALES_AND_RETURN_DETAILS_mainID", SqlDbType.NVarChar);
                                    sql_param[2].Value = SALES_AND_RETURN_MAIN_ID;

                                    sql_param[3] = new SqlParameter("@SALES_AND_RETURN_DETAILS_orderingID", SqlDbType.Int);
                                    sql_param[3].Value = SALES_AND_RETURN_DETAILS_orderingID;


                                    sql_param[4] = new SqlParameter("@SALES_AND_RETURN_DETAILS_itemID", SqlDbType.NVarChar);
                                    sql_param[4].Value = dr[cls_CTBL_SALES_AND_RETURN_MAIN.A_SALES_AND_RETURN_DETAILS_itemCode];

                                    sql_param[5] = new SqlParameter("@SALES_AND_RETURN_DETAILS_itemUnit", SqlDbType.NVarChar);
                                    sql_param[5].Value = dr[cls_CTBL_SALES_AND_RETURN_MAIN.A_SALES_AND_RETURN_DETAILS_itemUnitCode];


                                    sql_param[6] = new SqlParameter("@SALES_AND_RETURN_DETAILS_SALESPrice", SqlDbType.Float);
                                    sql_param[6].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice];
                                    
                                    sql_param[7] = new SqlParameter("@SALES_AND_RETURN_DETAILS_costPrice", SqlDbType.Float);
                                    sql_param[7].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_costPrice]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_costPrice];
                                 
                                    sql_param[8] = new SqlParameter("@SALES_AND_RETURN_DETAILS_QTY", SqlDbType.Float);
                                    sql_param[8].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY];
                                    
                                    sql_param[9] = new SqlParameter("@SALES_AND_RETURN_DETAILS_total", SqlDbType.Float);
                                    sql_param[9].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_total]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_total];



                                    sql_param[10] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                                    sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                                    sql_param[11] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                                    sql_param[11].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;



                                    ds = pobj_DALCustome.selection("sp_TBL_SALES_AND_RETURN_DETAILS_insertion", sql_param, pobj_SqlCommand, false);

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
                                                SALES_AND_RETURN_DETAILS_orderingID++;
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


            public bool insertionUpdation(char pProcedureStatus , out string pID)
            {

                if (dt_Detail.Rows.Count < 1)
                {
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                    pID = "N";
                    return false;
                }


                  pID = "";
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

                  if (

                        !obj_cls_TBL_VCH_MAIN.insertionUpdationOnlyVCH(

                                    obj_SqlCommand,
                                    obj_DALCustome,
                                    pProcedureStatus,
                                    SALES_AND_RETURN_MAIN_VCHID,
                                    SALES_AND_RETURN_MAIN_narration,
                                    pSALES_AND_RETURN_MAIN_SALESOrReturn == "Sales" ? "SI" : "SR",
                                    SALES_AND_RETURN_MAIN_date,
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
                  
                  SALES_AND_RETURN_MAIN_VCHID = ParentID;


                  if (
                        !insertUpdateOnlySALES(

                                                      obj_SqlCommand,
                                                      obj_DALCustome,
                                                      pProcedureStatus,
                                                      ParentID,
                                                      out ChildID,
                                                      out pID
                                                )
                     )
                        return false;
                 
                  SALES_AND_RETURN_DETAILS_mainID = ChildID;

                  BLL.IMS_BLL.TBL_STOCKS.cls_TBL_STOCKS obj_cls_TBL_STOCKS = new TBL_STOCKS.cls_TBL_STOCKS();

                  obj_cls_TBL_STOCKS.STOCK_stockAddRemoveStatus = add;

                  if (
                        !obj_cls_TBL_STOCKS.InsertUpdateOnlyStockSales(

                          obj_SqlCommand,
                          obj_DALCustome,
                          dt_Detail,
                          SALES_AND_RETURN_DETAILS_mainID,//pSTOCK_transactionID        ,
                          SALES_AND_RETURN_MAIN_VCHID,//pSTOCK_VCHID                     ,
                          SALES_AND_RETURN_MAIN_SALESOrReturn,//pSTOCK_transactionParentType     ,
                          SALES_AND_RETURN_MAIN_cashOrCredit,//pSTOCK_transactionChildType,
                          SALES_AND_RETURN_MAIN_date,
                          pProcedureStatus == 'I' ? -1 : STOCK_maxID,////STOCK_date                      ,
                          "",
                          SALES_AND_RETURN_MAIN_narration
                          //pSTOCK_stockLocationID

                      ))
                   return false;






                  string Log_description = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogDescription : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogDescription;
                  string Log_event = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogEvent : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogEvent;

                  if (obj_cls_TBL_LOG.insertion(SALES_AND_RETURN_DETAILS_mainID, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
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

                  sql_param[3] = new SqlParameter("@SALES_AND_RETURN_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = SALES_AND_RETURN_MAIN_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_SALES_AND_RETURN_MAIN_deletion", sql_param, obj_SqlCommand, true);

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

                  sql_param[3] = new SqlParameter("@SALES_AND_RETURN_MAIN_cashOrCredit", SqlDbType.NVarChar);
                  sql_param[3].Value = SALES_AND_RETURN_MAIN_cashOrCredit;

                  sql_param[4] = new SqlParameter("@SALES_AND_RETURN_MAIN_SALESOrReturn", SqlDbType.NVarChar);
                  sql_param[4].Value = SALES_AND_RETURN_MAIN_SALESOrReturn;

                  sql_param[5] = new SqlParameter("@SALES_AND_RETURN_MAIN_ID", SqlDbType.NVarChar);
                  sql_param[5].Value = SALES_AND_RETURN_MAIN_ID;

                  sql_param[6] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[6].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_SALES_AND_RETURN_MAIN_selection", sql_param, obj_SqlCommand, true);

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
