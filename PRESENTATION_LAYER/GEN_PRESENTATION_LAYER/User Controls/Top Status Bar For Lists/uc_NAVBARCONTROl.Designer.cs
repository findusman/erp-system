namespace DXWindowsApplication1
{
    partial class uc_NAVBARCONTROl
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
                  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_NAVBARCONTROl));
                  this.NavBarControl_sidePanel = new DevExpress.XtraNavBar.NavBarControl();
                  this.NavBarGroup_Options = new DevExpress.XtraNavBar.NavBarGroup();
                  this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
                  this.CheckEdit_showGroupPanel = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_showFindPanel = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_showRowFooter = new DevExpress.XtraEditors.CheckEdit();
                  this.CheckEdit_showAutoRowFilter = new DevExpress.XtraEditors.CheckEdit();
                  this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
                  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
                  this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
                  this.NavBarGroup_Filter = new DevExpress.XtraNavBar.NavBarGroup();
                  this.SplitContainerControl_main = new DevExpress.XtraEditors.SplitContainerControl();
                  ((System.ComponentModel.ISupportInitialize)(this.NavBarControl_sidePanel)).BeginInit();
                  this.NavBarControl_sidePanel.SuspendLayout();
                  this.navBarGroupControlContainer2.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showGroupPanel.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showFindPanel.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showRowFooter.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showAutoRowFilter.Properties)).BeginInit();
                  ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl_main)).BeginInit();
                  this.SplitContainerControl_main.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // NavBarControl_sidePanel
                  // 
                  this.NavBarControl_sidePanel.ActiveGroup = this.NavBarGroup_Filter;
                  this.NavBarControl_sidePanel.Controls.Add(this.navBarGroupControlContainer1);
                  this.NavBarControl_sidePanel.Controls.Add(this.navBarGroupControlContainer2);
                  this.NavBarControl_sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.NavBarControl_sidePanel.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.NavBarGroup_Filter,
            this.NavBarGroup_Options});
                  this.NavBarControl_sidePanel.Location = new System.Drawing.Point(0, 0);
                  this.NavBarControl_sidePanel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
                  this.NavBarControl_sidePanel.Name = "NavBarControl_sidePanel";
                  this.NavBarControl_sidePanel.OptionsNavPane.ExpandedWidth = 446;
                  this.NavBarControl_sidePanel.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
                  this.NavBarControl_sidePanel.Size = new System.Drawing.Size(446, 833);
                  this.NavBarControl_sidePanel.TabIndex = 11;
                  this.NavBarControl_sidePanel.Text = "navBarControl1";
                  this.NavBarControl_sidePanel.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2010 Blue");
                  // 
                  // NavBarGroup_Options
                  // 
                  this.NavBarGroup_Options.Caption = "Options";
                  this.NavBarGroup_Options.ControlContainer = this.navBarGroupControlContainer2;
                  this.NavBarGroup_Options.GroupClientHeight = 80;
                  this.NavBarGroup_Options.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                  this.NavBarGroup_Options.Name = "NavBarGroup_Options";
                  this.NavBarGroup_Options.SmallImage = ((System.Drawing.Image)(resources.GetObject("NavBarGroup_Options.SmallImage")));
                  // 
                  // navBarGroupControlContainer2
                  // 
                  this.navBarGroupControlContainer2.Controls.Add(this.CheckEdit_showGroupPanel);
                  this.navBarGroupControlContainer2.Controls.Add(this.CheckEdit_showFindPanel);
                  this.navBarGroupControlContainer2.Controls.Add(this.CheckEdit_showRowFooter);
                  this.navBarGroupControlContainer2.Controls.Add(this.CheckEdit_showAutoRowFilter);
                  this.navBarGroupControlContainer2.Controls.Add(this.simpleButton2);
                  this.navBarGroupControlContainer2.Controls.Add(this.simpleButton1);
                  this.navBarGroupControlContainer2.Margin = new System.Windows.Forms.Padding(6);
                  this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
                  this.navBarGroupControlContainer2.Size = new System.Drawing.Size(446, 693);
                  this.navBarGroupControlContainer2.TabIndex = 1;
                  // 
                  // CheckEdit_showGroupPanel
                  // 
                  this.CheckEdit_showGroupPanel.Location = new System.Drawing.Point(20, 193);
                  this.CheckEdit_showGroupPanel.Margin = new System.Windows.Forms.Padding(6);
                  this.CheckEdit_showGroupPanel.Name = "CheckEdit_showGroupPanel";
                  this.CheckEdit_showGroupPanel.Properties.Caption = "Group Panel";
                  this.CheckEdit_showGroupPanel.Size = new System.Drawing.Size(193, 23);
                  this.CheckEdit_showGroupPanel.TabIndex = 20;
                  this.CheckEdit_showGroupPanel.Tag = "N_N";
                  this.CheckEdit_showGroupPanel.CheckedChanged += new System.EventHandler(this.CheckEdit_showGroupPanel_CheckedChanged);
                  // 
                  // CheckEdit_showFindPanel
                  // 
                  this.CheckEdit_showFindPanel.Location = new System.Drawing.Point(20, 157);
                  this.CheckEdit_showFindPanel.Margin = new System.Windows.Forms.Padding(6);
                  this.CheckEdit_showFindPanel.Name = "CheckEdit_showFindPanel";
                  this.CheckEdit_showFindPanel.Properties.Caption = "Find Panel";
                  this.CheckEdit_showFindPanel.Size = new System.Drawing.Size(193, 23);
                  this.CheckEdit_showFindPanel.TabIndex = 19;
                  this.CheckEdit_showFindPanel.Tag = "N_N";
                  this.CheckEdit_showFindPanel.CheckedChanged += new System.EventHandler(this.CheckEdit_showFindPanel_CheckedChanged);
                  // 
                  // CheckEdit_showRowFooter
                  // 
                  this.CheckEdit_showRowFooter.EditValue = true;
                  this.CheckEdit_showRowFooter.Location = new System.Drawing.Point(20, 121);
                  this.CheckEdit_showRowFooter.Margin = new System.Windows.Forms.Padding(6);
                  this.CheckEdit_showRowFooter.Name = "CheckEdit_showRowFooter";
                  this.CheckEdit_showRowFooter.Properties.Caption = "Row Footer";
                  this.CheckEdit_showRowFooter.Size = new System.Drawing.Size(193, 23);
                  this.CheckEdit_showRowFooter.TabIndex = 18;
                  this.CheckEdit_showRowFooter.Tag = "N_N";
                  this.CheckEdit_showRowFooter.CheckedChanged += new System.EventHandler(this.CheckEdit_showRowFooter_CheckedChanged);
                  // 
                  // CheckEdit_showAutoRowFilter
                  // 
                  this.CheckEdit_showAutoRowFilter.EditValue = true;
                  this.CheckEdit_showAutoRowFilter.Location = new System.Drawing.Point(20, 85);
                  this.CheckEdit_showAutoRowFilter.Margin = new System.Windows.Forms.Padding(6);
                  this.CheckEdit_showAutoRowFilter.Name = "CheckEdit_showAutoRowFilter";
                  this.CheckEdit_showAutoRowFilter.Properties.Caption = "Auto Filter Row";
                  this.CheckEdit_showAutoRowFilter.Size = new System.Drawing.Size(193, 23);
                  this.CheckEdit_showAutoRowFilter.TabIndex = 17;
                  this.CheckEdit_showAutoRowFilter.Tag = "N_N";
                  this.CheckEdit_showAutoRowFilter.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
                  // 
                  // simpleButton2
                  // 
                  this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
                  this.simpleButton2.Location = new System.Drawing.Point(135, 22);
                  this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
                  this.simpleButton2.Name = "simpleButton2";
                  this.simpleButton2.Size = new System.Drawing.Size(101, 51);
                  this.simpleButton2.TabIndex = 16;
                  this.simpleButton2.Tag = "N_N";
                  this.simpleButton2.Text = "Export";
                  this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
                  // 
                  // simpleButton1
                  // 
                  this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
                  this.simpleButton1.Location = new System.Drawing.Point(22, 22);
                  this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
                  this.simpleButton1.Name = "simpleButton1";
                  this.simpleButton1.Size = new System.Drawing.Size(101, 51);
                  this.simpleButton1.TabIndex = 15;
                  this.simpleButton1.Tag = "N_N";
                  this.simpleButton1.Text = "Print";
                  this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
                  // 
                  // navBarGroupControlContainer1
                  // 
                  this.navBarGroupControlContainer1.Margin = new System.Windows.Forms.Padding(6);
                  this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
                  this.navBarGroupControlContainer1.Size = new System.Drawing.Size(446, 693);
                  this.navBarGroupControlContainer1.TabIndex = 0;
                  // 
                  // NavBarGroup_Filter
                  // 
                  this.NavBarGroup_Filter.Caption = "Filters";
                  this.NavBarGroup_Filter.ControlContainer = this.navBarGroupControlContainer1;
                  this.NavBarGroup_Filter.Expanded = true;
                  this.NavBarGroup_Filter.GroupClientHeight = 80;
                  this.NavBarGroup_Filter.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                  this.NavBarGroup_Filter.Name = "NavBarGroup_Filter";
                  this.NavBarGroup_Filter.SmallImage = ((System.Drawing.Image)(resources.GetObject("NavBarGroup_Filter.SmallImage")));
                  // 
                  // SplitContainerControl_main
                  // 
                  this.SplitContainerControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
                  this.SplitContainerControl_main.Location = new System.Drawing.Point(0, 0);
                  this.SplitContainerControl_main.Margin = new System.Windows.Forms.Padding(6);
                  this.SplitContainerControl_main.Name = "SplitContainerControl_main";
                  this.SplitContainerControl_main.Panel1.Controls.Add(this.NavBarControl_sidePanel);
                  this.SplitContainerControl_main.Panel1.Text = "Panel1";
                  this.SplitContainerControl_main.Panel2.Text = "Panel2";
                  this.SplitContainerControl_main.Size = new System.Drawing.Size(1251, 833);
                  this.SplitContainerControl_main.SplitterPosition = 446;
                  this.SplitContainerControl_main.TabIndex = 12;
                  this.SplitContainerControl_main.Text = "splitContainerControl1";
                  // 
                  // uc_NAVBARCONTROl
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.Controls.Add(this.SplitContainerControl_main);
                  this.Margin = new System.Windows.Forms.Padding(6);
                  this.Name = "uc_NAVBARCONTROl";
                  this.Size = new System.Drawing.Size(1251, 833);
                  this.Load += new System.EventHandler(this.uc_NAVBARCONTROl_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.NavBarControl_sidePanel)).EndInit();
                  this.NavBarControl_sidePanel.ResumeLayout(false);
                  this.navBarGroupControlContainer2.ResumeLayout(false);
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showGroupPanel.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showFindPanel.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showRowFooter.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.CheckEdit_showAutoRowFilter.Properties)).EndInit();
                  ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl_main)).EndInit();
                  this.SplitContainerControl_main.ResumeLayout(false);
                  this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl NavBarControl_sidePanel;
        private DevExpress.XtraNavBar.NavBarGroup NavBarGroup_Options;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroup NavBarGroup_Filter;
        private DevExpress.XtraEditors.SplitContainerControl SplitContainerControl_main;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_showGroupPanel;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_showFindPanel;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_showRowFooter;
        private DevExpress.XtraEditors.CheckEdit CheckEdit_showAutoRowFilter;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
