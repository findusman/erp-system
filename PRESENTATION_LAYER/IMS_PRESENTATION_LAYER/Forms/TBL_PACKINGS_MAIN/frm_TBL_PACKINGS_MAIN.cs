using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Forms.TBL_PACKINGS_MAIN
{
    public partial class frm_TBL_PACKINGS_MAIN : DevExpress.XtraEditors.XtraForm
    {

        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


        GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;
       public DataTable DtpackingDef = new DataTable();
        public char DBStatus = 'I';
        cls_TBL_PACKINGS_MAIN_P objcls_TBL_PACKINGS_MAIN_P = null;
        public string maxID = "";
        public frm_TBL_PACKINGS_MAIN()
        {
              InitializeComponent();
             
        }

        public frm_TBL_PACKINGS_MAIN(String pID, bool pIs_DesturbanceOnce)
        {

            try
            {

                InitializeComponent();
                obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                objcls_TBL_PACKINGS_MAIN_P = new cls_TBL_PACKINGS_MAIN_P(this, pID, obj_GenForm, pIs_DesturbanceOnce);
                obj_GenForm.Formatting();
                obj_GenForm.Appreance();
                BindTree();
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

                objcls_TBL_PACKINGS_MAIN_P.selection("A", "");

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
                DtpackingDef.Rows.Clear();
                objcls_TBL_PACKINGS_MAIN_P.Referesh("False");

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

                objcls_TBL_PACKINGS_MAIN_P.Referesh("True");

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

                objcls_TBL_PACKINGS_MAIN_P.Delete();

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
                if (IsValidatedDefination())
                {
                    objcls_TBL_PACKINGS_MAIN_P.Save();
                }

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



        private void frm_TBL_PACKINGS_MAIN_KeyDown(object sender, KeyEventArgs e)
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


        private void TextEdit_PACKING_MAIN_ID_Leave(object sender, EventArgs e)
        {

            try
            {

                if (DBStatus == 'U')
                    TextEdit_PACKING_MAIN_ID.Text = maxID;
                else
                {
                    if (CheckEdit_Is_AutoGenegereted.Checked)
                        TextEdit_PACKING_MAIN_ID.Text = maxID;
                }

            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }
        }

        private void TextEdit_PACKING_MAIN_ID_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {

                if (e.KeyData == Keys.Enter)
                {

                    if (TextEdit_PACKING_MAIN_ID.Text != "")
                        objcls_TBL_PACKINGS_MAIN_P.selection("V", TextEdit_PACKING_MAIN_ID.Text.Trim());
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
                    objcls_TBL_PACKINGS_MAIN_P.selection("N", x.ToString());
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
                    objcls_TBL_PACKINGS_MAIN_P.Referesh("False");
            }
            catch (Exception ex)
            {
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
            }

        }





        private void GridLookUpEdit_PACKING_MAIN_parentUnit_KeyDown(object sender, KeyEventArgs e)
        {
                    if (e.Control && e.KeyCode == Keys.A)
                    {
                                GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_UNITS("N", false, false, true);
                    }
                    else if (e.Control && e.KeyCode == Keys.U)
                    {
                                try
                                {
                                            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_UNITS(GridLookUpEdit_PACKING_MAIN_parentUnit.EditValue.ToString(), false, false, true);
                                            objcls_TBL_PACKINGS_MAIN_P.loadGridLookUpEdit("TBL_UNITS");

                                }
                                catch
                                {

                                }

                    }

        }

        void BindTree()
        {
            try
            {
                DtpackingDef.Columns.Add("ParentID", typeof(String));
                DtpackingDef.Columns.Add("UID", typeof(String));
                DtpackingDef.Columns.Add("Unit", typeof(String));
                DtpackingDef.Columns.Add("Qty", typeof(Int32));
                DtpackingDef.Columns.Add("Level", typeof(Int32));
               
                treeList1.DataSource = DtpackingDef;
                treeList1.ParentFieldName = "ParentID";
                treeList1.KeyFieldName = "UID";
                treeList1.OptionsBehavior.AllowExpandOnDblClick = true;
                treeList1.Columns["Level"].Visible = false;
              
                DATASET.IMS_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();


                obj_cls_DataSet.f_TBL_UNITS("L", "");
                DataSet ds = obj_cls_DataSet.g_TBL_UNITS;




                treeList1.Columns["Unit"].ColumnEdit =

                GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(
               BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
              BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                "Names",
                "ID",
                ds.Tables[0],
                  BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.UNIT_name,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopHeightlarge,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryLookUpEditPopWidthlarge,
                100,
              BLL.IMS_BLL.TBL_UNITS.cls_CTBL_UNITS.priUNIT_ID,
                false,
                true,
                   false

                );
            }
            catch { }

        }

        Boolean IsValidatedDefination(TreeListNode _node = null)
        {
            //try
            //{



         
             
                
            //    if (treeList1.Nodes.Count > 0)
            //    {
                  
            //        for(int i = 0; i< treeList1.AllNodesCount ; i++)
            //        {

                       
            //            _node = treeList1.GetNodeByVisibleIndex(i);



            //        if (_node == null)
            //        {
            //            return false;

            //        }

            //        if (_node.GetValue("Unit").ToString() == String.Empty)
            //        {
            //            XtraMessageBox.Show("Unit Cannot Be Empty!", "IM MS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return false;
            //        }

            //        if (_node.GetValue("Qty").ToString() == "0" || _node.GetValue("Qty").ToString() == String.Empty)
            //        {
            //            XtraMessageBox.Show("Qty Cannot Be Zero or Empty!", "IM MS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            _node.SetValue("Qty","1");
            //            return false;
            //        }


            //        if (_node.Level == 0)
            //        {
            //            if (_node.GetValue("Unit") != GridLookUpEdit_PACKING_MAIN_parentUnit.EditValue)
            //            {
            //                //_node.SetValue("Unit", GridLookUpEdit_PACKING_MAIN_parentUnit.EditValue);

            //            }
            //        }
            //        else
            //        {

            //            if (_node.ParentNode != null)
            //            {

            //                if (_node.GetValue("Unit").ToString() == _node.ParentNode.GetValue("Unit").ToString())
            //                {
            //                    _node.SetValue("Unit", "");
            //                    return false;

            //                }



            //                TreeListNode tempNode = _node.ParentNode;
            //                if (tempNode.ParentNode != null)
            //                {

            //                    if (_node.GetValue("Unit").ToString() == tempNode.ParentNode.GetValue("Unit").ToString())
            //                    {
            //                        _node.SetValue("Unit", "");
            //                        return false;
            //                    }
                               

            //                }



            //            }
            //            if (_node.LastNode != null)
            //            {

            //                if (_node.GetValue("Unit").ToString() == _node.LastNode.GetValue("Unit").ToString())
            //                {
            //                    _node.LastNode.SetValue("Unit", "");
            //                    return false;
            //                }
                      
            //            }


            //        }
            //        }

                    
            //    }

             


            //}


                 

            //catch { }
            return true;

        }
        void AddNodes()
        {
            try
            {
                        
                 DtpackingDef.Rows.Clear();
                 DtpackingDef.Rows.Add("N", "1", GridLookUpEdit_PACKING_MAIN_parentUnit.EditValue.ToString(), 0,1);

                    for (int i = 1; i < Convert.ToInt32(ComboBoxEdit_PACKING_MAIN_maxLevel.Text); i++)
                    {

                                DtpackingDef.Rows.Add(i, i + 1, GridLookUpEdit_PACKING_MAIN_parentUnit.Properties.GetKeyValue(0), 1,(i+1));
                       
                    }
                        
                    
                
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            AddNodes();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
             
          
        }

        private void treeList1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

            IsValidatedDefination(e.Node);
        }

        private void treeList1_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            
        }

        private void ComboBoxEdit_PACKING_MAIN_maxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (DtpackingDef != null)
            //{
            //    if (DtpackingDef.Rows.Count > 0)
            //    {
            //        AddNodes();
            //    }
            //}

        }

        private void frm_TBL_PACKINGS_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
                    DtpackingDef.Rows.Clear();
        }

    }



}