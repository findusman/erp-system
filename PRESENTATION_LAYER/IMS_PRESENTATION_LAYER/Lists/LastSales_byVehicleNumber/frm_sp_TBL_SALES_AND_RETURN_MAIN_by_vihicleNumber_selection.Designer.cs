namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber
{
      partial class frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection
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

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.sprptLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.uc_NAVBARCONTROl1 = new DXWindowsApplication1.uc_NAVBARCONTROl();
            this.GridControl_TBL_VCH_DETAILS = new DevExpress.XtraGrid.GridControl();
            this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection = new PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber.DataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection();
            this.GridView_TBL_VCH_DETAILS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSALES_AND_RETURN_MAIN_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_AND_RETURN_MAIN_Mileage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMER_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_AND_RETURN_MAIN_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALES_AND_RETURN_MAIN_totalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl_Grid = new DevExpress.XtraEditors.PanelControl();
            this.TextEdit_vehicleNumber = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_CUSTOMER_name = new DevExpress.XtraEditors.LabelControl();
            this.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter = new PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber.DataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapters.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sprptLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Grid)).BeginInit();
            this.PanelControl_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_vehicleNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sprptLedgerBindingSource
            // 
            this.sprptLedgerBindingSource.DataMember = "sp_rpt_Ledger";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(109, 71);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(67, 35);
            this.simpleButton2.TabIndex = 24;
            this.simpleButton2.Text = "Referesh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(185, 71);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 35);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Load Data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // uc_NAVBARCONTROl1
            // 
            this.uc_NAVBARCONTROl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_NAVBARCONTROl1.Location = new System.Drawing.Point(0, 0);
            this.uc_NAVBARCONTROl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uc_NAVBARCONTROl1.Name = "uc_NAVBARCONTROl1";
            this.uc_NAVBARCONTROl1.Pro_GridControl_temp = this.GridControl_TBL_VCH_DETAILS;
            this.uc_NAVBARCONTROl1.Pro_IsExpance = true;
            this.uc_NAVBARCONTROl1.Pro_PanelControl_filter = null;
            this.uc_NAVBARCONTROl1.Pro_PanelControl_Grid = this.PanelControl_Grid;
            this.uc_NAVBARCONTROl1.Size = new System.Drawing.Size(856, 537);
            this.uc_NAVBARCONTROl1.TabIndex = 27;
            // 
            // GridControl_TBL_VCH_DETAILS
            // 
            this.GridControl_TBL_VCH_DETAILS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl_TBL_VCH_DETAILS.DataSource = this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource;
            this.GridControl_TBL_VCH_DETAILS.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridControl_TBL_VCH_DETAILS.Location = new System.Drawing.Point(0, 0);
            this.GridControl_TBL_VCH_DETAILS.MainView = this.GridView_TBL_VCH_DETAILS;
            this.GridControl_TBL_VCH_DETAILS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridControl_TBL_VCH_DETAILS.Name = "GridControl_TBL_VCH_DETAILS";
            this.GridControl_TBL_VCH_DETAILS.Size = new System.Drawing.Size(227, 223);
            this.GridControl_TBL_VCH_DETAILS.TabIndex = 20;
            this.GridControl_TBL_VCH_DETAILS.Tag = "I";
            this.GridControl_TBL_VCH_DETAILS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_VCH_DETAILS});
            // 
            // spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource
            // 
            this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource.DataMember = "sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection";
            this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource.DataSource = this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection;
            // 
            // dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection
            // 
            this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection.DataSetName = "DataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection";
            this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GridView_TBL_VCH_DETAILS
            // 
            this.GridView_TBL_VCH_DETAILS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSALES_AND_RETURN_MAIN_ID,
            this.colSALES_AND_RETURN_MAIN_Mileage,
            this.colCUSTOMER_name,
            this.colSALES_AND_RETURN_MAIN_date,
            this.colSALES_AND_RETURN_MAIN_totalAmount});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "BeforeDateBalance";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "LastYearBalance";
            this.GridView_TBL_VCH_DETAILS.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.GridView_TBL_VCH_DETAILS.GridControl = this.GridControl_TBL_VCH_DETAILS;
            this.GridView_TBL_VCH_DETAILS.Name = "GridView_TBL_VCH_DETAILS";
            this.GridView_TBL_VCH_DETAILS.OptionsPrint.ExpandAllDetails = true;
            this.GridView_TBL_VCH_DETAILS.OptionsPrint.PrintDetails = true;
            this.GridView_TBL_VCH_DETAILS.DoubleClick += new System.EventHandler(this.GridView_TBL_VCH_DETAILS_DoubleClick);
            // 
            // colSALES_AND_RETURN_MAIN_ID
            // 
            this.colSALES_AND_RETURN_MAIN_ID.Caption = "Bill No";
            this.colSALES_AND_RETURN_MAIN_ID.FieldName = "SALES_AND_RETURN_MAIN_ID";
            this.colSALES_AND_RETURN_MAIN_ID.Name = "colSALES_AND_RETURN_MAIN_ID";
            this.colSALES_AND_RETURN_MAIN_ID.OptionsColumn.FixedWidth = true;
            this.colSALES_AND_RETURN_MAIN_ID.Visible = true;
            this.colSALES_AND_RETURN_MAIN_ID.VisibleIndex = 0;
            // 
            // colSALES_AND_RETURN_MAIN_Mileage
            // 
            this.colSALES_AND_RETURN_MAIN_Mileage.Caption = "Mileage";
            this.colSALES_AND_RETURN_MAIN_Mileage.FieldName = "SALES_AND_RETURN_MAIN_Mileage";
            this.colSALES_AND_RETURN_MAIN_Mileage.Name = "colSALES_AND_RETURN_MAIN_Mileage";
            this.colSALES_AND_RETURN_MAIN_Mileage.OptionsColumn.FixedWidth = true;
            this.colSALES_AND_RETURN_MAIN_Mileage.Visible = true;
            this.colSALES_AND_RETURN_MAIN_Mileage.VisibleIndex = 1;
            // 
            // colCUSTOMER_name
            // 
            this.colCUSTOMER_name.Caption = "Name";
            this.colCUSTOMER_name.FieldName = "CUSTOMER_name";
            this.colCUSTOMER_name.Name = "colCUSTOMER_name";
            this.colCUSTOMER_name.Visible = true;
            this.colCUSTOMER_name.VisibleIndex = 2;
            this.colCUSTOMER_name.Width = 750;
            // 
            // colSALES_AND_RETURN_MAIN_date
            // 
            this.colSALES_AND_RETURN_MAIN_date.Caption = "Date";
            this.colSALES_AND_RETURN_MAIN_date.FieldName = "SALES_AND_RETURN_MAIN_date";
            this.colSALES_AND_RETURN_MAIN_date.Name = "colSALES_AND_RETURN_MAIN_date";
            this.colSALES_AND_RETURN_MAIN_date.OptionsColumn.FixedWidth = true;
            this.colSALES_AND_RETURN_MAIN_date.Visible = true;
            this.colSALES_AND_RETURN_MAIN_date.VisibleIndex = 3;
            this.colSALES_AND_RETURN_MAIN_date.Width = 100;
            // 
            // colSALES_AND_RETURN_MAIN_totalAmount
            // 
            this.colSALES_AND_RETURN_MAIN_totalAmount.Caption = "Amount";
            this.colSALES_AND_RETURN_MAIN_totalAmount.FieldName = "SALES_AND_RETURN_MAIN_totalAmount";
            this.colSALES_AND_RETURN_MAIN_totalAmount.Name = "colSALES_AND_RETURN_MAIN_totalAmount";
            this.colSALES_AND_RETURN_MAIN_totalAmount.OptionsColumn.FixedWidth = true;
            this.colSALES_AND_RETURN_MAIN_totalAmount.Visible = true;
            this.colSALES_AND_RETURN_MAIN_totalAmount.VisibleIndex = 4;
            // 
            // PanelControl_Grid
            // 
            this.PanelControl_Grid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl_Grid.Controls.Add(this.GridControl_TBL_VCH_DETAILS);
            this.PanelControl_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl_Grid.Location = new System.Drawing.Point(0, 0);
            this.PanelControl_Grid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PanelControl_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl_Grid.Name = "PanelControl_Grid";
            this.PanelControl_Grid.Size = new System.Drawing.Size(405, 537);
            this.PanelControl_Grid.TabIndex = 28;
            // 
            // TextEdit_vehicleNumber
            // 
            this.TextEdit_vehicleNumber.EnterMoveNextControl = true;
            this.TextEdit_vehicleNumber.Location = new System.Drawing.Point(9, 47);
            this.TextEdit_vehicleNumber.Name = "TextEdit_vehicleNumber";
            this.TextEdit_vehicleNumber.Size = new System.Drawing.Size(275, 20);
            this.TextEdit_vehicleNumber.TabIndex = 28;
            this.TextEdit_vehicleNumber.Tag = "N_T_V";
            // 
            // LabelControl_TextEdit_CUSTOMER_name
            // 
            this.LabelControl_TextEdit_CUSTOMER_name.Location = new System.Drawing.Point(9, 28);
            this.LabelControl_TextEdit_CUSTOMER_name.Name = "LabelControl_TextEdit_CUSTOMER_name";
            this.LabelControl_TextEdit_CUSTOMER_name.Size = new System.Drawing.Size(80, 13);
            this.LabelControl_TextEdit_CUSTOMER_name.TabIndex = 29;
            this.LabelControl_TextEdit_CUSTOMER_name.Text = "Vehicle Number :";
            // 
            // sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter
            // 
            this.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 537);
            this.Controls.Add(this.TextEdit_vehicleNumber);
            this.Controls.Add(this.LabelControl_TextEdit_CUSTOMER_name);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.uc_NAVBARCONTROl1);
            this.Name = "frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection";
            this.Tag = "NoForm";
            this.Text = "Sales by Vehicle";
            this.Load += new System.EventHandler(this.frm_rpt_Ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprptLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Grid)).EndInit();
            this.PanelControl_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_vehicleNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.BindingSource sprptLedgerBindingSource;
             private DevExpress.XtraEditors.SimpleButton simpleButton2;
            private DevExpress.XtraEditors.SimpleButton simpleButton1;
            private DXWindowsApplication1.uc_NAVBARCONTROl uc_NAVBARCONTROl1;
            private DevExpress.XtraEditors.PanelControl PanelControl_Grid;
            public DevExpress.XtraGrid.GridControl GridControl_TBL_VCH_DETAILS;
            public DevExpress.XtraGrid.Views.Grid.GridView GridView_TBL_VCH_DETAILS;
            public DevExpress.XtraEditors.TextEdit TextEdit_vehicleNumber;
            public DevExpress.XtraEditors.LabelControl LabelControl_TextEdit_CUSTOMER_name;
            private System.Windows.Forms.BindingSource spTBLSALESANDRETURNMAINbyvihicleNumberselectionBindingSource;
            private DataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection;
            private DevExpress.XtraGrid.Columns.GridColumn colSALES_AND_RETURN_MAIN_ID;
            private DevExpress.XtraGrid.Columns.GridColumn colSALES_AND_RETURN_MAIN_Mileage;
            private DevExpress.XtraGrid.Columns.GridColumn colCUSTOMER_name;
            private DevExpress.XtraGrid.Columns.GridColumn colSALES_AND_RETURN_MAIN_date;
            private DevExpress.XtraGrid.Columns.GridColumn colSALES_AND_RETURN_MAIN_totalAmount;
            private DataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapters.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter;
      }
}