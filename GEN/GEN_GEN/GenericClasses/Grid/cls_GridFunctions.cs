using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraGrid.Columns;

namespace GEN.GEN_GEN.GenericClasses.Grid
{
  public  class cls_GridFunctions
    {


      public static void setColumnsWidth(GridView gridview, string width)
      {

          DataRow row;
          string[] w;

          w = width.Split(',');


          for (int x = 0; x < w.Length; x++)
          {

              gridview.Columns[x].Width = Convert.ToInt32(w[x]);

          }
      }

      public static void makeColumnsInvisible(GridView gridview, string width)
      {

          DataRow row;
          string[] w;

          w = width.Split(',');


          for (int x = 0; x < w.Length; x++)
          {

              gridview.Columns[w[x]].Visible = false;

          }
      }

      public static RepositoryItemLookUpEdit getRepositoryLookUpEdit(
          string pDisplayMember, 
          string pValueMmber, 
          string pDisplayMemberforCaption, 
          string pValueMmberforCaption, 
          string pDisplay_MemberCaption, 
          string pValue_memberCaption, DataTable pdt, 
          string pValueMmberForSelection, 
          int pVisibleRows, 
          int pPopUpWidth, 
          int pValueMemberWidth)
      {

          RepositoryItemLookUpEdit lookupedit = new RepositoryItemLookUpEdit();

          pdt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
          pdt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;


          lookupedit.DataSource = pdt;
          lookupedit.DisplayMember = pDisplayMember;
          lookupedit.ValueMember = pValueMmber;

          lookupedit.ReadOnly = false;
          lookupedit.NullText = "";

          lookupedit.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
          lookupedit.DropDownRows = pVisibleRows;
          lookupedit.PopupWidth = pPopUpWidth;
          return lookupedit;

      }
      public static RepositoryItemGridLookUpEdit getRepositoryGridLookUpEdit(
          string pDisplayMember, 
          string pValueMmber, 
          string pDisplayMemberforCaption, 
          string pValueMmberforCaption, 
          string pDisplay_MemberCaption, 
          string pValue_memberCaption, 
          DataTable pdt, 
          string pValueMmberForSelection, 
          int pPopUpHeight, 
          int pPopUpWidth, 
          int pValueMemberWidth)
      {

          RepositoryItemGridLookUpEdit lookupedit = new RepositoryItemGridLookUpEdit();
          lookupedit.View.Appearance.HeaderPanel.Font = GEN.GEN_GEN.GenericClasses.Appearance.cls_Appearance.GO_RepositoryGridLookUpHeaderAppearance_Fona;

          pdt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
          pdt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;

         // lookupedit.View.OptionsBehavior.AutoPopulateColumns = false;

          lookupedit.DataSource = pdt;
          lookupedit.DisplayMember = pDisplayMember;
          lookupedit.ValueMember = pValueMmber;

          lookupedit.View.PopulateColumns(lookupedit.DataSource);

          lookupedit.ReadOnly = false;
          lookupedit.NullText = "";

          lookupedit.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
          lookupedit.View.OptionsView.ShowAutoFilterRow = true;
          lookupedit.View.OptionsFind.AllowFindPanel = true;
          lookupedit.View.OptionsFind.AlwaysVisible= true;
          lookupedit.View.ShowFindPanel();
         
          lookupedit.View.Columns[pValueMmber].OptionsColumn.FixedWidth= true;
          lookupedit.View.Columns[pValueMmber].Width = pValueMemberWidth;
          lookupedit.View.Columns[pValueMmber].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center ;

          lookupedit.PopupFormSize = new Size(pPopUpWidth,pPopUpHeight);



          foreach (GridColumn tmpColumn in lookupedit.View.Columns)
          {

              if (tmpColumn.FieldName != pValueMmber && tmpColumn.FieldName != pDisplayMember)
              {
                  tmpColumn.BestFit();
              }

          }

          

          
          return lookupedit;

      }

