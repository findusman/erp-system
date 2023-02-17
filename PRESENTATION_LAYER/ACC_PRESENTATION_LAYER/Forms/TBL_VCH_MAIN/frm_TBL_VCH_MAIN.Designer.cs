using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Forms.TBL_VCH_MAIN
{
      partial class frm_TBL_VCH_MAIN
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
            this.labelControl_TextBox_VCH_ID = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_VCH_ID = new DevExpress.XtraEditors.TextEdit();
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
            this.GridControl_TBL_VCH_DETAILS = new DevExpress.XtraGrid.GridControl();
            this.GridView_TBL_VCH_DETAILS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TextEdit_VCH_narration = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_VCH_narration = new DevExpress.XtraEditors.LabelControl();
            this.DateEdit_VCH_date = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl_DateEdit_VCH_date = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl_TextEdit_VCH_chequeNo = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl_TextEdit_VCH_reference = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_VCH_reference = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_VCH_chequeNo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_narration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_VCH_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_VCH_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_reference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_chequeNo.Properties)).BeginInit();
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
            this.PanelControl_Default.Size = new System.Drawing.Size(947, 15);
            this.PanelControl_Default.TabIndex = 6;
            // 
            // labelControl_TextBox_VCH_ID
            // 
            this.labelControl_TextBox_VCH_ID.Location = new System.Drawing.Point(88, 20);
            this.labelControl_TextBox_VCH_ID.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl_TextBox_VCH_ID.Name = "labelControl_TextBox_VCH_ID";
            this.labelControl_TextBox_VCH_ID.Size = new System.Drawing.Size(28, 19);
            this.labelControl_TextBox_VCH_ID.TabIndex = 7;
            this.labelControl_TextBox_VCH_ID.Text = "ID :";
            // 
            // TextEdit_VCH_ID
            // 
            this.TextEdit_VCH_ID.Location = new System.Drawing.Point(126, 17);
            this.TextEdit_VCH_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TextEdit_VCH_ID.Name = "TextEdit_VCH_ID";
            this.TextEdit_VCH_ID.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d\\d";
            this.TextEdit_VCH_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TextEdit_VCH_ID.Size = new System.Drawing.Size(162, 26);
            this.TextEdit_VCH_ID.TabIndex = 0;
            this.TextEdit_VCH_ID.Tag = "N_T";
            this.TextEdit_VCH_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_VCH_ID_KeyDown);
            this.TextEdit_VCH_ID.Leave += new System.EventHandler(this.TextEdit_VCH_ID_Leave);
            // 
            // CheckEdit_Is_AutoGenegereted
            // 
            this.CheckEdit_Is_AutoGenegereted.EditValue = true;
            this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(1041, 28);
            this.CheckEdit_Is_AutoGenegereted.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
            this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
            this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(210, 23);
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
            this.DataNavigator_Navigate.Location = new System.Drawing.Point(389, 17);
            this.DataNavigator_Navigate.Margin = new System.Windows.Forms.Padding(4);
            this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
            this.DataNavigator_Navigate.Size = new System.Drawing.Size(351, 27);
            this.DataNavigator_Navigate.TabIndex = 4;
            this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
            // 
            // CheckEdit_navigate
            // 
            this.CheckEdit_navigate.Location = new System.Drawing.Point(357, 17);
            this.CheckEdit_navigate.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEdit_navigate.Name = "CheckEdit_navigate";
            this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CheckEdit_navigate.Properties.Caption = "";
            this.CheckEdit_navigate.Size = new System.Drawing.Size(24, 19);
            this.CheckEdit_navigate.TabIndex = 2;
            this.CheckEdit_navigate.Tag = "F";
            this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
            // 
            // SimpleButton_List
            // 
            this.SimpleButton_List.Location = new System.Drawing.Point(298, 17);
            this.SimpleButton_List.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleButton_List.Name = "SimpleButton_List";
            this.SimpleButton_List.Size = new System.Drawing.Size(48, 26);
            this.SimpleButton_List.TabIndex = 1;
            this.SimpleButton_List.Tag = "List";
            this.SimpleButton_List.Click += new System.EventHandler(this.SimpleButton_List_Click);
            // 
            // LabelControl_SimpleButton_List
            // 
            this.LabelControl_SimpleButton_List.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_List.Name = "LabelControl_SimpleButton_List";
            this.LabelControl_SimpleButton_List.Size = new System.Drawing.Size(75, 14);
            this.LabelControl_SimpleButton_List.TabIndex = 0;
            // 
            // SimpleButton_Referesh
            // 
            this.SimpleButton_Referesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton_Referesh.Location = new System.Drawing.Point(455, 666);
            this.SimpleButton_Referesh.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
            this.SimpleButton_Referesh.Size = new System.Drawing.Size(106, 45);
            this.SimpleButton_Referesh.TabIndex = 2;
            this.SimpleButton_Referesh.Tag = "Refresh";
            this.SimpleButton_Referesh.Text = "Refresh ";
            this.SimpleButton_Referesh.Click += new System.EventHandler(this.SimpleButton_Referesh_Click);
            // 
            // LabelControl_SimpleButton_Referesh
            // 
            this.LabelControl_SimpleButton_Referesh.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Referesh.Name = "LabelControl_SimpleButton_Referesh";
            this.LabelControl_SimpleButton_Referesh.Size = new System.Drawing.Size(75, 14);
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
            this.LabelControl_SimpleButton_Referesh_A.Size = new System.Drawing.Size(75, 14);
            this.LabelControl_SimpleButton_Referesh_A.TabIndex = 0;
            // 
            // SimpleButton_Delete
            // 
            this.SimpleButton_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton_Delete.Location = new System.Drawing.Point(569, 666);
            this.SimpleButton_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleButton_Delete.Name = "SimpleButton_Delete";
            this.SimpleButton_Delete.Size = new System.Drawing.Size(106, 45);
            this.SimpleButton_Delete.TabIndex = 2;
            this.SimpleButton_Delete.Tag = "Delete";
            this.SimpleButton_Delete.Text = "Delete ";
            this.SimpleButton_Delete.Click += new System.EventHandler(this.SimpleButton_Delete_Click);
            // 
            // LabelControl_SimpleButton_Delete
            // 
            this.LabelControl_SimpleButton_Delete.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Delete.Name = "LabelControl_SimpleButton_Delete";
            this.LabelControl_SimpleButton_Delete.Size = new System.Drawing.Size(75, 14);
            this.LabelControl_SimpleButton_Delete.TabIndex = 0;
            // 
            // SimpleButton_Save
            // 
            this.SimpleButton_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton_Save.Location = new System.Drawing.Point(683, 666);
            this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleButton_Save.Name = "SimpleButton_Save";
            this.SimpleButton_Save.Size = new System.Drawing.Size(106, 45);
            this.SimpleButton_Save.TabIndex = 2;
            this.SimpleButton_Save.Tag = "Save";
            this.SimpleButton_Save.Text = "Save ";
            this.SimpleButton_Save.Click += new System.EventHandler(this.SimpleButton_Save_Click);
            // 
            // LabelControl_SimpleButton_Save
            // 
            this.LabelControl_SimpleButton_Save.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Save.Name = "LabelControl_SimpleButton_Save";
            this.LabelControl_SimpleButton_Save.Size = new System.Drawing.Size(75, 14);
            this.LabelControl_SimpleButton_Save.TabIndex = 0;
            // 
            // SimpleButton_Exit
            // 
            this.SimpleButton_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton_Exit.Location = new System.Drawing.Point(797, 666);
            this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleButton_Exit.Name = "SimpleButton_Exit";
            this.SimpleButton_Exit.Size = new System.Drawing.Size(106, 45);
            this.SimpleButton_Exit.TabIndex = 2;
            this.SimpleButton_Exit.Tag = "Exit";
            this.SimpleButton_Exit.Text = "Exit ";
            this.SimpleButton_Exit.Click += new System.EventHandler(this.SimpleButton_Exit_Click);
            // 
            // LabelControl_SimpleButton_Exit
            // 
            this.LabelControl_SimpleButton_Exit.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Exit.Name = "LabelControl_SimpleButton_Exit";
            this.LabelControl_SimpleButton_Exit.Size = new System.Drawing.Size(75, 14);
            this.LabelControl_SimpleButton_Exit.TabIndex = 0;
            // 
            // GridControl_TBL_VCH_DETAILS
            // 
            this.GridControl_TBL_VCH_DETAILS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl_TBL_VCH_DETAILS.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_TBL_VCH_DETAILS.Location = new System.Drawing.Point(13, 158);
            this.GridControl_TBL_VCH_DETAILS.MainView = this.GridView_TBL_VCH_DETAILS;
            this.GridControl_TBL_VCH_DETAILS.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_TBL_VCH_DETAILS.Name = "GridControl_TBL_VCH_DETAILS";
            this.GridControl_TBL_VCH_DETAILS.Size = new System.Drawing.Size(890, 500);
            this.GridControl_TBL_VCH_DETAILS.TabIndex = 19;
            this.GridControl_TBL_VCH_DETAILS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_VCH_DETAILS});
            // 
            // GridView_TBL_VCH_DETAILS
            // 
            this.GridView_TBL_VCH_DETAILS.GridControl = this.GridControl_TBL_VCH_DETAILS;
            this.GridView_TBL_VCH_DETAILS.Name = "GridView_TBL_VCH_DETAILS";
            this.GridView_TBL_VCH_DETAILS.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridView_TBL_VCH_DETAILS_CellValueChanged);
            // 
            // TextEdit_VCH_narration
            // 
            this.TextEdit_VCH_narration.EnterMoveNextControl = true;
            this.TextEdit_VCH_narration.Location = new System.Drawing.Point(126, 85);
            this.TextEdit_VCH_narration.Margin = new System.Windows.Forms.Padding(4);
            this.TextEdit_VCH_narration.Name = "TextEdit_VCH_narration";
            this.TextEdit_VCH_narration.Size = new System.Drawing.Size(777, 26);
            this.TextEdit_VCH_narration.TabIndex = 28;
            this.TextEdit_VCH_narration.Tag = "N_T";
            // 
            // LabelControl_TextEdit_VCH_narration
            // 
            this.LabelControl_TextEdit_VCH_narration.Location = new System.Drawing.Point(45, 89);
            this.LabelControl_TextEdit_VCH_narration.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl_TextEdit_VCH_narration.Name = "LabelControl_TextEdit_VCH_narration";
            this.LabelControl_TextEdit_VCH_narration.Size = new System.Drawing.Size(77, 19);
            this.LabelControl_TextEdit_VCH_narration.TabIndex = 2;
            this.LabelControl_TextEdit_VCH_narration.Text = "Narration :";
            // 
            // DateEdit_VCH_date
            // 
            this.DateEdit_VCH_date.EditValue = null;
            this.DateEdit_VCH_date.EnterMoveNextControl = true;
            this.DateEdit_VCH_date.Location = new System.Drawing.Point(126, 119);
            this.DateEdit_VCH_date.Margin = new System.Windows.Forms.Padding(4);
            this.DateEdit_VCH_date.Name = "DateEdit_VCH_date";
            this.DateEdit_VCH_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_VCH_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateEdit_VCH_date.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.DateEdit_VCH_date.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.DateEdit_VCH_date.Properties.Mask.EditMask = "";
            this.DateEdit_VCH_date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DateEdit_VCH_date.Size = new System.Drawing.Size(195, 26);
            this.DateEdit_VCH_date.TabIndex = 30;
            this.DateEdit_VCH_date.Tag = "N_T";
            // 
            // LabelControl_DateEdit_VCH_date
            // 
            this.LabelControl_DateEdit_VCH_date.Location = new System.Drawing.Point(79, 122);
            this.LabelControl_DateEdit_VCH_date.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl_DateEdit_VCH_date.Name = "LabelControl_DateEdit_VCH_date";
            this.LabelControl_DateEdit_VCH_date.Size = new System.Drawing.Size(43, 19);
            this.LabelControl_DateEdit_VCH_date.TabIndex = 2;
            this.LabelControl_DateEdit_VCH_date.Text = "Date :";
            // 
            // LabelControl_TextEdit_VCH_chequeNo
            // 
            this.LabelControl_TextEdit_VCH_chequeNo.Location = new System.Drawing.Point(619, 122);
            this.LabelControl_TextEdit_VCH_chequeNo.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl_TextEdit_VCH_chequeNo.Name = "LabelControl_TextEdit_VCH_chequeNo";
            this.LabelControl_TextEdit_VCH_chequeNo.Size = new System.Drawing.Size(81, 19);
            this.LabelControl_TextEdit_VCH_chequeNo.TabIndex = 2;
            this.LabelControl_TextEdit_VCH_chequeNo.Text = "Cheque # :";
            // 
            // LabelControl_TextEdit_VCH_reference
            // 
            this.LabelControl_TextEdit_VCH_reference.Location = new System.Drawing.Point(328, 123);
            this.LabelControl_TextEdit_VCH_reference.Margin = new System.Windows.Forms.Padding(4);
            this.LabelControl_TextEdit_VCH_reference.Name = "LabelControl_TextEdit_VCH_reference";
            this.LabelControl_TextEdit_VCH_reference.Size = new System.Drawing.Size(80, 19);
            this.LabelControl_TextEdit_VCH_reference.TabIndex = 2;
            this.LabelControl_TextEdit_VCH_reference.Text = "Reference :";
            // 
            // TextEdit_VCH_reference
            // 
            this.TextEdit_VCH_reference.EnterMoveNextControl = true;
            this.TextEdit_VCH_reference.Location = new System.Drawing.Point(416, 119);
            this.TextEdit_VCH_reference.Margin = new System.Windows.Forms.Padding(4);
            this.TextEdit_VCH_reference.Name = "TextEdit_VCH_reference";
            this.TextEdit_VCH_reference.Size = new System.Drawing.Size(195, 26);
            this.TextEdit_VCH_reference.TabIndex = 32;
            this.TextEdit_VCH_reference.Tag = "N_T";
            // 
            // TextEdit_VCH_chequeNo
            // 
            this.TextEdit_VCH_chequeNo.EnterMoveNextControl = true;
            this.TextEdit_VCH_chequeNo.Location = new System.Drawing.Point(708, 119);
            this.TextEdit_VCH_chequeNo.Margin = new System.Windows.Forms.Padding(4);
            this.TextEdit_VCH_chequeNo.Name = "TextEdit_VCH_chequeNo";
            this.TextEdit_VCH_chequeNo.Size = new System.Drawing.Size(195, 26);
            this.TextEdit_VCH_chequeNo.TabIndex = 33;
            this.TextEdit_VCH_chequeNo.Tag = "N_T";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(341, 666);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 45);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Tag = "Print";
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_TBL_VCH_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 724);
            this.Controls.Add(this.PanelControl_Default);
            this.Controls.Add(this.ListBoxControl_Rights);
            this.Controls.Add(this.labelControl_TextBox_VCH_ID);
            this.Controls.Add(this.TextEdit_VCH_ID);
            this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
            this.Controls.Add(this.DataNavigator_Navigate);
            this.Controls.Add(this.CheckEdit_navigate);
            this.Controls.Add(this.SimpleButton_List);
            this.Controls.Add(this.SimpleButton_Referesh);
            this.Controls.Add(this.SimpleButton_Referesh_A);
            this.Controls.Add(this.SimpleButton_Delete);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SimpleButton_Save);
            this.Controls.Add(this.SimpleButton_Exit);
            this.Controls.Add(this.GridControl_TBL_VCH_DETAILS);
            this.Controls.Add(this.TextEdit_VCH_narration);
            this.Controls.Add(this.LabelControl_TextEdit_VCH_narration);
            this.Controls.Add(this.DateEdit_VCH_date);
            this.Controls.Add(this.LabelControl_DateEdit_VCH_date);
            this.Controls.Add(this.TextEdit_VCH_reference);
            this.Controls.Add(this.LabelControl_TextEdit_VCH_reference);
            this.Controls.Add(this.TextEdit_VCH_chequeNo);
            this.Controls.Add(this.LabelControl_TextEdit_VCH_chequeNo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TBL_VCH_MAIN";
            this.Tag = "TBL_VCH_MAIN";
            this.Text = "Vouchers";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_VCH_MAIN_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_VCH_DETAILS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_narration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_VCH_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_VCH_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_reference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VCH_chequeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

            private PanelControl PanelControl_Default;
            public LabelControl labelControl_TextBox_VCH_ID;
            public TextEdit TextEdit_VCH_ID;
            public CheckEdit CheckEdit_Is_AutoGenegereted;
            public DataNavigator DataNavigator_Navigate;
            public CheckEdit CheckEdit_navigate;

            public DevExpress.XtraGrid.GridControl GridControl_TBL_VCH_DETAILS;
            public GridView GridView_TBL_VCH_DETAILS;

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


            public TextEdit TextEdit_VCH_narration;
            public LabelControl LabelControl_TextEdit_VCH_narration;

            public DateEdit DateEdit_VCH_date;
            public LabelControl LabelControl_DateEdit_VCH_date;
            public LabelControl LabelControl_TextEdit_VCH_chequeNo;
            public LabelControl LabelControl_TextEdit_VCH_reference;
            public TextEdit TextEdit_VCH_reference;
            public TextEdit TextEdit_VCH_chequeNo;
        public SimpleButton simpleButton1;
    }
}