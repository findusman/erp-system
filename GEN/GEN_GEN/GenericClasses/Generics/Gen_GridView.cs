using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors;
using Gen_GridViewSub;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System.Data;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;



#region MAin Namespace Use For Calling
namespace GEN
{




    public class Gen_GridView
    {



        #region all Objects Variables.

        internal  enum GRIDTYPE
        {
            GridView,
            Banded,
            PivotTable,
            AdvBanded,
            TreeList
        };

        

        //views
       public DevExpress.XtraGrid.Views.Grid.GridView  Grid_View = new GridView();
       public DevExpress.XtraGrid.Views.BandedGrid.BandedGridView ObjBandedView = new BandedGridView();
       public DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView ObjAdvBandedView = new AdvBandedGridView();
       public DevExpress.XtraPivotGrid.PivotGridControl ObjPivotGrid = new PivotGridControl();
       public DevExpress.XtraTreeList.TreeList ObjTreelist = new TreeList();



        DevExpress.XtraGrid.GridControl Grid_Control =  new DevExpress.XtraGrid.GridControl();


        public readonly GRIDTYPE value;
        public bool isAllowDeleteColumns = true;

        Gen_Apperance objApp = new Gen_Apperance();
        Gen_ShortKeys objShk = new Gen_ShortKeys();
        Gen_Formating objFrt = new Gen_Formating();


        #endregion


        #region Helping Functions

        //Check foe ObjectRefrence

        public static void ChkObject(Object obj)
        {

            if (Object.ReferenceEquals(null,obj))
            {
                XtraMessageBox.Show("Object Refrence Error! in " +  obj.GetType());
            }

        }

        #endregion


        #region Allconstructors



        public  Gen_GridView(DevExpress.XtraGrid.Views.Grid.GridView PGrid_View, DevExpress.XtraGrid.GridControl PGrid_Control)
        {


            value = GRIDTYPE.GridView;
            Grid_View = PGrid_View;
            Grid_Control = PGrid_Control;

        }


       
        public Gen_GridView(DevExpress.XtraGrid.GridControl PGrid_Control)
        {


            try
            {




            
            Grid_Control = PGrid_Control;
            if (typeof(BandedGridView) == PGrid_Control.MainView.GetType())
            {
                value = GRIDTYPE.Banded;
                ObjBandedView = (BandedGridView)PGrid_Control.MainView;
            }
            else if (typeof(AdvBandedGridView) == PGrid_Control.MainView.GetType())
            {
                value = GRIDTYPE.AdvBanded;
                ObjAdvBandedView = (AdvBandedGridView)PGrid_Control.MainView;
            }
            else if (typeof(GridView) == PGrid_Control.MainView.GetType())
            {
                value = GRIDTYPE.GridView;
                Grid_View = (GridView)PGrid_Control.MainView;
            }
            }
            catch 
            {
                

                XtraMessageBox.Show("Error in View!");
            }
        }


      
        public Gen_GridView(DevExpress.XtraTreeList.TreeList PTreeList)
        {
                value = GRIDTYPE.TreeList;
                ObjTreelist = PTreeList;

        }



        private Gen_GridView(DevExpress.XtraPivotGrid.PivotGridControl Pivot)
        {


            value = GRIDTYPE.PivotTable;
            ObjPivotGrid = Pivot;

        }



        #endregion





        #region GridviewDeletion

        private void FAdddeletion()
        {
          

            if (value == GRIDTYPE.GridView)
            {
                
            }

            GridColumn tmpColumn = new GridColumn();
          
            tmpColumn.FieldName = "D";
            tmpColumn.Caption = "";
            tmpColumn.OptionsColumn.FixedWidth = true;
            tmpColumn.Width = 10;

            if (!Grid_View.Columns.Contains(tmpColumn))
                Grid_View.Columns.Add(tmpColumn);
            tmpColumn.Visible = true;


            //gridControl2.ForceInitialize();

            RepositoryItemButtonEdit btn = new RepositoryItemButtonEdit();
            //btn.Buttons[0].Caption = "X";

            btn.Buttons[0].Kind = ButtonPredefines.Glyph;
            btn.TextEditStyle = TextEditStyles.HideTextEditor;

            btn.ButtonClick += new ButtonPressedEventHandler(Del_Btn_Click);
            btn.Buttons[0].Image = Image.FromFile(Environment.CurrentDirectory + "\\del.png");
            btn.Buttons[0].ImageLocation = ImageLocation.MiddleCenter;
            Grid_View.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            Grid_View.Columns.ColumnByFieldName("D").ColumnEdit = btn;


        }


        private void Del_Btn_Click(object sender, EventArgs e)
        {


            try
            {

                
                DataView tCxC = (DataView)Grid_View.DataSource;
                tCxC.Table.Rows.RemoveAt(Grid_View.FocusedRowHandle);
                
            }
            catch
            { }
            
        }


        #endregion

        #region BandedDeletion

        private void FAdddeletionBanded()
        {


          

            GridColumn tmpColumn = new GridColumn();
            
            tmpColumn.FieldName = "D";
            tmpColumn.Caption = "";
            tmpColumn.OptionsColumn.FixedWidth = true;
            tmpColumn.Width = 10;

            if (!ObjBandedView.Columns.Contains(tmpColumn))
                ObjBandedView.Columns.Add(tmpColumn);
            tmpColumn.Visible = true;


            //gridControl2.ForceInitialize();

            RepositoryItemButtonEdit btn = new RepositoryItemButtonEdit();
            //btn.Buttons[0].Caption = "X";

            btn.Buttons[0].Kind = ButtonPredefines.Glyph;
            btn.TextEditStyle = TextEditStyles.HideTextEditor;

            btn.ButtonClick += new ButtonPressedEventHandler(Del_Btn_ClickBanded);
            btn.Buttons[0].Image = Image.FromFile(Environment.CurrentDirectory + "\\del.png");
            btn.Buttons[0].ImageLocation = ImageLocation.MiddleCenter;
            ObjBandedView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            ObjBandedView.Columns.ColumnByFieldName("D").ColumnEdit = btn;


        }


        private void Del_Btn_ClickBanded(object sender, EventArgs e)
        {


            try
            {


                DataView tCxC = (DataView)ObjBandedView.DataSource;
                tCxC.Table.Rows.RemoveAt(ObjBandedView.FocusedRowHandle);

            }
            catch
            { }

        }


        #endregion
        #region AdvBAndedtDeletion

        private void FAdddeletionAdvBanded()
        {


            

            GridColumn tmpColumn = new GridColumn();

            tmpColumn.FieldName = "D";
            tmpColumn.Caption = "";
            tmpColumn.OptionsColumn.FixedWidth = true;
            tmpColumn.Width = 10;

            if (!ObjAdvBandedView.Columns.Contains(tmpColumn))
                ObjAdvBandedView.Columns.Add(tmpColumn);
            tmpColumn.Visible = true;


            //gridControl2.ForceInitialize();

            RepositoryItemButtonEdit btn = new RepositoryItemButtonEdit();
            //btn.Buttons[0].Caption = "X";

            btn.Buttons[0].Kind = ButtonPredefines.Glyph;
            btn.TextEditStyle = TextEditStyles.HideTextEditor;

            btn.ButtonClick += new ButtonPressedEventHandler(Del_Btn_ClickAdvBanded);
            btn.Buttons[0].Image = Image.FromFile(Environment.CurrentDirectory + "\\del.png");
            btn.Buttons[0].ImageLocation = ImageLocation.MiddleCenter;
            ObjAdvBandedView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            ObjAdvBandedView.Columns.ColumnByFieldName("D").ColumnEdit = btn;


        }

        private void Del_Btn_ClickAdvBanded(object sender, EventArgs e)
        {


            try
            {


                DataView tCxC = (DataView)ObjAdvBandedView.DataSource;
                tCxC.Table.Rows.RemoveAt(ObjAdvBandedView.FocusedRowHandle);

            }
            catch
            { }

        }



        #endregion
        #region TreelistDeletion


