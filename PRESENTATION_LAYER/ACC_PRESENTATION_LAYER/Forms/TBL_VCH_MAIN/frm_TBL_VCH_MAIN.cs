using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL.ACC_BLL.TBL_VCH_MAIN;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Forms.TBL_VCH_MAIN
{
      public partial class frm_TBL_VCH_MAIN : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;

            public char DBStatus = 'I';
            cls_TBL_VCH_MAIN_P objcls_TBL_VCH_MAIN_P = null;
            public string maxID = "";

            public frm_TBL_VCH_MAIN()
            {
                  InitializeComponent();
            }

            public frm_TBL_VCH_MAIN(String pID, bool pIs_DesturbanceOnce, string PtmpVCHPrefix)
            {

                  try
                  {

                        InitializeComponent();
                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(this.GridView_TBL_VCH_DETAILS, this.GridControl_TBL_VCH_DETAILS);

                        objcls_TBL_VCH_MAIN_P = new cls_TBL_VCH_MAIN_P(this, pID, obj_GenForm, ObjGenGrid, pIs_DesturbanceOnce, PtmpVCHPrefix);
                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
                        ObjGenGrid.Apperance("I");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }



            }


            public void SimpleButton_List_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_VCH_MAIN_P.selection("A", "");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Referesh_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_VCH_MAIN_P.Referesh("False");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Referesh_A_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_VCH_MAIN_P.Referesh("True");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Delete_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_VCH_MAIN_P.Delete();

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Save_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_VCH_MAIN_P.Save();

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Exit_Click(object sender, EventArgs e)
            {

                  try
                  {

                        if (this.DBStatus == 'U')
                        {

                              obj_cls_MessageBox.MessageBoxStatic("C_E");
                              return;
                        }
                        this.Close();
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }



            private void frm_TBL_VCH_MAIN_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        obj_GenForm.ShortKey(e);

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }


            private void TextEdit_VCH_ID_Leave(object sender, EventArgs e)
            {

                  try
                  {

                        if (DBStatus == 'U')
                              TextEdit_VCH_ID.Text = maxID;
                        else
                        {
                              if (CheckEdit_Is_AutoGenegereted.Checked)
                                    TextEdit_VCH_ID.Text = maxID;
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_VCH_ID_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_VCH_ID.Text != "")
                                    objcls_TBL_VCH_MAIN_P.selection("V", GEN.ACC_GEN.Generics.cls_GACCFunctions.getCompleteVCHCodeWithPrefix(TextEdit_VCH_ID.Text.Trim(),objcls_TBL_VCH_MAIN_P.tmpVCHPrefix));
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void DataNavigator_Navigate_PositionChanged(object sender, EventArgs e)
            {

                  try
                  {
                        loadDataFromDataNavigator();
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            void loadDataFromDataNavigator()
            {

                  try
                  {

                        int x = DataNavigator_Navigate.Position;
                        if (x >= 0)
                              objcls_TBL_VCH_MAIN_P.selection("N", x.ToString());
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }


            private void CheckEdit_navigate_CheckedChanged(object sender, EventArgs e)
            {

                  try
                  {

                        DataNavigator_Navigate.Enabled = CheckEdit_navigate.Checked;
                        if (CheckEdit_navigate.Checked)
                              loadDataFromDataNavigator();
                        else
                              objcls_TBL_VCH_MAIN_P.Referesh("False");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }

            private void GridView_TBL_VCH_DETAILS_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
            {


                  string tmp_A_Accounts = GridView_TBL_VCH_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.A_VCH_DETAILS_COA).ToString();
                  string tmp_Accounts = GridView_TBL_VCH_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.VCH_DETAILS_COA).ToString();


                  if ((tmp_Accounts !=  tmp_A_Accounts) && e.Column.FieldName == cls_CTBL_VCH_MAIN.A_VCH_DETAILS_COA)
                  {
                              GridView_TBL_VCH_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.VCH_DETAILS_COA, e.Value);
                        //else if (e.Column.FieldName == cls_CTBL_VCH_MAIN.VCH_DETAILS_COA && GridView_TBL_VCH_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.VCH_DETAILS_COA).ToString() != "")
                        //      GridView_TBL_VCH_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.A_VCH_DETAILS_COA, e.Value);
                  }
                  else if ((tmp_Accounts != tmp_A_Accounts) && e.Column.FieldName == cls_CTBL_VCH_MAIN.VCH_DETAILS_COA)
                  {
                        GridView_TBL_VCH_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.A_VCH_DETAILS_COA, e.Value);
                        //else if (e.Column.FieldName == cls_CTBL_VCH_MAIN.VCH_DETAILS_COA && GridView_TBL_VCH_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.VCH_DETAILS_COA).ToString() != "")
                        //      GridView_TBL_VCH_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_VCH_MAIN.A_VCH_DETAILS_COA, e.Value);
                  }
            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                objcls_TBL_VCH_MAIN_P.Print();

            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }
        }
    }



}