using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_CUSTOMERS
{
    public partial class frm_TBL_CUSTOMERS : DevExpress.XtraEditors.XtraForm
    {

        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


        GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;

        public char DBStatus = 'I';
        cls_TBL_CUSTOMERS_P objcls_TBL_CUSTOMERS_P = null;
        public string maxID = "";

        public frm_TBL_CUSTOMERS()
        {
              InitializeComponent();
             
        }

        public frm_TBL_CUSTOMERS(String pID, bool pIs_DesturbanceOnce)
        {

            try
            {

                InitializeComponent();
                obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                objcls_TBL_CUSTOMERS_P = new cls_TBL_CUSTOMERS_P(this, pID, obj_GenForm, pIs_DesturbanceOnce);
                obj_GenForm.Formatting();
              
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

                objcls_TBL_CUSTOMERS_P.selection("A", "");

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

                objcls_TBL_CUSTOMERS_P.Referesh("False");

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

                objcls_TBL_CUSTOMERS_P.Referesh("True");

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

                objcls_TBL_CUSTOMERS_P.Delete();

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
               

                

                objcls_TBL_CUSTOMERS_P.Save();

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



        private void frm_TBL_CUSTOMERS_KeyDown(object sender, KeyEventArgs e)
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


        private void TextEdit_CUSTOMER_ID_Leave(object sender, EventArgs e)
        {

            try
            {

                if (DBStatus == 'U')
                    TextEdit_CUSTOMER_ID.Text = maxID;
                else
                {
                    if (CheckEdit_Is_AutoGenegereted.Checked)
                        TextEdit_CUSTOMER_ID.Text = maxID;
                }

            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }
        }

        private void TextEdit_CUSTOMER_ID_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {

                if (e.KeyData == Keys.Enter)
                {

                    if (TextEdit_CUSTOMER_ID.Text != "")
                        objcls_TBL_CUSTOMERS_P.selection("V", TextEdit_CUSTOMER_ID.Text.Trim());
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
                    objcls_TBL_CUSTOMERS_P.selection("N", x.ToString());
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
                    objcls_TBL_CUSTOMERS_P.Referesh("False");
            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }

        }





        private void GridLookUpEdit_CUSTOMER_vehicleMaker_KeyDown(object sender, KeyEventArgs e)
        {
              if (e.Control && e.Shift && e.KeyCode == Keys.A)
                    objcls_TBL_CUSTOMERS_P.loadGridLookUpEdit("TBL_VEHICLE_MAKERS");
              else if (e.Control && e.KeyCode == Keys.A)
              {
                    GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VEHICLE_MAKERS("N", false, false, true);
                    objcls_TBL_CUSTOMERS_P.loadGridLookUpEdit("TBL_VEHICLE_MAKERS");
              }
              else if (e.Control && e.KeyCode == Keys.U)
              {
                    try
                    {
                          GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VEHICLE_MAKERS(GridLookUpEdit_CUSTOMER_vehicleMaker.EditValue.ToString(), false, false, true);
                          objcls_TBL_CUSTOMERS_P.loadGridLookUpEdit("TBL_VEHICLE_MAKERS");

                    }
                    catch
                    {

                    }

              }

        }




        private void GridLookUpEdit_CUSTOMER_department_KeyDown(object sender, KeyEventArgs e)
        {
                    if (e.Control && e.KeyCode == Keys.A)
                    {
                                GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_DEPARTMENTS("N", false, false, true);
                                objcls_TBL_CUSTOMERS_P.loadGridLookUpEdit("TBL_DEPARTMENTS");
                    }
                    else if (e.Control && e.KeyCode == Keys.U)
                    {
                                try
                                {
                                            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_DEPARTMENTS(GridLookUpEdit_CUSTOMER_department.EditValue.ToString(), false, false, true);
                                            objcls_TBL_CUSTOMERS_P.loadGridLookUpEdit("TBL_DEPARTMENTS");

                                }
                                catch
                                {

                                }

                    }

        }

        private void frm_TBL_CUSTOMERS_Load(object sender, EventArgs e)
        {
            ComboBoxEdit_CUSTOMER_year.SelectedIndex = 0;
        }

    }



}