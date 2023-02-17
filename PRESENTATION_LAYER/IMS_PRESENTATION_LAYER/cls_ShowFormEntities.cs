using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER
{
    public class cls_ShowFormEntities
    {


        public static string TBL_SUPPLIERS_TMP(string pID, bool isParent, bool isUnique, bool isDisturbed)
        {

            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS_TMP.frm_TBL_SUPPLIERS_TMP));

            IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS_TMP.frm_TBL_SUPPLIERS_TMP obj_TBL_SUPPLIERS_TMP = new IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS_TMP.frm_TBL_SUPPLIERS_TMP(pID, isDisturbed);
            bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_SUPPLIERS_TMP.Name, "G");
            if (isOk)
            {
                if (isParent)
                {
                    obj_TBL_SUPPLIERS_TMP.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                    if (isUnique)
                    {

                        if (!isFormOpen)
                            obj_TBL_SUPPLIERS_TMP.Show();

                    }
                    else
                    {

                        obj_TBL_SUPPLIERS_TMP.Show();
                    }
                }
                else
                {
                    obj_TBL_SUPPLIERS_TMP.ShowDialog();
                }
                return "ok";

            }
            else
            {
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                return objcls_MessageBox.error_notAllowedToOpenScreen;
            }
        }




        public static string TBL_PURCHASE_AND_RETURN_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed, string pPURCHASE_AND_RETURN_MAIN_cashOrCredit, string pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_PURCHASE_AND_RETURN_MAIN.frm_TBL_PURCHASE_AND_RETURN_MAIN));

                IMS_PRESENTATION_LAYER.Forms.TBL_PURCHASE_AND_RETURN_MAIN.frm_TBL_PURCHASE_AND_RETURN_MAIN obj_TBL_PURCHASE_AND_RETURN_MAIN = new IMS_PRESENTATION_LAYER.Forms.TBL_PURCHASE_AND_RETURN_MAIN.frm_TBL_PURCHASE_AND_RETURN_MAIN(pID, isDisturbed,  pPURCHASE_AND_RETURN_MAIN_cashOrCredit,  pPURCHASE_AND_RETURN_MAIN_purchaseOrReturn);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_PURCHASE_AND_RETURN_MAIN.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_PURCHASE_AND_RETURN_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_PURCHASE_AND_RETURN_MAIN.Show();

                            }
                            else
                            {

                                  obj_TBL_PURCHASE_AND_RETURN_MAIN.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_PURCHASE_AND_RETURN_MAIN.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }

          public static string TBL_SALES_AND_RETURN_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed, string pSALES_AND_RETURN_MAIN_cashOrCredit, string pSALES_AND_RETURN_MAIN_SALESOrReturn)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Forms.TBL_SALES_AND_RETURN_MAIN.frm_TBL_SALES_AND_RETURN_MAIN));

                IMS_PRESENTATION_LAYER.Forms.TBL_SALES_AND_RETURN_MAIN.frm_TBL_SALES_AND_RETURN_MAIN obj_TBL_SALES_AND_RETURN_MAIN = new IMS_PRESENTATION_LAYER.Forms.TBL_SALES_AND_RETURN_MAIN.frm_TBL_SALES_AND_RETURN_MAIN(pID, isDisturbed, pSALES_AND_RETURN_MAIN_cashOrCredit, pSALES_AND_RETURN_MAIN_SALESOrReturn);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_SALES_AND_RETURN_MAIN.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_SALES_AND_RETURN_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_SALES_AND_RETURN_MAIN.Show();

                            }
                            else
                            {

                                  obj_TBL_SALES_AND_RETURN_MAIN.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_SALES_AND_RETURN_MAIN.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }
    
    
    
    
    }
}
