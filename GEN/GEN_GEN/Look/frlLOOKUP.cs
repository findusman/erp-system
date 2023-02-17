using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;

using DevExpress.XtraPrinting;
namespace GEN.GEN_GEN.Look
{
    public partial class frlLOOKUP : DevExpress.XtraEditors.XtraForm
    {

        public static int no_of_cols = 0;
        public static string value = string.Empty, ImageColumnName = "";
         
        private static DataTable dt = new DataTable();
        public static ImageCollection ImageListCollection = null;

        void changeImageSize()
        {

            GridView.Columns[ImageColumnName].Visible = true;

            if(ComboEdit_ImageSize.SelectedIndex == 0)
               ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_16X16;
            else if (ComboEdit_ImageSize.SelectedIndex == 1)
                ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_32X32;
            else if (ComboEdit_ImageSize.SelectedIndex == 2)
                ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_64X64;
            else if (ComboEdit_ImageSize.SelectedIndex == 3)
                ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_128X128;
            else if (ComboEdit_ImageSize.SelectedIndex == 4)
                ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_256X256;
            else if (ComboEdit_ImageSize.SelectedIndex == 5)
                ImageListCollection = GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_512X512;

           
           GridView.RefreshData();
            
        }
        bool IsRemaveImageReferenceColumn = false;
        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly, string columns_width, int focused_column, string Disabled_Columns_Indexes, string filter_string , bool pImageColumn , string pImageColumnName , bool pIsRemaveImageReferenceColumn )
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                ImageColumnName = pImageColumnName;
                IsRemaveImageReferenceColumn = pIsRemaveImageReferenceColumn;
                if (pImageColumn)
                    dt.Columns.Add("Image", typeof(System.Object));

                GridView.OptionsBehavior.Editable = true;
                GridView.OptionsBehavior.ReadOnly = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();


                if (pImageColumn)
                {
                    ComboEdit_ImageSize.Visible = true;
                    Label_ImageSize.Visible = true;
                    addImageFunctionality();
                   
                }
                //GridView.BestFitColumns();

                
                no_of_cols = colo_to_get;

