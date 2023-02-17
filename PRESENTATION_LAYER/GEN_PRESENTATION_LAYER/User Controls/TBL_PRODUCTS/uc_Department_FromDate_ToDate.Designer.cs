namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_PRODUCTS.User_Controls
{
      partial class uc_Department_FromDate_ToDate
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  this.GridLookUpEdit_departments = new DevExpress.XtraEditors.GridLookUpEdit();
                  this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
                  this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
                  this.DateEdit_toDate = new DevExpress.XtraEditors.DateEdit();
                  this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
                  this.DateEdit_fromDate = new DevExpress.XtraEditors.DateEdit();
                  this.ComboBoxEdit_comboBox = new DevExpress.XtraEditors.ComboBoxEdit();
                  this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
                  this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_departments.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties.CalendarTimeProperties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties.CalendarTimeProperties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_comboBox.Properties)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // GridLookUpEdit_departments
                  // 
                  this.GridLookUpEdit_departments.EnterMoveNextControl = true;
                  this.GridLookUpEdit_departments.Location = new System.Drawing.Point(69, 7);
                  this.GridLookUpEdit_departments.Margin = new System.Windows.Forms.Padding(4);
                  this.GridLookUpEdit_departments.Name = "GridLookUpEdit_departments";
                  this.GridLookUpEdit_departments.Properties.View = this.gridView1;
                  this.GridLookUpEdit_departments.Size = new System.Drawing.Size(401, 26);
                  this.GridLookUpEdit_departments.TabIndex = 33;
                  this.GridLookUpEdit_departments.Tag = "N_T";
                  // 
                  // gridView1
                  // 
                  this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                  this.gridView1.Name = "gridView1";
                  this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                  this.gridView1.OptionsView.ShowGroupPanel = false;
                  // 
                  // labelControl1
                  // 
                  this.labelControl1.Location = new System.Drawing.Point(71, 141);
                  this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl1.Name = "labelControl1";
                  this.labelControl1.Size = new System.Drawing.Size(58, 19);
                  this.labelControl1.TabIndex = 36;
                  this.labelControl1.Text = "T Date :";
                  // 
                  // DateEdit_toDate
                  // 
                  this.DateEdit_toDate.EditValue = null;
                  this.DateEdit_toDate.Location = new System.Drawing.Point(132, 137);
                  this.DateEdit_toDate.Margin = new System.Windows.Forms.Padding(6);
                  this.DateEdit_toDate.Name = "DateEdit_toDate";
                  this.DateEdit_toDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.DateEdit_toDate.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.DateEdit_toDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.DateEdit_toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.DateEdit_toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                  this.DateEdit_toDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
                  this.DateEdit_toDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
                  this.DateEdit_toDate.Size = new System.Drawing.Size(233, 28);
                  this.DateEdit_toDate.TabIndex = 39;
                  this.DateEdit_toDate.Tag = "N_T";
                  // 
                  // labelControl3
                  // 
                  this.labelControl3.Location = new System.Drawing.Point(73, 101);
                  this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl3.Name = "labelControl3";
                  this.labelControl3.Size = new System.Drawing.Size(56, 19);
                  this.labelControl3.TabIndex = 37;
                  this.labelControl3.Text = "F Date :";
                  // 
                  // DateEdit_fromDate
                  // 
                  this.DateEdit_fromDate.EditValue = null;
                  this.DateEdit_fromDate.Location = new System.Drawing.Point(132, 97);
                  this.DateEdit_fromDate.Margin = new System.Windows.Forms.Padding(6);
                  this.DateEdit_fromDate.Name = "DateEdit_fromDate";
                  this.DateEdit_fromDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                  this.DateEdit_fromDate.Properties.AppearanceFocused.Options.UseBorderColor = true;
                  this.DateEdit_fromDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                  this.DateEdit_fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.DateEdit_fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
                  this.DateEdit_fromDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
                  this.DateEdit_fromDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
                  this.DateEdit_fromDate.Size = new System.Drawing.Size(233, 28);
                  this.DateEdit_fromDate.TabIndex = 38;
                  this.DateEdit_fromDate.Tag = "N_T";
                  // 
                  // ComboBoxEdit_comboBox
                  // 
                  this.ComboBoxEdit_comboBox.EditValue = "Manual";
                  this.ComboBoxEdit_comboBox.EnterMoveNextControl = true;
                  this.ComboBoxEdit_comboBox.Location = new System.Drawing.Point(132, 61);
                  this.ComboBoxEdit_comboBox.Margin = new System.Windows.Forms.Padding(4);
                  this.ComboBoxEdit_comboBox.Name = "ComboBoxEdit_comboBox";
                  this.ComboBoxEdit_comboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                  this.ComboBoxEdit_comboBox.Properties.Items.AddRange(new object[] {
            "Manual",
            "Last Day",
            "Last Week",
            "Last Month",
            "Last Quarter "});
                  this.ComboBoxEdit_comboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                  this.ComboBoxEdit_comboBox.Size = new System.Drawing.Size(338, 26);
                  this.ComboBoxEdit_comboBox.TabIndex = 40;
                  this.ComboBoxEdit_comboBox.Tag = "N_T_N";
                  this.ComboBoxEdit_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_comboBox_SelectedIndexChanged);
                  // 
                  // labelControl4
                  // 
                  this.labelControl4.Location = new System.Drawing.Point(26, 64);
                  this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl4.Name = "labelControl4";
                  this.labelControl4.Size = new System.Drawing.Size(103, 19);
                  this.labelControl4.TabIndex = 37;
                  this.labelControl4.Text = "Date Options :";
                  // 
                  // labelControl2
                  // 
                  this.labelControl2.Location = new System.Drawing.Point(27, 10);
                  this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
                  this.labelControl2.Name = "labelControl2";
                  this.labelControl2.Size = new System.Drawing.Size(39, 19);
                  this.labelControl2.TabIndex = 35;
                  this.labelControl2.Text = "Dep :";
                  // 
                  // uc_Department_FromDate_ToDate
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.Controls.Add(this.ComboBoxEdit_comboBox);
                  this.Controls.Add(this.labelControl1);
                  this.Controls.Add(this.labelControl4);
                  this.Controls.Add(this.labelControl3);
                  this.Controls.Add(this.DateEdit_toDate);
                  this.Controls.Add(this.DateEdit_fromDate);
                  this.Controls.Add(this.labelControl2);
                  this.Controls.Add(this.GridLookUpEdit_departments);
                  this.Name = "uc_Department_FromDate_ToDate";
                  this.Size = new System.Drawing.Size(476, 176);
                  this.Load += new System.EventHandler(this.uc_Department_Product_FromDate_ToDate_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEdit_departments.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties.CalendarTimeProperties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_toDate.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties.CalendarTimeProperties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.DateEdit_fromDate.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.ComboBoxEdit_comboBox.Properties)).EndInit();
                  this.ResumeLayout(false);
                  this.PerformLayout();

            }

            #endregion

            public DevExpress.XtraEditors.GridLookUpEdit GridLookUpEdit_departments;
            public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
            public DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_comboBox;
            public DevExpress.XtraEditors.LabelControl labelControl1;
            public DevExpress.XtraEditors.DateEdit DateEdit_toDate;
            public DevExpress.XtraEditors.LabelControl labelControl3;
            public DevExpress.XtraEditors.DateEdit DateEdit_fromDate;
            public DevExpress.XtraEditors.LabelControl labelControl4;
            public DevExpress.XtraEditors.LabelControl labelControl2;
      }
}
