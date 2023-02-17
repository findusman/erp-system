namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Reports.Sales.SaleInvoice.DM
{
    partial class rpt_barCodePrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrBarCode_barcode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel_price = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel_productName = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode_barcode,
            this.xrLabel_price,
            this.xrLabel_productName});
            this.ReportHeader.HeightF = 66.79166F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrBarCode_barcode
            // 
            this.xrBarCode_barcode.LocationFloat = new DevExpress.Utils.PointFloat(8.999999F, 10.00001F);
            this.xrBarCode_barcode.Name = "xrBarCode_barcode";
            this.xrBarCode_barcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode_barcode.ShowText = false;
            this.xrBarCode_barcode.SizeF = new System.Drawing.SizeF(198F, 32.33331F);
            this.xrBarCode_barcode.StylePriority.UseTextAlignment = false;
            this.xrBarCode_barcode.Symbology = code128Generator1;
            this.xrBarCode_barcode.Text = "2000";
            this.xrBarCode_barcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel_price
            // 
            this.xrLabel_price.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel_price.LocationFloat = new DevExpress.Utils.PointFloat(8.999999F, 10.00001F);
            this.xrLabel_price.Name = "xrLabel_price";
            this.xrLabel_price.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_price.SizeF = new System.Drawing.SizeF(159.0833F, 14.45833F);
            this.xrLabel_price.StylePriority.UseFont = false;
            this.xrLabel_price.StylePriority.UseTextAlignment = false;
            this.xrLabel_price.Text = "9000.99 Rs.";
            this.xrLabel_price.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel_price.Visible = false;
            // 
            // xrLabel_productName
            // 
            this.xrLabel_productName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel_productName.LocationFloat = new DevExpress.Utils.PointFloat(8.999999F, 45.33332F);
            this.xrLabel_productName.LockedInUserDesigner = true;
            this.xrLabel_productName.Name = "xrLabel_productName";
            this.xrLabel_productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_productName.SizeF = new System.Drawing.SizeF(208F, 19.45834F);
            this.xrLabel_productName.StylePriority.UseFont = false;
            this.xrLabel_productName.Text = "MOBIL UNIVERSAL BRAKE FLUID 12 X 0.5 FLUID 12 X X 0.5 FLUID 12 X X 0.5";
            // 
            // rpt_barCodePrint
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("MingLiU_HKSCS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 100;
            this.PageWidth = 217;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "13.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode_barcode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_price;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_productName;
    }
}
