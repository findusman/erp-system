using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.ACC_BLL.TBL_OPENING_BALANCE
{

      public class cls_TBL_OPENING_BALANCE
      {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
            public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
            BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            public DataTable dt_Detail = new System.Data.DataTable();

            string ExeState = "";

            private string pSTATUS;
            public String STATUS
            {
                  get { return pSTATUS; }
                  set { pSTATUS = value; }
            }



            private string pFINANCIAL_YEAR_ID = string.Empty;

            public string FINANCIAL_YEAR_ID
            {
                  get { return pFINANCIAL_YEAR_ID; }
                  set { pFINANCIAL_YEAR_ID = value; }
            }




            private string pFINANCIAL_YEAR_name = string.Empty;
            public string FINANCIAL_YEAR_name
            {
                  get { return pFINANCIAL_YEAR_name; }
                  set { pFINANCIAL_YEAR_name = value; }
            }


            private DateTime pFINANCIAL_YEAR_fromDate = DateTime.Now;
            public DateTime FINANCIAL_YEAR_fromDate
            {
                  get { return pFINANCIAL_YEAR_fromDate; }
                  set { pFINANCIAL_YEAR_fromDate = value; }
            }


            private DateTime pFINANCIAL_YEAR_fromTo = DateTime.Now;
            public DateTime FINANCIAL_YEAR_fromTo
            {
                  get { return pFINANCIAL_YEAR_fromTo; }
                  set { pFINANCIAL_YEAR_fromTo = value; }
            }


            private string pFINANCIAL_YEAR_lastFinancialYear = string.Empty;
            public string FINANCIAL_YEAR_lastFinancialYear
            {
                  get { return pFINANCIAL_YEAR_lastFinancialYear; }
                  set { pFINANCIAL_YEAR_lastFinancialYear = value; }
            }


            private string pFINANCIAL_YEAR_narration = string.Empty;
            public string FINANCIAL_YEAR_narration
            {
                  get { return pFINANCIAL_YEAR_narration; }
                  set { pFINANCIAL_YEAR_narration = value; }
            }



            private String pOPENING_BALANCE_mainID;

            public String OPENING_BALANCE_mainID
            {
                  get { return pOPENING_BALANCE_mainID; }
                  set { pOPENING_BALANCE_mainID = value; }
            }
            private int pOPENING_BALANCE_orderingID;

            public int OPENING_BALANCE_orderingID
            {
                  get { return pOPENING_BALANCE_orderingID; }
                  set { pOPENING_BALANCE_orderingID = value; }
            }


            private decimal pOPENING_BALANCE_COA = 0;
            public decimal OPENING_BALANCE_COA
            {
                  get { return pOPENING_BALANCE_COA; }
                  set { pOPENING_BALANCE_COA = value; }
            }


            private decimal pOPENING_BALANCE_debit = 0;
            public decimal OPENING_BALANCE_debit
            {
                  get { return pOPENING_BALANCE_debit; }
                  set { pOPENING_BALANCE_debit = value; }
            }


            private decimal pOPENING_BALANCE_credit = 0;
            public decimal OPENING_BALANCE_credit
            {
                  get { return pOPENING_BALANCE_credit; }
                  set { pOPENING_BALANCE_credit = value; }
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


            public bool insertionUpdation(char pProcedureStatus)
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





                  OPENING_BALANCE_orderingID = 0;
                  foreach (DataRow dr in dt_Detail.Rows)
                  {


                        SqlParameter[] sql_param = new SqlParameter[9];

                        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                        sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                        sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                        sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                        sql_param[2] = new SqlParameter("@OPENING_BALANCE_mainID", SqlDbType.NVarChar);
                        sql_param[2].Value = FINANCIAL_YEAR_ID;

                        sql_param[3] = new SqlParameter("@OPENING_BALANCE_orderingID", SqlDbType.Int);
                        sql_param[3].Value = OPENING_BALANCE_orderingID;


                        sql_param[4] = new SqlParameter("@OPENING_BALANCE_COA", SqlDbType.NVarChar);
                        sql_param[4].Value = dr[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_COA];


                        string tmpStrDebit = Convert.ToDouble(dr[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit].ToString() == "" ? 0 : dr[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_debit]).ToString(GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.formatN3);
                        string tmpStrCredit = Convert.ToDouble(dr[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit].ToString() == "" ? 0 : dr[cls_CTBL_OPENING_BALANCE.OPENING_BALANCE_credit]).ToString(GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.formatN3);
                                  

                        sql_param[5] = new SqlParameter("@OPENING_BALANCE_debit", SqlDbType.Float);
                        sql_param[5].Value = Convert.ToDouble(tmpStrDebit);
                        sql_param[6] = new SqlParameter("@OPENING_BALANCE_credit", SqlDbType.Float);
                        sql_param[6].Value = Convert.ToDouble(tmpStrCredit);

                        sql_param[7] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                        sql_param[7].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                        sql_param[8] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                        sql_param[8].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                        DataSet ds = obj_DALCustome.selection("sp_TBL_OPENING_BALANCE_insertion", sql_param, obj_SqlCommand, true);

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

                              if (ExeState == "ok")
                              {
                                    OPENING_BALANCE_orderingID++;
                                    continue;
                              }
                              else
                              {
                                    obj_DALCustome.transactioRollBack();
                                    obj_DALCustome.closeconnection();
                                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                                    return false;

                              }

                        }

                  }





                  string Log_description = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogDescription : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogDescription;
                  string Log_event = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogEvent : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogEvent;

                  if (obj_cls_TBL_LOG.insertion(FINANCIAL_YEAR_ID, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
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

                  sql_param[3] = new SqlParameter("@FINANCIAL_YEAR_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = FINANCIAL_YEAR_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_FINANCIAL_YEAR_deletion", sql_param, obj_SqlCommand, true);

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

                  SqlParameter[] sql_param = new SqlParameter[5];

                  sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
                  sql_param[0].Value = STATUS;

                  sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[3] = new SqlParameter("@FINANCIAL_YEAR_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = FINANCIAL_YEAR_ID;

                  sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_FINANCIAL_YEAR_selection", sql_param, obj_SqlCommand, true);

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
