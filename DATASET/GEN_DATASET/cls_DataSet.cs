using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//using GEN_BLL;
//using BLL.GEN_BLL;

namespace DATASET.GEN_DATASET
{
    public class cls_DataSet
    {

          //******************************************  TBL_BRC  *****************************************


          public DataSet g_TBL_BRC = new DataSet();
          public DataSet f_TBL_BRC(string pSTATUS, string pBRC_ID)
          {

                BLL.GEN_BLL.TBL_BRC.cls_TBL_BRC obj_cls_TBL_BRC = new BLL.GEN_BLL.TBL_BRC.cls_TBL_BRC();


                obj_cls_TBL_BRC.STATUS = pSTATUS;
                obj_cls_TBL_BRC.BRC_ID = pBRC_ID;


                g_TBL_BRC = obj_cls_TBL_BRC.selection();
                return g_TBL_BRC;

          }



          //******************************************  TBL_CMP  *****************************************


          public DataSet g_TBL_CMP = new DataSet();
          public DataSet f_TBL_CMP(string pSTATUS, string pCMP_ID)
          {

                BLL.GEN_BLL.TBL_CMP.cls_TBL_CMP obj_cls_TBL_CMP = new BLL.GEN_BLL.TBL_CMP.cls_TBL_CMP();


                obj_cls_TBL_CMP.STATUS = pSTATUS;
                obj_cls_TBL_CMP.CMP_ID = pCMP_ID;


                g_TBL_CMP = obj_cls_TBL_CMP.selection();
                return g_TBL_CMP;

          }


          //******************************************  TBL_USERS  *****************************************


          public DataSet g_TBL_USERS = new DataSet();
          public DataSet f_TBL_USERS(string pSTATUS, string pUSERS_ID)
          {

                BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS obj_cls_TBL_USERS = new BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS();


                obj_cls_TBL_USERS.STATUS = pSTATUS;
                obj_cls_TBL_USERS.USERS_ID = pUSERS_ID;


                g_TBL_USERS = obj_cls_TBL_USERS.selection();
                return g_TBL_USERS;

          }


          //******************************************  TBL_RIGHTS_MAIN  *****************************************


          public DataSet g_TBL_RIGHTS_MAIN = new DataSet();
          public DataSet f_TBL_RIGHTS_MAIN(string pSTATUS, string pRIGHTS_MAIN_ID, string pRIGHTS_MAIN_rightAssigner)
          {

                BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_TBL_RIGHTS_MAIN obj_cls_TBL_RIGHTS_MAIN = new BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_TBL_RIGHTS_MAIN();


                obj_cls_TBL_RIGHTS_MAIN.STATUS = pSTATUS;
                obj_cls_TBL_RIGHTS_MAIN.RIGHTS_MAIN_ID = pRIGHTS_MAIN_ID;
                obj_cls_TBL_RIGHTS_MAIN.RIGHTS_MAIN_rightAssigner = pRIGHTS_MAIN_rightAssigner;


                g_TBL_RIGHTS_MAIN = obj_cls_TBL_RIGHTS_MAIN.selection();
                return g_TBL_RIGHTS_MAIN;

          }


          //******************************************  TBL_RIGHTS_TEMPLATE  *****************************************


          public DataSet g_TBL_RIGHTS_TEMPLATE = new DataSet();
          public DataSet f_TBL_RIGHTS_TEMPLATE(string pSTATUS, string pRIGHTS_TEMPLATE_ID)
          {

                BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_TBL_RIGHTS_TEMPLATE obj_cls_TBL_RIGHTS_TEMPLATE = new BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE.cls_TBL_RIGHTS_TEMPLATE();


                obj_cls_TBL_RIGHTS_TEMPLATE.STATUS = pSTATUS;
                obj_cls_TBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_ID = pRIGHTS_TEMPLATE_ID;


                g_TBL_RIGHTS_TEMPLATE = obj_cls_TBL_RIGHTS_TEMPLATE.selection();
                return g_TBL_RIGHTS_TEMPLATE;

          }



                //******************************************  TBL_TEMP_MAIN  *****************************************


                public DataSet g_TBL_TEMP_MAIN = new DataSet();
                public DataSet f_TBL_TEMP_MAIN(string pSTATUS, string pTEMP_MAIN_ID)
                {

                            BLL.GEN_BLL.TBL_TEMP_MAIN.cls_TBL_TEMP_MAIN obj_cls_TBL_TEMP_MAIN = new BLL.GEN_BLL.TBL_TEMP_MAIN.cls_TBL_TEMP_MAIN();


                            obj_cls_TBL_TEMP_MAIN.STATUS = pSTATUS;
                            obj_cls_TBL_TEMP_MAIN.TEMP_MAIN_ID = pTEMP_MAIN_ID;


                            g_TBL_TEMP_MAIN = obj_cls_TBL_TEMP_MAIN.selection();
                            return g_TBL_TEMP_MAIN;

                }


