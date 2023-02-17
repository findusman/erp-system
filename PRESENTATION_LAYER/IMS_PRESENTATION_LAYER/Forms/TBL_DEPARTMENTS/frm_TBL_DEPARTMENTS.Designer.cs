using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_DEPARTMENTS
{
    partial class frm_TBL_DEPARTMENTS
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
                  this.labelControl_TextBox_DEPARTMENT_ID = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_DEPARTMENT_ID = new DevExpress.XtraEditors.TextEdit();
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
                  this.TextEdit_DEPARTMENT_name = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_DEPARTMENT_name = new DevExpress.XtraEditors.LabelControl();
                  this.LabelControl_MemoEdit_DEPARTMENT_narration = new DevExpress.XtraEditors.LabelControl();
                  this.MemoEdit_DEPARTMENT_narration = new DevExpress.XtraEditors.MemoEdit();
                  this.GridLookUpEdit_DEPARTMENT_parentID = new DevExpress.XtraEditors.GridLookUpEdit();
                  this.GridLookUpEdit_CUSTOMER_departmentView = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department = new DevExpress.XtraEditors.LabelControl();
                  this.checkEdit_DEPARTMENT_isParent = new DevExpress.XtraEditors.CheckEdit();
                  this.ComboBoxEdit_Stocklevel = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.checkEdit_DEPARTMENT_stockIsLtr = new DevExpress.XtraEditors.CheckEdit();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_DEPARTMENT_ID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_DEPARTMENT_name.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_DEPARTMENT_narration.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_DEPARTMENT_parentID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_CUSTOMER_departmentView)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DEPARTMENT_isParent.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_Stocklevel.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DEPARTMENT_stockIsLtr.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(1239, 200);
                  this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(4);
                  this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
                  this.ListBoxControl_Rights.Size = new System.Drawing.Size(264, 409);
                  this.ListBoxControl_Rights.TabIndex = 27;
                  this.ListBoxControl_Rights.Visible = false;
                  // 
                  // PanelControl_Default
                  // 
                  this.PanelControl_Default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.PanelControl_Default.Location = new System.Drawing.Point(-4, 58);
                  this.PanelControl_Default.Margin = new System.Windows.Forms.Padding(4);
                  this.PanelControl_Default.Name = "PanelControl_Default";
                  this.PanelControl_Default.Size = new System.Drawing.Size(1002, 10);
                  this.PanelControl_Default.TabIndex = 6;
                  // 
                  // labelControl_TextBox_DEPARTMENT_ID
                  // 
                  this.labelControl_TextBox_DEPARTMENT_ID.Location = new System.Drawing.Point(92, 22);
                  this.labelControl_TextBox_DEPARTMENT_ID.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl_TextBox_DEPARTMENT_ID.Name = "labelControl_TextBox_DEPARTMENT_ID";
                  this.labelControl_TextBox_DEPARTMENT_ID.Size = new System.Drawing.Size(28, 19);
                  this.labelControl_TextBox_DEPARTMENT_ID.TabIndex = 7;
                  this.labelControl_TextBox_DEPARTMENT_ID.Text = "ID :";
                  // 
                  // TextEdit_DEPARTMENT_ID
                  // 
                  this.TextEdit_DEPARTMENT_ID.Location = new System.Drawing.Point(128, 16);
                  this.TextEdit_DEPARTMENT_ID.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_DEPARTMENT_ID.Name = "TextEdit_DEPARTMENT_ID";
                  this.TextEdit_DEPARTMENT_ID.Size = new System.Drawing.Size(93, 26);
                  this.TextEdit_DEPARTMENT_ID.TabIndex = 0;
                  this.TextEdit_DEPARTMENT_ID.Tag = "N_T_V";
                  this.TextEdit_DEPARTMENT_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_DEPARTMENT_ID_KeyDown);
                  this.TextEdit_DEPARTMENT_ID.Leave += new System.EventHandler(this.TextEdit_DEPARTMENT_ID_Leave);
                  // 
                  // CheckEdit_Is_AutoGenegereted
                  // 
                  this.CheckEdit_Is_AutoGenegereted.EditValue = true;
                  this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(792, 16);
                  this.CheckEdit_Is_AutoGenegereted.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
                  this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(150, 23);
                  this.CheckEdit_Is_AutoGenegereted.TabIndex = 2;
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
                  this.DataNavigator_Navigate.Location = new System.Drawing.Point(337, 16);
                  this.DataNavigator_Navigate.Margin = new System.Windows.Forms.Padding(4);
                  this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
                  this.DataNavigator_Navigate.Size = new System.Drawing.Size(441, 27);
                  this.DataNavigator_Navigate.TabIndex = 6;
                  this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
                  this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
                  // 
                  // CheckEdit_navigate
                  // 
                  this.CheckEdit_navigate.Location = new System.Drawing.Point(301, 19);
                  this.CheckEdit_navigate.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_navigate.Name = "CheckEdit_navigate";
                  this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_navigate.Properties.Caption = "";
                  this.CheckEdit_navigate.Size = new System.Drawing.Size(28, 19);
                  this.CheckEdit_navigate.TabIndex = 5;
                  this.CheckEdit_navigate.Tag = "F";
                  this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
                  // 
                  // SimpleButton_List
                  // 
                  this.SimpleButton_List.Location = new System.Drawing.Point(228, 16);
                  this.SimpleButton_List.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_List.Name = "SimpleButton_List";
                  this.SimpleButton_List.Size = new System.Drawing.Size(65, 29);
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
                  this.SimpleButton_Referesh.Location = new System.Drawing.Point(524, 317);
                  this.SimpleButton_Referesh.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
                  this.SimpleButton_Referesh.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Referesh.TabIndex = 9;
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
                  this.SimpleButton_Referesh_A.Location = new System.Drawing.Point(1092, 123);
                  this.SimpleButton_Referesh_A.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Referesh_A.Name = "SimpleButton_Referesh_A";
                  this.SimpleButton_Referesh_A.Size = new System.Drawing.Size(106, 45);
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
                  this.SimpleButton_Delete.Location = new System.Drawing.Point(639, 317);
                  this.SimpleButton_Delete.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Delete.Name = "SimpleButton_Delete";
                  this.SimpleButton_Delete.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Delete.TabIndex = 8;
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
                  this.SimpleButton_Save.Location = new System.Drawing.Point(754, 317);
                  this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Save.Name = "SimpleButton_Save";
                  this.SimpleButton_Save.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Save.TabIndex = 7;
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
                  this.SimpleButton_Exit.Location = new System.Drawing.Point(870, 317);
                  this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Exit.Name = "SimpleButton_Exit";
                  this.SimpleButton_Exit.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Exit.TabIndex = 10;
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
                  // TextEdit_DEPARTMENT_name
                  // 
                  this.TextEdit_DEPARTMENT_name.EnterMoveNextControl = true;
                  this.TextEdit_DEPARTMENT_name.Location = new System.Drawing.Point(160, 76);
                  this.TextEdit_DEPARTMENT_name.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_DEPARTMENT_name.Name = "TextEdit_DEPARTMENT_name";
                  this.TextEdit_DEPARTMENT_name.Size = new System.Drawing.Size(672, 26);
                  this.TextEdit_DEPARTMENT_name.TabIndex = 3;
                  this.TextEdit_DEPARTMENT_name.Tag = "N_T_V";
                  // 
                  // LabelControl_TextEdit_DEPARTMENT_name
                  // 
                  this.LabelControl_TextEdit_DEPARTMENT_name.Location = new System.Drawing.Point(104, 79);
                  this.LabelControl_TextEdit_DEPARTMENT_name.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_TextEdit_DEPARTMENT_name.Name = "LabelControl_TextEdit_DEPARTMENT_name";
                  this.LabelControl_TextEdit_DEPARTMENT_name.Size = new System.Drawing.Size(52, 19);
                  this.LabelControl_TextEdit_DEPARTMENT_name.TabIndex = 2;
                  this.LabelControl_TextEdit_DEPARTMENT_name.Text = "Name :";
                  // 
                  // LabelControl_MemoEdit_DEPARTMENT_narration
                  // 
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.Location = new System.Drawing.Point(79, 148);
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.Name = "LabelControl_MemoEdit_DEPARTMENT_narration";
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.Size = new System.Drawing.Size(77, 19);
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.TabIndex = 2;
                  this.LabelControl_MemoEdit_DEPARTMENT_narration.Text = "Narration :";
                  // 
                  // MemoEdit_DEPARTMENT_narration
                  // 
                  this.MemoEdit_DEPARTMENT_narration.Location = new System.Drawing.Point(160, 144);
                  this.MemoEdit_DEPARTMENT_narration.Margin = new System.Windows.Forms.Padding(4);
                  this.MemoEdit_DEPARTMENT_narration.Name = "MemoEdit_DEPARTMENT_narration";
                  this.MemoEdit_DEPARTMENT_narration.Size = new System.Drawing.Size(379, 76);
                  this.MemoEdit_DEPARTMENT_narration.TabIndex = 4;
                  this.MemoEdit_DEPARTMENT_narration.Tag = "N_T_N";
                  this.MemoEdit_DEPARTMENT_narration.UseOptimizedRendering = true;
                  // 
                  // GridLookUpEdit_DEPARTMENT_parentID
                  // 
                  this.GridLookUpEdit_DEPARTMENT_parentID.Enabled = false;
                  this.GridLookUpEdit_DEPARTMENT_parentID.EnterMoveNextControl = true;
                  this.GridLookUpEdit_DEPARTMENT_parentID.Location = new System.Drawing.Point(197, 110);
                  this.GridLookUpEdit_DEPARTMENT_parentID.Margin = new System.Windows.Forms.Padding(4);
                  this.GridLookUpEdit_DEPARTMENT_parentID.Name = "GridLookUpEdit_DEPARTMENT_parentID";
                  this.GridLookUpEdit_DEPARTMENT_parentID.Properties.View = this.GridLookUpEdit_CUSTOMER_departmentView;
                  this.GridLookUpEdit_DEPARTMENT_parentID.Size = new System.Drawing.Size(342, 26);
                  this.GridLookUpEdit_DEPARTMENT_parentID.TabIndex = 29;
                  this.GridLookUpEdit_DEPARTMENT_parentID.Tag = "N_T_V";
                  // 
                  // GridLookUpEdit_CUSTOMER_departmentView
                  // 
                  this.GridLookUpEdit_CUSTOMER_departmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                  this.GridLookUpEdit_CUSTOMER_departmentView.Name = "GridLookUpEdit_CUSTOMER_departmentView";
                  this.GridLookUpEdit_CUSTOMER_departmentView.OptionsSelection.EnableAppearanceFocusedCell = false;
                  this.GridLookUpEdit_CUSTOMER_departmentView.OptionsView.ShowGroupPanel = false;
                  // 
                  // LabelControl_GridLookUpEdit_CUSTOMER_department
                  // 
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.Location = new System.Drawing.Point(74, 113);
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.Name = "LabelControl_GridLookUpEdit_CUSTOMER_department";
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.Size = new System.Drawing.Size(82, 19);
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.TabIndex = 28;
                  this.LabelControl_GridLookUpEdit_CUSTOMER_department.Text = "Child Of ? :";
                  // 
                  // checkEdit_DEPARTMENT_isParent
                  // 
                  this.checkEdit_DEPARTMENT_isParent.Location = new System.Drawing.Point(164, 112);
                  this.checkEdit_DEPARTMENT_isParent.Margin = new System.Windows.Forms.Padding(4);
                  this.checkEdit_DEPARTMENT_isParent.Name = "checkEdit_DEPARTMENT_isParent";
                  this.checkEdit_DEPARTMENT_isParent.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.checkEdit_DEPARTMENT_isParent.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.checkEdit_DEPARTMENT_isParent.Properties.Caption = "";
                  this.checkEdit_DEPARTMENT_isParent.Size = new System.Drawing.Size(25, 19);
                  this.checkEdit_DEPARTMENT_isParent.TabIndex = 42;
                  this.checkEdit_DEPARTMENT_isParent.Tag = "F";
                  this.checkEdit_DEPARTMENT_isParent.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
                  // 
                  // ComboBoxEdit_Stocklevel
                  // 
                  this.ComboBoxEdit_Stocklevel.EditValue = false;
                  this.ComboBoxEdit_Stocklevel.Location = new System.Drawing.Point(556, 113);
                  this.ComboBoxEdit_Stocklevel.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_Stocklevel.Name = "ComboBoxEdit_Stocklevel";
                  this.ComboBoxEdit_Stocklevel.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.ComboBoxEdit_Stocklevel.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.ComboBoxEdit_Stocklevel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                  this.ComboBoxEdit_Stocklevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_Stocklevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
                  this.ComboBoxEdit_Stocklevel.Size = new System.Drawing.Size(135, 24);
                  this.ComboBoxEdit_Stocklevel.TabIndex = 42;
                  this.ComboBoxEdit_Stocklevel.Tag = "N_T_V";
                  // 
                  // checkEdit_DEPARTMENT_stockIsLtr
                  // 
                  this.checkEdit_DEPARTMENT_stockIsLtr.Location = new System.Drawing.Point(699, 115);
                  this.checkEdit_DEPARTMENT_stockIsLtr.Margin = new System.Windows.Forms.Padding(4);
                  this.checkEdit_DEPARTMENT_stockIsLtr.Name = "checkEdit_DEPARTMENT_stockIsLtr";
                  this.checkEdit_DEPARTMENT_stockIsLtr.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.checkEdit_DEPARTMENT_stockIsLtr.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.checkEdit_DEPARTMENT_stockIsLtr.Properties.Caption = "";
                  this.checkEdit_DEPARTMENT_stockIsLtr.Size = new System.Drawing.Size(25, 19);
                  this.checkEdit_DEPARTMENT_stockIsLtr.TabIndex = 42;
                  this.checkEdit_DEPARTMENT_stockIsLtr.Tag = "T";
                  this.checkEdit_DEPARTMENT_stockIsLtr.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
                  // 
                  // frm_TBL_DEPARTMENTS
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(994, 373);
                  this.Controls.Add(this.checkEdit_DEPARTMENT_stockIsLtr);
                  this.Controls.Add(this.checkEdit_DEPARTMENT_isParent);
                  this.Controls.Add(this.GridLookUpEdit_DEPARTMENT_parentID);
                  this.Controls.Add(this.LabelControl_GridLookUpEdit_CUSTOMER_department);
                  this.Controls.Add(this.PanelControl_Default);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.Controls.Add(this.labelControl_TextBox_DEPARTMENT_ID);
                  this.Controls.Add(this.TextEdit_DEPARTMENT_ID);
                  this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
                  this.Controls.Add(this.DataNavigator_Navigate);
                  this.Controls.Add(this.CheckEdit_navigate);
                  this.Controls.Add(this.SimpleButton_List);
                  this.Controls.Add(this.SimpleButton_Referesh);
                  this.Controls.Add(this.SimpleButton_Referesh_A);
                  this.Controls.Add(this.SimpleButton_Delete);
                  this.Controls.Add(this.SimpleButton_Save);
                  this.Controls.Add(this.SimpleButton_Exit);
                  this.Controls.Add(this.TextEdit_DEPARTMENT_name);
                  this.Controls.Add(this.LabelControl_TextEdit_DEPARTMENT_name);
                  this.Controls.Add(this.LabelControl_MemoEdit_DEPARTMENT_narration);
                  this.Controls.Add(this.MemoEdit_DEPARTMENT_narration);
                  this.Controls.Add(this.ComboBoxEdit_Stocklevel);
                  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                  this.KeyPreview = true;
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.MaximumSize = new System.Drawing.Size(1000, 419);
                  this.MinimumSize = new System.Drawing.Size(1000, 283);
                  this.Name = "frm_TBL_DEPARTMENTS";
                  this.Tag = "TBL_DEPARTMENTS";
                  this.Text = "Departments";
                  this.Load += new System.EventHandler(this.frm_TBL_DEPARTMENTS_Load);
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_DEPARTMENTS_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_DEPARTMENT_ID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_DEPARTMENT_name.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_DEPARTMENT_narration.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_DEPARTMENT_parentID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_CUSTOMER_departmentView)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DEPARTMENT_isParent.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_Stocklevel.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.checkEdit_DEPARTMENT_stockIsLtr.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

        private PanelControl PanelControl_Default;
        public LabelControl labelControl_TextBox_DEPARTMENT_ID;
        public TextEdit TextEdit_DEPARTMENT_ID;
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


        public TextEdit TextEdit_DEPARTMENT_name;
        public LabelControl LabelControl_TextEdit_DEPARTMENT_name;
        public LabelControl LabelControl_MemoEdit_DEPARTMENT_narration;
        public MemoEdit MemoEdit_DEPARTMENT_narration;
        public GridLookUpEdit GridLookUpEdit_DEPARTMENT_parentID;
        public GridView GridLookUpEdit_CUSTOMER_departmentView;
        public LabelControl LabelControl_GridLookUpEdit_CUSTOMER_department;
        public CheckEdit checkEdit_DEPARTMENT_isParent;
        public CheckEdit checkEdit_DEPARTMENT_stockIsLtr;
        public ComboBoxEdit ComboBoxEdit_Stocklevel;




    }
}