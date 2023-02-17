using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER
{
    public class cls_ShowFormEntities
    {



          public static string TBL_OPENING_BALANCE(string pID, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE.frm_TBL_OPENING_BALANCE));

                ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE.frm_TBL_OPENING_BALANCE obj_TBL_OPENING_BALANCE = new ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE.frm_TBL_OPENING_BALANCE(pID, isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_OPENING_BALANCE.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_OPENING_BALANCE.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_OPENING_BALANCE.Show();

                            }
                            else
                            {

                                  obj_TBL_OPENING_BALANCE.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_OPENING_BALANCE.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }

          public static string TBL_VCH_MAIN(string pID, bool isParent, bool isUnique, bool isDisturbed, string PtmpVCHPrefix)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Forms.TBL_VCH_MAIN.frm_TBL_VCH_MAIN));

                ACC_PRESENTATION_LAYER.Forms.TBL_VCH_MAIN.frm_TBL_VCH_MAIN obj_TBL_VCH_MAIN = new ACC_PRESENTATION_LAYER.Forms.TBL_VCH_MAIN.frm_TBL_VCH_MAIN(pID, isDisturbed, PtmpVCHPrefix);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_VCH_MAIN.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_VCH_MAIN.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_VCH_MAIN.Show();

                            }
                            else
                            {

                                  obj_TBL_VCH_MAIN.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_VCH_MAIN.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }


          public static string TBL_FINANCIAL_YEAR(string pID, bool isParent, bool isUnique, bool isDisturbed)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Forms.TBL_FINANCIAL_YEAR.frm_TBL_FINANCIAL_YEAR));

                ACC_PRESENTATION_LAYER.Forms.TBL_FINANCIAL_YEAR.frm_TBL_FINANCIAL_YEAR obj_TBL_FINANCIAL_YEAR = new ACC_PRESENTATION_LAYER.Forms.TBL_FINANCIAL_YEAR.frm_TBL_FINANCIAL_YEAR(pID, isDisturbed);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_TBL_FINANCIAL_YEAR.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj_TBL_FINANCIAL_YEAR.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj_TBL_FINANCIAL_YEAR.Show();

                            }
                            else
                            {

                                  obj_TBL_FINANCIAL_YEAR.Show();
                            }
                      }
                      else
                      {
                            obj_TBL_FINANCIAL_YEAR.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }



        static void applyskingToDialog(DevExpress.XtraEditors.XtraForm pForm)
        {
            pForm.LookAndFeel.UseDefaultLookAndFeel = false;
            pForm.LookAndFeel.SkinName = "Office 2010 Silver";
            pForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
    
       }


    }
}
