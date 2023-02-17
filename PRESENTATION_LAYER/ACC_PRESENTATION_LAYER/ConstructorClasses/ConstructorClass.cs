using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.ConstructorClasses
{
    public class ConstructorClass
    {
        public static string GV_DefaultAccoutnKey = "";
        public void InitiateACC()
        {


            DATASET.ACC_DATASET.cls_DataSet objcls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
            objcls_DataSet.f_TBL_ACC_PLAN('A', false);

            GEN.ACC_GEN.Generics.cls_GInitiateACC objcls_GInitiateACC = new GEN.ACC_GEN.Generics.cls_GInitiateACC();
            objcls_GInitiateACC.initiateCAOPlan(DATASET.ACC_DATASET.cls_DataSet.g_TBL_ACC_PLAN);

            objcls_DataSet.f_TBL_TYPE_PLAN_MAIN('A', GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_ID, false);
            objcls_GInitiateACC.InitiateCAOtypes(objcls_DataSet.g_TBL_TYPE_PLAN_MAIN);
            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DefaultFromDate = System.DateTime.Now.AddMonths(-1);
            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DefaultToDate = System.DateTime.Now;

        }
        public void initiateDefaultCOA(string pDefaultAccountKey)
        {

            DATASET.GEN_DATASET.cls_DataSet objcls_DATASET = new DATASET.GEN_DATASET.cls_DataSet();
            objcls_DATASET.f_TBL_DEFAULT_ACCT("V", pDefaultAccountKey, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, 0, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);

            GEN.ACC_GEN.Generics.cls_DefaultCOA objcls_DefaultCOA = new GEN.ACC_GEN.Generics.cls_DefaultCOA();
            objcls_DefaultCOA.initiateCOA(objcls_DATASET.g_TBL_DEFAULT_ACCT);
        }

        public void initiateCOA()
        {

            DATASET.ACC_DATASET.cls_DataSet objcls_DATASET = new DATASET.ACC_DATASET.cls_DataSet();
            objcls_DATASET.f_TBL_COA("A_Type", "","", "", 0, 0,0,0,false,false,false,false,false);

            PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA = objcls_DATASET.g_TBL_COA.Tables[0];
            
        }

    }
}
