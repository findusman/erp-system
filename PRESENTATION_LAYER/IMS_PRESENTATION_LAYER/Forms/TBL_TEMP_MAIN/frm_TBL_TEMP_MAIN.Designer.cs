using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_TEMP_MAIN
{
      partial class frm_TBL_TEMP_MAIN
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
                  this.labelControl_TextBox_TEMP_MAIN_ID = new DevExpress.XtraEditors.LabelControl();
                  this.TextEdit_TEMP_MAIN_ID = new DevExpress.XtraEditors.TextEdit();
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
                  this.GridControl_TBL_TEMP_DET = new DevExpress.XtraGrid.GridControl();
                  this.GridView_TBL_TEMP_DET = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.TextEdit_TEMP_MAIN_name = new DevExpress.XtraEditors.TextEdit();
                  this.LabelControl_TextEdit_TEMP_MAIN_name = new DevExpress.XtraEditors.LabelControl();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_TEMP_MAIN_ID.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_TEMP_DET)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_TEMP_DET)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_TEMP_MAIN_name.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(1226, 200);
                  this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  this.PanelControl_Default.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.PanelControl_Default.Name = "PanelControl_Default";
                  this.PanelControl_Default.Size = new System.Drawing.Size(1630, 15);
                  this.PanelControl_Default.TabIndex = 6;
                  // 
                  // labelControl_TextBox_TEMP_MAIN_ID
                  // 
                  this.labelControl_TextBox_TEMP_MAIN_ID.Location = new System.Drawing.Point(30, 29);
                  this.labelControl_TextBox_TEMP_MAIN_ID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
                  this.labelControl_TextBox_TEMP_MAIN_ID.Name = "labelControl_TextBox_TEMP_MAIN_ID";
                  this.labelControl_TextBox_TEMP_MAIN_ID.Size = new System.Drawing.Size(28, 19);
                  this.labelControl_TextBox_TEMP_MAIN_ID.TabIndex = 7;
                  this.labelControl_TextBox_TEMP_MAIN_ID.Text = "ID :";
                  // 
                  // TextEdit_TEMP_MAIN_ID
                  // 
                  this.TextEdit_TEMP_MAIN_ID.Location = new System.Drawing.Point(82, 25);
                  this.TextEdit_TEMP_MAIN_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.TextEdit_TEMP_MAIN_ID.Name = "TextEdit_TEMP_MAIN_ID";
                  this.TextEdit_TEMP_MAIN_ID.Size = new System.Drawing.Size(206, 26);
                  this.TextEdit_TEMP_MAIN_ID.TabIndex = 0;
                  this.TextEdit_TEMP_MAIN_ID.Tag = "N_T";
                  this.TextEdit_TEMP_MAIN_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_TEMP_MAIN_ID_KeyDown);
                  this.TextEdit_TEMP_MAIN_ID.Leave += new System.EventHandler(this.TextEdit_TEMP_MAIN_ID_Leave);
                  // 
                  // CheckEdit_Is_AutoGenegereted
                  // 
                  this.CheckEdit_Is_AutoGenegereted.EditValue = true;
                  this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(1041, 28);
                  this.CheckEdit_Is_AutoGenegereted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
                  this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
                  this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(210, 24);
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
                  this.DataNavigator_Navigate.Location = new System.Drawing.Point(476, 16);
                  this.DataNavigator_Navigate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
                  this.DataNavigator_Navigate.Size = new System.Drawing.Size(584, 41);
                  this.DataNavigator_Navigate.TabIndex = 4;
                  this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
                  this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
                  // 
                  // CheckEdit_navigate
                  // 
                  this.CheckEdit_navigate.Location = new System.Drawing.Point(404, 26);
                  this.CheckEdit_navigate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.CheckEdit_navigate.Name = "CheckEdit_navigate";
                  this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.CheckEdit_navigate.Properties.Caption = "";
                  this.CheckEdit_navigate.Size = new System.Drawing.Size(42, 24);
                  this.CheckEdit_navigate.TabIndex = 2;
                  this.CheckEdit_navigate.Tag = "F";
                  this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
                  // 
                  // SimpleButton_List
                  // 
                  this.SimpleButton_List.Location = new System.Drawing.Point(298, 25);
                  this.SimpleButton_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.SimpleButton_List.Name = "SimpleButton_List";
                  this.SimpleButton_List.Size = new System.Drawing.Size(82, 41);
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
                  this.SimpleButton_Referesh.Location = new System.Drawing.Point(1241, 959);
                  this.SimpleButton_Referesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  this.SimpleButton_Referesh_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  this.SimpleButton_Delete.Location = new System.Drawing.Point(1125, 959);
                  this.SimpleButton_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  this.SimpleButton_Save.Location = new System.Drawing.Point(1357, 959);
                  this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  this.SimpleButton_Exit.Location = new System.Drawing.Point(1472, 959);
                  this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
                  // GridControl_TBL_TEMP_DET
                  // 
                  this.GridControl_TBL_TEMP_DET.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.GridControl_TBL_TEMP_DET.Location = new System.Drawing.Point(45, 149);
                  this.GridControl_TBL_TEMP_DET.MainView = this.GridView_TBL_TEMP_DET;
                  this.GridControl_TBL_TEMP_DET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.GridControl_TBL_TEMP_DET.Name = "GridControl_TBL_TEMP_DET";
                  this.GridControl_TBL_TEMP_DET.Size = new System.Drawing.Size(1533, 802);
                  this.GridControl_TBL_TEMP_DET.TabIndex = 19;
                  this.GridControl_TBL_TEMP_DET.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_TEMP_DET});
                  // 
                  // GridView_TBL_TEMP_DET
                  // 
                  this.GridView_TBL_TEMP_DET.GridControl = this.GridControl_TBL_TEMP_DET;
                  this.GridView_TBL_TEMP_DET.Name = "GridView_TBL_TEMP_DET";
                  // 
                  // TextEdit_TEMP_MAIN_name
                  // 
                  this.TextEdit_TEMP_MAIN_name.EnterMoveNextControl = true;
                  this.TextEdit_TEMP_MAIN_name.Location = new System.Drawing.Point(126, 79);
                  this.TextEdit_TEMP_MAIN_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.TextEdit_TEMP_MAIN_name.Name = "TextEdit_TEMP_MAIN_name";
                  this.TextEdit_TEMP_MAIN_name.Size = new System.Drawing.Size(195, 26);
                  this.TextEdit_TEMP_MAIN_name.TabIndex = 28;
                  this.TextEdit_TEMP_MAIN_name.Tag = "N_T";
                  // 
                  // LabelControl_TextEdit_TEMP_MAIN_name
                  // 
                  this.LabelControl_TextEdit_TEMP_MAIN_name.Location = new System.Drawing.Point(45, 79);
                  this.LabelControl_TextEdit_TEMP_MAIN_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.LabelControl_TextEdit_TEMP_MAIN_name.Name = "LabelControl_TextEdit_TEMP_MAIN_name";
                  this.LabelControl_TextEdit_TEMP_MAIN_name.Size = new System.Drawing.Size(148, 19);
                  this.LabelControl_TextEdit_TEMP_MAIN_name.TabIndex = 2;
                  this.LabelControl_TextEdit_TEMP_MAIN_name.Text = "TEMP_MAIN_name :";
                  // 
                  // frm_TBL_TEMP_MAIN
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1596, 1023);
                  this.Controls.Add(this.DataNavigator_Navigate);
                  this.Controls.Add(this.PanelControl_Default);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.Controls.Add(this.labelControl_TextBox_TEMP_MAIN_ID);
                  this.Controls.Add(this.TextEdit_TEMP_MAIN_ID);
                  this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
                  this.Controls.Add(this.CheckEdit_navigate);
                  this.Controls.Add(this.SimpleButton_List);
                  this.Controls.Add(this.SimpleButton_Referesh);
                  this.Controls.Add(this.SimpleButton_Referesh_A);
                  this.Controls.Add(this.SimpleButton_Delete);
                  this.Controls.Add(this.SimpleButton_Save);
                  this.Controls.Add(this.SimpleButton_Exit);
                  this.Controls.Add(this.GridControl_TBL_TEMP_DET);
                  this.Controls.Add(this.TextEdit_TEMP_MAIN_name);
                  this.Controls.Add(this.LabelControl_TextEdit_TEMP_MAIN_name);
                  this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.Name = "frm_TBL_TEMP_MAIN";
                  this.Tag = "TBL_TEMP_MAIN";
                  this.Text = "TBL_TEMP_MAIN";
                  this.Load += new System.EventHandler(this.frm_TBL_TEMP_MAIN_Load);
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_TEMP_MAIN_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_TEMP_MAIN_ID.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_TEMP_DET)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_TEMP_DET)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.TextEdit_TEMP_MAIN_name.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

            private PanelControl PanelControl_Default;
            public LabelControl labelControl_TextBox_TEMP_MAIN_ID;
            public TextEdit TextEdit_TEMP_MAIN_ID;
            public CheckEdit CheckEdit_Is_AutoGenegereted;
            public DataNavigator DataNavigator_Navigate;
            public CheckEdit CheckEdit_navigate;

            public DevExpress.XtraGrid.GridControl GridControl_TBL_TEMP_DET;
            public GridView GridView_TBL_TEMP_DET;

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


            public TextEdit TextEdit_TEMP_MAIN_name;
            public LabelControl LabelControl_TextEdit_TEMP_MAIN_name;




      }
}