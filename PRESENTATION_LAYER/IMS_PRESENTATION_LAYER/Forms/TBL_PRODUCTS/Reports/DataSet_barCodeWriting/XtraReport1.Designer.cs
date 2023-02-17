namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting
{
    partial class XtraReport1
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
            DevExpress.XtraPrinting.BarCode.Code11Generator code11Generator1 = new DevExpress.XtraPrinting.BarCode.Code11Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel_salePrice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel_caption = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.TopMargin.HeightF = 3F;
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
            this.xrLabel_salePrice,
            this.xrBarCode2,
            this.xrLabel_caption,
            this.xrLabel2});
            this.ReportHeader.HeightF = 63.71667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel_salePrice
            // 
            this.xrLabel_salePrice.Font = new System.Drawing.Font("Book Antiqua", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrLabel_salePrice.LocationFloat = new DevExpress.Utils.PointFloat(9.000023F, 48.20832F);
            this.xrLabel_salePrice.Name = "xrLabel_salePrice";
            this.xrLabel_salePrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_salePrice.SizeF = new System.Drawing.SizeF(159.0833F, 2F);
            this.xrLabel_salePrice.StylePriority.UseFont = false;
            this.xrLabel_salePrice.StylePriority.UseTextAlignment = false;
            this.xrLabel_salePrice.Text = "9000.99 Rs.";
            this.xrLabel_salePrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.45832F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode2.ShowText = false;
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(168.0833F, 33.75F);
            this.xrBarCode2.StylePriority.UseTextAlignment = false;
            this.xrBarCode2.Symbology = code11Generator1;
            this.xrBarCode2.Text = "12345";
            this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel_caption
            // 
            this.xrLabel_caption.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel_caption.LocationFloat = new DevExpress.Utils.PointFloat(9.000023F, 0F);
            this.xrLabel_caption.Name = "xrLabel_caption";
            this.xrLabel_caption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_caption.SizeF = new System.Drawing.SizeF(159.0833F, 14.45833F);
            this.xrLabel_caption.StylePriority.UseFont = false;
            this.xrLabel_caption.StylePriority.UseTextAlignment = false;
            this.xrLabel_caption.Text = "9000.99 Rs.";
            this.xrLabel_caption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 7.25F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(9.000023F, 50.20831F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(62.50002F, 12.58333F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Brown Davies";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("MingLiU_HKSCS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 3, 0);
            this.PageHeight = 100;
            this.PageWidth = 186;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "13.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_caption;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_salePrice;
    }
}
