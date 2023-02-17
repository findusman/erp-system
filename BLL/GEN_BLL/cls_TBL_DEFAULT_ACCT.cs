using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
//using GEN_DAL;
 
namespace BLL.GEN_BLL
{
//     *****************************************************************************************************************************************************************
 
 
//                             Code Type:           Business Logic Layer
//                             Creation Date:       7/11/2014 9:43:35 AM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_DEFAULT_ACCT
    {
      DAL.DALCustome obj_dal = new DAL.DALCustome();
 
        public Boolean  gproperty_allocatoin = false;
        public static DataTable dt_DEF = new DataTable();

        string ExeState = "";
 
        private  String  status  ;
 
        public  String  STATUS  
        {
              get { return status; }
              set {status = value ; }
        }

        private string cMP_ID = null;
 
        public  string  CMP_ID  
        {
              get { return cMP_ID; }
              set {cMP_ID = value ; }
        }

       private string bRC_ID = null;
 
        public  string  BRC_ID  
        {
              get { return bRC_ID; }
              set {bRC_ID = value ; }
        }
 
        private  int  dEFAULT_ACCT_ID  = 0;
 
        public  int  DEFAULT_ACCT_ID  
        {
              get { return dEFAULT_ACCT_ID; }
              set {dEFAULT_ACCT_ID = value ; }
        }
 
        private  string  dEFAULT_ACCT_KEY  = string.Empty;
 
        public  string  DEFAULT_ACCT_KEY  
        {
              get { return dEFAULT_ACCT_KEY; }
              set {dEFAULT_ACCT_KEY = value ; }
        }
 
        private  string  dEFAULT_ACCT_CODE  = string.Empty;
 
        public  string  DEFAULT_ACCT_CODE  
        {
              get { return dEFAULT_ACCT_CODE; }
              set {dEFAULT_ACCT_CODE = value ; }
        }
 
        private  string  dEFAULT_ACCT_MATCH  = string.Empty;
 
        public  string  DEFAULT_ACCT_MATCH  
        {
              get { return dEFAULT_ACCT_MATCH; }
              set {dEFAULT_ACCT_MATCH = value ; }
        }
 
        private  bool  dEFAULT_ACCT_isParent  = true;
 
        public  bool  DEFAULT_ACCT_isParent  
        {
              get { return dEFAULT_ACCT_isParent; }
              set {dEFAULT_ACCT_isParent = value ; }
        }
 
        private  bool  dEFAULT_ACCT_isDeleted  = true;
 
        public  bool  DEFAULT_ACCT_isDeleted  
        {
              get { return dEFAULT_ACCT_isDeleted; }
              set {dEFAULT_ACCT_isDeleted = value ; }
        }
 
        public bool insertion()
        {

            DAL.DALCustome objDAlCustome = new DAL.DALCustome();
            SqlCommand objSqlCommand = new SqlCommand();
            SqlParameter[] sql_param;
            SqlParameter[] sql_param2 = new SqlParameter[0];


            string ExeStatetemp = "ok";
         ///   DAlCustome.DATABASE = "GEN";
            string Status = objDAlCustome.open_connection();



            if (Status != "ok")
            {
                objDAlCustome.closeconnection();
                return false;
            }
            else
            {

                ExeStatetemp = objDAlCustome.ins_del_upd("sp_TBL_DEFAULT_ACCT_deletion", sql_param2, objSqlCommand, true);           

            }

            
          
                for (int x = 0; x < dt_DEF.Rows.Count; x++)
                {
                    sql_param = new SqlParameter[5];
                    if (ExeStatetemp != "ok")
                    {
                        objDAlCustome.transactioRollBack();
                        objDAlCustome.closeconnection();
                        return false;
                    }


                    sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                    sql_param[0].Value = CMP_ID;

                    sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                    sql_param[1].Value = BRC_ID;

                    sql_param[2] = new SqlParameter("@DEFAULT_ACCT_KEY", SqlDbType.NVarChar);
                    sql_param[2].Value = dt_DEF.Rows[x]["KEY_key"].ToString();

                    sql_param[3] = new SqlParameter("@DEFAULT_ACCT_CODE", SqlDbType.NVarChar);
                    sql_param[3].Value = dt_DEF.Rows[x]["DEFAULT_ACCT_CODE"].ToString();

                    sql_param[4] = new SqlParameter("@DEFAULT_ACCT_isDeleted", SqlDbType.Bit);
                    sql_param[4].Value = DEFAULT_ACCT_isDeleted;

                    ExeStatetemp = objDAlCustome.ins_del_upd("sp_TBL_DEFAULT_ACCT_insertion", sql_param, objSqlCommand, false);
                   

                }

                if (ExeStatetemp == "ok")
                {
                    objDAlCustome.transactioCommit();
                    objDAlCustome.closeconnection();
                }
                else
                {
                    objDAlCustome.transactioRollBack();
                    objDAlCustome.closeconnection();
                
                }

          return true;



        }
        
        
        
        
        
        public bool updation()

        {

              SqlParameter[] sql_param = new SqlParameter[8];
 
            
 
             string ExeStatetemp = "ok";
             for (int x = 0; x < dt_DEF.Rows.Count; x++)
             {
                 if (ExeStatetemp != "ok")
                     return false;


                 sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                 sql_param[0].Value = CMP_ID;

                 sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                 sql_param[1].Value = BRC_ID;

                 sql_param[2] = new SqlParameter("@DEFAULT_ACCT_ID", SqlDbType.Int);
                 sql_param[2].Value = DEFAULT_ACCT_ID;

                 sql_param[3] = new SqlParameter("@DEFAULT_ACCT_KEY", SqlDbType.NVarChar);
                 sql_param[3].Value = DEFAULT_ACCT_KEY;

                 sql_param[4] = new SqlParameter("@DEFAULT_ACCT_CODE", SqlDbType.NVarChar);
                 sql_param[4].Value = DEFAULT_ACCT_CODE;

                 sql_param[5] = new SqlParameter("@DEFAULT_ACCT_MATCH", SqlDbType.NVarChar);
                 sql_param[5].Value = DEFAULT_ACCT_MATCH;

                 sql_param[6] = new SqlParameter("@DEFAULT_ACCT_isParent", SqlDbType.Bit);
                 sql_param[6].Value = DEFAULT_ACCT_isParent;

                 sql_param[7] = new SqlParameter("@DEFAULT_ACCT_isDeleted", SqlDbType.Bit);
                 sql_param[7].Value = DEFAULT_ACCT_isDeleted;



                 ExeStatetemp = obj_dal.ins_del_upd("sp_TBL_DEFAULT_ACCT_updation", sql_param);
             }
             return true;
                     
          

        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[6];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = BRC_ID ;
        sql_param[3] = new SqlParameter("@DEFAULT_ACCT_ID", SqlDbType.Int);
        sql_param[3].Value = DEFAULT_ACCT_ID ;
        sql_param[4] = new SqlParameter("@DEFAULT_ACCT_KEY", SqlDbType.NVarChar);
        sql_param[4].Value = DEFAULT_ACCT_KEY ;
        sql_param[8] = new SqlParameter("@DEFAULT_ACCT_isDeleted", SqlDbType.Bit);
        sql_param[8].Value = DEFAULT_ACCT_isDeleted ;
 

         ExeState = obj_dal.ins_del_upd("sp_TBL_DEFAULT_ACCT_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {

        SqlParameter[] sql_param = new SqlParameter[6];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = BRC_ID ;
        sql_param[3] = new SqlParameter("@DEFAULT_ACCT_ID", SqlDbType.Int);
        sql_param[3].Value = DEFAULT_ACCT_ID ;
        sql_param[4] = new SqlParameter("@DEFAULT_ACCT_KEY", SqlDbType.NVarChar);
        sql_param[4].Value = DEFAULT_ACCT_KEY ;
        sql_param[5] = new SqlParameter("@DEFAULT_ACCT_isDeleted", SqlDbType.Bit);
        sql_param[5].Value = DEFAULT_ACCT_isDeleted ;

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_DEFAULT_ACCT_selection", sql_param);

        if(ds == null)
        {
        return ds ;
        }

        int x = ds.Tables.Count;

         DataTable dt = new DataTable();

        dt = ds.Tables[0];

        if(gproperty_allocatoin == true)
        {
        if (dt.Rows.Count != 0)

        {

            CMP_ID = (string)GEN.GEN_GEN.GenericClasses.Form.Gen_Form.checkDbNull(dt.Rows[0]["CMP_ID"]);
            BRC_ID = (string)GEN.GEN_GEN.GenericClasses.Form.Gen_Form.checkDbNull(dt.Rows[0]["BRC_ID"]);        
        DEFAULT_ACCT_ID = Convert.ToInt32( dt.Rows[0]["DEFAULT_ACCT_ID"].ToString());
        DEFAULT_ACCT_KEY = Convert.ToString( dt.Rows[0]["DEFAULT_ACCT_KEY"].ToString());
        DEFAULT_ACCT_CODE = Convert.ToString( dt.Rows[0]["DEFAULT_ACCT_CODE"].ToString());
        DEFAULT_ACCT_MATCH = Convert.ToString( dt.Rows[0]["DEFAULT_ACCT_MATCH"].ToString());
        DEFAULT_ACCT_isParent = Convert.ToBoolean( dt.Rows[0]["DEFAULT_ACCT_isParent"].ToString());
        DEFAULT_ACCT_isDeleted = Convert.ToBoolean( dt.Rows[0]["DEFAULT_ACCT_isDeleted"].ToString());

        }

        }

        return ds;

        }
        
    }
}
