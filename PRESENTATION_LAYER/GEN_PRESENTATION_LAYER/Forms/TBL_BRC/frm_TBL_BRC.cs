using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_BRC
{
      public partial class frm_TBL_BRC : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;

            public char DBStatus = 'I';
            cls_TBL_BRC_P objcls_TBL_BRC_P = null;
            public string maxID = "";
            
            public frm_TBL_BRC()
            {
                  InitializeComponent();

            }
            public frm_TBL_BRC(String pID, bool pIs_DesturbanceOnce)
            {

                  try
                  {

                        InitializeComponent();
                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        objcls_TBL_BRC_P = new cls_TBL_BRC_P(this, pID, obj_GenForm, pIs_DesturbanceOnce);
                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
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

                        objcls_TBL_BRC_P.selection("A", "");

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

                        objcls_TBL_BRC_P.Referesh("False");

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

                        objcls_TBL_BRC_P.Referesh("True");

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

                        objcls_TBL_BRC_P.Delete();

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

                        objcls_TBL_BRC_P.Save();

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



            private void frm_TBL_BRC_KeyDown(object sender, KeyEventArgs e)
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


            private void TextEdit_BRC_maxID_Leave(object sender, EventArgs e)
            {

                  try
                  {

                        if (DBStatus == 'U')
                              TextEdit_BRC_maxID.Text = maxID;
                        else
                        {
                              if (CheckEdit_Is_AutoGenegereted.Checked)
                                    TextEdit_BRC_maxID.Text = maxID;
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_BRC_maxID_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_BRC_maxID.Text != "")
                                    objcls_TBL_BRC_P.selection("V", TextEdit_BRC_maxID.Text.Trim());
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
                              objcls_TBL_BRC_P.selection("N", x.ToString());
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
                              objcls_TBL_BRC_P.Referesh("False");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }





            private void GridLookUpEdit_BRC_adminUserID_KeyDown(object sender, KeyEventArgs e)
        {
        //if (e.Control && e.Shift && e.KeyCode == Keys.R)
        //            objcls_TBL_BRC_P.loadGridLookUpEdit("TBL_RIGHTS_MAIN");

        //    else if (e.Control  && e.KeyCode == Keys.A)
        //       {
        //        GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_MAIN("N", false, false, true);
        //  objcls_TBL_BRC_P.loadGridLookUpEdit("TBL_RIGHTS_MAIN");

        //       }
        //    else if (e.Control && e.KeyCode == Keys.U)
        //    {
        //        try
        //        {
        //            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_MAIN(GridLookUpEdit_                  BRC_adminUserID.EditValue.ToString(), false, false, true);
        //            objcls_TBL_BRC_P.loadGridLookUpEdit("TBL_RIGHTS_MAIN");

        

        //        }
        //        catch
        //        { 
                
        //        }

        //    }

         }

            private void frm_TBL_BRC_Load(object sender, EventArgs e)
            {

            }

      }



}