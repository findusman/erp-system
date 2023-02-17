using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE
{

      public class cls_TBL_RIGHTS_TEMPLATE
      {



            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
            public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
            BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


           
            public DataTable dt_Detail = new System.Data.DataTable();


            public cls_TBL_RIGHTS_TEMPLATE()
            {
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_parentKey, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_primaryKey, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_name, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_level, typeof(System.Int32));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_nature, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_defaultValue, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_valueType, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_valueFormat, typeof(System.String));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_isAddedDirectly, typeof(System.Boolean));
                  dt_Detail.Columns.Add(cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_visibleTypeOrValueType, typeof(System.String));



            }

            string ExeState = "";

            private bool pIs_BulkInsertion;
            public bool Is_BulkInsertion
            {
                  get { return pIs_BulkInsertion; }
                  set { pIs_BulkInsertion = value; }
            }

             private string pSTATUS;
            public String STATUS
            {
                  get { return pSTATUS; }
                  set { pSTATUS = value; }
            }



            private string pRIGHTS_TEMPLATE_ID = string.Empty;

            public string RIGHTS_TEMPLATE_ID
            {
                  get { return pRIGHTS_TEMPLATE_ID; }
                  set { pRIGHTS_TEMPLATE_ID = value; }
            }




            private string pRIGHTS_TEMPLATE_parentKey = string.Empty;
            public string RIGHTS_TEMPLATE_parentKey
            {
                  get { return pRIGHTS_TEMPLATE_parentKey; }
                  set { pRIGHTS_TEMPLATE_parentKey = value; }
            }


            private string pRIGHTS_TEMPLATE_primaryKey = string.Empty;
            public string RIGHTS_TEMPLATE_primaryKey
            {
                  get { return pRIGHTS_TEMPLATE_primaryKey; }
                  set { pRIGHTS_TEMPLATE_primaryKey = value; }
            }


            private string pRIGHTS_TEMPLATE_name = string.Empty;
            public string RIGHTS_TEMPLATE_name
            {
                  get { return pRIGHTS_TEMPLATE_name; }
                  set { pRIGHTS_TEMPLATE_name = value; }
            }


            private int pRIGHTS_TEMPLATE_level = 0;
            public int RIGHTS_TEMPLATE_level
            {
                  get { return pRIGHTS_TEMPLATE_level; }
                  set { pRIGHTS_TEMPLATE_level = value; }
            }


            private string pRIGHTS_TEMPLATE_nature = string.Empty;
            public string RIGHTS_TEMPLATE_nature
            {
                  get { return pRIGHTS_TEMPLATE_nature; }
                  set { pRIGHTS_TEMPLATE_nature = value; }
            }


            private string pRIGHTS_TEMPLATE_defaultValue = string.Empty;
            public string RIGHTS_TEMPLATE_defaultValue
            {
                  get { return pRIGHTS_TEMPLATE_defaultValue; }
                  set { pRIGHTS_TEMPLATE_defaultValue = value; }
            }


            private string pRIGHTS_TEMPLATE_valueType = string.Empty;
            public string RIGHTS_TEMPLATE_valueType
            {
                  get { return pRIGHTS_TEMPLATE_valueType; }
                  set { pRIGHTS_TEMPLATE_valueType = value; }
            }


            private string pRIGHTS_TEMPLATE_valueFormat = string.Empty;
            public string RIGHTS_TEMPLATE_valueFormat
            {
                  get { return pRIGHTS_TEMPLATE_valueFormat; }
                  set { pRIGHTS_TEMPLATE_valueFormat = value; }
            }


            private bool pRIGHTS_TEMPLATE_isAddedDirectly = true;
            public bool RIGHTS_TEMPLATE_isAddedDirectly
            {
                  get { return pRIGHTS_TEMPLATE_isAddedDirectly; }
                  set { pRIGHTS_TEMPLATE_isAddedDirectly = value; }
            }


            private string pRIGHTS_TEMPLATE_visibleTypeOrValueType = string.Empty;
            public string RIGHTS_TEMPLATE_visibleTypeOrValueType
            {
                  get { return pRIGHTS_TEMPLATE_visibleTypeOrValueType; }
                  set { pRIGHTS_TEMPLATE_visibleTypeOrValueType = value; }
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

            public bool loadTemplateToRightsTables(char pProcedureStatus)
            {
                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  string Status = obj_DALCustome.open_connection();

                  string rightMainID = "";
                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                        SqlParameter[] sql_param = new SqlParameter[1];


                        sql_param[0] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                        sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;

                        DataSet ds = new DataSet();

                        ds = obj_DALCustome.selection("sp_LoadRightsTemplateToRightsTableForAdminIT_selectionInto", sql_param, obj_SqlCommand, true);


                        //if (pProcedureStatus == 'I')
                        //      ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_insertion", sql_param, obj_SqlCommand, true);
                        //else
                        //      ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_updation", sql_param, obj_SqlCommand, true);

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
                              rightMainID = ds.Tables[0].Rows[0][1].ToString();
                              if (rightMainID != "N" && ExeState == "ok")
                              {

                              }
                              else {
                                    obj_DALCustome.transactioRollBack();
                                    obj_DALCustome.closeconnection();
                                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                                    return false;

                              }


                        }

                        BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS obj_cls_TBL_USERS = new TBL_USERS.cls_TBL_USERS();

                         ds = obj_cls_TBL_USERS.insertionUpdationGlobal(
                               obj_DALCustome,
                               obj_SqlCommand,
                               "1",
                               rightMainID, // right will be here
                               "IT Admin",
                               "Admin",//USERS_loginID,
                               "Admin",//USERS_password,
                               "This User is Auto generated for IT Admin",
                               true,
                               false,
                               false,

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
                              string id = ds.Tables[0].Rows[0][1].ToString();



                              if (id != "N" && ExeState == "ok")
                              { }
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



                  string Log_description = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogDescription : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogDescription;
                  string Log_event = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogEvent : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogEvent;

                  if (obj_cls_TBL_LOG.insertion(rightMainID, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
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

          


            public bool insertionUpdation(char pProcedureStatus )
            {
                  DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

                  SqlCommand obj_SqlCommand = new SqlCommand();

                  string Status = obj_DALCustome.open_connection();




                  string Id = "";
                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  foreach (DataRow dr in dt_Detail.Rows)
                  {
                        SqlParameter[] sql_param = new SqlParameter[17];

                        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                        sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                        sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                        sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                        sql_param[2] = new SqlParameter("@RIGHTS_TEMPLATE_ID ", SqlDbType.NVarChar);
                        sql_param[2].Value = "";


                        sql_param[3] = new SqlParameter("@RIGHTS_TEMPLATE_parentKey", SqlDbType.NVarChar);
                        sql_param[3].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_parentKey];

                        sql_param[4] = new SqlParameter("@RIGHTS_TEMPLATE_primaryKey", SqlDbType.NVarChar);
                        sql_param[4].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_primaryKey];

                        sql_param[5] = new SqlParameter("@RIGHTS_TEMPLATE_name", SqlDbType.NVarChar);
                        sql_param[5].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_name];

                        sql_param[6] = new SqlParameter("@RIGHTS_TEMPLATE_level", SqlDbType.Int);
                        sql_param[6].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_level];

                        sql_param[7] = new SqlParameter("@RIGHTS_TEMPLATE_nature", SqlDbType.NVarChar);
                        sql_param[7].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_nature];

                        sql_param[8] = new SqlParameter("@RIGHTS_TEMPLATE_defaultValue", SqlDbType.NVarChar);
                        sql_param[8].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_defaultValue];

                        sql_param[9] = new SqlParameter("@RIGHTS_TEMPLATE_valueType", SqlDbType.NVarChar);
                        sql_param[9].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_valueType];

                        sql_param[10] = new SqlParameter("@RIGHTS_TEMPLATE_valueFormat", SqlDbType.NVarChar);
                        sql_param[10].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_valueFormat];

                        sql_param[11] = new SqlParameter("@RIGHTS_TEMPLATE_isAddedDirectly", SqlDbType.Bit);
                        sql_param[11].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_isAddedDirectly];

                        sql_param[12] = new SqlParameter("@RIGHTS_TEMPLATE_visibleTypeOrValueType", SqlDbType.NVarChar);
                        sql_param[12].Value = dr[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_visibleTypeOrValueType];

                        sql_param[13] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
                        sql_param[13].Value = Is_Auto_Generated;

                        sql_param[14] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
                        sql_param[14].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                        sql_param[15] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                        sql_param[15].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;

                        sql_param[16] = new SqlParameter("@Is_BulkInsertion", SqlDbType.NVarChar);
                        sql_param[16].Value = pIs_BulkInsertion;
                        

                        
                        DataSet ds = new DataSet();

                        ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_insertion", sql_param, obj_SqlCommand, true);
                        


                        //if (pProcedureStatus == 'I')
                        //      ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_insertion", sql_param, obj_SqlCommand, true);
                        //else
                        //      ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_updation", sql_param, obj_SqlCommand, true);
                       
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
                              Id = ds.Tables[0].Rows[0][1].ToString();
                              if (Id != "N" && ExeState == "ok")
                              {
                                    pIs_BulkInsertion = false;
                                    continue;
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

                  sql_param[3] = new SqlParameter("@RIGHTS_TEMPLATE_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = RIGHTS_TEMPLATE_ID;


                  string Status = obj_DALCustome.open_connection();

                  if (Status != "ok")
                  {
                        obj_DALCustome.transactioRollBack();
                        obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                        return false;
                  }

                  DataSet ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_deletion", sql_param, obj_SqlCommand, true);

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

                  sql_param[3] = new SqlParameter("@RIGHTS_TEMPLATE_ID ", SqlDbType.NVarChar);
                  sql_param[3].Value = RIGHTS_TEMPLATE_ID;

                  sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                  sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                  DataSet ds = obj_DALCustome.selection("sp_TBL_RIGHTS_TEMPLATE_selection", sql_param, obj_SqlCommand, true);

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
