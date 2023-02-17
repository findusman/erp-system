using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.ACC_BLL
{
//     *****************************************************************************************************************************************************************
 
 
//                             Code Type:           Business Logic Layer
//                             Creation Date:       4/28/2014 9:41:16 PM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_TYPE_PLAN_MAIN
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


 
        private  int  tYPE_PLAN_MAIN_ID  = 0;
 
        public  int  TYPE_PLAN_MAIN_ID  
        {
              get { return tYPE_PLAN_MAIN_ID; }
              set {tYPE_PLAN_MAIN_ID = value ; }
        }
 
        private  string  tYPE_PLAN_MAIN_name  = string.Empty;
 
        public  string  TYPE_PLAN_MAIN_name  
        {
              get { return tYPE_PLAN_MAIN_name; }
              set {tYPE_PLAN_MAIN_name = value ; }
        }
 
        private  bool  tYPE_PLAN_MAIN_isSameForAllChilds  = true;
 
        public  bool  TYPE_PLAN_MAIN_isSameForAllChilds  
        {
              get { return tYPE_PLAN_MAIN_isSameForAllChilds; }
              set {tYPE_PLAN_MAIN_isSameForAllChilds = value ; }
        }
 
        private  bool  tYPE_PLAN_MAIN_isActive  = true;
 
        public  bool  TYPE_PLAN_MAIN_isActive  
        {
              get { return tYPE_PLAN_MAIN_isActive; }
              set {tYPE_PLAN_MAIN_isActive = value ; }
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
        private bool tYPE_PLAN_MAIN_isDeleted = true;

        public bool TYPE_PLAN_MAIN_isDeleted
        {
            get { return tYPE_PLAN_MAIN_isDeleted; }
            set { tYPE_PLAN_MAIN_isDeleted = value; }
        }
 
        public string insertion()
        {

              SqlParameter[] sql_param = new SqlParameter[9];
 
 
        sql_param[0] = new SqlParameter("@TYPE_PLAN_MAIN_name", SqlDbType.NVarChar);
        sql_param[0].Value = TYPE_PLAN_MAIN_name ;
 
        sql_param[1] = new SqlParameter("@TYPE_PLAN_MAIN_isSameForAllChilds", SqlDbType.Bit);
        sql_param[1].Value = TYPE_PLAN_MAIN_isSameForAllChilds ;
 
        sql_param[2] = new SqlParameter("@TYPE_PLAN_MAIN_isActive", SqlDbType.Bit);
        sql_param[2].Value = TYPE_PLAN_MAIN_isActive ;

        sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[3].Value = BRC_ID;

        sql_param[4] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[4].Value = CMP_ID;

        sql_param[5] = new SqlParameter("@TYPE_PLAN_MAIN_isDeleted", SqlDbType.Bit);
        sql_param[5].Value = TYPE_PLAN_MAIN_isDeleted;
 
         ExeState = obj_dal.ins_del_upd("sp_TBL_TYPE_PLAN_MAIN_insertion", sql_param);

         return ExeState ;

        }
        
        
        
        
        
        public string updation()

        {

              SqlParameter[] sql_param = new SqlParameter[7];
 
        sql_param[0] = new SqlParameter("@TYPE_PLAN_MAIN_ID", SqlDbType.Int);
        sql_param[0].Value = TYPE_PLAN_MAIN_ID ;
 
        sql_param[1] = new SqlParameter("@TYPE_PLAN_MAIN_name", SqlDbType.NVarChar);
        sql_param[1].Value = TYPE_PLAN_MAIN_name ;
 
        sql_param[2] = new SqlParameter("@TYPE_PLAN_MAIN_isSameForAllChilds", SqlDbType.Bit);
        sql_param[2].Value = TYPE_PLAN_MAIN_isSameForAllChilds ;
 
        sql_param[3] = new SqlParameter("@TYPE_PLAN_MAIN_isActive", SqlDbType.Bit);
        sql_param[3].Value = TYPE_PLAN_MAIN_isActive ;

        sql_param[4] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[4].Value = BRC_ID;

        sql_param[5] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[5].Value = CMP_ID;

        sql_param[6] = new SqlParameter("@TYPE_PLAN_MAIN_isDeleted", SqlDbType.Bit);
        sql_param[6].Value = TYPE_PLAN_MAIN_isDeleted;
 

        ExeState = obj_dal.ins_del_upd("sp_TBL_TYPE_PLAN_MAIN_updation", sql_param);

        return ExeState ; 
        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@TYPE_PLAN_MAIN_ID", SqlDbType.Int);
        sql_param[1].Value = TYPE_PLAN_MAIN_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = BRC_ID;

        sql_param[3] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[3].Value = CMP_ID;

        sql_param[4] = new SqlParameter("@TYPE_PLAN_MAIN_isDeleted", SqlDbType.Bit);
        sql_param[4].Value = TYPE_PLAN_MAIN_isDeleted;
 

         ExeState = obj_dal.ins_del_upd("sp_TBL_TYPE_PLAN_MAIN_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {

        SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@TYPE_PLAN_MAIN_ID", SqlDbType.Int);
        sql_param[1].Value = TYPE_PLAN_MAIN_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = BRC_ID;

        sql_param[3] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[3].Value = CMP_ID;

        sql_param[4] = new SqlParameter("@TYPE_PLAN_MAIN_isDeleted", SqlDbType.Bit);
        sql_param[4].Value = TYPE_PLAN_MAIN_isDeleted;
 

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_TYPE_PLAN_MAIN_selection", sql_param);

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

        TYPE_PLAN_MAIN_ID = Convert.ToInt32( dt.Rows[0]["TYPE_PLAN_MAIN_ID"].ToString());
        TYPE_PLAN_MAIN_name = Convert.ToString( dt.Rows[0]["TYPE_PLAN_MAIN_name"].ToString());
        TYPE_PLAN_MAIN_isSameForAllChilds = Convert.ToBoolean( dt.Rows[0]["TYPE_PLAN_MAIN_isSameForAllChilds"].ToString());
        TYPE_PLAN_MAIN_isActive = Convert.ToBoolean( dt.Rows[0]["TYPE_PLAN_MAIN_isActive"].ToString());

        }

        }

        return ds;

        }
        
    }
}
