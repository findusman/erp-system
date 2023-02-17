using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Reports.Sales.SaleInvoice.DM
{
    public partial class rpt_DETAIL_SALE_INVOICE_SMALL : DevExpress.XtraReports.UI.XtraReport
    {

          string PRODUCT_ID = "";
          public rpt_DETAIL_SALE_INVOICE_SMALL(string pPRODUCT_ID)
        {
            InitializeComponent();
            PRODUCT_ID = pPRODUCT_ID;

            this.sp_TBL_SALES_AND_RETURN_MAIN_selectionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;

           
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           

            //  lb_title1.Text = cls_global_veriables.cmp_Sub_Title1;
            //  lb_title2.Text = cls_global_veriables.cmp_Sub_Title2;
            //  lb_xtra1.Text = cls_global_veriables.xtra_label1;
            //  lb_xtra2.Text = cls_global_veriables.xtra_label2;
            //img_cmp_logo.ImageUrl = cls_global_veriables.cmp_logo_path;
            //lb_cmp_main_title.Text = cls_global_veriables.cmp_main_title;
            //lb_cmp_address.Text = cls_global_veriables.cmp_address;
            //lb_developer.Text = cls_global_veriables.cmp_developer;
            xrTable1.CanGrow = true;
          

        }

        private void rpt_DETAIL_SALE_INVOICE_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           GEN.GEN_GEN.GenericClasses.cls_generic_change_to_words obj = new GEN.GEN_GEN.GenericClasses.cls_generic_change_to_words();




           double ssss = Convert.ToDouble(this.GetCurrentColumnValue("SALES_AND_RETURN_MAIN_totalAmount").ToString());


                  string ss11 = obj.changeCurrencyToWords(ssss);
                  xr_total_in_words.Text = "  " + ss11 ;
            
        }

        private void xrLabel14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRLabel)sender).Text = Convert.ToDateTime(this.GetCurrentColumnValue("SI_DATE")).ToString("   " + cls_global_veriables.Generic_default_date);
          //  ((XRLabel)sender).Text =  "  " + DateTime.Now.ToString(cls_global_veriables.Generic_default_date);
          
            
        }

        private void xrLabel14_AfterPrint(object sender, EventArgs e)
        {
           
        }

        private void PageHeader_AfterPrint(object sender, EventArgs e)
        {
            
         
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("CF_TOTAL_PRICE")).ToString(cls_global_veriables.Generic_default_Value);
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           // ((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("PI_UNIT_PRICE")).ToString(cls_global_veriables.Generic_default_Value);
        }

        private void clSubtotal_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

           // ((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("SI_TOTAL_AMOUNT")).ToString(cls_global_veriables.Generic_default_Value);
           
           
           
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          
        }

        private void xrTableCell16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           //((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("SI_DISCOUNT")).ToString(cls_global_veriables.Generic_default_Value);
        }

        private void clFreight_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           // ((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("SI_PAID_AMOUNT")).ToString(cls_global_veriables.Generic_default_Value);
        }

        private void clTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           // ((XRTableCell)sender).Text = Convert.ToDouble(this.GetCurrentColumnValue("SI_REMANING")).ToString(cls_global_veriables.Generic_default_Value);
        }

        private void rpt_DETAIL_SALE_INVOICE_AfterPrint(object sender, EventArgs e)
        {

          


        }

        private void rpt_DETAIL_SALE_INVOICE_SMALL_DataSourceDemanded(object sender, EventArgs e)
        {

              this.sp_TBL_SALES_AND_RETURN_MAIN_selectionTableAdapter.Fill(

                  this.dataSet_SaleInvoice_DM1.sp_TBL_SALES_AND_RETURN_MAIN_selection,
                  "Sales Report",
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                  "",
                  "",
                  PRODUCT_ID,
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted);
                    
        }

     
    }
}
