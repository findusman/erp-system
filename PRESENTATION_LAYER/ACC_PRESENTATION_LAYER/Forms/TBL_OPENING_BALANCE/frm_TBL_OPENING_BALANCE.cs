using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.Forms.TBL_OPENING_BALANCE
{
      public partial class frm_TBL_OPENING_BALANCE : DevExpress.XtraEditors.XtraForm
      {

            GEN.GEN_GEN.GenericClasses.cls_MessageBox obj_cls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();


            GEN.GEN_GEN.GenericClasses.Form.Gen_Form obj_GenForm;
            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;

            public char DBStatus = 'U';
            cls_TBL_OPENING_BALANCE_P objcls_TBL_OPENING_BALANCE_P = null;
            public string maxID = "";


            public frm_TBL_OPENING_BALANCE()
            {
                  InitializeComponent();
            }

            public frm_TBL_OPENING_BALANCE(String pID, bool pIs_DesturbanceOnce)
            {

                  try
                  {

                        InitializeComponent();
                        obj_GenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
                        ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(this.GridView_TBL_OPENING_BALANCE, this.GridControl_TBL_OPENING_BALANCE);

                        objcls_TBL_OPENING_BALANCE_P = new cls_TBL_OPENING_BALANCE_P(this, pID, obj_GenForm, ObjGenGrid, pIs_DesturbanceOnce);
                        obj_GenForm.Formatting();
                        obj_GenForm.Appreance();
                        ObjGenGrid.Apperance("I");
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }


       
            public void SimpleButton_Referesh_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_OPENING_BALANCE_P.Referesh("True");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Referesh_A_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_OPENING_BALANCE_P.Referesh("True");

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

     
            public void SimpleButton_Save_Click(object sender, EventArgs e)
            {

                  try
                  {

                        objcls_TBL_OPENING_BALANCE_P.Save();

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }

            public void SimpleButton_Exit_Click(object sender, EventArgs e)
            {

                  try
                  {

                        if (this.DBStatus == 'U')
                        {

                              obj_cls_MessageBox.MessageBoxStatic("C_E");
                              return;
                        }
                        this.Close();
                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }

            }



            private void frm_TBL_OPENING_BALANCE_KeyDown(object sender, KeyEventArgs e)
            {

                  try
                  {

                        obj_GenForm.ShortKey(e);

                  }
                  catch (Exception ex)
                  {
                        obj_cls_MessageBox.MessageBoxStatic("BLL_E");
                  }
            }


       
     
     


          

      }



}