using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL.TBL_LOG
{

  public class cls_TBL_LOG
    {
        DAL.DALCustome obj_DAL = new DAL.DALCustome();
        
        string ExeState = "";
        
        private string pSTATUS; 
        public  String  STATUS  
        {
              get { return pSTATUS;  }
              set {pSTATUS  = value ; }
        }
 
      
 
        private  string  pLOG_ID   = string.Empty;
 
        public  string  LOG_ID   
        {
              get { return pLOG_ID ; }
              set { pLOG_ID  = value ; }
        }

        


        public bool insertion(string pLOG_TransactionID, string pLOG_name, string pLOG_text, string pLOG_description, string pLOG_event, SqlCommand pObjSqlCommand, DAL.DALCustome pObjDAlCustome, bool pDalStatus)
        {

            SqlParameter[] sql_param = new SqlParameter[9];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
           
            sql_param[2] = new SqlParameter("@LOG_TransactionID", SqlDbType.NVarChar);
            sql_param[2].Value = pLOG_TransactionID;

            sql_param[3] = new SqlParameter("@LOG_name", SqlDbType.NVarChar);
            sql_param[3].Value = pLOG_name;

            sql_param[4] = new SqlParameter("@LOG_text", SqlDbType.NVarChar);
            sql_param[4].Value = pLOG_text;

            sql_param[5] = new SqlParameter("@LOG_description", SqlDbType.NVarChar);
            sql_param[5].Value = pLOG_description;

            sql_param[6] = new SqlParameter("@LOG_event", SqlDbType.NVarChar);
            sql_param[6].Value = pLOG_event;

            sql_param[7] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[7].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted; 

            sql_param[8] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[8].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;




            DataSet ds = pObjDAlCustome.selection("sp_TBL_LOG_insertion", sql_param, pObjSqlCommand, pDalStatus);

            if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                return true;
            else
                return false;
            
          

        }


      

    

    
    }
}
