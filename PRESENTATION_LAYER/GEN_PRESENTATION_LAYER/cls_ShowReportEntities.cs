using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER
{
  public class cls_ShowReportEntities
    {




        public static string ItemTransactionReport(string pID, DateTime pfromDate, DateTime ptoDate, bool isParent, bool isUnique)
        {



              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Transaction_Report));

              IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Transaction_Report obj = new IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Transaction_Report(pID, pfromDate, ptoDate);
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
      


      //public static string previewLedgerReport(string pCOA, DateTime pFromDate, DateTime pToTime, bool isParent, bool isUnique, bool isDefault)
      //{



      //    bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI.IsAlreadyOpen(typeof(ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger));

      //    ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger obj_frm_rpt_Ledger = new ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger(pCOA, pFromDate, pToTime, false);
      //    bool isOk = GEN.GEN_GEN.GenericClasses.UserRIghts.cls_UserRights.isThisScreenAllowed(obj_frm_rpt_Ledger.Name, "G");
      //    if (isOk)
      //    {
      //        if (isParent)
      //        {
      //            obj_frm_rpt_Ledger.MdiParent = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDI;
      //            if (isUnique)
      //            {

      //                if (!isFormOpen)
      //                    obj_frm_rpt_Ledger.Show();

      //            }
      //            else
      //            {

      //                obj_frm_rpt_Ledger.Show();
      //            }
      //        }
      //        else
      //        {
      //            obj_frm_rpt_Ledger.Show();
      //        }
      //        return "ok";

      //    }
      //    else
      //    {
      //        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

      //        return objcls_MessageBox.error_notAllowedToOpenScreen;
      //    }


      //}




    }
}
