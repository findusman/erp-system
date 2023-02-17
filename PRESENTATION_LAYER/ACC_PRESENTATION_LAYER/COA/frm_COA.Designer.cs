namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.COA
{
    partial class frm_COA
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
                  this.TL_COA = new DevExpress.XtraTreeList.TreeList();
                  this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
                  this.RadioGroup_expandCollapse = new DevExpress.XtraEditors.RadioGroup();
                  this.ListBoxControl_Rights = new DevExpress.XtraEditors.ListBoxControl();
                  ((System.ComponentModel.ISupportInitialize)(this.TL_COA)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.RadioGroup_expandCollapse.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // TL_COA
                  // 
                  this.TL_COA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.TL_COA.Appearance.HeaderPanel.Options.UseTextOptions = true;
                  this.TL_COA.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                  this.TL_COA.Location = new System.Drawing.Point(6, -1);
                  this.TL_COA.Margin = new System.Windows.Forms.Padding(4);
                  this.TL_COA.Name = "TL_COA";
                  this.TL_COA.OptionsBehavior.AutoFocusNewNode = true;
                  this.TL_COA.OptionsView.ShowHorzLines = false;
                  this.TL_COA.OptionsView.ShowVertLines = false;
                  this.TL_COA.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
                  this.TL_COA.Size = new System.Drawing.Size(1072, 257);
                  this.TL_COA.TabIndex = 0;
                  this.TL_COA.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
                  this.TL_COA.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.TL_COA_CellValueChanging);
                  this.TL_COA.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
                  this.TL_COA.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.TL_COA_EditorKeyDown);
                  this.TL_COA.Click += new System.EventHandler(this.TL_COA_Click);
                  this.TL_COA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TL_COA_KeyDown);
                  // 
                  // repositoryItemTextEdit1
                  // 
                  this.repositoryItemTextEdit1.AutoHeight = false;
                  this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton1.Location = new System.Drawing.Point(326, 265);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(112, 48);
                  this.simpleButton1.TabIndex = 1;
                  this.simpleButton1.Text = "Add Siblings";
                  this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
                  // 
                  // simpleButton2
                  // 
                  this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton2.Location = new System.Drawing.Point(447, 265);
                  this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton2.Name = "simpleButton2";
                  this.simpleButton2.Size = new System.Drawing.Size(112, 48);
                  this.simpleButton2.TabIndex = 1;
                  this.simpleButton2.Text = "Add Child ";
                  this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
                  // 
                  // simpleButton3
                  // 
                  this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton3.Location = new System.Drawing.Point(966, 265);
                  this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton3.Name = "simpleButton3";
                  this.simpleButton3.Size = new System.Drawing.Size(112, 48);
                  this.simpleButton3.TabIndex = 2;
                  this.simpleButton3.Text = "Clear";
                  this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
                  // 
                  // simpleButton4
                  // 
                  this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton4.Location = new System.Drawing.Point(568, 265);
                  this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton4.Name = "simpleButton4";
                  this.simpleButton4.Size = new System.Drawing.Size(112, 48);
                  this.simpleButton4.TabIndex = 2;
                  this.simpleButton4.Tag = "Delete";
                  this.simpleButton4.Text = "Delete";
                  this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
                  // 
                  // simpleButton5
                  // 
                  this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton5.Location = new System.Drawing.Point(690, 265);
                  this.simpleButton5.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton5.Name = "simpleButton5";
                  this.simpleButton5.Size = new System.Drawing.Size(112, 48);
                  this.simpleButton5.TabIndex = 3;
                  this.simpleButton5.Text = "Load";
                  this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
                  // 
                  // simpleButton6
                  // 
                  this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                  this.simpleButton6.Location = new System.Drawing.Point(812, 265);
                  this.simpleButton6.Margin = new System.Windows.Forms.Padding(4);
                  this.simpleButton6.Name = "simpleButton6";
                  this.simpleButton6.Size = new System.Drawing.Size(146, 48);
                  this.simpleButton6.TabIndex = 4;
                  this.simpleButton6.Text = "Show In Report";
                  // 
                  // RadioGroup_expandCollapse
                  // 
                  this.RadioGroup_expandCollapse.Location = new System.Drawing.Point(6, 265);
                  this.RadioGroup_expandCollapse.Margin = new System.Windows.Forms.Padding(4);
                  this.RadioGroup_expandCollapse.Name = "RadioGroup_expandCollapse";
                  this.RadioGroup_expandCollapse.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.RadioGroup_expandCollapse.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.RadioGroup_expandCollapse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.RadioGroup_expandCollapse.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Expand"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Collapse")});
                  this.RadioGroup_expandCollapse.Size = new System.Drawing.Size(273, 31);
                  this.RadioGroup_expandCollapse.TabIndex = 21;
                  this.RadioGroup_expandCollapse.Visible = false;
                  this.RadioGroup_expandCollapse.SelectedIndexChanged += new System.EventHandler(this.RadioGroup_expandCollapse_SelectedIndexChanged);
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(795, 22);
                  this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(4);
                  this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
                  this.ListBoxControl_Rights.Size = new System.Drawing.Size(264, 409);
                  this.ListBoxControl_Rights.TabIndex = 28;
                  this.ListBoxControl_Rights.Tag = "ListRights";
                  this.ListBoxControl_Rights.Visible = false;
                  // 
                  // frm_COA
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1089, 330);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.Controls.Add(this.RadioGroup_expandCollapse);
                  this.Controls.Add(this.simpleButton6);
                  this.Controls.Add(this.simpleButton5);
                  this.Controls.Add(this.simpleButton4);
                  this.Controls.Add(this.simpleButton3);
                  this.Controls.Add(this.simpleButton2);
                  this.Controls.Add(this.simpleButton1);
                  this.Controls.Add(this.TL_COA);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "frm_COA";
                  this.Text = "Chart of Accounts";
                  this.Load += new System.EventHandler(this.XtraForm1_Load);
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_COA_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.TL_COA)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.RadioGroup_expandCollapse.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTreeList.TreeList TL_COA;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.RadioGroup RadioGroup_expandCollapse;
        public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

    }
}