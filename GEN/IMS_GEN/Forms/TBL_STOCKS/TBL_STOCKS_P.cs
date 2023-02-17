using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GEN.IMS_GEN.Forms.TBL_STOCKS
{
    public class TBL_STOCKS_P
    {


        public static DataRow adjustRates(DataRow pCurrentRow, DataRow pParentRow)
        {

            double parentCLosingValue = 0;
            double totalCLosingValue = 0;
            double PurchasePrice1 = 0;
            double PurchasePrice2 = 0;
            double PurchasePrice3 = 0;
            double ParentPurchasePrice1 = 0;
            double ParentPurchasePrice2 = 0;
            double ParentPurchasePrice3 = 0;


            string productID = pCurrentRow["STOCK_itemID"].ToString();

            if (productID == "89")
            {



            }


            double totalStockInLtr = (double)pCurrentRow["STOCK_closingQTYInLTR"];
            string tmpmaxLevel = pCurrentRow["PACKING_MAIN_maxLevel"].ToString();
            double QTY = (double)pCurrentRow["STOCK_QTY"];
            double parentQ2 = (double)pCurrentRow["U2_QTY"];
            double parentQ3 = (double)pCurrentRow["U3_QTY"];

            double TotalCostValue = (double)pCurrentRow["STOCK_inValue"];
            string Type = pCurrentRow["STOCK_transactionParentType"].ToString();

            if (totalStockInLtr < 1)
                totalStockInLtr = 1;

            if (pParentRow != null)
            {


                parentCLosingValue = (double)pParentRow["STOCK_closingValue"];



                //if (Type == "Purchase" || Type == "Purchase Return")
                //{
                //    TotalCostValue = (double)pCurrentRow["STOCK_inValue"];

                //}
                //else 
                if (Type == "Sales" || Type == "Sales Return")
                {
                    ParentPurchasePrice1 = (double)pParentRow["STOCK_purchasePrice1"];
                    ParentPurchasePrice2 = (double)pParentRow["STOCK_purchasePrice2"];
                    ParentPurchasePrice3 = (double)pParentRow["STOCK_purchasePrice3"];

                    double PurchasePriceForSale = 0;

                    string unit = pCurrentRow["STOCK_unit"].ToString();
                    string Unit1 = pCurrentRow["U1_ID"].ToString();
                    string Unit2 = pCurrentRow["U2_ID"].ToString();
                    string Unit3 = pCurrentRow["U3_ID"].ToString();


                    if (unit == Unit1)
                    {

                        PurchasePriceForSale = ParentPurchasePrice1;

                    }
                    else if (unit == Unit2)
                    {

                        PurchasePriceForSale = ParentPurchasePrice2;

                    }
                    else if (unit == Unit3)
                    {

                        PurchasePriceForSale = ParentPurchasePrice3;

                    }
                    TotalCostValue = (PurchasePriceForSale * QTY);
                    pCurrentRow["STOCK_purchasePrice"] = PurchasePriceForSale;
                    pCurrentRow["STOCK_inValue"] = (PurchasePriceForSale * QTY);

 

                }

            }



            if (tmpmaxLevel == "1")
            {

                totalCLosingValue = parentCLosingValue + TotalCostValue;
                PurchasePrice1 = totalCLosingValue / totalStockInLtr;
            }
            else if (tmpmaxLevel == "2")
            {

                totalCLosingValue = parentCLosingValue + TotalCostValue;
                PurchasePrice2 = totalCLosingValue / totalStockInLtr;
                PurchasePrice1 = PurchasePrice2 / parentQ2;
            }
            else if (tmpmaxLevel == "3")
            {

                totalCLosingValue = parentCLosingValue + (TotalCostValue);
                PurchasePrice3 = totalCLosingValue / totalStockInLtr;
                PurchasePrice2 = PurchasePrice3 * parentQ3;
                PurchasePrice1 = PurchasePrice3 * parentQ2 * parentQ3;

            }





            //if (unit == Unit1)
            //{

            //    PurchasePrice1 = ParentPurchaseRate;
            //    PurchasePrice2 = ParentPurchaseRate/parentQ2;
            //    PurchasePrice3 = ParentPurchaseRate / parentQ2 / parentQ3;

            //}
            //else if (unit == Unit2)
            //{

            //    PurchasePrice1 = ParentPurchaseRate * parentQ2;
            //    PurchasePrice2 = ParentPurchaseRate  ;
            //    PurchasePrice3 = ParentPurchaseRate / parentQ3;

            //}
            //else if (unit == Unit3)
            //{

            //    PurchasePrice1 = ParentPurchaseRate * parentQ2 * parentQ3;
            //    PurchasePrice2 = ParentPurchaseRate * parentQ3;
            //    PurchasePrice3 = ParentPurchaseRate ;

            //}



            pCurrentRow["STOCK_purchasePrice1"] = PurchasePrice1;
            pCurrentRow["STOCK_purchasePrice2"] = PurchasePrice2;
            pCurrentRow["STOCK_purchasePrice3"] = PurchasePrice3;
            pCurrentRow["STOCK_closingValue"] = totalCLosingValue;







            return null;

        }


        public static DataRow ArrangeNegativeStockFromParentStock(DataRow pParentDataRow, DataRow pChildDataRow)
        {
            double parentQ1 = (double)pParentDataRow["STOCK_QTY1"];
            double parentQ2 = (double)pParentDataRow["STOCK_QTY2"];
            double parentQ3 = (double)pParentDataRow["STOCK_QTY3"];

            double parentQTYInLtr = (double)pParentDataRow["STOCK_closingQTYInLTR"];
            double parentValue = (double)pParentDataRow["STOCK_closingValue"];


            double childQ1 = (double)pChildDataRow["STOCK_QTY1"];
            double childQ2 = (double)pChildDataRow["STOCK_QTY2"];
            double childQ3 = (double)pChildDataRow["STOCK_QTY3"];

            double childValue = (double)pChildDataRow["STOCK_inValue"];

            double Q1 = parentQ1 + childQ1;
            double Q2 = parentQ2 + childQ2;
            double Q3 = parentQ3 + childQ3;

            double closingStockInValue = parentValue + childValue;



            int tmp_parentQTY = 0;
            double tmp_currentQTY = 0;
            double tmp_extraQTY = 0;




            //double Q1 = (double)pChildDataRow["netQty1"];
            //double Q2 = (double)pChildDataRow["netQty2"];
            //double Q3 = (double)pChildDataRow["netQty3"];

            double packingQ2 = (double)pChildDataRow["U2_QTY"];
            double packingQ3 = (double)pChildDataRow["U3_QTY"];

            string tmpmaxLevel = pChildDataRow["PACKING_MAIN_maxLevel"].ToString();
            double stockInLtr = 0;


            if (tmpmaxLevel == "1")
                stockInLtr = childQ1;
            else if (tmpmaxLevel == "2")
                stockInLtr = (childQ1 * packingQ2) + childQ2;
            else if (tmpmaxLevel == "3")
                stockInLtr = (childQ1 * packingQ2 * packingQ3) + (childQ2 * packingQ3) + childQ3;




            if (Q3 < 0)
            {
                // Q3 =  (Math.Abs(Q3)+ packingQ3) : Math.Abs(Q3);

                tmp_extraQTY = 0;
                if (Math.Abs(Q3) < packingQ3)
                {
                    Q3 = (Math.Abs(Q3) + packingQ3);
                    tmp_extraQTY = packingQ3;
                }
                else if ((Math.Abs(Q3) % packingQ3) != 0)
                {

                    Q3 = (Math.Abs(Q3) + packingQ3);
                    tmp_extraQTY = packingQ3;

                }

                else
                    Q3 = Math.Abs(Q3);


                tmp_parentQTY = Convert.ToInt32(((Q3 / packingQ3).ToString().Split('.'))[0]);


                tmp_currentQTY = ((tmp_parentQTY * packingQ3) + tmp_extraQTY) - Q3;


                Q2 -= tmp_parentQTY;
                Q3 = tmp_currentQTY;

            }

            if (Q2 < 0)
            {
                tmp_extraQTY = 0;
                if (Math.Abs(Q2) < packingQ2)
                {
                    Q2 = (Math.Abs(Q2) + packingQ2);
                    tmp_extraQTY = packingQ2;
                }
                else if ((Math.Abs(Q2) % packingQ2) != 0)
                {

                    Q2 = (Math.Abs(Q2) + packingQ2);
                    tmp_extraQTY = packingQ2;

                }
                else
                    Q2 = Math.Abs(Q2);


                tmp_parentQTY = Convert.ToInt32((Convert.ToInt32((Q2 / packingQ2)).ToString().Split('.'))[0]);

                tmp_currentQTY = ((tmp_parentQTY * packingQ2) + tmp_extraQTY) - Q2;

                Q1 -= tmp_parentQTY;
                Q2 = tmp_currentQTY;

            }


            double totalStockInLtr = parentQTYInLtr + stockInLtr;


            pChildDataRow["STOCK_QTY1"] = Q1;
            pChildDataRow["STOCK_QTY2"] = Q2;
            pChildDataRow["STOCK_QTY3"] = Q3;
            pChildDataRow["STOCK_closingQTYInLTR"] = totalStockInLtr;
            pChildDataRow["STOCK_QTYInLtr"] = (stockInLtr);



            //  pChildDataRow["STOCK_closingValue"] = closingStockInValue;

            adjustRates(pChildDataRow, pParentDataRow);
            return pChildDataRow;
        }


    }
}
