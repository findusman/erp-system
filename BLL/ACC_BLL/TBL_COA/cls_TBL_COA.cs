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
       private  int?  cOA_levelNo  = 0;
 
        public  int?  COA_levelNo  
        {
              get { return cOA_levelNo; }
              set {cOA_levelNo = value ; }
        }
 
        private string cOA_nature = string.Empty;

        public string COA_nature
        {
            get { return cOA_nature; }
            set { cOA_nature = value; }
        }
 
        private  bool?  cOA_IsInventory  = false;
        public  bool?  COA_IsInventory  
        {
            get { return cOA_IsInventory; }
            set { cOA_IsInventory = value; }
        }

        private bool? cOA_IsTransaction = null;

        public bool? COA_IsTransaction
        {
            get { return cOA_IsTransaction; }
            set { cOA_IsTransaction = value; }
        }
     
        private bool cOA_isAddedDirectly = true;

        public bool COA_isAddedDirectly
        {
            get { return cOA_isAddedDirectly; }
            set { cOA_isAddedDirectly = value; }
        }

        private bool pCOA_IsRoot;

        public bool COA_IsRoot
        {
            get { return pCOA_IsRoot; }
            set { pCOA_IsRoot = value; }
        }
        private String pCOA_ChildOrSbling;

        public String COA_ChildOrSbling
        {
            get { return pCOA_ChildOrSbling; }
            set { pCOA_ChildOrSbling = value; }
        }


        private String pTBL_ACC_PLAN_MAIN_ID;

        public String TBL_ACC_PLAN_MAIN_ID
        {
            get { return pTBL_ACC_PLAN_MAIN_ID; }
            set { pTBL_ACC_PLAN_MAIN_ID = value; }
        }  

        public DataSet insertionDirect(
            int ptmp_levelNo, 
            string pCOA_PARENTID, 
            string pCOA_UID,
            int pCOA_definationPlanID,
            string pCOA_Name, 
            int pCOA_type, 
            string pCOA_nature, 
            bool pCOA_IsTransaction, 
            string Pstatus, 
            string pChildOrSbling,
            bool pCOA_IsInventory, 
            bool pCOA_isAddedDirectly 
            )
        {
            try
            {
              
                this.COA_PARENTID = pCOA_PARENTID;
                this.COA_UID = pCOA_UID;
                this.COA_levelID = 1;
                this.COA_definationPlanID = pCOA_definationPlanID;// Convert.ToInt16(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[ptmp_levelNo][BLL.ACC_BLL.TBL_ACC_PLAN.cls_CTBL_ACC_PLAN_DEF.priTBL_ACC_PLAN_DEF_ID]); this.COA_Name = pCOA_Name;
                this.COA_Name = pCOA_Name;
                this.COA_type = pCOA_type;
                this.COA_IsInventory = pCOA_IsInventory;
                this.COA_isAddedDirectly = pCOA_isAddedDirectly;
                this.COA_IsRoot = ptmp_levelNo == 0 ? true : false;
                this.COA_ChildOrSbling = ptmp_levelNo == 0 ? "Sibling" : pChildOrSbling;


                if (pCOA_isAddedDirectly)
                            this.COA_IsTransaction = true;
                else if (GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_isTransactionFixed )
                    this.COA_IsTransaction = Convert.ToBoolean(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[ptmp_levelNo][BLL.ACC_BLL.TBL_ACC_PLAN.cls_CTBL_ACC_PLAN_DEF.TBL_ACC_PLAN_DEF_isTransaction]);
                     //else
                     //   this.COA_IsTransaction = pCOA_IsTransaction;
              

                this.COA_nature = pCOA_nature;
                this.STATUS = Pstatus;
                if (Pstatus == "Insertion")
                    return this.insertion();
                else
                    if (Pstatus == "Updation")
                        return this.updation();
            }
            catch (Exception ex)
            {

               // return ex.Message.ToString();

            }
            return null;

        }

        //public DataSet settingValuesThenInsert(int ptmp_levelNo, string pCOA_PARENTID, string pCOA_UID, string pCOA_prefix, int pCOA_levelID,
        //                  string pCOA_Name, int pCOA_type, bool pCOA_isActive, bool pCOA_IsInventory, string pCOA_nature, bool pAllowedDeletion, bool pCOA_isTransaction)
        //{
        //    try
        //    {
        //        DataTable dt = cls_InitiateGrids.dt_COA;

        //        this.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
        //        this.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
        //        this.COA_PARENTID = pCOA_PARENTID;
        //        this.COA_UID = pCOA_UID;
        //        this.COA_levelNo = ptmp_levelNo + 1;
        //        this.COA_levelID = pCOA_levelID;
        //        this.COA_definationPlanID = Convert.ToInt16(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[ptmp_levelNo]["TBL_ACC_PLAN_DEF_ID"]);

        //        this.COA_Name = pCOA_Name;
        //        this.COA_type = pCOA_type;
        //        this.COA_isActive = pCOA_isActive;
        //        this.COA_description = "NA";
        //        this.COA_IsInventory = pCOA_IsInventory;


        //        this.COA_IsTransaction = pCOA_isTransaction;

        //        if (GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_transactionLevel == this.COA_levelNo)
        //            this.COA_IsTransaction = true;
        //        else
        //            this.COA_IsTransaction = false;

        //        this.COA_nature = pCOA_nature;
        //        this.COA_IsDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;
        //        this.STATUS = pStatus;
        //        this.COA_isAddedDirectly = pAllowedDeletion;
        //        return this.insertion();
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message.ToString();

        //    }
        //    return this.insertion();

        //}

        public string settingValuesThenDelete(string pCOA_UID)
        {
            try
            {

                this.STATUS = "D";
                this.COA_UID = pCOA_UID;
                return "";  
                //return this.deletion();

            }
            catch (Exception ex)
            {

                return ex.Message.ToString();

            }


        }


        public DataSet insertion()
        {



            SqlParameter[] sql_param = new SqlParameter[17];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
            sql_param[2].Value = COA_PARENTID;

            sql_param[3] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
            sql_param[3].Value = COA_UID;

            sql_param[4] = new SqlParameter("@COA_definationPlanID", SqlDbType.Int);
            sql_param[4].Value = COA_definationPlanID;

            sql_param[5] = new SqlParameter("@COA_levelID", SqlDbType.Int);
            sql_param[5].Value = COA_levelID;

            sql_param[6] = new SqlParameter("@COA_IsRoot", SqlDbType.Bit);
            sql_param[6].Value = COA_IsRoot;

            sql_param[7] = new SqlParameter("@COA_ChildOrSbling", SqlDbType.NVarChar);
            sql_param[7].Value = COA_ChildOrSbling;

            sql_param[8] = new SqlParameter("@COA_Name", SqlDbType.NVarChar);
            sql_param[8].Value = COA_Name;

            sql_param[9] = new SqlParameter("@COA_type", SqlDbType.Int);
            sql_param[9].Value = COA_type;

            sql_param[10] = new SqlParameter("@COA_IsInventory", SqlDbType.Bit);
            sql_param[10].Value = COA_IsInventory;

            sql_param[11] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
            sql_param[11].Value = COA_IsTransaction;

            sql_param[12] = new SqlParameter("@COA_nature", SqlDbType.NVarChar);
            sql_param[12].Value = COA_nature;

            sql_param[13] = new SqlParameter("@COA_isAddedDirectly", SqlDbType.Bit);
            sql_param[13].Value = COA_isAddedDirectly;

            sql_param[14] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
            sql_param[14].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[15] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[15].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;
            
            sql_param[16] = new SqlParameter("@TBL_ACC_PLAN_MAIN_ID", SqlDbType.NVarChar);
            sql_param[16].Value = GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_ID;

          




            DataSet ds = new System.Data.DataSet();

            ds = obj_dal.selection("sp_TBL_COA_insertion", sql_param);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds,0))
                return null;
            else
                return ds;

        }
        public DataSet updation()
        {

            SqlParameter[] sql_param = new SqlParameter[9];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
            sql_param[2].Value = COA_UID;

            sql_param[3] = new SqlParameter("@COA_Name", SqlDbType.NVarChar);
            sql_param[3].Value = COA_Name;

            sql_param[4] = new SqlParameter("@COA_type", SqlDbType.Int);
            sql_param[4].Value = COA_type;

            sql_param[5] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
            sql_param[5].Value = COA_IsTransaction;

            sql_param[6] = new SqlParameter("@COA_nature", SqlDbType.NVarChar);
            sql_param[6].Value = COA_nature;

            sql_param[7] = new SqlParameter("@COA_isDeleted", SqlDbType.Bit);
            sql_param[7].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[8] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[8].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                





            DataSet ds = new System.Data.DataSet();

            ds = obj_dal.selection("sp_TBL_COA_updation", sql_param);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                return null;
            else
                return ds;

        }

        //public string updation()

        //{

        //      SqlParameter[] sql_param = new SqlParameter[17];
 
        //sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        //sql_param[0].Value = CMP_ID ;
 
        //sql_param[1] = new SqlParameter("@COA_ID", SqlDbType.Int);
        //sql_param[1].Value = COA_ID ;
 
        //sql_param[2] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
        //sql_param[2].Value = COA_PARENTID ;
 
        //sql_param[3] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
        //sql_param[3].Value = COA_UID ;
 
        //sql_param[4] = new SqlParameter("@COA_prefix", SqlDbType.NVarChar);
        //sql_param[4].Value = COA_prefix ;
 
        //sql_param[5] = new SqlParameter("@COA_levelID", SqlDbType.Int);
        //sql_param[5].Value = COA_levelID ;
 
        //sql_param[6] = new SqlParameter("@COA_definationPlanID", SqlDbType.Int);
        //sql_param[6].Value = COA_definationPlanID ;
 
        //sql_param[7] = new SqlParameter("@COA_Name", SqlDbType.NVarChar);
        //sql_param[7].Value = COA_Name ;
 
        //sql_param[8] = new SqlParameter("@COA_type", SqlDbType.Int);
        //sql_param[8].Value = COA_type ;
 
        //sql_param[9] = new SqlParameter("@COA_isActive", SqlDbType.Bit);
        //sql_param[9].Value = COA_isActive ;
 
        //sql_param[10] = new SqlParameter("@COA_description", SqlDbType.NVarChar);
        //sql_param[10].Value = COA_description ;
 
        //sql_param[11] = new SqlParameter("@COA_Inventory", SqlDbType.Bit);
        //sql_param[11].Value = COA_IsInventory ;
 
        //sql_param[12] = new SqlParameter("@COA_levelNo", SqlDbType.Int);
        //sql_param[12].Value = COA_levelNo ;
        //sql_param[13] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
        //sql_param[13].Value = COA_IsTransaction;
        
        //sql_param[14] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        //sql_param[14].Value = BRC_ID;

        //sql_param[15] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
        //sql_param[15].Value = COA_IsDeleted;

        //sql_param[16] = new SqlParameter("@COA_isAddedDirectly", SqlDbType.Bit);
        //sql_param[16].Value = COA_isAddedDirectly;

        //ExeState = obj_dal.ins_del_upd("sp_TBL_COA_updation", sql_param);

        //return ExeState ; 
        //}
        //public string deletion()
        //{
        //    DataSet ds = new System.Data.DataSet();
        //SqlParameter[] sql_param = new SqlParameter[5];
 
        //sql_param[0] = new SqlParameter("@STATUS", SqlDbType.Char);
        //sql_param[0].Value = STATUS ;
        //sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        //sql_param[1].Value = CMP_ID ;
        //sql_param[2] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
        //sql_param[2].Value = @COA_UID;
        //sql_param[3] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        //sql_param[3].Value = BRC_ID;
        //sql_param[4] = new SqlParameter("@COA_IsDeleted", SqlDbType.Bit);
        //sql_param[4].Value = COA_IsDeleted;

        ////sql_param[5] = new SqlParameter("@COA_isAddedDirectly", SqlDbType.Bit);
        ////sql_param[5].Value = COA_isAddedDirectly;

        //ds = obj_dal.selection("sp_TBL_COA_deletion", sql_param);

        //ExeState = ds.Tables[0].Rows[0][0].ToString();//obj_dal.ins_del_upd("sp_TBL_COA_deletion", sql_param);
        //return ExeState ;

        //}
        
        public DataSet selection()
        {
            SqlParameter[] sql_param = new SqlParameter[12];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;

            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[3] = new SqlParameter("@COA_PARENTID", SqlDbType.NVarChar);
            sql_param[3].Value = COA_PARENTID;

            sql_param[4] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
            sql_param[4].Value = COA_UID;

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
            sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[11] = new SqlParameter("@COA_IsTransaction", SqlDbType.Bit);
            sql_param[11].Value = COA_IsTransaction;



        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_COA_selection", sql_param);

        return ds;

        }

        public string deletion()
        {

            SqlParameter[] sql_param = new SqlParameter[5];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;

            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[3] = new SqlParameter("@COA_UID", SqlDbType.NVarChar);
            sql_param[3].Value = COA_UID;

            sql_param[4] = new SqlParameter("@COA_isDeleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;


            DataSet ds = new System.Data.DataSet();

            ds = obj_dal.selection("sp_TBL_COA_deletion", sql_param);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                return null;
            else
                ExeState = ds.Tables[0].Rows[0][0].ToString();
            
                return ExeState;
            

        }


    }
}
