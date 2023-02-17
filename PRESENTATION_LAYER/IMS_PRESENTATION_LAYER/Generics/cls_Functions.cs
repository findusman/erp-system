using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Generics
{


    class cls_Functions
    {
        public static RepositoryItemGridLookUpEdit repository_item = new RepositoryItemGridLookUpEdit();

        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_Messeage = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

        //public void addUnitsToUnitColumns(DataRow pDataRow, GridColumn tmpGridColumn)
        //{

        //    RepositoryItemImageComboBox obj_RepositoryItemImageComboBox = (RepositoryItemImageComboBox)tmpGridColumn.ColumnEdit;
        //    obj_RepositoryItemImageComboBox.Items.Clear();


        //    if (pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_maxUnitLevel].ToString() == "1")
        //    {
        //        ImageComboBoxItem obj_ImageComboBoxItem1 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem1);

        //    }
        //    else if (pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_maxUnitLevel].ToString() == "2")
        //    {
        //        ImageComboBoxItem obj_ImageComboBoxItem1 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem1);

        //        ImageComboBoxItem obj_ImageComboBoxItem2 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_secondUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_secondUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem2);

        //    }
        //    else if (pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_maxUnitLevel].ToString() == "3")
        //    {

        //        ImageComboBoxItem obj_ImageComboBoxItem1 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_firstUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem1);

        //        ImageComboBoxItem obj_ImageComboBoxItem2 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_secondUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_secondUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem2);

        //        ImageComboBoxItem obj_ImageComboBoxItem3 = new ImageComboBoxItem(pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_thirdUnit + "Name"].ToString(), pDataRow[PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_ITEM.cls_CTBL_ITEM.ITEM_thirdUnit].ToString());
        //        obj_RepositoryItemImageComboBox.Items.Add(obj_ImageComboBoxItem3);

        //    }



        //}

        public static string code_Generator(string pValue, string pStatus, int pLevelNO)
        {

            try
            {
                DATASET.ACC_DATASET.cls_DataSet objcls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
                GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_Messeage = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

                objcls_DataSet.f_TBL_ACC_PLAN('A', false);
                DataSet ds = DATASET.ACC_DATASET.cls_DataSet.g_TBL_ACC_PLAN;

                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_levelSeparator = Convert.ToChar(ds.Tables[0].Rows[0]["TBL_ACC_PLAN_MAIN_leveSeperator"].ToString());
                int level_length = ds.Tables[1].Select("TBL_ACC_PLAN_DEF_levelNo=" + pLevelNO)[0]["TBL_ACC_PLAN_DEF_format"].ToString().Length;

                if (pValue.Length <= level_length)
                {
                    return pValue = pValue.ToString().PadLeft(level_length, '0');
                }
                else
                {
                    return objcls_Messeage.MessageBoxStatic("C_E");
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }


        }

        public static void code_Generator()
        {
            try
            {

                DATASET.ACC_DATASET.cls_DataSet objcls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
                objcls_DataSet.f_TBL_ACC_PLAN('A',  false);
                DataSet ds = DATASET.ACC_DATASET.cls_DataSet.g_TBL_ACC_PLAN;

                GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_levelSeparator = Convert.ToChar(ds.Tables[0].Rows[0]["TBL_ACC_PLAN_MAIN_leveSeperator"].ToString());
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        public static string code_Generator(int pLevelNO)
        {

            try
            {
                DATASET.ACC_DATASET.cls_DataSet objcls_DataSet = new DATASET.ACC_DATASET.cls_DataSet();
                objcls_DataSet.f_TBL_ACC_PLAN('A', false);
                DataSet ds = DATASET.ACC_DATASET.cls_DataSet.g_TBL_ACC_PLAN;

                string level_Value = ds.Tables[1].Select("TBL_ACC_PLAN_DEF_levelNo=" + pLevelNO)[0]["TBL_ACC_PLAN_DEF_format"].ToString();

                return level_Value;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();

            }

        }

        public static DataTable GetCOA_All()
        {
            DATASET.GEN_DATASET.cls_DataSet objcls_GEN_DATASET = new DATASET.GEN_DATASET.cls_DataSet();
            objcls_GEN_DATASET.f_TBL_DEFAULT_ACCT("A", "", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, 0, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);

            if (objcls_GEN_DATASET.g_TBL_DEFAULT_ACCT != null)
                if (objcls_GEN_DATASET.g_TBL_DEFAULT_ACCT.Tables.Count > 0)
                {

                    //foreach (DataRow row in objcls_GEN_DATASET.g_TBL_DEFAULT_ACCT.Tables[0].Rows)
                    //{
                    //    if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Bank_Accounts == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Bank_Accounts = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Business_Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Business_Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Business_Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Business_Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Accounts == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Accounts = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Purchase_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Purchase_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Purchase_Returns == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Purchase_Returns = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Sales_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Sales_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }
                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Sales_Return == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Sales_Return = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Purchase_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Purchase_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Purchase_Returns == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Purchase_Returns = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Sales_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Sales_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Sales_Return == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Sales_Return = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Current_Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Current_Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Current_Liabilities == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Current_Liabilities = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Customers == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Customers = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Equity == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Equity = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Expense == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Expense = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Fixed_Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Fixed_Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Fixed_Liabilities == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Fixed_Liabilities = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Income == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Income = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Inventory == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Inventory = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Liability == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Liability = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }
                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Purchase_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Purchase_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Purchase_Return == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Purchase_Return = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Sales_Discount == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Sales_Discount = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Sales_Retun == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Sales_Retun = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }

                    //    else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Suppliers == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
                    //    {
                    //        GEN.ACC_GEN.Generics.cls_DefaultCOA.Suppliers = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
                    //    }
                   // }
                }
            return objcls_GEN_DATASET.g_TBL_DEFAULT_ACCT.Tables[0];
        }

        //public static RepositoryItemGridLookUpEdit get_repositoryforItemNames_VOUCHER()
        //{
        //    DATASET.IMS_DATASET.cls_DataSet objcls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();
        //    objcls_DataSet.f_TBL_ITEM_GEN_PAK_ASIA("LOOKUP_PAK_ASIA", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "0", "", "", true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataTable dt_COA = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0];
        //    String ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name + "," + PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID;
        //    return repository_item = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, "Item Names", "IDs", dt_COA, "COA_Is_Inventory", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforItemCodes_VOUCHERS()
        //{
        //    DATASET.IMS_DATASET.cls_DataSet objcls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();
        //    objcls_DataSet.f_TBL_ITEM_GEN_PAK_ASIA("LOOKUP_PAK_ASIA", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "0", "", "", true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataTable dt_COA = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0];
        //    String ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name + "," + PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID;
        //    return repository_item = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, "Item Names", "IDs", dt_COA, "COA_Is_Inventory", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforItemNames(string pStatus)
        //{
        //    DataTable dt_COA = new DataTable();
        //    DATASET.IMS_DATASET.cls_DataSet objcls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();
        //    objcls_DataSet.f_TBL_ITEM_GEN_PAK_ASIA("LOOKUP_PAK_ASIA", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "0", "", "", true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataRow[] dT_ROW = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0].Select("COA_Is_Inventory=" + pStatus);

        //    dt_COA = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0].Clone();
        //    for (int i = 0; i < dT_ROW.Length; i++)
        //    {
        //        dt_COA.ImportRow(dT_ROW[i]);
        //    }

        //    String ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name + "," + PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID;
        //    return repository_item = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, "Item Names", "IDs", dt_COA, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforItemCodes(string pStatus)
        //{
        //    DataTable dt_COA = new DataTable();
        //    DATASET.IMS_DATASET.cls_DataSet objcls_DataSet = new DATASET.IMS_DATASET.cls_DataSet();

        //    objcls_DataSet.f_TBL_ITEM_GEN_PAK_ASIA("LOOKUP_PAK_ASIA", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "0", "", "", true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataRow[] dT_ROW = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0].Select("COA_Is_Inventory=" + pStatus);

        //    dt_COA = objcls_DataSet.g_TBL_ITEM_GEN_PAK_ASIA.Tables[0].Clone();
        //    for (int i = 0; i < dT_ROW.Length; i++)
        //    {
        //        dt_COA.ImportRow(dT_ROW[i]);
        //    }

        //    String ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name + "," + PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID;
        //    return repository_item = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_ID, "Item Names", "IDs", dt_COA, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.frm_TBL_ITEM_GEN_PAK_ASIA.cls_CTBL_ITEM_GEN_PAK_ASIA.ITEM_GEN_PAK_ASIA_Name, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforUnits()
        //{
        //    RepositoryItemGridLookUpEdit repository_unit = new RepositoryItemGridLookUpEdit();

        //    DATASET.IMS_DATASET.cls_DataSet objcls_IMSDataSet = new DATASET.IMS_DATASET.cls_DataSet();

        //    objcls_IMSDataSet.f_TBL_UNIT("All_Levels", 0, false);

        //    DataSet ds_Unit = objcls_IMSDataSet.g_TBL_UNIT;

        //    string ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_NAME;

        //    return repository_unit = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_NAME, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_NAME, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_ID, "Item Names", "IDs", ds_Unit.Tables[0], PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_UNIT.cls_CTBL_UNIT.UNIT_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforLocation()
        //{
        //    RepositoryItemGridLookUpEdit repository_location = new RepositoryItemGridLookUpEdit();

        //    DATASET.IMS_DATASET.cls_DataSet objcls_IMSDataSet = new DATASET.IMS_DATASET.cls_DataSet();

        //    objcls_IMSDataSet.f_TBL_LOCATION("L", "0", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataSet ds = objcls_IMSDataSet.g_TBL_LOCATION;

        //    string ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_name + "," + PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_ID;

        //    return repository_location = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_ID, "Item Names", "IDs", ds.Tables[0], PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_LOCATION.cls_CTBL_LOCATION.LOCATION_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforSchemes()
        //{
        //    RepositoryItemGridLookUpEdit repository_location = new RepositoryItemGridLookUpEdit();

        //    DATASET.IMS_DATASET.cls_DataSet objcls_IMSDataSet = new DATASET.IMS_DATASET.cls_DataSet();

        //    objcls_IMSDataSet.f_TBL_SCHEME('L', "", false);
        //    DataSet ds_Scheme = objcls_IMSDataSet.g_TBL_SCHEME;

        //    string ColumnsForVisibilit = PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_name;

        //    return repository_location = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_ID, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_name, PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_ID, "Item Names", "IDs", ds_Scheme.Tables[0], PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Def_Forms.TBL_SCHEME.cls_CTBL_SCHEME.SCHEME_name, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        //public static RepositoryItemGridLookUpEdit get_repositoryforPacking()
        //{
        //    RepositoryItemGridLookUpEdit repository_location = new RepositoryItemGridLookUpEdit();

        //    DATASET.GEN_DATASET.cls_DataSet objcls_GENDataSet = new DATASET.GEN_DATASET.cls_DataSet();

        //    objcls_GENDataSet.f_TBL_GEN_FORM('L', "0", "ItemPacking", false);
        //    DataSet ds_packing = objcls_GENDataSet.g_TBL_GEN_FORM;

        //    string ColumnsForVisibilit = PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_ID + "," + PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_name;

        //    return repository_location = GEN.GEN_GEN.GenericClasses.Grid.cls_GridFunctions.getRepositoryGridLookUpEdit(PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_name, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_ID, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_name, PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_ID, "Item Names", "IDs", ds_packing.Tables[0], PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_GEN_FORM.cls_CTBL_GEN_FORM.GEN_FORM_name, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopHeight, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopWidth, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RepositoryGridLookUpEditPopValueMemberWidth, ColumnsForVisibilit, true, true, true);

        //}

        public static void COAValues(String pCOA_PARENTID)
        {
            //  if (pTYPE == "others")
            //{
            DataRow[] dr = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA.Select("[COA_UID]= '" + pCOA_PARENTID + "'");
            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_COA_nature = dr[0].ItemArray[8].ToString();
            GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_COA_type = Convert.ToInt32(dr[0].ItemArray[7].ToString());
            //}
            //else
            //{
            //    DataRow[] dr = PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.InitiateGrid.cls_InitiateGrids.dt_COA.Select("[COA_UID]= '" + pCOA_PARENTID + "'");
            //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_COA_nature = dr[0].ItemArray[8].ToString();
            //    GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_COA_type = Convert.ToInt32(dr[0].ItemArray[7].ToString());
            //}
        }

        //public static DataTable GetFORMATS()
        //{
        //    DATASET.GEN_DATASET.cls_DataSet.f_TBL_FORMATS();

        //    if (DATASET.GEN_DATASET.cls_DataSet.g_TBL_FORMATS != null)
        //        if (DATASET.GEN_DATASET.cls_DataSet.g_TBL_FORMATS.Tables.Count > 0)
        //        {

        //            foreach (DataRow row in DATASET.GEN_DATASET.cls_DataSet.g_TBL_FORMATS.Tables[0].Rows)
        //            {
        //                //if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Purchase_Returns == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Purchase_Returns = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Cash_Sales_Return == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Cash_Sales_Return = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Purchase == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Purchase = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Purchase_Returns == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Purchase_Returns = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}


        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Sales == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Sales = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Credit_Sales_Return == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Credit_Sales_Return = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Current_Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Current_Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}
        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Customers == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Customers = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Equity == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Equity = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Expense == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Expense = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Fixed_Assets == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Fixed_Assets = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Income == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Income = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}


        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Liability == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Liability = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //                //else if (GEN.ACC_GEN.Generics.cls_DefaultCOAKeys.Suppliers == row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_KEY].ToString())
        //                //{
        //                //    GEN.ACC_GEN.Generics.cls_DefaultCOA.Suppliers = row[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE].ToString();
        //                //}

        //            }

        //        }


        //    return DATASET.GEN_DATASET.cls_DataSet.g_TBL_FORMATS.Tables[0];
        //}
    }
}
