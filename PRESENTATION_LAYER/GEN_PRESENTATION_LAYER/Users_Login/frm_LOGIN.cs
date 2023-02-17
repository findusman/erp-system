using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL.GEN_BLL;
using System.IO;
//using GEN.GenericClasses;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Users_Login
{
      public partial class frm_LOGIN : DevExpress.XtraEditors.XtraForm
      {


            BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS objcls_TBL_USERS = new BLL.GEN_BLL.TBL_USERS.cls_TBL_USERS();

            Boolean customerside = false;
            DATASET.GEN_DATASET.cls_DataSet obj_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
            // BLL.GEN_BLL.TBL_USERS.cls_USERS_LOGIN obj_USERS_APP = new BLL.GEN_BLL.TBL_USERS.cls_USERS_LOGIN();

            GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

            DataSet ds = new DataSet();

            void FUN_SCREEN_SETTING(bool full)
            {

                  objcls_TBL_USERS.obj_XtraForm = this;

                  if (full == true)
                  {

                        this.WindowState = FormWindowState.Maximized;
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.Bounds = Screen.PrimaryScreen.Bounds;

                  }

                  else
                  {
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        this.WindowState = FormWindowState.Maximized;
                  }

            }

            //public frm_LOGIN()
            //{
            //    InitializeComponent();
            //}
            public frm_LOGIN(bool CustomerSide = false)
            {



                  InitializeComponent();

                  //FUN_SCREEN_SETTING(true);

                  //lblTime.Text = DateTime.Now.ToString("HH:mm"); // Hour.ToString() + ":" + DateTime.Now.Minute.ToString("mm");
                  //lblDate.Text = DateTime.Now.Date.ToString("dddd, MMMM d");



                  //Timer timer = new Timer();
                  //timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
                  //timer.Interval = (1000) * (1);              // Timer will tick evert second
                  //timer.Enabled = true;                       // Enable the timer
                  //timer.Start();                              // Start the timer

                  //lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
                  //lblDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;

                  //if (CustomerSide)
                  //{
                  //      btnBack.Visible = true;
                  //}


            }


            //void timer_Tick(object sender, EventArgs e)
            //{
            //      lblTime.Text = DateTime.Now.ToString("HH:mm");
            //      lblDate.Text = DateTime.Now.Date.ToString("dddd, MMMM d");
            //}


            private void btn_cancel_Click(object sender, EventArgs e)
            {
                  //this.Close();
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID = "1";
                      
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID = "" ;
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID = "";
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID = "1";
                  MDIClassic obj_MDI = new MDIClassic();
                  obj_MDI.GV_isLoadRights = CheckEdit_isLoadRights.Checked;
                  obj_MDI.Show();
                  this.Close();
                    
            }

            private void frm_LOGIN_Load(object sender, EventArgs e)
            {



                  //try
                  //{
                  //      string[] str = File.ReadAllLines(Application.StartupPath + "/Data/1.txt");


                  //      DAL.DALCustome.SERVERNAME2 = str[0];
                  //      DAL.DALCustome.DATABASE = str[1];
                  //      DAL.DALCustome.USERID = str[2];
                  //      DAL.DALCustome.PASSWORD = str[3];



                  //}
                  //catch (Exception ex)
                  //{

                  //      MessageBox.Show("Connection Problem");
                  
                  //}

                 



                  //try
                  //{
                  //      DAL.DAL obj = new DAL.DAL();
                  //      DataSet ds = obj.selectionWithExecuteTextType("select * from sys.databases");

                  //      foreach (DataRow dr in ds.Tables[0].Rows)
                  //            Combobox_newDatabases.Properties.Items.Add(dr["name"]);
                  //      Combobox_newDatabases.SelectedItem = "DM_Current";

                  //}
                  //catch (Exception ex)
                  //{ }
                  lblcompany.Text = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_COMPANY_NAME;
                  textEdit_LOGIN_EDIT.Select();
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID = null;
                  GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID = null;


            }





            private void btn_login_Click(object sender, EventArgs e)
            {
                  //if (CheckEdit_isNewDatabase.Checked)

                  //      DAL.DALCustome.DATABASE = Combobox_newDatabases.SelectedItem.ToString();
                 
                  String login = textEdit_LOGIN_EDIT.Text.ToString().Trim();
                  String pass = textEdit_PASSWORD.Text.ToString().Trim();

                  if (login == "")
                  {
                        textEdit_LOGIN_EDIT.Focus();
                        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_provide_val, "S_E");
                        return;
                  }
                  if (pass == "")
                  {
                        textEdit_PASSWORD.Focus();
                        objcls_MessageBox.MessageBoxDynamics(objcls_MessageBox.error_provide_val, "S_E");
                        return;
                  }


                  objcls_TBL_USERS.USERS_loginID = textEdit_LOGIN_EDIT.Text.ToString().Trim();
                  objcls_TBL_USERS.USERS_password = textEdit_PASSWORD.Text.ToString().Trim();
                  DataRow dr = objcls_TBL_USERS.login();



                  //obj_DataSet.f_USERS_LOGIN(login, pass, true, "N");
                  //ds = obj_DataSet.g_USERS_LOGIN;

                  if (dr != null)
                  {
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID = dr[BLL.GEN_BLL.TBL_USERS.cls_CTBL_USERS.USERS_rightID].ToString();
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID = dr["CMP_ID"].ToString() == "" ? null : dr["CMP_ID"].ToString();
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID = dr["BRC_ID"].ToString() == "" ? null : dr["BRC_ID"].ToString();
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID = dr[BLL.GEN_BLL.TBL_USERS.cls_CTBL_USERS.priUSERS_ID].ToString();
                        GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID_RIGHTS_MAIN_rightAssigner = dr[BLL.GEN_BLL.TBL_RIGHTS_MAIN.cls_CTBL_RIGHTS_MAIN.RIGHTS_MAIN_rightAssigner].ToString();

                        this.Hide();

                        PRESENTATION_LAYER.InitiateProject.cls_InitilizeProject objcls_InitilizeProject = new InitiateProject.cls_InitilizeProject();
                        objcls_InitilizeProject.initialize(GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_RightID);
                        MDIClassic obj_MDI = new MDIClassic();
                        obj_MDI.GV_isLoadRights = CheckEdit_isLoadRights.Checked;
                        obj_MDI.user_name = textEdit_LOGIN_EDIT.Text.ToString().Trim();
                        obj_MDI.Show();
                  }


            }

            private void CheckEdit_isLoadRights_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                  this.Close();
            }

            private void CheckEdit_isNewDatabase_CheckedChanged(object sender, EventArgs e)
            {


            }
      }
}
