using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_SALES_AND_RETURN_MAIN
{
      public partial class frm_TBL_SALES_AND_RETURN_MAIN : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;

            public char DBStatus = 'I';
            cls_TBL_SALES_AND_RETURN_MAIN_P objcls_TBL_SALES_AND_RETURN_MAIN_P = null;
            public string maxID = "";
            bool idFormLoaded = false;
            public frm_TBL_SALES_AND_RETURN_MAIN()
        {
            InitializeComponent();
        }
            public frm_TBL_SALES_AND_RETURN_MAIN(String pID, bool pIs_DesturbanceOnce, string pSALES_AND_RETURN_MAIN_cashOrCredit, string pSALES_AND_RETURN_MAIN_SALESOrReturn)
            {

                  try
                  {

                        InitializeComponent();

                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(this.GridView_SALES_AND_RETURN_DETAILS, this.GridControl_SALES_AND_RETURN_DETAILS);
                        objcls_TBL_SALES_AND_RETURN_MAIN_P = new cls_TBL_SALES_AND_RETURN_MAIN_P(this, pID, obj_GenForm, ObjGenGrid, pIs_DesturbanceOnce, pSALES_AND_RETURN_MAIN_cashOrCredit, pSALES_AND_RETURN_MAIN_SALESOrReturn);

                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
                        ObjGenGrid.Apperance("I");
                        idFormLoaded = true;
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product ID");
                        GridView_SALES_AND_RETURN_DETAILS.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
      


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

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.selection("A", "");

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
                        

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.Referesh("False");

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

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.Referesh("True");

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

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.Delete();

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

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.Save(false);

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



            private void frm_TBL_SALES_AND_RETURN_MAIN_KeyDown(object sender, KeyEventArgs e)
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


            private void TextEdit_SALES_AND_RETURN_MAIN_ID_Leave(object sender, EventArgs e)
            {

                  try
                  {

                        if (DBStatus == 'U')
                              TextEdit_SALES_AND_RETURN_MAIN_ID.Text = maxID;
                        else
                        {
                              if (CheckEdit_Is_AutoGenegereted.Checked)
                                    TextEdit_SALES_AND_RETURN_MAIN_ID.Text = maxID;
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_SALES_AND_RETURN_MAIN_ID_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_SALES_AND_RETURN_MAIN_ID.Text != "")
                                    objcls_TBL_SALES_AND_RETURN_MAIN_P.selection("V", TextEdit_SALES_AND_RETURN_MAIN_ID.Text.Trim());
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
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.selection("N", x.ToString());
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
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.Referesh("False");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }





            private void GridLookUpEdit_SALES_AND_RETURN_MAIN_supplierID_KeyDown(object sender, KeyEventArgs e)
            {
                  if (idFormLoaded)
                  {
                        if (e.Control && e.Shift && e.KeyCode == Keys.R)
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.loadGridLookUpEdit("TBL_SUPPLIERS");

                        else if (e.Control && e.KeyCode == Keys.A)
                        {
                              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_CUSTOMERS("N", false, false, true);
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.loadGridLookUpEdit("TBL_SUPPLIERS");

                        }
                        else if (e.Control && e.KeyCode == Keys.U)
                        {
                              try
                              {

                                    GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_CUSTOMERS(GridLookUpEdit_SALES_AND_RETURN_MAIN_supplierID.EditValue.ToString(), false, false, true);
                                    objcls_TBL_SALES_AND_RETURN_MAIN_P.loadGridLookUpEdit("TBL_SUPPLIERS");


                              }
                              catch
                              {

                              }

                        }
                  }
            }

            private void frm_TBL_SALES_AND_RETURN_MAIN_Load(object sender, EventArgs e)
            {
                  
            }

            private void GridLookUpEdit_productsName_EditValueChanged(object sender, EventArgs e)
            {
                  if (idFormLoaded)
                  {
                        GridLookUpEdit_productsCode.EditValue = GridLookUpEdit_productsName.EditValue;
                        //objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product ID");
                  }
            }

            private void SimpleButton_addRow_Click(object sender, EventArgs e)
            {
                  if (idFormLoaded)
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.addRow();
            }

            private void GridView_SALES_AND_RETURN_DETAILS_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
            {
                  if (idFormLoaded)
                  {
                        try
                        {
                              //objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations();

                              if (e.Column.FieldName == cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY)
                              {

                                    string tmpQTY = GridView_SALES_AND_RETURN_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY).ToString();
                                    if (tmpQTY == "" || tmpQTY == "0")
                                          GridView_SALES_AND_RETURN_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY, "1");

                              }
                              else
                                    if (e.Column.FieldName == cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice)
                                    {

                                          string tmpRate = GridView_SALES_AND_RETURN_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice).ToString();
                                          if (tmpRate == "" || tmpRate == "0")
                                                GridView_SALES_AND_RETURN_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice, "1");

                                    }

                              if (e.Column.FieldName == cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_total)
                                    objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
                              if (e.Column.FieldName == BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN.cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice || e.Column.FieldName == BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN.cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY)
                              {

                                    double qty = (double)GridView_SALES_AND_RETURN_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY);
                                    double rate = (double)GridView_SALES_AND_RETURN_DETAILS.GetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice);
                                    GridView_SALES_AND_RETURN_DETAILS.SetRowCellValue(e.RowHandle, cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_total, (qty * rate));


                              }
                        }
                        catch (Exception ex)
                        { }
                  }
            }

            private void GridView_SALES_AND_RETURN_DETAILS_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                  if (idFormLoaded)
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void GridControl_SALES_AND_RETURN_DETAILS_Enter(object sender, EventArgs e)
            {
                  if (idFormLoaded)
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void GridControl_SALES_AND_RETURN_DETAILS_Leave(object sender, EventArgs e)
            {
                  if (idFormLoaded)
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void GridControl_SALES_AND_RETURN_DETAILS_Validated(object sender, EventArgs e)
            {
                  if (idFormLoaded)
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void TextEdit_SALES_AND_RETURN_MAIN_discountAmount_EditValueChanged(object sender, EventArgs e)
            {
                if (idFormLoaded)
                    objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void SimpleButton_listForInvoicesWhenReturnSelected_Click(object sender, EventArgs e)
            {
                  try
                  {

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.selectionInvoiceWhenReturnIsSelected("A", "");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_InvoiceIDWhenReturnSelected_Leave(object sender, EventArgs e)
            {


            }

            private void TextEdit_InvoiceIDWhenReturnSelected_KeyDown(object sender, KeyEventArgs e)
            {


                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_InvoiceIDWhenReturnSelected.Text != "")
                                    objcls_TBL_SALES_AND_RETURN_MAIN_P.selectionInvoiceWhenReturnIsSelected("V", TextEdit_InvoiceIDWhenReturnSelected.Text.Trim());
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }

            private void GridLookUpEdit_productsCode_EditValueChanged(object sender, EventArgs e)
            {
                  try
                  {
                        if (idFormLoaded)
                        {
                              GridLookUpEdit_productsName.EditValue = GridLookUpEdit_productsCode.EditValue;
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product ID");
                        }

                  }
                  catch (Exception ex)
                  { }
            }

            private void TextEdit_productsBarcode_EditValueChanged(object sender, EventArgs e)
            {

            }

            private void TextEdit_productsBarcode_KeyDown(object sender, KeyEventArgs e)
            {

            }

            private void CheckEdit_isAddedAutomatically_CheckedChanged(object sender, EventArgs e)
            {
                  CheckEdit_isAddedAutomatically.Tag =  CheckEdit_isAddedAutomatically.Checked ? "T" : "F";
            }

            private void CheckEdit_lastQTY_CheckedChanged(object sender, EventArgs e)
            {
                  CheckEdit_lastQTY.Tag = CheckEdit_lastQTY.Checked ? "T" : "F";
            }

            private void GridLookUpEdit_productsName_KeyDown(object sender, KeyEventArgs e)
            {

            }

            private void GridLookUpEdit_productsName_KeyDown_1(object sender, KeyEventArgs e)
            {
                  if (e.Control && e.KeyCode == Keys.A)
                  {
                        GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PRODUCTS("N", false, false, true);
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.loadGridLookUpEdit("TBL_PRODUCTS");
                        objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product ID");
               

                  }
                  else if (e.Control && e.KeyCode == Keys.U)
                  {
                        try
                        {
                              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_DEPARTMENTS(GridLookUpEdit_productsCode.EditValue.ToString(), false, false, true);
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.loadGridLookUpEdit("TBL_PRODUCTS");
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product ID");
               
                        }
                        catch
                        {

                        }

                  }
                  if (e.KeyCode == Keys.Enter)
                  {
                        try
                        {
                              objcls_TBL_SALES_AND_RETURN_MAIN_P.selectItemDetailsINfo("Single Product Info For Transaction Against Product Barcode");

                        }
                        catch
                        {

                        }

                  }


            }

            private void GridLookUpEdit_productsCostRateHistory_EditValueChanged(object sender, EventArgs e)
            {
                  try
                  {
                        
                        //objcls_TBL_SALES_AND_RETURN_MAIN_P.loadlastProductInforFromCostRateHistory();
                  }
                  catch (Exception ex)
                  { 
                  
                  }
            }

            private void GridLookUpEdit_productsUnits_EditValueChanged(object sender, EventArgs e)
            {
                  //objcls_TBL_SALES_AND_RETURN_MAIN_P.setRatesAgainstUnit(false);
            }

            private void GridLookUpEdit_productsUnits_EditValueChanged_1(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_SALES_AND_RETURN_MAIN_P.setRatesAgainstUnit(false);
                  }
                  catch (Exception ex)
                  {

                  }
                  
            }

            private void TextEdit_SALES_AND_RETURN_MAIN_paidAmount_Validated(object sender, EventArgs e)
            {
                //if (idFormLoaded)
                //    objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {
                //RadioGroud_printOrPreview.SelectedIndex = 0;
                try
                {

                    objcls_TBL_SALES_AND_RETURN_MAIN_P.Save(true);

                }
                catch (Exception ex)
                {
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                }
            }

            private void TextEdit_SALES_AND_RETURN_MAIN_totalPayableAmount_EditValueChanged(object sender, EventArgs e)
            {
                if (idFormLoaded)
                    objcls_TBL_SALES_AND_RETURN_MAIN_P.calculations(false);
            }
            
      }



}