using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Lists.LastSales_byVehicleNumber
{
      public partial class frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGen_Form;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;
            public frm_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection()
            {
                  InitializeComponent();
                  initialize();
            }

            private void frm_rpt_Ledger_Load(object sender, EventArgs e)
            {


                  initialize();


            }

            void bingGrid()
            {

               //   ACC_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_COA_FinancialAndTransaction(GridLookUpEdit_COA, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name);

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
                        this.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter.Fill(
                              dataSet_sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection.sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selection,
                          GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                        TextEdit_vehicleNumber.Text
                          );


                        //sp_rpt_LedgerTableAdapter.Fill(
                        //    sp_rpt_Ledger._sp_rpt_Ledger,
                        //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                        //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                        //    DateEdit_fromDate.DateTime.Date,
                        //    DateEdit_toDate.DateTime.Date,
                        //    GridLookUpEdit_COA.EditValue.ToString(),
                           // false);
                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }

                 
                  ObjGenGrid.Formatting();
                  this.Text = "Vehile : " + TextEdit_vehicleNumber.Text;


            }

            void referesh()
            {
                  ObjGen_Form.GenRefresh();
                  this.Text = "Vehile : ";
                  

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

                  sp_TBL_SALES_AND_RETURN_MAIN_by_vihicleNumber_selectionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;

                  bingGrid();

                  ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(GridView_TBL_VCH_DETAILS, GridControl_TBL_VCH_DETAILS);
                  ObjGenGrid.Apperance("List_With_No_Sort");
                  ObjGenGrid.isAllowDeleteColumns = false;
                  ObjGenGrid.Formatting();

                  ObjGen_Form = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                  ObjGen_Form.Formatting();
                  ObjGen_Form.GenRefresh();



            }

            private void GridView_TBL_VCH_DETAILS_DoubleClick(object sender, EventArgs e)
            {
                try
                {


                    int x = GridView_TBL_VCH_DETAILS.FocusedRowHandle;
                    string ID = GridView_TBL_VCH_DETAILS.GetRowCellValue(x, "SALES_AND_RETURN_MAIN_ID").ToString();

                    //  uc_TBL_COA_fromCodeToCode1

                    IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Sales");




                }
                catch (Exception ex)
                {


                }
            }

      }
}