                Grid.ShowOnlyPredefinedDetails = ReadOnly;

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, columns_width);
                if (Disabled_Columns_Indexes!="")
                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.makeColumnsInvisible(GridView, Disabled_Columns_Indexes);

                GridView.FocusedColumn = GridView.Columns[focused_column];

                lb_records.Text = ds.Tables[0].Rows.Count.ToString();

                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;

                if (filter_string != "")
                GridView.ActiveFilterString = filter_string;
                GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;

               
            }
            catch (Exception ex)
            {

            }


        }

        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly, string columns_width, int focused_column, string Disabled_Columns_Indexes , string filter_string)
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();

                no_of_cols = colo_to_get;

                Grid.ShowOnlyPredefinedDetails = ReadOnly;

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, columns_width);
                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.makeColumnsInvisible(GridView, Disabled_Columns_Indexes);

                GridView.FocusedColumn = GridView.Columns[focused_column];

                lb_records.Text = ds.Tables[0].Rows.Count.ToString();

                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;
                if (filter_string != "")
                GridView.ActiveFilterString = filter_string;
                GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            }
            catch (Exception ex)
            {

            }


        }


        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly, string columns_width, int focused_column,string Disabled_Columns_Indexes)
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();

                no_of_cols = colo_to_get;

                Grid.ShowOnlyPredefinedDetails = ReadOnly;

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, columns_width);
                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.makeColumnsInvisible(GridView, Disabled_Columns_Indexes);

                GridView.FocusedColumn = GridView.Columns[focused_column];

                lb_records.Text = ds.Tables[0].Rows.Count.ToString();
                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;


            }
            catch (Exception ex)
            {

            }


        }

        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly, string columns_width , int focused_column)
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();

                no_of_cols = colo_to_get;

                Grid.ShowOnlyPredefinedDetails = ReadOnly;

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, columns_width);
               
                GridView.FocusedColumn = GridView.Columns[focused_column];
                lb_records.Text = ds.Tables[0].Rows.Count.ToString();
                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;

            }

            catch (Exception ex)
            {

            }


        }


        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly, string columns_width)
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();

                no_of_cols = colo_to_get;
                Grid.ShowOnlyPredefinedDetails = ReadOnly;



                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, columns_width);
                lb_records.Text = ds.Tables[0].Rows.Count.ToString();
                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;


            }
            catch (Exception ex)
            {

            }


        }

        public frlLOOKUP(DataSet ds, int colo_to_get, Boolean ReadOnly)
        {


            try
            {
                InitializeComponent();

                value = "";

                dt = ds.Tables[0];
                GridView.OptionsBehavior.Editable = false;
                Grid.DataSource = dt;
                GridView.PopulateColumns();

                no_of_cols = colo_to_get;
                Grid.ShowOnlyPredefinedDetails = ReadOnly;
                lb_records.Text = ds.Tables[0].Rows.Count.ToString();
                this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;

            }
            catch (Exception ex)
            {

            }


        }


        void addImageFunctionality()
        {
            RepositoryItemPictureEdit obj_RepositoryItemPictureEdit = new RepositoryItemPictureEdit();
            GridView.Columns["Image"].ColumnEdit = obj_RepositoryItemPictureEdit;
            changeImageSize();
        }


       private void frlLOOKUP_Load(object sender, EventArgs e)
        {
           // cls_generic_Functions.Show_tooltip(this, e);

            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(;          
         //  cls_generic_Functions.GRID_VIEW_APPEARANCE(GridView, "L");
          //  GridView.GridControl.IsSplitGrid = true;
          //  Grid.IsSplitGrid = true;
          //  Grid.CreateSplitContainer();
          // Grid.sh


         //   gridSplitContainer1.IsSplitViewVisible = true;
           GEN.GEN_GEN.GenericClasses.Grid.cls_GridAppearance.setAppearance(GridView, "L");
           checkEdit1_CheckedChanged( sender,  e);
         
       }

        private void memoUSER_DESCRIPTION_EditValueChanged(object sender, EventArgs e)
        {
            if (check_search.Checked)
            {

                string columnname = string.Empty;
                string expresion = "";
                if (memosearch.Text == "")
                {

                    dt.DefaultView.RowFilter = null;


                }
                else
                {

                   // string c = GridView


                    string new_columnname = GridView.FocusedColumn.GetCaption();
                   // columnname = columnname.Substring(3);


                     columnname = "[" + new_columnname + "]";

                    //if ((dt.Columns[columnname].DataType.ToString() == "System.Int32") || (dt.Columns[columnname].DataType.ToString() == "System.Double"))
                    //{

                    //    expresion = columnname + " = " + memosearch.Text + "";
                    //    dt.DefaultView.RowFilter = expresion;
                    //}

                    //else 

                     try
                     {
                         string value = memosearch.Text;
                          string main_value = "";
                     for (int x = 0; x < memosearch.Text.Length; x++)
                     {

                         if (value[x].ToString() == "'")
                         {

                             main_value = main_value + "'" + value[x].ToString();
                         }
                         else
                             if (value[x].ToString() == "%" || value[x].ToString() == "[" || value[x].ToString() == "_" || value[x].ToString() == "*")
                         {

                             main_value = main_value + "[" + value[x].ToString() + "]";
                         }
                         else
                         {
                             main_value = main_value + value[x].ToString();
                     
                         }
                     }


                         if (dt.Columns[new_columnname].DataType.ToString() == "System.String")
                         {
                             if (check_adv_str.Checked)
                             {

                                 expresion =    columnname + "  like  '%"  + main_value + "%'";
                                 dt.DefaultView.RowFilter = expresion;

                             }
                             else
                             {
                                 expresion = columnname + " like  '"  + main_value + "%'";
                                 dt.DefaultView.RowFilter = expresion;
                             }

                         }
                     }
                     catch (Exception ex)
                     { 
                     
                     }
                }


            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {




        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    int x = e.RowHandle;
        //    value = "";
        //    for (int y = 0; y < no_of_cols; y++)
        //    {

        //        value = value + dt.Rows[x][y].ToString() + "|";

        //    }

        //   this.Close();
        //}



        private void GridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //if (!check_search.Checked)
            //{

            //    int x = e.RowHandle;

            //    DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
            //    view = GridView;

            //    //   string str =   view.GetRowCellValue(x,).ToString();




            //    value = "";


            //    for (int y = 0; y < no_of_cols; y++)
            //    {

            //        value = value + view.GetRowCellValue(x, dt.Columns[y].Caption.ToString()) + "|";//Rows[x][y].ToString()).ToString() + "|";

            //        //  value = value + dt.Rows[x][y].ToString() + "|";

            //    }

            //    this.Close();
            //}
        }

        private void GridView_DoubleClick_1(object sender, EventArgs e)
        {

            int x = GridView.FocusedRowHandle;

            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
            view = GridView;
            value = "";

            for (int y = 0; y < dt.Columns.Count; y++)
            {
                value = value + view.GetRowCellValue(x, dt.Columns[y].Caption.ToString()) + "|";             
            }

            this.Close();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frlLOOKUP_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.Control) //&& e.Modifiers == Keys.Control)
            {
                this.Close();
            }
            else  if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)

            {

                if (check_search.Checked)
                {

                    check_search.Checked = false;


                }
                else
                {


                    check_search.Checked = true;
                }
            

            }

            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                if (check_adv_str.Checked)
                {

                    check_adv_str.Checked = false;


                }
                else
                {


                    check_adv_str.Checked = true;
                }


            }

        }

        private void frlLOOKUP_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if ((e.KeyChar != Keys.Escape) && (e.KeyChar == Keys.S))
            //{
            //    this.Close();

            //}


            //if (e.KeyChar == Keys.Escape)
            //{


            //    this.Close();
            
            //}

            ////    if (check_search.Checked)
            //    {

            //        check_search.Checked = false;


            //    }
            //    else
            //    {


            //        check_search.Checked = true;
            //    }


            //}
        }

        private void frlLOOKUP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {

            //int ss = (int)e.KeyData;

            //if (ss > 32 && ss < 255)
            //{
            //    if (ss > 47 && ss < 57)
            //    {
            //        memosearch.Text = memosearch.Text + (ss - 48).ToString();
            //    }
            //    else
            //    {
            //        if (e.KeyCode.ToString().Length < 2)
            //        {

            //            memosearch.Text = memosearch.Text + e.KeyCode.ToString();
            //        }
            //    }
            //}
            //if (ss == 32 )
            //{

            //    memosearch.Text = memosearch.Text +  " ";

            //}
            //if (ss == 8)
            //{

            //    memosearch.Text = memosearch.Text.Substring(0, memosearch.Text.Length - 1);

            //}



            if (e.KeyCode == Keys.Escape)
            {

                memosearch.Focus();
            
            }

            if (e.KeyCode == Keys.Enter)
            {

                int x = GridView.FocusedRowHandle;

                DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView();
                view = GridView;
                value = "";

                for (int y = 0; y < no_of_cols; y++)
                {
                    value = value + view.GetRowCellValue(x, dt.Columns[y].Caption.ToString()) + "|";
                }

                this.Close();
            
            }
        }

        private void memosearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Grid.Focus();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < GridView.Columns.Count; x++)
            {


                textEdit1.Text = textEdit1.Text + GridView.Columns[x].Width.ToString() + ",";


            }




        }

        private void GridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ss = (int)e.KeyChar;

            if (ss > 32 && ss < 255)
            {
                if (ss > 47 && ss < 57)
                {
                    memosearch.Text = memosearch.Text + (ss - 48).ToString();
                }
                else
                {
                    if (e.KeyChar.ToString().Length < 2)
                    {

                        memosearch.Text = memosearch.Text + e.KeyChar.ToString();
                    }
                }
            }
            if (ss == 32)
            {

                memosearch.Text = memosearch.Text + " ";

            }
            if (ss == 8)
            {
                if (memosearch.Text.Length > 0)
                {
                    memosearch.Text = memosearch.Text.Substring(0, memosearch.Text.Length - 1);
                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            Boolean c = Grid.IsPrintingAvailable;

          Grid.ShowPrintPreview();


         //   printableComponentLink1.ShowPreview();

           // Grid.Print();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();


            //LOOK_UP.Export_data obj = new LOOK_UP.Export_data(Grid);
            //obj.ShowDialog();
            

//            Grid.expoExportToXlsx(@"D:\usman.xlsx");


        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            //RadioGroup_splittion.Enabled = checkEdit1.Checked;
            //if (checkEdit1.Checked)
            //{


                //GridSplitContainer_Main.ShowSplitView();

                //if (RadioGroup_splittion.SelectedIndex == 0)
                //{
                //    GridSplitContainer_Main.Horizontal = true;
                //}
                //else 
                //{

                //    GridSplitContainer_Main.Horizontal = false;

                //}
            
            //}
            //else
            //{


            //    GridSplitContainer_Main.HideSplitView();

              

            //}




        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEdit1_CheckedChanged( sender,  e);
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            GridView.OptionsView.AllowCellMerge = checkEdit2.Checked;
        }

        private void GridView_RowCountChanged(object sender, EventArgs e)
        {
            lb_records.Text = GridView.RowCount.ToString();
            this.Text = this.Tag + " ..::.. Total Records : " + lb_records.Text;

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.setColumnsWidth(GridView, textEdit1.Text);
            }
            catch (Exception ex)
            { 
            
            }
         }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckEdit_showAutoRowFilter_CheckedChanged(object sender, EventArgs e)
        {
            GridView.OptionsView.ShowAutoFilterRow = CheckEdit_showAutoRowFilter.Checked;
     
        }

        private void CheckEdit_showRowFooter_CheckedChanged(object sender, EventArgs e)
        {
            GridView.OptionsView.ShowFooter = CheckEdit_showRowFooter.Checked;
   
        }

        private void CheckEdit_showFindPanel_CheckedChanged(object sender, EventArgs e)
        {
            GridView.OptionsFind.AlwaysVisible = CheckEdit_showFindPanel.Checked;
   
        }

        private void CheckEdit_showGroupPanel_CheckedChanged(object sender, EventArgs e)
        {
            GridView.OptionsView.ShowGroupPanel = CheckEdit_showGroupPanel.Checked;
   
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Export_data obj_Export_data = new Export_data(Grid);
            obj_Export_data.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Grid.ShowPrintPreview();
        }

        private void Grid_Click(object sender, EventArgs e)
        {

        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            
            

        }

        private void GridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            try
            {
                if (ImageColumnName != "" && e.Column.FieldName == ImageColumnName)
                {
                    string imageName = GridView.GetRowCellValue(e.RowHandle, ImageColumnName).ToString();
                    //GridView.SetRowCellValue(e.RowHandle, "Image", GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_256X256.Images[imageName]);
                    GridView.SetRowCellValue(e.RowHandle, "Image", ImageListCollection.Images[imageName]);
                    GridView.Columns["Image"].BestFit();

                    if (e.RowHandle == dt.Rows.Count-1)
                    {
                        if (IsRemaveImageReferenceColumn)
                            GridView.Columns[ImageColumnName].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void ComboEdit_ImageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeImageSize();
        }

        private void GridView_AsyncCompleted(object sender, EventArgs e)
        {
            if (IsRemaveImageReferenceColumn)
                GridView.Columns[ImageColumnName].Visible = false;
        }

        private void GridView_GotFocus(object sender, EventArgs e)
        {
            if (IsRemaveImageReferenceColumn)
                GridView.Columns[ImageColumnName].Visible = false;
        }

       
    }
}