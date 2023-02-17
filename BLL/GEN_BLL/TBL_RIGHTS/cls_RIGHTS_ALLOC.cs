using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
//using GEN_DAL;

namespace BLL.GEN_BLL.TBL_RIGHTS
{
    public class cls_RIGHTS_ALLOC
    {
        public static DataTable dt_right_def = new DataTable();

        DAL.DALCustome obj_dal = new DAL.DALCustome();

        public Boolean gproperty_allocatoin = false;

        string ExeState = "";

        private String status;

        public String STATUS
        {
            get { return status; }
            set { status = value; }
        }

        private string cMP_ID = null;

       public string CMP_ID
        {
            get { return cMP_ID; }
            set { cMP_ID = value; }
        }

       private string bRC_ID = null;

       public string BRC_ID
        {
            get { return bRC_ID; }
            set { bRC_ID = value; }
        }

        private string rIGHTS_MAIN_ID = string.Empty;

        public string RIGHTS_MAIN_ID
        {
            get { return rIGHTS_MAIN_ID; }
            set { rIGHTS_MAIN_ID = value; }
        }

        private string rIGHTS_MAIN_name = string.Empty;

        public string RIGHTS_MAIN_name
        {
            get { return rIGHTS_MAIN_name; }
            set { rIGHTS_MAIN_name = value; }
        }

        private string rIGHTS_MAIN_roleID = string.Empty;

        public string RIGHTS_MAIN_roleID
        {
            get { return rIGHTS_MAIN_roleID; }
            set { rIGHTS_MAIN_roleID = value; }
        }

        private string rIGHTS_MAIN_narration = string.Empty;

        public string RIGHTS_MAIN_narration
        {
            get { return rIGHTS_MAIN_narration; }
            set { rIGHTS_MAIN_narration = value; }
        }

        private bool rIGHTS_DEF_isDeleted = true;

        public bool RIGHTS_DEF_isDeleted
        {
            get { return rIGHTS_DEF_isDeleted; }
            set { rIGHTS_DEF_isDeleted = value; }
        }

        private bool rIGHTS_DEF_isActive = true;

        public bool RIGHTS_DEF_isActive
        {
            get { return rIGHTS_DEF_isActive; }
            set { rIGHTS_DEF_isActive = value; }
        }


        private string rIGHTS_MAIN_level = string.Empty;

        public string RIGHTS_MAIN_level
        {
            get { return rIGHTS_MAIN_level; }
            set { rIGHTS_MAIN_level = value; }
        }




        public DataSet selection()
        {

            SqlParameter[] sql_param = new SqlParameter[6];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = BRC_ID;

            sql_param[2] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[2].Value = RIGHTS_DEF_isDeleted;

            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_ID", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_name;

            sql_param[4] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[4].Value = STATUS;

            sql_param[5] = new SqlParameter("@RIGHTS_MAIN_level", SqlDbType.NVarChar);
            sql_param[5].Value = RIGHTS_MAIN_level;


            DataSet ds = new DataSet();

            ds = obj_dal.selection("sp_RIGHTS_alloc", sql_param);

            if (ds == null)
            {
                return ds;
            }

            int x = ds.Tables.Count;

            DataTable dt = new DataTable();

            dt = ds.Tables[0];

            if (gproperty_allocatoin == true)
            {
                if (dt.Rows.Count != 0)
                {

                    CMP_ID = (string)GEN.GEN_GEN.GenericClasses.Form.Gen_Form.checkDbNull(dt.Rows[0]["CMP_ID"]);
                    BRC_ID = (string)GEN.GEN_GEN.GenericClasses.Form.Gen_Form.checkDbNull(dt.Rows[0]["BRC_ID"]);
                    RIGHTS_MAIN_ID = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_ID"].ToString());
                    RIGHTS_MAIN_name = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_name"].ToString());
                    RIGHTS_MAIN_roleID = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_roleID"].ToString());
                    RIGHTS_MAIN_narration = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_narration"].ToString());
                    RIGHTS_DEF_isDeleted = Convert.ToBoolean(dt.Rows[0]["RIGHTS_DEF_isDeleted"].ToString());
                    RIGHTS_DEF_isActive = Convert.ToBoolean(dt.Rows[0]["RIGHTS_DEF_isActive"].ToString());

                }

            }

            return ds;

        }

    }
}
