using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Lists.DM.TBL_VCH_Details.frm_profitOrLoss
{
      public partial class frm_profitOrLoss_Report : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGen_Form;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid2;

            public frm_profitOrLoss_Report(DateTime pFromDate, DateTime ptoDate)
            {
                  InitializeComponent();
                  initialize();
            }

            public frm_profitOrLoss_Report()
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

                  //ACC_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_COA_FinancialAndTransaction(GridLookUpEdit_COA, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name);

            }


            private void simpleButton2_Click(object sender, EventArgs e)
            {
                  try
                  {
                        referesh();
                        //uc_Department_Product_FromDate_ToDate1.loadGrid();

                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }
            }

            void loadData()
            {


                  
               //"",
               //"",
               //PRODUCT_ID,
               //GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted

                  string str = null;

                  if (uc_Department_FromDate_ToDate1.GridLookUpEdit_departments.EditValue.ToString() != "-1")
                        str = uc_Department_FromDate_ToDate1.GridLookUpEdit_departments.EditValue.ToString();

                  //sp_TBL_DEPARTMENTS_parentAsStockSummaryReportTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;
                  //sp_TBL_STOCK_rpt_StockSummaryTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;


                  sp_profitOrLoss_DM_Lubricants_selectionTableAdapter.Fill(
                        dataSet_profitOrLoss.sp_profitOrLoss_DM_Lubricants_selection,
                          GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                         GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                        
                           uc_Department_FromDate_ToDate1.DateEdit_fromDate.DateTime.Date,
                           uc_Department_FromDate_ToDate1.DateEdit_toDate.DateTime.Date,

                       str, "", true, CheckEdit_addOpeningAsWell.Checked);


                  //sp_TBL_STOCK_rpt_StockSummaryTableAdapter.Fill(

                  //       dataSet_Item_Stock_Summary.sp_TBL_STOCK_rpt_StockSummary,
                  //       GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                  //       GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                  //       "",
                  //       "",//uc_Department_Product_FromDate_ToDate1.GridLookUpEdit_productName.EditValue.ToString(),
                  //        uc_Department_FromDate_ToDate1.DateEdit_fromDate.DateTime.Date,
                  //         uc_Department_FromDate_ToDate1.DateEdit_toDate.DateTime.Date,

                  //       "",
                  //       GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted

                  //       );



                  bandedGridView1.OptionsView.ShowFooter = false;
                  bandedGridView1.OptionsView.ShowColumnHeaders = false;





                 //if (dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows.Count > 0)
                 //{

                 //      string U1 = dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["U1_name"].ToString();
                 //      string U2 = dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["U2_name"].ToString();
                 //      string U3 = dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["U3_name"].ToString();
                 //      double Q1 = (double)dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["Opending_QTY1"];
                 //      double Q2 = (double)dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["Opending_QTY2"];
                 //      double Q3 = (double)dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["Opending_QTY3"];


                 //      string Packing = dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows[0]["PACKING_MAIN_name"].ToString();

                 //      colReceived_QTY1.Caption = colIssued_QTY1.Caption = colSTOCK_clostingQTY1.Caption = U1;
                 //      colReceived_QTY2.Caption = colIssued_QTY2.Caption = colSTOCK_clostingQTY2.Caption = U2;
                 //      colReceived_QTY3.Caption = colIssued_QTY3.Caption = colSTOCK_clostingQTY3.Caption = U3;

                 //      labelControl_name.Text = uc_Department_Product_FromDate_ToDate1.GridLookUpEdit_productName.Text + "( " + Packing + " )";

                 //      if (U1 != "")
                 //            labelControl_u1.Text = "Last " + U1 + " : " + Q1.ToString("n2");
                 //      else
                 //            labelControl_u1.Text = "";
                 //      if (U2 != "")
                 //      labelControl_u2.Text = "Last " + U2 + " : " + Q2.ToString("n2");
                 //      else
                 //            labelControl_u2.Text = "";
                 //      if (U3 != "")
                 //      labelControl_u3.Text = "Last " + U3 + " : " + Q3.ToString("n2");
                 //      else
                 //            labelControl_u3.Text = "";



                 //}
                 //else
                 //{

                 //      labelControl_name.Text = "";// uc_Department_Product_FromDate_ToDate1.GridLookUpEdit_productName.SelectedText.ToString() + "( " + Packing + " )";
                 //      labelControl_u1.Text = "";// "Last " + U1 + " : " + Q1.ToString("n2");
                 //      labelControl_u2.Text = "";// "Last " + U2 + " : " + Q1.ToString("n2");
                 //      labelControl_u3.Text = "";// "Last " + U3 + " : " + Q1.ToString("n2");


                 //}

                 //dataSet_Item_Transaction.sp_TBL_STOCK_rpt_ItemTransaction.Rows.RemoveAt(0);

                 
                  //ObjGenGrid.Formatting();
                 

            }

            void referesh()
            {
                  ObjGen_Form.GenRefresh();
                  this.Text = "Ledger : ";
                  //sp_rpt_Ledger._sp_rpt_Ledger.Rows.Clear();

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

                  uc_Department_FromDate_ToDate1.loadGridForparentDepartments();


                  sp_profitOrLoss_DM_Lubricants_selectionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;

                  bingGrid();

                //  ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(bandedGridView1, GridControl_PURCHASE_AND_RETURN_DETAILS);
                  ObjGenGrid2 = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(gridView1, GridControl_PURCHASE_AND_RETURN_DETAILS);
               
                  //ObjGenGrid.Apperance("List_With_No_Sort");
                  //ObjGenGrid.isAllowDeleteColumns = false;
                  //ObjGenGrid.Formatting();

                  ObjGenGrid2.Apperance("List_With_No_Sort");
                  ObjGenGrid2.isAllowDeleteColumns = false;
                  ObjGenGrid2.Formatting();


                  ObjGen_Form = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                  ObjGen_Form.Formatting();
                  ObjGen_Form.GenRefresh();
                  //gridView1.DetailHeight = int.MaxValue;



            }

            private void PanelControl_filterControls_Paint(object sender, PaintEventArgs e)
            {

            }

            private void d(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
            {

            }

            private void bandedGridView1_DoubleClick(object sender, EventArgs e)
            {
                  //string transactioID = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "STOCK_transactionID").ToString();
                  //string Type = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "STOCK_transactionParentType").ToString();


                  //if (Type == "Sales" || Type == "Sales Return")
                  //{

                  //      IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(transactioID, false, false, true, "", Type);
                  //}else
                  //       if (Type == "Purchase" || Type == "Purchase Return")
                  //{

                  //      IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(transactioID, false, false, true, "", Type);
                  //}


            }

            private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
            {
                  //try
                  //{
                  //      string productID = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "PRODUCT_ID").ToString();

                  //      if (productID != "")
                  //            IMS_PRESENTATION_LAYER.cls_ShowReportEntities.ItemTransactionReport(productID, uc_FromDate_ToDate1.DateEdit_fromDate.DateTime.Date, uc_FromDate_ToDate1.DateEdit_toDate.DateTime.Date, false, false);
                  //}
                  //catch
                  //{ 
                  

                  //}
            }

      }
}