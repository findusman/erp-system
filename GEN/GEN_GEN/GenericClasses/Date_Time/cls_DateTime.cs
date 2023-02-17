using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GEN.GEN_GEN.GenericClasses.Date_Time
{
   public class cls_DateTime
    {

       public static int getDifferenceInMonths(DateTime pdatetime1,DateTime pDatetime2)
       {

           return Convert.ToInt16((pDatetime2.Subtract(pdatetime1).Days / (365.25 / 12)));
       }

       public static DateTime getFromDate(DateTime pdatetime)
       {

           string strDateFrom = pdatetime.ToShortDateString();
           strDateFrom = strDateFrom + " 12:00:00.0000 AM";
           DateTime dtFrom = Convert.ToDateTime(strDateFrom);

           return dtFrom;
       }
       public static DateTime getToDate(DateTime pdatetime)
       {

           string strDateFrom = pdatetime.ToShortDateString();
           strDateFrom = strDateFrom + " 11:59:59.9999 PM";
           DateTime dtFrom = Convert.ToDateTime(strDateFrom);
           return dtFrom;
       }


       public static void adjustFromDateToDate(DevExpress.XtraEditors.ComboBoxEdit pComboBoxEdit, DevExpress.XtraEditors.DateEdit pFromDateEdit, DevExpress.XtraEditors.DateEdit pToDateEdit)
       {



             pToDateEdit.DateTime = pToDateEdit.DateTime = DateTime.Now.Date;

             
             if (pComboBoxEdit.SelectedItem.ToString() == "Last Day")
             {
                   pToDateEdit.DateTime = pToDateEdit.DateTime = DateTime.Now.AddDays(-1).Date;

             }
             else if (pComboBoxEdit.SelectedItem.ToString() == "Last Week")
             {
                   pToDateEdit.DateTime = DateTime.Now.AddDays(-7).Date;
                  
             }
             else if (pComboBoxEdit.SelectedItem.ToString() == "Last Month")
             {
                   pToDateEdit.DateTime = DateTime.Now.AddMonths(-1).Date;
                  
             }
             else if (pComboBoxEdit.SelectedItem.ToString() == "Last Quarter")
             {
                   pToDateEdit.DateTime = DateTime.Now.AddMonths(-4).Date;
                  
             }
       
       }
        


         public static  void AddDatePeriodstoCombobox(DevExpress.XtraEditors.ComboBoxEdit pComboBoxEdit)
       {

               pComboBoxEdit.Properties.Items.Clear();

                pComboBoxEdit.Properties.Items.Add("Manual");
                pComboBoxEdit.Properties.Items.Add("Last Day");
                pComboBoxEdit.Properties.Items.Add("Last Week");
                pComboBoxEdit.Properties.Items.Add("Last Month");
                pComboBoxEdit.Properties.Items.Add("Last Quarter ");

               




        
       
       }

         public static double calculateFloatSum(DataTable pdt, string pColumnsName) 
         {

               try
               {

                     double sum = 0;

                     object sumObject;
                     sumObject = pdt.Compute("Sum(" + pColumnsName + ")", "");


                     return (float)sumObject;
               }
               catch (Exception ex)
               {

                     return 0;
               }
         
         }

    }
}
