using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using BLL.IMS_BLL.TBL_PURCHASE_AND_RETURN_MAIN;
using BLL.IMS_BLL.TBL_SALES_AND_RETURN_MAIN;


namespace BLL.IMS_BLL.TBL_STOCKS
{

    public class cls_TBL_STOCKS
    {
        DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
        public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
        BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        string ExeState = "";

        private string pSTATUS;
        public String STATUS
        {
            get { return pSTATUS; }
            set { pSTATUS = value; }
        }



        private string pSTOCK_ID = string.Empty;

        public string STOCK_ID
        {
            get { return pSTOCK_ID; }
            set { pSTOCK_ID = value; }
        }

        private int pSTOCK_maxID = 0;

        public int STOCK_maxID
        {
            get { return pSTOCK_maxID; }
            set { pSTOCK_maxID = value; }
        }





        private string pSTOCK_itemID = string.Empty;
        public string STOCK_itemID
        {
            get { return pSTOCK_itemID; }
            set { pSTOCK_itemID = value; }
        }


        private string pSTOCK_transactionID = string.Empty;
        public string STOCK_transactionID
        {
            get { return pSTOCK_transactionID; }
            set { pSTOCK_transactionID = value; }
        }


        private string pSTOCK_VCHID = string.Empty;
        public string STOCK_VCHID
        {
            get { return pSTOCK_VCHID; }
            set { pSTOCK_VCHID = value; }
        }


        private string pSTOCK_transactionParentType = string.Empty;
        public string STOCK_transactionParentType
        {
            get { return pSTOCK_transactionParentType; }
            set { pSTOCK_transactionParentType = value; }
        }


        private string pSTOCK_transactionChildType = string.Empty;
        public string STOCK_transactionChildType
        {
            get { return pSTOCK_transactionChildType; }
            set { pSTOCK_transactionChildType = value; }
        }


        private string pSTOCK_stockAddRemoveStatus = string.Empty;
        public string STOCK_stockAddRemoveStatus
        {
            get { return pSTOCK_stockAddRemoveStatus; }
            set { pSTOCK_stockAddRemoveStatus = value; }
        }


        private string pSTOCK_stockLocationID = string.Empty;
        public string STOCK_stockLocationID
        {
            get { return pSTOCK_stockLocationID; }
            set { pSTOCK_stockLocationID = value; }
        }


        private decimal pSTOCK_salePrice = 0;
        public decimal STOCK_salePrice
        {
            get { return pSTOCK_salePrice; }
            set { pSTOCK_salePrice = value; }
        }


        private decimal pSTOCK_purchasePrice = 0;
        public decimal STOCK_purchasePrice
        {
            get { return pSTOCK_purchasePrice; }
            set { pSTOCK_purchasePrice = value; }
        }


        private decimal pSTOCK_saleDiscount = 0;
        public decimal STOCK_saleDiscount
        {
            get { return pSTOCK_saleDiscount; }
            set { pSTOCK_saleDiscount = value; }
        }


        private decimal pSTOCK_purchaseDiscount = 0;
        public decimal STOCK_purchaseDiscount
        {
            get { return pSTOCK_purchaseDiscount; }
            set { pSTOCK_purchaseDiscount = value; }
        }


        private decimal pSTOCK_QTY = 0;
        public decimal STOCK_QTY
        {
            get { return pSTOCK_QTY; }
            set { pSTOCK_QTY = value; }
        }


        private string pSTOCK_unit = string.Empty;
        public string STOCK_unit
        {
            get { return pSTOCK_unit; }
            set { pSTOCK_unit = value; }
        }


        private decimal pSTOCK_giftQTY = 0;
        public decimal STOCK_giftQTY
        {
            get { return pSTOCK_giftQTY; }
            set { pSTOCK_giftQTY = value; }
        }


        private DateTime pSTOCK_date = DateTime.Now;
        public DateTime STOCK_date
        {
            get { return pSTOCK_date; }
            set { pSTOCK_date = value; }
        }



        private bool pIs_Auto_Generated = true;

        public bool Is_Auto_Generated
        {
            get { return pIs_Auto_Generated; }
            set { pIs_Auto_Generated = value; }
        }

        private string pUser_ID = string.Empty;

        public string User_ID
        {
            get { return pUser_ID; }
            set { pUser_ID = value; }
        }