        private void FAdddeletionTreeList()
        {




            DevExpress.XtraTreeList.Columns.TreeListColumn tmpColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();

            tmpColumn.FieldName = "D";
            tmpColumn.Caption = "";
            tmpColumn.OptionsColumn.FixedWidth = true;
            tmpColumn.Width = 10;

            if (!ObjTreelist.VisibleColumns.Contains(tmpColumn))
            {
                TreeListColumn col = ObjTreelist.Columns.AddField(tmpColumn.Name);

                col.VisibleIndex = ObjTreelist.Columns.Count;
            }






            tmpColumn.Visible = true;


            //gridControl2.ForceInitialize();

            RepositoryItemButtonEdit btn = new RepositoryItemButtonEdit();
            //btn.Buttons[0].Caption = "X";

            btn.Buttons[0].Kind = ButtonPredefines.Glyph;
            btn.TextEditStyle = TextEditStyles.HideTextEditor;

            btn.ButtonClick += new ButtonPressedEventHandler(Del_Btn_ClickTreeList);
            btn.Buttons[0].Image = Image.FromFile(Environment.CurrentDirectory + "\\del.png");
            btn.Buttons[0].ImageLocation = ImageLocation.MiddleCenter;
            ObjTreelist.ShowButtonMode = ShowButtonModeEnum.ShowAlways;

            ObjTreelist.Columns.ColumnByFieldName("D").ColumnEdit = btn;


        }




        private void Del_Btn_ClickTreeList(object sender, EventArgs e)
        {


            try
            {


                DataView tCxC = (DataView)ObjTreelist.DataSource;
                tCxC.Table.Rows.RemoveAt(ObjTreelist.FocusedNode.Id);

            }
            catch
            { }

        }



        #endregion

















        #region Apperance function calling

        public void Apperance(String Type)
        {
            try
            {

                if (value == GRIDTYPE.GridView)
                {
                    objApp.SetGridAppearance(Grid_View, Type);
                }

                else if (value == GRIDTYPE.AdvBanded)
                {

                    objApp.AdvBandedAppearance(ObjAdvBandedView, Type);
                }

                else if (value == GRIDTYPE.Banded)
                {

                    objApp.BandedAppearance(ObjBandedView, Type);
                }

                else if (value == GRIDTYPE.PivotTable)
                {

                    // objApp.PivotAppearance(ObjPivotGrid, Type);
                }

                else if (value == GRIDTYPE.TreeList)
                {

                    objApp.TreeAppearance(ObjTreelist, Type);
                }
            }
            catch
            {


            }

        }

#endregion

        #region Formating function calling


        public  void Formatting()
        {

try
            {
   
       objFrt.gridview = Grid_View;
       objFrt.Bangridview =  ObjBandedView;
       objFrt.Advgridview =  ObjAdvBandedView;
   
    
    if (isAllowDeleteColumns)
        if (value == GRIDTYPE.GridView)
        {
            FAdddeletion();
        }
        else if (value == GRIDTYPE.Banded)
        {
            FAdddeletionBanded();
        }
        else if (value == GRIDTYPE.AdvBanded)
        {
            FAdddeletionAdvBanded();
        }

        else if (value == GRIDTYPE.TreeList)
        {
            FAdddeletionTreeList();
        }


    objFrt.SetGridFormat(value) ;
    
                

            }
            catch
            {

              
            }


        }

        #endregion


        #region ShorcutKey Function Calling
        public void ShortKey(KeyEventArgs e)
        {


            try
            {

                if (value == GRIDTYPE.GridView)
                {
                    objShk.SetGridShortkey(Grid_View, e);
                }

                else if (value == GRIDTYPE.AdvBanded)
                {

                    objShk.AdvBanedeGridShortkey(ObjAdvBandedView, e);
                }

                else if (value == GRIDTYPE.Banded)
                {

                    objShk.BanedeGridShortkey(ObjBandedView, e);
                }

                else if (value == GRIDTYPE.TreeList)
                {

                    objShk.TreeListShortkey(ObjTreelist, e);
                }
                


            }
           

         
            catch
            {

                throw;
            }


        }

        #endregion


    }


}




#endregion






#region NameSapve GRidViewSub.  Contain  Apperance / Shorcut/Formating