      public static RepositoryItemGridLookUpEdit getRepositoryGridLookUpEdit(
          string pDisplayMember, 
          string pValueMmber, 
          string pDisplayMemberforCaption, 
          string pValueMmberforCaption, 
          string pDisplay_MemberCaption, 
          string pValue_memberCaption, 
          DataTable pdt, 
          string pValueMmberForSelection, 
          int pPopUpHeight, 
          int pPopUpWidth, 
          int pValueMemberWidth, 
          String pColumnsForVisibility, 
          Boolean pIsMakeVisible, 
          Boolean pIsPerformVisibilityAndBestFit, 
          Boolean pIsShowFilterRow)
      {

          RepositoryItemGridLookUpEdit lookupedit = new RepositoryItemGridLookUpEdit();
          lookupedit.View.Appearance.HeaderPanel.Font = GEN.GEN_GEN.GenericClasses.Appearance.cls_Appearance.GO_RepositoryGridLookUpHeaderAppearance_Fona;

          pdt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
          pdt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;

          // lookupedit.View.OptionsBehavior.AutoPopulateColumns = false;

          lookupedit.DataSource = pdt;
          lookupedit.DisplayMember = pDisplayMember;
          lookupedit.ValueMember = pValueMmber;

          lookupedit.View.PopulateColumns(lookupedit.DataSource);

          lookupedit.ReadOnly = false;
          lookupedit.NullText = "";

          //lookupedit.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

          lookupedit.View.OptionsView.ShowAutoFilterRow = pIsShowFilterRow;
          lookupedit.View.OptionsView.ShowFilterPanelMode = pIsShowFilterRow ? DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways : DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never ;
          lookupedit.View.OptionsView.ShowHorizontalLines= DevExpress.Utils.DefaultBoolean.True;

          lookupedit.View.OptionsView.ShowIndicator = false;
          lookupedit.View.OptionsFind.AllowFindPanel = true;
          lookupedit.View.OptionsFind.AlwaysVisible = true;
          lookupedit.View.ShowFindPanel();

          lookupedit.View.Columns[pValueMmber].OptionsColumn.FixedWidth = true;
          lookupedit.View.Columns[pValueMmber].Width = pValueMemberWidth;
          lookupedit.View.Columns[pValueMmber].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

          lookupedit.PopupFormSize = new Size(pPopUpWidth, pPopUpHeight);


          String[] tmp_Columns = pColumnsForVisibility.Split(',');


          if (pIsPerformVisibilityAndBestFit)
          {

              foreach (GridColumn tmpColumn in lookupedit.View.Columns)
              {
                  tmpColumn.Visible = !pIsMakeVisible;

                  foreach (String str in tmp_Columns)
                  {

                      if (tmpColumn.FieldName == str)
                          tmpColumn.Visible = pIsMakeVisible;
                  }

                  if (tmpColumn.FieldName != pValueMmber && tmpColumn.FieldName != pDisplayMember)
                  {
                      tmpColumn.BestFit();
                  }

              }

          }


          if (pIsMakeVisible)
          { 
          
              
          
          
          
          }

          //  lookupedit.DropDownRows = pVisibleRows;
          //  lookupedit.PopupWidth = pPopUpWidth;

          return lookupedit;

      }


