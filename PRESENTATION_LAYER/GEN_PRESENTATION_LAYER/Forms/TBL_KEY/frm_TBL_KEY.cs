using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_KEY
{
    public partial class frm_TBL_KEY : DevExpress.XtraEditors.XtraForm
    {

        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


        GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;

        public char DBStatus = 'I';
        cls_TBL_RIGHTS_TEMPLATE_P objcls_TBL_KEY_P = null;
        public string maxID = "";

        public frm_TBL_KEY()
            {
                  InitializeComponent();

            }

        public frm_TBL_KEY(String pID, bool pIs_DesturbanceOnce)
        {
            try
            {

                InitializeComponent();


                obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                objcls_TBL_KEY_P = new cls_TBL_RIGHTS_TEMPLATE_P(this, pID, obj_GenForm, pIs_DesturbanceOnce);
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
        
            objcls_TBL_KEY_P.selection("A", "");
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
        
            objcls_TBL_KEY_P.Referesh("False");
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
        
            objcls_TBL_KEY_P.Referesh("True");
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
        
            objcls_TBL_KEY_P.Delete();
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
        
            objcls_TBL_KEY_P.Save();
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



        private void frm_TBL_KEY_KeyDown(object sender, KeyEventArgs e)
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


        private void TextEdit_KEY_ID_Leave(object sender, EventArgs e)
        {
                        try
            {   
        
            if (DBStatus == 'U')
                TextEdit_KEY_ID.Text = maxID;
            else
            {
                if (CheckEdit_Is_AutoGenegereted.Checked)
                    TextEdit_KEY_ID.Text = maxID;
            }
            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }
        }

        private void TextEdit_KEY_ID_KeyDown(object sender, KeyEventArgs e)
        {
                        try
            {   
        
            if (e.KeyData == Keys.Enter)
            {

                if (TextEdit_KEY_ID.Text != "")
                    objcls_TBL_KEY_P.selection("V", TextEdit_KEY_ID.Text.Trim());
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
                objcls_TBL_KEY_P.selection("N", x.ToString());
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
                objcls_TBL_KEY_P.Referesh("False");
            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }

        }









        private void GridLookUpEdit_KEY_types_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {   
        
            if (e.Control  && e.KeyCode == Keys.A)
                GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_KEYS_TYPES("N", false, false, true);
            else if (e.Control && e.KeyCode == Keys.U)
            {
                try
                {
                    GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_KEYS_TYPES(GridLookUpEdit_KEY_types.EditValue.ToString(), false, false, true);
        

                }
                catch
                { 
                
                }

            }
            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }
         }

        private void frm_TBL_KEY_Load(object sender, EventArgs e)
        {

        }











    }



}