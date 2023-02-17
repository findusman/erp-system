using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.ACC_BLL.TBL_FINANCIAL_YEAR
{

  public class cls_TBL_FINANCIAL_YEAR
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


        private DateTime pfromDate = DateTime.Now;

        public DateTime fromDate
        {
            get { return pfromDate; }
            set { pfromDate = value; }
        }

        private DateTime ptoDate = DateTime.Now;

        public DateTime toDate
        {
            get { return ptoDate; }
            set { ptoDate = value; }
        }  

      
 
        private  string  pFINANCIAL_YEAR_ID   = string.Empty;
 
        public  string  FINANCIAL_YEAR_ID   
        {
              get { return pFINANCIAL_YEAR_ID ; }
              set { pFINANCIAL_YEAR_ID  = value ; }
        }

        


        private  string  pFINANCIAL_YEAR_name  = string.Empty;
        public  string  FINANCIAL_YEAR_name
        {
              get { return pFINANCIAL_YEAR_name; }
              set {pFINANCIAL_YEAR_name = value; }
        }


        private  DateTime  pFINANCIAL_YEAR_fromDate  = DateTime.Now;
        public  DateTime  FINANCIAL_YEAR_fromDate
        {
              get { return pFINANCIAL_YEAR_fromDate; }
              set {pFINANCIAL_YEAR_fromDate = value; }
        }


        private  DateTime  pFINANCIAL_YEAR_fromTo  = DateTime.Now;
        public  DateTime  FINANCIAL_YEAR_fromTo
        {
              get { return pFINANCIAL_YEAR_fromTo; }
              set {pFINANCIAL_YEAR_fromTo = value; }
        }


        private  string  pFINANCIAL_YEAR_lastFinancialYear  = string.Empty;
        public  string  FINANCIAL_YEAR_lastFinancialYear
        {
              get { return pFINANCIAL_YEAR_lastFinancialYear; }
              set {pFINANCIAL_YEAR_lastFinancialYear = value; }
        }


        private  string  pFINANCIAL_YEAR_narration  = string.Empty;
        public  string  FINANCIAL_YEAR_narration
        {
              get { return pFINANCIAL_YEAR_narration; }
              set {pFINANCIAL_YEAR_narration = value; }
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

            SqlParameter[] sql_param = new SqlParameter[11];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@FINANCIAL_YEAR_ID ", SqlDbType.NVarChar);
            sql_param[2].Value = FINANCIAL_YEAR_ID ;


sql_param[3] = new SqlParameter("@FINANCIAL_YEAR_name", SqlDbType.NVarChar);
sql_param[3].Value = FINANCIAL_YEAR_name;

sql_param[4] = new SqlParameter("@FINANCIAL_YEAR_fromDate", SqlDbType.DateTime);
sql_param[4].Value = FINANCIAL_YEAR_fromDate;

sql_param[5] = new SqlParameter("@FINANCIAL_YEAR_fromTo", SqlDbType.DateTime);
sql_param[5].Value = FINANCIAL_YEAR_fromTo;

sql_param[6] = new SqlParameter("@FINANCIAL_YEAR_lastFinancialYear", SqlDbType.NVarChar);
sql_param[6].Value = FINANCIAL_YEAR_lastFinancialYear;

sql_param[7] = new SqlParameter("@FINANCIAL_YEAR_narration", SqlDbType.NVarChar);
sql_param[7].Value = FINANCIAL_YEAR_narration;
           
            sql_param[8] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[8].Value = Is_Auto_Generated;

            sql_param[9] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
            sql_param[9].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted; 

            sql_param[10] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID; 


              DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");
               
                return false;
            }

            if (pProcedureStatus == 'I')
              ds = obj_DALCustome.selection("sp_TBL_FINANCIAL_YEAR_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_FINANCIAL_YEAR_updation", sql_param, obj_SqlCommand, true);
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


        public DataSet selectionBalanceSheet()
        {

            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                return null;
            }

            SqlParameter[] sql_param = new SqlParameter[4];


            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@fromdate ", SqlDbType.DateTime);
            sql_param[2].Value = fromDate;

            sql_param[3] = new SqlParameter("@toDate", SqlDbType.DateTime);
            sql_param[3].Value = toDate;

            DataSet ds = obj_DALCustome.selection("sp_balanceSheet_DM_Lubricants_selection", sql_param, obj_SqlCommand, true);

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
            sql_param[3].Value = FINANCIAL_YEAR_ID ;


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

            sql_param[3] = new SqlParameter("@FINANCIAL_YEAR_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = FINANCIAL_YEAR_ID ;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome .selection("sp_TBL_FINANCIAL_YEAR_selection", sql_param,obj_SqlCommand ,true);

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
