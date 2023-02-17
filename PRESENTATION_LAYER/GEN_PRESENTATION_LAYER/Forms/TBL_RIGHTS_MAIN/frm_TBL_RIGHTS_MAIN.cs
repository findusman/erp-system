using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_MAIN
{
      public partial class frm_TBL_RIGHTS_MAIN : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;

            public char DBStatus = 'I';
            cls_TBL_RIGHTS_MAIN_P objcls_TBL_RIGHTS_MAIN_P = null;
            public string maxID = "";


            public frm_TBL_RIGHTS_MAIN()
            {
                  InitializeComponent();
            }


            public frm_TBL_RIGHTS_MAIN(String pID, string pRIGHTS_MAIN_rightAssigner, bool pIs_DesturbanceOnce)
            {

                  try
                  {

                        InitializeComponent();
                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        //ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(this.GridView_TBL_RIGHTS_DETAILS, this.GridControl_TBL_RIGHTS_DETAILS);

                        objcls_TBL_RIGHTS_MAIN_P = new cls_TBL_RIGHTS_MAIN_P(this, pID, pRIGHTS_MAIN_rightAssigner,  obj_GenForm,  ObjGenGrid, pIs_DesturbanceOnce);
                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
                        //ObjGenGrid.Apperance("I");


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

                        objcls_TBL_RIGHTS_MAIN_P.selection("A", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID_RIGHTS_MAIN_rightAssigner,false);

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

                        objcls_TBL_RIGHTS_MAIN_P.Referesh("False");

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

                        objcls_TBL_RIGHTS_MAIN_P.Referesh("True");

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

                        objcls_TBL_RIGHTS_MAIN_P.Delete();

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

                        objcls_TBL_RIGHTS_MAIN_P.Save();

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



            private void frm_TBL_RIGHTS_MAIN_KeyDown(object sender, KeyEventArgs e)
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


            private void TextEdit_RIGHTS_MAIN_ID_Leave(object sender, EventArgs e)
            {

                  try
                  {

                        if (DBStatus == 'U')
                              TextEdit_RIGHTS_MAIN_ID.Text = maxID;
                        else
                        {
                              if (CheckEdit_Is_AutoGenegereted.Checked)
                                    TextEdit_RIGHTS_MAIN_ID.Text = maxID;
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_RIGHTS_MAIN_ID_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_RIGHTS_MAIN_ID.Text != "" || TextEdit_RIGHTS_MAIN_ID.Text != GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID)
                                    objcls_TBL_RIGHTS_MAIN_P.selection("Load All Rights To Assign To Child Or Sibling", TextEdit_RIGHTS_MAIN_ID.Text.Trim(), GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID,true);
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
                              objcls_TBL_RIGHTS_MAIN_P.selection("Load All Rights To Assign To Child Or Sibling", x.ToString(), GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID, true);
                        //objcls_TBL_RIGHTS_MAIN_P.selection("N", x.ToString());
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
                              objcls_TBL_RIGHTS_MAIN_P.Referesh("False");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }

            private void TreeList_visibleBase_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
            {
                  //MessageBox.Show("usman");
                  //string str = "";
            }

            private void TreeList_visibleBase_CustomDrawNodeCheckBox(object sender, DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventArgs e)
            {
                  //if (e.Node.Checked.ToString() == "True")
                  //      e.Node[BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.RIGHTS_DETAILS_isFixed] = "True";

                  //e.Node[BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.RIGHTS_DETAILS_isFixed] = e.Node.Checked;
                 // string str = "";
            }

            private void TreeList_visibleBase_StateChanged(object sender, EventArgs e)
            {
                  string str = "";
            }



          

      }



}