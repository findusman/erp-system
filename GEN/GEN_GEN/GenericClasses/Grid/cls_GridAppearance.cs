using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace GEN.GEN_GEN.GenericClasses.Grid
{
    public class cls_GridAppearance
  {

      public static void setAppearance(DevExpress.XtraGrid.Views.Grid.GridView Grid_View, string Type)
      {
          /// Row Appearance


          if (Type == "L")
          {

              Grid_View.Appearance.Row.Font = new Font("Tahoma", 9, FontStyle.Regular);

              Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 9, FontStyle.Regular);

              Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

              Grid_View.RowHeight = 22;
              Grid_View.OptionsView.ShowFooter = false;


          }

          else if (Type == "I")
          {


              //   Appearance

              Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
              Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
              Grid_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
              Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
              Grid_View.RowHeight = 20;

              //   Behaviour

              Grid_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
              Grid_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
              Grid_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

              //   Customization


              Grid_View.OptionsCustomization.AllowColumnMoving = false;
              Grid_View.OptionsCustomization.AllowColumnResizing = true;
              Grid_View.OptionsCustomization.AllowFilter = false;
              Grid_View.OptionsCustomization.AllowGroup = true;
              Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
              Grid_View.OptionsCustomization.AllowRowSizing = true;
              Grid_View.OptionsCustomization.AllowSort = true;


              //   Find


              Grid_View.OptionsFind.AllowFindPanel = true;
              Grid_View.OptionsFind.AlwaysVisible = false;
              Grid_View.OptionsFind.ClearFindOnClose = true;
              Grid_View.OptionsFind.FindDelay = 100;
              Grid_View.OptionsFind.FindFilterColumns = "*";
              Grid_View.OptionsFind.FindMode = FindMode.Default;
              Grid_View.OptionsFind.HighlightFindResults = true;
              Grid_View.OptionsFind.ShowCloseButton = true;



              // Option Layout

              Grid_View.OptionsLayout.Columns.AddNewColumns = false;
              Grid_View.OptionsLayout.Columns.RemoveOldColumns = false;



              //  option menue 


              Grid_View.OptionsMenu.EnableColumnMenu = false;
              Grid_View.OptionsMenu.EnableFooterMenu = false;
              Grid_View.OptionsMenu.EnableGroupPanelMenu = false;
              Grid_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;


              // option navigation

              Grid_View.OptionsNavigation.AutoFocusNewRow = true;
              Grid_View.OptionsNavigation.AutoMoveRowFocus = true;
              Grid_View.OptionsNavigation.EnterMoveNextColumn = false;
              Grid_View.OptionsNavigation.UseOfficePageNavigation = true;
              Grid_View.OptionsNavigation.UseTabKey = true;


              // option selection 


              Grid_View.OptionsSelection.EnableAppearanceFocusedCell = true;
              Grid_View.OptionsSelection.EnableAppearanceFocusedRow = true;
              Grid_View.OptionsSelection.EnableAppearanceHideSelection = true;
              Grid_View.OptionsSelection.MultiSelect = true;
              Grid_View.OptionsSelection.UseIndicatorForSelection = true;




              // option  view



              Grid_View.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
              Grid_View.OptionsView.ColumnAutoWidth = true;
              Grid_View.OptionsView.EnableAppearanceEvenRow = false;
              Grid_View.OptionsView.EnableAppearanceOddRow = false;
              Grid_View.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
              Grid_View.OptionsView.RowAutoHeight = true;
              Grid_View.OptionsView.ShowColumnHeaders = true;
              Grid_View.OptionsView.ShowFooter = true;
              Grid_View.OptionsView.ShowGroupedColumns = true;
              Grid_View.OptionsView.ShowGroupPanel = false;
              //  Grid_View.OptionsView.
              //Grid_View.OptionsView.

          }


      }


  }
}
