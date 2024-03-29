﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_PRODUCTS.User_Controls
{
      public partial class uc_Department_FromDate_ToDate : DevExpress.XtraEditors.XtraUserControl
      {
            public uc_Department_FromDate_ToDate()
            {
                  InitializeComponent();
                  loadGrid();

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



                  IMS_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_DEPARTMENTS(GridLookUpEdit_departments, true);
               

            }
            public void loadGridForparentDepartments()
            {



                  IMS_PRESENTATION_LAYER.cls_bindGridLookUpEdit.TBL_DEPARTMENTSParent(GridLookUpEdit_departments, true);


            }
            //GEN.GEN_GEN.GenericClasses.Date_Time.cls_DateTime.adjustFromDateToDate(ComboBoxEdit_comboBox ,DateEdit_fromDate, DateEdit_toDate);
                
         
         
           

            private void GridLookUpEdit_fCode_EditValueChanged(object sender, EventArgs e)
            {
                  //if (GridLookUpEdit_fCode.EditValue.ToString() == "All")
                  //      GridLookUpEdit_departments.EditValue = GridLookUpEdit_productID.EditValue =
                  //            GridLookUpEdit_departments.EditValue = GridLookUpEdit_productName.EditValue = "All";
                  //else
                  //      GridLookUpEdit_departments.EditValue = GridLookUpEdit_fCode.EditValue;



            }

       

           

            private void ComboBoxEdit_comboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                  GEN.GEN_GEN.GenericClasses.Date_Time.cls_DateTime.adjustFromDateToDate(ComboBoxEdit_comboBox, DateEdit_fromDate, DateEdit_toDate);
              
            }

            private void uc_Department_Product_FromDate_ToDate_Load(object sender, EventArgs e)
            {
                  GEN.GEN_GEN.GenericClasses.Date_Time.cls_DateTime.AddDatePeriodstoCombobox(ComboBoxEdit_comboBox);
                  GEN.GEN_GEN.GenericClasses.Date_Time.cls_DateTime.adjustFromDateToDate(ComboBoxEdit_comboBox, DateEdit_fromDate, DateEdit_toDate);
              
            }

            
      }
}
