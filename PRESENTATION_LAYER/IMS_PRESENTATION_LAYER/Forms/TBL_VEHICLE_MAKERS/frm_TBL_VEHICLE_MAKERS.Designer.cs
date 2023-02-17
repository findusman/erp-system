using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_VEHICLE_MAKERS
{
    partial class frm_TBL_VEHICLE_MAKERS
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
            this.labelControl_TextBox_VEHICLE_MAKER_ID = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_VEHICLE_MAKER_ID = new DevExpress.XtraEditors.TextEdit();
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
            this.TextEdit_VEHICLE_MAKER_name = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl_TextEdit_VEHICLE_MAKER_name = new DevExpress.XtraEditors.LabelControl();
            this.MemoEdit_VEHICLE_MAKER_narration = new DevExpress.XtraEditors.MemoEdit();
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VEHICLE_MAKER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VEHICLE_MAKER_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_VEHICLE_MAKER_narration.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxControl_Rights
            // 
            this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
            this.ListBoxControl_Rights.Location = new System.Drawing.Point(658, 137);
            this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
            this.ListBoxControl_Rights.Size = new System.Drawing.Size(176, 280);
            this.ListBoxControl_Rights.TabIndex = 27;
            this.ListBoxControl_Rights.Visible = false;
            // 
            // PanelControl_Default
            // 
            this.PanelControl_Default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControl_Default.Location = new System.Drawing.Point(-14, 40);
            this.PanelControl_Default.Name = "PanelControl_Default";
            this.PanelControl_Default.Size = new System.Drawing.Size(627, 10);
            this.PanelControl_Default.TabIndex = 6;
            // 
            // labelControl_TextBox_VEHICLE_MAKER_ID
            // 
            this.labelControl_TextBox_VEHICLE_MAKER_ID.Location = new System.Drawing.Point(62, 15);
            this.labelControl_TextBox_VEHICLE_MAKER_ID.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl_TextBox_VEHICLE_MAKER_ID.Name = "labelControl_TextBox_VEHICLE_MAKER_ID";
            this.labelControl_TextBox_VEHICLE_MAKER_ID.Size = new System.Drawing.Size(18, 13);
            this.labelControl_TextBox_VEHICLE_MAKER_ID.TabIndex = 7;
            this.labelControl_TextBox_VEHICLE_MAKER_ID.Text = "ID :";
            // 
            // TextEdit_VEHICLE_MAKER_ID
            // 
            this.TextEdit_VEHICLE_MAKER_ID.Location = new System.Drawing.Point(87, 12);
            this.TextEdit_VEHICLE_MAKER_ID.Name = "TextEdit_VEHICLE_MAKER_ID";
            this.TextEdit_VEHICLE_MAKER_ID.Size = new System.Drawing.Size(64, 20);
            this.TextEdit_VEHICLE_MAKER_ID.TabIndex = 0;
            this.TextEdit_VEHICLE_MAKER_ID.Tag = "N_T";
            this.TextEdit_VEHICLE_MAKER_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_VEHICLE_MAKER_ID_KeyDown);
            this.TextEdit_VEHICLE_MAKER_ID.Leave += new System.EventHandler(this.TextEdit_VEHICLE_MAKER_ID_Leave);
            // 
            // CheckEdit_Is_AutoGenegereted
            // 
            this.CheckEdit_Is_AutoGenegereted.EditValue = true;
            this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(537, 13);
            this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
            this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
            this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(115, 19);
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
            this.DataNavigator_Navigate.Location = new System.Drawing.Point(237, 12);
            this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
            this.DataNavigator_Navigate.Size = new System.Drawing.Size(294, 21);
            this.DataNavigator_Navigate.TabIndex = 6;
            this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);
            // 
            // CheckEdit_navigate
            // 
            this.CheckEdit_navigate.Location = new System.Drawing.Point(215, 12);
            this.CheckEdit_navigate.Name = "CheckEdit_navigate";
            this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CheckEdit_navigate.Properties.Caption = "";
            this.CheckEdit_navigate.Size = new System.Drawing.Size(22, 19);
            this.CheckEdit_navigate.TabIndex = 5;
            this.CheckEdit_navigate.Tag = "F";
            this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
            // 
            // SimpleButton_List
            // 
            this.SimpleButton_List.Location = new System.Drawing.Point(154, 12);
            this.SimpleButton_List.Name = "SimpleButton_List";
            this.SimpleButton_List.Size = new System.Drawing.Size(55, 20);
            this.SimpleButton_List.TabIndex = 1;
            this.SimpleButton_List.Tag = "List";
            this.SimpleButton_List.Click += new System.EventHandler(this.SimpleButton_List_Click);
            // 
            // LabelControl_SimpleButton_List
            // 
            this.LabelControl_SimpleButton_List.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_List.Name = "LabelControl_SimpleButton_List";
            this.LabelControl_SimpleButton_List.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_List.TabIndex = 0;
            // 
            // SimpleButton_Referesh
            // 
            this.SimpleButton_Referesh.Location = new System.Drawing.Point(332, 237);
            this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
            this.SimpleButton_Referesh.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Referesh.TabIndex = 9;
            this.SimpleButton_Referesh.Tag = "Refresh";
            this.SimpleButton_Referesh.Text = "Refresh ";
            this.SimpleButton_Referesh.Click += new System.EventHandler(this.SimpleButton_Referesh_Click);
            // 
            // LabelControl_SimpleButton_Referesh
            // 
            this.LabelControl_SimpleButton_Referesh.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Referesh.Name = "LabelControl_SimpleButton_Referesh";
            this.LabelControl_SimpleButton_Referesh.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_Referesh.TabIndex = 0;
            // 
            // SimpleButton_Referesh_A
            // 
            this.SimpleButton_Referesh_A.Location = new System.Drawing.Point(728, 84);
            this.SimpleButton_Referesh_A.Name = "SimpleButton_Referesh_A";
            this.SimpleButton_Referesh_A.Size = new System.Drawing.Size(71, 31);
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
            this.LabelControl_SimpleButton_Referesh_A.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_Referesh_A.TabIndex = 0;
            // 
            // SimpleButton_Delete
            // 
            this.SimpleButton_Delete.Location = new System.Drawing.Point(409, 237);
            this.SimpleButton_Delete.Name = "SimpleButton_Delete";
            this.SimpleButton_Delete.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Delete.TabIndex = 8;
            this.SimpleButton_Delete.Tag = "Delete";
            this.SimpleButton_Delete.Text = "Delete ";
            this.SimpleButton_Delete.Click += new System.EventHandler(this.SimpleButton_Delete_Click);
            // 
            // LabelControl_SimpleButton_Delete
            // 
            this.LabelControl_SimpleButton_Delete.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Delete.Name = "LabelControl_SimpleButton_Delete";
            this.LabelControl_SimpleButton_Delete.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_Delete.TabIndex = 0;
            // 
            // SimpleButton_Save
            // 
            this.SimpleButton_Save.Location = new System.Drawing.Point(486, 237);
            this.SimpleButton_Save.Name = "SimpleButton_Save";
            this.SimpleButton_Save.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Save.TabIndex = 7;
            this.SimpleButton_Save.Tag = "Save";
            this.SimpleButton_Save.Text = "Save ";
            this.SimpleButton_Save.Click += new System.EventHandler(this.SimpleButton_Save_Click);
            // 
            // LabelControl_SimpleButton_Save
            // 
            this.LabelControl_SimpleButton_Save.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Save.Name = "LabelControl_SimpleButton_Save";
            this.LabelControl_SimpleButton_Save.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_Save.TabIndex = 0;
            // 
            // SimpleButton_Exit
            // 
            this.SimpleButton_Exit.Location = new System.Drawing.Point(563, 237);
            this.SimpleButton_Exit.Name = "SimpleButton_Exit";
            this.SimpleButton_Exit.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Exit.TabIndex = 10;
            this.SimpleButton_Exit.Tag = "Exit";
            this.SimpleButton_Exit.Text = "Exit ";
            this.SimpleButton_Exit.Click += new System.EventHandler(this.SimpleButton_Exit_Click);
            // 
            // LabelControl_SimpleButton_Exit
            // 
            this.LabelControl_SimpleButton_Exit.Location = new System.Drawing.Point(0, 0);
            this.LabelControl_SimpleButton_Exit.Name = "LabelControl_SimpleButton_Exit";
            this.LabelControl_SimpleButton_Exit.Size = new System.Drawing.Size(0, 13);
            this.LabelControl_SimpleButton_Exit.TabIndex = 0;
            // 
            // TextEdit_VEHICLE_MAKER_name
            // 
            this.TextEdit_VEHICLE_MAKER_name.EnterMoveNextControl = true;
            this.TextEdit_VEHICLE_MAKER_name.Location = new System.Drawing.Point(84, 69);
            this.TextEdit_VEHICLE_MAKER_name.Name = "TextEdit_VEHICLE_MAKER_name";
            this.TextEdit_VEHICLE_MAKER_name.Size = new System.Drawing.Size(447, 20);
            this.TextEdit_VEHICLE_MAKER_name.TabIndex = 3;
            this.TextEdit_VEHICLE_MAKER_name.Tag = "N_T_V";
            // 
            // LabelControl_TextEdit_VEHICLE_MAKER_name
            // 
            this.LabelControl_TextEdit_VEHICLE_MAKER_name.Location = new System.Drawing.Point(44, 72);
            this.LabelControl_TextEdit_VEHICLE_MAKER_name.Name = "LabelControl_TextEdit_VEHICLE_MAKER_name";
            this.LabelControl_TextEdit_VEHICLE_MAKER_name.Size = new System.Drawing.Size(34, 13);
            this.LabelControl_TextEdit_VEHICLE_MAKER_name.TabIndex = 2;
            this.LabelControl_TextEdit_VEHICLE_MAKER_name.Text = "Name :";
            // 
            // MemoEdit_VEHICLE_MAKER_narration
            // 
            this.MemoEdit_VEHICLE_MAKER_narration.EnterMoveNextControl = true;
            this.MemoEdit_VEHICLE_MAKER_narration.Location = new System.Drawing.Point(84, 95);
            this.MemoEdit_VEHICLE_MAKER_narration.Name = "MemoEdit_VEHICLE_MAKER_narration";
            this.MemoEdit_VEHICLE_MAKER_narration.Size = new System.Drawing.Size(228, 60);
            this.MemoEdit_VEHICLE_MAKER_narration.TabIndex = 4;
            this.MemoEdit_VEHICLE_MAKER_narration.Tag = "N_T_N";
            // 
            // LabelControl_MemoEdit_VEHICLE_MAKER_narration
            // 
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration.Location = new System.Drawing.Point(26, 98);
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration.Name = "LabelControl_MemoEdit_VEHICLE_MAKER_narration";
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration.Size = new System.Drawing.Size(52, 13);
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration.TabIndex = 2;
            this.LabelControl_MemoEdit_VEHICLE_MAKER_narration.Text = "Narration :";
            // 
            // frm_TBL_VEHICLE_MAKERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 275);
            this.Controls.Add(this.PanelControl_Default);
            this.Controls.Add(this.ListBoxControl_Rights);
            this.Controls.Add(this.labelControl_TextBox_VEHICLE_MAKER_ID);
            this.Controls.Add(this.TextEdit_VEHICLE_MAKER_ID);
            this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
            this.Controls.Add(this.DataNavigator_Navigate);
            this.Controls.Add(this.CheckEdit_navigate);
            this.Controls.Add(this.SimpleButton_List);
            this.Controls.Add(this.SimpleButton_Referesh);
            this.Controls.Add(this.SimpleButton_Referesh_A);
            this.Controls.Add(this.SimpleButton_Delete);
            this.Controls.Add(this.SimpleButton_Save);
            this.Controls.Add(this.SimpleButton_Exit);
            this.Controls.Add(this.TextEdit_VEHICLE_MAKER_name);
            this.Controls.Add(this.LabelControl_TextEdit_VEHICLE_MAKER_name);
            this.Controls.Add(this.MemoEdit_VEHICLE_MAKER_narration);
            this.Controls.Add(this.LabelControl_MemoEdit_VEHICLE_MAKER_narration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(661, 303);
            this.MinimumSize = new System.Drawing.Size(661, 303);
            this.Name = "frm_TBL_VEHICLE_MAKERS";
            this.Tag = "TBL_VEHICLE_MAKERS";
            this.Text = "Vehicle Makers";
            this.Load += new System.EventHandler(this.frm_TBL_VEHICLE_MAKERS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_VEHICLE_MAKERS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl_Default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VEHICLE_MAKER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_Is_AutoGenegereted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_navigate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_VEHICLE_MAKER_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEdit_VEHICLE_MAKER_narration.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

        private PanelControl PanelControl_Default;
        public LabelControl labelControl_TextBox_VEHICLE_MAKER_ID;
        public TextEdit TextEdit_VEHICLE_MAKER_ID;
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


        public TextEdit TextEdit_VEHICLE_MAKER_name;
        public LabelControl LabelControl_TextEdit_VEHICLE_MAKER_name;

        public MemoEdit MemoEdit_VEHICLE_MAKER_narration;
        public LabelControl LabelControl_MemoEdit_VEHICLE_MAKER_narration;




    }
}