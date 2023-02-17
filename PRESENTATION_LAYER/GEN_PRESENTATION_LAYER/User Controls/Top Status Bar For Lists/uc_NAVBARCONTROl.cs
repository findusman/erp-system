using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace DXWindowsApplication1
{
      public partial class uc_NAVBARCONTROl : DevExpress.XtraEditors.XtraUserControl
      {
            public uc_NAVBARCONTROl()
            {
                  InitializeComponent();
            }

            #region Is Expand


            public bool Pro_tempIsExpance = true;

            public bool Pro_IsExpance
            {

                  get
                  {

                        return Pro_tempIsExpance;

                  }
                  set
                  {
                        Pro_tempIsExpance = value;
                  }

            }

            #endregion

            #region Grid


            public DevExpress.XtraGrid.GridControl GridControl_tempPrivate = null;

            public DevExpress.XtraGrid.GridControl Pro_GridControl_temp
            {

                  get
                  {

                        return GridControl_tempPrivate;

                  }
                  set
                  {
                        GridControl_tempPrivate = value;
                  }

            }

            #endregion


            #region Panel for filters

            private DevExpress.XtraEditors.PanelControl PanelControl_filterPrivate = null;


            public DevExpress.XtraEditors.PanelControl Pro_PanelControl_filter
            {

                  get
                  {

                        return PanelControl_filterPrivate;

                  }
                  set
                  {
                        PanelControl_filterPrivate = value;
                  }

            }
            #endregion

            #region Van Control for Side Panel


            public DevExpress.XtraNavBar.NavBarControl Pro_NavBarControl_SidePanel
            {

                  get
                  {

                        return NavBarControl_sidePanel;

                  }
                  set
                  {
                        NavBarControl_sidePanel = value;
                  }

            }

            #endregion

            #region Panel For Grid

            private DevExpress.XtraEditors.PanelControl PanelControl_GridPrivate = null;


            public DevExpress.XtraEditors.PanelControl Pro_PanelControl_Grid
            {

                  get
                  {

                        return PanelControl_GridPrivate;

                  }
                  set
                  {
                        PanelControl_GridPrivate = value;
                  }

            }
            #endregion

            #region Split Control

            public DevExpress.XtraEditors.SplitContainerControl Pro_SplitContainerControl_main
            {

                  get
                  {

                        return SplitContainerControl_main;

                  }
                  set
                  {
                        SplitContainerControl_main = value;
                  }

            }
            #endregion

            public void collapseExpand(bool pIsExpand, int pSplitterPolistion)
            {

                  if (pIsExpand)
                  {
                        NavBarControl_sidePanel.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
                        SplitContainerControl_main.SplitterPosition = pSplitterPolistion;
                  }
                  else
                        NavBarControl_sidePanel.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
                  SplitContainerControl_main.SplitterPosition = 50;




            }


            DevExpress.XtraGrid.Views.Grid.GridView obj_GridView = null;
            DevExpress.XtraGrid.Views.Grid.GridView obj_bandedViewDetail = null;

            string viewType = "";
            string viewTypeDetail = "";

            private void uc_NAVBARCONTROl_Load(object sender, EventArgs e)
            {
                  try
                  {

                        viewType = Pro_GridControl_temp.MainView.GetType().Name;


                        if (viewType == "GridView")
                        {
                              obj_GridView = (GridView)Pro_GridControl_temp.MainView;
                              CheckEdit_showAutoRowFilter.Checked = obj_GridView.OptionsView.ShowAutoFilterRow;
                              CheckEdit_showFindPanel.Checked = obj_GridView.OptionsFind.AlwaysVisible;
                              CheckEdit_showRowFooter.Checked = obj_GridView.OptionsView.ShowFooter;
                              CheckEdit_showGroupPanel.Checked = obj_GridView.OptionsView.ShowGroupPanel;
                              obj_GridView.OptionsPrint.PrintDetails = true;
                              obj_GridView.OptionsPrint.ExpandAllDetails = true;
                              obj_GridView.OptionsPrint.ExpandAllGroups = true;

                              //viewviewTypeDetailType = obj_GridView.GetDetailView(

                        }


                        SplitContainerControl_main.Panel2.Controls.Add(Pro_PanelControl_Grid);

                        Point p = new Point(0, 0);
                        Pro_PanelControl_filter.Location = p;
                        navBarGroupControlContainer1.Controls.Add(Pro_PanelControl_filter);


                        if (!Pro_tempIsExpance)
                        {
                              NavBarControl_sidePanel.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
                              SplitContainerControl_main.SplitterPosition = 50;
                        }

                        //if(Pro_GridControl_temp.MainView.ty)


                        //GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(Pro_GridControl_temp.Views, Pro_GridControl_temp);
                        //ObjGenGrid.Apperance("List");
                        //ObjGenGrid.isAllowDeleteColumns = false;
                        //ObjGenGrid.Formatting();
                  }
                  catch (Exception ex)
                  { 
                  
                  }
            }

            private void simpleButton2_Click(object sender, EventArgs e)
            {
                  GEN.GEN_GEN.Look.Export_data obj_Export_data = new GEN.GEN_GEN.Look.Export_data(Pro_GridControl_temp);
                  obj_Export_data.ShowDialog();

            }

            private void checkEdit1_CheckedChanged(object sender, EventArgs e)
            {
                  if (viewType == "GridView")
                        obj_GridView.OptionsView.ShowAutoFilterRow = CheckEdit_showAutoRowFilter.Checked;
            }

            private void CheckEdit_showRowFooter_CheckedChanged(object sender, EventArgs e)
            {
                  if (viewType == "GridView")
                        obj_GridView.OptionsView.ShowFooter = CheckEdit_showRowFooter.Checked;
                  //GridView_tempPrivate.OptionsView.ShowFooter = CheckEdit_showRowFooter.Checked;

            }

            private void CheckEdit_showFindPanel_CheckedChanged(object sender, EventArgs e)
            {
                  if (viewType == "GridView")
                        obj_GridView.OptionsFind.AlwaysVisible = CheckEdit_showFindPanel.Checked;

                  //GridView_tempPrivate.OptionsFind.AlwaysVisible= CheckEdit_showFindPanel.Checked;

            }

            private void CheckEdit_showGroupPanel_CheckedChanged(object sender, EventArgs e)
            {
                  if (viewType == "GridView")
                        obj_GridView.OptionsView.ShowGroupPanel = CheckEdit_showGroupPanel.Checked;
                  //GridView_tempPrivate.OptionsView.ShowGroupPanel = CheckEdit_showGroupPanel.Checked;

            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {
                  GridControl_tempPrivate.ShowPrintPreview();
            }



      }
}
