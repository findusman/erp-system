using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
//using IMS_BLL;
//using IMS_BLL.PO;


namespace DATASET.IMS_DATASET
{
    public class cls_DataSet
    {


        //******************************************  TBL_SUPPLIERS_TMP  *****************************************


        public DataSet g_TBL_SUPPLIERS_TMP = new DataSet();
        public DataSet f_TBL_SUPPLIERS_TMP(string pSTATUS, string pSUPPLIER_ID)
        {

            BLL.IMS_BLL.TBL_SUPPLIERS_TMP.cls_TBL_SUPPLIERS_TMP obj_cls_TBL_SUPPLIERS_TMP = new BLL.IMS_BLL.TBL_SUPPLIERS_TMP.cls_TBL_SUPPLIERS_TMP();


            obj_cls_TBL_SUPPLIERS_TMP.STATUS = pSTATUS;
            obj_cls_TBL_SUPPLIERS_TMP.SUPPLIER_ID = pSUPPLIER_ID;


            g_TBL_SUPPLIERS_TMP = obj_cls_TBL_SUPPLIERS_TMP.selection();
            return g_TBL_SUPPLIERS_TMP;

        }




        //******************************************  TBL_RASHID  *****************************************


        public DataSet g_TBL_RASHID = new DataSet();
          public DataSet f_TBL_RASHID(string pSTATUS, string pRASHID_ID)
          {

                BLL.GEN_BLL.TBL_RASHID.cls_TBL_RASHID obj_cls_TBL_RASHID = new BLL.GEN_BLL.TBL_RASHID.cls_TBL_RASHID();


                obj_cls_TBL_RASHID.STATUS = pSTATUS;
                obj_cls_TBL_RASHID.RASHID_ID = pRASHID_ID;


                g_TBL_RASHID = obj_cls_TBL_RASHID.selection();
                return g_TBL_RASHID;

          }



          //******************************************  TBL_SALES_AND_RETURN_MAIN  *****************************************


          public DataSet g_TBL_SALES_AND_RETURN_MAIN = new DataSet();
          public DataSet f_TBL_SALES_AND_RETURN_MAIN(string pSTATUS, string pSALES_AND_RETURN_MAIN_ID, string pSALES_AND_RETURN_MAIN_cashOrCredit, string pSALES_AND_RETURN_MAIN_SALESOrReturn)
          {

                BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN.cls_TBL_SALES_AND_RETURN_MAIN obj_cls_TBL_SALES_AND_RETURN_MAIN = new BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN.cls_TBL_SALES_AND_RETURN_MAIN();


                obj_cls_TBL_SALES_AND_RETURN_MAIN.STATUS = pSTATUS;
                obj_cls_TBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_MAIN_ID = pSALES_AND_RETURN_MAIN_ID;
                obj_cls_TBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_MAIN_cashOrCredit = pSALES_AND_RETURN_MAIN_cashOrCredit;
                obj_cls_TBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_MAIN_SALESOrReturn = pSALES_AND_RETURN_MAIN_SALESOrReturn;


                g_TBL_SALES_AND_RETURN_MAIN = obj_cls_TBL_SALES_AND_RETURN_MAIN.selection();
                return g_TBL_SALES_AND_RETURN_MAIN;

          }

          //******************************************  TBL_PURCHASE_AND_RETURN_MAIN  *****************************************


