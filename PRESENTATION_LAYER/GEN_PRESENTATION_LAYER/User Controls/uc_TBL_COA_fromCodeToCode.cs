using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.User_Controls
{
      public partial class uc_TBL_COA_fromCodeToCode : DevExpress.XtraEditors.XtraUserControl
      {
            public uc_TBL_COA_fromCodeToCode()
            {
                  InitializeComponent();
                  

            }


            

            #region STATUS


            public string Pro_tempSTATUS = "";

            public string Pro_STATUS
            {

                  get
                  {

                        return Pro_tempSTATUS;

                  }
                  set
                  {
                        Pro_tempSTATUS = value;
                  }

            }
            #endregion
        
            #region STATUS1


            public string Pro_tempSTATUS1 = "";

            public string STATUS1
            {

                  get
                  {

                        return Pro_tempSTATUS1;

                  }
                  set
                  {
                        Pro_tempSTATUS1 = value;
                  }

            }

            #endregion

            #region COA_UID


            public string Pro_tempCOA_PARENTID = "";

            public string Pro_COA_PARENTID
            {

                  get
                  {

                        return Pro_tempCOA_PARENTID;

                  }
                  set
                  {
                        Pro_tempCOA_PARENTID = value;
                  }

            }

          
            #endregion

            #region COA_PARENTID


            public string Pro_tempCOA_UID = "";

            public string Pro_COA_UID
            {

                  get
                  {

                        return Pro_tempCOA_UID;

                  }
                  set
                  {
                        Pro_tempCOA_UID = value;
                  }

            }

            #endregion

            #region COA_levelNo


            public int? Pro_tempCOA_levelNo = null;

            public int? Pro_COA_levelNo
            {

                  get
                  {

                        return Pro_tempCOA_levelNo;

                  }
                  set
                  {
                        Pro_tempCOA_levelNo = value;
                  }

            }

            #endregion

            #region COA_type


            public int Pro_tempCOA_type = 0;

            public int Pro_COA_type
            {

                  get
                  {

                        return Pro_tempCOA_type;

                  }
                  set
                  {
                        Pro_tempCOA_type = value;
                  }

            }

            #endregion

            #region COA_IsTransaction


            public bool? Pro_tempCOA_IsTransaction = null;

            public bool? Pro_COA_IsTransaction
            {

                  get
                  {

                        return Pro_tempCOA_IsTransaction;

                  }
                  set
                  {
                        Pro_tempCOA_IsTransaction = value;
                  }

            }

            #endregion

            #region Visible String


            public string Pro_tempvisibleString = "";

            public string Pro_visibleString
            {

                  get
                  {

                        return Pro_tempvisibleString;

                  }
                  set
                  {
                        Pro_tempvisibleString = value;
                  }

            }

            #endregion


            public void loadGrid()
            {

                  loadAccounts(GridLookUpEdit_fCode, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID);
                  loadAccounts(GridLookUpEdit_tCode, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID);
                  loadAccounts(GridLookUpEdit_fName, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name);
                  loadAccounts(GridLookUpEdit_tName, ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name);

            }

            void loadAccounts(GridLookUpEdit pGridLookUpEdit, string pDisplayMember)
            {
                  DATASET.ACC_DATASET.cls_DataSet obj_cls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
                  obj_cls_DataSet.f_TBL_COA(
                        Pro_STATUS,
                        Pro_COA_PARENTID,
                        Pro_COA_UID,
                        "",
                        0,
                        0,
                        Pro_COA_type,
                        Pro_COA_levelNo,
                        null,
                        false,
                        Pro_COA_IsTransaction,
                        true,
                        false);
                  DataSet ds = obj_cls_DataSet.g_TBL_COA;

                  if (ds != null)
                  {
                        GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getGridLookUpEdit(

                    pGridLookUpEdit,
                    pDisplayMember,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_Name,
                            ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                            "Names",
                            "IDs",
                    ds,
                    ACC_PRESENTATION_LAYER.GColumns.cls_CTBL_COA.COA_UID,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopHeightMedium,
                    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_GridLookUpEditPopWidthlarge,
                    200,
                    Pro_visibleString,
                    false,
                    true,
                    true

                    );
                  }


            }

            private void ComboBoxEdit_CUSTOMER_year_SelectedIndexChanged(object sender, EventArgs e)
            {
//                  Manual
//Last Day
//Last Week
//Last Month
//Last Quarter 

                  if (ComboBoxEdit_comboBox.SelectedItem.ToString() == "Manual")
                        DateEdit_fromDate.DateTime = DateEdit_toDate.DateTime = DateTime.Now.Date;
                  else if (ComboBoxEdit_comboBox.SelectedItem.ToString() == "Last Day")
                  {
                        DateEdit_fromDate.DateTime = DateEdit_toDate.DateTime = DateTime.Now.AddDays(-1).Date;
                  
                  }
                  else if (ComboBoxEdit_comboBox.SelectedItem.ToString() == "Last Week")
                  {
                        DateEdit_fromDate.DateTime = DateTime.Now.AddDays(-7).Date;
                         DateEdit_toDate.DateTime = DateTime.Now.AddDays(-1).Date;

                  }
                  else if (ComboBoxEdit_comboBox.SelectedItem.ToString() == "Last Month")
                  {
                        DateEdit_fromDate.DateTime = DateTime.Now.AddMonths(-1).Date;
                        DateEdit_toDate.DateTime = DateTime.Now.AddDays(-1).Date;

                  }
                  else if (ComboBoxEdit_comboBox.SelectedItem.ToString() == "Last Quarter")
                  {
                        DateEdit_fromDate.DateTime = DateTime.Now.AddMonths(-4).Date;
                        DateEdit_toDate.DateTime = DateTime.Now.AddDays(-1).Date;

                  }

            }

            private void uc_TBL_COA_fromCodeToCode_Load(object sender, EventArgs e)
            {

            }

            private void GridLookUpEdit_fCode_EditValueChanged(object sender, EventArgs e)
            {
                  if (GridLookUpEdit_fCode.EditValue.ToString() == "All")
                        GridLookUpEdit_fName.EditValue = GridLookUpEdit_tCode.EditValue =
                              GridLookUpEdit_fName.EditValue = GridLookUpEdit_tName.EditValue = "All";
                  else
                        GridLookUpEdit_fName.EditValue = GridLookUpEdit_fCode.EditValue;



            }

            private void GridLookUpEdit_fName_EditValueChanged(object sender, EventArgs e)
            {
                  if (GridLookUpEdit_fName.EditValue.ToString() == "All")
                        GridLookUpEdit_fCode.EditValue = GridLookUpEdit_tCode.EditValue =
                              GridLookUpEdit_fName.EditValue = GridLookUpEdit_tName.EditValue = "All";
                  else
                        GridLookUpEdit_fCode.EditValue = GridLookUpEdit_fName.EditValue;
            }

            private void GridLookUpEdit_tCode_EditValueChanged(object sender, EventArgs e)
            {
                  if (GridLookUpEdit_tCode.EditValue.ToString() == "All")
                        GridLookUpEdit_fName.EditValue = GridLookUpEdit_tCode.EditValue =
                              GridLookUpEdit_fName.EditValue = GridLookUpEdit_tName.EditValue = "All";
                  else
                        GridLookUpEdit_tName.EditValue = GridLookUpEdit_tCode.EditValue;
            }

            private void GridLookUpEdit_tName_EditValueChanged(object sender, EventArgs e)
            {
                  if (GridLookUpEdit_tName.EditValue.ToString() == "All")
                        GridLookUpEdit_fCode.EditValue = GridLookUpEdit_tCode.EditValue =
                              GridLookUpEdit_fName.EditValue = GridLookUpEdit_tName.EditValue = "All";
                  else
                        GridLookUpEdit_tCode.EditValue = GridLookUpEdit_tName.EditValue;
            }
      }
}
