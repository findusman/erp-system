using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Reports.TrialBalance
{
      public partial class frm_rpt_TrialBalance : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGen_Form;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;



            public frm_rpt_TrialBalance()
            {
                  InitializeComponent();
                 // initialize();
            }



          


            private void frm_rpt_Ledger_Load(object sender, EventArgs e)
            {


                  initialize();


            }

            void bingGrid()
            {

                 
            }


            private void simpleButton2_Click(object sender, EventArgs e)
            {
                  try
                  {
                        referesh();

                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }
            }

            void loadData()
            {
                  try
                  {



                        sp_TrialBlance_selectionTableAdapter.Fill(
                              ds_TrialBalanceMultiLevel.sp_TrialBlance_selection,
                              GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                           "", //uc_TBL_COA_fromCodeToCode1.GridLookUpEdit_fCode.EditValue.ToString(),
                            "",//.uc_TBL_COA_fromCodeToCode1.GridLookUpEdit_tCode.EditValue.ToString(),
                            uc_TBL_COA_fromCodeToCode1.DateEdit_fromDate.DateTime.Date,
                            uc_TBL_COA_fromCodeToCode1.DateEdit_toDate.DateTime.Date,
                            1,//Convert.ToInt16(RadioGroup_expandCollapse.EditValue.ToString()),
                            "1",
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted
                            );






                        
                        //sp_rpt_LedgerTableAdapter.Fill(
                        //    sp_rpt_Ledger._sp_rpt_Ledger,
                        //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                        //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                        //    DateEdit_fromDate.DateTime.Date,
                        //    DateEdit_toDate.DateTime.Date,
                        //    GridLookUpEdit_COA.EditValue.ToString(),
                        //    false);
                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }

                  //if (sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count > 0)
                  //      LabelControl_TextEdit_VCH_reference.Text = "Balance : " + ((double)sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["RunningSum"]).ToString("N2") + " " + sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["Type"].ToString();
                  //else
                  //      LabelControl_TextEdit_VCH_reference.Text = "Balance : ";
                  //ObjGenGrid.Formatting();
                  //this.Text = "Ledger : " + GridLookUpEdit_COA.Text;


            }

            void referesh()
            {
                  ObjGen_Form.GenRefresh();
                  //this.Text = "Ledger : ";
                  ds_TrialBalanceMultiLevel.sp_TrialBlance_selection.Rows.Clear();

            }

            private void simpleButton1_Click(object sender, EventArgs e)
            {

                  try
                  {
                        loadData();
                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }

            }

            private void button1_Click(object sender, EventArgs e)
            {
                  uc_NAVBARCONTROl1.collapseExpand(false, 300);
            }


            void initialize()
            {
                  uc_TBL_COA_fromCodeToCode1.loadGrid();

                  sp_TrialBlance_selectionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;

                  bingGrid();

                  ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(bandedGridView1, GridControl_SALES_AND_RETURN_DETAILS);
                  ObjGenGrid.Apperance("List_With_No_Sort");
                  ObjGenGrid.isAllowDeleteColumns = false;
                  ObjGenGrid.Formatting();

                  ObjGen_Form = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                  ObjGen_Form.Formatting();
                  //ObjGen_Form.GenRefresh();


            }

            private void RadioGroup_expandCollapse_SelectedIndexChanged(object sender, EventArgs e)
            {
                  uc_TBL_COA_fromCodeToCode1.Pro_COA_levelNo = Convert.ToInt16( RadioGroup_expandCollapse.EditValue.ToString());
                  uc_TBL_COA_fromCodeToCode1.loadGrid();
            }

            private void bandedGridView1_DoubleClick(object sender, EventArgs e)
            {

                try
                {

                    if (RadioGroup_expandCollapse.EditValue.ToString() == "4")
                    {

                        int x = bandedGridView1.FocusedRowHandle;
                        string ID = bandedGridView1.GetRowCellValue(x, "COA_UID").ToString();

                        //  uc_TBL_COA_fromCodeToCode1

                        ACC_PRESENTATION_LAYER.cls_ShowReportEntities.Ledger(ID, uc_TBL_COA_fromCodeToCode1.DateEdit_fromDate.DateTime.Date,
                                uc_TBL_COA_fromCodeToCode1.DateEdit_toDate.DateTime.Date, true, false);



                    }
                }
                catch( Exception ex)
                {
                

                }

            }

      }
}