using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace BLL.ACC_BLL.TBL_VCH_MAIN
{

    public class cls_TBL_VCH_MAIN
    {




        DAL.DALCustome obj_DALCustome = new DAL.DALCustome();
        public DevExpress.XtraEditors.XtraForm obj_XtraForm = new DevExpress.XtraEditors.XtraForm();
        BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG obj_cls_TBL_LOG = new BLL.GEN_BLL.TBL_LOG.cls_TBL_LOG();
        GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();
        public DataTable dt_Detail = new System.Data.DataTable();

        string ExeState = "";

        private string pSTATUS;
        public String STATUS
        {
            get { return pSTATUS; }
            set { pSTATUS = value; }
        }



        private string pVCH_ID = string.Empty;

        public string VCH_ID
        {
            get { return pVCH_ID; }
            set { pVCH_ID = value; }
        }




        private string pVCH_narration = string.Empty;
        public string VCH_narration
        {
            get { return pVCH_narration; }
            set { pVCH_narration = value; }
        }


        private string pVCH_prefix = string.Empty;
        public string VCH_prefix
        {
            get { return pVCH_prefix; }
            set { pVCH_prefix = value; }
        }


        private DateTime pVCH_date = DateTime.Now;
        public DateTime VCH_date
        {
            get { return pVCH_date; }
            set { pVCH_date = value; }
        }


        private string pVCH_transactionID = string.Empty;
        public string VCH_transactionID
        {
            get { return pVCH_transactionID; }
            set { pVCH_transactionID = value; }
        }


        private string pVCH_reference = string.Empty;
        public string VCH_reference
        {
            get { return pVCH_reference; }
            set { pVCH_reference = value; }
        }


        private string pVCH_chequeNo = string.Empty;
        public string VCH_chequeNo
        {
            get { return pVCH_chequeNo; }
            set { pVCH_chequeNo = value; }
        }


        private bool pVCH_isApproved = true;
        public bool VCH_isApproved
        {
            get { return pVCH_isApproved; }
            set { pVCH_isApproved = value; }
        }


        private bool pVCH_isEffectOnFinance = true;
        public bool VCH_isEffectOnFinance
        {
            get { return pVCH_isEffectOnFinance; }
            set { pVCH_isEffectOnFinance = value; }
        }



        private String pVCH_DETAILS_mainID;

        public String VCH_DETAILS_mainID
        {
            get { return pVCH_DETAILS_mainID; }
            set { pVCH_DETAILS_mainID = value; }
        }
        private int pVCH_DETAILS_orderingID;

        public int VCH_DETAILS_orderingID
        {
            get { return pVCH_DETAILS_orderingID; }
            set { pVCH_DETAILS_orderingID = value; }
        }


        private string pVCH_DETAILS_COA = string.Empty;
        public string VCH_DETAILS_COA
        {
            get { return pVCH_DETAILS_COA; }
            set { pVCH_DETAILS_COA = value; }
        }


        private string pVCH_DETAILS_referenceNo = string.Empty;
        public string VCH_DETAILS_referenceNo
        {
            get { return pVCH_DETAILS_referenceNo; }
            set { pVCH_DETAILS_referenceNo = value; }
        }


        private string pVCH_DETAILS_remarks = string.Empty;
        public string VCH_DETAILS_remarks
        {
            get { return pVCH_DETAILS_remarks; }
            set { pVCH_DETAILS_remarks = value; }
        }


        private decimal pVCH_DETAILS_debit = 0;
        public decimal VCH_DETAILS_debit
        {
            get { return pVCH_DETAILS_debit; }
            set { pVCH_DETAILS_debit = value; }
        }


        private decimal pVCH_DETAILS_credit = 0;
        public decimal VCH_DETAILS_credit
        {
            get { return pVCH_DETAILS_credit; }
            set { pVCH_DETAILS_credit = value; }
        }


        private DateTime pVCH_DETAILS_date = DateTime.Now;
        public DateTime VCH_DETAILS_date
        {
            get { return pVCH_DETAILS_date; }
            set { pVCH_DETAILS_date = value; }
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


        public bool insertionUpdationOnlyVCH(

               SqlCommand pobj_SqlCommand,
               DAL.DALCustome pobj_DALCustome,
               char pProcedureStatus,
                string pVCH_ID,
               string pVCH_narration,
               string pVCH_prefix,
               DateTime pVCH_date,
               string pVCH_transactionID,
               string pVCH_reference,
               string pVCH_chequeNo,
               bool pVCH_isApproved,
               bool pVCH_isEffectOnFinance,
               bool pIs_Auto_Generated,
               DataTable pdt_Detail,
               out string Id



               )
        {


            double debit = Convert.ToDouble(pdt_Detail.Compute("SUM(" + cls_CTBL_VCH_MAIN.VCH_DETAILS_debit + ")", string.Empty));
            double credit = Convert.ToDouble(pdt_Detail.Compute("SUM(" + cls_CTBL_VCH_MAIN.VCH_DETAILS_credit + ")", string.Empty));
            debit = Math.Round(debit, 2);
            credit = Math.Round(credit, 2);


            if (debit != credit)
            {
                obj_cls_MessageBox.MessageBoxStatic("Debit Credit Not equal!!");
                Id = "N";
                return false;

            }


            Id = "N";

            SqlParameter[] sql_param = new SqlParameter[14];

            sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[2] = new SqlParameter("@VCH_ID ", SqlDbType.NVarChar);
            sql_param[2].Value = pVCH_ID;


            sql_param[3] = new SqlParameter("@VCH_narration", SqlDbType.NVarChar);
            sql_param[3].Value = pVCH_narration;

            sql_param[4] = new SqlParameter("@VCH_prefix", SqlDbType.NVarChar);
            sql_param[4].Value = pVCH_prefix;

            sql_param[5] = new SqlParameter("@VCH_date", SqlDbType.DateTime);
            sql_param[5].Value = pVCH_date;

            sql_param[6] = new SqlParameter("@VCH_transactionID", SqlDbType.NVarChar);
            sql_param[6].Value = "";

            sql_param[7] = new SqlParameter("@VCH_reference", SqlDbType.NVarChar);
            sql_param[7].Value = pVCH_reference;

            sql_param[8] = new SqlParameter("@VCH_chequeNo", SqlDbType.NVarChar);
            sql_param[8].Value = pVCH_chequeNo;

            sql_param[9] = new SqlParameter("@VCH_isApproved", SqlDbType.Bit);
            sql_param[9].Value = true;

            sql_param[10] = new SqlParameter("@VCH_isEffectOnFinance", SqlDbType.Bit);
            sql_param[10].Value = true;

            sql_param[11] = new SqlParameter("@Is_Auto_Generated", SqlDbType.Bit);
            sql_param[11].Value = pIs_Auto_Generated;

            sql_param[12] = new SqlParameter("@Is_Deleted", SqlDbType.NVarChar);
            sql_param[12].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            sql_param[13] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
            sql_param[13].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


            DataSet ds = new DataSet();


            if (pProcedureStatus == 'I')
                ds = pobj_DALCustome.selection("sp_TBL_VCH_MAIN_insertion", sql_param, pobj_SqlCommand, true);
            else
                ds = pobj_DALCustome.selection("sp_TBL_VCH_MAIN_updation", sql_param, pobj_SqlCommand, true);
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
                Id = ds.Tables[0].Rows[0][1].ToString();

                if (Id != "N" && ExeState == "ok")
                {


                    pVCH_ID = Id;
                    VCH_DETAILS_orderingID = 0;
                    foreach (DataRow dr in pdt_Detail.Rows)
                    {


                        sql_param = new SqlParameter[12];

                        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
                        sql_param[0].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

                        sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
                        sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

                        sql_param[2] = new SqlParameter("@VCH_DETAILS_mainID", SqlDbType.NVarChar);
                        sql_param[2].Value = pVCH_ID;

                        sql_param[3] = new SqlParameter("@VCH_DETAILS_orderingID", SqlDbType.Int);
                        sql_param[3].Value = VCH_DETAILS_orderingID;


                        sql_param[4] = new SqlParameter("@VCH_DETAILS_COA", SqlDbType.NVarChar);
                        sql_param[4].Value = dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_COA];

                        sql_param[5] = new SqlParameter("@VCH_DETAILS_referenceNo", SqlDbType.NVarChar);
                        sql_param[5].Value = dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_referenceNo];

                        sql_param[6] = new SqlParameter("@VCH_DETAILS_remarks", SqlDbType.NVarChar);
                        sql_param[6].Value = dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_remarks];

                        string tmpStrDebit = Convert.ToDouble(dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_debit].ToString() == "" ? 0 : dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_debit]).ToString(GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.formatN3);
                        string tmpStrCredit = Convert.ToDouble(dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_credit].ToString() == "" ? 0 : dr[cls_CTBL_VCH_MAIN.VCH_DETAILS_credit]).ToString(GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.formatN3);





                        sql_param[7] = new SqlParameter("@VCH_DETAILS_debit", SqlDbType.Float);
                        sql_param[7].Value = Convert.ToDouble(tmpStrDebit);
                        sql_param[8] = new SqlParameter("@VCH_DETAILS_credit", SqlDbType.Float);
                        sql_param[8].Value = Convert.ToDouble(tmpStrCredit);
                        sql_param[9] = new SqlParameter("@VCH_DETAILS_date", SqlDbType.DateTime);
                        sql_param[9].Value = pVCH_date;

                        sql_param[10] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
                        sql_param[10].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

                        sql_param[11] = new SqlParameter("@User_ID", SqlDbType.NVarChar);
                        sql_param[11].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID;


                        ds = pobj_DALCustome.selection("sp_TBL_VCH_DETAILS_insertion", sql_param, pobj_SqlCommand, false);

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

                            if (Id != "N" && ExeState == "ok")
                            {
                                VCH_DETAILS_orderingID++;
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



                }

            }
            return true;
        }

        public bool insertionUpdation(char pProcedureStatus)
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


            string Id = "";

            if (


                   !insertionUpdationOnlyVCH(

             obj_SqlCommand,
             obj_DALCustome,
             pProcedureStatus,
              VCH_ID,
             VCH_narration,
             VCH_prefix,
             VCH_date,
             VCH_transactionID,
             VCH_reference,
             VCH_chequeNo,
             VCH_isApproved,
             VCH_isEffectOnFinance,
             Is_Auto_Generated,
             dt_Detail,
             out Id
             )
                  )
            {


                return false;
            }



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

            sql_param[3] = new SqlParameter("@VCH_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = VCH_ID;


            string Status = obj_DALCustome.open_connection();

            if (Status != "ok")
            {
                obj_DALCustome.transactioRollBack();
                obj_cls_MessageBox.MessageBoxStatic("Connection_E");

                return false;
            }

            DataSet ds = obj_DALCustome.selection("sp_TBL_VCH_MAIN_deletion", sql_param, obj_SqlCommand, true);

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

            SqlParameter[] sql_param = new SqlParameter[6];

            sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
            sql_param[0].Value = STATUS;

            sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
            sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;

            sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
            sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;

            sql_param[3] = new SqlParameter("@VCH_ID ", SqlDbType.NVarChar);
            sql_param[3].Value = VCH_ID;

            sql_param[4] = new SqlParameter("@VCH_prefix ", SqlDbType.NVarChar);
            sql_param[4].Value = VCH_prefix;

            sql_param[5] = new SqlParameter("@Is_Deleted", SqlDbType.Bit);
            sql_param[5].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;

            DataSet ds = obj_DALCustome.selection("sp_TBL_VCH_MAIN_selection", sql_param, obj_SqlCommand, true);

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
