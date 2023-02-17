using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
//using GEN_DAL;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace BLL.GEN_BLL.TBL_RIGHTS
{
    //     *****************************************************************************************************************************************************************


    //                             Code Type:           Business Logic Layer
    //                             Creation Date:       6/18/2014 1:54:23 PM
    //                             Auther:              Muhammad Usman Raza Attari
    //                             Developed By :       786 Software House 


    //    *****************************************************************************************************************************************************************

    public class cls_TBL_RIGHTS_MAIN
    {

        public static DataTable dt_right_def = new DataTable();
        public static TreeList dt_right_def_tree = new TreeList();

        DAL.DALCustome obj_dal = new DAL.DALCustome();

        public Boolean gproperty_allocatoin = false;

        string ExeState = "";

        private String status;

        public String STATUS
        {
            get { return status; }
            set { status = value; }
        }

        private string cMP_ID;

        public string CMP_ID
        {
            get { return cMP_ID; }
            set { cMP_ID = value; }
        }

        private string bRC_ID;

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





        private string parentCMP_ID = string.Empty;

        public string ParentCMP_ID
        {
            get { return parentCMP_ID; }
            set { parentCMP_ID = value; }
        }


        private string parentBRC_ID = string.Empty;

        public string ParentBRC_ID
        {
            get { return parentBRC_ID; }
            set { parentBRC_ID = value; }
        }


        private string parentRIGHTS_MAIN_level = string.Empty;

        public string ParentRIGHTS_MAIN_level
        {
            get { return parentRIGHTS_MAIN_level; }
            set { parentRIGHTS_MAIN_level = value; }
        }


        private string parentRIGHTS_MAIN_ID = string.Empty;

        public string ParentRIGHTS_MAIN_ID
        {
            get { return parentRIGHTS_MAIN_ID; }
            set { parentRIGHTS_MAIN_ID = value; }
        }



        private bool rIGHTS_DEF_isActive = true;

        public bool RIGHTS_DEF_isActive
        {
            get { return rIGHTS_DEF_isActive; }
            set { rIGHTS_DEF_isActive = value; }
        }

        private string rIGHTS_MAIN_level = "";

        public string RIGHTS_MAIN_level
        {
            get { return rIGHTS_MAIN_level; }
            set { rIGHTS_MAIN_level = value; }
        }

        public bool insertionRIGHT_DEF_MDI(string pRIGHTS_DEF_ID, SqlCommand objSqlCommand, DAL.DALCustome objDAlCustome, char pstatus)
        {
            string ExeStatetemp = "ok";
            for (int x = 0; x < dt_right_def.Rows.Count; x++)
            {
                if (ExeStatetemp != "ok")
                    return false;

                SqlParameter[] sql_param = new SqlParameter[14];

                sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                sql_param[2] = new SqlParameter("@RIGHTS_DEF_MAIN_ID", SqlDbType.NVarChar);
                sql_param[2].Value = RIGHTS_MAIN_ID;

                sql_param[3] = new SqlParameter("@RIGHTS_DEF_isAllowed", SqlDbType.Bit);
                sql_param[3].Value = dt_right_def.Rows[x]["Is Allowed"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_isAllowed];

                sql_param[4] = new SqlParameter("@RIGHTS_DEF_parentKeyForTree", SqlDbType.NVarChar);
                sql_param[4].Value = dt_right_def.Rows[x]["Parent Tree"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_parentKeyForTree];

                sql_param[5] = new SqlParameter("@RIGHTS_DEF_PKKeyForTree", SqlDbType.NVarChar);
                sql_param[5].Value = dt_right_def.Rows[x]["Primary Tree"];

                sql_param[6] = new SqlParameter("@RIGHTS_DEF_itemText", SqlDbType.NVarChar);
                sql_param[6].Value = dt_right_def.Rows[x]["Right Name"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_itemText];

                sql_param[7] = new SqlParameter("@RIGHTS_DEF_parentKeyLogical", SqlDbType.NVarChar);
                sql_param[7].Value = dt_right_def.Rows[x]["Parent Key"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_parentKeyLogical];

                sql_param[8] = new SqlParameter("@RIGHTS_DEF_PKKeyForLogical", SqlDbType.NVarChar);
                sql_param[8].Value = dt_right_def.Rows[x]["Primary Key"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_PKKeyForLogical];

                sql_param[9] = new SqlParameter("@RIGHTS_DEF_itemType", SqlDbType.NVarChar);
                sql_param[9].Value = dt_right_def.Rows[x]["Type"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_itemType];

                sql_param[10] = new SqlParameter("@RIGHTS_DEF_childNodes", SqlDbType.Bit);
                sql_param[10].Value = dt_right_def.Rows[x]["Childs"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_itemType];

                sql_param[11] = new SqlParameter("@RIGHTS_DEF_itemLevel", SqlDbType.Int);
                sql_param[11].Value = dt_right_def.Rows[x]["Level"];//cls_CTBL_RIGHTS_DEF.RIGHTS_DEF_itemLevel];

                sql_param[12] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
                sql_param[12].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                sql_param[13] = new SqlParameter("@RIGHTS_DEF_level", SqlDbType.NVarChar);
                sql_param[13].Value = RIGHTS_MAIN_level;

                ExeState = objDAlCustome.ins_del_upd("sp_TBL_RIGHTS_DEF_insertion", sql_param, objSqlCommand, false);

            }
            return true;

        }

        private bool chkAllNodes(string pRIGHTS_DEF_ID, SqlCommand objSqlCommand, DAL.DALCustome objDAlCustome, char pstatus)
        {   
         
            foreach(TreeListNode node in dt_right_def_tree.Nodes)
                {
                    if (insertionRIGHT_DEF(pRIGHTS_DEF_ID, objSqlCommand, objDAlCustome, pstatus, node)) 
                    { }
                    else
                        return false;
                }

            return true;

        }

        public bool insertionRIGHT_DEF(string pRIGHTS_DEF_ID, SqlCommand objSqlCommand, DAL.DALCustome objDAlCustome, char pstatus, TreeListNode treeNode)
        {
            string ExeStatetemp = "ok";
            
                
                if (ExeStatetemp != "ok")
                    return false;

            

                SqlParameter[] sql_param = new SqlParameter[14];

                sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                sql_param[2] = new SqlParameter("@RIGHTS_DEF_MAIN_ID", SqlDbType.NVarChar);
                sql_param[2].Value = RIGHTS_MAIN_ID;

                sql_param[3] = new SqlParameter("@RIGHTS_DEF_isAllowed", SqlDbType.Bit);
                sql_param[3].Value = treeNode.CheckState == System.Windows.Forms.CheckState.Indeterminate ? true : treeNode.Checked;

                sql_param[4] = new SqlParameter("@RIGHTS_DEF_parentKeyForTree", SqlDbType.NVarChar);
                sql_param[4].Value = treeNode["Parent Tree"];

                sql_param[5] = new SqlParameter("@RIGHTS_DEF_PKKeyForTree", SqlDbType.NVarChar);
                sql_param[5].Value = treeNode["Primary Tree"];

                sql_param[6] = new SqlParameter("@RIGHTS_DEF_itemText", SqlDbType.NVarChar);
                sql_param[6].Value = treeNode["Right Name"];

                sql_param[7] = new SqlParameter("@RIGHTS_DEF_parentKeyLogical", SqlDbType.NVarChar);
                sql_param[7].Value = treeNode["Parent Key"];

                sql_param[8] = new SqlParameter("@RIGHTS_DEF_PKKeyForLogical", SqlDbType.NVarChar);
                sql_param[8].Value = treeNode["Primary Key"];

                sql_param[9] = new SqlParameter("@RIGHTS_DEF_itemType", SqlDbType.NVarChar);
                sql_param[9].Value = treeNode["Type"];

                sql_param[10] = new SqlParameter("@RIGHTS_DEF_childNodes", SqlDbType.Bit);
                sql_param[10].Value = treeNode["Childs"];

                sql_param[11] = new SqlParameter("@RIGHTS_DEF_itemLevel", SqlDbType.Int);
                sql_param[11].Value = treeNode["Level"];

                sql_param[12] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
                sql_param[12].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                sql_param[13] = new SqlParameter("@RIGHTS_DEF_level", SqlDbType.NVarChar);
                sql_param[13].Value = RIGHTS_MAIN_level;

                ExeState = objDAlCustome.ins_del_upd("sp_TBL_RIGHTS_DEF_insertion", sql_param, objSqlCommand, false);

                if (treeNode.HasChildren)
                {

                    foreach (TreeListNode node in treeNode.Nodes)
                    {
                        insertionRIGHT_DEF(pRIGHTS_DEF_ID, objSqlCommand, objDAlCustome, pstatus, node);
                    }

                }


            return true;

        }

        public DataSet insertionMDI()
        {

            DAL.DALCustome objDAlCustome = new DAL.DALCustome();
            SqlCommand objSqlCommand = new SqlCommand();
            SqlParameter[] sql_param = new SqlParameter[8];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = BRC_ID;

            sql_param[2] = new SqlParameter("@RIGHTS_MAIN_name", SqlDbType.NVarChar);
            sql_param[2].Value = RIGHTS_MAIN_name;

            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_roleID", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_roleID;

            sql_param[4] = new SqlParameter("@RIGHTS_MAIN_narration", SqlDbType.NVarChar);
            sql_param[4].Value = RIGHTS_MAIN_narration;

            sql_param[5] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[5].Value = RIGHTS_DEF_isDeleted;

            sql_param[6] = new SqlParameter("@RIGHTS_DEF_isActive", SqlDbType.Bit);
            sql_param[6].Value = RIGHTS_DEF_isActive;

            sql_param[7] = new SqlParameter("RIGHTS_MAIN_level", SqlDbType.NVarChar);
            sql_param[7].Value = RIGHTS_MAIN_level;

            DataSet ds = new DataSet();


            string Status = objDAlCustome.open_connection();

            if (Status != "ok")
            {
                objDAlCustome.transactioRollBack();
                return null;
            }

            //  ds = obj_dal.selection("sp_TBL_RIGHTS_MAIN_insertion", sql_param);

            ds = objDAlCustome.selection("sp_TBL_RIGHTS_MAIN_insertion", sql_param, objSqlCommand, true);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
            {

                objDAlCustome.transactioRollBack();
                return null;
            }
            else
            {


                string Id = ds.Tables[0].Rows[0][1].ToString();
                if (Id != "N")
                {

                    if (insertionRIGHT_DEF_MDI(Id, objSqlCommand, objDAlCustome, 'I'))
                    {

                        objDAlCustome.transactioCommit();
                        objDAlCustome.closeconnection();

                    }
                    else
                    {
                        objDAlCustome.transactioRollBack();
                        objDAlCustome.closeconnection();

                        return ds;

                    }
                }
                else
                {
                    objDAlCustome.transactioCommit();
                    objDAlCustome.closeconnection();

                    return ds;

                }
            }



            return ds;

        }

        public DataSet insertion()
        {

            DAL.DALCustome objDAlCustome = new DAL.DALCustome();
            SqlCommand objSqlCommand = new SqlCommand();
            SqlParameter[] sql_param = new SqlParameter[8];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = BRC_ID;

            sql_param[2] = new SqlParameter("@RIGHTS_MAIN_name", SqlDbType.NVarChar);
            sql_param[2].Value = RIGHTS_MAIN_name;

            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_roleID", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_roleID;

            sql_param[4] = new SqlParameter("@RIGHTS_MAIN_narration", SqlDbType.NVarChar);
            sql_param[4].Value = RIGHTS_MAIN_narration;

            sql_param[5] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[5].Value = RIGHTS_DEF_isDeleted;

            sql_param[6] = new SqlParameter("@RIGHTS_DEF_isActive", SqlDbType.Bit);
            sql_param[6].Value = RIGHTS_DEF_isActive;

            sql_param[7] = new SqlParameter("RIGHTS_MAIN_level", SqlDbType.NVarChar);
            sql_param[7].Value = RIGHTS_MAIN_level;

            DataSet ds = new DataSet();


            string Status = objDAlCustome.open_connection();

            if (Status != "ok")
            {
                objDAlCustome.transactioRollBack();
                return null;
            }

            //  ds = obj_dal.selection("sp_TBL_RIGHTS_MAIN_insertion", sql_param);

            ds = objDAlCustome.selection("sp_TBL_RIGHTS_MAIN_insertion", sql_param, objSqlCommand, true);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
            {
                objDAlCustome.transactioRollBack();
                return null;
            }
            else
            {

                string Id = ds.Tables[0].Rows[0][1].ToString();
                if (Id != "N")
                {

                    if (chkAllNodes
                        (Id, objSqlCommand, objDAlCustome, 'I'))
                    {

                        objDAlCustome.transactioCommit();
                        objDAlCustome.closeconnection();

                    }
                    else
                    {
                        objDAlCustome.transactioRollBack();
                        objDAlCustome.closeconnection();

                        return ds;

                    }
                }
                else
                {
                    objDAlCustome.transactioCommit();
                    objDAlCustome.closeconnection();

                    return ds;

                }
            }



            return ds;

        }

        public DataSet updation()
        {


           DAL.DALCustome objDAlCustome = new DAL.DALCustome();

            SqlCommand objSqlCommand = new SqlCommand();
            SqlParameter[] sql_param = new SqlParameter[9];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = BRC_ID;

            sql_param[2] = new SqlParameter("@RIGHTS_MAIN_ID", SqlDbType.NVarChar);
            sql_param[2].Value = RIGHTS_MAIN_ID;

            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_name", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_name;

            sql_param[4] = new SqlParameter("@RIGHTS_MAIN_roleID", SqlDbType.NVarChar);
            sql_param[4].Value = RIGHTS_MAIN_roleID;

            sql_param[5] = new SqlParameter("@RIGHTS_MAIN_narration", SqlDbType.NVarChar);
            sql_param[5].Value = RIGHTS_MAIN_narration;

            sql_param[6] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[6].Value = RIGHTS_DEF_isDeleted;

            sql_param[7] = new SqlParameter("@RIGHTS_DEF_isActive", SqlDbType.Bit);
            sql_param[7].Value = RIGHTS_DEF_isActive;

            sql_param[8] = new SqlParameter("RIGHTS_DEF_level", SqlDbType.NVarChar);
            sql_param[8].Value = RIGHTS_MAIN_level;


            DataSet ds = new DataSet();



            string Status = objDAlCustome.open_connection();

            if (Status != "ok")
            {
                objDAlCustome.transactioRollBack();
                return null;
            }


            //   ds = obj_dal.selection("sp_TBL_RIGHTS_MAIN_updation", sql_param);
            ds = objDAlCustome.selection("sp_TBL_RIGHTS_MAIN_updation", sql_param, objSqlCommand, true);

            if (GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
            {

                objDAlCustome.transactioRollBack();
                return null;
            }
            else
            {


                string Id = ds.Tables[0].Rows[0][1].ToString();
                if (Id != "N")
                {

                    if (chkAllNodes(Id, objSqlCommand, objDAlCustome, 'I'))
                    {
                        objDAlCustome.transactioCommit();
                        objDAlCustome.closeconnection();

                    }
                    else
                    {
                        objDAlCustome.transactioRollBack();
                        objDAlCustome.closeconnection();

                        return ds;
                    }
                }
                else
                {
                    objDAlCustome.transactioCommit();
                    objDAlCustome.closeconnection();

                    return ds;

                }
            }


            return ds;

        }

        public string deletion()
        {

            SqlParameter[] sql_param = new SqlParameter[6];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;
            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = CMP_ID;
            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = BRC_ID;
            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_ID", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_ID;
            sql_param[4] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[4].Value = RIGHTS_DEF_isDeleted;
            sql_param[5] = new SqlParameter("@RIGHTS_DEF_isActive", SqlDbType.Bit);
            sql_param[5].Value = RIGHTS_DEF_isActive;

            ExeState = obj_dal.ins_del_upd("sp_TBL_RIGHTS_MAIN_deletion", sql_param);
            return ExeState;

        }

        public DataSet selection()
        {

            SqlParameter[] sql_param = new SqlParameter[10];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;
            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = CMP_ID;
            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = BRC_ID;
            sql_param[3] = new SqlParameter("@RIGHTS_MAIN_ID", SqlDbType.NVarChar);
            sql_param[3].Value = RIGHTS_MAIN_ID;
            sql_param[4] = new SqlParameter("@RIGHTS_DEF_isDeleted", SqlDbType.Bit);
            sql_param[4].Value = RIGHTS_DEF_isDeleted;
            sql_param[5] = new SqlParameter("@RIGHTS_MAIN_level", SqlDbType.Int);
            sql_param[5].Value = RIGHTS_MAIN_level;


            sql_param[6] = new SqlParameter("@parentCMP_ID", SqlDbType.NVarChar);
            sql_param[6].Value = ParentCMP_ID;
            sql_param[7] = new SqlParameter("@parentBRC_ID", SqlDbType.NVarChar);
            sql_param[7].Value = ParentBRC_ID;
            sql_param[8] = new SqlParameter("@parentRIGHTS_MAIN_ID", SqlDbType.NVarChar);
            sql_param[8].Value = ParentRIGHTS_MAIN_ID;
            sql_param[9] = new SqlParameter("@parentRIGHTS_MAIN_level", SqlDbType.NVarChar);
            sql_param[9].Value = ParentRIGHTS_MAIN_level;


            DataSet ds = new DataSet();

            ds = obj_dal.selection("sp_TBL_RIGHTS_MAIN_selection", sql_param);

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
                    RIGHTS_MAIN_ID = (string)GEN.GEN_GEN.GenericClasses.Form.Gen_Form.checkDbNull(dt.Rows[0]["RIGHTS_MAIN_ID"]);
                    RIGHTS_MAIN_name = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_name"].ToString());
                    RIGHTS_MAIN_roleID = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_roleID"].ToString());
                    RIGHTS_MAIN_narration = Convert.ToString(dt.Rows[0]["RIGHTS_MAIN_narration"].ToString());
                    RIGHTS_DEF_isDeleted = Convert.ToBoolean(dt.Rows[0]["RIGHTS_DEF_isDeleted"].ToString());
                    RIGHTS_DEF_isActive = Convert.ToBoolean(dt.Rows[0]["RIGHTS_DEF_isActive"].ToString());
                    RIGHTS_MAIN_level = dt.Rows[0]["RIGHTS_MAIN_level"].ToString();
                }

            }

            return ds;

        }

    }
}