        public bool updateClosingStock(

                  SqlCommand pobj_SqlCommand,
                  DAL.DALCustome pobj_DALCustome,
                  DataTable pdt_detail

              )
        {


            int STOCK_orderingID = 0;
            string parentItem = "", childItem = "";

            for (int x = 0; x < pdt_detail.Rows.Count; x++)
            {

                if (parentItem != "")
                {
                    parentItem = pdt_detail.Rows[x - 1]["STOCK_itemID"].ToString();

                    childItem = pdt_detail.Rows[x]["STOCK_itemID"].ToString();

                    if (parentItem != childItem)
                        parentItem = "";
                    else
                        GEN.IMS_GEN.Forms.TBL_STOCKS.TBL_STOCKS_P.ArrangeNegativeStockFromParentStock(pdt_detail.Rows[x -1], pdt_detail.Rows[x]);
                }
                if (parentItem == "")
                {

                    parentItem = pdt_detail.Rows[x]["STOCK_itemID"].ToString();


                    double Q1 = (double)pdt_detail.Rows[x]["STOCK_QTY1"];
                    double Q2 = (double)pdt_detail.Rows[x]["STOCK_QTY2"];
                    double Q3 = (double)pdt_detail.Rows[x]["STOCK_QTY3"];
                    double packingQ2 = (double)pdt_detail.Rows[x]["U2_QTY"];
                    double packingQ3 = (double)pdt_detail.Rows[x]["U3_QTY"];
                    double closingStockInValue = (double)pdt_detail.Rows[x]["STOCK_inValue"];

                    string tmpmaxLevel = pdt_detail.Rows[x]["PACKING_MAIN_maxLevel"].ToString();
                    double stockInLtr = 0;

                    if (tmpmaxLevel == "1")
                        stockInLtr = Q1;
                    else if (tmpmaxLevel == "2")
                        stockInLtr = (Q1 * packingQ2) + Q2;
                    else if (tmpmaxLevel == "3")
                        stockInLtr = (Q1 * packingQ2 * packingQ3) + (Q2 * packingQ3) + Q3;



                    pdt_detail.Rows[x]["STOCK_closingQTYInLTR"] = stockInLtr;
                    pdt_detail.Rows[x]["STOCK_QTYInLtr"] = stockInLtr;

                    pdt_detail.Rows[x]["STOCK_closingValue"] = closingStockInValue;

                    GEN.IMS_GEN.Forms.TBL_STOCKS.TBL_STOCKS_P.adjustRates(pdt_detail.Rows[x], null);
                    //adjustRates(pdt_detail.Rows[x], pdt_detail.Rows[x - 1]);
                }

                parentItem = pdt_detail.Rows[x]["STOCK_itemID"].ToString();

                //bool isLast = false;

            }

            SqlParameter[] sql_param = new SqlParameter[1];

            sql_param[0] = new SqlParameter("@dt", SqlDbType.Structured);
            sql_param[0].Value = pdt_detail;


            //sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            //sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            //sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            //sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            //sql_param[2] = new SqlParameter("@STOCK_ID", SqlDbType.NVarChar);
            //sql_param[2].Value = pdt_detail.Rows[x]["STOCK_ID"].ToString();

            //sql_param[3] = new SqlParameter("@STOCK_clostingQTY1", SqlDbType.Float);
            //sql_param[3].Value = pdt_detail.Rows[x]["STOCK_QTY1"];

            //sql_param[4] = new SqlParameter("@STOCK_clostingQTY2", SqlDbType.Float);
            //sql_param[4].Value = pdt_detail.Rows[x]["STOCK_QTY2"];

            //sql_param[5] = new SqlParameter("@STOCK_clostingQTY3", SqlDbType.Float);
            //sql_param[5].Value = pdt_detail.Rows[x]["STOCK_QTY3"];

            //sql_param[6] = new SqlParameter("@STOCK_closingQTYInLTR", SqlDbType.Float);
            //sql_param[6].Value = pdt_detail.Rows[x]["STOCK_closingQTYInLTR"];

            //sql_param[7] = new SqlParameter("@STOCK_closingValue", SqlDbType.Float);
            //sql_param[7].Value = pdt_detail.Rows[x]["STOCK_closingValue"];

            //sql_param[8] = new SqlParameter("@STOCK_QTYInLtr", SqlDbType.Float);
            //sql_param[8].Value = pdt_detail.Rows[x]["STOCK_QTYInLtr"];

            DataSet ds = pobj_DALCustome.selection("sp_TBL_STOCKS_closingStock_updation_with_table", sql_param, pobj_SqlCommand, false);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
            {

                pobj_DALCustome.transactioRollBack();
                pobj_DALCustome.closeconnection();
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                return false;
            }
            else
            {

                ExeState = ds.Tables[0].Rows[0][0].ToString();
                //pSTOCK_maxID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                if (ExeState == "ok")
                {
                    return true;
                    //continue;
                }
                else
                {
                    pobj_DALCustome.transactioRollBack();
                    pobj_DALCustome.closeconnection();
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                    return false;

                }

            }


            return true;

        }


