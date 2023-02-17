
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
using PRESENTATION_LAYER;


namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.COA
{
      public partial class frm_COA : DevExpress.XtraEditors.XtraForm
      {

            string previous_Level_no = "";
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView objGenGrid = null;
            GEN.GEN_GEN.GenericClasses.Form.Gen_Form objGenForm = null;
            cls_COA_P objcls_COA_P = null;
            public Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false, isAllowDeletionForCurrentNode = false, isAllowUpdationForCurrentNode = false;

            
            public frm_COA()
            {

                  this.Tag = this.Name;
                  InitializeComponent();

                  objcls_COA_P = new cls_COA_P(this);
                  objGenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                  objGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(TL_COA);


                  objGenForm.Appreance();
                  //  objGenForm.Formatting();
                  //objGenGrid.Formatting();
                  objGenGrid.Apperance("I");

            }

            Boolean CellValueChangeMode = false;

            private void XtraForm1_Load(object sender, EventArgs e)
            {
                  TL_COA.OptionsSelection.EnableAppearanceFocusedCell = true;
                  try
                  {

                        //DataRow[] drr = MDI.dtRightsButton.Select(" [Parent Key] = '" + this.Tag + "'");
                        //foreach (DataRow d in drr)
                        //{
                        //    if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_del == d["Primary Key"].ToString())
                        //         {
                        //             isAllowedDeletion = true;
                        //         }
                        //         else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_insert == d["Primary Key"].ToString())
                        //         {
                        //             isAllowedInsertion = true;
                        //         }
                        //         else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_update == d["Primary Key"].ToString())
                        //         {
                        //             isAllowedUpdation = true;
                        //         }
                        //}

                  }
                  catch
                  {
                        //throw;
                  }

                  if (!isAllowedDeletion)
                        this.simpleButton4.Enabled = false;

            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {
                  newNode("Sibling");
            }

            private void treeList1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
            {

                  objcls_COA_P.InsertValues(null, "Updation", "N", 0);


                  //if (TL_COA.FocusedColumn.FieldName == cls_CTBL_COA.COA_levelID)
                  //{

                  //    string str =  e.Node.GetValue(cls_CTBL_COA.COA_levelID).ToString();
                  //    string temp_UID = "";
                  //    if (CurrentNodeLevel == 0)
                  //    {
                  //        temp_UID = cls_GACCFunctions.getCompleteCOAID(cls_ACCGlobalClass.GV_format, str, CurrentNodeLevel);
                  //    }
                  //    else
                  //    {

                  //        string temp_ParentId = e.Node.GetValue(cls_CTBL_COA.COA_PARENTID).ToString();
                  //        temp_UID = cls_GACCFunctions.getCompleteCOAID(temp_ParentId, str, CurrentNodeLevel);

                  //    }

                  //    //  if (CellValueChangeMode)
                  //    e.Node.SetValue(cls_CTBL_COA.COA_UID, temp_UID);

                  //}

                  // e.Node.SetValue(cls_CTBL_COA.COA_A_isSaved, false);
            }
            public int CurrentNodeLevel = 0;

            private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
            {
                  try
                  {
                        objcls_COA_P.focusedNodeChanged(e.Node);
                        CurrentNodeLevel = e.Node.Level;

                  }
                  catch (Exception ex)
                  {

                  }
            }

            void newNode(string pChildOrSbling)
            {



                  objcls_COA_P.InsertValues(null, "Updation", "N", 0);

                  int temp_Get_Max = 0;
                  int tmp_COA_type = GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_TYPE_defaultType;

                  if (pChildOrSbling == "Sibling")
                  {

                        if (CurrentNodeLevel <= GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_maxLevel)
                        {

                              string temp_ParentId = string.Empty;
                              string temp_Nature = string.Empty;

                              if (CurrentNodeLevel == 0)
                              {
                                    temp_ParentId = GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_format;
                                    temp_Nature = "Debit";
                              }
                              else
                              {

                                    TreeListNode tempNode = TL_COA.FocusedNode;
                                    temp_ParentId = tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_PARENTID).ToString();
                                    temp_Nature = tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature).ToString();
                                    tmp_COA_type = Convert.ToInt16(tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type).ToString());
                              }

                              int temp_PlanId = Convert.ToInt16(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[CurrentNodeLevel][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_ACC_PLAN_DEF.TBL_ACC_PLAN_DEF_ID].ToString());



                              if (objcls_COA_P.addNewNode(temp_ParentId, CurrentNodeLevel, temp_PlanId, temp_Nature, tmp_COA_type))
                                    objcls_COA_P.InsertValues(null, "Insertion", pChildOrSbling, temp_PlanId);

                        }
                  }
                  else if (pChildOrSbling == "Child")
                  {
                        if (TL_COA.Nodes.Count == 0)
                              return;

                        if (CurrentNodeLevel >= GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_maxLevel - 1)
                              return;

                        if (TL_COA.Nodes.Count != 0)
                        {
                              CurrentNodeLevel++;
                        }

                        string temp_ParentId = string.Empty;
                        string temp_nature = string.Empty;

                        int temp_focusedIndex = 0;
                        if (CurrentNodeLevel == 0)
                        {
                              temp_ParentId = GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GV_format;
                              temp_nature = "Debit";
                        }
                        else
                        {

                              TreeListNode tempNode = TL_COA.FocusedNode;
                              temp_ParentId = tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID).ToString();
                              temp_nature = tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_nature).ToString();
                              tmp_COA_type = Convert.ToInt16(tempNode.GetValue(PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_type).ToString());

                        }

                        int temp_PlanId = Convert.ToInt16(GEN.ACC_GEN.Generics.cls_ACCGlobalClass.GT_LevelInformation.Rows[(CurrentNodeLevel - 1)][PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_ACC_PLAN_DEF.TBL_ACC_PLAN_DEF_ID].ToString());
                        if (objcls_COA_P.addNewNode(temp_ParentId, CurrentNodeLevel, temp_PlanId, temp_nature, tmp_COA_type))
                              objcls_COA_P.InsertValues(null, "Insertion", pChildOrSbling, temp_PlanId);


                  }
            }
            private void simpleButton2_Click(object sender, EventArgs e)
            {

                  newNode("Child");
            }

            private void TL_COA_EditorKeyDown(object sender, KeyEventArgs e)
            {

                  //if ((e.KeyData == Keys.Enter) | e.KeyData == (Keys.Control | Keys.S))
                  //{

                  //    //objcls_COA_P.InsertValues(null, "Insertion","N");

                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.Delete))
                  //{

                  //    objcls_COA_P.deleteCOA();

                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.P))
                  //{

                  //    newNode("Sibling");

                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.N))
                  //{

                  //    newNode("Child");

                  //}




            }

            private void TL_COA_KeyDown(object sender, KeyEventArgs e)
            {
                  //if ((e.KeyData == Keys.Enter) | e.KeyData == (Keys.Control | Keys.S))
                  //{

                  //    objcls_COA_P.InsertValues(null, "Insertion","N");


                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.Delete))
                  //{

                  //    objcls_COA_P.deleteCOA();

                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.P))
                  //{

                  //    newNode("Sibling");

                  //}
                  //else if (e.KeyData == (Keys.Control | Keys.N))
                  //{

                  //    newNode("Child");

                  //}


            }

            private void simpleButton3_Click(object sender, EventArgs e)
            {

                  //MessageBox.Show(objcls_COA_P.);

                  //PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA.Rows.Clear();
                  //CurrentNodeLevel = 0;
            }

            private void simpleButton4_Click(object sender, EventArgs e)
            {


                  objcls_COA_P.deleteCOA();

            }

            bool GV_IsLoading = false;

            private void simpleButton5_Click(object sender, EventArgs e)
            {
                  CurrentNodeLevel = 0;
                  GV_IsLoading = true;
                  objcls_COA_P.loadCOA();
                  //DataTable dt =  objcls_COA_P.getValues();
                  //PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.initiateCOATable(TL_COA, dt);
                  GV_IsLoading = false;


            }

            private void TL_COA_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
            {
                  //string str = (string)e.Value;
                  //e.Node.SetValue(e.Column, e.Value);

            }
            private void frm_COA_KeyDown(object sender, KeyEventArgs e)
            {
                  objGenForm.ShortKey(e);
            }

            private void TL_COA_Click(object sender, EventArgs e)
            {
                  //TL_COA.FocusedNode.ExpandAll();


                  //if (TL_COA.FocusedColumn.FieldName == "D")
                  //{
                  //    objcls_COA_P.deleteCOA();
                  //}

            }

            private void RadioGroup_expandCollapse_SelectedIndexChanged(object sender, EventArgs e)
            {


            }
      }
}