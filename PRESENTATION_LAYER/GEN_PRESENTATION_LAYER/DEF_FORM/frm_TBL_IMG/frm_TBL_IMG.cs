using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG
{
    public partial class frm_TBL_IMG : DevExpress.XtraEditors.XtraForm
    {


        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;


        public char DBStatus = 'I';
        cls_TBL_IMG_P objcls_TBL_IMG_P = null;
        public string maxID = "";

        public frm_TBL_IMG()
        {
            InitializeComponent();
        }
        
        public frm_TBL_IMG(String pID)
        {
            this.Tag = this.Name;
            InitializeComponent();
            ObjGenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);           
            objcls_TBL_IMG_P = new cls_TBL_IMG_P(this,pID,ObjGenForm);		
	        
            
            
            
            ObjGenForm.Formatting();
            ObjGenForm.Appreance();        
    




        }


           


//                                             SimpleButton_List

         public void SimpleButton_List_Click(object sender, EventArgs e)
         {
               objcls_TBL_IMG_P.selection("A", "0");
         }







//                                             SimpleButton_Clear

         public void SimpleButton_Clear_Click(object sender, EventArgs e)
         {
               objcls_TBL_IMG_P.Referesh(false);
         }



//                                             SimpleButton_Clear_A

         public void SimpleButton_Clear_A_Click(object sender, EventArgs e)
         {
               objcls_TBL_IMG_P.Referesh(true);
         }



//                                             SimpleButton_Delete

         public void SimpleButton_Delete_Click(object sender, EventArgs e)
         {
               objcls_TBL_IMG_P.Delete();
         }



//                                             SimpleButton_Save

         public void SimpleButton_Save_Click(object sender, EventArgs e)
         {
               objcls_TBL_IMG_P.Save();
         }

        

//                                             SimpleButton_Exit

         public void SimpleButton_Exit_Click(object sender, EventArgs e)
         {
               this.Close();
         }




   public void TextEdit_IMG_ID_KeyDown(object sender, KeyEventArgs e)
        {
         if (e.KeyData == Keys.Enter)
            {
            if (TextEdit_IMG_ID.Text != "" && TextEdit_IMG_ID.Text != "0")
                objcls_TBL_IMG_P.selection("V", TextEdit_IMG_ID.Text.Trim());
           else
            if ( TextEdit_IMG_ID.Text != maxID.ToString())
               objcls_TBL_IMG_P.Referesh(false);
            }
        }	

       
     private void frm_TBL_IMG_KeyDown(object sender, KeyEventArgs e)
        {
            ObjGenForm.ShortKey(e);
        }

     private void LabelControl_IMG_imageSmall_Click(object sender, EventArgs e)
     {

     }

     private void frm_TBL_IMG_Load(object sender, EventArgs e)
     {

     }

     private void simpleButton1_Click(object sender, EventArgs e)
     {
         objcls_TBL_IMG_P.SelectImage();
     }

     private void LabelControl_IMG_isActive_Click(object sender, EventArgs e)
     {

     }

     private void CheckEdit_IMG_isActive_CheckedChanged(object sender, EventArgs e)
     {

     }



      }
}