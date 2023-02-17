using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Lists.TBL_STOCKS.Item_Transaction_Report
{
      public partial class frm_Item_Sales_Purchase_Ledger : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
            GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGen_Form;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;
        string _status = "";

          public frm_Item_Sales_Purchase_Ledger( string pProductID, string pstatus )
            {
                  InitializeComponent();
                  initialize();
              _status =pstatus;

              if (_status == "Sales")
              {
                  this.Text = "Sales Ledger";            
 


              }
              else

                  this.Text = "Purchase Ledger";            
 
                  
            }

          public frm_Item_Sales_Purchase_Ledger()
            {
                  InitializeComponent();
                  this.Tag = "fsfs";
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
                        uc_Department_Product_FromDate_ToDate1.loadGrid();

                  }
                  catch (Exception ex)
                  {

                        obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


                  }
            }

            void loadData(string pProductID, DateTime pFromDateTime,DateTime pToDateTime)
            {


                  
               //"",
               //"",
               //PRODUCT_ID,
               //GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted

                  

                sp_rpt_ledger_sales_purchaseTableAdapter.Fill(
                        
                        dataSet_Item_Transaction.sp_rpt_ledger_sales_purchase, 
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                        pProductID,//uc_Department_Product_FromDate_ToDate1.GridLookUpEdit_productName.EditValue.ToString(),
                        pFromDateTime,
                        pToDateTime,
                        _status
                        );


             
                if( _status != "Sales")
                      
                    gridView1.Columns["Cost Rate"].Visible = false;
                else
                    gridView1.Columns["Rate"].Caption = "Sale Rate";
                 
                  ObjGenGrid.Formatting();
                 

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
                        loadData(
                            
                            uc_Department_Product_FromDate_ToDate1.GridLookUpEdit_productID.EditValue.ToString(), 
                            
                            uc_Department_Product_FromDate_ToDate1.DateEdit_fromDate.DateTime.Date, 
                            
                            uc_Department_Product_FromDate_ToDate1.DateEdit_toDate.DateTime.Date
                            

                            );
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


                  sp_rpt_ledger_sales_purchaseTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;
                  sp_TBL_STOCK_rpt_ItemTransactionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;


                  bingGrid();

                  ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(gridView1, GridControl_PURCHASE_AND_RETURN_DETAILS);
                  ObjGenGrid.Apperance("List_With_No_Sort");
                  ObjGenGrid.isAllowDeleteColumns = false;
                  ObjGenGrid.Formatting();

                  ObjGen_Form = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                  ObjGen_Form.Formatting();
                  ObjGen_Form.GenRefresh();



            }

            private void PanelControl_filterControls_Paint(object sender, PaintEventArgs e)
            {

            }

            private void d(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
            {

            }

            private void bandedGridView1_DoubleClick(object sender, EventArgs e)
            {

                try
                {


                //    int x = bandedGridView1.FocusedRowHandle;
                //    string ID = bandedGridView1.GetRowCellValue(x, "STOCK_VCHID").ToString();
                //    string Type = ID.Split('-')[0].ToString();

                //    //  uc_TBL_COA_fromCodeToCode1

                //    if (Type == "CP" || Type == "BP" || Type == "CR" || Type == "BR" || Type == "GV" || Type == "OB")
                //    {

                //        ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN(ID, true, false, false, Type);
                //    }
                //    else if (Type == "SI" || Type == "SR")
                //    {
                //        if (Type == "SI")
                //            IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Sales");
                //        else if (Type == "SR")
                //            IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Sales Return");

                //    }
                //    else if (Type == "PI" || Type == "PR")
                //    {
                //        if (Type == "PI")
                //            IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Purchase");
                //        else if (Type == "PR")
                //            IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Purchase Return");

                //    }




                }
                catch (Exception ex)
                {


                }

                //string transactioID = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "STOCK_transactionID").ToString();
                //string Type = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "STOCK_transactionParentType").ToString();


                //if (Type == "Sales" || Type == "Sales Return")
                //{

                //    IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(transactioID, false, false, true, "", Type);
                //}
                //else
                //    if (Type == "Purchase" || Type == "Purchase Return")
                //    {

                //        IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(transactioID, false, false, true, "", Type);
                //    }


            }

      }
}