using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;


namespace DATASET.ACC_DATASET
{
   public class cls_DataSet
    {

          //******************************************  TBL_VCH_MAIN  *****************************************


          public DataSet g_TBL_VCH_MAIN = new DataSet();
          public DataSet f_TBL_VCH_MAIN(string pSTATUS, string pVCH_ID, string pVCH_prefix)
          {

                BLL.ACC_BLL.TBL_VCH_MAIN.cls_TBL_VCH_MAIN obj_cls_TBL_VCH_MAIN = new BLL.ACC_BLL.TBL_VCH_MAIN.cls_TBL_VCH_MAIN();


                obj_cls_TBL_VCH_MAIN.STATUS = pSTATUS;
                obj_cls_TBL_VCH_MAIN.VCH_ID = pVCH_ID;

                obj_cls_TBL_VCH_MAIN.VCH_prefix=pVCH_prefix;


                g_TBL_VCH_MAIN = obj_cls_TBL_VCH_MAIN.selection();
                return g_TBL_VCH_MAIN;

          }



          //******************************************  TBL_FINANCIAL_YEAR  *****************************************


          public DataSet g_TBL_FINANCIAL_YEAR = new DataSet();
          public DataSet f_TBL_FINANCIAL_YEAR(string pSTATUS, string pFINANCIAL_YEAR_ID)
          {

                BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_TBL_FINANCIAL_YEAR obj_cls_TBL_FINANCIAL_YEAR = new BLL.ACC_BLL.TBL_FINANCIAL_YEAR.cls_TBL_FINANCIAL_YEAR();


                obj_cls_TBL_FINANCIAL_YEAR.STATUS = pSTATUS;
                obj_cls_TBL_FINANCIAL_YEAR.FINANCIAL_YEAR_ID = pFINANCIAL_YEAR_ID;


                g_TBL_FINANCIAL_YEAR = obj_cls_TBL_FINANCIAL_YEAR.selection();
                return g_TBL_FINANCIAL_YEAR;

          }



        //******************************************  TBL_ACC_PLAN  *****************************************
       
       public static DataSet g_TBL_ACC_PLAN = new DataSet();
        public DataSet f_TBL_ACC_PLAN(char pSTATUS,  Boolean property_allocation)
        {

            BLL.ACC_BLL.cls_TBL_ACC_PLAN obj_cls_TBL_ACC_PLAN = new BLL.ACC_BLL.cls_TBL_ACC_PLAN();

            obj_cls_TBL_ACC_PLAN.STATUS = pSTATUS;
            obj_cls_TBL_ACC_PLAN.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
            obj_cls_TBL_ACC_PLAN.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
            obj_cls_TBL_ACC_PLAN.gproperty_allocatoin = property_allocation;
            obj_cls_TBL_ACC_PLAN.TBL_ACC_PLAN_MAIN_isDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;
            
            g_TBL_ACC_PLAN = obj_cls_TBL_ACC_PLAN.selection();
            return g_TBL_ACC_PLAN;

        }

      

        
       
       //******************************************  TBL_TYPE_PLAN_MAIN  *****************************************

        public DataSet g_TBL_TYPE_PLAN_MAIN = new DataSet();
        public DataSet f_TBL_TYPE_PLAN_MAIN(char pSTATUS, int pTYPE_PLAN_MAIN_ID, Boolean property_allocation)
        {

            BLL.ACC_BLL.cls_TBL_TYPE_PLAN_MAIN obj_cls_TBL_TYPE_PLAN_MAIN = new BLL.ACC_BLL.cls_TBL_TYPE_PLAN_MAIN();

            obj_cls_TBL_TYPE_PLAN_MAIN.STATUS = pSTATUS;
            obj_cls_TBL_TYPE_PLAN_MAIN.TYPE_PLAN_MAIN_ID = pTYPE_PLAN_MAIN_ID;
            obj_cls_TBL_TYPE_PLAN_MAIN.gproperty_allocatoin = property_allocation;
            obj_cls_TBL_TYPE_PLAN_MAIN.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID; ;
            obj_cls_TBL_TYPE_PLAN_MAIN.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
            obj_cls_TBL_TYPE_PLAN_MAIN.TYPE_PLAN_MAIN_isDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            g_TBL_TYPE_PLAN_MAIN = obj_cls_TBL_TYPE_PLAN_MAIN.selection();
            return g_TBL_TYPE_PLAN_MAIN;

        }





        //******************************************  Get Max  *****************************************

