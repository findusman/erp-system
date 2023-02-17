using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.GEN_BLL
{
//     *****************************************************************************************************************************************************************
 
 
//                             Code Type:           Business Logic Layer
//                             Creation Date:       4/28/2014 9:31:08 PM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_COA
    {
      DAL.DALCustome obj_dal = new DAL.DALCustome();
 
        public Boolean  gproperty_allocatoin = false;
 
        string ExeState = "";
 
        private  string   status  ;
 
        public  string   STATUS  
        {
              get { return status; }
              set {status = value ; }
        }
 
       private string cMP_ID  = null;
 
        public  string  CMP_ID  
        {
              get { return cMP_ID; }
              set {cMP_ID = value ; }
        }
       private string bRC_ID = null;

       public string BRC_ID
        {
            get { return bRC_ID; }
            set { bRC_ID = value; }
        }
 

        private  int  cOA_ID  = 0;
 
        public  int  COA_ID  
        {
              get { return cOA_ID; }
              set {cOA_ID = value ; }
        }
 
        private  string  cOA_PARENTID  = string.Empty;
 
        public  string  COA_PARENTID  
        {
              get { return cOA_PARENTID; }
              set {cOA_PARENTID = value ; }
        }
 
        private  string  cOA_UID  = string.Empty;
 
        public  string  COA_UID  
        {
              get { return cOA_UID; }
              set {cOA_UID = value ; }
        }
 
        private  string  cOA_prefix  = string.Empty;
 
        public  string  COA_prefix  
        {
              get { return cOA_prefix; }
              set {cOA_prefix = value ; }
        }
 
        private  int  cOA_levelID  = 0;
 
        public  int  COA_levelID  
        {
              get { return cOA_levelID; }
              set {cOA_levelID = value ; }
        }
 
        private  int  cOA_definationPlanID  = 0;
 
        public  int  COA_definationPlanID  
        {
              get { return cOA_definationPlanID; }
              set {cOA_definationPlanID = value ; }
        }
 
        private  string  cOA_Name  = string.Empty;
 
        public  string  COA_Name  
        {
              get { return cOA_Name; }
              set {cOA_Name = value ; }
        }
 
        private  int  cOA_type  = 0;
 
        public  int  COA_type  
        {
              get { return cOA_type; }
              set {cOA_type = value ; }
        }
 
        private  bool  cOA_isActive  = true;
 
        public  bool  COA_isActive  
        {
              get { return cOA_isActive; }
              set {cOA_isActive = value ; }
        }

        private string cOA_description = string.Empty;

        public string COA_description
        {
            get { return cOA_description; }
            set { cOA_description = value; }
        }

        private string cOA_nature = string.Empty;

        public string COA_nature
        {
            get { return cOA_nature; }
            set { cOA_nature = value; }
        }
 
        private  bool  cOA_IsInventory  = false;
 
        public  bool  COA_IsInventory  
        {
            get { return cOA_IsInventory; }
            set { cOA_IsInventory = value; }
        }

        private bool cOA_IsDeleted = false;

        public bool COA_IsDeleted
        {
            get { return cOA_IsDeleted; }
            set { cOA_IsDeleted = value; }
        }


        private bool cOA_IsTransaction = false;

        public bool COA_IsTransaction
        {
            get { return cOA_IsTransaction; }
            set { cOA_IsTransaction = value; }
        }
        private  int  cOA_levelNo  = 0;
 
        public  int  COA_levelNo  
        {
              get { return cOA_levelNo; }
              set {cOA_levelNo = value ; }
        }



        public string settingValuesThenInsert(int ptmp_levelNo, string pCOA_PARENTID, string pCOA_UID, string pCOA_prefix, int pCOA_levelID,
                           string pCOA_Name, int pCOA_type, bool pCOA_isActive, string pCOA_description, bool pCOA_IsInventory, string pCOA_nature)
        {
            try
            {
              //  DataTable dt = cls_InitiateGrids.dt_COA;

                this.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
                this.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID; 
                this.COA_PARENTID = pCOA_PARENTID;
                this.COA_UID = pCOA_UID;
                this.COA_prefix = pCOA_prefix;
                this.COA_levelID = pCOA_levelID;
                this.COA_definationPlanID = Convert.ToInt16(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[ptmp_levelNo]["TBL_ACC_PLAN_DEF_ID"]);

                this.COA_Name = pCOA_Name;
                this.COA_type = pCOA_type;
                this.COA_isActive = pCOA_isActive;
                this.COA_description = pCOA_description;
                this.COA_IsInventory = pCOA_IsInventory;
                this.COA_levelNo = ptmp_levelNo + 1;

                if (GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_transactionLevel == this.COA_levelNo)
                    this.COA_IsTransaction = true;
                else
                    this.COA_IsTransaction = false;

                this.COA_nature = pCOA_nature;
                this.COA_IsDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted; 

                return this.insertion();
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();

            }


        }


        public string settingValuesThenDelete(string pCOA_UID)
        {
            try
            {

                this.STATUS = "D";
                this.COA_UID = pCOA_UID;
                this.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
                this.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
                this.COA_IsDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted; 


                return this.deletion();

            }
            catch (Exception ex)
            {

                return ex.Message.ToString();

            }


        }


        public string insertion()
        {

              SqlParameter[] sql_param = new SqlParameter[16];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
 
        sql_param[1] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
        sql_param[1].Value = COA_PARENTID ;
 
        sql_param[2] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
        sql_param[2].Value = COA_UID ;
 
        sql_param[3] = new SqlParameter("@COA_prefix", SqlDbType.NVarChar);
        sql_param[3].Value = COA_prefix ;
 
        sql_param[4] = new SqlParameter("@COA_levelID", SqlDbType.Int);
        sql_param[4].Value = COA_levelID ;
 
        sql_param[5] = new SqlParameter("@COA_definationPlanID", SqlDbType.Int);
        sql_param[5].Value = COA_definationPlanID ;
 
        sql_param[6] = new SqlParameter("@COA_Name", SqlDbType.NVarChar);
        sql_param[6].Value = COA_Name ;
 
        sql_param[7] = new SqlParameter("@COA_type", SqlDbType.Int);
        sql_param[7].Value = COA_type ;
 
        sql_param[8] = new SqlParameter("@COA_isActive", SqlDbType.Bit);
        sql_param[8].Value = COA_isActive ;
 
        sql_param[9] = new SqlParameter("@COA_description", SqlDbType.NVarChar);
        sql_param[9].Value = COA_description ;
 

        sql_param[10] = new SqlParameter("@COA_Inventory", SqlDbType.Bit);
        sql_param[10].Value = COA_IsInventory ;
 
        sql_param[11] = new SqlParameter("@COA_levelNo", SqlDbType.Int);
        sql_param[11].Value = COA_levelNo ;

        sql_param[12] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
        sql_param[12].Value = COA_IsTransaction;


        sql_param[13] = new SqlParameter("@COA_nature", SqlDbType.NVarChar);
        sql_param[13].Value = COA_nature;
 
        sql_param[14] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[14].Value = BRC_ID;
        
        sql_param[15] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
        sql_param[15].Value = COA_IsDeleted;


         ExeState = obj_dal.ins_del_upd("sp_TBL_COA_insertion", sql_param);

         return ExeState ;

        }
        
        
        
        
        
        public string updation()

        {

              SqlParameter[] sql_param = new SqlParameter[16];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
        sql_param[1] = new SqlParameter("@COA_ID", SqlDbType.Int);
        sql_param[1].Value = COA_ID ;
 
        sql_param[2] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
        sql_param[2].Value = COA_PARENTID ;
 
        sql_param[3] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
        sql_param[3].Value = COA_UID ;
 
        sql_param[4] = new SqlParameter("@COA_prefix", SqlDbType.NVarChar);
        sql_param[4].Value = COA_prefix ;
 
        sql_param[5] = new SqlParameter("@COA_levelID", SqlDbType.Int);
        sql_param[5].Value = COA_levelID ;
 
        sql_param[6] = new SqlParameter("@COA_definationPlanID", SqlDbType.Int);
        sql_param[6].Value = COA_definationPlanID ;
 
        sql_param[7] = new SqlParameter("@COA_Name", SqlDbType.NVarChar);
        sql_param[7].Value = COA_Name ;
 
        sql_param[8] = new SqlParameter("@COA_type", SqlDbType.Int);
        sql_param[8].Value = COA_type ;
 
        sql_param[9] = new SqlParameter("@COA_isActive", SqlDbType.Bit);
        sql_param[9].Value = COA_isActive ;
 
        sql_param[10] = new SqlParameter("@COA_description", SqlDbType.NVarChar);
        sql_param[10].Value = COA_description ;
 
        sql_param[11] = new SqlParameter("@COA_Inventory", SqlDbType.Bit);
        sql_param[11].Value = COA_IsInventory ;
 
        sql_param[12] = new SqlParameter("@COA_levelNo", SqlDbType.Int);
        sql_param[12].Value = COA_levelNo ;
        sql_param[13] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
        sql_param[13].Value = COA_IsTransaction;
        
        sql_param[14] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[14].Value = BRC_ID;

        sql_param[15] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
        sql_param[15].Value = COA_IsDeleted;


        ExeState = obj_dal.ins_del_upd("sp_TBL_COA_updation", sql_param);

        return ExeState ; 
        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[5];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.Int);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
        sql_param[2].Value = @COA_UID;
        sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[3].Value = BRC_ID;
        sql_param[4] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
        sql_param[4].Value = COA_IsDeleted;


         ExeState = obj_dal.ins_del_upd("sp_TBL_COA_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {
            SqlParameter[] sql_param = new SqlParameter[14];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;
            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.Int);
            sql_param[1].Value = CMP_ID;

            sql_param[2] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
            sql_param[2].Value = COA_PARENTID;
            sql_param[3] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
            sql_param[3].Value = COA_UID;
            sql_param[4] = new SqlParameter("@COA_prefix", SqlDbType.NVarChar);
            sql_param[4].Value = COA_prefix;
            sql_param[5] = new SqlParameter("@COA_levelID", SqlDbType.Int);
            sql_param[5].Value = COA_levelID;
            sql_param[6] = new SqlParameter("@COA_definationPlanID", SqlDbType.Int);
            sql_param[6].Value = COA_definationPlanID;
            sql_param[7] = new SqlParameter("@COA_type", SqlDbType.Int);
            sql_param[7].Value = COA_type;
            sql_param[8] = new SqlParameter("@COA_levelNo", SqlDbType.Int);
            sql_param[8].Value = COA_levelNo;
            sql_param[9] = new SqlParameter("@COA_IsInventory", SqlDbType.Bit);
            sql_param[9].Value = COA_IsInventory;
            sql_param[10] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
            sql_param[10].Value = COA_IsDeleted;
            sql_param[11] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
            sql_param[11].Value = COA_IsTransaction;
            sql_param[12] = new SqlParameter("@COA_IsActive", SqlDbType.Bit);
            sql_param[12].Value = COA_isActive;
            sql_param[13] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[13].Value = BRC_ID;

 

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_COA_selection", sql_param);

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
        COA_ID = Convert.ToInt32( dt.Rows[0]["COA_ID"].ToString());
        COA_PARENTID = Convert.ToString( dt.Rows[0]["COA_PARENTID"].ToString());
        COA_UID = Convert.ToString( dt.Rows[0]["COA_UID"].ToString());
        COA_prefix = Convert.ToString( dt.Rows[0]["COA_prefix"].ToString());
        COA_levelID = Convert.ToInt32( dt.Rows[0]["COA_levelID"].ToString());
        COA_definationPlanID = Convert.ToInt32( dt.Rows[0]["COA_definationPlanID"].ToString());
        COA_Name = Convert.ToString( dt.Rows[0]["COA_Name"].ToString());
        COA_type = Convert.ToInt32( dt.Rows[0]["COA_type"].ToString());
        COA_isActive = Convert.ToBoolean( dt.Rows[0]["COA_isActive"].ToString());
        COA_description = Convert.ToString( dt.Rows[0]["COA_description"].ToString());
        COA_IsInventory = Convert.ToBoolean(dt.Rows[0]["COA_IsInventory"].ToString());
        COA_levelNo = Convert.ToInt32( dt.Rows[0]["COA_levelNo"].ToString());
        COA_IsTransaction = Convert.ToBoolean(dt.Rows[0]["COA_IsTransaction"].ToString());
       
        }

        }

        return ds;

        }
        
    }
}
