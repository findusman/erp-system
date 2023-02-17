using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Reports.Ledger
{
    public partial class frm_rpt_Ledger : DevExpress.XtraEditors.XtraForm
    {

        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGen_Form;
        GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;
        public frm_rpt_Ledger()
        {
            InitializeComponent();
            initialize();
        }

        string vch = "";

        

        public frm_rpt_Ledger(string VCH_ID, DateTime dtFrom,DateTime toFrom)
        {
            InitializeComponent();
            initialize();

            vch = VCH_ID;

            GridLookUpEdit_COA.EditValue = VCH_ID;
            DateEdit_fromDate.DateTime = dtFrom;
            DateEdit_toDate.DateTime = toFrom;


            //try
            //{

            //    sp_rpt_LedgerTableAdapter.Fill(
            //        sp_rpt_Ledger._sp_rpt_Ledger,
            //        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
            //        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
            //        dtFrom.Date,
            //        toFrom.Date,
            //        VCH_ID,
            //        false);
            //}
            //catch (Exception ex)
            //{

            //    obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


            //}

            //if (sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count > 0)
            //    LabelControl_TextEdit_VCH_reference.Text = "Balance : " + ((double)sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["RunningSum"]).ToString("N2") + " " + sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["Type"].ToString();
            //else
            //    LabelControl_TextEdit_VCH_reference.Text = "Balance : ";
            //ObjGenGrid.Formatting();
            //this.Text = "Ledger : " + GridLookUpEdit_COA.Text;


            try
            {
                loadData();
            }
            catch (Exception ex)
            {


                obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


            }
        }
        private void frm_rpt_Ledger_Load(object sender, EventArgs e)
        {


          //  initialize();
           // GridLookUpEdit_COA.EditValue = VCH_ID

        }

        void bingGrid()
        {

            ACC_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_COA_FinancialAndTransaction(GridLookUpEdit_COA, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name);

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

                sp_rpt_LedgerTableAdapter.Fill(
                    sp_rpt_Ledger._sp_rpt_Ledger,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                    DateEdit_fromDate.DateTime.Date,
                    DateEdit_toDate.DateTime.Date,
                    GridLookUpEdit_COA.EditValue.ToString(),
                    false);
            }
            catch (Exception ex)
            {

                obj_cls_MessageBox.MessageBoxDynamics(ex.Message, "I_E");


            }

            if (sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count > 0)
                LabelControl_TextEdit_VCH_reference.Text = "Balance : " + ((double)sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["RunningSum"]).ToString("N2") + " " + sp_rpt_Ledger._sp_rpt_Ledger.Rows[sp_rpt_Ledger._sp_rpt_Ledger.Rows.Count - 1]["Type"].ToString();
            else
                LabelControl_TextEdit_VCH_reference.Text = "Balance : ";
            ObjGenGrid.Formatting();
            this.Text = "Ledger : " + GridLookUpEdit_COA.Text;


            GridView_TBL_VCH_DETAILS.ViewCaption = GridLookUpEdit_COA.Text + " ( " +  DateEdit_fromDate.DateTime.Date.ToShortDateString() + " - "+
                    DateEdit_toDate.DateTime.Date.ToShortDateString() + " )";




        }

        void referesh()
        {
            ObjGen_Form.GenRefresh();
            this.Text = "Ledger : ";
            sp_rpt_Ledger._sp_rpt_Ledger.Rows.Clear();

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

            sp_rpt_LedgerTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;

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
                int _rowHandle = GridView_TBL_VCH_DETAILS.FocusedRowHandle;
                string ID = GridView_TBL_VCH_DETAILS.GetRowCellValue(_rowHandle, "VCH_DETAILS_mainID").ToString();
                string Type = ID.Split('-')[0];

                if (Type == "CP" || Type == "BP" || Type == "CR" || Type == "BR" || Type == "GV" || Type == "OB")
                {

                    ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN(ID, true, false, false, Type);
                }
                else if (Type == "SI" || Type == "SR")
                {
                    if (Type == "SI")
                        IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Sales");
                    else if (Type == "SR")
                        IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Sales Return");

                }
                 else if (Type == "PI" || Type == "PR")
                {
                    if (Type == "PI")
                        IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Purchase");
                    else if (Type == "PR")
                        IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN(ID, true, false, false, "Credit", "Purchase Return");

                }


            }
            catch (Exception ex)
            {


            }

        }

    }
}