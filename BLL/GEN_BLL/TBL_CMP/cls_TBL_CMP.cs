using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_CMP
{

      public class cls_TBL_CMP
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



            private string pCMP_ID = string.Empty;

            public string CMP_ID
            {
                  get { return pCMP_ID; }
                  set { pCMP_ID = value; }
            }




            private string pCMP_name = string.Empty;
            public string CMP_name
            {
                  get { return pCMP_name; }
                  set { pCMP_name = value; }
            }


            private string pCMP_address = string.Empty;
            public string CMP_address
            {
                  get { return pCMP_address; }
                  set { pCMP_address = value; }
            }


            private string pCMP_adminUserID = string.Empty;
            public string CMP_adminUserID
            {
                  get { return pCMP_adminUserID; }
                  set { pCMP_adminUserID = value; }
            }


            private string pCMP_phoneNumber = string.Empty;
            public string CMP_phoneNumber
            {
                  get { return pCMP_phoneNumber; }
                  set { pCMP_phoneNumber = value; }
            }


            private int pCMP_numberOfBranches = 0;
            public int CMP_numberOfBranches
            {
                  get { return pCMP_numberOfBranches; }
                  set { pCMP_numberOfBranches = value; }
            }


            private string pCMP_narration = string.Empty;
            public string CMP_narration
            {
                  get { return pCMP_narration; }
                  set { pCMP_narration = value; }
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

            private string pUSERS_ID = string.Empty;

            public string USERS_ID
            {
                  get { return pUSERS_ID; }
                  set { pUSERS_ID = value; }
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

                  BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS obj_cls_TBL_USERS = new TBL_USERS.cls_TBL_USERS();

                  DataSet ds = obj_cls_TBL_USERS.insertionUpdationGlobal(
                         obj_DALCustome,
                         obj_SqlCommand,
                         USERS_ID,
                         "", // right will be here
                         CMP_name,
                         USERS_loginID,
                         USERS_password,
                         CMP_narration,
                         true,
                         true,
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
                        CMP_adminUserID = ds.Tables[0].Rows[0][1].ToString();



                        if (CMP_adminUserID != "N" && ExeState == "ok")
                        {  }
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




                  SqlParameter[] sql_param = new SqlParameter[10];




                  sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[0].Value = CMP_ID;

                  sql_param[1] = new SqlParameter("@CMP_name", SqlDbType.NVarChar);
                  sql_param[1].Value = CMP_name;

                  sql_param[2] = new SqlParameter("@CMP_address", SqlDbType.NVarChar);
                  sql_param[2].Value = CMP_address;

                  sql_param[3] = new SqlParameter("@CMP_adminUserID", SqlDbType.NVarChar);
                  sql_param[3].Value = CMP_adminUserID;

                  sql_param[4] = new SqlParameter("@CMP_phoneNumber", SqlDbType.NVarChar);
                  sql_param[4].Value = CMP_phoneNumber;

                  sql_param[5] = new SqlParameter("@CMP_numberOfBranches", SqlDbType.Int);
                  sql_param[5].Value = CMP_numberOfBranches;

                  sql_param[6] = new SqlParameter("@CMP_narration", SqlDbType.NVarChar);
                  sql_param[6].Value = CMP_narration;

                  sql_param[7] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                  sql_param[7].Value = Is_Auto_Generated;

                  sql_param[8] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[8].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  sql_param[9] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                  sql_param[9].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;







                  if (pProcedureStatus == 'I')
                        ds = obj_DALCustome.selection("sp_TBL_CMP_insertion", sql_param, obj_SqlCommand, true);
                  else
                        ds = obj_DALCustome.selection("sp_TBL_CMP_updation", sql_param, obj_SqlCommand, true);
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

                  SqlParameter[] sql_param = new SqlParameter[2];

                  sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
                  sql_param[0].Value = STATUS;

                  sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = CMP_ID;




                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_CMP_deletion", sql_param, obj_SqlCommand, true);

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

                  SqlParameter[] sql_param = new SqlParameter[3];

                  sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
                  sql_param[0].Value = STATUS;

                  sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                  sql_param[1].Value = CMP_ID;

                  sql_param[2] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_CMP_selection", sql_param, obj_SqlCommand, true);

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
