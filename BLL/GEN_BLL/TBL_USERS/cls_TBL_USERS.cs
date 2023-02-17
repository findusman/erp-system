using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_USERS
{

      public class cls_TBL_USERS
      {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
            public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
            BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            string ExeState = "";

            private string pSTATUS;
            public String STATUS
            {
                  get { return pSTATUS; }
                  set { pSTATUS = value; }
            }



            private string pUSERS_ID = string.Empty;

            public string USERS_ID
            {
                  get { return pUSERS_ID; }
                  set { pUSERS_ID = value; }
            }




            private string pUSERS_rightID = string.Empty;
            public string USERS_rightID
            {
                  get { return pUSERS_rightID; }
                  set { pUSERS_rightID = value; }
            }


            private string pUSERS_name = string.Empty;
            public string USERS_name
            {
                  get { return pUSERS_name; }
                  set { pUSERS_name = value; }
            }


            private string pUSERS_loginID = string.Empty;
            public string USERS_loginID
            {
                  get { return pUSERS_loginID; }
                  set { pUSERS_loginID = value; }
            }


            private string pUSERS_password = string.Empty;
            public string USERS_password
            {
                  get { return pUSERS_password; }
                  set { pUSERS_password = value; }
            }


            private string pUSERS_narration = string.Empty;
            public string USERS_narration
            {
                  get { return pUSERS_narration; }
                  set { pUSERS_narration = value; }
            }


            private bool pUSERS_isActive = true;
            public bool USERS_isActive
            {
                  get { return pUSERS_isActive; }
                  set { pUSERS_isActive = value; }
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

            public DataSet insertionUpdationGlobal(
                  DAL.DALCustome pobj_DALCustome,
                  SqlCommand pobj_SqlCommand,

                  string pUSERS_ID,
                  string pUSERS_rightID,
                  string pUSERS_name,
                  string pUSERS_loginID,
                  string pUSERS_password,
                  string pUSERS_narration,
                  bool pUSERS_isActive,
                  bool pIs_Auto_Generated,
                  bool pIsParent,



                  char ppProcedureStatus)
            {

                  SqlParameter[] sql_param = new SqlParameter[12];

                  sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                  sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                  sql_param[2] = new SqlParameter("@USERS_ID ", SqlDbType.NVarChar);
                  sql_param[2].Value = pUSERS_ID;


                  sql_param[3] = new SqlParameter("@USERS_rightID", SqlDbType.NVarChar);
                  sql_param[3].Value = pUSERS_rightID;

                  sql_param[4] = new SqlParameter("@USERS_name", SqlDbType.NVarChar);
                  sql_param[4].Value = pUSERS_name;

                  sql_param[5] = new SqlParameter("@USERS_loginID", SqlDbType.NVarChar);
                  sql_param[5].Value = pUSERS_loginID;

                  sql_param[6] = new SqlParameter("@USERS_password", SqlDbType.NVarChar);
                  sql_param[6].Value = pUSERS_password;

                  sql_param[7] = new SqlParameter("@USERS_narration", SqlDbType.NVarChar);
                  sql_param[7].Value = pUSERS_narration;

                  sql_param[8] = new SqlParameter("@USERS_isActive", SqlDbType.Bit);
                  sql_param[8].Value = pUSERS_isActive;

                  sql_param[9] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                  sql_param[9].Value = pIs_Auto_Generated;

                  sql_param[10] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
                  sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  sql_param[11] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                  sql_param[11].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                  DataSet ds = new DataSet();


                  if (ppProcedureStatus == 'I')
                        ds = pobj_DALCustome.selection("sp_TBL_USERS_insertion", sql_param, pobj_SqlCommand, pIsParent);
                  else
                        ds = pobj_DALCustome.selection("sp_TBL_USERS_updation", sql_param, pobj_SqlCommand, pIsParent);



                  return ds;

            }

            public DataRow login()
            {
                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  DataRow dr = null;
                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return null;
                  }

                  SqlParameter[] sql_param = new SqlParameter[2];

                  sql_param[0] = new SqlParameter("@USERS_loginID", SqlDbType.NVarChar);
                  sql_param[0].Value = USERS_loginID;

                  sql_param[1] = new SqlParameter("@USERS_password", SqlDbType.NVarChar);
                  sql_param[1].Value = USERS_password;


                  DataSet ds = obj_DALCustome.selection("sp_login_selection", sql_param, obj_SqlCommand, true);



                  if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                  {

                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("Login_E");

                        return null;
                  }
                  else
                  {
                        dr = ds.Tables[0].Rows[0];

                     
                        if (obj_cls_TBL_LOG.insertion(USERS_loginID, "Tag", obj_XtraForm.Text.ToString(), "You logged In", "Login", obj_SqlCommand, obj_DALCustome, false))
                        {

                              obj_DALCustome.transactioCommit();
                              obj_DALCustome.closeconnection();
                              return dr;
                        }
                        else
                        {
                              obj_DALCustome.transactioRollBack();
                              obj_DALCustome.closeconnection();
                              obj_cls_MessageBox.MessageBoxStatic("Login_E");
                              return null;

                        }



                  }



                  return null;

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


                  DataSet ds = insertionUpdationGlobal(
                         obj_DALCustome,
                         obj_SqlCommand,

                         pUSERS_ID,
                         USERS_rightID,
                         USERS_name,
                         USERS_loginID,
                         USERS_password,
                         USERS_narration,
                         USERS_isActive,
                         Is_Auto_Generated,
                         true,

                   pProcedureStatus
                         );





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

                  sql_param[3] = new SqlParameter("@USERS_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = USERS_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_USERS_deletion", sql_param, obj_SqlCommand, true);

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

                  sql_param[3] = new SqlParameter("@USERS_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = USERS_ID;

                  sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_USERS_selection", sql_param, obj_SqlCommand, true);

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