namespace Gen_GridViewSub
 {




     #region Class Formatiing

     internal class Gen_Formating
    {




     
         public GridView gridview;
         public BandedGridView Bangridview;
         public AdvBandedGridView Advgridview;
         public TreeList TreeView;

         string[] ArrTags = new string[4];



         String N1 = "#.0";
         String N2 = "#.00";
         String N3 = "#.000";
         String N4 = "#.0000";
         String N5 = "#.00000";


         String SA = "Avg: {0:n2}";
         String SS = "Sum: {0:n2}";
         String ST = "Total Rows: {0}";

         String D3 = "yyyy/MM/dd";
         String D2 = "yyyy/dd/MM";
         String D4 = "dd/MM/yyyy";
         String D1 = "MM/dd/yyyy";
         String D5 = "yyyy/MM/dd HH:mm:ss";







         private void gridView_InvalidRowException(object sender,DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
         {
             //Suppress displaying the error message box
             e.ExceptionMode = ExceptionMode.NoAction;
         }


         private void TreeView_InvalidNodeException(object sender, DevExpress.XtraTreeList.InvalidNodeExceptionEventArgs e)
         {
             //Suppress displaying the error message box
             e.ExceptionMode = ExceptionMode.NoAction;
         }



         void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
         {
             try
             {

           
             for (int x = 0; x < gridview.Columns.Count; x++)
             {


                 if (object.ReferenceEquals(null, gridview.Columns[x].Tag))
                 {
                     continue;
                 }



                 ArrTags = gridview.Columns[x].Tag.ToString().Split('|');

                 if (ArrTags == null)
                 {
                     continue;
                 }

                 if (ArrTags[0] == "D")
                 {

                     GridColumn ColToValid = gridview.Columns[x];
                     GridView view = sender as GridView;
                     DataView currentDataView = (sender as GridView).DataSource as DataView;
                     if (view.FocusedColumn == ColToValid)
                     {
                         //check duplicate code
                         string currentCode = e.Value.ToString();
                         for (int i = 0; i < currentDataView.Count; i++)
                         {
                             if (i != view.GetDataSourceRowIndex(view.FocusedRowHandle))
                             {
                                 if (currentDataView[i][ColToValid.FieldName].ToString() == currentCode)
                                 {
                                     e.ErrorText = "Duplicate Data Not Allowed!";
                                     e.Valid = false;
                                     break;
                                 }
                                
                             }

                             else
                             {

                                 e.Valid = true;
                             }
                         }
                     }
                 }


             }

             }
             catch 
             {

                 
             }
         }




         void BangridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
         {
             try
             {


                 for (int x = 0; x < Bangridview.Columns.Count; x++)
                 {


                     if (object.ReferenceEquals(null, Bangridview.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = Bangridview.Columns[x].Tag.ToString().Split('|');

                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "D")
                     {

                         GridColumn ColToValid = Bangridview.Columns[x];
                         BandedGridView view = sender as BandedGridView;
                         DataView currentDataView = (sender as BandedGridView).DataSource as DataView;
                         if (view.FocusedColumn == ColToValid)
                         {
                             //check duplicate code
                             string currentCode = e.Value.ToString();
                             for (int i = 0; i < currentDataView.Count; i++)
                             {
                                 if (i != view.GetDataSourceRowIndex(view.FocusedRowHandle))
                                 {
                                     if (currentDataView[i][ColToValid.FieldName].ToString() == currentCode)
                                     {
                                         e.ErrorText = "Duplicate Data Not Allowed!";
                                         e.Valid = false;
                                         break;
                                     }

                                 }

                                 else
                                 {

                                     e.Valid = true;
                                 }
                             }
                         }
                     }


                 }

             }
             catch
             {


             }
         }


         void AdvBangridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
         {
             try
             {


                 for (int x = 0; x < Advgridview.Columns.Count; x++)
                 {


                     if (object.ReferenceEquals(null, Advgridview.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = Advgridview.Columns[x].Tag.ToString().Split('|');

                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "D")
                     {

                         GridColumn ColToValid = Advgridview.Columns[x];
                         AdvBandedGridView view = sender as AdvBandedGridView;
                         DataView currentDataView = (sender as AdvBandedGridView).DataSource as DataView;
                         if (view.FocusedColumn == ColToValid)
                         {
                             //check duplicate code
                             string currentCode = e.Value.ToString();
                             for (int i = 0; i < currentDataView.Count; i++)
                             {
                                 if (i != view.GetDataSourceRowIndex(view.FocusedRowHandle))
                                 {
                                     if (currentDataView[i][ColToValid.FieldName].ToString() == currentCode)
                                     {
                                         e.ErrorText = "Duplicate Data Not Allowed!";
                                         e.Valid = false;
                                         break;
                                     }

                                 }

                                 else
                                 {

                                     e.Valid = true;
                                 }
                             }
                         }
                     }


                 }

             }
             catch
             {


             }
         }





         void TreeView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
         {
             try
             {


                 for (int x = 0; x < TreeView.Columns.Count; x++)
                 {


                     if (object.ReferenceEquals(null, TreeView.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = TreeView.Columns[x].Tag.ToString().Split('|');

                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "D")
                     {
                         
                         TreeListColumn ColToValid = TreeView.Columns[x];
                         TreeList view = sender as TreeList;
                         DataView currentDataView = (sender as TreeList).DataSource as DataView;
                         if (view.FocusedColumn == ColToValid)
                         {
                             //check duplicate code
                             string currentCode = e.Value.ToString();
                             for (int i = 0; i < currentDataView.Count; i++)
                             {
                                 if (i != view.GetNodeIndex(view.FocusedNode))
                                 {
                                     if (currentDataView[i][ColToValid.FieldName].ToString() == currentCode)
                                     {
                                         e.ErrorText = "Duplicate Data Not Allowed!";
                                         e.Valid = false;
                                         break;
                                     }

                                 }

                                 else
                                 {

                                     e.Valid = true;
                                 }
                             }
                         }
                     }


                 }

             }
             catch
             {


             }
         }





         private void gridView_Validate(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
         {

             try
             {

           

             for (int x = 0; x < gridview.Columns.Count; x++)
             {

                 if (object.ReferenceEquals(null, gridview.Columns[x].Tag))
                 {
                     continue;
                 }
                 
                

                 ArrTags = gridview.Columns[x].Tag.ToString().Split('|');


                 if (ArrTags == null)
                 {
                     continue;
                 }

                 if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                 {
                     return;

                 }


                 if (ArrTags[2] == "Y")
                 {

                     GridColumn ColToValid = gridview.Columns[x];

                     if (gridview.GetRowCellValue(gridview.FocusedRowHandle, ColToValid).ToString() == string.Empty)
                     {

                         e.Valid = false;
                         //gridview.SetColumnError(ColToValid, "Null Value Not Allowed");
                         e.ErrorText  = "Null Value Not Allowed";
                         break;

                     }
                     else
                     {
                         e.Valid = true;
                        
                     }

                 }
             }


             }
             catch
             {

               
             }
         }





         private void BangridView_Validate(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
         {

             try
             {



                 for (int x = 0; x < Bangridview.Columns.Count; x++)
                 {

                     if (object.ReferenceEquals(null, Bangridview.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = Bangridview.Columns[x].Tag.ToString().Split('|');


                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                     {
                         return;

                     }


                     if (ArrTags[2] == "Y")
                     {

                         GridColumn ColToValid = Bangridview.Columns[x];

                         if (Bangridview.GetRowCellValue(Bangridview.FocusedRowHandle, ColToValid).ToString() == string.Empty)
                         {

                             e.Valid = false;
                             //gridview.SetColumnError(ColToValid, "Null Value Not Allowed");
                             e.ErrorText = "Null Value Not Allowed";
                             break;

                         }
                         else
                         {
                             e.Valid = true;

                         }

                     }
                 }


             }
             catch
             {


             }
         }



         private void AdvBangridView_Validate(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
         {

             try
             {



                 for (int x = 0; x < Advgridview.Columns.Count; x++)
                 {

                     if (object.ReferenceEquals(null, Advgridview.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = Advgridview.Columns[x].Tag.ToString().Split('|');


                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                     {
                         return;

                     }


                     if (ArrTags[2] == "Y")
                     {

                         GridColumn ColToValid = Advgridview.Columns[x];

                         if (Advgridview.GetRowCellValue(Advgridview.FocusedRowHandle, ColToValid).ToString() == string.Empty)
                         {

                             e.Valid = false;
                             //gridview.SetColumnError(ColToValid, "Null Value Not Allowed");
                             e.ErrorText = "Null Value Not Allowed";
                             break;

                         }
                         else
                         {
                             e.Valid = true;

                         }

                     }
                 }


             }
             catch
             {


             }
         }



         private void TreeView_Validate(object sender, DevExpress.XtraTreeList.ValidateNodeEventArgs e)
         {

             try
             {



                 for (int x = 0; x < TreeView.Columns.Count; x++)
                 {

                     if (object.ReferenceEquals(null, TreeView.Columns[x].Tag))
                     {
                         continue;
                     }



                     ArrTags = TreeView.Columns[x].Tag.ToString().Split('|');


                     if (ArrTags == null)
                     {
                         continue;
                     }

                     if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                     {
                         return;

                     }


                     if (ArrTags[2] == "Y")
                     {

                         TreeListColumn ColToValid = TreeView.Columns[x];
                       

                         if (TreeView.FocusedNode.GetValue(ColToValid).ToString() == string.Empty)
                         {

                             e.Valid = false;
                             //gridview.SetColumnError(ColToValid, "Null Value Not Allowed");
                             e.ErrorText = "Null Value Not Allowed";
                             break;

                         }
                         else
                         {
                             e.Valid = true;

                         }

                     }
                 }


             }
             catch
             {


             }
         }







         public void SetGridFormat(GEN.Gen_GridView.GRIDTYPE GridType)
        {




            
           

            try 
            {      
		
	
        
            Array.Clear(ArrTags, 0, ArrTags.Length);



            if (GridType == GEN.Gen_GridView.GRIDTYPE.GridView)
            {
                gridview.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gridView_Validate);
                gridview.ValidatingEditor += new BaseContainerValidateEditorEventHandler(gridView1_ValidatingEditor);
                gridview.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(gridView_InvalidRowException);

                for (int x = 0; x < gridview.Columns.Count - 1; x++)
                {



                    try
                    {


                        if (!object.ReferenceEquals(null, gridview.Columns[x].Tag))
                        {

                            ArrTags = gridview.Columns[x].Tag.ToString().Split('|');
                        }
                        else
                        {
                            continue;
                        }




                    }
                    catch
                    {

                        Array.Clear(ArrTags, 0, ArrTags.Length);
                        continue;

                    }



                    if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                    {
                        continue;

                    }






                    //Dates
                    if (ArrTags[0] == "D1")
                    {

                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        gridview.Columns[x].DisplayFormat.FormatString = D1;

                    }

                    else if (ArrTags[0] == "D2")
                    {

                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        gridview.Columns[x].DisplayFormat.FormatString = D2;

                    }

                    else if (ArrTags[0] == "D3")
                    {

                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        gridview.Columns[x].DisplayFormat.FormatString = D3;

                    }

                    else if (ArrTags[0] == "D4")
                    {

                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        gridview.Columns[x].DisplayFormat.FormatString = D4;

                    }

                    else if (ArrTags[0] == "D5")
                    {

                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        gridview.Columns[x].DisplayFormat.FormatString = D5;

                    }





                    ///Numerics
                    if (ArrTags[0] == "N1")
                    {


                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        gridview.Columns[x].DisplayFormat.FormatString = N1;
                    }

                    else if (ArrTags[0] == "N2")
                    {


                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        gridview.Columns[x].DisplayFormat.FormatString = N2;
                    }

                    else if (ArrTags[0] == "N3")
                    {


                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        gridview.Columns[x].DisplayFormat.FormatString = N3;
                    }


                    else if (ArrTags[0] == "N4")
                    {


                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        gridview.Columns[x].DisplayFormat.FormatString = N4;
                    }

                    else if (ArrTags[0] == "N5")
                    {


                        gridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        gridview.Columns[x].DisplayFormat.FormatString = N5;
                    }







                    //summries

                    if (ArrTags[1] == "S")
                    {



                        gridview.Columns[x].SummaryItem.DisplayFormat = SS;
                        gridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;




                    }

                    else if (ArrTags[1] == "A")
                    {


                        gridview.Columns[x].SummaryItem.DisplayFormat = SA;
                        gridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;




                    }
                    else if (ArrTags[1] == "M")
                    {


                        gridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        gridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max;




                    }
                    else if (ArrTags[1] == "m")
                    {



                        gridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        gridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min;




                    }
                    else if (ArrTags[1] == "C")
                    {



                        gridview.Columns[x].SummaryItem.DisplayFormat = ST;
                        gridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;




                    }

                }

            }


            else if (GridType == GEN.Gen_GridView.GRIDTYPE.Banded)
            {
                Bangridview.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(BangridView_Validate);
                Bangridview.ValidatingEditor += new BaseContainerValidateEditorEventHandler(BangridView_ValidatingEditor);
                Bangridview.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(gridView_InvalidRowException);

                for (int x = 0; x < Bangridview.Columns.Count - 1; x++)
                {



                    try
                    {


                        if (!object.ReferenceEquals(null, Bangridview.Columns[x].Tag))
                        {

                            ArrTags = Bangridview.Columns[x].Tag.ToString().Split('|');
                        }
                        else
                        {
                            continue;
                        }




                    }
                    catch
                    {

                        Array.Clear(ArrTags, 0, ArrTags.Length);
                        continue;

                    }



                    if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                    {
                        continue;

                    }






                    //Dates
                    if (ArrTags[0] == "D1")
                    {

                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Bangridview.Columns[x].DisplayFormat.FormatString = D1;

                    }

                    else if (ArrTags[0] == "D2")
                    {

                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Bangridview.Columns[x].DisplayFormat.FormatString = D2;

                    }

                    else if (ArrTags[0] == "D3")
                    {

                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Bangridview.Columns[x].DisplayFormat.FormatString = D3;

                    }

                    else if (ArrTags[0] == "D4")
                    {

                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Bangridview.Columns[x].DisplayFormat.FormatString = D4;

                    }

                    else if (ArrTags[0] == "D5")
                    {

                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Bangridview.Columns[x].DisplayFormat.FormatString = D5;

                    }





                    ///Numerics
                    if (ArrTags[0] == "N1")
                    {


                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Bangridview.Columns[x].DisplayFormat.FormatString = N1;
                    }

                    else if (ArrTags[0] == "N2")
                    {


                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Bangridview.Columns[x].DisplayFormat.FormatString = N2;
                    }

                    else if (ArrTags[0] == "N3")
                    {


                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Bangridview.Columns[x].DisplayFormat.FormatString = N3;
                    }


                    else if (ArrTags[0] == "N4")
                    {


                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Bangridview.Columns[x].DisplayFormat.FormatString = N4;
                    }

                    else if (ArrTags[0] == "N5")
                    {


                        Bangridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Bangridview.Columns[x].DisplayFormat.FormatString = N5;
                    }







                    //summries

                    if (ArrTags[1] == "S")
                    {



                        Bangridview.Columns[x].SummaryItem.DisplayFormat = SS;
                        Bangridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;




                    }

                    else if (ArrTags[1] == "A")
                    {


                        Bangridview.Columns[x].SummaryItem.DisplayFormat = SA;
                        Bangridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;




                    }
                    else if (ArrTags[1] == "M")
                    {


                        Bangridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        Bangridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max;




                    }
                    else if (ArrTags[1] == "m")
                    {



                        Bangridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        Bangridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min;




                    }
                    else if (ArrTags[1] == "C")
                    {



                        Bangridview.Columns[x].SummaryItem.DisplayFormat = ST;
                        Bangridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;




                    }

                }
            }


            else if (GridType == GEN.Gen_GridView.GRIDTYPE.AdvBanded)
            {
                Advgridview.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(AdvBangridView_Validate);
                Advgridview.ValidatingEditor += new BaseContainerValidateEditorEventHandler(AdvBangridView_ValidatingEditor);
                Advgridview.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(gridView_InvalidRowException);

                for (int x = 0; x < Advgridview.Columns.Count - 1; x++)
                {



                    try
                    {


                        if (!object.ReferenceEquals(null, Advgridview.Columns[x].Tag))
                        {

                            ArrTags = Advgridview.Columns[x].Tag.ToString().Split('|');
                        }
                        else
                        {
                            continue;
                        }




                    }
                    catch
                    {

                        Array.Clear(ArrTags, 0, ArrTags.Length);
                        continue;

                    }



                    if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                    {
                        continue;

                    }






                    //Dates
                    if (ArrTags[0] == "D1")
                    {

                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Advgridview.Columns[x].DisplayFormat.FormatString = D1;

                    }

                    else if (ArrTags[0] == "D2")
                    {

                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Advgridview.Columns[x].DisplayFormat.FormatString = D2;

                    }

                    else if (ArrTags[0] == "D3")
                    {

                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Advgridview.Columns[x].DisplayFormat.FormatString = D3;

                    }

                    else if (ArrTags[0] == "D4")
                    {

                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Advgridview.Columns[x].DisplayFormat.FormatString = D4;

                    }

                    else if (ArrTags[0] == "D5")
                    {

                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.DateTime;
                        Advgridview.Columns[x].DisplayFormat.FormatString = D5;

                    }





                    ///Numerics
                    if (ArrTags[0] == "N1")
                    {


                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Advgridview.Columns[x].DisplayFormat.FormatString = N1;
                    }

                    else if (ArrTags[0] == "N2")
                    {


                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Advgridview.Columns[x].DisplayFormat.FormatString = N2;
                    }

                    else if (ArrTags[0] == "N3")
                    {


                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Advgridview.Columns[x].DisplayFormat.FormatString = N3;
                    }


                    else if (ArrTags[0] == "N4")
                    {


                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Advgridview.Columns[x].DisplayFormat.FormatString = N4;
                    }

                    else if (ArrTags[0] == "N5")
                    {


                        Advgridview.Columns[x].DisplayFormat.FormatType = FormatType.Numeric;
                        Advgridview.Columns[x].DisplayFormat.FormatString = N5;
                    }







                    //summries

                    if (ArrTags[1] == "S")
                    {



                        Advgridview.Columns[x].SummaryItem.DisplayFormat = SS;
                        Advgridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;




                    }

                    else if (ArrTags[1] == "A")
                    {


                        Advgridview.Columns[x].SummaryItem.DisplayFormat = SA;
                        Advgridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;




                    }
                    else if (ArrTags[1] == "M")
                    {


                        Advgridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        Advgridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max;




                    }
                    else if (ArrTags[1] == "m")
                    {



                        Advgridview.Columns[x].SummaryItem.DisplayFormat = N2;
                        Advgridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min;




                    }
                    else if (ArrTags[1] == "C")
                    {



                        Advgridview.Columns[x].SummaryItem.DisplayFormat = ST;
                        Advgridview.Columns[x].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;




                    }

                }
            }




            else if (GridType == GEN.Gen_GridView.GRIDTYPE.TreeList)
            {

                TreeView.ValidateNode +=new ValidateNodeEventHandler(TreeView_Validate);
                TreeView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(TreeView_ValidatingEditor);
                TreeView.InvalidNodeException +=new InvalidNodeExceptionEventHandler(TreeView_InvalidNodeException);

                for (int x = 0; x < TreeView.Columns.Count - 1; x++)
                {



                    try
                    {


                        if (!object.ReferenceEquals(null, TreeView.Columns[x].Tag))
                        {

                            ArrTags = TreeView.Columns[x].Tag.ToString().Split('|');
                        }
                        else
                        {
                            continue;
                        }




                    }
                    catch
                    {

                        Array.Clear(ArrTags, 0, ArrTags.Length);
                        continue;

                    }



                    if (ArrTags[0] == "N" && ArrTags[1] == "N" && ArrTags[2] == "N")
                    {
                        continue;

                    }






                    //Dates
                    if (ArrTags[0] == "D1")
                    {

                        TreeView.Columns[x].Format.FormatType = FormatType.DateTime;
                        TreeView.Columns[x].Format.FormatString = D1;

                    }

                    else if (ArrTags[0] == "D2")
                    {

                        TreeView.Columns[x].Format.FormatType = FormatType.DateTime;
                        TreeView.Columns[x].Format.FormatString = D2;

                    }

                    else if (ArrTags[0] == "D3")
                    {

                        TreeView.Columns[x].Format.FormatType = FormatType.DateTime;
                        TreeView.Columns[x].Format.FormatString = D3;

                    }

                    else if (ArrTags[0] == "D4")
                    {

                        TreeView.Columns[x].Format.FormatType = FormatType.DateTime;
                        TreeView.Columns[x].Format.FormatString = D4;

                    }

                    else if (ArrTags[0] == "D5")
                    {

                        TreeView.Columns[x].Format.FormatType = FormatType.DateTime;
                        TreeView.Columns[x].Format.FormatString = D5;

                    }





                    ///Numerics
                    if (ArrTags[0] == "N1")
                    {


                        TreeView.Columns[x].Format.FormatType = FormatType.Numeric;
                        TreeView.Columns[x].Format.FormatString = N1;
                    }

                    else if (ArrTags[0] == "N2")
                    {


                        TreeView.Columns[x].Format.FormatType = FormatType.Numeric;
                        TreeView.Columns[x].Format.FormatString = N2;
                    }

                    else if (ArrTags[0] == "N3")
                    {


                        TreeView.Columns[x].Format.FormatType = FormatType.Numeric;
                        TreeView.Columns[x].Format.FormatString = N3;
                    }


                    else if (ArrTags[0] == "N4")
                    {


                        TreeView.Columns[x].Format.FormatType = FormatType.Numeric;
                        TreeView.Columns[x].Format.FormatString = N4;
                    }

                    else if (ArrTags[0] == "N5")
                    {


                        TreeView.Columns[x].Format.FormatType = FormatType.Numeric;
                        TreeView.Columns[x].Format.FormatString = N5;
                    }







                    //summries

                    if (ArrTags[1] == "S")
                    {



                        TreeView.Columns[x].SummaryFooterStrFormat = SS;
                        TreeView.Columns[x].SummaryFooter = SummaryItemType.Sum;




                    }

                    else if (ArrTags[1] == "A")
                    {


                        TreeView.Columns[x].SummaryFooterStrFormat = SA;
                        TreeView.Columns[x].SummaryFooter = SummaryItemType.Average;




                    }
                    else if (ArrTags[1] == "M")
                    {


                        TreeView.Columns[x].SummaryFooterStrFormat = N2;
                        TreeView.Columns[x].SummaryFooter = SummaryItemType.Max;




                    }
                    else if (ArrTags[1] == "m")
                    {



                        TreeView.Columns[x].SummaryFooterStrFormat = N2;
                        TreeView.Columns[x].SummaryFooter = SummaryItemType.Min;




                    }
                    else if (ArrTags[1] == "C")
                    {



                        TreeView.Columns[x].SummaryFooterStrFormat = ST;
                        TreeView.Columns[x].SummaryFooter = SummaryItemType.Count;




                    }

                }
            }




        }

         catch
     {


     }

        }
    }






     #endregion














     #region   class Apperance

     internal class Gen_Apperance
        {


            public  void SetGridAppearance(DevExpress.XtraGrid.Views.Grid.GridView Grid_View, String Type)
            {

                try
                {

                

                if (Type == "L")
                {

                    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                    Grid_View.OptionsView.ShowFooter = false;




                    Grid_View.OptionsView.ShowGroupPanel = false;

                    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    Grid_View.OptionsCustomization.AllowFilter = false;
                    Grid_View.OptionsCustomization.AllowGroup = false;
                    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    Grid_View.OptionsCustomization.AllowSort = false;
                    Grid_View.OptionsView.ShowAutoFilterRow = false;
                    Grid_View.OptionsBehavior.Editable = false;


                    Grid_View.OptionsFind.AllowFindPanel = false;

                    Grid_View.OptionsFind.AlwaysVisible = false;

                }
                else if (Type == "List")
                {

                    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    Grid_View.OptionsView.ShowFooter = true;
                    Grid_View.OptionsView.ShowGroupPanel = false;
                    Grid_View.OptionsView.ShowViewCaption = false;
                    Grid_View.OptionsCustomization.AllowColumnMoving = true;
                    Grid_View.OptionsCustomization.AllowColumnResizing = true;
                    Grid_View.OptionsCustomization.AllowFilter = true;
                    Grid_View.OptionsCustomization.AllowGroup = true;
                    Grid_View.OptionsCustomization.AllowQuickHideColumns = true;
                    Grid_View.OptionsCustomization.AllowRowSizing = true;
                    Grid_View.OptionsCustomization.AllowSort = true;
                    Grid_View.OptionsView.ShowAutoFilterRow = true;
                    Grid_View.OptionsBehavior.Editable = false;
                    Grid_View.OptionsFind.AllowFindPanel = false;
                    Grid_View.OptionsFind.AlwaysVisible = false;

                }


                

                if (Type == "D")
                {

                    Grid_View.Appearance.Row.Font = new Font("Tahoma", 10, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 10, FontStyle.Regular);

                    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                    Grid_View.OptionsView.ShowFooter = false;




                    Grid_View.OptionsView.ShowGroupPanel = true;

                    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    Grid_View.OptionsCustomization.AllowFilter = true;
                    Grid_View.OptionsCustomization.AllowGroup = false;
                    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    Grid_View.OptionsCustomization.AllowSort = true;
                    Grid_View.OptionsView.ShowAutoFilterRow = true;
                    Grid_View.OptionsBehavior.Editable = false;


                    Grid_View.OptionsFind.AllowFindPanel = true;

                    Grid_View.OptionsFind.AlwaysVisible = true;

                }

                if (Type == "I")
                {

                    //   Appearance

                    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
                    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
                    Grid_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
                    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    Grid_View.RowHeight = 20;
                    Grid_View.FooterPanelHeight = 20;
                    //   Behaviour

                    Grid_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                    Grid_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                    Grid_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

                    //   Customization


                    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    Grid_View.OptionsCustomization.AllowFilter = false;
                    Grid_View.OptionsCustomization.AllowGroup = false;
                    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    Grid_View.OptionsCustomization.AllowSort = false;


                    //   Find


                    Grid_View.OptionsFind.AllowFindPanel = false;
                    Grid_View.OptionsFind.AlwaysVisible = false;
                    Grid_View.OptionsFind.ClearFindOnClose = true;
                    Grid_View.OptionsFind.FindDelay = 100;
                    Grid_View.OptionsFind.FindFilterColumns = "*";
                    Grid_View.OptionsFind.FindMode = FindMode.Default;
                    Grid_View.OptionsFind.HighlightFindResults = false;
                    Grid_View.OptionsFind.ShowCloseButton = false;



                    // Option Layout

                    Grid_View.OptionsLayout.Columns.AddNewColumns = false;
                    Grid_View.OptionsLayout.Columns.RemoveOldColumns = false;



                    //  option menue 


                    Grid_View.OptionsMenu.EnableColumnMenu = false;
                    Grid_View.OptionsMenu.EnableFooterMenu = false;
                    
                    Grid_View.OptionsMenu.EnableGroupPanelMenu = false;
                    Grid_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;


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
                    Grid_View.OptionsView.ShowIndicator = false;
                    Grid_View.OptionsView.ShowGroupedColumns = false;
                    Grid_View.OptionsView.ShowGroupPanel = false;
                }

                }
                catch 
                {

                  
                }
            }

            public void BandedAppearance(BandedGridView Grid_View,String Type)
            {

                try
                {



                    if (Type == "L")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        Grid_View.OptionsView.ShowFooter = false;




                        Grid_View.OptionsView.ShowGroupPanel = false;

                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = false;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = false;
                        Grid_View.OptionsView.ShowAutoFilterRow = false;
                        Grid_View.OptionsBehavior.Editable = false;


                        Grid_View.OptionsFind.AllowFindPanel = false;

                        Grid_View.OptionsFind.AlwaysVisible = false;

                    }
                    else if (Type == "List")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        Grid_View.OptionsView.ShowFooter = true;
                        Grid_View.OptionsView.ShowGroupPanel = false;
                        Grid_View.OptionsView.ShowViewCaption = false;
                        Grid_View.OptionsCustomization.AllowColumnMoving = true;
                        Grid_View.OptionsCustomization.AllowColumnResizing = true;
                        Grid_View.OptionsCustomization.AllowFilter = true;
                        Grid_View.OptionsCustomization.AllowGroup = true;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = true;
                        Grid_View.OptionsCustomization.AllowRowSizing = true;
                        Grid_View.OptionsCustomization.AllowSort = true;
                        Grid_View.OptionsView.ShowAutoFilterRow = true;
                        Grid_View.OptionsBehavior.Editable = false;
                        Grid_View.OptionsFind.AllowFindPanel = false;
                        Grid_View.OptionsFind.AlwaysVisible = false;

                    }




                    if (Type == "D")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        Grid_View.OptionsView.ShowFooter = false;




                        Grid_View.OptionsView.ShowGroupPanel = true;

                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = true;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = true;
                        Grid_View.OptionsView.ShowAutoFilterRow = true;
                        Grid_View.OptionsBehavior.Editable = false;


                        Grid_View.OptionsFind.AllowFindPanel = true;

                        Grid_View.OptionsFind.AlwaysVisible = true;

                    }

                    if (Type == "I")
                    {

                        //   Appearance

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Grid_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        Grid_View.RowHeight = 20;
                        Grid_View.FooterPanelHeight = 20;
                        //   Behaviour

                        Grid_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                        Grid_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                        Grid_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

                        //   Customization


                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = false;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = false;


                        //   Find


                        Grid_View.OptionsFind.AllowFindPanel = false;
                        Grid_View.OptionsFind.AlwaysVisible = false;
                        Grid_View.OptionsFind.ClearFindOnClose = true;
                        Grid_View.OptionsFind.FindDelay = 100;
                        Grid_View.OptionsFind.FindFilterColumns = "*";
                        Grid_View.OptionsFind.FindMode = FindMode.Default;
                        Grid_View.OptionsFind.HighlightFindResults = false;
                        Grid_View.OptionsFind.ShowCloseButton = false;



                        // Option Layout

                        Grid_View.OptionsLayout.Columns.AddNewColumns = false;
                        Grid_View.OptionsLayout.Columns.RemoveOldColumns = false;



                        //  option menue 


                        Grid_View.OptionsMenu.EnableColumnMenu = false;
                        Grid_View.OptionsMenu.EnableFooterMenu = false;

                        Grid_View.OptionsMenu.EnableGroupPanelMenu = false;
                        Grid_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;


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
                        Grid_View.OptionsView.ShowIndicator = false;
                        Grid_View.OptionsView.ShowGroupedColumns = false;
                        Grid_View.OptionsView.ShowGroupPanel = false;
                    }

                }
                catch
                {


                }
            }

            public void AdvBandedAppearance(AdvBandedGridView Grid_View, String Type)
            {

                try
                {



                    if (Type == "L")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        Grid_View.OptionsView.ShowFooter = false;




                        Grid_View.OptionsView.ShowGroupPanel = false;

                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = false;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = false;
                        Grid_View.OptionsView.ShowAutoFilterRow = false;
                        Grid_View.OptionsBehavior.Editable = false;


                        Grid_View.OptionsFind.AllowFindPanel = false;

                        Grid_View.OptionsFind.AlwaysVisible = false;

                    }
                    else if (Type == "List")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        Grid_View.OptionsView.ShowFooter = true;
                        Grid_View.OptionsView.ShowGroupPanel = false;
                        Grid_View.OptionsView.ShowViewCaption = false;
                        Grid_View.OptionsCustomization.AllowColumnMoving = true;
                        Grid_View.OptionsCustomization.AllowColumnResizing = true;
                        Grid_View.OptionsCustomization.AllowFilter = true;
                        Grid_View.OptionsCustomization.AllowGroup = true;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = true;
                        Grid_View.OptionsCustomization.AllowRowSizing = true;
                        Grid_View.OptionsCustomization.AllowSort = true;
                        Grid_View.OptionsView.ShowAutoFilterRow = true;
                        Grid_View.OptionsBehavior.Editable = false;
                        Grid_View.OptionsFind.AllowFindPanel = false;
                        Grid_View.OptionsFind.AlwaysVisible = false;

                    }




                    if (Type == "D")
                    {

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        Grid_View.OptionsView.ShowFooter = false;




                        Grid_View.OptionsView.ShowGroupPanel = true;

                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = true;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = true;
                        Grid_View.OptionsView.ShowAutoFilterRow = true;
                        Grid_View.OptionsBehavior.Editable = false;


                        Grid_View.OptionsFind.AllowFindPanel = true;

                        Grid_View.OptionsFind.AlwaysVisible = true;

                    }

                    if (Type == "I")
                    {

                        //   Appearance

                        Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Grid_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
                        Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        Grid_View.RowHeight = 20;
                        Grid_View.FooterPanelHeight = 20;
                        //   Behaviour

                        Grid_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                        Grid_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                        Grid_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

                        //   Customization


                        Grid_View.OptionsCustomization.AllowColumnMoving = false;
                        Grid_View.OptionsCustomization.AllowColumnResizing = false;
                        Grid_View.OptionsCustomization.AllowFilter = false;
                        Grid_View.OptionsCustomization.AllowGroup = false;
                        Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                        Grid_View.OptionsCustomization.AllowRowSizing = false;
                        Grid_View.OptionsCustomization.AllowSort = false;


                        //   Find


                        Grid_View.OptionsFind.AllowFindPanel = false;
                        Grid_View.OptionsFind.AlwaysVisible = false;
                        Grid_View.OptionsFind.ClearFindOnClose = true;
                        Grid_View.OptionsFind.FindDelay = 100;
                        Grid_View.OptionsFind.FindFilterColumns = "*";
                        Grid_View.OptionsFind.FindMode = FindMode.Default;
                        Grid_View.OptionsFind.HighlightFindResults = false;
                        Grid_View.OptionsFind.ShowCloseButton = false;



                        // Option Layout

                        Grid_View.OptionsLayout.Columns.AddNewColumns = false;
                        Grid_View.OptionsLayout.Columns.RemoveOldColumns = false;



                        //  option menue 


                        Grid_View.OptionsMenu.EnableColumnMenu = false;
                        Grid_View.OptionsMenu.EnableFooterMenu = false;

                        Grid_View.OptionsMenu.EnableGroupPanelMenu = false;
                        Grid_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;


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
                        Grid_View.OptionsView.ShowIndicator = false;
                        Grid_View.OptionsView.ShowGroupedColumns = false;
                        Grid_View.OptionsView.ShowGroupPanel = false;
                    }

                }
                catch
                {


                }
            }

            public void TreeAppearance(TreeList Tree_View, String Type)
            {

                try
                {



                    if (Type == "L")
                    {

                        Tree_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        //Tree_View.OptionsView.ShowFooter = false;




                        //Tree_View.OptionsView.ShowGroupPanel = false;

                        //Tree_View.OptionsCustomization.AllowColumnMoving = false;
                        //Tree_View.OptionsCustomization.AllowColumnResizing = false;
                        //Tree_View.OptionsCustomization.AllowFilter = false;
                        //Tree_View.OptionsCustomization.AllowGroup = false;
                        //Tree_View.OptionsCustomization.AllowQuickHideColumns = false;
                        //Tree_View.OptionsCustomization.AllowRowSizing = false;
                        //Tree_View.OptionsCustomization.AllowSort = false;
                        Tree_View.OptionsView.ShowAutoFilterRow = false;
                        Tree_View.OptionsBehavior.Editable = false;


                        //Tree_View.OptionsFind.AllowFindPanel = false;

                        //Tree_View.OptionsFind.AlwaysVisible = false;

                    }
                    else if (Type == "List")
                    {

                        Tree_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        //Tree_View.OptionsView.ShowFooter = true;
                        //Tree_View.OptionsView.ShowGroupPanel = false;
                        //Tree_View.OptionsView.ShowViewCaption = false;
                        //Tree_View.OptionsCustomization.AllowColumnMoving = true;
                        //Tree_View.OptionsCustomization.AllowColumnResizing = true;
                        //Tree_View.OptionsCustomization.AllowFilter = true;
                        //Tree_View.OptionsCustomization.AllowGroup = true;
                        //Tree_View.OptionsCustomization.AllowQuickHideColumns = true;
                        //Tree_View.OptionsCustomization.AllowRowSizing = true;
                        //Tree_View.OptionsCustomization.AllowSort = true;
                        Tree_View.OptionsView.ShowAutoFilterRow = true;
                        Tree_View.OptionsBehavior.Editable = false;
                        //Tree_View.OptionsFind.AllowFindPanel = false;
                        //Tree_View.OptionsFind.AlwaysVisible = false;

                    }




                    if (Type == "D")
                    {

                        Tree_View.Appearance.Row.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 10, FontStyle.Regular);

                        Tree_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                        //Tree_View.OptionsView.ShowFooter = false;




                        //Tree_View.OptionsView.ShowGroupPanel = true;

                        //Tree_View.OptionsCustomization.AllowColumnMoving = false;
                        //Tree_View.OptionsCustomization.AllowColumnResizing = false;
                        //Tree_View.OptionsCustomization.AllowFilter = true;
                        //Tree_View.OptionsCustomization.AllowGroup = false;
                        //Tree_View.OptionsCustomization.AllowQuickHideColumns = false;
                        //Tree_View.OptionsCustomization.AllowRowSizing = false;
                        //Tree_View.OptionsCustomization.AllowSort = true;
                        Tree_View.OptionsView.ShowAutoFilterRow = true;
                        Tree_View.OptionsBehavior.Editable = false;


                        //Tree_View.OptionsFind.AllowFindPanel = true;

                        //Tree_View.OptionsFind.AlwaysVisible = true;

                    }

                    if (Type == "I")
                    {

                        //   Appearance

                        Tree_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Tree_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        Tree_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
                        Tree_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        Tree_View.RowHeight = 20;
                       // Tree_View.FooterPanelHeight = 20;
                        //   Behaviour

                        //Tree_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                        //Tree_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                        //Tree_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

                        //   Customization


                        //Tree_View.AllowColumnMoving = false;
                        //Tree_View.OptionsCustomization.AllowColumnResizing = false;
                        //Tree_View.OptionsCustomization.AllowFilter = false;
                        //Tree_View.OptionsCustomization.AllowGroup = false;
                        //Tree_View.OptionsCustomization.AllowQuickHideColumns = false;
                        //Tree_View.OptionsCustomization.AllowRowSizing = false;
                        //Tree_View.OptionsCustomization.AllowSort = false;


                        //   Find


                        //Tree_View.OptionsFind.AllowFindPanel = false;
                        //Tree_View.OptionsFind.AlwaysVisible = false;
                        //Tree_View.OptionsFind.ClearFindOnClose = true;
                        //Tree_View.OptionsFind.FindDelay = 100;
                        //Tree_View.OptionsFind.FindFilterColumns = "*";
                        //Tree_View.OptionsFind.FindMode = FindMode.Default;
                        //Tree_View.OptionsFind.HighlightFindResults = false;
                        //Tree_View.OptionsFind.ShowCloseButton = false;



                        // Option Layout

                        //Tree_View.OptionsLayout.Columns.AddNewColumns = false;
                        //Tree_View.OptionsLayout.Columns.RemoveOldColumns = false;



                        //  option menue 


                        Tree_View.OptionsMenu.EnableColumnMenu = false;
                        Tree_View.OptionsMenu.EnableFooterMenu = false;

                        //Tree_View.OptionsMenu.EnableGroupPanelMenu = false;
                        //Tree_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;


                        // option navigation

                        //Tree_View.OptionsNavigation.AutoFocusNewRow = true;
                        //Tree_View.OptionsNavigation.AutoMoveRowFocus = true;
                        //Tree_View.OptionsNavigation.EnterMoveNextColumn = false;
                        //Tree_View.OptionsNavigation.UseOfficePageNavigation = true;
                        //Tree_View.OptionsNavigation.UseTabKey = true;


                        // option selection 


                        Tree_View.OptionsSelection.EnableAppearanceFocusedCell = true;
                        Tree_View.OptionsSelection.EnableAppearanceFocusedRow = true;
                        //Tree_View.OptionsSelection.EnableAppearanceHideSelection = true;
                        Tree_View.OptionsSelection.MultiSelect = true;
                        Tree_View.OptionsSelection.UseIndicatorForSelection = true;




                        // option  view



                        //Tree_View.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
                        //Tree_View.OptionsView.ColumnAutoWidth = true;
                        Tree_View.OptionsView.EnableAppearanceEvenRow = false;
                        Tree_View.OptionsView.EnableAppearanceOddRow = false;
                        //Tree_View.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        //Tree_View.OptionsView.RowAutoHeight = true;
                        //Tree_View.OptionsView.ShowColumnHeaders = true;
                        //Tree_View.OptionsView.ShowFooter = true;
                        Tree_View.OptionsView.ShowIndicator = false;
                        //Tree_View.OptionsView.ShowGroupedColumns = false;
                        //Tree_View.OptionsView.ShowGroupPanel = false;
                    }

                }
                catch
                {


                }
            }

            private void PivotAppearance(PivotGridControl Grid_View, String Type)
            {

                try
                {



                    //if (Type == "L")
                    //{

                    //    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                    //    Grid_View.OptionsView.ShowFooter = false;




                    //    Grid_View.OptionsView.ShowGroupPanel = false;

                    //    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    //    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    //    Grid_View.OptionsCustomization.AllowFilter = false;
                    //    Grid_View.OptionsCustomization.AllowGroup = false;
                    //    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    //    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    //    Grid_View.OptionsCustomization.AllowSort = false;
                    //    Grid_View.OptionsView.ShowAutoFilterRow = false;
                    //    Grid_View.OptionsBehavior.Editable = false;


                    //    Grid_View.OptionsFind.AllowFindPanel = false;

                    //    Grid_View.OptionsFind.AlwaysVisible = false;

                    //}
                    //else if (Type == "List")
                    //{

                    //    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    //    Grid_View.OptionsView.ShowFooter = true;
                    //    Grid_View.OptionsView.ShowGroupPanel = false;
                    //    Grid_View.OptionsView.ShowViewCaption = false;
                    //    Grid_View.OptionsCustomization.AllowColumnMoving = true;
                    //    Grid_View.OptionsCustomization.AllowColumnResizing = true;
                    //    Grid_View.OptionsCustomization.AllowFilter = true;
                    //    Grid_View.OptionsCustomization.AllowGroup = true;
                    //    Grid_View.OptionsCustomization.AllowQuickHideColumns = true;
                    //    Grid_View.OptionsCustomization.AllowRowSizing = true;
                    //    Grid_View.OptionsCustomization.AllowSort = true;
                    //    Grid_View.OptionsView.ShowAutoFilterRow = true;
                    //    Grid_View.OptionsBehavior.Editable = false;
                    //    Grid_View.OptionsFind.AllowFindPanel = false;
                    //    Grid_View.OptionsFind.AlwaysVisible = false;

                    //}




                    //if (Type == "D")
                    //{

                    //    Grid_View.Appearance.Row.Font = new Font("Tahoma", 10, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 10, FontStyle.Regular);

                    //    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                    //    Grid_View.OptionsView.ShowFooter = false;




                    //    Grid_View.OptionsView.ShowGroupPanel = true;

                    //    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    //    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    //    Grid_View.OptionsCustomization.AllowFilter = true;
                    //    Grid_View.OptionsCustomization.AllowGroup = false;
                    //    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    //    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    //    Grid_View.OptionsCustomization.AllowSort = true;
                    //    Grid_View.OptionsView.ShowAutoFilterRow = true;
                    //    Grid_View.OptionsBehavior.Editable = false;


                    //    Grid_View.OptionsFind.AllowFindPanel = true;

                    //    Grid_View.OptionsFind.AlwaysVisible = true;

                    //}

                    //if (Type == "I")
                    //{

                    //    //   Appearance

                    //    Grid_View.Appearance.Row.Font = new Font("Tahoma", 8, FontStyle.Regular);
                    //    Grid_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8, FontStyle.Regular);
                    //    Grid_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8, FontStyle.Italic);
                    //    Grid_View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    //    Grid_View.RowHeight = 20;
                    //    Grid_View.FooterPanelHeight = 20;
                    //    //   Behaviour

                    //    Grid_View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                    //    Grid_View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
                    //    Grid_View.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;

                    //    //   Customization


                    //    Grid_View.OptionsCustomization.AllowColumnMoving = false;
                    //    Grid_View.OptionsCustomization.AllowColumnResizing = false;
                    //    Grid_View.OptionsCustomization.AllowFilter = false;
                    //    Grid_View.OptionsCustomization.AllowGroup = false;
                    //    Grid_View.OptionsCustomization.AllowQuickHideColumns = false;
                    //    Grid_View.OptionsCustomization.AllowRowSizing = false;
                    //    Grid_View.OptionsCustomization.AllowSort = false;


                    //    //   Find


                    //    Grid_View.OptionsFind.AllowFindPanel = false;
                    //    Grid_View.OptionsFind.AlwaysVisible = false;
                    //    Grid_View.OptionsFind.ClearFindOnClose = true;
                    //    Grid_View.OptionsFind.FindDelay = 100;
                    //    Grid_View.OptionsFind.FindFilterColumns = "*";
                    //    Grid_View.OptionsFind.FindMode = FindMode.Default;
                    //    Grid_View.OptionsFind.HighlightFindResults = false;
                    //    Grid_View.OptionsFind.ShowCloseButton = false;



                    //    // Option Layout

                    //    Grid_View.OptionsLayout.Columns.AddNewColumns = false;
                    //    Grid_View.OptionsLayout.Columns.RemoveOldColumns = false;



                    //    //  option menue 


                    //    Grid_View.OptionsMenu.EnableColumnMenu = false;
                    //    Grid_View.OptionsMenu.EnableFooterMenu = false;

                    //    Grid_View.OptionsMenu.EnableGroupPanelMenu = false;
                    //    Grid_View.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;


                    //    // option navigation

                    //    Grid_View.OptionsNavigation.AutoFocusNewRow = true;
                    //    Grid_View.OptionsNavigation.AutoMoveRowFocus = true;
                    //    Grid_View.OptionsNavigation.EnterMoveNextColumn = false;
                    //    Grid_View.OptionsNavigation.UseOfficePageNavigation = true;
                    //    Grid_View.OptionsNavigation.UseTabKey = true;


                    //    // option selection 


                    //    Grid_View.OptionsSelection.EnableAppearanceFocusedCell = true;
                    //    Grid_View.OptionsSelection.EnableAppearanceFocusedRow = true;
                    //    Grid_View.OptionsSelection.EnableAppearanceHideSelection = true;
                    //    Grid_View.OptionsSelection.MultiSelect = true;
                    //    Grid_View.OptionsSelection.UseIndicatorForSelection = true;




                    //    // option  view



                    //    Grid_View.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
                    //    Grid_View.OptionsView.ColumnAutoWidth = true;
                    //    Grid_View.OptionsView.EnableAppearanceEvenRow = false;
                    //    Grid_View.OptionsView.EnableAppearanceOddRow = false;
                    //    Grid_View.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                    //    Grid_View.OptionsView.RowAutoHeight = true;
                    //    Grid_View.OptionsView.ShowColumnHeaders = true;
                    //    Grid_View.OptionsView.ShowFooter = true;
                    //    Grid_View.OptionsView.ShowIndicator = false;
                    //    Grid_View.OptionsView.ShowGroupedColumns = false;
                    //    Grid_View.OptionsView.ShowGroupPanel = false;
                    //}

                }
                catch
                {


                }
            }



        }


     #endregion




     #region   ClassShortcutKeys


     internal class Gen_ShortKeys
        {


            public void SetGridShortkey(DevExpress.XtraGrid.Views.Grid.GridView Grid_View, KeyEventArgs e)
            {
                try
                {



                    if (Grid_View.IsFocusedView == true)
                    {


                        if (e.KeyCode == Keys.Enter)
                        {

                            if (Grid_View.FocusedColumn.VisibleIndex < Grid_View.VisibleColumns.Count - 1)
                            {


                                Grid_View.FocusedColumn = Grid_View.Columns[Grid_View.FocusedColumn.VisibleIndex + 1];
                            }
                            else
                            {

                                Grid_View.FocusedRowHandle++;
                                Grid_View.FocusedColumn = Grid_View.Columns[0];

                            }
                        }

                        else if (e.Control && e.KeyCode == Keys.Delete)
                        {
                            if (Grid_View.FocusedRowHandle > 0)
                            {
                                Grid_View.DeleteRow(Grid_View.FocusedRowHandle);
                                Grid_View.Columns[0].Visible = false;
                            }
                        }



                        else if (e.Control && e.KeyCode == Keys.H)
                        {
                            Grid_View.FocusedColumn.Visible = false;
                        }



                    }



                }


                catch 
                {

                    
                }

            }



            public void BanedeGridShortkey(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView Grid_View, KeyEventArgs e)
            {
                try
                {



                    if (Grid_View.IsFocusedView == true)
                    {


                        if (e.KeyCode == Keys.Enter)
                        {

                            if (Grid_View.FocusedColumn.VisibleIndex < Grid_View.VisibleColumns.Count - 1)
                            {


                                Grid_View.FocusedColumn = Grid_View.Columns[Grid_View.FocusedColumn.VisibleIndex + 1];
                            }
                            else
                            {

                                Grid_View.FocusedRowHandle++;
                                Grid_View.FocusedColumn = Grid_View.Columns[0];

                            }
                        }

                        else if (e.Control && e.KeyCode == Keys.Delete)
                        {
                            if (Grid_View.FocusedRowHandle > 0)
                            {
                                Grid_View.DeleteRow(Grid_View.FocusedRowHandle);
                                Grid_View.Columns[0].Visible = false;
                            }
                        }



                        else if (e.Control && e.KeyCode == Keys.H)
                        {
                            Grid_View.FocusedColumn.Visible = false;
                        }



                    }



                }


                catch
                {


                }

            }


            public void  AdvBanedeGridShortkey(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView Grid_View, KeyEventArgs e)
            {
                try
                {



                    if (Grid_View.IsFocusedView == true)
                    {


                        if (e.KeyCode == Keys.Enter)
                        {

                            if (Grid_View.FocusedColumn.VisibleIndex < Grid_View.VisibleColumns.Count - 1)
                            {


                                Grid_View.FocusedColumn = Grid_View.Columns[Grid_View.FocusedColumn.VisibleIndex + 1];
                            }
                            else
                            {

                                Grid_View.FocusedRowHandle++;
                                Grid_View.FocusedColumn = Grid_View.Columns[0];

                            }
                        }

                        else if (e.Control && e.KeyCode == Keys.Delete)
                        {
                            if (Grid_View.FocusedRowHandle > 0)
                            {
                                Grid_View.DeleteRow(Grid_View.FocusedRowHandle);
                                Grid_View.Columns[0].Visible = false;
                            }
                        }



                        else if (e.Control && e.KeyCode == Keys.H)
                        {
                            Grid_View.FocusedColumn.Visible = false;
                        }



                    }



                }


                catch
                {


                }

            }



            public void TreeListShortkey(DevExpress.XtraTreeList.TreeList Tree_View, KeyEventArgs e)
            {
                try
                {



                    if (Tree_View.Focused == true)
                    {


                        if (e.KeyCode == Keys.Enter)
                        {

                            if (Tree_View.FocusedColumn.VisibleIndex < Tree_View.VisibleColumns.Count - 1)
                            {


                                Tree_View.FocusedColumn = Tree_View.Columns[Tree_View.FocusedColumn.VisibleIndex + 1];
                            }
                            else
                            {

                                Tree_View.MoveNext();
                                Tree_View.FocusedColumn = Tree_View.Columns[0];

                            }
                        }

                        else if (e.Control && e.KeyCode == Keys.Delete)
                        {
                            if (Tree_View.AllNodesCount > 0)
                            {
                                Tree_View.DeleteNode(Tree_View.FocusedNode);
                                Tree_View.Columns[0].Visible = false;
                            }
                        }



                        else if (e.Control && e.KeyCode == Keys.H)
                        {
                            Tree_View.FocusedColumn.Visible = false;
                        }


                       

                    }



                }


                catch
                {


                }

            }


        }
    
    

#endregion
}

#endregion
