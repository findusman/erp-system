using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER
{
      public class cls_ShowReportEntities
    {



             
            public static string Ledger(string pID, bool isParent, bool isUnique)
          {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger));

                ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger obj = new ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger();
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj.Name, "G");
                if (isOk)
                {
                      if (isParent)
                      {
                            obj.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                            if (isUnique)
                            {

                                  if (!isFormOpen)
                                        obj.Show();

                            }
                            else
                            {

                                  obj.Show();
                            }
                      }
                      else
                      {
                            obj.ShowDialog();
                      }
                      return "ok";

                }
                else
                {
                      GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                      return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
          }
            public static string Ledger(string pID, DateTime dtFrom,DateTime toFrom, bool isParent, bool isUnique)
            {

                bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger));

                ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger obj = new ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger(pID, dtFrom,toFrom);
                bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj.Name, "G");
                if (isOk)
                {
                    if (isParent)
                    {
                        obj.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                        if (isUnique)
                        {

                            if (!isFormOpen)
                                obj.Show();

                        }
                        else
                        {

                            obj.Show();
                        }
                    }
                    else
                    {
                        obj.ShowDialog();
                    }
                    return "ok";

                }
                else
                {
                    GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                    return objcls_MessageBox.error_notAllowedToOpenScreen;
                }
            }
            public static string TrialBalance(string pID, bool isParent, bool isUnique)
            {

                  bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Reports.TrialBalance.frm_rpt_TrialBalance));

                  ACC_PRESENTATION_LAYER.Reports.TrialBalance.frm_rpt_TrialBalance obj = new ACC_PRESENTATION_LAYER.Reports.TrialBalance.frm_rpt_TrialBalance();
                  bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj.Name, "G");
                  if (isOk)
                  {
                        if (isParent)
                        {
                              obj.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                              if (isUnique)
                              {

                                    if (!isFormOpen)
                                          obj.Show();

                              }
                              else
                              {

                                    obj.Show();
                              }
                        }
                        else
                        {
                              obj.ShowDialog();
                        }
                        return "ok";

                  }
                  else
                  {
                        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                        return objcls_MessageBox.error_notAllowedToOpenScreen;
                  }
            }
            public static string profitorLoss(string pID, bool isParent, bool isUnique)
            {

                  bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Lists.DM.TBL_VCH_Details.frm_profitOrLoss.frm_profitOrLoss_Report));

                  ACC_PRESENTATION_LAYER.Lists.DM.TBL_VCH_Details.frm_profitOrLoss.frm_profitOrLoss_Report obj = new ACC_PRESENTATION_LAYER.Lists.DM.TBL_VCH_Details.frm_profitOrLoss.frm_profitOrLoss_Report(DateTime.Now,DateTime.Now);
                  bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj.Name, "G");
                  if (isOk)
                  {
                        if (isParent)
                        {
                              obj.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                              if (isUnique)
                              {

                                    if (!isFormOpen)
                                          obj.Show();

                              }
                              else
                              {

                                    obj.Show();
                              }
                        }
                        else
                        {
                              obj.ShowDialog();
                        }
                        return "ok";

                  }
                  else
                  {
                        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                        return objcls_MessageBox.error_notAllowedToOpenScreen;
                  }
            }

            public static string balanceSheet(string pID, bool isParent, bool isUnique)
            {

                  bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Lists.DM.BalanceSheet.frm_balanceSheet_Report.frm_balanceSheet_Report));

                  ACC_PRESENTATION_LAYER.Lists.DM.BalanceSheet.frm_balanceSheet_Report.frm_balanceSheet_Report obj = new ACC_PRESENTATION_LAYER.Lists.DM.BalanceSheet.frm_balanceSheet_Report.frm_balanceSheet_Report(DateTime.Now, DateTime.Now);
                  bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj.Name, "G");
                  if (isOk)
                  {
                        if (isParent)
                        {
                              obj.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic;
                              if (isUnique)
                              {

                                    if (!isFormOpen)
                                          obj.Show();

                              }
                              else
                              {

                                    obj.Show();
                              }
                        }
                        else
                        {
                              obj.ShowDialog();
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
