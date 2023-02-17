using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_SUPPLIERS_TMP
{
    partial class frm_TBL_SUPPLIERS_TMP
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

            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 700);

            //Initialization
            this.ListBoxControl_Rights = new DevExpress.XtraEditors.ListBoxControl();

            this.PanelControl_Default = new DevExpress.XtraEditors.PanelControl();
            this.labelControl_TextBox_SUPPLIER_ID = new DevExpress.XtraEditors.LabelControl();
            this.TextEdit_SUPPLIER_ID = new DevExpress.XtraEditors.TextEdit();
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

            this.TextEdit_SUPPLIER_COA = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_COA = new LabelControl();
            this.TextEdit_SUPPLIER_name = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_name = new LabelControl();
            this.TextEdit_SUPPLIER_address = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_address = new LabelControl();
            this.TextEdit_SUPPLIER_department = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_department = new LabelControl();
            this.TextEdit_SUPPLIER_millage = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_millage = new LabelControl();
            this.TextEdit_SUPPLIER_creditLimit = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_creditLimit = new LabelControl();
            this.TextEdit_SUPPLIER_creditDays = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_creditDays = new LabelControl();
            this.TextEdit_SUPPLIER_phone = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_phone = new LabelControl();
            this.TextEdit_SUPPLIER_email = new TextEdit();
            this.LabelControl_TextEdit_SUPPLIER_email = new LabelControl();

            // Initialization Closing

            this.PanelControl_Default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControl_Default.Location = new System.Drawing.Point(-14, 40);
            this.PanelControl_Default.Name = "PanelControl_Default";
            this.PanelControl_Default.Size = new System.Drawing.Size(744, 10);
            this.PanelControl_Default.TabIndex = 6;
            this.Controls.Add(this.PanelControl_Default);
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
            this.Controls.Add(this.ListBoxControl_Rights);
            // 
            // labelControl_TextBox_SUPPLIER_ID
            // 
            this.labelControl_TextBox_SUPPLIER_ID.Location = new System.Drawing.Point(20, 20);
            this.labelControl_TextBox_SUPPLIER_ID.Name = "labelControl_TextBox_SUPPLIER_ID";
            this.labelControl_TextBox_SUPPLIER_ID.Size = new System.Drawing.Size(28, 19);
            this.labelControl_TextBox_SUPPLIER_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl_TextBox_SUPPLIER_ID.TabIndex = 7;
            this.labelControl_TextBox_SUPPLIER_ID.Text = "ID :";
            this.TextEdit_SUPPLIER_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_SUPPLIER_ID_KeyDown);
            this.TextEdit_SUPPLIER_ID.Leave += new System.EventHandler(this.TextEdit_SUPPLIER_ID_Leave);
            this.Controls.Add(this.labelControl_TextBox_SUPPLIER_ID);
            // 
            // TextEdit_SUPPLIER_ID
            // 
            this.TextEdit_SUPPLIER_ID.Location = new System.Drawing.Point(55, 17);
            this.TextEdit_SUPPLIER_ID.Name = "TextEdit_SUPPLIER_ID";
            this.TextEdit_SUPPLIER_ID.Size = new System.Drawing.Size(137, 28);
            this.TextEdit_SUPPLIER_ID.TabIndex = 0;
            this.TextEdit_SUPPLIER_ID.Tag = "N_T";
            this.Controls.Add(this.TextEdit_SUPPLIER_ID);
            // 
            // CheckEdit_Is_AutoGenegereted
            // 
            this.CheckEdit_Is_AutoGenegereted.EditValue = true;
            this.CheckEdit_Is_AutoGenegereted.Location = new System.Drawing.Point(694, 19);
            this.CheckEdit_Is_AutoGenegereted.Name = "CheckEdit_Is_AutoGenegereted";
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.CheckEdit_Is_AutoGenegereted.Properties.Appearance.Options.UseForeColor = true;
            this.CheckEdit_Is_AutoGenegereted.Properties.Caption = "Auto Generated";
            this.CheckEdit_Is_AutoGenegereted.Size = new System.Drawing.Size(140, 24);
            this.CheckEdit_Is_AutoGenegereted.TabIndex = 5;
            this.CheckEdit_Is_AutoGenegereted.Tag = "N";
            this.Controls.Add(this.CheckEdit_Is_AutoGenegereted);
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
            this.DataNavigator_Navigate.Location = new System.Drawing.Point(297, 17);
            this.DataNavigator_Navigate.Name = "DataNavigator_Navigate";
            this.DataNavigator_Navigate.Size = new System.Drawing.Size(389, 28);
            this.DataNavigator_Navigate.TabIndex = 4;
            this.DataNavigator_Navigate.Text = "";
            this.DataNavigator_Navigate.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.DataNavigator_Navigate.PositionChanged += new System.EventHandler(this.DataNavigator_Navigate_PositionChanged);

            this.Controls.Add(this.DataNavigator_Navigate);
            // 
            // CheckEdit_navigate
            // 
            this.CheckEdit_navigate.Location = new System.Drawing.Point(322, 19);
            this.CheckEdit_navigate.Name = "CheckEdit_navigate";
            this.CheckEdit_navigate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckEdit_navigate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.CheckEdit_navigate.Properties.Caption = "";
            this.CheckEdit_navigate.Size = new System.Drawing.Size(28, 24);
            this.CheckEdit_navigate.TabIndex = 2;
            this.CheckEdit_navigate.Tag = "F";
            this.CheckEdit_navigate.CheckedChanged += new System.EventHandler(this.CheckEdit_navigate_CheckedChanged);
            this.Controls.Add(this.CheckEdit_navigate);

            // 
            // SimpleButton_List
            // 
            this.SimpleButton_List.Location = new System.Drawing.Point(199, 17);
            this.SimpleButton_List.Name = "SimpleButton_List";
            this.SimpleButton_List.Size = new System.Drawing.Size(55, 28);
            this.SimpleButton_List.TabIndex = 1;
            this.SimpleButton_List.Tag = "List";
            this.SimpleButton_List.Click += new System.EventHandler(this.SimpleButton_List_Click);
            this.Controls.Add(this.SimpleButton_List);

            // 
            // SimpleButton_Referesh
            // 
            this.SimpleButton_Referesh.Location = new System.Drawing.Point(390, 386);
            this.SimpleButton_Referesh.Name = "SimpleButton_Referesh";
            this.SimpleButton_Referesh.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Referesh.TabIndex = 2;
            this.SimpleButton_Referesh.Tag = "Refresh";
            this.SimpleButton_Referesh.Text = "Refresh ";
            this.SimpleButton_Referesh.Tag = "Refresh";
            this.SimpleButton_Referesh.Click += new System.EventHandler(this.SimpleButton_Referesh_Click);
            this.Controls.Add(this.SimpleButton_Referesh);

            // 
            // SimpleButton_Referesh_A
            // 
            this.SimpleButton_Referesh_A.Location = new System.Drawing.Point(728, 84);
            this.SimpleButton_Referesh_A.Name = "SimpleButton_Referesh_A";
            this.SimpleButton_Referesh_A.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Referesh_A.TabIndex = 2;
            this.SimpleButton_Referesh_A.Tag = "Refresh_";
            this.SimpleButton_Referesh_A.Text = "Refresh_A ";
            this.SimpleButton_Referesh_A.Visible = false;
            this.SimpleButton_Referesh_A.Tag = "Refresh_A";
            this.SimpleButton_Referesh_A.Click += new System.EventHandler(this.SimpleButton_Referesh_A_Click);
            this.Controls.Add(this.SimpleButton_Referesh_A);

            // 
            // SimpleButton_Delete
            // 
            this.SimpleButton_Delete.Location = new System.Drawing.Point(402, 386);
            this.SimpleButton_Delete.Name = "SimpleButton_Delete";
            this.SimpleButton_Delete.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Delete.TabIndex = 2;
            this.SimpleButton_Delete.Tag = "Delete";
            this.SimpleButton_Delete.Text = "Delete ";
            this.SimpleButton_Delete.Tag = "Delete";
            this.SimpleButton_Delete.Click += new System.EventHandler(this.SimpleButton_Delete_Click);
            this.Controls.Add(this.SimpleButton_Delete);

            // 
            // SimpleButton_Save
            // 
            this.SimpleButton_Save.Location = new System.Drawing.Point(518, 386);
            this.SimpleButton_Save.Name = "SimpleButton_Save";
            this.SimpleButton_Save.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Save.TabIndex = 2;
            this.SimpleButton_Save.Tag = "Save";
            this.SimpleButton_Save.Text = "Save ";
            this.SimpleButton_Save.Tag = "Save";
            this.SimpleButton_Save.Click += new System.EventHandler(this.SimpleButton_Save_Click);
            this.Controls.Add(this.SimpleButton_Save);

            // 
            // SimpleButton_Exit
            // 
            this.SimpleButton_Exit.Location = new System.Drawing.Point(634, 386);
            this.SimpleButton_Exit.Name = "SimpleButton_Exit";
            this.SimpleButton_Exit.Size = new System.Drawing.Size(71, 31);
            this.SimpleButton_Exit.TabIndex = 2;
            this.SimpleButton_Exit.Tag = "Exit";
            this.SimpleButton_Exit.Text = "Exit ";
            this.SimpleButton_Exit.Tag = "Exit";
            this.SimpleButton_Exit.Click += new System.EventHandler(this.SimpleButton_Exit_Click);
            this.Controls.Add(this.SimpleButton_Exit);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_SUPPLIERS_TMP_KeyDown);
            this.Name = "TBL_SUPPLIERS_TMP";
            this.Tag = "TBL_SUPPLIERS_TMP";
            this.Text = "TBL_SUPPLIERS_TMP";


            //                                             TextEdit_SUPPLIER_COA

            this.TextEdit_SUPPLIER_COA.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_COA.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_COA.Location = new System.Drawing.Point(84, 54);
            this.TextEdit_SUPPLIER_COA.Name = "TextEdit_SUPPLIER_COA";
            this.TextEdit_SUPPLIER_COA.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_COA);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_COA.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_COA.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_COA

            this.LabelControl_TextEdit_SUPPLIER_COA.Location = new System.Drawing.Point(30, 54);
            this.LabelControl_TextEdit_SUPPLIER_COA.Name = "54";
            this.LabelControl_TextEdit_SUPPLIER_COA.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_COA.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_COA.Text = "SUPPLIER_COA :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_COA);
            //                                             TextEdit_SUPPLIER_name

            this.TextEdit_SUPPLIER_name.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_name.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_name.Location = new System.Drawing.Point(84, 84);
            this.TextEdit_SUPPLIER_name.Name = "TextEdit_SUPPLIER_name";
            this.TextEdit_SUPPLIER_name.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_name);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_name.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_name.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_name

            this.LabelControl_TextEdit_SUPPLIER_name.Location = new System.Drawing.Point(30, 84);
            this.LabelControl_TextEdit_SUPPLIER_name.Name = "84";
            this.LabelControl_TextEdit_SUPPLIER_name.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_name.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_name.Text = "SUPPLIER_name :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_name);
            //                                             TextEdit_SUPPLIER_address

            this.TextEdit_SUPPLIER_address.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_address.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_address.Location = new System.Drawing.Point(84, 114);
            this.TextEdit_SUPPLIER_address.Name = "TextEdit_SUPPLIER_address";
            this.TextEdit_SUPPLIER_address.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_address);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_address.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_address.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_address

            this.LabelControl_TextEdit_SUPPLIER_address.Location = new System.Drawing.Point(30, 114);
            this.LabelControl_TextEdit_SUPPLIER_address.Name = "114";
            this.LabelControl_TextEdit_SUPPLIER_address.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_address.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_address.Text = "SUPPLIER_address :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_address);
            //                                             TextEdit_SUPPLIER_department

            this.TextEdit_SUPPLIER_department.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_department.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_department.Location = new System.Drawing.Point(84, 144);
            this.TextEdit_SUPPLIER_department.Name = "TextEdit_SUPPLIER_department";
            this.TextEdit_SUPPLIER_department.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_department);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_department.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_department.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_department

            this.LabelControl_TextEdit_SUPPLIER_department.Location = new System.Drawing.Point(30, 144);
            this.LabelControl_TextEdit_SUPPLIER_department.Name = "144";
            this.LabelControl_TextEdit_SUPPLIER_department.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_department.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_department.Text = "SUPPLIER_department :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_department);
            //                                             TextEdit_SUPPLIER_millage

            this.TextEdit_SUPPLIER_millage.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_millage.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_millage.Location = new System.Drawing.Point(84, 174);
            this.TextEdit_SUPPLIER_millage.Name = "TextEdit_SUPPLIER_millage";
            this.TextEdit_SUPPLIER_millage.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_millage);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_millage.Tag = "N1_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_millage.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_millage

            this.LabelControl_TextEdit_SUPPLIER_millage.Location = new System.Drawing.Point(30, 174);
            this.LabelControl_TextEdit_SUPPLIER_millage.Name = "174";
            this.LabelControl_TextEdit_SUPPLIER_millage.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_millage.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_millage.Text = "SUPPLIER_millage :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_millage);
            //                                             TextEdit_SUPPLIER_creditLimit

            this.TextEdit_SUPPLIER_creditLimit.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_creditLimit.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_creditLimit.Location = new System.Drawing.Point(84, 204);
            this.TextEdit_SUPPLIER_creditLimit.Name = "TextEdit_SUPPLIER_creditLimit";
            this.TextEdit_SUPPLIER_creditLimit.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_creditLimit);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_creditLimit.Tag = "N1_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_creditLimit.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_creditLimit

            this.LabelControl_TextEdit_SUPPLIER_creditLimit.Location = new System.Drawing.Point(30, 204);
            this.LabelControl_TextEdit_SUPPLIER_creditLimit.Name = "204";
            this.LabelControl_TextEdit_SUPPLIER_creditLimit.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_creditLimit.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_creditLimit.Text = "SUPPLIER_creditLimit :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_creditLimit);
            //                                             TextEdit_SUPPLIER_creditDays

            this.TextEdit_SUPPLIER_creditDays.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_creditDays.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_creditDays.Location = new System.Drawing.Point(84, 234);
            this.TextEdit_SUPPLIER_creditDays.Name = "TextEdit_SUPPLIER_creditDays";
            this.TextEdit_SUPPLIER_creditDays.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_creditDays);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_creditDays.Tag = "N1_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_creditDays.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_creditDays

            this.LabelControl_TextEdit_SUPPLIER_creditDays.Location = new System.Drawing.Point(30, 234);
            this.LabelControl_TextEdit_SUPPLIER_creditDays.Name = "234";
            this.LabelControl_TextEdit_SUPPLIER_creditDays.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_creditDays.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_creditDays.Text = "SUPPLIER_creditDays :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_creditDays);
            //                                             TextEdit_SUPPLIER_phone

            this.TextEdit_SUPPLIER_phone.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_phone.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_phone.Location = new System.Drawing.Point(84, 264);
            this.TextEdit_SUPPLIER_phone.Name = "TextEdit_SUPPLIER_phone";
            this.TextEdit_SUPPLIER_phone.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_phone);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_phone.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_phone.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_phone

            this.LabelControl_TextEdit_SUPPLIER_phone.Location = new System.Drawing.Point(30, 264);
            this.LabelControl_TextEdit_SUPPLIER_phone.Name = "264";
            this.LabelControl_TextEdit_SUPPLIER_phone.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_phone.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_phone.Text = "SUPPLIER_phone :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_phone);
            //                                             TextEdit_SUPPLIER_email

            this.TextEdit_SUPPLIER_email.EnterMoveNextControl = true;
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_email.Properties)).BeginInit();
            this.TextEdit_SUPPLIER_email.Location = new System.Drawing.Point(84, 294);
            this.TextEdit_SUPPLIER_email.Name = "TextEdit_SUPPLIER_email";
            this.TextEdit_SUPPLIER_email.Size = new System.Drawing.Size(130, 20);
            this.Controls.Add(this.TextEdit_SUPPLIER_email);
            //VVValidateLineVVV
            //VVPrimaryMaskIDVVV
            this.TextEdit_SUPPLIER_email.Tag = "N_T";
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_SUPPLIER_email.Properties)).EndInit();





            //                                             LabelControl_TextEdit_SUPPLIER_email

            this.LabelControl_TextEdit_SUPPLIER_email.Location = new System.Drawing.Point(30, 294);
            this.LabelControl_TextEdit_SUPPLIER_email.Name = "294";
            this.LabelControl_TextEdit_SUPPLIER_email.Size = new System.Drawing.Size(130, 20);
            this.LabelControl_TextEdit_SUPPLIER_email.TabIndex = 2;
            this.LabelControl_TextEdit_SUPPLIER_email.Text = "SUPPLIER_email :";
            this.Controls.Add(this.LabelControl_TextEdit_SUPPLIER_email);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

        private PanelControl PanelControl_Default;
        public LabelControl labelControl_TextBox_SUPPLIER_ID;
        public TextEdit TextEdit_SUPPLIER_ID;
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


        public TextEdit TextEdit_SUPPLIER_COA;
        public LabelControl LabelControl_TextEdit_SUPPLIER_COA;

        public TextEdit TextEdit_SUPPLIER_name;
        public LabelControl LabelControl_TextEdit_SUPPLIER_name;

        public TextEdit TextEdit_SUPPLIER_address;
        public LabelControl LabelControl_TextEdit_SUPPLIER_address;

        public TextEdit TextEdit_SUPPLIER_department;
        public LabelControl LabelControl_TextEdit_SUPPLIER_department;

        public TextEdit TextEdit_SUPPLIER_millage;
        public LabelControl LabelControl_TextEdit_SUPPLIER_millage;

        public TextEdit TextEdit_SUPPLIER_creditLimit;
        public LabelControl LabelControl_TextEdit_SUPPLIER_creditLimit;

        public TextEdit TextEdit_SUPPLIER_creditDays;
        public LabelControl LabelControl_TextEdit_SUPPLIER_creditDays;

        public TextEdit TextEdit_SUPPLIER_phone;
        public LabelControl LabelControl_TextEdit_SUPPLIER_phone;

        public TextEdit TextEdit_SUPPLIER_email;
        public LabelControl LabelControl_TextEdit_SUPPLIER_email;




    }
}