      public static void getRepositoryGridLookUpEdit(
            RepositoryItemGridLookUpEdit lookupedit,
       string pDisplayMember,
       string pValueMmber,
       string pDisplayMemberforCaption,
       string pValueMmberforCaption,
       string pDisplay_MemberCaption,
       string pValue_memberCaption,
       DataTable pdt,
       string pValueMmberForSelection,
       int pPopUpHeight,
       int pPopUpWidth,
       int pValueMemberWidth,
       String pColumnsForVisibility,
       Boolean pIsMakeVisible,
       Boolean pIsPerformVisibilityAndBestFit,
       Boolean pIsShowFilterRow)
      {

            lookupedit.View.Appearance.HeaderPanel.Font = GEN.GEN_GEN.GenericClasses.Appearance.cls_Appearance.GO_RepositoryGridLookUpHeaderAppearance_Fona;

            pdt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
            pdt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;

            // lookupedit.View.OptionsBehavior.AutoPopulateColumns = false;

            lookupedit.DataSource = pdt;
            lookupedit.DisplayMember = pDisplayMember;
            lookupedit.ValueMember = pValueMmber;

            lookupedit.View.PopulateColumns(lookupedit.DataSource);

            lookupedit.ReadOnly = false;
            lookupedit.NullText = "";

            lookupedit.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            lookupedit.View.OptionsView.ShowAutoFilterRow = pIsShowFilterRow;
            lookupedit.View.OptionsView.ShowFilterPanelMode = pIsShowFilterRow ? DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways : DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            lookupedit.View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;

            lookupedit.View.OptionsView.ShowIndicator = false;
            lookupedit.View.OptionsFind.AllowFindPanel = true;
            lookupedit.View.OptionsFind.AlwaysVisible = true;
            lookupedit.View.ShowFindPanel();

            lookupedit.View.Columns[pValueMmber].OptionsColumn.FixedWidth = true;
            lookupedit.View.Columns[pValueMmber].Width = pValueMemberWidth;
            lookupedit.View.Columns[pValueMmber].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            lookupedit.PopupFormSize = new Size(pPopUpWidth, pPopUpHeight);


            String[] tmp_Columns = pColumnsForVisibility.Split(',');


            if (pIsPerformVisibilityAndBestFit)
            {

                  foreach (GridColumn tmpColumn in lookupedit.View.Columns)
                  {
                        tmpColumn.Visible = !pIsMakeVisible;

                        foreach (String str in tmp_Columns)
                        {

                              if (tmpColumn.FieldName == str)
                                    tmpColumn.Visible = pIsMakeVisible;
                        }

                        if (tmpColumn.FieldName != pValueMmber && tmpColumn.FieldName != pDisplayMember)
                        {
                              tmpColumn.BestFit();
                        }

                  }

            }


            if (pIsMakeVisible)
            {





            }

            //  lookupedit.DropDownRows = pVisibleRows;
            //  lookupedit.PopupWidth = pPopUpWidth;

           

      }


      public static void getGridLookUpEdit(GridLookUpEdit pGridLookUpEdit, string pDisplayMember, string pValueMmber, string pDisplayMemberforCaption, string pValueMmberforCaption, string pDisplay_MemberCaption, string pValue_memberCaption, DataSet pds, string pValueMmberForSelection, int pVisibleRows, int pPopUpWidth, int pValueMemberWidth)
      {
          // combobox = new ComboBoxEdit();

          

          pGridLookUpEdit.Properties.DataSource = null;
          pGridLookUpEdit.Properties.DisplayMember = null;
         // pGridLookUpEdit.Properties.Appearance.HeaderPanel.Font = GEN.GEN_GEN.GenericClasses.Appearance.cls_Appearance.GO_RepositoryGridLookUpHeaderAppearance_Fona;
          
          
          DataTable dt = new DataTable();

          if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(pds))
          {

             
              dt = pds.Tables[0];

              dt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
              dt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;


              pGridLookUpEdit.Refresh();
              

              pGridLookUpEdit.Properties.DataSource = dt;
            
              pGridLookUpEdit.Properties.DisplayMember = pDisplayMember;
              pGridLookUpEdit.Properties.ValueMember = pValueMmber;
              pGridLookUpEdit.Properties.PopulateViewColumns();
              pGridLookUpEdit.Properties.View.Columns[0].Width = pValueMemberWidth;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
           //   pGridLookUpEdit.Properties.View. = 0;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.Font =  new Font("Tahoma", 9, FontStyle.Regular);
              
              try
              {
                 // pGridLookUpEdit.Text = dt.Rows[0][pDisplayMember].ToString();
                   pGridLookUpEdit.EditValue = pGridLookUpEdit.Properties.GetKeyValue(0);   //dt.Rows[0][pValueMmber];

                  
               
          }

          catch
          {

          }
            
          }

