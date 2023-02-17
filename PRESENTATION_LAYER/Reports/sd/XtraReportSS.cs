using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Linq;


namespace PRESENTATION_LAYER.Reports
{



    public partial class XtraReportSS : DevExpress.XtraReports.UI.XtraReport
    {


           DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet_IMS = new DATASET.IMS_DATASET.cls_DataSet();

       
 
        public XtraReportSS()
        {
            InitializeComponent();
        }




        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            obj_cls_DataSet_IMS.f_TABLE_Report_STOCK("S");
            DataTable dtstock = obj_cls_DataSet_IMS.g_TABLE_Report_STOCK.Tables[0];
            dataSetReports1.DtStock.Rows.Add();

           for(int i = 0; i <dtstock.Rows.Count ; i++ )
           {
               dataSetReports1.DtStock.Rows.Add(dtstock.Rows[i]["STOCK_itemID"], dtstock.Rows[i]["PRODUCTS_name"], dtstock.Rows[i]["PRODUCTS_Weights"], dtstock.Rows[i]["TR"], dtstock.Rows[i]["TA"], dtstock.Rows[i]["Remaning"]);
           }




         
        }

    }
}
