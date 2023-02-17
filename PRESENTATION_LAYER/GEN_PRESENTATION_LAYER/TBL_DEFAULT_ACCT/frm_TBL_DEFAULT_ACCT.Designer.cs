namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT
{
    partial class frm_TBL_DEFAULT_ACCT
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
                  this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.SimpleButton_Clear = new DevExpress.XtraEditors.SimpleButton();
                  this.SimpleButton_Clear_A = new DevExpress.XtraEditors.SimpleButton();
                  this.SimpleButton_Save = new DevExpress.XtraEditors.SimpleButton();
                  this.SimpleButton_Exit = new DevExpress.XtraEditors.SimpleButton();
                  this.grdControl = new DevExpress.XtraGrid.GridControl();
                  this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.ListBoxControl_Rights = new DevExpress.XtraEditors.ListBoxControl();
                  ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.grdControl)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // gridLookUpEdit1View
                  // 
                  this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
                  // 
                  // SimpleButton_Clear
                  // 
                  this.SimpleButton_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                  this.SimpleButton_Clear.Location = new System.Drawing.Point(584, 395);
                  this.SimpleButton_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.SimpleButton_Clear.Name = "SimpleButton_Clear";
                  this.SimpleButton_Clear.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Clear.TabIndex = 2;
                  this.SimpleButton_Clear.Tag = "F";
                  this.SimpleButton_Clear.Text = "Refresh";
                  this.SimpleButton_Clear.Click += new System.EventHandler(this.SimpleButton_Clear_Click);
                  // 
                  // SimpleButton_Clear_A
                  // 
                  this.SimpleButton_Clear_A.Location = new System.Drawing.Point(1028, 18);
                  this.SimpleButton_Clear_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.SimpleButton_Clear_A.Name = "SimpleButton_Clear_A";
                  this.SimpleButton_Clear_A.Size = new System.Drawing.Size(20, 15);
                  this.SimpleButton_Clear_A.TabIndex = 2;
                  this.SimpleButton_Clear_A.Tag = "F";
                  this.SimpleButton_Clear_A.Text = "Refresh_A";
                  this.SimpleButton_Clear_A.Click += new System.EventHandler(this.SimpleButton_Clear_A_Click);
                  // 
                  // SimpleButton_Save
                  // 
                  this.SimpleButton_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                  this.SimpleButton_Save.Location = new System.Drawing.Point(699, 395);
                  this.SimpleButton_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.SimpleButton_Save.Name = "SimpleButton_Save";
                  this.SimpleButton_Save.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Save.TabIndex = 2;
                  this.SimpleButton_Save.Tag = "S";
                  this.SimpleButton_Save.Text = "Save";
                  this.SimpleButton_Save.Click += new System.EventHandler(this.SimpleButton_Save_Click);
                  // 
                  // SimpleButton_Exit
                  // 
                  this.SimpleButton_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                  this.SimpleButton_Exit.Location = new System.Drawing.Point(814, 395);
                  this.SimpleButton_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.SimpleButton_Exit.Name = "SimpleButton_Exit";
                  this.SimpleButton_Exit.Size = new System.Drawing.Size(106, 45);
                  this.SimpleButton_Exit.TabIndex = 2;
                  this.SimpleButton_Exit.Tag = "E";
                  this.SimpleButton_Exit.Text = "Exit";
                  this.SimpleButton_Exit.Click += new System.EventHandler(this.SimpleButton_Exit_Click);
                  // 
                  // grdControl
                  // 
                  this.grdControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                  this.grdControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
                  this.grdControl.Location = new System.Drawing.Point(-4, 1);
                  this.grdControl.MainView = this.grdView;
                  this.grdControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.grdControl.Name = "grdControl";
                  this.grdControl.Size = new System.Drawing.Size(926, 384);
                  this.grdControl.TabIndex = 7;
                  this.grdControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView});
                  // 
                  // grdView
                  // 
                  this.grdView.GridControl = this.grdControl;
                  this.grdView.Name = "grdView";
                  this.grdView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdView_CellValueChanged);
                  this.grdView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdView_KeyDown);
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton1.Location = new System.Drawing.Point(196, 425);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(15, 15);
                  this.simpleButton1.TabIndex = 112;
                  this.simpleButton1.TabStop = false;
                  this.simpleButton1.Tag = "F";
                  this.simpleButton1.Text = "Refresh_A";
                  this.simpleButton1.Visible = false;
                  this.simpleButton1.Click += new System.EventHandler(this.SimpleButton_Clear_A_Click);
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(519, 13);
                  this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(4);
                  this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
                  this.ListBoxControl_Rights.Size = new System.Drawing.Size(264, 409);
                  this.ListBoxControl_Rights.TabIndex = 113;
                  this.ListBoxControl_Rights.Tag = "ListRights";
                  this.ListBoxControl_Rights.Visible = false;
                  // 
                  // frm_TBL_DEFAULT_ACCT
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(922, 457);
                  this.Controls.Add(this.simpleButton1);
                  this.Controls.Add(this.grdControl);
                  this.Controls.Add(this.SimpleButton_Clear);
                  this.Controls.Add(this.SimpleButton_Clear_A);
                  this.Controls.Add(this.SimpleButton_Save);
                  this.Controls.Add(this.SimpleButton_Exit);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                  this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                  this.MaximizeBox = false;
                  this.MinimizeBox = false;
                  this.Name = "frm_TBL_DEFAULT_ACCT";
                  this.ShowIcon = false;
                  this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                  this.Tag = "TBL_DEFAULT_ACCT";
                  this.Text = "Default Accounts";
                  this.Load += new System.EventHandler(this.frm_TBL_DEFAULT_ACCT_Load);
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_DEFAULT_ACCT_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.grdControl)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  this.ResumeLayout(false);

        }

        #endregion

        DevExpress.XtraEditors.LabelControl LabelControl_List;

        public DevExpress.XtraEditors.SimpleButton SimpleButton_Clear;
        DevExpress.XtraEditors.LabelControl LabelControl_Clear;

        public DevExpress.XtraEditors.SimpleButton SimpleButton_Clear_A;
        DevExpress.XtraEditors.LabelControl LabelControl_Clear_A;
        DevExpress.XtraEditors.LabelControl LabelControl_Delete;

        public DevExpress.XtraEditors.SimpleButton SimpleButton_Save;
        DevExpress.XtraEditors.LabelControl LabelControl_Save;

        public DevExpress.XtraEditors.SimpleButton SimpleButton_Exit;
        DevExpress.XtraEditors.LabelControl LabelControl_Exit;

        public DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        public DevExpress.XtraGrid.GridControl grdControl;
        public DevExpress.XtraGrid.Views.Grid.GridView grdView;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;
    }
}