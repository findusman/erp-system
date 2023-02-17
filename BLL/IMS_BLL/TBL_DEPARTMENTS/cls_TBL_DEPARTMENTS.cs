using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;





namespace BLL.IMS_BLL.TBL_DEPARTMENTS
{

    public class cls_TBL_DEPARTMENTS
    {
        DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
        public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
        BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        BLL.ACC_BLL.cls_GetCode_Againt_Key obj_getCode_Against_key = new ACC_BLL.cls_GetCode_Againt_Key();
        DataSet dsCOA = new System.Data.DataSet();
        string ExeState = "";

        private string pSTATUS;
        public String STATUS
        {
            get { return pSTATUS; }
            set { pSTATUS = value; }
        }



        private string pDEPARTMENT_ID = string.Empty;

        public string DEPARTMENT_ID
        {
            get { return pDEPARTMENT_ID; }
            set { pDEPARTMENT_ID = value; }
        }



        private int pDEPARTMENT_stockLevel;

        public int DEPARTMENT_stockLevel
        {
              get { return pDEPARTMENT_stockLevel; }
              set { pDEPARTMENT_stockLevel = value; }
        }
        private bool pDEPARTMENT_stockInLtr;

        public bool DEPARTMENT_stockInLtr
        {
              get { return pDEPARTMENT_stockInLtr; }
              set { pDEPARTMENT_stockInLtr = value; }
        }  


        private string pDEPARTMENT_name = string.Empty;
        public string DEPARTMENT_name
        {
            get { return pDEPARTMENT_name; }
            set { pDEPARTMENT_name = value; }
        }


        private string pDEPARTMENT_narration = string.Empty;
        public string DEPARTMENT_narration
        {
            get { return pDEPARTMENT_narration; }
            set { pDEPARTMENT_narration = value; }
        }

        private String pDEPARTMENT_COA;

        public String DEPARTMENT_COA
        {
            get { return pDEPARTMENT_COA; }
            set { pDEPARTMENT_COA = value; }
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


        private bool pDEPARTMENT_isParent;

        public bool DEPARTMENT_isParent
        {
              get { return pDEPARTMENT_isParent; }
              set { pDEPARTMENT_isParent = value; }
        }

        private String pDEPARTMENT_parentID;

        public String DEPARTMENT_parentID
        {
              get { return pDEPARTMENT_parentID; }
              set { pDEPARTMENT_parentID = value; }
        }  


        public bool insertionUpdation(char pProcedureStatus)
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            if (pProcedureStatus == 'I')
            {
                //coa insertion
                BLL.ACC_BLL.cls_TBL_COA obj = new BLL.ACC_BLL.cls_TBL_COA();
                dsCOA = obj.insertionDirect(1, GEN.GEN_GEN.GenericClasses.cls_KeysWithValue.Parent_Of_Departments, "", 0, DEPARTMENT_name, 0, "", false, "Insertion", "Child", false, true);

                if (dsCOA == null)
                {
                    obj_DALCustome.transactioRollBack();
                    obj_DALCustome.closeconnection();
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                    return false;
                }

                DEPARTMENT_COA = dsCOA.Tables[0].Rows[0][1].ToString();
            }

            SqlParameter[] sql_param = new SqlParameter[13];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@DEPARTMENT_ID", SqlDbType.NVarChar);
            sql_param[2].Value = DEPARTMENT_ID;

            sql_param[3] = new SqlParameter("@DEPARTMENT_parentID", SqlDbType.NVarChar);
            sql_param[3].Value = DEPARTMENT_parentID;

            sql_param[4] = new SqlParameter("@DEPARTMENT_COA", SqlDbType.NVarChar);
            sql_param[4].Value = DEPARTMENT_COA;

            sql_param[5] = new SqlParameter("@DEPARTMENT_isParent", SqlDbType.Bit);
            sql_param[5].Value = DEPARTMENT_isParent;

            sql_param[6] = new SqlParameter("@DEPARTMENT_name", SqlDbType.NVarChar);
            sql_param[6].Value = DEPARTMENT_name;

            sql_param[7] = new SqlParameter("@DEPARTMENT_narration", SqlDbType.NVarChar);
            sql_param[7].Value = DEPARTMENT_narration;

            sql_param[8] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[8].Value = Is_Auto_Generated;

            sql_param[9] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[9].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[10] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;

            sql_param[11] = new SqlParameter("@DEPARTMENT_stockLevel", SqlDbType.Int);
            sql_param[11].Value = DEPARTMENT_stockLevel;

            sql_param[12] = new SqlParameter("@DEPARTMENT_stockInLtr", SqlDbType.Bit);
            sql_param[12].Value = DEPARTMENT_stockInLtr;


            DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            if (pProcedureStatus == 'I')
                ds = obj_DALCustome.selection("sp_TBL_DEPARTMENTS_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_DEPARTMENTS_updation", sql_param, obj_SqlCommand, true);
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

            sql_param[3] = new SqlParameter("@DEPARTMENT_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = DEPARTMENT_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_DEPARTMENTS_deletion", sql_param, obj_SqlCommand, true);

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

            sql_param[3] = new SqlParameter("@DEPARTMENT_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = DEPARTMENT_ID;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_DEPARTMENTS_selection", sql_param, obj_SqlCommand, true);

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
