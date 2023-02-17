using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER
{
  public class cls_ShowReportEntities
    {

        public static string sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection( bool isParent, bool isUnique)
        {



              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber.frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection));

              IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber.frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection obj = new IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber.frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection();
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
    

        public static string AccountSummary_ByParentAccount(string ptitle, string pId, bool isParent, bool isUnique)
        {



              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.AccountSummary_ByParentAccount.frm_AccountSummary_ByParentAccount));

              IMS_PRESENTATION_LAYER.Lists.AccountSummary_ByParentAccount.frm_AccountSummary_ByParentAccount obj = new IMS_PRESENTATION_LAYER.Lists.AccountSummary_ByParentAccount.frm_AccountSummary_ByParentAccount(ptitle, pId);
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
    

        public static string AuditTrial( bool isParent, bool isUnique)
        {



              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.AuditTrial.frm_AuditTrial));

              IMS_PRESENTATION_LAYER.Lists.AuditTrial.frm_AuditTrial obj = new IMS_PRESENTATION_LAYER.Lists.AuditTrial.frm_AuditTrial();
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
    

        public static string Item_Stock_Summary(  DateTime pfromDate, DateTime ptoDate, bool isParent, bool isUnique )
        {



              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Stock_Summary.frm_Item_Transaction_Report));

              IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Stock_Summary.frm_Item_Transaction_Report obj = new IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Stock_Summary.frm_Item_Transaction_Report( pfromDate, ptoDate);
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


        public static string Item_Ledger_Sales_Purchase(string pID,  string status, bool isParent, bool isUnique)
        {



            bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Transaction_Report));

            IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Sales_Purchase_Ledger obj = new IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report.frm_Item_Sales_Purchase_Ledger(pID , status);
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


        public static string Sales_Margin( bool isParent, bool isUnique)
        {

              bool isFormOpen = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic.IsAlreadyOpen(typeof(IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Sales.SalesMargin.frm_SalesMargin));

              IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Sales.SalesMargin.frm_SalesMargin obj = new IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Sales.SalesMargin.frm_SalesMargin();
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
