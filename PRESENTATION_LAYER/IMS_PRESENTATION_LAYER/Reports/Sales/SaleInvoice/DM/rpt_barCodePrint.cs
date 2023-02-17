using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Reports.Sales.SaleInvoice.DM
{
    public partial class rpt_barCodePrint : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_barCodePrint()
        {
            InitializeComponent();
        }

        public rpt_barCodePrint(string price, string barcode, string productName
            )
        {
            InitializeComponent();



            xrBarCode_barcode.Text = barcode;
            xrLabel_price.Text = price;
            xrLabel_productName.Text = productName;


        }

    }
}