          pGridLookUpEdit.Properties.ReadOnly = false;
          pGridLookUpEdit.Properties.NullText = "";
          pGridLookUpEdit.Properties.View.BestFitMaxRowCount = pVisibleRows;
          pGridLookUpEdit.Properties.View.OptionsView.ShowAutoFilterRow = true;
          System.Drawing.Size objSize = new System.Drawing.Size(pPopUpWidth, pVisibleRows * 40);
          pGridLookUpEdit.Properties.PopupFormSize = objSize;
         

      }
      public static void getGridLookUpEdit(
          
          GridLookUpEdit pGridLookUpEdit, 
          string pDisplayMember, 
          string pValueMmber, 
          string pDisplayMemberforCaption, 
          string pValueMmberforCaption, 
          string pDisplay_MemberCaption, 
          string pValue_memberCaption, 
          DataSet pds, 
          string pValueMmberForSelection, 
          int pVisibleRows, 
          int pPopUpWidth, 
          int pValueMemberWidth, 
          String pColumnsForVisibility, 
          Boolean pIsMakeVisible, 
          Boolean pIsPerformVisibilityAndBestFit, 
          Boolean pIsShowFilterRow)
      {
          // combobox = new ComboBoxEdit();



          pGridLookUpEdit.Properties.DataSource = null;
          pGridLookUpEdit.Properties.DisplayMember = null;


          DataTable dt = new DataTable();

          if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(pds))
          {


              dt = pds.Tables[0];

              dt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
              dt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;

              pGridLookUpEdit.Refresh();


              pGridLookUpEdit.Properties.DataSource = dt;

              pGridLookUpEdit.Properties.DisplayMember = pDisplayMember;
              pGridLookUpEdit.Properties.ValueMember = pValueMmber;
              pGridLookUpEdit.Properties.PopulateViewColumns();
              //pGridLookUpEdit.EditValue = pGridLookUpEdit.Properties.GetKeyValue(0);
              pGridLookUpEdit.Properties.View.Columns[0].Width = pValueMemberWidth;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
              //pGridLookUpEdit.Properties.View. = 0;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.Font = new Font("Tahoma", 9, FontStyle.Regular);
              pGridLookUpEdit.Properties.View.OptionsView.ShowIndicator = false;

              try
              {
                  // pGridLookUpEdit.Text = dt.Rows[0][pDisplayMember].ToString();
                 // pGridLookUpEdit.EditValue = pGridLookUpEdit.Properties.GetKeyValue(0);   //dt.Rows[0][pValueMmber];



              }

              catch
              {

              }

          }

          pGridLookUpEdit.Properties.ReadOnly = false;
          pGridLookUpEdit.Properties.NullText = "";
          pGridLookUpEdit.Properties.View.BestFitMaxRowCount = pVisibleRows;
          pGridLookUpEdit.Properties.View.OptionsView.ShowAutoFilterRow = pIsShowFilterRow;
          System.Drawing.Size objSize = new System.Drawing.Size(pPopUpWidth, pVisibleRows * 40);
          pGridLookUpEdit.Properties.PopupFormSize = objSize;
          pGridLookUpEdit.Properties.PopupSizeable = false;
          pGridLookUpEdit.Properties.View.OptionsView.ShowViewCaption = false;

          String[] tmp_Columns = pColumnsForVisibility.Split(',');


