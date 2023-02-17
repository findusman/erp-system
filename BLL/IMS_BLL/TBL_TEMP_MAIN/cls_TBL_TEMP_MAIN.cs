using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_TEMP_MAIN
{

      public class cls_TBL_TEMP_MAIN
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



            private string pTEMP_MAIN_ID = string.Empty;

            public string TEMP_MAIN_ID
            {
                  get { return pTEMP_MAIN_ID; }
                  set { pTEMP_MAIN_ID = value; }
            }




            private string pTEMP_MAIN_name = string.Empty;
            public string TEMP_MAIN_name
            {
                  get { return pTEMP_MAIN_name; }
                  set { pTEMP_MAIN_name = value; }
            }



            private String pTEMP_DET_mainID;

            public String TEMP_DET_mainID
            {
                  get { return pTEMP_DET_mainID; }
                  set { pTEMP_DET_mainID = value; }
            }
            private int pTEMP_DET_orderingID;

            public int TEMP_DET_orderingID
            {
                  get { return pTEMP_DET_orderingID; }
                  set { pTEMP_DET_orderingID = value; }
            }


            private DateTime pTEMP_DET_date = DateTime.Now;
            public DateTime TEMP_DET_date
            {
                  get { return pTEMP_DET_date; }
                  set { pTEMP_DET_date = value; }
            }


            private decimal pTEMP_DET_float = 0;
            public decimal TEMP_DET_float
            {
                  get { return pTEMP_DET_float; }
                  set { pTEMP_DET_float = value; }
            }


            private int pTEMP_DET_Int = 0;
            public int TEMP_DET_Int
            {
                  get { return pTEMP_DET_Int; }
                  set { pTEMP_DET_Int = value; }
            }


            private bool pTEMP_DET_Bool = true;
            public bool TEMP_DET_Bool
            {
                  get { return pTEMP_DET_Bool; }
                  set { pTEMP_DET_Bool = value; }
            }


            private string pTEMP_DET_String = string.Empty;
            public string TEMP_DET_String
            {
                  get { return pTEMP_DET_String; }
                  set { pTEMP_DET_String = value; }
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

                  SqlParameter[] sql_param = new SqlParameter[7];

                  sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[2] = new SqlParameter("@TEMP_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[2].Value = TEMP_MAIN_ID;


                  sql_param[3] = new SqlParameter("@TEMP_MAIN_name", SqlDbType.NVarChar);
                  sql_param[3].Value = TEMP_MAIN_name;

                  sql_param[4] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                  sql_param[4].Value = Is_Auto_Generated;

                  sql_param[5] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
                  sql_param[5].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  sql_param[6] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                  sql_param[6].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                  DataSet ds = new DataSet();


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  if (pProcedureStatus == 'I')
                        ds = obj_DALCustome.selection("sp_TBL_TEMP_MAIN_insertion", sql_param, obj_SqlCommand, true);
                  else
                        ds = obj_DALCustome.selection("sp_TBL_TEMP_MAIN_updation", sql_param, obj_SqlCommand, true);
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

                        if (Id != "N" && ExeState == "ok")
                        {


                              TEMP_MAIN_ID = Id;
                              TEMP_DET_orderingID = 0;
                              foreach (DataRow dr in dt_Detail.Rows)
                              {


                                    sql_param = new SqlParameter[11];

                                    sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                                    sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                                    sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                                    sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                                    sql_param[2] = new SqlParameter("@TEMP_DET_mainID", SqlDbType.NVarChar);
                                    sql_param[2].Value = TEMP_MAIN_ID;

                                    sql_param[3] = new SqlParameter("@TEMP_DET_orderingID", SqlDbType.Int);
                                    sql_param[3].Value = TEMP_DET_orderingID;


                                    sql_param[4] = new SqlParameter("@TEMP_DET_date", SqlDbType.Date);
                                    sql_param[4].Value = dr[cls_CTBL_TEMP_MAIN.TEMP_DET_date];
                                    sql_param[5] = new SqlParameter("@TEMP_DET_float", SqlDbType.Float);
                                    sql_param[5].Value = dr[cls_CTBL_TEMP_MAIN.TEMP_DET_float];
                                    sql_param[6] = new SqlParameter("@TEMP_DET_Int", SqlDbType.Int);
                                    sql_param[6].Value = dr[cls_CTBL_TEMP_MAIN.TEMP_DET_Int];
                                    sql_param[7] = new SqlParameter("@TEMP_DET_Bool", SqlDbType.Bit);
                                    sql_param[7].Value = dr[cls_CTBL_TEMP_MAIN.TEMP_DET_Bool];
                                    sql_param[8] = new SqlParameter("@TEMP_DET_String", SqlDbType.NVarChar);
                                    sql_param[8].Value = dr[cls_CTBL_TEMP_MAIN.TEMP_DET_String];

                                    sql_param[9] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                                    sql_param[9].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                                    sql_param[10] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                                    sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                                    ds = obj_DALCustome.selection("sp_TBL_TEMP_DET_insertion", sql_param, obj_SqlCommand, true);

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

                                          if (Id != "N" && ExeState == "ok")
                                          {
                                                TEMP_DET_orderingID++;
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

                              if (obj_cls_TBL_LOG.insertion(Id, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
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
                        }
                        else
                        {
                              obj_DALCustome.transactioCommit();
                              obj_DALCustome.closeconnection();
                              if (pProcedureStatus == 'I')
                                    obj_cls_MessageBox.MessageBoxDynamics(ExeState, "I_E");
                              else
                                    obj_cls_MessageBox.MessageBoxDynamics(ExeState, "U_E");
                              return false;

                        }


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

                  sql_param[3] = new SqlParameter("@TEMP_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = TEMP_MAIN_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_TEMP_MAIN_deletion", sql_param, obj_SqlCommand, true);

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

                  sql_param[3] = new SqlParameter("@TEMP_MAIN_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = TEMP_MAIN_ID;

                  sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_TEMP_MAIN_selection", sql_param, obj_SqlCommand, true);

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
