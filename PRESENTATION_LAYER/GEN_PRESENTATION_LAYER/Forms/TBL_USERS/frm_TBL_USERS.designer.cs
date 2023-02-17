using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_USERS
{
      partial class frm_TBL_USERS
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
                  this.labelControl_TextBox_USERS_ID = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_USERS_ID = new DevExpress.XtraEditors.TextEdit();
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
                  this.GridLookUpEdit_USERS_rightID = new DevExpress.XtraEditors.GridLookUpEdit();
                  this.GridLookUpEdit_USERS_rightIDView = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.LabelControl_GridLookUpEdit_USERS_rightID = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_USERS_name = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_USERS_name = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_USERS_loginID = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_USERS_loginID = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_USERS_password = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_USERS_password = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_USERS_narration = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_USERS_narration = new DevExpress.XtraEditors.LabelControl();
                  this.CheckEdit_USERS_isActive = new DevExpress.XtraEditors.CheckEdit();
                  this.LabelControl_CheckEdit_USERS_isActive = new DevExpress.XtraEditors.LabelControl();
                  this.CheckEdit_ShowPassword = new DevExpress.XtraEditors.CheckEdit();
                  this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_ID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_USERS_rightID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_USERS_rightIDView)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_name.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_loginID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_password.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_narration.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_USERS_isActive.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_ShowPassword.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(987, 200);
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
                  this.PanelControl_Default.Location = new System.Drawing.Point(-21, 58);
                  this.PanelControl_Default.Margin = new System.Windows.Forms.Padding(4);
                  this.PanelControl_Default.Name = "PanelControl_Default";
                  this.PanelControl_Default.Size = new System.Drawing.Size(960, 15);
                  this.PanelControl_Default.TabIndex = 6;
                  // 
                  // labelControl_TextBox_USERS_ID
                  // 
                  this.labelControl_TextBox_USERS_ID.Location = new System.Drawing.Point(45, 23);
                  this.labelControl_TextBox_USERS_ID.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl_TextBox_USERS_ID.Name = "labelControl_TextBox_USERS_ID";
                  this.labelControl_TextBox_USERS_ID.Size = new System.Drawing.Size(28, 19);
                  this.labelControl_TextBox_USERS_ID.TabIndex = 7;
                  this.labelControl_TextBox_USERS_ID.Text = "ID :";
                  // 
                  // TextEdit_USERS_ID
                  // 
                  this.TextEdit_USERS_ID.Location = new System.Drawing.Point(82, 20);
                  this.TextEdit_USERS_ID.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_USERS_ID.Name = "TextEdit_USERS_ID";
                  this.TextEdit_USERS_ID.Size = new System.Drawing.Size(206, 26);
                  this.TextEdit_USERS_ID.TabIndex = 0;
                  this.TextEdit_USERS_ID.Tag = "N_T";
                  this.TextEdit_USERS_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_USERS_ID_KeyDown);
                  this.TextEdit_USERS_ID.Leave += new System.EventHandler(this.TextEdit_USERS_ID_Leave);
                  // 
                  // CheckEdit_Is_AutoGenegereted
                  // 
                  this.CheckEdit_Is_AutoGenegereted.EditValue = true;
                  this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(788, 20);
                  this.CheckEdit_Is_AutoGenegereted.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
                  this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(160, 24);
                  this.CheckEdit_Is_AutoGenegereted.TabIndex = 4;
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
                  this.DataNavigator_Navigate.Location = new System.Drawing.Point(416, 20);
                  this.DataNavigator_Navigate.Margin = new System.Windows.Forms.Padding(4);
                  this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
                  this.DataNavigator_Navigate.Size = new System.Drawing.Size(364, 27);
                  this.DataNavigator_Navigate.TabIndex = 3;
                  this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
                  this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
                  // 
                  // CheckEdit_navigate
                  // 
                  this.CheckEdit_navigate.Location = new System.Drawing.Point(365, 20);
                  this.CheckEdit_navigate.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_navigate.Name = "CheckEdit_navigate";
                  this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_navigate.Properties.Caption = "";
                  this.CheckEdit_navigate.Size = new System.Drawing.Size(26, 24);
                  this.CheckEdit_navigate.TabIndex = 2;
                  this.CheckEdit_navigate.Tag = "F";
                  this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
                  // 
                  // SimpleButton_List
                  // 
                  this.SimpleButton_List.Location = new System.Drawing.Point(298, 20);
                  this.SimpleButton_List.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_List.Name = "SimpleButton_List";
                  this.SimpleButton_List.Size = new System.Drawing.Size(59, 26);
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
                  this.SimpleButton_Referesh.Location = new System.Drawing.Point(465, 405);
                  this.SimpleButton_Referesh.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
                  this.SimpleButton_Referesh.Size = new System.Drawing.Size(106, 45);
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
                  this.SimpleButton_Delete.Location = new System.Drawing.Point(579, 405);
                  this.SimpleButton_Delete.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Delete.Name = "SimpleButton_Delete";
                  this.SimpleButton_Delete.Size = new System.Drawing.Size(106, 45);
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
                  this.SimpleButton_Save.Location = new System.Drawing.Point(693, 405);
                  this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Save.Name = "SimpleButton_Save";
                  this.SimpleButton_Save.Size = new System.Drawing.Size(106, 45);
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
                  this.SimpleButton_Exit.Location = new System.Drawing.Point(807, 405);
                  this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(4);
                  this.SimpleButton_Exit.Name = "SimpleButton_Exit";
                  this.SimpleButton_Exit.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Exit.TabIndex = 16;
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
                  // GridLookUpEdit_USERS_rightID
                  // 
                  this.GridLookUpEdit_USERS_rightID.EnterMoveNextControl = true;
                  this.GridLookUpEdit_USERS_rightID.Location = new System.Drawing.Point(143, 87);
                  this.GridLookUpEdit_USERS_rightID.Margin = new System.Windows.Forms.Padding(4);
                  this.GridLookUpEdit_USERS_rightID.Name = "GridLookUpEdit_USERS_rightID";
                  this.GridLookUpEdit_USERS_rightID.Properties.View = this.GridLookUpEdit_USERS_rightIDView;
                  this.GridLookUpEdit_USERS_rightID.Size = new System.Drawing.Size(195, 26);
                  this.GridLookUpEdit_USERS_rightID.TabIndex = 5;
                  this.GridLookUpEdit_USERS_rightID.Tag = "N_T";
                  this.GridLookUpEdit_USERS_rightID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridLookUpEdit_USERS_rightID_KeyDown);
                  // 
                  // GridLookUpEdit_USERS_rightIDView
                  // 
                  this.GridLookUpEdit_USERS_rightIDView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                  this.GridLookUpEdit_USERS_rightIDView.Name = "GridLookUpEdit_USERS_rightIDView";
                  this.GridLookUpEdit_USERS_rightIDView.OptionsSelection.EnableAppearanceFocusedCell = false;
                  this.GridLookUpEdit_USERS_rightIDView.OptionsView.ShowGroupPanel = false;
                  // 
                  // LabelControl_GridLookUpEdit_USERS_rightID
                  // 
                  this.LabelControl_GridLookUpEdit_USERS_rightID.Location = new System.Drawing.Point(84, 90);
                  this.LabelControl_GridLookUpEdit_USERS_rightID.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_GridLookUpEdit_USERS_rightID.Name = "LabelControl_GridLookUpEdit_USERS_rightID";
                  this.LabelControl_GridLookUpEdit_USERS_rightID.Size = new System.Drawing.Size(55, 19);
                  this.LabelControl_GridLookUpEdit_USERS_rightID.TabIndex = 2;
                  this.LabelControl_GridLookUpEdit_USERS_rightID.Text = "Rights :";
                  // 
                  // TextEdit_USERS_name
                  // 
                  this.TextEdit_USERS_name.EnterMoveNextControl = true;
                  this.TextEdit_USERS_name.Location = new System.Drawing.Point(143, 121);
                  this.TextEdit_USERS_name.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_USERS_name.Name = "TextEdit_USERS_name";
                  this.TextEdit_USERS_name.Size = new System.Drawing.Size(195, 26);
                  this.TextEdit_USERS_name.TabIndex = 6;
                  this.TextEdit_USERS_name.Tag = "N_T";
                  // 
                  // LabelControl_TextEdit_USERS_name
                  // 
                  this.LabelControl_TextEdit_USERS_name.Location = new System.Drawing.Point(87, 124);
                  this.LabelControl_TextEdit_USERS_name.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_TextEdit_USERS_name.Name = "LabelControl_TextEdit_USERS_name";
                  this.LabelControl_TextEdit_USERS_name.Size = new System.Drawing.Size(52, 19);
                  this.LabelControl_TextEdit_USERS_name.TabIndex = 2;
                  this.LabelControl_TextEdit_USERS_name.Text = "Name :";
                  // 
                  // TextEdit_USERS_loginID
                  // 
                  this.TextEdit_USERS_loginID.EnterMoveNextControl = true;
                  this.TextEdit_USERS_loginID.Location = new System.Drawing.Point(143, 155);
                  this.TextEdit_USERS_loginID.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_USERS_loginID.Name = "TextEdit_USERS_loginID";
                  this.TextEdit_USERS_loginID.Size = new System.Drawing.Size(195, 26);
                  this.TextEdit_USERS_loginID.TabIndex = 7;
                  this.TextEdit_USERS_loginID.Tag = "N_T";
                  // 
                  // LabelControl_TextEdit_USERS_loginID
                  // 
                  this.LabelControl_TextEdit_USERS_loginID.Location = new System.Drawing.Point(67, 158);
                  this.LabelControl_TextEdit_USERS_loginID.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_TextEdit_USERS_loginID.Name = "LabelControl_TextEdit_USERS_loginID";
                  this.LabelControl_TextEdit_USERS_loginID.Size = new System.Drawing.Size(72, 19);
                  this.LabelControl_TextEdit_USERS_loginID.TabIndex = 2;
                  this.LabelControl_TextEdit_USERS_loginID.Text = "Login ID :";
                  // 
                  // TextEdit_USERS_password
                  // 
                  this.TextEdit_USERS_password.EnterMoveNextControl = true;
                  this.TextEdit_USERS_password.Location = new System.Drawing.Point(143, 189);
                  this.TextEdit_USERS_password.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_USERS_password.Name = "TextEdit_USERS_password";
                  this.TextEdit_USERS_password.Size = new System.Drawing.Size(195, 26);
                  this.TextEdit_USERS_password.TabIndex = 8;
                  this.TextEdit_USERS_password.Tag = "N_T";
                  // 
                  // LabelControl_TextEdit_USERS_password
                  // 
                  this.LabelControl_TextEdit_USERS_password.Location = new System.Drawing.Point(61, 192);
                  this.LabelControl_TextEdit_USERS_password.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_TextEdit_USERS_password.Name = "LabelControl_TextEdit_USERS_password";
                  this.LabelControl_TextEdit_USERS_password.Size = new System.Drawing.Size(78, 19);
                  this.LabelControl_TextEdit_USERS_password.TabIndex = 2;
                  this.LabelControl_TextEdit_USERS_password.Text = "Password :";
                  // 
                  // TextEdit_USERS_narration
                  // 
                  this.TextEdit_USERS_narration.EnterMoveNextControl = true;
                  this.TextEdit_USERS_narration.Location = new System.Drawing.Point(143, 223);
                  this.TextEdit_USERS_narration.Margin = new System.Windows.Forms.Padding(4);
                  this.TextEdit_USERS_narration.Name = "TextEdit_USERS_narration";
                  this.TextEdit_USERS_narration.Size = new System.Drawing.Size(195, 26);
                  this.TextEdit_USERS_narration.TabIndex = 9;
                  this.TextEdit_USERS_narration.Tag = "N_T";
                  // 
                  // LabelControl_TextEdit_USERS_narration
                  // 
                  this.LabelControl_TextEdit_USERS_narration.Location = new System.Drawing.Point(62, 226);
                  this.LabelControl_TextEdit_USERS_narration.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_TextEdit_USERS_narration.Name = "LabelControl_TextEdit_USERS_narration";
                  this.LabelControl_TextEdit_USERS_narration.Size = new System.Drawing.Size(77, 19);
                  this.LabelControl_TextEdit_USERS_narration.TabIndex = 2;
                  this.LabelControl_TextEdit_USERS_narration.Text = "Narration :";
                  // 
                  // CheckEdit_USERS_isActive
                  // 
                  this.CheckEdit_USERS_isActive.EditValue = true;
                  this.CheckEdit_USERS_isActive.EnterMoveNextControl = true;
                  this.CheckEdit_USERS_isActive.Location = new System.Drawing.Point(141, 257);
                  this.CheckEdit_USERS_isActive.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_USERS_isActive.Name = "CheckEdit_USERS_isActive";
                  this.CheckEdit_USERS_isActive.Properties.Caption = "";
                  this.CheckEdit_USERS_isActive.Size = new System.Drawing.Size(38, 24);
                  this.CheckEdit_USERS_isActive.TabIndex = 11;
                  this.CheckEdit_USERS_isActive.Tag = "N_T";
                  // 
                  // LabelControl_CheckEdit_USERS_isActive
                  // 
                  this.LabelControl_CheckEdit_USERS_isActive.Location = new System.Drawing.Point(67, 259);
                  this.LabelControl_CheckEdit_USERS_isActive.Margin = new System.Windows.Forms.Padding(4);
                  this.LabelControl_CheckEdit_USERS_isActive.Name = "LabelControl_CheckEdit_USERS_isActive";
                  this.LabelControl_CheckEdit_USERS_isActive.Size = new System.Drawing.Size(72, 19);
                  this.LabelControl_CheckEdit_USERS_isActive.TabIndex = 2;
                  this.LabelControl_CheckEdit_USERS_isActive.Text = "Is Active :";
                  // 
                  // CheckEdit_ShowPassword
                  // 
                  this.CheckEdit_ShowPassword.EditValue = true;
                  this.CheckEdit_ShowPassword.EnterMoveNextControl = true;
                  this.CheckEdit_ShowPassword.Location = new System.Drawing.Point(476, 191);
                  this.CheckEdit_ShowPassword.Margin = new System.Windows.Forms.Padding(4);
                  this.CheckEdit_ShowPassword.Name = "CheckEdit_ShowPassword";
                  this.CheckEdit_ShowPassword.Properties.Caption = "";
                  this.CheckEdit_ShowPassword.Size = new System.Drawing.Size(30, 24);
                  this.CheckEdit_ShowPassword.TabIndex = 10;
                  this.CheckEdit_ShowPassword.Tag = "N_T";
                  this.CheckEdit_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckEdit_ShowPassword_CheckedChanged);
                  // 
                  // labelControl1
                  // 
                  this.labelControl1.Location = new System.Drawing.Point(346, 191);
                  this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
                  this.labelControl1.Name = "labelControl1";
                  this.labelControl1.Size = new System.Drawing.Size(122, 19);
                  this.labelControl1.TabIndex = 2;
                  this.labelControl1.Text = "Show Password :";
                  // 
                  // frm_TBL_USERS
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(926, 467);
                  this.Controls.Add(this.DataNavigator_Navigate);
                  this.Controls.Add(this.PanelControl_Default);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.Controls.Add(this.labelControl_TextBox_USERS_ID);
                  this.Controls.Add(this.TextEdit_USERS_ID);
                  this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
                  this.Controls.Add(this.CheckEdit_navigate);
                  this.Controls.Add(this.SimpleButton_List);
                  this.Controls.Add(this.SimpleButton_Referesh);
                  this.Controls.Add(this.SimpleButton_Referesh_A);
                  this.Controls.Add(this.SimpleButton_Delete);
                  this.Controls.Add(this.SimpleButton_Save);
                  this.Controls.Add(this.SimpleButton_Exit);
                  this.Controls.Add(this.GridLookUpEdit_USERS_rightID);
                  this.Controls.Add(this.LabelControl_GridLookUpEdit_USERS_rightID);
                  this.Controls.Add(this.TextEdit_USERS_name);
                  this.Controls.Add(this.LabelControl_TextEdit_USERS_name);
                  this.Controls.Add(this.TextEdit_USERS_loginID);
                  this.Controls.Add(this.LabelControl_TextEdit_USERS_loginID);
                  this.Controls.Add(this.TextEdit_USERS_password);
                  this.Controls.Add(this.LabelControl_TextEdit_USERS_password);
                  this.Controls.Add(this.TextEdit_USERS_narration);
                  this.Controls.Add(this.LabelControl_TextEdit_USERS_narration);
                  this.Controls.Add(this.CheckEdit_ShowPassword);
                  this.Controls.Add(this.CheckEdit_USERS_isActive);
                  this.Controls.Add(this.labelControl1);
                  this.Controls.Add(this.LabelControl_CheckEdit_USERS_isActive);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "frm_TBL_USERS";
                  this.Tag = "TBL_USERS";
                  this.Text = "TBL_USERS";
                  this.Load += new System.EventHandler(this.frm_TBL_USERS_Load);
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_USERS_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_ID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_USERS_rightID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_USERS_rightIDView)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_name.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_loginID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_password.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_USERS_narration.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_USERS_isActive.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_ShowPassword.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

            private PanelControl PanelControl_Default;
            public LabelControl labelControl_TextBox_USERS_ID;
            public TextEdit TextEdit_USERS_ID;
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


            public GridLookUpEdit GridLookUpEdit_USERS_rightID;
            public GridView GridView_USERS_rightID;
            public LabelControl LabelControl_GridLookUpEdit_USERS_rightID;


            public TextEdit TextEdit_USERS_name;
            public LabelControl LabelControl_TextEdit_USERS_name;

            public TextEdit TextEdit_USERS_loginID;
            public LabelControl LabelControl_TextEdit_USERS_loginID;

            public TextEdit TextEdit_USERS_password;
            public LabelControl LabelControl_TextEdit_USERS_password;

            public TextEdit TextEdit_USERS_narration;
            public LabelControl LabelControl_TextEdit_USERS_narration;

            public CheckEdit CheckEdit_USERS_isActive;
            public LabelControl LabelControl_CheckEdit_USERS_isActive;
            public GridView GridLookUpEdit_USERS_rightIDView;
            public CheckEdit CheckEdit_ShowPassword;
            public LabelControl labelControl1;




      }
}