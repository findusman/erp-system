using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Reports.COA
{
    public partial class rpt_COA : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_COA()
        {
            InitializeComponent();
        }

        private void rpt_COA_DataSourceDemanded(object sender, EventArgs e)
        {



            sp_TBL_COA_selectionTableAdapter.Connection.ConnectionString = DAL.DALCustome.connectionstring;
            DataSets.ACC_COA.sp_TBL_COA_selectionDataTable obj_sp_TBL_COA_selectionDataTable = new DataSets.ACC_COA.sp_TBL_COA_selectionDataTable();


            sp_TBL_COA_selectionTableAdapter.Fill(
                obj_sp_TBL_COA_selectionDataTable,
                "Report",
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                false,
                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted,
                null,
                null);

        }

    }
}
