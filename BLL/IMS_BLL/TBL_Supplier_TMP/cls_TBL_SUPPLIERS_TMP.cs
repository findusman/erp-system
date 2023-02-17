using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_SUPPLIERS_TMP
{

  public class cls_TBL_SUPPLIERS_TMP
    {
        DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
        public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
        BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        string ExeState = "";
        
        private string pSTATUS; 
        public  String  STATUS  
        {
              get { return pSTATUS;  }
              set {pSTATUS  = value ; }
        }
 
      
 
        private  string  pSUPPLIER_ID   = string.Empty;
 
        public  string  SUPPLIER_ID   
        {
              get { return pSUPPLIER_ID ; }
              set { pSUPPLIER_ID  = value ; }
        }

        


        private  string  pSUPPLIER_COA  = string.Empty;
        public  string  SUPPLIER_COA
        {
              get { return pSUPPLIER_COA; }
              set {pSUPPLIER_COA = value; }
        }


        private  string  pSUPPLIER_name  = string.Empty;
        public  string  SUPPLIER_name
        {
              get { return pSUPPLIER_name; }
              set {pSUPPLIER_name = value; }
        }


        private  string  pSUPPLIER_address  = string.Empty;
        public  string  SUPPLIER_address
        {
              get { return pSUPPLIER_address; }
              set {pSUPPLIER_address = value; }
        }


        private  string  pSUPPLIER_department  = string.Empty;
        public  string  SUPPLIER_department
        {
              get { return pSUPPLIER_department; }
              set {pSUPPLIER_department = value; }
        }


        private  decimal  pSUPPLIER_millage  = 0;
        public  decimal  SUPPLIER_millage
        {
              get { return pSUPPLIER_millage; }
              set {pSUPPLIER_millage = value; }
        }


        private  decimal  pSUPPLIER_creditLimit  = 0;
        public  decimal  SUPPLIER_creditLimit
        {
              get { return pSUPPLIER_creditLimit; }
              set {pSUPPLIER_creditLimit = value; }
        }


        private  decimal  pSUPPLIER_creditDays  = 0;
        public  decimal  SUPPLIER_creditDays
        {
              get { return pSUPPLIER_creditDays; }
              set {pSUPPLIER_creditDays = value; }
        }


        private  string  pSUPPLIER_phone  = string.Empty;
        public  string  SUPPLIER_phone
        {
              get { return pSUPPLIER_phone; }
              set {pSUPPLIER_phone = value; }
        }


        private  string  pSUPPLIER_email  = string.Empty;
        public  string  SUPPLIER_email
        {
              get { return pSUPPLIER_email; }
              set {pSUPPLIER_email = value; }
        }



        private bool  pIs_Auto_Generated    = true;
 
        public  bool  Is_Auto_Generated    
        {
              get { return pIs_Auto_Generated  ; }
              set { pIs_Auto_Generated   = value ; }
        }
 
        private  string  pUser_ID   = string.Empty;
 
        public  string  User_ID   
        {
              get { return pUser_ID ; }
              set { pUser_ID  = value ; }
        }      
 
        
        public bool insertionUpdation(char pProcedureStatus)
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            SqlParameter[] sql_param = new SqlParameter[15];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@SUPPLIER_ID ", SqlDbType.NVarChar);
            sql_param[2].Value = SUPPLIER_ID ;


sql_param[3] = new SqlParameter("@SUPPLIER_COA", SqlDbType.NVarChar);
sql_param[3].Value = SUPPLIER_COA;

sql_param[4] = new SqlParameter("@SUPPLIER_name", SqlDbType.NVarChar);
sql_param[4].Value = SUPPLIER_name;

sql_param[5] = new SqlParameter("@SUPPLIER_address", SqlDbType.NVarChar);
sql_param[5].Value = SUPPLIER_address;

sql_param[6] = new SqlParameter("@SUPPLIER_department", SqlDbType.NVarChar);
sql_param[6].Value = SUPPLIER_department;

sql_param[7] = new SqlParameter("@SUPPLIER_millage", SqlDbType.Float);
sql_param[7].Value = SUPPLIER_millage;

sql_param[8] = new SqlParameter("@SUPPLIER_creditLimit", SqlDbType.Float);
sql_param[8].Value = SUPPLIER_creditLimit;

sql_param[9] = new SqlParameter("@SUPPLIER_creditDays", SqlDbType.Float);
sql_param[9].Value = SUPPLIER_creditDays;

sql_param[10] = new SqlParameter("@SUPPLIER_phone", SqlDbType.NVarChar);
sql_param[10].Value = SUPPLIER_phone;

sql_param[11] = new SqlParameter("@SUPPLIER_email", SqlDbType.NVarChar);
sql_param[11].Value = SUPPLIER_email;
           
            sql_param[12] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[12].Value = Is_Auto_Generated;

            sql_param[13] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
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
              ds = obj_DALCustome.selection("sp_TBL_SUPPLIERS_TMP_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_SUPPLIERS_TMP_updation", sql_param, obj_SqlCommand, true);
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

            sql_param[3] = new SqlParameter("@SUPPLIER_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = SUPPLIER_ID ;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

                DataSet ds = obj_DALCustome.selection("sp_TBL_SUPPLIERS_TMP_deletion", sql_param, obj_SqlCommand, true);
          
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

                    string Log_description =  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogDescription;
                    string Log_event =  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogEvent;

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

            sql_param[3] = new SqlParameter("@SUPPLIER_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = SUPPLIER_ID ;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome .selection("sp_TBL_SUPPLIERS_TMP_selection", sql_param,obj_SqlCommand ,true);

            if (ds!=null)
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
