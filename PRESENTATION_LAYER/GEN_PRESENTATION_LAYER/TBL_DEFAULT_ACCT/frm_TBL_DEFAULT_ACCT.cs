using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

using System.Windows.Forms;
using DevExpress.XtraEditors;
//using GEN_BLL;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT
{
    public partial class frm_TBL_DEFAULT_ACCT : DevExpress.XtraEditors.XtraForm
    {


        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;
        GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid;


        public char DBStatus = 'I';
        cls_TBL_DEFAULT_ACCT_P objcls_TBL_DEFAULT_ACCT_P = null;
        public string maxID = "";


        
        public frm_TBL_DEFAULT_ACCT(int x)
        {
            InitializeComponent();
        }

        public frm_TBL_DEFAULT_ACCT()
        {
            this.Tag = this.Name;
            InitializeComponent();
            ObjGenForm = new GEN.GEN_GEN.GenericClasses.Form.Gen_Form(this);
            ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(grdView, grdControl);

            objcls_TBL_DEFAULT_ACCT_P = new cls_TBL_DEFAULT_ACCT_P(this, ObjGenForm, ObjGenGrid);
            ObjGenForm.Formatting();
            ObjGenForm.Appreance();
            ObjGenGrid.Apperance("I");
            ObjGenGrid.Formatting();
            objcls_TBL_DEFAULT_ACCT_P.initiateGrid();

        }

        public void SimpleButton_Clear_Click(object sender, EventArgs e)
        {
            objcls_TBL_DEFAULT_ACCT_P.initiateGrid();
        }







        //                                             SimpleButton_Clear_A

        public void SimpleButton_Clear_A_Click(object sender, EventArgs e)
        {
            objcls_TBL_DEFAULT_ACCT_P.Referesh(true);
        }







       





        //                                             SimpleButton_Save

        public void SimpleButton_Save_Click(object sender, EventArgs e)
        {
            objcls_TBL_DEFAULT_ACCT_P.Save();
        }







        //                                             SimpleButton_Exit

        public void SimpleButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }







     

        private void frm_TBL_DEFAULT_ACCT_KeyDown(object sender, KeyEventArgs e)
        {
            ObjGenForm.ShortKey(e);
        }

        private void frm_TBL_DEFAULT_ACCT_Load(object sender, EventArgs e)
        {

        }


        private void grdView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            string ACCcode = grdView.GetRowCellValue(e.RowHandle, cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_CODE).ToString();
         
            if (e.Column.Caption == "Account Code")
            {
                grdView.SetRowCellValue(e.RowHandle, cls_CTBL_DEFAULT_ACCT.DEFAULT_ACCT_MATCH, ACCcode);
            }
        }

        private void grdView_KeyDown(object sender, KeyEventArgs e)
        {
            ObjGenGrid.ShortKey(e);
        }

       


    }
}