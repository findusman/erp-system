using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace BLL.IMS_BLL
{
//     *****************************************************************************************************************************************************************
 
 
//                             Code Type:           Business Logic Layer
//                             Creation Date:       5/11/2014 6:12:34 PM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_IA
    {
      DAL.DALCustome obj_dal = new DAL.DALCustome();
 
        public Boolean  gproperty_allocatoin = false;
 
        string ExeState = "";
 
        private  char  status  ;
 
        public  char  STATUS  
        {
              get { return status; }
              set {status = value ; }
        }

        private string cMP_ID = null;

        public string CMP_ID
        {
            get { return cMP_ID; }
            set { cMP_ID = value; }
        }

        private string bRC_ID = null;

        public string BRC_ID
        {
            get { return bRC_ID; }
            set { bRC_ID = value; }
        }

        private  string  iA_ID  = string.Empty;
 
        public  string  IA_ID  
        {
              get { return iA_ID; }
              set {iA_ID = value ; }
        }
 
        private  string  iA_name  = string.Empty;
 
        public  string  IA_name  
        {
              get { return iA_name; }
              set {iA_name = value ; }
        }
 
        private  int  iA_description  = 0;
 
        public  int  IA_description  
        {
              get { return iA_description; }
              set {iA_description = value ; }
        }
 
        public string insertion()
        {

              SqlParameter[] sql_param = new SqlParameter[4];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
 
        sql_param[1] = new SqlParameter("@IA_name", SqlDbType.NVarChar);
        sql_param[1].Value = IA_name ;
 
        sql_param[2] = new SqlParameter("@IA_description", SqlDbType.Int);
        sql_param[2].Value = IA_description ;

        sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[3].Value = BRC_ID;

        ExeState = obj_dal.ins_del_upd("sp_TBL_IA_insertion", sql_param);

         return ExeState ;

        }
        
        
        
        
        
        public string updation()

        {

              SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
        sql_param[1] = new SqlParameter("@IA_ID", SqlDbType.NVarChar);
        sql_param[1].Value = IA_ID ;
 
        sql_param[2] = new SqlParameter("@IA_name", SqlDbType.NVarChar);
        sql_param[2].Value = IA_name ;
 
        sql_param[3] = new SqlParameter("@IA_description", SqlDbType.Int);
        sql_param[3].Value = IA_description ;
 
        sql_param[4] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[4].Value = BRC_ID;
 

        ExeState = obj_dal.ins_del_upd("sp_TBL_IA_updation", sql_param);

        return ExeState ; 
        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[4];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@IA_ID", SqlDbType.NVarChar);
        sql_param[2].Value = IA_ID ;
        sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[3].Value = BRC_ID;
 

         ExeState = obj_dal.ins_del_upd("sp_TBL_IA_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {

        SqlParameter[] sql_param = new SqlParameter[4];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@IA_ID", SqlDbType.NVarChar);
        sql_param[2].Value = IA_ID ;
        sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[3].Value = BRC_ID;
 

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_IA_selection", sql_param);

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

        CMP_ID = (dt.Rows[0]["CMP_ID"].ToString());
        IA_ID = Convert.ToString( dt.Rows[0]["IA_ID"].ToString());
        IA_name = Convert.ToString( dt.Rows[0]["IA_name"].ToString());
        IA_description = Convert.ToInt32( dt.Rows[0]["IA_description"].ToString());

        }

        }

        return ds;

        }
        
    }
}
