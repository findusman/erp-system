namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Users_Login
{
    partial class frm_LOGIN
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LOGIN));
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_LOGIN_EDIT = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_PASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_USER_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcompany = new DevExpress.XtraEditors.LabelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.CheckEdit_isLoadRights = new DevExpress.XtraEditors.CheckEdit();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.Combobox_newDatabases = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CheckEdit_isNewDatabase = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_LOGIN_EDIT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_USER_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isLoadRights.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_newDatabases.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isNewDatabase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AllowFocus = false;
            this.btn_login.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_login.Appearance.Options.UseBorderColor = true;
            this.btn_login.Appearance.Options.UseImage = true;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Location = new System.Drawing.Point(306, 95);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(147, 73);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login ";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textEdit_LOGIN_EDIT
            // 
            this.textEdit_LOGIN_EDIT.EditValue = "admin";
            this.textEdit_LOGIN_EDIT.Location = new System.Drawing.Point(123, 18);
            this.textEdit_LOGIN_EDIT.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit_LOGIN_EDIT.Name = "textEdit_LOGIN_EDIT";
            this.textEdit_LOGIN_EDIT.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Olive;
            this.textEdit_LOGIN_EDIT.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textEdit_LOGIN_EDIT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textEdit_LOGIN_EDIT.Size = new System.Drawing.Size(330, 28);
            this.textEdit_LOGIN_EDIT.TabIndex = 0;
            this.textEdit_LOGIN_EDIT.ToolTip = "Enter a login ID provided by administrator.";
            // 
            // textEdit_PASSWORD
            // 
            this.textEdit_PASSWORD.EditValue = "omer@#123";
            this.textEdit_PASSWORD.Location = new System.Drawing.Point(123, 56);
            this.textEdit_PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit_PASSWORD.Name = "textEdit_PASSWORD";
            this.textEdit_PASSWORD.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Olive;
            this.textEdit_PASSWORD.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.textEdit_PASSWORD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textEdit_PASSWORD.Properties.PasswordChar = '*';
            this.textEdit_PASSWORD.Size = new System.Drawing.Size(330, 28);
            this.textEdit_PASSWORD.TabIndex = 1;
            this.textEdit_PASSWORD.ToolTip = "Enter your personal password.";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Login ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Password :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(736, 419);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 19);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "User Type :";
            this.labelControl3.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(696, 151);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Admin";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // textEdit_USER_TYPE
            // 
            this.textEdit_USER_TYPE.Location = new System.Drawing.Point(824, 415);
            this.textEdit_USER_TYPE.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit_USER_TYPE.Name = "textEdit_USER_TYPE";
            this.textEdit_USER_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit_USER_TYPE.Properties.NullText = "";
            this.textEdit_USER_TYPE.Size = new System.Drawing.Size(92, 26);
            this.textEdit_USER_TYPE.TabIndex = 4;
            this.textEdit_USER_TYPE.Visible = false;
            // 
            // lblcompany
            // 
            this.lblcompany.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblcompany.Location = new System.Drawing.Point(384, 414);
            this.lblcompany.Margin = new System.Windows.Forms.Padding(4);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(0, 34);
            this.lblcompany.TabIndex = 9;
            this.lblcompany.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.Appearance.Font = new System.Drawing.Font("Verdana", 52F);
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(66, 238);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 126);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Verdana", 28F);
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(72, 352);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 67);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "0";
            // 
            // CheckEdit_isLoadRights
            // 
            this.CheckEdit_isLoadRights.Location = new System.Drawing.Point(120, 96);
            this.CheckEdit_isLoadRights.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEdit_isLoadRights.Name = "CheckEdit_isLoadRights";
            this.CheckEdit_isLoadRights.Properties.Caption = "Load Rights";
            this.CheckEdit_isLoadRights.Size = new System.Drawing.Size(130, 23);
            this.CheckEdit_isLoadRights.TabIndex = 18;
            this.CheckEdit_isLoadRights.Visible = false;
            this.CheckEdit_isLoadRights.CheckedChanged += new System.EventHandler(this.CheckEdit_isLoadRights_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.Appearance.Options.UseBorderColor = true;
            this.btnBack.Appearance.Options.UseImage = true;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(542, 228);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 73);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Combobox_newDatabases
            // 
            this.Combobox_newDatabases.Location = new System.Drawing.Point(696, 69);
            this.Combobox_newDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_newDatabases.Name = "Combobox_newDatabases";
            this.Combobox_newDatabases.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Combobox_newDatabases.Properties.PopupFormSize = new System.Drawing.Size(500, 500);
            this.Combobox_newDatabases.Properties.PopupSizeable = true;
            this.Combobox_newDatabases.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Combobox_newDatabases.Size = new System.Drawing.Size(232, 26);
            this.Combobox_newDatabases.TabIndex = 4;
            this.Combobox_newDatabases.Visible = false;
            // 
            // CheckEdit_isNewDatabase
            // 
            this.CheckEdit_isNewDatabase.EditValue = true;
            this.CheckEdit_isNewDatabase.Location = new System.Drawing.Point(696, 110);
            this.CheckEdit_isNewDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEdit_isNewDatabase.Name = "CheckEdit_isNewDatabase";
            this.CheckEdit_isNewDatabase.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.CheckEdit_isNewDatabase.Properties.Caption = "checkEdit1";
            this.CheckEdit_isNewDatabase.Size = new System.Drawing.Size(92, 23);
            this.CheckEdit_isNewDatabase.TabIndex = 4;
            this.CheckEdit_isNewDatabase.Visible = false;
            this.CheckEdit_isNewDatabase.CheckedChanged += new System.EventHandler(this.CheckEdit_isNewDatabase_CheckedChanged);
            // 
            // frm_LOGIN
            // 
            this.AcceptButton = this.btn_login;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(472, 193);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CheckEdit_isLoadRights);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblcompany);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_PASSWORD);
            this.Controls.Add(this.textEdit_LOGIN_EDIT);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textEdit_USER_TYPE);
            this.Controls.Add(this.Combobox_newDatabases);
            this.Controls.Add(this.CheckEdit_isNewDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_LOGIN_EDIT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_USER_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isLoadRights.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combobox_newDatabases.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_isNewDatabase.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.TextEdit textEdit_LOGIN_EDIT;
        private DevExpress.XtraEditors.TextEdit textEdit_PASSWORD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LookUpEdit textEdit_USER_TYPE;
        private DevExpress.XtraEditors.LabelControl lblcompany;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_isLoadRights;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.ComboBoxEdit Combobox_newDatabases;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_isNewDatabase;
    }
}