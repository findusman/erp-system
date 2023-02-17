namespace PRESENTATION_LAYER
{
      partial class XtraForm3
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
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.GridControl_TBL_TEMP_DET = new DevExpress.XtraGrid.GridControl();
                  this.GridView_TBL_TEMP_DET = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
                  this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_TEMP_DET)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_TEMP_DET)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Location = new System.Drawing.Point(0, 0);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(75, 23);
                  this.simpleButton1.TabIndex = 0;
                  this.simpleButton1.Text = "simpleButton1";
                  // 
                  // GridControl_TBL_TEMP_DET
                  // 
                  this.GridControl_TBL_TEMP_DET.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
                  this.GridControl_TBL_TEMP_DET.Location = new System.Drawing.Point(102, 77);
                  this.GridControl_TBL_TEMP_DET.MainView = this.GridView_TBL_TEMP_DET;
                  this.GridControl_TBL_TEMP_DET.Margin = new System.Windows.Forms.Padding(4);
                  this.GridControl_TBL_TEMP_DET.Name = "GridControl_TBL_TEMP_DET";
                  this.GridControl_TBL_TEMP_DET.Size = new System.Drawing.Size(912, 292);
                  this.GridControl_TBL_TEMP_DET.TabIndex = 20;
                  this.GridControl_TBL_TEMP_DET.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView_TBL_TEMP_DET});
                  // 
                  // GridView_TBL_TEMP_DET
                  // 
                  this.GridView_TBL_TEMP_DET.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
                  this.GridView_TBL_TEMP_DET.GridControl = this.GridControl_TBL_TEMP_DET;
                  this.GridView_TBL_TEMP_DET.Name = "GridView_TBL_TEMP_DET";
                  this.GridView_TBL_TEMP_DET.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                  // 
                  // gridColumn1
                  // 
                  this.gridColumn1.Caption = "gridColumn1";
                  this.gridColumn1.Name = "gridColumn1";
                  this.gridColumn1.Visible = true;
                  this.gridColumn1.VisibleIndex = 0;
                  // 
                  // gridColumn2
                  // 
                  this.gridColumn2.AppearanceCell.BorderColor = System.Drawing.Color.White;
                  this.gridColumn2.AppearanceCell.Options.UseBorderColor = true;
                  this.gridColumn2.Caption = "gridColumn2";
                  this.gridColumn2.Name = "gridColumn2";
                  this.gridColumn2.Visible = true;
                  this.gridColumn2.VisibleIndex = 1;
                  // 
                  // XtraForm3
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1158, 625);
                  this.Controls.Add(this.GridControl_TBL_TEMP_DET);
                  this.Controls.Add(this.simpleButton1);
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "XtraForm3";
                  this.Text = "XtraForm3";
                  this.Load += new System.EventHandler(this.XtraForm3_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.GridControl_TBL_TEMP_DET)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.GridView_TBL_TEMP_DET)).EndInit();
                  this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraEditors.SimpleButton simpleButton1;
            public DevExpress.XtraGrid.GridControl GridControl_TBL_TEMP_DET;
            public DevExpress.XtraGrid.Views.Grid.GridView GridView_TBL_TEMP_DET;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
      }
}