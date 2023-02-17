using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_PRODUCTS
{

    public class cls_TBL_PRODUCTS
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



        private string pPRODUCT_ID = string.Empty;

        public string PRODUCT_ID
        {
            get { return pPRODUCT_ID; }
            set { pPRODUCT_ID = value; }
        }



        private String pPRODUCT_COA;

        public String PRODUCT_COA
        {
            get { return pPRODUCT_COA; }
            set { pPRODUCT_COA = value; }
        }  

        private string pPRODUCT_name = string.Empty;
        public string PRODUCT_name
        {
            get { return pPRODUCT_name; }
            set { pPRODUCT_name = value; }
        }


        private string pPRODUCT_packing = string.Empty;
        public string PRODUCT_packing
        {
            get { return pPRODUCT_packing; }
            set { pPRODUCT_packing = value; }
        }


        private string pPRODUCT_defaultLevel = string.Empty;
        public string PRODUCT_defaultLevel
        {
            get { return pPRODUCT_defaultLevel; }
            set { pPRODUCT_defaultLevel = value; }
        }


        private string pPRODUCT_department = string.Empty;
        public string PRODUCT_department
        {
            get { return pPRODUCT_department; }
            set { pPRODUCT_department = value; }
        }

        private string pDEPARTMETN_COA = string.Empty;
        public string DEPARTMETN_COA
        {
              get { return pDEPARTMETN_COA; }
              set { pDEPARTMETN_COA = value; }
        }


        private decimal pPRODUCT_saleRate = 0;
        public decimal PRODUCT_saleRate
        {
            get { return pPRODUCT_saleRate; }
            set { pPRODUCT_saleRate = value; }
        }


        private decimal pPRODUCT_purchaseRate = 0;
        public decimal PRODUCT_purchaseRate
        {
            get { return pPRODUCT_purchaseRate; }
            set { pPRODUCT_purchaseRate = value; }
        }


        private string pPRODUCT_barCode = string.Empty;
        public string PRODUCT_barCode
        {
            get { return pPRODUCT_barCode; }
            set { pPRODUCT_barCode = value; }
        }


        private bool pPRODUCT_isService = true;
        public bool PRODUCT_isService
        {
            get { return pPRODUCT_isService; }
            set { pPRODUCT_isService = value; }
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
            if (pProcedureStatus == 'I')
            {

                //coa insertion
                BLL.ACC_BLL.cls_TBL_COA obj = new BLL.ACC_BLL.cls_TBL_COA();
                dsCOA = obj.insertionDirect(1, DEPARTMETN_COA, "", 0, PRODUCT_name, 0, "", true, "Insertion", "Child", true, true);

                if (dsCOA == null)
                {
                    obj_DALCustome.transactioRollBack();
                    obj_DALCustome.closeconnection();
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                    return false;
                }
                PRODUCT_COA = dsCOA.Tables[0].Rows[0][1].ToString(); 
            }
            SqlParameter[] sql_param = new SqlParameter[15];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@PRODUCT_ID", SqlDbType.NVarChar);
            sql_param[2].Value = PRODUCT_ID;

            sql_param[3] = new SqlParameter("@PRODUCT_COA", SqlDbType.NVarChar);
            sql_param[3].Value = PRODUCT_COA;

            sql_param[4] = new SqlParameter("@PRODUCT_name", SqlDbType.NVarChar);
            sql_param[4].Value = PRODUCT_name;

            sql_param[5] = new SqlParameter("@PRODUCT_packing", SqlDbType.NVarChar);
            sql_param[5].Value = PRODUCT_packing;

            sql_param[6] = new SqlParameter("@PRODUCT_defaultLevel", SqlDbType.NVarChar);
            sql_param[6].Value = PRODUCT_defaultLevel;

            sql_param[7] = new SqlParameter("@PRODUCT_department", SqlDbType.NVarChar);
            sql_param[7].Value = PRODUCT_department;

            sql_param[8] = new SqlParameter("@PRODUCT_saleRate", SqlDbType.Float);
            sql_param[8].Value = PRODUCT_saleRate;

            sql_param[9] = new SqlParameter("@PRODUCT_purchaseRate", SqlDbType.Float);
            sql_param[9].Value = PRODUCT_purchaseRate;

            sql_param[10] = new SqlParameter("@PRODUCT_barCode", SqlDbType.NVarChar);
            sql_param[10].Value = PRODUCT_barCode;

            sql_param[11] = new SqlParameter("@PRODUCT_isService", SqlDbType.Bit);
            sql_param[11].Value = PRODUCT_isService;

            sql_param[12] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[12].Value = Is_Auto_Generated;

            sql_param[13] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[13].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[14] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[14].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;



            DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            if (pProcedureStatus == 'I')
                ds = obj_DALCustome.selection("sp_TBL_PRODUCTS_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_PRODUCTS_updation", sql_param, obj_SqlCommand, true);
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

            sql_param[3] = new SqlParameter("@PRODUCT_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = PRODUCT_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_PRODUCTS_deletion", sql_param, obj_SqlCommand, true);

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

            sql_param[3] = new SqlParameter("@PRODUCT_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = PRODUCT_ID;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_PRODUCTS_selection", sql_param, obj_SqlCommand, true);

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

        public DataSet Rate_Adjustment()
        {



            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
            SqlCommand obj_SqlCommand = new SqlCommand();

            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                return null;
            }

            SqlParameter[] sql_param = new SqlParameter[1];

            sql_param[0] = new SqlParameter("@tmp", SqlDbType.NVarChar);
            sql_param[0].Value = "";

            DataSet ds = obj_DALCustome.selection("sp_rate_adjustment", sql_param, obj_SqlCommand, true);

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
