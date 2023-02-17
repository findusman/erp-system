using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_KEY
{

  public class cls_TBL_KEY
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
 
      
 
        private  string  pKEY_ID   = string.Empty;
 
        public  string  KEY_ID   
        {
              get { return pKEY_ID ; }
              set { pKEY_ID  = value ; }
        }

        


        private  string  pKEY_key  = string.Empty;
        public  string  KEY_key
        {
              get { return pKEY_key; }
              set {pKEY_key = value; }
        }


        private  string  pKEY_value  = string.Empty;
        public  string  KEY_value
        {
              get { return pKEY_value; }
              set {pKEY_value = value; }
        }


        private  string  pKEY_types  = string.Empty;
        public  string  KEY_types
        {
              get { return pKEY_types; }
              set {pKEY_types = value; }
        }


        private  string  pKEY_extraString1  = string.Empty;
        public  string  KEY_extraString1
        {
              get { return pKEY_extraString1; }
              set {pKEY_extraString1 = value; }
        }


        private  string  pKEY_KEY_extraString2  = string.Empty;
        public  string  KEY_KEY_extraString2
        {
              get { return pKEY_KEY_extraString2; }
              set {pKEY_KEY_extraString2 = value; }
        }


        private  bool  pKEY_extraBit1  = true;
        public  bool  KEY_extraBit1
        {
              get { return pKEY_extraBit1; }
              set {pKEY_extraBit1 = value; }
        }


        private  bool  pKEY_KEY_extraBit2  = true;
        public  bool  KEY_KEY_extraBit2
        {
              get { return pKEY_KEY_extraBit2; }
              set {pKEY_KEY_extraBit2 = value; }
        }


        private  string  pKEY_description  = string.Empty;
        public  string  KEY_description
        {
              get { return pKEY_description; }
              set {pKEY_description = value; }
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

            SqlParameter[] sql_param = new SqlParameter[14];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@KEY_ID ", SqlDbType.NVarChar);
            sql_param[2].Value = KEY_ID ;


sql_param[3] = new SqlParameter("@KEY_key", SqlDbType.NVarChar);
sql_param[3].Value = KEY_key;

sql_param[4] = new SqlParameter("@KEY_value", SqlDbType.NVarChar);
sql_param[4].Value = KEY_value;

sql_param[5] = new SqlParameter("@KEY_types", SqlDbType.NVarChar);
sql_param[5].Value = KEY_types;

sql_param[6] = new SqlParameter("@KEY_extraString1", SqlDbType.NVarChar);
sql_param[6].Value = KEY_extraString1;

sql_param[7] = new SqlParameter("@KEY_KEY_extraString2", SqlDbType.NVarChar);
sql_param[7].Value = KEY_KEY_extraString2;

sql_param[8] = new SqlParameter("@KEY_extraBit1", SqlDbType.Bit);
sql_param[8].Value = KEY_extraBit1;

sql_param[9] = new SqlParameter("@KEY_KEY_extraBit2", SqlDbType.Bit);
sql_param[9].Value = KEY_KEY_extraBit2;

sql_param[10] = new SqlParameter("@KEY_description", SqlDbType.NVarChar);
sql_param[10].Value = KEY_description;
           
            sql_param[11] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[11].Value = Is_Auto_Generated;

            sql_param[12] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
            sql_param[12].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted; 

            sql_param[13] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[13].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID; 


              DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");
               
                return false;
            }

            if (pProcedureStatus == 'I')
              ds = obj_DALCustome.selection("sp_TBL_KEY_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_KEY_updation", sql_param, obj_SqlCommand, true);
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

            sql_param[3] = new SqlParameter("@KEY_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = KEY_ID ;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

                DataSet ds = obj_DALCustome.selection("sp_TBL_KEY_deletion", sql_param, obj_SqlCommand, true);
          
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

            sql_param[3] = new SqlParameter("@KEY_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = KEY_ID ;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome .selection("sp_TBL_KEY_selection", sql_param,obj_SqlCommand ,true);

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
