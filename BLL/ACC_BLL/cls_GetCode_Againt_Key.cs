using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL.ACC_BLL
{
    class cls_GetCode_Againt_Key
    {
        DAL.DALCustome obj_dal = new DAL.DALCustome();

        public String getCodeAgaintKey(String Key_Value,String status = "A")
        {

            SqlParameter[] sql_param = new SqlParameter[2];

            sql_param[0] = new SqlParameter("@KEY_VALUE", SqlDbType.NVarChar);
            sql_param[0].Value = Key_Value;
            sql_param[1] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[1].Value = status;
      


            DataSet ds = new DataSet();

            ds = obj_dal.selection("sp_HelperFunction", sql_param);

            if (ds == null)
            {
                return "";
            }
            else
            {

                if (ds.Tables[0].Rows.Count == 0)
                {

                    return "";
                }
                else
                {

                    return Convert.ToString(ds.Tables[0].Rows[0][0]);

                }

            }



        }
    }
}
