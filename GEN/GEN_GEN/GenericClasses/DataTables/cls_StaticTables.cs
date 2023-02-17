using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace GEN.GEN_GEN.GenericClasses.DataTables
{
    public class cls_StaticTables
    {


        public DataTable getUnitTable()
        {

            DataTable dt_temp = new DataTable();
            dt_temp.Columns.Add("IDs", typeof(string));
            dt_temp.Columns.Add("Unit Names", typeof(string));
            return dt_temp;

        }


        public static DataTable getRightsTable()
        {
            DataTable dt_temp = new DataTable();
            dt_temp.Columns.Add("Is Allowed", typeof(bool));
            dt_temp.Columns.Add("Parent Tree", typeof(string));
            dt_temp.Columns.Add("Primary Tree", typeof(string));
            dt_temp.Columns.Add("Right Name", typeof(string));
            dt_temp.Columns.Add("Parent Key", typeof(string));
            dt_temp.Columns.Add("Primary Key", typeof(string));
            dt_temp.Columns.Add("Childs", typeof(bool));            
            dt_temp.Columns.Add("Level", typeof(int));
            dt_temp.Columns.Add("Type", typeof(string));
            dt_temp.Columns.Add("Form", typeof(string));
            return dt_temp;

        }

        public static DataTable getTableofVCH()
        {
              DataTable dt_temp = new DataTable();
              dt_temp.Columns.Add("VCH_DETAILS_COA", typeof(string));
              dt_temp.Columns.Add("VCH_DETAILS_referenceNo", typeof(string));
              dt_temp.Columns.Add("VCH_DETAILS_debit", typeof(float));
              dt_temp.Columns.Add("VCH_DETAILS_credit", typeof(float));
              dt_temp.Columns.Add("VCH_DETAILS_remarks", typeof(string));
            
            
              return dt_temp;

        }









    }
}
