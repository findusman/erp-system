namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting
{
      partial class rpt_barCodeWriting_Child
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
                  DevExpress.XtraPrinting.BarCode.CodabarGenerator codabarGenerator1 = new DevExpress.XtraPrinting.BarCode.CodabarGenerator();
                  this.Detail = new DevExpress.XtraReports.UI.DetailBand();
                  this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
                  this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
                  this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
                  this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
                  this.EVENSTYLE = new DevExpress.XtraReports.UI.XRControlStyle();
                  this.ODDSTYLE = new DevExpress.XtraReports.UI.XRControlStyle();
                  this.CF_ITEM = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_CODE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_QUANTITY = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_UNIT_PRICE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_TOTAL_PRICE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_CUS_NAME = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_DATE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_MILEGE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_YEAR = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_VEHICLE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_INVOICE_CODE = new DevExpress.XtraReports.UI.CalculatedField();
                  this.CF_BANK_NAME = new DevExpress.XtraReports.UI.CalculatedField();
                  this.dataSet_barCodeWriting1 = new PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting.DataSet_barCodeWriting();
                  this.v_TBL_PRODUCTS_barcodeWritingTableAdapter = new PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting.DataSet_barCodeWritingTableAdapters.V_TBL_PRODUCTS_barcodeWritingTableAdapter();
                  this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
                  ((System.ComponentModel.ISupportInitialize)(this.dataSet_barCodeWriting1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
                  // 
                  // Detail
                  // 
                  this.Detail.HeightF = 0F;
                  this.Detail.Name = "Detail";
                  this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
                  this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                  // 
                  // xrLabel1
                  // 
                  this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_TBL_PRODUCTS_barcodeWriting.PRODUCT_name")});
                  this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(17.75F, 13.69447F);
                  this.xrLabel1.Name = "xrLabel1";
                  this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 0, 100F);
                  this.xrLabel1.SizeF = new System.Drawing.SizeF(183.25F, 19.88889F);
                  // 
                  // xrBarCode1
                  // 
                  this.xrBarCode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "V_TBL_PRODUCTS_barcodeWriting.PRODUCT_COA")});
                  this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(9.000015F, 33.58334F);
                  this.xrBarCode1.Name = "xrBarCode1";
                  this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
                  this.xrBarCode1.SizeF = new System.Drawing.SizeF(207F, 56.41667F);
                  this.xrBarCode1.StylePriority.UseTextAlignment = false;
                  codabarGenerator1.WideNarrowRatio = 2F;
                  this.xrBarCode1.Symbology = codabarGenerator1;
                  this.xrBarCode1.Text = "01-0001";
                  this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
                  this.BottomMargin.HeightF = 49F;
                  this.BottomMargin.Name = "BottomMargin";
                  this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
                  this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                  // 
                  // EVENSTYLE
                  // 
                  this.EVENSTYLE.BackColor = System.Drawing.Color.Transparent;
                  this.EVENSTYLE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
                  this.EVENSTYLE.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
                  this.EVENSTYLE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.EVENSTYLE.ForeColor = System.Drawing.SystemColors.ControlText;
                  this.EVENSTYLE.Name = "EVENSTYLE";
                  this.EVENSTYLE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
                  this.EVENSTYLE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                  // 
                  // ODDSTYLE
                  // 
                  this.ODDSTYLE.BackColor = System.Drawing.Color.Transparent;
                  this.ODDSTYLE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
                  this.ODDSTYLE.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
                  this.ODDSTYLE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.ODDSTYLE.ForeColor = System.Drawing.SystemColors.ControlText;
                  this.ODDSTYLE.Name = "ODDSTYLE";
                  this.ODDSTYLE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
                  this.ODDSTYLE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                  // 
                  // CF_ITEM
                  // 
                  this.CF_ITEM.DataMember = "V_SALE_INVOICE";
                  this.CF_ITEM.Expression = "\'   \' +[ITEM_NAME]";
                  this.CF_ITEM.Name = "CF_ITEM";
                  // 
                  // CF_CODE
                  // 
                  this.CF_CODE.DataMember = "V_SALE_INVOICE";
                  this.CF_CODE.Expression = "\'   \' + [ITEM_ID]";
                  this.CF_CODE.Name = "CF_CODE";
                  // 
                  // CF_QUANTITY
                  // 
                  this.CF_QUANTITY.DataMember = "V_SALE_INVOICE";
                  this.CF_QUANTITY.Expression = "\'   \' + [PI_QTY] + \'  \' + [PI_UNIT]";
                  this.CF_QUANTITY.Name = "CF_QUANTITY";
                  // 
                  // CF_UNIT_PRICE
                  // 
                  this.CF_UNIT_PRICE.DataMember = "V_SALE_INVOICE";
                  this.CF_UNIT_PRICE.Expression = "\'   \' +[PI_UNIT_PRICE]";
                  this.CF_UNIT_PRICE.Name = "CF_UNIT_PRICE";
                  // 
                  // CF_TOTAL_PRICE
                  // 
                  this.CF_TOTAL_PRICE.DataMember = "V_SALE_INVOICE";
                  this.CF_TOTAL_PRICE.Expression = "[PI_QTY]  *  [PI_UNIT_PRICE]";
                  this.CF_TOTAL_PRICE.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
                  this.CF_TOTAL_PRICE.Name = "CF_TOTAL_PRICE";
                  // 
                  // CF_CUS_NAME
                  // 
                  this.CF_CUS_NAME.DataMember = "V_SALE_INVOICE";
                  this.CF_CUS_NAME.Expression = "\'   \' + [CUS_NAME]";
                  this.CF_CUS_NAME.Name = "CF_CUS_NAME";
                  // 
                  // CF_DATE
                  // 
                  this.CF_DATE.DataMember = "V_SALE_INVOICE";
                  this.CF_DATE.Expression = "\'   \' + [SI_DATE]";
                  this.CF_DATE.Name = "CF_DATE";
                  // 
                  // CF_MILEGE
                  // 
                  this.CF_MILEGE.DataMember = "V_SALE_INVOICE";
                  this.CF_MILEGE.Expression = "\'   \' +[SI_MIALAGE]";
                  this.CF_MILEGE.Name = "CF_MILEGE";
                  // 
                  // CF_YEAR
                  // 
                  this.CF_YEAR.DataMember = "V_SALE_INVOICE";
                  this.CF_YEAR.Expression = "\'   \' + [SI_YEAR]";
                  this.CF_YEAR.Name = "CF_YEAR";
                  // 
                  // CF_VEHICLE
                  // 
                  this.CF_VEHICLE.DataMember = "V_SALE_INVOICE";
                  this.CF_VEHICLE.Expression = "\'   \' +[SI_VEHICLE_#]";
                  this.CF_VEHICLE.Name = "CF_VEHICLE";
                  // 
                  // CF_INVOICE_CODE
                  // 
                  this.CF_INVOICE_CODE.DataMember = "V_SALE_INVOICE";
                  this.CF_INVOICE_CODE.Expression = "\'   \' + [SI_CODE]";
                  this.CF_INVOICE_CODE.Name = "CF_INVOICE_CODE";
                  // 
                  // CF_BANK_NAME
                  // 
                  this.CF_BANK_NAME.DataMember = "V_SALE_INVOICE";
                  this.CF_BANK_NAME.Expression = "\'   \' + [SI_BANK]";
                  this.CF_BANK_NAME.Name = "CF_BANK_NAME";
                  // 
                  // dataSet_barCodeWriting1
                  // 
                  this.dataSet_barCodeWriting1.DataSetName = "DataSet_barCodeWriting";
                  this.dataSet_barCodeWriting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                  // 
                  // v_TBL_PRODUCTS_barcodeWritingTableAdapter
                  // 
                  this.v_TBL_PRODUCTS_barcodeWritingTableAdapter.ClearBeforeFill = true;
                  // 
                  // ReportHeader
                  // 
                  this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrLabel1});
                  this.ReportHeader.Name = "ReportHeader";
                  // 
                  // rpt_barCodeWriting_Child
                  // 
                  this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
                  this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CF_ITEM,
            this.CF_CODE,
            this.CF_QUANTITY,
            this.CF_UNIT_PRICE,
            this.CF_TOTAL_PRICE,
            this.CF_CUS_NAME,
            this.CF_DATE,
            this.CF_MILEGE,
            this.CF_YEAR,
            this.CF_VEHICLE,
            this.CF_INVOICE_CODE,
            this.CF_BANK_NAME});
                  this.DataAdapter = this.v_TBL_PRODUCTS_barcodeWritingTableAdapter;
                  this.DataMember = "V_TBL_PRODUCTS_barcodeWriting";
                  this.DataSource = this.dataSet_barCodeWriting1;
                  this.DisplayName = "Sale Invoice";
                  this.Landscape = true;
                  this.Margins = new System.Drawing.Printing.Margins(35, 566, 0, 49);
                  this.PageHeight = 583;
                  this.PageWidth = 827;
                  this.PaperKind = System.Drawing.Printing.PaperKind.A5;
                  this.RequestParameters = false;
                  this.SnapGridSize = 0.1F;
                  this.SnapToGrid = false;
                  this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EVENSTYLE,
            this.ODDSTYLE});
                  this.Version = "13.1";
                  this.Watermark.ImageTransparency = 245;
                  this.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom;
                  ((System.ComponentModel.ISupportInitialize)(this.dataSet_barCodeWriting1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle EVENSTYLE;
        private DevExpress.XtraReports.UI.XRControlStyle ODDSTYLE;
        private DevExpress.XtraReports.UI.CalculatedField CF_ITEM;
        private DevExpress.XtraReports.UI.CalculatedField CF_CODE;
        private DevExpress.XtraReports.UI.CalculatedField CF_QUANTITY;
        private DevExpress.XtraReports.UI.CalculatedField CF_UNIT_PRICE;
        private DevExpress.XtraReports.UI.CalculatedField CF_TOTAL_PRICE;
        private DevExpress.XtraReports.UI.CalculatedField CF_CUS_NAME;
        private DevExpress.XtraReports.UI.CalculatedField CF_DATE;
        private DevExpress.XtraReports.UI.CalculatedField CF_MILEGE;
        private DevExpress.XtraReports.UI.CalculatedField CF_YEAR;
        private DevExpress.XtraReports.UI.CalculatedField CF_VEHICLE;
        private DevExpress.XtraReports.UI.CalculatedField CF_INVOICE_CODE;
        private DevExpress.XtraReports.UI.CalculatedField CF_BANK_NAME;
         private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting.DataSet_barCodeWriting dataSet_barCodeWriting1;
        private Forms.TBL_PRODUCTS.Reports.DataSet_barCodeWriting.DataSet_barCodeWritingTableAdapters.V_TBL_PRODUCTS_barcodeWritingTableAdapter v_TBL_PRODUCTS_barcodeWritingTableAdapter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    }
}
