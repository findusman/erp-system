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
//                             Creation Date:       4/27/2014 8:28:26 PM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************

    public class cls_GET_MAX
    {
        DAL.DALCustome obj_dal = new DAL.DALCustome();

 
        public Boolean  gproperty_allocatoin = false;
 
        string ExeState = "";

        string sTATUS = "";


        public string STATUS
        {
            get { return sTATUS; }
            set { sTATUS = value; }
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



        int dependent_C1 = 0;

        public int Dependent_C1
        {
            get { return dependent_C1; }
            set { dependent_C1 = value; }
        }
        int dependent_C2 = 0;

        public int Dependent_C2
        {
            get { return dependent_C2; }
            set { dependent_C2 = value; }
        }
        int dependent_C3 = 0;

        public int Dependent_C3
        {
            get { return dependent_C3; }
            set { dependent_C3 = value; }
        }

        string dependent_S1 = "";

        public string Dependent_S1
        {
            get { return dependent_S1; }
            set { dependent_S1 = value; }
        }
        string dependent_S2 = "";

        public string Dependent_S2
        {
            get { return dependent_S2; }
            set { dependent_S2 = value; }
        }
        string dependent_S3 = "";

        public string Dependent_S3
        {
            get { return dependent_S3; }
            set { dependent_S3 = value; }
        }


        bool is_Deleted = true   ;

        public bool isDeleted 
        {
            get { return is_Deleted; }
            set { is_Deleted = value; }
        }



       
        public int getMax()
        {

        SqlParameter[] sql_param = new SqlParameter[10];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = @CMP_ID;

        sql_param[2] = new SqlParameter("@Dependent_C1", SqlDbType.Int);
        sql_param[2].Value = Dependent_C1;
        sql_param[3] = new SqlParameter("@Dependent_C2", SqlDbType.Int);
        sql_param[3].Value = Dependent_C2;
        sql_param[4] = new SqlParameter("@Dependent_C3", SqlDbType.Int);
        sql_param[4].Value = Dependent_C2;

        sql_param[5] = new SqlParameter("@Dependent_S1", SqlDbType.NVarChar);
        sql_param[5].Value = Dependent_S1;
        sql_param[6] = new SqlParameter("@Dependent_S2", SqlDbType.NVarChar);
        sql_param[6].Value = Dependent_S1;
        sql_param[7] = new SqlParameter("@Dependent_S3", SqlDbType.NVarChar);
        sql_param[7].Value = Dependent_S1;
        sql_param[8] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[8].Value = BRC_ID;
        sql_param[9] = new SqlParameter("@isDeleted", SqlDbType.Bit);
        sql_param[9].Value = isDeleted;





        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_GET_MAX", sql_param);

        if (ds == null)
        {
            return 0;
        }
        else
        { 
        
            if(ds.Tables[0].Rows.Count == 0)
            {
            
                return 0;
            }
            else
            {
            
               return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            
        }

    
    
        }
        
    }
}