        public int g_GETMAX = 0;
        public int f_GETMAX(string pSTATUS, int pDependent_C1 ,int pDependent_C2 ,int pDependent_C3 , string pDependent_S1 , string pDependent_S2 ,string pDependent_S3  )
        {

            BLL.ACC_BLL.cls_GET_MAX obj_cls_TBL_TYPE_PLAN_MAIN = new BLL.ACC_BLL.cls_GET_MAX();

            obj_cls_TBL_TYPE_PLAN_MAIN.STATUS = pSTATUS;
            obj_cls_TBL_TYPE_PLAN_MAIN.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
            obj_cls_TBL_TYPE_PLAN_MAIN.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
            obj_cls_TBL_TYPE_PLAN_MAIN.isDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_C1 = pDependent_C1;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_C2 = pDependent_C2;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_C3 = pDependent_C2;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_S1 = pDependent_S1;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_S2 = pDependent_S2;
            obj_cls_TBL_TYPE_PLAN_MAIN.Dependent_S3 = pDependent_S3;
            

            g_GETMAX = obj_cls_TBL_TYPE_PLAN_MAIN.getMax();
            return g_GETMAX;

        }


        //******************************************  TBL_COA  *****************************************


        public DataSet g_TBL_COA = new DataSet();
        public DataSet f_TBL_COA(string pSTATUS, string pCOA_PARENTID, string pCOA_UID, string pCOA_prefix, int pCOA_levelID, int pCOA_definationPlanID, int pCOA_type, int pCOA_levelNo, Boolean pCOA_IsInventory, Boolean pCOA_IsDeleted, Boolean pCOA_IsTransaction, Boolean pCOA_IsActive, Boolean property_allocation)
        {

            BLL.ACC_BLL.cls_TBL_COA obj_cls_TBL_COA = new BLL.ACC_BLL.cls_TBL_COA();

            obj_cls_TBL_COA.STATUS = pSTATUS;
            obj_cls_TBL_COA.COA_PARENTID = pCOA_PARENTID;
            obj_cls_TBL_COA.COA_UID = pCOA_UID;
            obj_cls_TBL_COA.COA_prefix = pCOA_prefix;
            obj_cls_TBL_COA.COA_levelID = pCOA_levelID;
            obj_cls_TBL_COA.COA_definationPlanID = pCOA_definationPlanID;
            obj_cls_TBL_COA.COA_type = pCOA_type;
            obj_cls_TBL_COA.COA_levelNo = pCOA_levelNo;
            obj_cls_TBL_COA.COA_IsInventory = pCOA_IsInventory;
            obj_cls_TBL_COA.COA_IsTransaction = pCOA_IsTransaction;
         
            obj_cls_TBL_COA.gproperty_allocatoin = property_allocation;

            g_TBL_COA = obj_cls_TBL_COA.selection();
            return g_TBL_COA;

        }
        public DataSet f_TBL_COA(string pSTATUS, string pCOA_PARENTID, string pCOA_UID, string pCOA_prefix, int pCOA_levelID, int pCOA_definationPlanID, int pCOA_type, int? pCOA_levelNo, Boolean? pCOA_IsInventory, Boolean pCOA_IsDeleted, Boolean? pCOA_IsTransaction, Boolean pCOA_IsActive, Boolean property_allocation)
        {

              BLL.ACC_BLL.cls_TBL_COA obj_cls_TBL_COA = new BLL.ACC_BLL.cls_TBL_COA();

              obj_cls_TBL_COA.STATUS = pSTATUS;
              obj_cls_TBL_COA.COA_PARENTID = pCOA_PARENTID;
              obj_cls_TBL_COA.COA_UID = pCOA_UID;
              obj_cls_TBL_COA.COA_prefix = pCOA_prefix;
              obj_cls_TBL_COA.COA_levelID = pCOA_levelID;
              obj_cls_TBL_COA.COA_definationPlanID = pCOA_definationPlanID;
              obj_cls_TBL_COA.COA_type = pCOA_type;
              obj_cls_TBL_COA.COA_levelNo = pCOA_levelNo;
              obj_cls_TBL_COA.COA_IsInventory = pCOA_IsInventory;
              obj_cls_TBL_COA.COA_IsTransaction = pCOA_IsTransaction;

              obj_cls_TBL_COA.gproperty_allocatoin = property_allocation;

              g_TBL_COA = obj_cls_TBL_COA.selection();
              return g_TBL_COA;

        }


    
   }
}
