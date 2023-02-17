using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting
{
    public partial class rpt_barCodeWriting_Parent : DevExpress.XtraReports.UI.XtraReport
    {

          string PRODUCT_ID = "";



          System.Data.DataTable dt = new System.Data.DataTable();
          int index_Count = 0;

          public rpt_barCodeWriting_Parent(string pPRODUCT_ID)
        {
            InitializeComponent();
            v_TBL_PRODUCTS_barcodeWritingTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;
            v_TBL_PRODUCTS_barcodeWritingTableAdapter.Fill(dataSet_barCodeWriting2.V_TBL_PRODUCTS_barcodeWriting);

            dt = dataSet_barCodeWriting2.V_TBL_PRODUCTS_barcodeWriting.Copy();
          
           
        }

          private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
                if (index_Count < dt.Rows.Count)
                {

                      ((XRSubreport)sender).ReportSource.FilterString = "[PRODUCT_ID] = " + dt.Rows[index_Count]["PRODUCT_ID"].ToString();
                      index_Count++;
                }
          }

          private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
                if (index_Count < dt.Rows.Count)
                {
                ((XRSubreport)sender).ReportSource.FilterString = "[PRODUCT_ID] = " + dt.Rows[index_Count]["PRODUCT_ID"].ToString();
                index_Count++;
                      }
          }

          private void xrSubreport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
                if (index_Count < dt.Rows.Count)
                {
                ((XRSubreport)sender).ReportSource.FilterString = "[PRODUCT_ID] = " + dt.Rows[index_Count]["PRODUCT_ID"].ToString();
                index_Count++;
                }
          }

    }
}
