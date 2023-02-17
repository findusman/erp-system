using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using GEN.GenericClasses;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Users_Login
{
    public partial class frm_ChangePassword : Form
    {

        Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false;
        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

        public frm_ChangePassword()
        {
                       
            InitializeComponent();
            this.Tag = this.Name;     
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //changePass();
        }


        //private void changePass()
        //{

        //    string newPass = txtNew.Text.Trim();
        //    string oldPass = txtOld.Text.Trim();
        //    string varifyPass = txtVarify.Text.Trim();


        //    if (oldPass == "")
        //    {
        //        txtOld.Select();
        //        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_provide_val, "S_E");
        //        return;
        //    }
        //    else if (newPass == "")
        //    {
        //        txtNew.Select();
        //        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_provide_val, "S_E");
        //        return;
        //    }
        //    else if (varifyPass == "")
        //    {
        //        txtVarify.Select();
        //        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_provide_val, "S_E");
        //        return;
        //    }


        //    if (newPass == varifyPass)
        //    {

        //        DataSet ds = null;
        //       // BLL.GEN_BLL.TBL_USERS.cls_USERS_LOGIN obj = new BLL.GEN_BLL.TBL_USERS.cls_USERS_LOGIN();

        //        try
        //        {
        //            obj.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;
        //            obj.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
        //            obj.USERS_loginID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_LOGIN_ID;
        //            obj.USERS_password = oldPass;


        //            ds = obj.selection();

        //            if (ds != null)
        //            {
        //                if (ds.Tables[0].Rows[0]["Exec"].ToString() == "ok")
        //                {
        //                    obj.STATUS = "P";
        //                    obj.USERS_password = newPass;
        //                    ds = null;
        //                    ds = obj.selection();

        //                    if (ds.Tables[0].Rows[0]["Exec"].ToString() == "ok")
        //                    {
        //                        objcls_MessageBox.MessageBoxStatic("U_S");
        //                        refresh();
        //                    }


        //                }
        //            }

        //        }

        //        catch
        //        {
        //            objcls_MessageBox.MessageBoxStatic("U_E");
        //        }

        //    }
        //    else
        //    {
        //        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_pass_missmatched, "S_E");
        //    }





        //}




        //private void refresh()
        //{
        //    txtNew.Text = "";
        //    txtOld.Text = "";
        //    txtVarify.Text = "";
        //    txtOld.Select();
        //}


        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {

            //try
            //{

            //    DataRow[] drr = MDI.dtRightsButton.Select(" [Parent Key] = '" +  this.Tag + "'");
            //    foreach (DataRow d in drr)
            //    {
            //        if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_del == d["Primary Key"].ToString())
            //             {
            //                 isAllowedDeletion = true;
            //             }
            //             else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_insert == d["Primary Key"].ToString())
            //             {
            //                 isAllowedInsertion = true;
            //             }
            //             else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_update == d["Primary Key"].ToString())
            //             {
            //                 isAllowedUpdation = true;
            //             }
            //    }

            //}
            //catch
            //{
            //    //throw;
            //}




            //if (!isAllowedUpdation)
            //    this.SimpleButton_Save.Enabled = false;
            



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }


    }
}
