using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PRODUCTS
{
    partial class frm_TBL_PRODUCTS
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
            this.ListBoxControl_Rights = new DevExpress.XtraEditors.ListBoxControl();
            this.PanelControl_Default = new DevExpress.XtraEditors.PanelControl();
            this.labelControl_TextBox_PRODUCT_ID = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_PRODUCT_ID = new DevExpress.XtraEditors.TextEdit();
            this.CheckEdit_Is_AutoGenegereted = new DevExpress.XtraEditors.CheckEdit();
            this.DataNavigator_Navigate = new DevExpress.XtraEditors.DataNavigator();
            this.CheckEdit_navigate = new DevExpress.XtraEditors.CheckEdit();
            this.SimpleButton_List = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_List = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButton_Referesh = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_Referesh = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButton_Referesh_A = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_Referesh_A = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButton_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_Delete = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButton_Save = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_Save = new DevExpress.XtraEditors.LabelControl();
            this.SimpleButton_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl_SimpleButton_Exit = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_PRODUCT_name = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_PRODUCT_name = new DevExpress.XtraEditors.LabelControl();
            this.GridLookUpEdit_PRODUCT_packing = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit_PRODUCT_packingView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl_GridLookUpEdit_PRODUCT_packing = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl_TextEdit_PRODUCT_defaultLevel = new DevExpress.XtraEditors.LabelControl();
            this.GridLookUpEdit_PRODUCT_department = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GridLookUpEdit_PRODUCT_departmentView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl_GridLookUpEdit_PRODUCT_department = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_PRODUCT_saleRate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_PRODUCT_saleRate = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_PRODUCT_purchaseRate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_PRODUCT_purchaseRate = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_PRODUCT_barCode = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_PRODUCT_barCode = new DevExpress.XtraEditors.LabelControl();
            this.CheckEdit_PRODUCT_isService = new DevExpress.XtraEditors.CheckEdit();
            this.TextEdit_PRODUCT_defaultLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_printHowMany = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_packing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_packingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_departmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_saleRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_purchaseRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_barCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_PRODUCT_isService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_defaultLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_printHowMany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxControl_Rights
            // 
            this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
            this.ListBoxControl_Rights.Location = new System.Drawing.Point(8, 482);
            this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
            this.ListBoxControl_Rights.Size = new System.Drawing.Size(83, 84);
            this.ListBoxControl_Rights.TabIndex = 27;
            this.ListBoxControl_Rights.Visible = false;
            // 
            // PanelControl_Default
            // 
            this.PanelControl_Default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControl_Default.Location = new System.Drawing.Point(-16, 49);
            this.PanelControl_Default.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl_Default.Name = "PanelControl_Default";
            this.PanelControl_Default.Size = new System.Drawing.Size(1133, 12);
            this.PanelControl_Default.TabIndex = 6;
            // 
            // labelControl_TextBox_PRODUCT_ID
            // 
            this.labelControl_TextBox_PRODUCT_ID.Location = new System.Drawing.Point(70, 21);
            this.labelControl_TextBox_PRODUCT_ID.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl_TextBox_PRODUCT_ID.Name = "labelControl_TextBox_PRODUCT_ID";
            this.labelControl_TextBox_PRODUCT_ID.Size = new System.Drawing.Size(21, 16);
            this.labelControl_TextBox_PRODUCT_ID.TabIndex = 7;
            this.labelControl_TextBox_PRODUCT_ID.Text = "ID :";
            // 
            // TextEdit_PRODUCT_ID
            // 
            this.TextEdit_PRODUCT_ID.Location = new System.Drawing.Point(98, 17);
            this.TextEdit_PRODUCT_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_ID.Name = "TextEdit_PRODUCT_ID";
            this.TextEdit_PRODUCT_ID.Size = new System.Drawing.Size(70, 22);
            this.TextEdit_PRODUCT_ID.TabIndex = 0;
            this.TextEdit_PRODUCT_ID.Tag = "N_T";
            this.TextEdit_PRODUCT_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_PRODUCT_ID_KeyDown);
            this.TextEdit_PRODUCT_ID.Leave += new System.EventHandler(this.TextEdit_PRODUCT_ID_Leave);
            // 
            // CheckEdit_Is_AutoGenegereted
            // 
            this.CheckEdit_Is_AutoGenegereted.EditValue = true;
            this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(621, 18);
            this.CheckEdit_Is_AutoGenegereted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
            this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
            this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(163, 20);
            this.CheckEdit_Is_AutoGenegereted.TabIndex = 5;
            this.CheckEdit_Is_AutoGenegereted.Tag = "N";
            // 
            // DataNavigator_Navigate
            // 
            this.DataNavigator_Navigate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.DataNavigator_Navigate.Buttons.Append.Visible = false;
            this.DataNavigator_Navigate.Buttons.CancelEdit.Visible = false;
            this.DataNavigator_Navigate.Buttons.EndEdit.Visible = false;
            this.DataNavigator_Navigate.Buttons.NextPage.Visible = false;
            this.DataNavigator_Navigate.Buttons.PrevPage.Visible = false;
            this.DataNavigator_Navigate.Buttons.Remove.Visible = false;
            this.DataNavigator_Navigate.Enabled = false;
            this.DataNavigator_Navigate.Location = new System.Drawing.Point(253, 16);
            this.DataNavigator_Navigate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
            this.DataNavigator_Navigate.Size = new System.Drawing.Size(360, 30);
            this.DataNavigator_Navigate.TabIndex = 11;
            this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
            // 
            // CheckEdit_navigate
            // 
            this.CheckEdit_navigate.Location = new System.Drawing.Point(226, 20);
            this.CheckEdit_navigate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckEdit_navigate.Name = "CheckEdit_navigate";
            this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CheckEdit_navigate.Properties.Caption = "";
            this.CheckEdit_navigate.Size = new System.Drawing.Size(20, 19);
            this.CheckEdit_navigate.TabIndex = 10;
            this.CheckEdit_navigate.Tag = "F";
            this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
            // 
            // SimpleButton_List
            // 
            this.SimpleButton_List.Location = new System.Drawing.Point(175, 17);
            this.SimpleButton_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_List.Name = "SimpleButton_List";
            this.SimpleButton_List.Size = new System.Drawing.Size(45, 25);
            this.SimpleButton_List.TabIndex = 1;
            this.SimpleButton_List.Tag = "List";
            this.SimpleButton_List.Click += new System.EventHandler(this.SimpleButton_List_Click);
            // 
            // LabelControl_SimpleButton_List
            // 
            this.LabelControl_SimpleButton_List.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_List.Name = "LabelControl_SimpleButton_List";
            this.LabelControl_SimpleButton_List.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_List.TabIndex = 0;
            // 
            // SimpleButton_Referesh
            // 
            this.SimpleButton_Referesh.Location = new System.Drawing.Point(261, 327);
            this.SimpleButton_Referesh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
            this.SimpleButton_Referesh.Size = new System.Drawing.Size(83, 38);
            this.SimpleButton_Referesh.TabIndex = 14;
            this.SimpleButton_Referesh.Tag = "Refresh";
            this.SimpleButton_Referesh.Text = "Refresh ";
            this.SimpleButton_Referesh.Click += new System.EventHandler(this.SimpleButton_Referesh_Click);
            // 
            // LabelControl_SimpleButton_Referesh
            // 
            this.LabelControl_SimpleButton_Referesh.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Referesh.Name = "LabelControl_SimpleButton_Referesh";
            this.LabelControl_SimpleButton_Referesh.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_Referesh.TabIndex = 0;
            // 
            // SimpleButton_Referesh_A
            // 
            this.SimpleButton_Referesh_A.Location = new System.Drawing.Point(8, 437);
            this.SimpleButton_Referesh_A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_Referesh_A.Name = "SimpleButton_Referesh_A";
            this.SimpleButton_Referesh_A.Size = new System.Drawing.Size(83, 38);
            this.SimpleButton_Referesh_A.TabIndex = 2;
            this.SimpleButton_Referesh_A.Tag = "Refresh_A";
            this.SimpleButton_Referesh_A.Text = "Refresh_A ";
            this.SimpleButton_Referesh_A.Visible = false;
            this.SimpleButton_Referesh_A.Click += new System.EventHandler(this.SimpleButton_Referesh_A_Click);
            // 
            // LabelControl_SimpleButton_Referesh_A
            // 
            this.LabelControl_SimpleButton_Referesh_A.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Referesh_A.Name = "LabelControl_SimpleButton_Referesh_A";
            this.LabelControl_SimpleButton_Referesh_A.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_Referesh_A.TabIndex = 0;
            // 
            // SimpleButton_Delete
            // 
            this.SimpleButton_Delete.Location = new System.Drawing.Point(351, 327);
            this.SimpleButton_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_Delete.Name = "SimpleButton_Delete";
            this.SimpleButton_Delete.Size = new System.Drawing.Size(83, 38);
            this.SimpleButton_Delete.TabIndex = 13;
            this.SimpleButton_Delete.Tag = "Delete";
            this.SimpleButton_Delete.Text = "Delete ";
            this.SimpleButton_Delete.Click += new System.EventHandler(this.SimpleButton_Delete_Click);
            // 
            // LabelControl_SimpleButton_Delete
            // 
            this.LabelControl_SimpleButton_Delete.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Delete.Name = "LabelControl_SimpleButton_Delete";
            this.LabelControl_SimpleButton_Delete.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_Delete.TabIndex = 0;
            // 
            // SimpleButton_Save
            // 
            this.SimpleButton_Save.Location = new System.Drawing.Point(441, 327);
            this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_Save.Name = "SimpleButton_Save";
            this.SimpleButton_Save.Size = new System.Drawing.Size(83, 38);
            this.SimpleButton_Save.TabIndex = 12;
            this.SimpleButton_Save.Tag = "Save";
            this.SimpleButton_Save.Text = "Save ";
            this.SimpleButton_Save.Click += new System.EventHandler(this.SimpleButton_Save_Click);
            // 
            // LabelControl_SimpleButton_Save
            // 
            this.LabelControl_SimpleButton_Save.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Save.Name = "LabelControl_SimpleButton_Save";
            this.LabelControl_SimpleButton_Save.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_Save.TabIndex = 0;
            // 
            // SimpleButton_Exit
            // 
            this.SimpleButton_Exit.Location = new System.Drawing.Point(531, 327);
            this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SimpleButton_Exit.Name = "SimpleButton_Exit";
            this.SimpleButton_Exit.Size = new System.Drawing.Size(83, 38);
            this.SimpleButton_Exit.TabIndex = 15;
            this.SimpleButton_Exit.Tag = "Exit";
            this.SimpleButton_Exit.Text = "Exit ";
            this.SimpleButton_Exit.Click += new System.EventHandler(this.SimpleButton_Exit_Click);
            // 
            // LabelControl_SimpleButton_Exit
            // 
            this.LabelControl_SimpleButton_Exit.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Exit.Name = "LabelControl_SimpleButton_Exit";
            this.LabelControl_SimpleButton_Exit.Size = new System.Drawing.Size(0, 19);
            this.LabelControl_SimpleButton_Exit.TabIndex = 0;
            // 
            // TextEdit_PRODUCT_name
            // 
            this.TextEdit_PRODUCT_name.EnterMoveNextControl = true;
            this.TextEdit_PRODUCT_name.Location = new System.Drawing.Point(98, 86);
            this.TextEdit_PRODUCT_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_name.Name = "TextEdit_PRODUCT_name";
            this.TextEdit_PRODUCT_name.Size = new System.Drawing.Size(516, 22);
            this.TextEdit_PRODUCT_name.TabIndex = 2;
            this.TextEdit_PRODUCT_name.Tag = "N_T_V";
            // 
            // LabelControl_TextEdit_PRODUCT_name
            // 
            this.LabelControl_TextEdit_PRODUCT_name.Location = new System.Drawing.Point(51, 90);
            this.LabelControl_TextEdit_PRODUCT_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_TextEdit_PRODUCT_name.Name = "LabelControl_TextEdit_PRODUCT_name";
            this.LabelControl_TextEdit_PRODUCT_name.Size = new System.Drawing.Size(42, 16);
            this.LabelControl_TextEdit_PRODUCT_name.TabIndex = 2;
            this.LabelControl_TextEdit_PRODUCT_name.Text = "Name :";
            // 
            // GridLookUpEdit_PRODUCT_packing
            // 
            this.GridLookUpEdit_PRODUCT_packing.EnterMoveNextControl = true;
            this.GridLookUpEdit_PRODUCT_packing.Location = new System.Drawing.Point(98, 118);
            this.GridLookUpEdit_PRODUCT_packing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridLookUpEdit_PRODUCT_packing.Name = "GridLookUpEdit_PRODUCT_packing";
            this.GridLookUpEdit_PRODUCT_packing.Properties.View = this.GridLookUpEdit_PRODUCT_packingView;
            this.GridLookUpEdit_PRODUCT_packing.Size = new System.Drawing.Size(349, 22);
            this.GridLookUpEdit_PRODUCT_packing.TabIndex = 3;
            this.GridLookUpEdit_PRODUCT_packing.Tag = "N_T_V";
            this.GridLookUpEdit_PRODUCT_packing.EditValueChanged += new System.EventHandler(this.GridLookUpEdit_PRODUCT_packing_EditValueChanged);
            this.GridLookUpEdit_PRODUCT_packing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridLookUpEdit_PRODUCT_packing_KeyDown);
            // 
            // GridLookUpEdit_PRODUCT_packingView
            // 
            this.GridLookUpEdit_PRODUCT_packingView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit_PRODUCT_packingView.Name = "GridLookUpEdit_PRODUCT_packingView";
            this.GridLookUpEdit_PRODUCT_packingView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit_PRODUCT_packingView.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl_GridLookUpEdit_PRODUCT_packing
            // 
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.Location = new System.Drawing.Point(41, 122);
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.Name = "LabelControl_GridLookUpEdit_PRODUCT_packing";
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.Size = new System.Drawing.Size(52, 16);
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.TabIndex = 2;
            this.LabelControl_GridLookUpEdit_PRODUCT_packing.Text = "Packing :";
            // 
            // LabelControl_TextEdit_PRODUCT_defaultLevel
            // 
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.Location = new System.Drawing.Point(454, 122);
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.Name = "LabelControl_TextEdit_PRODUCT_defaultLevel";
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.Size = new System.Drawing.Size(82, 16);
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.TabIndex = 2;
            this.LabelControl_TextEdit_PRODUCT_defaultLevel.Text = "Default Level :";
            // 
            // GridLookUpEdit_PRODUCT_department
            // 
            this.GridLookUpEdit_PRODUCT_department.EnterMoveNextControl = true;
            this.GridLookUpEdit_PRODUCT_department.Location = new System.Drawing.Point(98, 150);
            this.GridLookUpEdit_PRODUCT_department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridLookUpEdit_PRODUCT_department.Name = "GridLookUpEdit_PRODUCT_department";
            this.GridLookUpEdit_PRODUCT_department.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.GridLookUpEdit_PRODUCT_department.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.GridLookUpEdit_PRODUCT_department.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.GridLookUpEdit_PRODUCT_department.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.GridLookUpEdit_PRODUCT_department.Properties.View = this.GridLookUpEdit_PRODUCT_departmentView;
            this.GridLookUpEdit_PRODUCT_department.Size = new System.Drawing.Size(349, 22);
            this.GridLookUpEdit_PRODUCT_department.TabIndex = 5;
            this.GridLookUpEdit_PRODUCT_department.Tag = "N_T_V";
            this.GridLookUpEdit_PRODUCT_department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridLookUpEdit_PRODUCT_department_KeyDown);
            // 
            // GridLookUpEdit_PRODUCT_departmentView
            // 
            this.GridLookUpEdit_PRODUCT_departmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GridLookUpEdit_PRODUCT_departmentView.Name = "GridLookUpEdit_PRODUCT_departmentView";
            this.GridLookUpEdit_PRODUCT_departmentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridLookUpEdit_PRODUCT_departmentView.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl_GridLookUpEdit_PRODUCT_department
            // 
            this.LabelControl_GridLookUpEdit_PRODUCT_department.Location = new System.Drawing.Point(16, 154);
            this.LabelControl_GridLookUpEdit_PRODUCT_department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_GridLookUpEdit_PRODUCT_department.Name = "LabelControl_GridLookUpEdit_PRODUCT_department";
            this.LabelControl_GridLookUpEdit_PRODUCT_department.Size = new System.Drawing.Size(76, 16);
            this.LabelControl_GridLookUpEdit_PRODUCT_department.TabIndex = 2;
            this.LabelControl_GridLookUpEdit_PRODUCT_department.Text = "Department :";
            // 
            // TextEdit_PRODUCT_saleRate
            // 
            this.TextEdit_PRODUCT_saleRate.EnterMoveNextControl = true;
            this.TextEdit_PRODUCT_saleRate.Location = new System.Drawing.Point(98, 182);
            this.TextEdit_PRODUCT_saleRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_saleRate.Name = "TextEdit_PRODUCT_saleRate";
            this.TextEdit_PRODUCT_saleRate.Size = new System.Drawing.Size(141, 22);
            this.TextEdit_PRODUCT_saleRate.TabIndex = 6;
            this.TextEdit_PRODUCT_saleRate.Tag = "N1_T_V";
            // 
            // LabelControl_TextEdit_PRODUCT_saleRate
            // 
            this.LabelControl_TextEdit_PRODUCT_saleRate.Location = new System.Drawing.Point(29, 186);
            this.LabelControl_TextEdit_PRODUCT_saleRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_TextEdit_PRODUCT_saleRate.Name = "LabelControl_TextEdit_PRODUCT_saleRate";
            this.LabelControl_TextEdit_PRODUCT_saleRate.Size = new System.Drawing.Size(64, 16);
            this.LabelControl_TextEdit_PRODUCT_saleRate.TabIndex = 2;
            this.LabelControl_TextEdit_PRODUCT_saleRate.Text = "Sale Rate :";
            // 
            // TextEdit_PRODUCT_purchaseRate
            // 
            this.TextEdit_PRODUCT_purchaseRate.EnterMoveNextControl = true;
            this.TextEdit_PRODUCT_purchaseRate.Location = new System.Drawing.Point(342, 182);
            this.TextEdit_PRODUCT_purchaseRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_purchaseRate.Name = "TextEdit_PRODUCT_purchaseRate";
            this.TextEdit_PRODUCT_purchaseRate.Size = new System.Drawing.Size(105, 22);
            this.TextEdit_PRODUCT_purchaseRate.TabIndex = 7;
            this.TextEdit_PRODUCT_purchaseRate.Tag = "N1_T_V";
            // 
            // LabelControl_TextEdit_PRODUCT_purchaseRate
            // 
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.Location = new System.Drawing.Point(245, 186);
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.Name = "LabelControl_TextEdit_PRODUCT_purchaseRate";
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.Size = new System.Drawing.Size(91, 16);
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.TabIndex = 2;
            this.LabelControl_TextEdit_PRODUCT_purchaseRate.Text = "Purchase Rate :";
            // 
            // TextEdit_PRODUCT_barCode
            // 
            this.TextEdit_PRODUCT_barCode.EditValue = "";
            this.TextEdit_PRODUCT_barCode.EnterMoveNextControl = true;
            this.TextEdit_PRODUCT_barCode.Location = new System.Drawing.Point(119, 214);
            this.TextEdit_PRODUCT_barCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_barCode.Name = "TextEdit_PRODUCT_barCode";
            this.TextEdit_PRODUCT_barCode.Size = new System.Drawing.Size(120, 22);
            this.TextEdit_PRODUCT_barCode.TabIndex = 8;
            this.TextEdit_PRODUCT_barCode.Tag = "N_T_N";
            // 
            // LabelControl_TextEdit_PRODUCT_barCode
            // 
            this.LabelControl_TextEdit_PRODUCT_barCode.Location = new System.Drawing.Point(35, 218);
            this.LabelControl_TextEdit_PRODUCT_barCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl_TextEdit_PRODUCT_barCode.Name = "LabelControl_TextEdit_PRODUCT_barCode";
            this.LabelControl_TextEdit_PRODUCT_barCode.Size = new System.Drawing.Size(57, 16);
            this.LabelControl_TextEdit_PRODUCT_barCode.TabIndex = 2;
            this.LabelControl_TextEdit_PRODUCT_barCode.Text = "BarCode :";
            // 
            // CheckEdit_PRODUCT_isService
            // 
            this.CheckEdit_PRODUCT_isService.EditValue = true;
            this.CheckEdit_PRODUCT_isService.EnterMoveNextControl = true;
            this.CheckEdit_PRODUCT_isService.Location = new System.Drawing.Point(97, 217);
            this.CheckEdit_PRODUCT_isService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckEdit_PRODUCT_isService.Name = "CheckEdit_PRODUCT_isService";
            this.CheckEdit_PRODUCT_isService.Properties.Caption = "";
            this.CheckEdit_PRODUCT_isService.Size = new System.Drawing.Size(16, 19);
            this.CheckEdit_PRODUCT_isService.TabIndex = 9;
            this.CheckEdit_PRODUCT_isService.Tag = "N_N";
            this.CheckEdit_PRODUCT_isService.CheckedChanged += new System.EventHandler(this.CheckEdit_PRODUCT_isService_CheckedChanged);
            // 
            // TextEdit_PRODUCT_defaultLevel
            // 
            this.TextEdit_PRODUCT_defaultLevel.Location = new System.Drawing.Point(542, 118);
            this.TextEdit_PRODUCT_defaultLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit_PRODUCT_defaultLevel.Name = "TextEdit_PRODUCT_defaultLevel";
            this.TextEdit_PRODUCT_defaultLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextEdit_PRODUCT_defaultLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TextEdit_PRODUCT_defaultLevel.Size = new System.Drawing.Size(71, 22);
            this.TextEdit_PRODUCT_defaultLevel.TabIndex = 4;
            this.TextEdit_PRODUCT_defaultLevel.Tag = "N_T_V";
            this.TextEdit_PRODUCT_defaultLevel.SelectedIndexChanged += new System.EventHandler(this.TextEdit_PRODUCT_defaultLevel_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(153, 327);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 38);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Tag = "";
            this.simpleButton1.Text = "Bar Code Writer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton13);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textEdit_printHowMany);
            this.groupControl1.Location = new System.Drawing.Point(621, 90);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 112);
            this.groupControl1.TabIndex = 140;
            this.groupControl1.Text = "Print Articals";
            // 
            // simpleButton13
            // 
            this.simpleButton13.Location = new System.Drawing.Point(210, 62);
            this.simpleButton13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(64, 32);
            this.simpleButton13.TabIndex = 140;
            this.simpleButton13.Tag = "Layout1_Delete";
            this.simpleButton13.Text = "Print";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(26, 33);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 16);
            this.labelControl7.TabIndex = 75;
            this.labelControl7.Text = "No Off Copies :";
            // 
            // textEdit_printHowMany
            // 
            this.textEdit_printHowMany.Location = new System.Drawing.Point(115, 30);
            this.textEdit_printHowMany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit_printHowMany.Name = "textEdit_printHowMany";
            this.textEdit_printHowMany.Size = new System.Drawing.Size(159, 22);
            this.textEdit_printHowMany.TabIndex = 138;
            this.textEdit_printHowMany.Tag = "d_T_N_N_layout1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(45, 327);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 38);
            this.simpleButton2.TabIndex = 141;
            this.simpleButton2.Tag = "";
            this.simpleButton2.Text = "Rate Adjustment";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frm_TBL_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 590);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.PanelControl_Default);
            this.Controls.Add(this.ListBoxControl_Rights);
            this.Controls.Add(this.labelControl_TextBox_PRODUCT_ID);
            this.Controls.Add(this.TextEdit_PRODUCT_ID);
            this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
            this.Controls.Add(this.DataNavigator_Navigate);
            this.Controls.Add(this.CheckEdit_navigate);
            this.Controls.Add(this.SimpleButton_List);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SimpleButton_Referesh);
            this.Controls.Add(this.SimpleButton_Referesh_A);
            this.Controls.Add(this.SimpleButton_Delete);
            this.Controls.Add(this.SimpleButton_Save);
            this.Controls.Add(this.SimpleButton_Exit);
            this.Controls.Add(this.TextEdit_PRODUCT_name);
            this.Controls.Add(this.LabelControl_TextEdit_PRODUCT_name);
            this.Controls.Add(this.GridLookUpEdit_PRODUCT_packing);
            this.Controls.Add(this.LabelControl_GridLookUpEdit_PRODUCT_packing);
            this.Controls.Add(this.LabelControl_TextEdit_PRODUCT_defaultLevel);
            this.Controls.Add(this.GridLookUpEdit_PRODUCT_department);
            this.Controls.Add(this.LabelControl_GridLookUpEdit_PRODUCT_department);
            this.Controls.Add(this.TextEdit_PRODUCT_saleRate);
            this.Controls.Add(this.LabelControl_TextEdit_PRODUCT_saleRate);
            this.Controls.Add(this.TextEdit_PRODUCT_purchaseRate);
            this.Controls.Add(this.LabelControl_TextEdit_PRODUCT_purchaseRate);
            this.Controls.Add(this.TextEdit_PRODUCT_barCode);
            this.Controls.Add(this.LabelControl_TextEdit_PRODUCT_barCode);
            this.Controls.Add(this.CheckEdit_PRODUCT_isService);
            this.Controls.Add(this.TextEdit_PRODUCT_defaultLevel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1110, 622);
            this.MinimumSize = new System.Drawing.Size(660, 354);
            this.Name = "frm_TBL_PRODUCTS";
            this.Tag = "TBL_PRODUCTS";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frm_TBL_PRODUCTS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_PRODUCTS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_packing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_packingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_PRODUCT_departmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_saleRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_purchaseRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_barCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_PRODUCT_isService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_PRODUCT_defaultLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_printHowMany.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

        private PanelControl PanelControl_Default;
        public LabelControl labelControl_TextBox_PRODUCT_ID;
        public TextEdit TextEdit_PRODUCT_ID;
        public CheckEdit CheckEdit_Is_AutoGenegereted;
        public DataNavigator DataNavigator_Navigate;
        public CheckEdit CheckEdit_navigate;

        public SimpleButton SimpleButton_List;
        public LabelControl LabelControl_SimpleButton_List;

        public SimpleButton SimpleButton_Referesh;
        public LabelControl LabelControl_SimpleButton_Referesh;

        public SimpleButton SimpleButton_Referesh_A;
        public LabelControl LabelControl_SimpleButton_Referesh_A;

        public SimpleButton SimpleButton_Delete;
        public LabelControl LabelControl_SimpleButton_Delete;

        public SimpleButton SimpleButton_Save;
        public LabelControl LabelControl_SimpleButton_Save;

        public SimpleButton SimpleButton_Exit;
        public LabelControl LabelControl_SimpleButton_Exit;


        public TextEdit TextEdit_PRODUCT_name;
        public LabelControl LabelControl_TextEdit_PRODUCT_name;

        public GridLookUpEdit GridLookUpEdit_PRODUCT_packing;
        public GridView GridView_PRODUCT_packing;
        public LabelControl LabelControl_GridLookUpEdit_PRODUCT_packing;
        public LabelControl LabelControl_TextEdit_PRODUCT_defaultLevel;

        public GridLookUpEdit GridLookUpEdit_PRODUCT_department;
        public GridView GridView_PRODUCT_department;
        public LabelControl LabelControl_GridLookUpEdit_PRODUCT_department;


        public TextEdit TextEdit_PRODUCT_saleRate;
        public LabelControl LabelControl_TextEdit_PRODUCT_saleRate;

        public TextEdit TextEdit_PRODUCT_purchaseRate;
        public LabelControl LabelControl_TextEdit_PRODUCT_purchaseRate;

        public TextEdit TextEdit_PRODUCT_barCode;
        public LabelControl LabelControl_TextEdit_PRODUCT_barCode;

        public CheckEdit CheckEdit_PRODUCT_isService;
        public GridView GridLookUpEdit_PRODUCT_packingView;
        public GridView GridLookUpEdit_PRODUCT_departmentView;
        public ComboBoxEdit TextEdit_PRODUCT_defaultLevel;
        public SimpleButton simpleButton1;
        private GroupControl groupControl1;
        public SimpleButton simpleButton13;
        public LabelControl labelControl7;
        public TextEdit textEdit_printHowMany;
        public SimpleButton simpleButton2;




    }
}