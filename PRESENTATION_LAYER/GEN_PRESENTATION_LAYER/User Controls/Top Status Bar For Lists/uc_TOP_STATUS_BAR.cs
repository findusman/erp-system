using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.User_Controls.Top_Status_Bar_For_Lists
{
    public partial class uc_TOP_STATUS_BAR : DevExpress.XtraEditors.XtraUserControl
    {

        public DevExpress.XtraGrid.GridControl GridControl_tempPrivate = null;

        private DevExpress.XtraGrid.Views.Grid.GridView GridView_tempPrivate = null;


        public DevExpress.XtraGrid.GridControl GridControl_temp
        {

            get
            {

                return GridControl_tempPrivate;

            }
            set
            {
                GridControl_tempPrivate = value;
            }

        }

        public DevExpress.XtraGrid.Views.Grid.GridView GridView_tempPublic
        {

            get
            {

                return GridView_tempPrivate;

            }
            set
            {
                GridView_tempPrivate = value;
            }



        }


        public uc_TOP_STATUS_BAR()
        {
            InitializeComponent();
        }

        private void uc_TOP_STATUS_BAR_Load(object sender, EventArgs e)
        {

            GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView ObjGenGrid = new GEN.GEN_GEN.GenericClasses.Grid.Gen_GridView(GridView_tempPrivate, GridControl_tempPrivate);
            ObjGenGrid.Apperance("List");
            ObjGenGrid.isAllowDeleteColumns = false;
            ObjGenGrid.Formatting();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GEN.GEN_GEN.Look.Export_data obj_Export_data = new GEN.GEN_GEN.Look.Export_data(GridControl_tempPrivate);
            obj_Export_data.ShowDialog();
        }

   
    }
}