          if (pIsPerformVisibilityAndBestFit)
          {

              foreach (GridColumn tmpColumn in pGridLookUpEdit.Properties.View.Columns)
              {
                  tmpColumn.Visible = !pIsMakeVisible;

                  foreach (String str in tmp_Columns)
                  {

                      if (tmpColumn.FieldName == str)
                          tmpColumn.Visible = pIsMakeVisible;
                  }

                  if (tmpColumn.FieldName != pValueMmber && tmpColumn.FieldName != pDisplayMember)
                  {
                      tmpColumn.BestFit();
                  }

              }

          }



      }


      private void GridLookUpEdit_CATEGORY_imageView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
      {
          if (ImageColumnName != "" && e.Column.FieldName == ImageColumnName)
          {
              try
              {

                  GridView GridView_temp = (GridView)sender;
          

                  string imageName = GridView_temp.GetRowCellValue(e.RowHandle, ImageColumnName).ToString();
                  //GridView.SetRowCellValue(e.RowHandle, "Image", GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_256X256.Images[imageName]);
                  GridView_temp.SetRowCellValue(e.RowHandle, "Image", GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_32X32.Images[imageName]);
                  GridView_temp.Columns["Image"].BestFit();
                  if (e.RowHandle +1 == GridView_temp.RowCount)
                  {
                      if (IsRemaveImageReferenceColumn)
                          GridView_temp.Columns[ImageColumnName].Visible = false;
                  }
              }
              catch (Exception ex)
              { 
              

              }

          }
      }
      bool IsRemaveImageReferenceColumn = false;
      string ImageColumnName = "";
       
      public void getGridLookUpEdit(GridLookUpEdit pGridLookUpEdit, string pDisplayMember, string pValueMmber, string pDisplayMemberforCaption, string pValueMmberforCaption, string pDisplay_MemberCaption, string pValue_memberCaption, DataSet pds, string pValueMmberForSelection, int pVisibleRows, int pPopUpWidth, int pValueMemberWidth, String pColumnsForVisibility, Boolean pIsMakeVisible, Boolean pIsPerformVisibilityAndBestFit, Boolean pIsShowFilterRow, bool pImageColumn, string pImageColumnName, bool pIsRemaveImageReferenceColumn)
      {
          // combobox = new ComboBoxEdit();


         // pGridLookUpEdit_tmp = pGridLookUpEdit;
          pGridLookUpEdit.Properties.DataSource = null;
          pGridLookUpEdit.Properties.DisplayMember = null;
          pGridLookUpEdit.Properties.View.Tag = pImageColumnName;
          IsRemaveImageReferenceColumn = pIsRemaveImageReferenceColumn;
          ImageColumnName = pImageColumnName;



          DataTable dt = new DataTable();

          if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTable(pds))
          {


              dt = pds.Tables[0];

              dt.Columns[pDisplayMemberforCaption].Caption = pDisplay_MemberCaption;
              dt.Columns[pValueMmberforCaption].Caption = pValue_memberCaption;
             
              pGridLookUpEdit.Refresh();

              if (pImageColumn)
                  dt.Columns.Add("Image", typeof(System.Object));
              pGridLookUpEdit.Properties.View.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(GridLookUpEdit_CATEGORY_imageView_CustomRowCellEdit); 
              pGridLookUpEdit.Properties.DataSource = dt;

              pGridLookUpEdit.Properties.DisplayMember = pDisplayMember;
              pGridLookUpEdit.Properties.ValueMember = pValueMmber;
              pGridLookUpEdit.Properties.PopulateViewColumns();
              pGridLookUpEdit.Properties.View.Columns[0].Width = pValueMemberWidth;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
              pGridLookUpEdit.Properties.View.OptionsView.RowAutoHeight = true;

              if (pImageColumn)
              {

                  RepositoryItemPictureEdit obj_RepositoryItemPictureEdit = new RepositoryItemPictureEdit();
                  pGridLookUpEdit.Properties.View.Columns["Image"].ColumnEdit = obj_RepositoryItemPictureEdit;
          
                 // if (isRemaveImageReferenceColumn)
                    //  pGridLookUpEdit.Properties.View.Columns[pImageColumnName].Visible = false;
              }

              //pGridLookUpEdit.Properties.View. = 0;
              pGridLookUpEdit.Properties.View.Columns[0].OptionsColumn.FixedWidth = true;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
              pGridLookUpEdit.Properties.View.Appearance.HeaderPanel.Font = new Font("Tahoma", 9, FontStyle.Regular);

              try
              {
                  // pGridLookUpEdit.Text = dt.Rows[0][pDisplayMember].ToString();
                  pGridLookUpEdit.EditValue = pGridLookUpEdit.Properties.GetKeyValue(0);   //dt.Rows[0][pValueMmber];



              }

              catch
              {

              }

          }

          pGridLookUpEdit.Properties.ReadOnly = false;
          pGridLookUpEdit.Properties.NullText = "";
          pGridLookUpEdit.Properties.View.BestFitMaxRowCount = pVisibleRows;
          pGridLookUpEdit.Properties.View.OptionsView.ShowAutoFilterRow = true;
          System.Drawing.Size objSize = new System.Drawing.Size(pPopUpWidth, pVisibleRows * 40);
          pGridLookUpEdit.Properties.PopupFormSize = objSize;



          String[] tmp_Columns = pColumnsForVisibility.Split(',');


          if (pIsPerformVisibilityAndBestFit)
          {

              foreach (GridColumn tmpColumn in pGridLookUpEdit.Properties.View.Columns)
              {
                  tmpColumn.Visible = !pIsMakeVisible;

                  foreach (String str in tmp_Columns)
                  {

                      if (tmpColumn.FieldName == str)
                          tmpColumn.Visible = pIsMakeVisible;
                  }

                  if (tmpColumn.FieldName != pValueMmber && tmpColumn.FieldName != pDisplayMember)
                  {
                      tmpColumn.BestFit();
                  }

              }

          }



      }
    
      
    }
}