        public bool InsertUpdateOnlyStockPurchase(

                  SqlCommand pobj_SqlCommand,
                  DAL.DALCustome pobj_DALCustome,
                  DataTable dt_detail,
                  string pSTOCK_transactionID,
                  string pSTOCK_VCHID,
                  string pSTOCK_transactionParentType,
                  string pSTOCK_transactionChildType,
                  DateTime pSTOCK_date,
                    int pSTOCK_maxID,

                  string pSTOCK_stockLocationID,
              string pSTOCK_narration

              )
        {


            int STOCK_orderingID = 0;
            foreach (DataRow dr in dt_detail.Rows)
            {

                bool isLast = false;
                SqlParameter[] sql_param = new SqlParameter[22];

                sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                sql_param[2] = new SqlParameter("@STOCK_transactionID", SqlDbType.NVarChar);
                sql_param[2].Value = pSTOCK_transactionID;

                sql_param[3] = new SqlParameter("@STOCK_orderingID", SqlDbType.Int);
                sql_param[3].Value = STOCK_orderingID;


                sql_param[4] = new SqlParameter("@STOCK_VCHID", SqlDbType.NVarChar);
                sql_param[4].Value = pSTOCK_VCHID;

                sql_param[5] = new SqlParameter("@STOCK_transactionParentType", SqlDbType.NVarChar);
                sql_param[5].Value = pSTOCK_transactionParentType;

                sql_param[6] = new SqlParameter("@STOCK_transactionChildType", SqlDbType.NVarChar);
                sql_param[6].Value = pSTOCK_transactionChildType;

                sql_param[7] = new SqlParameter("@STOCK_date", SqlDbType.DateTime);
                sql_param[7].Value = pSTOCK_date;

                sql_param[8] = new SqlParameter("@STOCK_stockLocationID", SqlDbType.NVarChar);
                sql_param[8].Value = pSTOCK_stockLocationID;

                sql_param[9] = new SqlParameter("@STOCK_itemID", SqlDbType.NVarChar);
                sql_param[9].Value = dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.A_PURCHASE_AND_RETURN_DETAILS_itemCode];
                sql_param[10] = new SqlParameter("@STOCK_salePrice", SqlDbType.Float);
                sql_param[10].Value = 0;

                sql_param[11] = new SqlParameter("@STOCK_purchasePrice", SqlDbType.Float);
                sql_param[11].Value = Convert.ToDouble(dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_purchasePrice]) == 0 ? 1 : dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_purchasePrice];

                sql_param[12] = new SqlParameter("@STOCK_saleDiscount", SqlDbType.Float);
                sql_param[12].Value = 0;

                sql_param[13] = new SqlParameter("@STOCK_purchaseDiscount", SqlDbType.Float);
                sql_param[13].Value = 0;

