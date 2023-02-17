using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using BLL.GEN_BLL.TBL_RIGHTS_TEMPLATE;


namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms.TBL_RIGHTS_TEMPLATE
{
      public partial class frm_TBL_RIGHTS_TEMPLATE : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;

            public char DBStatus = 'I';
            cls_TBL_RIGHTS_TEMPLATE_P objcls_TBL_RIGHTS_TEMPLATE_P = null;
            public string maxID = "";

            RepositoryItemDateEdit RepositoryItemDateEdit = new RepositoryItemDateEdit();
            RepositoryItemCheckEdit RepositoryItemCheckEdit = new RepositoryItemCheckEdit();
            RepositoryItemSpinEdit RepositoryItemSpinEdit = new RepositoryItemSpinEdit();
            RepositoryItemMemoEdit RepositoryItemMemoEdit = new RepositoryItemMemoEdit();


            public frm_TBL_RIGHTS_TEMPLATE()
            {
                  InitializeComponent();

            }
            public frm_TBL_RIGHTS_TEMPLATE(String pID, bool pIs_DesturbanceOnce)
            {

                  try
                  {

                        InitializeComponent();
                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        objcls_TBL_RIGHTS_TEMPLATE_P = new cls_TBL_RIGHTS_TEMPLATE_P(this, pID, obj_GenForm, pIs_DesturbanceOnce);
                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
                        RepositoryItemCheckEdit.ValueChecked = "True";
                        RepositoryItemCheckEdit.ValueUnchecked = "False";
                        RepositoryItemCheckEdit.NullText = "";


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

                        objcls_TBL_RIGHTS_TEMPLATE_P.selection("A", "");

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

                        objcls_TBL_RIGHTS_TEMPLATE_P.Referesh("False");

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

                        objcls_TBL_RIGHTS_TEMPLATE_P.Referesh("True");

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

                        objcls_TBL_RIGHTS_TEMPLATE_P.Delete();

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

                        objcls_TBL_RIGHTS_TEMPLATE_P.Save(false);

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



            private void frm_TBL_RIGHTS_TEMPLATE_KeyDown(object sender, KeyEventArgs e)
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


            private void TextEdit_RIGHTS_TEMPLATE_ID_Leave(object sender, EventArgs e)
            {

                  try
                  {

                        if (DBStatus == 'U')
                              TextEdit_RIGHTS_TEMPLATE_ID.Text = maxID;
                        else
                        {
                              if (CheckEdit_Is_AutoGenegereted.Checked)
                                    TextEdit_RIGHTS_TEMPLATE_ID.Text = maxID;
                        }

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void TextEdit_RIGHTS_TEMPLATE_ID_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        if (e.KeyData == Keys.Enter)
                        {

                              if (TextEdit_RIGHTS_TEMPLATE_ID.Text != "")
                                    objcls_TBL_RIGHTS_TEMPLATE_P.selection("V", TextEdit_RIGHTS_TEMPLATE_ID.Text.Trim());
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
                              objcls_TBL_RIGHTS_TEMPLATE_P.selection("N", x.ToString());
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
                              objcls_TBL_RIGHTS_TEMPLATE_P.Referesh("False");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }





            private void GridLookUpEdit_RIGHTS_TEMPLATE_parentKey_KeyDown(object sender, KeyEventArgs e)
            {
                  //if (e.Control && e.Shift && e.KeyCode == Keys.R)
                  //            objcls_TBL_RIGHTS_TEMPLATE_P.loadGridLookUpEdit("TBL_RIGHTS_TEMPLATE");

                  //    else if (e.Control  && e.KeyCode == Keys.A)
                  //       {
                  //        GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_TEMPLATE("N", false, false, true);
                  //  objcls_TBL_RIGHTS_TEMPLATE_P.loadGridLookUpEdit("TBL_RIGHTS_TEMPLATE");

                  //       }
                  //    else if (e.Control && e.KeyCode == Keys.U)
                  //    {
                  //        try
                  //        {
                  //            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_TEMPLATE(GridLookUpEdit_                  RIGHTS_TEMPLATE_parentKey.EditValue.ToString(), false, false, true);
                  //            objcls_TBL_RIGHTS_TEMPLATE_P.loadGridLookUpEdit("TBL_RIGHTS_TEMPLATE");



                  //        }
                  //        catch
                  //        { 

                  //        }

                  //}

            }

            private void DateEdit_date_EditValueChanged(object sender, EventArgs e)
            {
                  
            }

            private void CheckEdit_edit_CheckedChanged(object sender, EventArgs e)
            {
                  

            }

            private void TL_COA_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
            {

            }

            private void checkEdit1_CheckedChanged(object sender, EventArgs e)
            {
                  GridLookUpEdit_RIGHTS_TEMPLATE_parentKey.Enabled = !checkEdit1.Checked;
            }

            private void SimpleButton_createAdminITRight_Click(object sender, EventArgs e)
            {
                  objcls_TBL_RIGHTS_TEMPLATE_P.loadTemplateToRightsTableAndAddAdmin();
            }

            private void TreeList_valueBase_CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
            {

                  //if (e.Column.FieldName == cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_defaultValue)
                  //{

                  //      TreeList obj_TreeList = (TreeList)sender;
                  //      //DevExpress.XtraTreeList.Nodes.TreeListNode obj_TreeListNode = obj_TreeList.FocusedNode;


                  //      string value = (string)e.Node[cls_CTBL_RIGHTS_TEMPLATE.RIGHTS_TEMPLATE_valueType];


                  //      switch (value)
                  //      {
                  //            case "DateTime":
                  //                  e.RepositoryItem = RepositoryItemDateEdit;
                  //                  break;
                  //            case "Bool":
                  //                  e.RepositoryItem = RepositoryItemCheckEdit;
                  //                  break;
                  //            case "Int":
                  //                  e.RepositoryItem = RepositoryItemSpinEdit;
                  //                  break;
                  //            case "Float":
                  //                  e.RepositoryItem = RepositoryItemSpinEdit;
                  //                  break;
                  //            case "String":
                  //                  e.RepositoryItem = RepositoryItemMemoEdit;
                  //                  break;

                  //      }
                  //}

            }

            private void frm_TBL_RIGHTS_TEMPLATE_Load(object sender, EventArgs e)
            {

            }

            private void ComboBoxEdit_RIGHTS_TEMPLATE_visibleTypeOrValueType_SelectedIndexChanged(object sender, EventArgs e)
            {
                  if (ComboBoxEdit_RIGHTS_TEMPLATE_visibleTypeOrValueType.SelectedItem.ToString() == "Value")
                  {
                        ComboBoxEdit_RIGHTS_TEMPLATE_valueType.Enabled = DateEdit_date.Enabled = CheckEdit_edit.Enabled = true;
                        ComboBoxEdit_RIGHTS_TEMPLATE_nature.Enabled = false;
                        ComboBoxEdit_RIGHTS_TEMPLATE_nature.EditValue = "Action";
                        getDefaultValues();
                  }
                  else
                  {
                        ComboBoxEdit_RIGHTS_TEMPLATE_valueType.Enabled = DateEdit_date.Enabled = CheckEdit_edit.Enabled = false;
                        ComboBoxEdit_RIGHTS_TEMPLATE_nature.Enabled = true;
                        //ComboBoxEdit_RIGHTS_TEMPLATE_nature.SelectedIndex = 0;
                        
                  }
            }


            void getDefaultValues()
            {

                  if (ComboBoxEdit_RIGHTS_TEMPLATE_valueType.SelectedItem.ToString() == "DateTime")
                  {
                        DateEdit_date.Enabled = true;
                        CheckEdit_edit.Enabled = false;
                        TextEdit_RIGHTS_TEMPLATE_defaultValue.Enabled = false;
                  }
                  else if (ComboBoxEdit_RIGHTS_TEMPLATE_valueType.SelectedItem.ToString() == "Bool")
                  {
                        DateEdit_date.Enabled = false;
                        CheckEdit_edit.Enabled = true;
                        TextEdit_RIGHTS_TEMPLATE_defaultValue.Enabled = false;
                  }
                  else 
                  {
                        DateEdit_date.Enabled = false;
                        CheckEdit_edit.Enabled = false;
                        TextEdit_RIGHTS_TEMPLATE_defaultValue.Enabled = true;
                  }
                 
                 

            }

            private void ComboBoxEdit_RIGHTS_TEMPLATE_valueType_SelectedIndexChanged(object sender, EventArgs e)
            {

                     getDefaultValues();
                
            }

            private void SimpleButton_loadMDiRights_Click(object sender, EventArgs e)
            {
                  try
                  {
                      // objcls_TBL_RIGHTS_TEMPLATE_P.loadRightsFromMDI_recursiveParent();

                        objcls_TBL_RIGHTS_TEMPLATE_P.Save(true);

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            private void xtraTabControl2_Click(object sender, EventArgs e)
            {

            }

           
      }


}