        //******************************************  TBL_KEY  *****************************************


        public DataSet g_TBL_KEY = new DataSet();
        public DataSet f_TBL_KEY(string pSTATUS, string pKEY_ID)
        {

            BLL.GEN_BLL.TBL_KEY.cls_TBL_KEY obj_cls_TBL_KEY = new BLL.GEN_BLL.TBL_KEY.cls_TBL_KEY();


            obj_cls_TBL_KEY.STATUS = pSTATUS;
            obj_cls_TBL_KEY.KEY_ID = pKEY_ID;


            g_TBL_KEY = obj_cls_TBL_KEY.selection();
            return g_TBL_KEY;

        }


        //******************************************  TBL_KEYS_TYPES  *****************************************


        public DataSet g_TBL_KEYS_TYPES = new DataSet();
        public DataSet f_TBL_KEYS_TYPES(string pSTATUS, string pKEYS_TYPES_ID)
        {

            BLL.GEN_BLL.TBL_KEYS_TYPES.cls_TBL_KEYS_TYPES obj_cls_TBL_KEYS_TYPES = new BLL.GEN_BLL.TBL_KEYS_TYPES.cls_TBL_KEYS_TYPES();


            obj_cls_TBL_KEYS_TYPES.STATUS = pSTATUS;
            obj_cls_TBL_KEYS_TYPES.KEYS_TYPES_ID = pKEYS_TYPES_ID;


            g_TBL_KEYS_TYPES = obj_cls_TBL_KEYS_TYPES.selection();
            return g_TBL_KEYS_TYPES;

        }



    
        //******************************************  Get Max  *****************************************


        public int g_GETMAX = 0;
        public int f_GETMAX(string pSTATUS, int pDependent_C1, int pDependent_C2, int pDependent_C3, string pDependent_S1, string pDependent_S2, string pDependent_S3)
        {

            BLL.GEN_BLL.cls_GET_MAX obj_cls_TBL_TYPE_PLAN_MAIN = new BLL.GEN_BLL.cls_GET_MAX();

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

    
    
      


     

     

    

        //******************************************  TBL_IMG  *****************************************


        public DataSet g_TBL_IMG = new DataSet();
        public DataSet f_TBL_IMG(String pSTATUS, string pCMP_ID, string pBRC_ID, string pIMG_ID, bool pIMG_isActive, bool pIMG_isDeleted, Boolean property_allocation)
        {

            BLL.GEN_BLL.cls_TBL_IMG obj_cls_TBL_IMG = new BLL.GEN_BLL.cls_TBL_IMG();

            obj_cls_TBL_IMG.STATUS = pSTATUS;
            obj_cls_TBL_IMG.CMP_ID = pCMP_ID;
            obj_cls_TBL_IMG.BRC_ID = pBRC_ID;
            obj_cls_TBL_IMG.IMG_ID = pIMG_ID;
            obj_cls_TBL_IMG.IMG_isActive = pIMG_isActive;
            obj_cls_TBL_IMG.IMG_isDeleted = pIMG_isDeleted;
            obj_cls_TBL_IMG.gproperty_allocatoin = property_allocation;

            g_TBL_IMG = obj_cls_TBL_IMG.selection();
            return g_TBL_IMG;

        }

    

        //******************************************  TBL_DEFAULT_ACCT  *****************************************


        public DataSet g_TBL_DEFAULT_ACCT = new DataSet();
        public DataSet f_TBL_DEFAULT_ACCT(String pSTATUS, string pDEFAULT_ACCT_KEY, string pCMP_ID, string pBRC_ID, int pDEFAULT_ACCT_ID, bool pDEFAULT_ACCT_isDeleted, Boolean property_allocation)
        {
            BLL.GEN_BLL.cls_TBL_DEFAULT_ACCT obj_cls_TBL_DEFAULT_ACCT = new BLL.GEN_BLL.cls_TBL_DEFAULT_ACCT();

            obj_cls_TBL_DEFAULT_ACCT.STATUS = pSTATUS;
            obj_cls_TBL_DEFAULT_ACCT.CMP_ID = pCMP_ID;
            obj_cls_TBL_DEFAULT_ACCT.BRC_ID = pBRC_ID;
            obj_cls_TBL_DEFAULT_ACCT.DEFAULT_ACCT_ID = pDEFAULT_ACCT_ID;
            obj_cls_TBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY = pDEFAULT_ACCT_KEY;
            obj_cls_TBL_DEFAULT_ACCT.DEFAULT_ACCT_isDeleted = pDEFAULT_ACCT_isDeleted;
            obj_cls_TBL_DEFAULT_ACCT.gproperty_allocatoin = property_allocation;

            g_TBL_DEFAULT_ACCT = obj_cls_TBL_DEFAULT_ACCT.selection();
            return g_TBL_DEFAULT_ACCT;
        }
      






      


    }
}
