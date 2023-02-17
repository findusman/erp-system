using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE
{
      partial class frm_TBL_OPENING_BALANCE
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
                  this.LabelControl_SimpleButton_List = new DevExpress.XtraEditors.LabelControl();
                  this.SimpleButton_Referesh = new DevExpress.XtraEditors.SimpleButton();
                  this.LabelControl_SimpleButton_Referesh = new DevExpress.XtraEditors.LabelControl();
                  this.SimpleButton_Referesh_A = new DevExpress.XtraEditors.SimpleButton();
                  this.LabelControl_SimpleButton_Referesh_A = new DevExpress.XtraEditors.LabelControl();
                  this.LabelControl_SimpleButton_Delete = new DevExpress.XtraEditors.LabelControl();
                  this.SimpleButton_Save = new DevExpress.XtraEditors.SimpleButton();
                  this.LabelControl_SimpleButton_Save = new DevExpress.XtraEditors.LabelControl();
                  this.SimpleButton_Exit = new DevExpress.XtraEditors.SimpleButton();
                  this.LabelControl_SimpleButton_Exit = new DevExpress.XtraEditors.LabelControl();
                  this.GridControl_TBL_OPENING_BALANCE = new DevExpress.XtraGrid.GridControl();
                  this.GridView_TBL_OPENING_BALANCE = new DevExpress.XtraGrid.Views.Grid.GridView();
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_OPENING_BALANCE)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_OPENING_BALANCE)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // ListBoxControl_Rights
                  // 
                  this.ListBoxControl_Rights.Items.AddRange(new object[] {
            "key_insert",
            "key_update",
            "key_del"});
                  this.ListBoxControl_Rights.Location = new System.Drawing.Point(13, 13);
                  this.ListBoxControl_Rights.Margin = new System.Windows.Forms.Padding(4);
                  this.ListBoxControl_Rights.Name = "ListBoxControl_Rights";
                  this.ListBoxControl_Rights.Size = new System.Drawing.Size(264, 409);
                  this.ListBoxControl_Rights.TabIndex = 27;
                  this.ListBoxControl_Rights.Visible = false;
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
                  this.SimpleButton_Referesh.Location = new System.Drawing.Point(735, 381);
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
                  this.SimpleButton_Save.Location = new System.Drawing.Point(849, 381);
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
                  this.SimpleButton_Exit.Location = new System.Drawing.Point(963, 381);
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
                  // GridControl_TBL_OPENING_BALANCE
                  // 
                  this.GridControl_TBL_OPENING_BALANCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.GridControl_TBL_OPENING_BALANCE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
                  this.GridControl_TBL_OPENING_BALANCE.Location = new System.Drawing.Point(13, 13);
                  this.GridControl_TBL_OPENING_BALANCE.MainView = this.GridView_TBL_OPENING_BALANCE;
                  this.GridControl_TBL_OPENING_BALANCE.Margin = new System.Windows.Forms.Padding(4);
                  this.GridControl_TBL_OPENING_BALANCE.Name = "GridControl_TBL_OPENING_BALANCE";
                  this.GridControl_TBL_OPENING_BALANCE.Size = new System.Drawing.Size(1056, 358);
                  this.GridControl_TBL_OPENING_BALANCE.TabIndex = 19;
                  this.GridControl_TBL_OPENING_BALANCE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_OPENING_BALANCE});
                  // 
                  // GridView_TBL_OPENING_BALANCE
                  // 
                  this.GridView_TBL_OPENING_BALANCE.GridControl = this.GridControl_TBL_OPENING_BALANCE;
                  this.GridView_TBL_OPENING_BALANCE.Name = "GridView_TBL_OPENING_BALANCE";
                  // 
                  // frm_TBL_OPENING_BALANCE
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1082, 436);
                  this.Controls.Add(this.SimpleButton_Referesh);
                  this.Controls.Add(this.SimpleButton_Referesh_A);
                  this.Controls.Add(this.SimpleButton_Save);
                  this.Controls.Add(this.SimpleButton_Exit);
                  this.Controls.Add(this.GridControl_TBL_OPENING_BALANCE);
                  this.Controls.Add(this.ListBoxControl_Rights);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "frm_TBL_OPENING_BALANCE";
                  this.Tag = "TBL_OPENING_BALANCE";
                  this.Text = "Opening Balances";
                  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_TBL_OPENING_BALANCE_KeyDown);
                  ((System.ComponentModel.ISupportInitialize)(this.ListBoxControl_Rights)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_OPENING_BALANCE)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_OPENING_BALANCE)).EndInit();
                  this.ResumeLayout(false);

            }

            #endregion

            public DevExpress.XtraEditors.ListBoxControl ListBoxControl_Rights;

            public DevExpress.XtraGrid.GridControl GridControl_TBL_OPENING_BALANCE;
            public GridView GridView_TBL_OPENING_BALANCE;
            public LabelControl LabelControl_SimpleButton_List;

            public SimpleButton SimpleButton_Referesh;
            public LabelControl LabelControl_SimpleButton_Referesh;

            public SimpleButton SimpleButton_Referesh_A;
            public LabelControl LabelControl_SimpleButton_Referesh_A;
            public LabelControl LabelControl_SimpleButton_Delete;

            public SimpleButton SimpleButton_Save;
            public LabelControl LabelControl_SimpleButton_Save;

            public SimpleButton SimpleButton_Exit;
            public LabelControl LabelControl_SimpleButton_Exit;




      }
}