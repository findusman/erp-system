namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Reports.Ledger
{
      partial class frm_rpt_Ledger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rpt_Ledger));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colColor_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sprptLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rpt_Ledger = new PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.DataSets.sp_rpt_Ledger();
            this.sp_rpt_LedgerTableAdapter = new PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.DataSets.sp_rpt_LedgerTableAdapters.sp_rpt_LedgerTableAdapter();
            this.PanelControl_filterControls = new DevExpress.XtraEditors.PanelControl();
            this.GridLookUpEdit_COA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEditITEM_unit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.DateEdit_toDate = new DevExpress.XtraEditors.DateEdit();
            this.DateEdit_fromDate = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uc_NAVBARCONTROl1 = new DXWindowsApplication1.uc_NAVBARCONTROl();
            this.GridControl_TBL_VCH_DETAILS = new DevExpress.XtraGrid.GridControl();
            this.GridView_TBL_VCH_DETAILS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunningSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVCH_DETAILS_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVCH_DETAILS_mainID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVCH_DETAILS_remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVCH_DETAILS_debit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVCH_DETAILS_credit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelControl_Grid = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelControl_TextEdit_VCH_reference = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.sprptLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Ledger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_filterControls)).BeginInit();
            this.PanelControl_filterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_COA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditITEM_unit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Grid)).BeginInit();
            this.PanelControl_Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // colColor_Status
            // 
            this.colColor_Status.FieldName = "Color_Status";
            this.colColor_Status.Name = "colColor_Status";
            this.colColor_Status.OptionsColumn.ReadOnly = true;
            // 
            // sprptLedgerBindingSource
            // 
            this.sprptLedgerBindingSource.DataMember = "sp_rpt_Ledger";
            this.sprptLedgerBindingSource.DataSource = this.sp_rpt_Ledger;
            // 
            // sp_rpt_Ledger
            // 
            this.sp_rpt_Ledger.DataSetName = "sp_rpt_Ledger";
            this.sp_rpt_Ledger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rpt_LedgerTableAdapter
            // 
            this.sp_rpt_LedgerTableAdapter.ClearBeforeFill = true;
            // 
            // PanelControl_filterControls
            // 
            this.PanelControl_filterControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl_filterControls.Controls.Add(this.GridLookUpEdit_COA);
            this.PanelControl_filterControls.Controls.Add(this.labelControl2);
            this.PanelControl_filterControls.Controls.Add(this.labelControl3);
            this.PanelControl_filterControls.Controls.Add(this.simpleButton2);
            this.PanelControl_filterControls.Controls.Add(this.DateEdit_toDate);
            this.PanelControl_filterControls.Controls.Add(this.DateEdit_fromDate);
            this.PanelControl_filterControls.Controls.Add(this.simpleButton1);
            this.PanelControl_filterControls.Controls.Add(this.labelControl1);
            this.PanelControl_filterControls.Location = new System.Drawing.Point(0, 0);
            this.PanelControl_filterControls.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PanelControl_filterControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl_filterControls.Name = "PanelControl_filterControls";
            this.PanelControl_filterControls.Size = new System.Drawing.Size(441, 252);
            this.PanelControl_filterControls.TabIndex = 26;
            // 
            // GridLookUpEdit_COA
            // 
            this.GridLookUpEdit_COA.EnterMoveNextControl = true;
            this.GridLookUpEdit_COA.Location = new System.Drawing.Point(94, 12);
            this.GridLookUpEdit_COA.Margin = new System.Windows.Forms.Padding(6);
            this.GridLookUpEdit_COA.Name = "GridLookUpEdit_COA";
            this.GridLookUpEdit_COA.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GridLookUpEdit_COA.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.GridLookUpEdit_COA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.GridLookUpEdit_COA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEdit_COA.Properties.View = this.gridLookUpEditITEM_unit2View;
            this.GridLookUpEdit_COA.Size = new System.Drawing.Size(339, 28);
            this.GridLookUpEdit_COA.TabIndex = 21;
            this.GridLookUpEdit_COA.Tag = "N_T";
            // 
            // gridLookUpEditITEM_unit2View
            // 
            this.gridLookUpEditITEM_unit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEditITEM_unit2View.Name = "gridLookUpEditITEM_unit2View";
            this.gridLookUpEditITEM_unit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEditITEM_unit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "To Date :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "From Date :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 182);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 51);
            this.simpleButton2.TabIndex = 24;
            this.simpleButton2.Text = "Referesh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DateEdit_toDate
            // 
            this.DateEdit_toDate.EditValue = null;
            this.DateEdit_toDate.Location = new System.Drawing.Point(94, 83);
            this.DateEdit_toDate.Margin = new System.Windows.Forms.Padding(6);
            this.DateEdit_toDate.Name = "DateEdit_toDate";
            this.DateEdit_toDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DateEdit_toDate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.DateEdit_toDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.DateEdit_toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateEdit_toDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.DateEdit_toDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.DateEdit_toDate.Size = new System.Drawing.Size(233, 26);
            this.DateEdit_toDate.TabIndex = 23;
            this.DateEdit_toDate.Tag = "N_T";
            // 
            // DateEdit_fromDate
            // 
            this.DateEdit_fromDate.EditValue = null;
            this.DateEdit_fromDate.Location = new System.Drawing.Point(94, 46);
            this.DateEdit_fromDate.Margin = new System.Windows.Forms.Padding(6);
            this.DateEdit_fromDate.Name = "DateEdit_fromDate";
            this.DateEdit_fromDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DateEdit_fromDate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.DateEdit_fromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.DateEdit_fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateEdit_fromDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.DateEdit_fromDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.DateEdit_fromDate.Size = new System.Drawing.Size(233, 26);
            this.DateEdit_fromDate.TabIndex = 22;
            this.DateEdit_fromDate.Tag = "N_T";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(276, 182);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 51);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Load Data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Accounts :";
            // 
            // uc_NAVBARCONTROl1
            // 
            this.uc_NAVBARCONTROl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_NAVBARCONTROl1.Location = new System.Drawing.Point(0, 0);
            this.uc_NAVBARCONTROl1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_NAVBARCONTROl1.Name = "uc_NAVBARCONTROl1";
            this.uc_NAVBARCONTROl1.Pro_GridControl_temp = this.GridControl_TBL_VCH_DETAILS;
            this.uc_NAVBARCONTROl1.Pro_IsExpance = true;
            this.uc_NAVBARCONTROl1.Pro_PanelControl_filter = this.PanelControl_filterControls;
            this.uc_NAVBARCONTROl1.Pro_PanelControl_Grid = this.PanelControl_Grid;
            this.uc_NAVBARCONTROl1.Size = new System.Drawing.Size(1213, 605);
            this.uc_NAVBARCONTROl1.TabIndex = 27;
            // 
            // GridControl_TBL_VCH_DETAILS
            // 
            this.GridControl_TBL_VCH_DETAILS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl_TBL_VCH_DETAILS.DataSource = this.sprptLedgerBindingSource;
            this.GridControl_TBL_VCH_DETAILS.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.GridControl_TBL_VCH_DETAILS.Location = new System.Drawing.Point(0, 0);
            this.GridControl_TBL_VCH_DETAILS.MainView = this.GridView_TBL_VCH_DETAILS;
            this.GridControl_TBL_VCH_DETAILS.Margin = new System.Windows.Forms.Padding(6);
            this.GridControl_TBL_VCH_DETAILS.Name = "GridControl_TBL_VCH_DETAILS";
            this.GridControl_TBL_VCH_DETAILS.Size = new System.Drawing.Size(762, 536);
            this.GridControl_TBL_VCH_DETAILS.TabIndex = 20;
            this.GridControl_TBL_VCH_DETAILS.Tag = "I";
            this.GridControl_TBL_VCH_DETAILS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_VCH_DETAILS});
            // 
            // GridView_TBL_VCH_DETAILS
            // 
            this.GridView_TBL_VCH_DETAILS.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView_TBL_VCH_DETAILS.Appearance.ViewCaption.Options.UseFont = true;
            this.GridView_TBL_VCH_DETAILS.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.GridView_TBL_VCH_DETAILS.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.GridView_TBL_VCH_DETAILS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType,
            this.colRunningSum,
            this.colsr,
            this.colColor_Status,
            this.colVCH_DETAILS_date,
            this.colVCH_DETAILS_mainID,
            this.colVCH_DETAILS_remarks,
            this.colVCH_DETAILS_debit,
            this.colVCH_DETAILS_credit,
            this.colRowBalance});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colColor_Status;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "BeforeDateBalance";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colColor_Status;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "LastYearBalance";
            this.GridView_TBL_VCH_DETAILS.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.GridView_TBL_VCH_DETAILS.GridControl = this.GridControl_TBL_VCH_DETAILS;
            this.GridView_TBL_VCH_DETAILS.Name = "GridView_TBL_VCH_DETAILS";
            this.GridView_TBL_VCH_DETAILS.OptionsPrint.ExpandAllDetails = true;
            this.GridView_TBL_VCH_DETAILS.OptionsPrint.PrintDetails = true;
            this.GridView_TBL_VCH_DETAILS.OptionsView.ShowViewCaption = true;
            this.GridView_TBL_VCH_DETAILS.ViewCaption = "asdf";
            this.GridView_TBL_VCH_DETAILS.DoubleClick += new System.EventHandler(this.GridView_TBL_VCH_DETAILS_DoubleClick);
            // 
            // colType
            // 
            this.colType.Caption = "  ";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.FixedWidth = true;
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 6;
            this.colType.Width = 25;
            // 
            // colRunningSum
            // 
            this.colRunningSum.Caption = "Balance";
            this.colRunningSum.FieldName = "RunningSum";
            this.colRunningSum.Name = "colRunningSum";
            this.colRunningSum.OptionsColumn.FixedWidth = true;
            this.colRunningSum.OptionsColumn.ReadOnly = true;
            this.colRunningSum.Tag = "N2|N|N|N";
            this.colRunningSum.Visible = true;
            this.colRunningSum.VisibleIndex = 5;
            this.colRunningSum.Width = 100;
            // 
            // colsr
            // 
            this.colsr.FieldName = "sr";
            this.colsr.Name = "colsr";
            this.colsr.OptionsColumn.ReadOnly = true;
            // 
            // colVCH_DETAILS_date
            // 
            this.colVCH_DETAILS_date.Caption = "Date";
            this.colVCH_DETAILS_date.FieldName = "VCH_DETAILS_date";
            this.colVCH_DETAILS_date.Name = "colVCH_DETAILS_date";
            this.colVCH_DETAILS_date.OptionsColumn.FixedWidth = true;
            this.colVCH_DETAILS_date.OptionsColumn.ReadOnly = true;
            this.colVCH_DETAILS_date.Visible = true;
            this.colVCH_DETAILS_date.VisibleIndex = 2;
            this.colVCH_DETAILS_date.Width = 125;
            // 
            // colVCH_DETAILS_mainID
            // 
            this.colVCH_DETAILS_mainID.Caption = "VCH Code";
            this.colVCH_DETAILS_mainID.FieldName = "VCH_DETAILS_mainID";
            this.colVCH_DETAILS_mainID.Name = "colVCH_DETAILS_mainID";
            this.colVCH_DETAILS_mainID.OptionsColumn.FixedWidth = true;
            this.colVCH_DETAILS_mainID.OptionsColumn.ReadOnly = true;
            this.colVCH_DETAILS_mainID.Visible = true;
            this.colVCH_DETAILS_mainID.VisibleIndex = 0;
            // 
            // colVCH_DETAILS_remarks
            // 
            this.colVCH_DETAILS_remarks.Caption = "Narration";
            this.colVCH_DETAILS_remarks.FieldName = "VCH_DETAILS_remarks";
            this.colVCH_DETAILS_remarks.MinWidth = 150;
            this.colVCH_DETAILS_remarks.Name = "colVCH_DETAILS_remarks";
            this.colVCH_DETAILS_remarks.OptionsColumn.ReadOnly = true;
            this.colVCH_DETAILS_remarks.Tag = "N|A|N|N";
            this.colVCH_DETAILS_remarks.Visible = true;
            this.colVCH_DETAILS_remarks.VisibleIndex = 1;
            this.colVCH_DETAILS_remarks.Width = 621;
            // 
            // colVCH_DETAILS_debit
            // 
            this.colVCH_DETAILS_debit.Caption = "Debit";
            this.colVCH_DETAILS_debit.FieldName = "VCH_DETAILS_debit";
            this.colVCH_DETAILS_debit.Name = "colVCH_DETAILS_debit";
            this.colVCH_DETAILS_debit.OptionsColumn.FixedWidth = true;
            this.colVCH_DETAILS_debit.OptionsColumn.ReadOnly = true;
            this.colVCH_DETAILS_debit.Tag = "N2|N|N|N";
            this.colVCH_DETAILS_debit.Visible = true;
            this.colVCH_DETAILS_debit.VisibleIndex = 3;
            this.colVCH_DETAILS_debit.Width = 100;
            // 
            // colVCH_DETAILS_credit
            // 
            this.colVCH_DETAILS_credit.Caption = "Credit";
            this.colVCH_DETAILS_credit.FieldName = "VCH_DETAILS_credit";
            this.colVCH_DETAILS_credit.Name = "colVCH_DETAILS_credit";
            this.colVCH_DETAILS_credit.OptionsColumn.FixedWidth = true;
            this.colVCH_DETAILS_credit.OptionsColumn.ReadOnly = true;
            this.colVCH_DETAILS_credit.Tag = "N2|N|N|N";
            this.colVCH_DETAILS_credit.Visible = true;
            this.colVCH_DETAILS_credit.VisibleIndex = 4;
            this.colVCH_DETAILS_credit.Width = 100;
            // 
            // colRowBalance
            // 
            this.colRowBalance.FieldName = "RowBalance";
            this.colRowBalance.Name = "colRowBalance";
            this.colRowBalance.OptionsColumn.ReadOnly = true;
            // 
            // PanelControl_Grid
            // 
            this.PanelControl_Grid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl_Grid.Controls.Add(this.button1);
            this.PanelControl_Grid.Controls.Add(this.LabelControl_TextEdit_VCH_reference);
            this.PanelControl_Grid.Controls.Add(this.GridControl_TBL_VCH_DETAILS);
            this.PanelControl_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl_Grid.Location = new System.Drawing.Point(0, 0);
            this.PanelControl_Grid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PanelControl_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControl_Grid.Name = "PanelControl_Grid";
            this.PanelControl_Grid.Size = new System.Drawing.Size(762, 605);
            this.PanelControl_Grid.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(469, 707);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelControl_TextEdit_VCH_reference
            // 
            this.LabelControl_TextEdit_VCH_reference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl_TextEdit_VCH_reference.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.LabelControl_TextEdit_VCH_reference.Location = new System.Drawing.Point(16, 545);
            this.LabelControl_TextEdit_VCH_reference.Margin = new System.Windows.Forms.Padding(6);
            this.LabelControl_TextEdit_VCH_reference.Name = "LabelControl_TextEdit_VCH_reference";
            this.LabelControl_TextEdit_VCH_reference.Size = new System.Drawing.Size(409, 48);
            this.LabelControl_TextEdit_VCH_reference.TabIndex = 21;
            this.LabelControl_TextEdit_VCH_reference.Tag = "N|N";
            this.LabelControl_TextEdit_VCH_reference.Text = "Balance : 1,000.00 DR.";
            // 
            // frm_rpt_Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 605);
            this.Controls.Add(this.uc_NAVBARCONTROl1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frm_rpt_Ledger";
            this.Tag = "NoForm";
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.frm_rpt_Ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprptLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_Ledger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_filterControls)).EndInit();
            this.PanelControl_filterControls.ResumeLayout(false);
            this.PanelControl_filterControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_COA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditITEM_unit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Grid)).EndInit();
            this.PanelControl_Grid.ResumeLayout(false);
            this.PanelControl_Grid.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.BindingSource sprptLedgerBindingSource;
            private DataSets.sp_rpt_Ledger sp_rpt_Ledger;
            private DataSets.sp_rpt_LedgerTableAdapters.sp_rpt_LedgerTableAdapter sp_rpt_LedgerTableAdapter;
            private DevExpress.XtraEditors.PanelControl PanelControl_filterControls;
            public DevExpress.XtraEditors.GridLookUpEdit GridLookUpEdit_COA;
            public DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEditITEM_unit2View;
            private DevExpress.XtraEditors.LabelControl labelControl2;
            private DevExpress.XtraEditors.LabelControl labelControl3;
            private DevExpress.XtraEditors.SimpleButton simpleButton2;
            private DevExpress.XtraEditors.DateEdit DateEdit_toDate;
            private DevExpress.XtraEditors.DateEdit DateEdit_fromDate;
            private DevExpress.XtraEditors.SimpleButton simpleButton1;
            private DevExpress.XtraEditors.LabelControl labelControl1;
            private DXWindowsApplication1.uc_NAVBARCONTROl uc_NAVBARCONTROl1;
            private DevExpress.XtraEditors.PanelControl PanelControl_Grid;
            public DevExpress.XtraGrid.GridControl GridControl_TBL_VCH_DETAILS;
            public DevExpress.XtraGrid.Views.Grid.GridView GridView_TBL_VCH_DETAILS;
            public DevExpress.XtraEditors.LabelControl LabelControl_TextEdit_VCH_reference;
            private DevExpress.XtraGrid.Columns.GridColumn colType;
            private DevExpress.XtraGrid.Columns.GridColumn colRunningSum;
            private DevExpress.XtraGrid.Columns.GridColumn colsr;
            private DevExpress.XtraGrid.Columns.GridColumn colColor_Status;
            private DevExpress.XtraGrid.Columns.GridColumn colVCH_DETAILS_date;
            private DevExpress.XtraGrid.Columns.GridColumn colVCH_DETAILS_mainID;
            private DevExpress.XtraGrid.Columns.GridColumn colVCH_DETAILS_remarks;
            private DevExpress.XtraGrid.Columns.GridColumn colVCH_DETAILS_debit;
            private DevExpress.XtraGrid.Columns.GridColumn colVCH_DETAILS_credit;
            private DevExpress.XtraGrid.Columns.GridColumn colRowBalance;
            private System.Windows.Forms.Button button1;
      }
}