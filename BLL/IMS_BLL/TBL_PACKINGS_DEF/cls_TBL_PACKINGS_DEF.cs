using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.IMS_BLL.TBL_PACKINGS_DEF
{

    public class cls_TBL_PACKINGS_DEF
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



        private string pPACKING_DEF_ID = string.Empty;

        public string PACKING_DEF_ID
        {
            get { return pPACKING_DEF_ID; }
            set { pPACKING_DEF_ID = value; }
        }




        private string pPACKING_DEF_MAIN_ID = string.Empty;
        public string PACKING_DEF_MAIN_ID
        {
            get { return pPACKING_DEF_MAIN_ID; }
            set { pPACKING_DEF_MAIN_ID = value; }
        }


        private string pPACKING_DEF_parentKey = string.Empty;
        public string PACKING_DEF_parentKey
        {
            get { return pPACKING_DEF_parentKey; }
            set { pPACKING_DEF_parentKey = value; }
        }


        private string pPACKING_DEF_primaryKeyLogical = string.Empty;
        public string PACKING_DEF_primaryKeyLogical
        {
            get { return pPACKING_DEF_primaryKeyLogical; }
            set { pPACKING_DEF_primaryKeyLogical = value; }
        }


        private string pPACKING_DEF_unit = string.Empty;
        public string PACKING_DEF_unit
        {
            get { return pPACKING_DEF_unit; }
            set { pPACKING_DEF_unit = value; }
        }


        private decimal pPACKING_DEF_qty = 0;
        public decimal PACKING_DEF_qty
        {
            get { return pPACKING_DEF_qty; }
            set { pPACKING_DEF_qty = value; }
        }


        private string pPACKING_DEF_barCode = string.Empty;
        public string PACKING_DEF_barCode
        {
            get { return pPACKING_DEF_barCode; }
            set { pPACKING_DEF_barCode = value; }
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

        private int pPACKING_DEF_level;

        public int PACKING_DEF_level
        {
                    get { return pPACKING_DEF_level; }
                    set { pPACKING_DEF_level = value; }
        }  

        public bool insertionUpdation(char pProcedureStatus)
        {
            DAL.DALCustome obj_DALCustome = new DAL.DALCustome();

            SqlCommand obj_SqlCommand = new SqlCommand();

            SqlParameter[] sql_param = new SqlParameter[13];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@PACKING_DEF_ID", SqlDbType.NVarChar);
            sql_param[2].Value = PACKING_DEF_ID;

            sql_param[3] = new SqlParameter("@PACKING_DEF_MAIN_ID", SqlDbType.NVarChar);
            sql_param[3].Value = PACKING_DEF_MAIN_ID;

            sql_param[4] = new SqlParameter("@PACKING_DEF_parentKey", SqlDbType.NVarChar);
            sql_param[4].Value = PACKING_DEF_parentKey;

            sql_param[5] = new SqlParameter("@PACKING_DEF_primaryKeyLogical", SqlDbType.NVarChar);
            sql_param[5].Value = PACKING_DEF_primaryKeyLogical;

            sql_param[6] = new SqlParameter("@PACKING_DEF_unit", SqlDbType.NVarChar);
            sql_param[6].Value = PACKING_DEF_unit;

            sql_param[7] = new SqlParameter("@PACKING_DEF_qty", SqlDbType.Float);
            sql_param[7].Value = PACKING_DEF_qty;

            sql_param[8] = new SqlParameter("@PACKING_DEF_level", SqlDbType.Int);
            sql_param[8].Value = PACKING_DEF_level;

            sql_param[9] = new SqlParameter("@PACKING_DEF_barCode", SqlDbType.NVarChar);
            sql_param[9].Value = PACKING_DEF_barCode;

            sql_param[10] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[10].Value = Is_Auto_Generated;

            sql_param[11] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[11].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[12] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[12].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;



            DataSet ds = new DataSet();


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            if (pProcedureStatus == 'I')
                ds = obj_DALCustome.selection("sp_TBL_PACKINGS_DEF_insertion", sql_param, obj_SqlCommand, true);
            else
                ds = obj_DALCustome.selection("sp_TBL_PACKINGS_DEF_updation", sql_param, obj_SqlCommand, true);
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

                if (ExeState == "ok")
                {
                    obj_DALCustome.transactioCommit();
                    return true;
                }
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

            sql_param[3] = new SqlParameter("@PACKING_DEF_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = PACKING_DEF_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_PACKINGS_DEF_deletion", sql_param, obj_SqlCommand, true);

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
                obj_DALCustome.transactioCommit();
                return true;
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

            sql_param[3] = new SqlParameter("@PACKING_DEF_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = PACKING_DEF_ID;

            sql_param[4] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[4].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_PACKINGS_DEF_selection", sql_param, obj_SqlCommand, true);

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
