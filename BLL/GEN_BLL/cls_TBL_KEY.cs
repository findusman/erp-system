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
//                             Creation Date:       7/10/2014 3:33:45 PM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_KEY
    {
        DAL.DALCustome obj_dal = new DAL.DALCustome();
 
        public Boolean  gproperty_allocatoin = false;
 
        string ExeState = "";
 
        private  String  status  ;
 
        public  String  STATUS  
        {
              get { return status; }
              set {status = value ; }
        }

        private string gEN_FORM_CMP_ID = null;
 
        public  string  GEN_FORM_CMP_ID  
        {
              get { return gEN_FORM_CMP_ID; }
              set {gEN_FORM_CMP_ID = value ; }
        }
 
        private  int  gEN_FORM_ID;
 
        public  int  GEN_FORM_ID  
        {
              get { return gEN_FORM_ID; }
              set {gEN_FORM_ID = value ; }
        }
 
        private  string  gEN_FORM_key  = string.Empty;
 
        public  string  GEN_FORM_key  
        {
              get { return gEN_FORM_key; }
              set {gEN_FORM_key = value ; }
        }
 
        private  string  gEN_FORM_value  = string.Empty;
 
        public  string  GEN_FORM_value  
        {
              get { return gEN_FORM_value; }
              set {gEN_FORM_value = value ; }
        }
 
        private  string  gEN_FORM_Prefix  = string.Empty;
 
        public  string  GEN_FORM_Prefix  
        {
              get { return gEN_FORM_Prefix; }
              set {gEN_FORM_Prefix = value ; }
        }
 
        public DataSet insertion()
        {

              SqlParameter[] sql_param = new SqlParameter[4];
 
        sql_param[0] = new SqlParameter("@GEN_FORM_CMP_ID", SqlDbType.Int);
        sql_param[0].Value = GEN_FORM_CMP_ID ;
 
 
        sql_param[1] = new SqlParameter("@GEN_FORM_key", SqlDbType.NVarChar);
        sql_param[1].Value = GEN_FORM_key ;
 
        sql_param[2] = new SqlParameter("@GEN_FORM_value", SqlDbType.NVarChar);
        sql_param[2].Value = GEN_FORM_value ;
 
        sql_param[3] = new SqlParameter("@GEN_FORM_Prefix", SqlDbType.NVarChar);
        sql_param[3].Value = GEN_FORM_Prefix ;

         //ExeState = obj_dal.ins_del_upd("sp_TBL_KEY_insertion", sql_param);
        DataSet ds = obj_dal.selection("sp_TBL_KEY_insertion", sql_param);
        return ds;
         

        }
        
        
        
        
        
        public DataSet updation()

        {

              SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@GEN_FORM_CMP_ID", SqlDbType.Int);
        sql_param[0].Value = GEN_FORM_CMP_ID ;
 
        sql_param[1] = new SqlParameter("@GEN_FORM_ID", SqlDbType.Int);
        sql_param[1].Value = GEN_FORM_ID ;
 
        sql_param[2] = new SqlParameter("@GEN_FORM_key", SqlDbType.NVarChar);
        sql_param[2].Value = GEN_FORM_key ;
 
        sql_param[3] = new SqlParameter("@GEN_FORM_value", SqlDbType.NVarChar);
        sql_param[3].Value = GEN_FORM_value ;
 
        sql_param[4] = new SqlParameter("@GEN_FORM_Prefix", SqlDbType.NVarChar);
        sql_param[4].Value = GEN_FORM_Prefix ;

//        ExeState = obj_dal.ins_del_upd("sp_TBL_KEY_updation", sql_param);

        DataSet ds = obj_dal.selection("sp_TBL_KEY_updation", sql_param);
        return ds;
        
        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@GEN_FORM_CMP_ID", SqlDbType.Int);
        sql_param[1].Value = GEN_FORM_CMP_ID ;
        sql_param[2] = new SqlParameter("@GEN_FORM_ID", SqlDbType.Int);
        sql_param[2].Value = GEN_FORM_ID ;
        sql_param[3] = new SqlParameter("@GEN_FORM_key", SqlDbType.NVarChar);
        sql_param[3].Value = GEN_FORM_key ;
        sql_param[5] = new SqlParameter("@GEN_FORM_Prefix", SqlDbType.NVarChar);
        sql_param[5].Value = GEN_FORM_Prefix ;
 

         ExeState = obj_dal.ins_del_upd("sp_TBL_KEY_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {

        SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@GEN_FORM_CMP_ID", SqlDbType.Int);
        sql_param[1].Value = GEN_FORM_CMP_ID ;
        sql_param[2] = new SqlParameter("@GEN_FORM_ID", SqlDbType.Int);
        sql_param[2].Value = GEN_FORM_ID ;
        sql_param[3] = new SqlParameter("@GEN_FORM_key", SqlDbType.NVarChar);
        sql_param[3].Value = GEN_FORM_key ;
        sql_param[4] = new SqlParameter("@GEN_FORM_Prefix", SqlDbType.NVarChar);
        sql_param[4].Value = GEN_FORM_Prefix ;
 

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_KEY_selection", sql_param);

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

            GEN_FORM_CMP_ID = (dt.Rows[0]["GEN_FORM_CMP_ID"].ToString());
        GEN_FORM_ID = Convert.ToInt32( dt.Rows[0]["GEN_FORM_ID"].ToString());
        GEN_FORM_key = Convert.ToString( dt.Rows[0]["GEN_FORM_key"].ToString());
        GEN_FORM_value = Convert.ToString( dt.Rows[0]["GEN_FORM_value"].ToString());
        GEN_FORM_Prefix = Convert.ToString( dt.Rows[0]["GEN_FORM_Prefix"].ToString());

        }

        }

        return ds;

        }
        
    }
}