                sql_param[14] = new SqlParameter("@STOCK_unit", SqlDbType.NVarChar);
                sql_param[14].Value = dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.A_PURCHASE_AND_RETURN_DETAILS_itemUnitCode];

                sql_param[15] = new SqlParameter("@STOCK_QTY", SqlDbType.Float);
                sql_param[15].Value = Convert.ToDouble(dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_QTY]) == 0 ? 1 : (STOCK_stockAddRemoveStatus == "Add" ? dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_QTY] : "-" + dr[cls_CTBL_PURCHASE_AND_RETURN_MAIN.PURCHASE_AND_RETURN_DETAILS_QTY].ToString());

                sql_param[16] = new SqlParameter("@STOCK_stockAddRemoveStatus", SqlDbType.NVarChar);
                sql_param[16].Value = STOCK_stockAddRemoveStatus;//"Add";

                sql_param[17] = new SqlParameter("@STOCK_maxID", SqlDbType.Int);
                sql_param[17].Value = pSTOCK_maxID;//"Add";


                sql_param[18] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                sql_param[18].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                sql_param[19] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                sql_param[19].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                sql_param[20] = new SqlParameter("@Is_Last", SqlDbType.Bit);

                if (STOCK_orderingID == (dt_detail.Rows.Count - 1))
                {
                    sql_param[20].Value = true;
                    isLast = true;
                }
                else
                {
                    sql_param[20].Value = false;
                    isLast = false;
                }


                sql_param[21] = new SqlParameter("@STOCK_narration", SqlDbType.NVarChar);
                sql_param[21].Value = pSTOCK_narration;


                DataSet ds = pobj_DALCustome.selection("sp_TBL_STOCKS_insertion", sql_param, pobj_SqlCommand, false);

                if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                {

                    pobj_DALCustome.transactioRollBack();
                    pobj_DALCustome.closeconnection();
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                    return false;
                }
                else
                {

                    ExeState = ds.Tables[0].Rows[0][0].ToString();
                    pSTOCK_maxID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                    if (ExeState == "ok")
                    {
                        if (isLast)
                        {
                            if (!updateClosingStock(pobj_SqlCommand, pobj_DALCustome, ds.Tables[1]))
                                return false;
                        }
                        STOCK_orderingID++;
                        continue;
                    }
                    else
                    {
                        pobj_DALCustome.transactioRollBack();
                        pobj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        return false;

                    }

                }

            }
            return true;

        }

        public bool InsertUpdateOnlyStockSales(

               SqlCommand pobj_SqlCommand,
               DAL.DALCustome pobj_DALCustome,
               DataTable dt_detail,
               string pSTOCK_transactionID,
               string pSTOCK_VCHID,
               string pSTOCK_transactionParentType,
               string pSTOCK_transactionChildType,
               DateTime pSTOCK_date,
                 int pSTOCK_maxID,

               string pSTOCK_stockLocationID,
               string pSTOCK_narration


           )
        {


            int STOCK_orderingID = 0;

            bool isLast = false;

            foreach (DataRow dr in dt_detail.Rows)
            {


                SqlParameter[] sql_param = new SqlParameter[22];

                sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                sql_param[2] = new SqlParameter("@STOCK_transactionID", SqlDbType.NVarChar);
                sql_param[2].Value = pSTOCK_transactionID;

                sql_param[3] = new SqlParameter("@STOCK_orderingID", SqlDbType.Int);
                sql_param[3].Value = STOCK_orderingID;


                sql_param[4] = new SqlParameter("@STOCK_VCHID", SqlDbType.NVarChar);
                sql_param[4].Value = pSTOCK_VCHID;

                sql_param[5] = new SqlParameter("@STOCK_transactionParentType", SqlDbType.NVarChar);
                sql_param[5].Value = pSTOCK_transactionParentType;

                sql_param[6] = new SqlParameter("@STOCK_transactionChildType", SqlDbType.NVarChar);
                sql_param[6].Value = pSTOCK_transactionChildType;

                sql_param[7] = new SqlParameter("@STOCK_date", SqlDbType.DateTime);
                sql_param[7].Value = pSTOCK_date;

                sql_param[8] = new SqlParameter("@STOCK_stockLocationID", SqlDbType.NVarChar);
                sql_param[8].Value = pSTOCK_stockLocationID;

                sql_param[9] = new SqlParameter("@STOCK_itemID", SqlDbType.NVarChar);
                sql_param[9].Value = dr[cls_CTBL_SALES_AND_RETURN_MAIN.A_SALES_AND_RETURN_DETAILS_itemCode];
                sql_param[10] = new SqlParameter("@STOCK_salePrice", SqlDbType.Float);
                sql_param[10].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_SALESPrice];

                sql_param[11] = new SqlParameter("@STOCK_purchasePrice", SqlDbType.Float);
                sql_param[11].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_costPrice]) == 0 ? 1 : dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_costPrice];

                sql_param[12] = new SqlParameter("@STOCK_saleDiscount", SqlDbType.Float);
                sql_param[12].Value = 0;

                sql_param[13] = new SqlParameter("@STOCK_purchaseDiscount", SqlDbType.Float);
                sql_param[13].Value = 0;

                sql_param[14] = new SqlParameter("@STOCK_unit", SqlDbType.NVarChar);
                sql_param[14].Value = dr[cls_CTBL_SALES_AND_RETURN_MAIN.A_SALES_AND_RETURN_DETAILS_itemUnitCode];

                sql_param[15] = new SqlParameter("@STOCK_QTY", SqlDbType.Float);
                sql_param[15].Value = Convert.ToDouble(dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY]) == 0 ? 1 : (STOCK_stockAddRemoveStatus == "Add" ? dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY] : "-" + dr[cls_CTBL_SALES_AND_RETURN_MAIN.SALES_AND_RETURN_DETAILS_QTY].ToString());

                sql_param[16] = new SqlParameter("@STOCK_stockAddRemoveStatus", SqlDbType.NVarChar);
                sql_param[16].Value = STOCK_stockAddRemoveStatus;//"Add";

                sql_param[17] = new SqlParameter("@STOCK_maxID", SqlDbType.Int);
                sql_param[17].Value = pSTOCK_maxID;//"Add";


                sql_param[18] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                sql_param[18].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                sql_param[19] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                sql_param[19].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;

                sql_param[20] = new SqlParameter("@Is_Last", SqlDbType.Bit);

                if (STOCK_orderingID == (dt_detail.Rows.Count - 1))
                {
                    sql_param[20].Value = true;
                    isLast = true;
                }
                else
                {
                    sql_param[20].Value = false;
                    isLast = false;
                }

                sql_param[21] = new SqlParameter("@STOCK_narration", SqlDbType.NVarChar);
                sql_param[21].Value = pSTOCK_narration;




                DataSet ds = pobj_DALCustome.selection("sp_TBL_STOCKS_insertion", sql_param, pobj_SqlCommand, false);

                if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                {

                    pobj_DALCustome.transactioRollBack();
                    pobj_DALCustome.closeconnection();
                    obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                    return false;
                }
                else
                {


                    ExeState = ds.Tables[0].Rows[0][0].ToString();
                    pSTOCK_maxID = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                    if (ExeState == "ok")
                    {
                        if (isLast)
                        {
                            if (!updateClosingStock(pobj_SqlCommand, pobj_DALCustome, ds.Tables[1]))
                                return false;
                        }
                        STOCK_orderingID++;
                        continue;
                    }
                    else
                    {
                        pobj_DALCustome.transactioRollBack();
                        pobj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        return false;

                    }

                }

            }
            return true;

        }

        public bool insertionUpdation(char pProcedureStatus)
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            string Id = "";


            string Log_description = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogDescription : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogDescription;
            string Log_event = pProcedureStatus == 'I' ? GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_InsertLogEvent : GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_UpdateLogEvent;

            if (obj_cls_TBL_LOG.insertion(Id, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
            {

                obj_DALCustome.transactioCommit();
                obj_DALCustome.closeconnection();
                if (pProcedureStatus == 'I')
                    obj_cls_MessageBox.MessageBoxStatic("I_S");
                else
                    obj_cls_MessageBox.MessageBoxStatic("U_S");
                return true;
            }
            else
            {
                obj_DALCustome.transactioRollBack();
                obj_DALCustome.closeconnection();
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                return false;

            }




            return false;

        }

        public bool Open()
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");
                return false;
            }

            if (obj_cls_TBL_LOG.insertion("O", obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_ScreenOpenedLogDescription, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_ScreenOpenedLogEvent, obj_SqlCommand, obj_DALCustome, true))
            {

                obj_DALCustome.transactioCommit();
                obj_DALCustome.closeconnection();
                return true;
            }
            else
            {
                obj_DALCustome.transactioRollBack();
                obj_DALCustome.closeconnection();
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                return false;

            }


        }




        public bool deletion()
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            SqlParameter[] sql_param = new SqlParameter[4];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;

            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[3] = new SqlParameter("@STOCK_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = STOCK_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_STOCKS_deletion", sql_param, obj_SqlCommand, true);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
            {

                obj_DALCustome.transactioRollBack();
                obj_DALCustome.closeconnection();
                obj_cls_MessageBox.MessageBoxStatic("BLL_E");

                return false;
            }
            else
            {
                ExeState = ds.Tables[0].Rows[0][0].ToString();
                string Id = ds.Tables[0].Rows[0][1].ToString();

                if (Id != "N")
                {

                    string Log_description = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogDescription;
                    string Log_event = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_DeleteLogEvent;

                    if (obj_cls_TBL_LOG.insertion(Id, obj_XtraForm.Tag.ToString(), obj_XtraForm.Text.ToString(), Log_description, Log_event, obj_SqlCommand, obj_DALCustome, false))
                    {

                        obj_DALCustome.transactioCommit();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("D_S");
                        return true;
                    }
                    else
                    {
                        obj_DALCustome.transactioRollBack();
                        obj_DALCustome.closeconnection();
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                        return false;

                    }
                }
                else
                {
                    obj_DALCustome.transactioCommit();
                    obj_DALCustome.closeconnection();

                    obj_cls_MessageBox.MessageBoxDynamics(ExeState, "D_E");

                    return false;

                }


            }
            return false;
        }


        public DataSet selection()
        {

            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                return null;
            }

            SqlParameter[] sql_param = new SqlParameter[5];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;

            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[3] = new SqlParameter("@STOCK_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = STOCK_ID;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_STOCKS_selection", sql_param, obj_SqlCommand, true);

            if (ds != null)
            {

                obj_DALCustome.transactioCommit();
                obj_DALCustome.closeconnection();
                return ds;
            }
            else
            {
                obj_DALCustome.transactioRollBack();
                obj_DALCustome.closeconnection();
                return null;

            }

            return ds;

        }

    }
}
