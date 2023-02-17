using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_CUSTOMERS
{

    public class cls_TBL_CUSTOMERS
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



        private string pCUSTOMER_ID = string.Empty;

        public string CUSTOMER_ID
        {
            get { return pCUSTOMER_ID; }
            set { pCUSTOMER_ID = value; }
        }




        private string pCUSTOMER_name = string.Empty;
        public string CUSTOMER_name
        {
            get { return pCUSTOMER_name; }
            set { pCUSTOMER_name = value; }
        }


        private string pCUSTOMER_address = string.Empty;
        public string CUSTOMER_address
        {
            get { return pCUSTOMER_address; }
            set { pCUSTOMER_address = value; }
        }


        private string pCUSTOMER_vehicleMaker = string.Empty;
        public string CUSTOMER_vehicleMaker
        {
            get { return pCUSTOMER_vehicleMaker; }
            set { pCUSTOMER_vehicleMaker = value; }
        }


        private string pCUSTOMER_department = string.Empty;
        public string CUSTOMER_department
        {
            get { return pCUSTOMER_department; }
            set { pCUSTOMER_department = value; }
        }


        private string pCUSTOMER_vehicleNo = string.Empty;
        public string CUSTOMER_vehicleNo
        {
            get { return pCUSTOMER_vehicleNo; }
            set { pCUSTOMER_vehicleNo = value; }
        }


        private decimal pCUSTOMER_millage = 0;
        public decimal CUSTOMER_millage
        {
            get { return pCUSTOMER_millage; }
            set { pCUSTOMER_millage = value; }
        }


        private string pCUSTOMER_year = string.Empty;
        public string CUSTOMER_year
        {
            get { return pCUSTOMER_year; }
            set { pCUSTOMER_year = value; }
        }


        private decimal pCUSTOMER_creditLimit = 0;
        public decimal CUSTOMER_creditLimit
        {
            get { return pCUSTOMER_creditLimit; }
            set { pCUSTOMER_creditLimit = value; }
        }


        private decimal pCUSTOMER_creditDays = 0;
        public decimal CUSTOMER_creditDays
        {
            get { return pCUSTOMER_creditDays; }
            set { pCUSTOMER_creditDays = value; }
        }


        private string pCUSTOMER_phone = string.Empty;
        public string CUSTOMER_phone
        {
            get { return pCUSTOMER_phone; }
            set { pCUSTOMER_phone = value; }
        }


        private string pCUSTOMER_email = string.Empty;
        public string CUSTOMER_email
        {
            get { return pCUSTOMER_email; }
            set { pCUSTOMER_email = value; }
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
        private String pCUSTOMER_COA;

        public String CUSTOMER_COA
        {
            get { return pCUSTOMER_COA; }
            set { pCUSTOMER_COA = value; }
        }  

        public bool insertionUpdation(char pProcedureStatus)
        {
              DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
               SqlCommand obj_SqlCommand = new SqlCommand();

               if (pProcedureStatus == 'I')
               {
                   //coa insertion
                   BLL.ACC_BLL.cls_TBL_COA obj = new BLL.ACC_BLL.cls_TBL_COA();

                   string parentCOAOfCustomer = obj_getCode_Against_key.getCodeAgaintKey(
                               GEN.ACC_GEN.Generics.cls_DefaultCOA.Parent_Of_Customer
                               );

                   dsCOA = obj.insertionDirect(1, GEN.GEN_GEN.GenericClasses.cls_KeysWithValue.Parent_Of_Customer , "", 0, CUSTOMER_name, 0, "", true, "Insertion", "Child", false, true);

                   if (dsCOA == null)
                   {
                       obj_DALCustome.transactioRollBack();
                       obj_DALCustome.closeconnection();
                       obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                       return false;
                   }

                   CUSTOMER_COA =  dsCOA.Tables[0].Rows[0][1].ToString();
                   

               }

         

            SqlParameter[] sql_param = new SqlParameter[18];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value =  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.NVarChar);
            sql_param[2].Value = CUSTOMER_ID;

            sql_param[3] = new SqlParameter("@CUSTOMER_COA", SqlDbType.NVarChar);
            sql_param[3].Value = CUSTOMER_COA;

            sql_param[4] = new SqlParameter("@CUSTOMER_name", SqlDbType.NVarChar);
            sql_param[4].Value = CUSTOMER_name;

            sql_param[5] = new SqlParameter("@CUSTOMER_address", SqlDbType.NVarChar);
            sql_param[5].Value = CUSTOMER_address;

            sql_param[6] = new SqlParameter("@CUSTOMER_vehicleMaker", SqlDbType.NVarChar);
            sql_param[6].Value = CUSTOMER_vehicleMaker;

            sql_param[7] = new SqlParameter("@CUSTOMER_department", SqlDbType.NVarChar);
            sql_param[7].Value = CUSTOMER_department;

            sql_param[8] = new SqlParameter("@CUSTOMER_vehicleNo", SqlDbType.NVarChar);
            sql_param[8].Value = CUSTOMER_vehicleNo;

            sql_param[9] = new SqlParameter("@CUSTOMER_millage", SqlDbType.Float);
            sql_param[9].Value = CUSTOMER_millage;

            sql_param[10] = new SqlParameter("@CUSTOMER_year", SqlDbType.NVarChar);
            sql_param[10].Value = CUSTOMER_year;

            sql_param[11] = new SqlParameter("@CUSTOMER_creditLimit", SqlDbType.Float);
            sql_param[11].Value = CUSTOMER_creditLimit;

            sql_param[12] = new SqlParameter("@CUSTOMER_creditDays", SqlDbType.Float);
            sql_param[12].Value = CUSTOMER_creditDays;

            sql_param[13] = new SqlParameter("@CUSTOMER_phone", SqlDbType.NVarChar);
            sql_param[13].Value = CUSTOMER_phone;

            sql_param[14] = new SqlParameter("@CUSTOMER_email", SqlDbType.NVarChar);
            sql_param[14].Value = CUSTOMER_email;

            sql_param[15] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[15].Value = Is_Auto_Generated;

            sql_param[16] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[16].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[17] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[17].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;



            DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            if (pProcedureStatus == 'I')
                ds = obj_DALCustome.selection("sp_TBL_CUSTOMERS_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_CUSTOMERS_updation", sql_param, obj_SqlCommand, true);
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

            sql_param[3] = new SqlParameter("@CUSTOMER_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = CUSTOMER_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_CUSTOMERS_deletion", sql_param, obj_SqlCommand, true);

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

            sql_param[3] = new SqlParameter("@CUSTOMER_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = CUSTOMER_ID;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_CUSTOMERS_selection", sql_param, obj_SqlCommand, true);

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