          public DataSet g_TBL_PURCHASE_AND_RETURN_MAIN = new DataSet();
          public DataSet f_TBL_PURCHASE_AND_RETURN_MAIN(string pSTATUS, string pPURCHASE_AND_RETURN_MAIN_ID, string pPURCHASE_AND_RETURN_MAIN_cashOrCredit, string pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn)
          {

                BLL.IMS_BLL.TBL_PURCHASE_AND_RETURN_MAIN.cls_TBL_PURCHASE_AND_RETURN_MAIN obj_cls_TBL_PURCHASE_AND_RETURN_MAIN = new BLL.IMS_BLL.TBL_PURCHASE_AND_RETURN_MAIN.cls_TBL_PURCHASE_AND_RETURN_MAIN();


                obj_cls_TBL_PURCHASE_AND_RETURN_MAIN.STATUS = pSTATUS;
                obj_cls_TBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_MAIN_ID = pPURCHASE_AND_RETURN_MAIN_ID;
                obj_cls_TBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_MAIN_cashOrCredit = pPURCHASE_AND_RETURN_MAIN_cashOrCredit;
                obj_cls_TBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_MAIN_purchaseOrReturn = pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn;


                g_TBL_PURCHASE_AND_RETURN_MAIN = obj_cls_TBL_PURCHASE_AND_RETURN_MAIN.selection();
                return g_TBL_PURCHASE_AND_RETURN_MAIN;

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



        //******************************************  TBL_PACKINGS_MAIN  *****************************************


        public DataSet g_TBL_PACKINGS_MAIN = new DataSet();
        public DataSet f_TBL_PACKINGS_MAIN(string pSTATUS, string pPACKING_MAIN_ID)
        {

            BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_TBL_PACKINGS_MAIN obj_cls_TBL_PACKINGS_MAIN = new BLL.IMS_BLL.TBL_PACKINGS_MAIN.cls_TBL_PACKINGS_MAIN();


            obj_cls_TBL_PACKINGS_MAIN.STATUS = pSTATUS;
            obj_cls_TBL_PACKINGS_MAIN.PACKING_MAIN_ID = pPACKING_MAIN_ID;


            g_TBL_PACKINGS_MAIN = obj_cls_TBL_PACKINGS_MAIN.selection();
            return g_TBL_PACKINGS_MAIN;

        }

        //******************************************  TBL_PACKINGS_DEF  *****************************************


        public DataSet g_TBL_PACKINGS_DEF = new DataSet();
        public DataSet f_TBL_PACKINGS_DEF(string pSTATUS, string pPACKING_DEF_ID)
        {

            BLL.IMS_BLL.TBL_PACKINGS_DEF.cls_TBL_PACKINGS_DEF obj_cls_TBL_PACKINGS_DEF = new BLL.IMS_BLL.TBL_PACKINGS_DEF.cls_TBL_PACKINGS_DEF();


            obj_cls_TBL_PACKINGS_DEF.STATUS = pSTATUS;
            obj_cls_TBL_PACKINGS_DEF.PACKING_DEF_ID = pPACKING_DEF_ID;


            g_TBL_PACKINGS_DEF = obj_cls_TBL_PACKINGS_DEF.selection();
            return g_TBL_PACKINGS_DEF;

        }




        //******************************************  TBL_PRODUCTS  *****************************************


        public DataSet g_TBL_PRODUCTS = new DataSet();
        public DataSet f_TBL_PRODUCTS(string pSTATUS, string pPRODUCT_ID)
        {

            BLL.IMS_BLL.TBL_PRODUCTS.cls_TBL_PRODUCTS obj_cls_TBL_PRODUCTS = new BLL.IMS_BLL.TBL_PRODUCTS.cls_TBL_PRODUCTS();


            obj_cls_TBL_PRODUCTS.STATUS = pSTATUS;
            obj_cls_TBL_PRODUCTS.PRODUCT_ID = pPRODUCT_ID;


            g_TBL_PRODUCTS = obj_cls_TBL_PRODUCTS.selection();
            return g_TBL_PRODUCTS;

        }


        //******************************************  TBL_SUPPLIERS  *****************************************


        public DataSet g_TBL_SUPPLIERS = new DataSet();
        public DataSet f_TBL_SUPPLIERS(string pSTATUS, string pSUPPLIER_ID)
        {

            BLL.IMS_BLL.TBL_SUPPLIERS.cls_TBL_SUPPLIERS obj_cls_TBL_SUPPLIERS = new BLL.IMS_BLL.TBL_SUPPLIERS.cls_TBL_SUPPLIERS();


            obj_cls_TBL_SUPPLIERS.STATUS = pSTATUS;
            obj_cls_TBL_SUPPLIERS.SUPPLIER_ID = pSUPPLIER_ID;


            g_TBL_SUPPLIERS = obj_cls_TBL_SUPPLIERS.selection();
            return g_TBL_SUPPLIERS;

        }


        //******************************************  TBL_CUSTOMERS  *****************************************


        public DataSet g_TBL_CUSTOMERS = new DataSet();
        public DataSet f_TBL_CUSTOMERS(string pSTATUS, string pCUSTOMER_ID)
        {

            BLL.IMS_BLL.TBL_CUSTOMERS.cls_TBL_CUSTOMERS obj_cls_TBL_CUSTOMERS = new BLL.IMS_BLL.TBL_CUSTOMERS.cls_TBL_CUSTOMERS();


            obj_cls_TBL_CUSTOMERS.STATUS = pSTATUS;
            obj_cls_TBL_CUSTOMERS.CUSTOMER_ID = pCUSTOMER_ID;


            g_TBL_CUSTOMERS = obj_cls_TBL_CUSTOMERS.selection();
            return g_TBL_CUSTOMERS;

        }


        //******************************************  TBL_VEHICLE_MAKERS  *****************************************


        public DataSet g_TBL_VEHICLE_MAKERS = new DataSet();
        public DataSet f_TBL_VEHICLE_MAKERS(string pSTATUS, string pVEHICLE_MAKER_ID)
        {

            BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_TBL_VEHICLE_MAKERS obj_cls_TBL_VEHICLE_MAKERS = new BLL.IMS_BLL.TBL_VEHICLE_MAKERS.cls_TBL_VEHICLE_MAKERS();


            obj_cls_TBL_VEHICLE_MAKERS.STATUS = pSTATUS;
            obj_cls_TBL_VEHICLE_MAKERS.VEHICLE_MAKER_ID = pVEHICLE_MAKER_ID;


            g_TBL_VEHICLE_MAKERS = obj_cls_TBL_VEHICLE_MAKERS.selection();
            return g_TBL_VEHICLE_MAKERS;

        }


        //******************************************  TBL_DEPARTMENTS  *****************************************


        public DataSet g_TBL_DEPARTMENTS = new DataSet();
        public DataSet f_TBL_DEPARTMENTS(string pSTATUS, string pDEPARTMENT_ID)
        {

            BLL.IMS_BLL.TBL_DEPARTMENTS.cls_TBL_DEPARTMENTS obj_cls_TBL_DEPARTMENTS = new BLL.IMS_BLL.TBL_DEPARTMENTS.cls_TBL_DEPARTMENTS();


            obj_cls_TBL_DEPARTMENTS.STATUS = pSTATUS;
            obj_cls_TBL_DEPARTMENTS.DEPARTMENT_ID = pDEPARTMENT_ID;


            g_TBL_DEPARTMENTS = obj_cls_TBL_DEPARTMENTS.selection();
            return g_TBL_DEPARTMENTS;

        }


        //******************************************  TBL_UNITS  *****************************************


        public DataSet g_TBL_UNITS = new DataSet();
        public DataSet f_TBL_UNITS(string pSTATUS, string pUNIT_ID)
        {

            BLL.IMS_BLL.TBL_UNITS.cls_TBL_UNITS obj_cls_TBL_UNITS = new BLL.IMS_BLL.TBL_UNITS.cls_TBL_UNITS();


            obj_cls_TBL_UNITS.STATUS = pSTATUS;
            obj_cls_TBL_UNITS.UNIT_ID = pUNIT_ID;


            g_TBL_UNITS = obj_cls_TBL_UNITS.selection();
            return g_TBL_UNITS;

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

            BLL.IMS_BLL.cls_GET_MAX obj_cls_TBL_TYPE_PLAN_MAIN = new BLL.IMS_BLL.cls_GET_MAX();

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


      













       








          //******************************************  TBL_IA  *****************************************


        public DataSet g_TBL_IA = new DataSet();
        public DataSet f_TBL_IA(char pSTATUS, string pIA_ID, Boolean property_allocation)
        {

            BLL.IMS_BLL.cls_TBL_IA obj_cls_TBL_IA = new BLL.IMS_BLL.cls_TBL_IA();

            obj_cls_TBL_IA.STATUS = pSTATUS;
            obj_cls_TBL_IA.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
            obj_cls_TBL_IA.IA_ID = pIA_ID;
            obj_cls_TBL_IA.gproperty_allocatoin = property_allocation;
            obj_cls_TBL_IA.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            g_TBL_IA = obj_cls_TBL_IA.selection();
            return g_TBL_IA;

        }



      



       


     

       
   

   

      

    

    }
}