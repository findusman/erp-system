using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.ComponentModel;

namespace PRESENTATION_LAYER
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

              if (System.IO.File.Exists(Environment.CurrentDirectory + "//NewConfigfile.txt"))
              {
                    String[] Arr = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "//NewConfigfile.txt");

                    if (Arr.Length > 0 && Arr != null)
                    {

                          try
                          {
                                DAL.DALCustome.IsWindowsAutheticate = Convert.ToBoolean(Arr[0]);

                                DAL.DALCustome.SERVERNAME2 = Arr[1];
                                DAL.DALCustome.DATABASE = Arr[2];
                                DAL.DALCustome.USERID = Arr[3];
                                DAL.DALCustome.PASSWORD = Arr[4];
                          }



                          catch { DevExpress.XtraEditors.XtraMessageBox.Show("Config File Is Corrupted", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

                    }
                    else
                    {
                          DevExpress.XtraEditors.XtraMessageBox.Show("Config File Is Corrupted", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                          return;
                    }
              }
              else
              {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Config File Missing!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
              }

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BonusSkins).Assembly); 
          
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress");
           Application.Run(new GEN_PRESENTATION_LAYER.Users_Login.frm_LOGIN());

            
            //Application.Run(new PRESENTATION_LAYER.MDIClassic());
            //Application.Run(new XtraForm3());
            //Application.Run(new GEN_PRESENTATION_LAYER.Forms.TBL_TEMP_MAIN.frm_TBL_TEMP_MAIN1("N",true));


        }

        //public class SkinManager : Component
        //{
        //    public SkinManager()
        //    {
        //        DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.DigiPruSkins).Assembly);
        //    }
        //}
    }
}