namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Users_Login
{
    partial class frm_ChangePassword
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
            this.txtOld = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVarify = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton_Save = new DevExpress.XtraEditors.SimpleButton();
            this.ListRight = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVarify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListRight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(112, 25);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(180, 20);
            this.txtOld.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Old Password :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "New Password :";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(112, 55);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(180, 20);
            this.txtNew.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Varify Password :";
            // 
            // txtVarify
            // 
            this.txtVarify.Location = new System.Drawing.Point(112, 85);
            this.txtVarify.Name = "txtVarify";
            this.txtVarify.Size = new System.Drawing.Size(180, 20);
            this.txtVarify.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(217, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SimpleButton_Save
            // 
            this.SimpleButton_Save.Location = new System.Drawing.Point(136, 111);
            this.SimpleButton_Save.Name = "SimpleButton_Save";
            this.SimpleButton_Save.Size = new System.Drawing.Size(75, 23);
            this.SimpleButton_Save.TabIndex = 7;
            this.SimpleButton_Save.Text = "Save";
            this.SimpleButton_Save.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ListRight
            // 
            this.ListRight.Items.AddRange(new object[] {
            "key_update",
            "key_del"});
            this.ListRight.Location = new System.Drawing.Point(265, -10);
            this.ListRight.Name = "ListRight";
            this.ListRight.Size = new System.Drawing.Size(69, 14);
            this.ListRight.TabIndex = 17;
            this.ListRight.Visible = false;
            // 
            // frm_ChangePassword
            // 
            this.AcceptButton = this.SimpleButton_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton1;
            this.ClientSize = new System.Drawing.Size(321, 155);
            this.Controls.Add(this.ListRight);
            this.Controls.Add(this.SimpleButton_Save);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtVarify);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtOld);
            this.Name = "frm_ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frm_ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVarify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtOld;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNew;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtVarify;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton SimpleButton_Save;
        private DevExpress.XtraEditors.ListBoxControl ListRight;
    }
}