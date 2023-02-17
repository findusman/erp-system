using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Forms
{
    public partial class frm_products_without_margin : DevExpress.XtraEditors.XtraForm
    {
        public frm_products_without_margin()
        {
            InitializeComponent();
        }

        private void frm_products_without_margin_Load(object sender, EventArgs e)
        {
            DAL.DALCustome obj = new DAL.DALCustome();

            SqlParameter[] sql_param = new SqlParameter[1];

            sql_param[0] = new SqlParameter("@var", SqlDbType.NVarChar);
            sql_param[0].Value = "";

            var ds = obj.selection("select_products_without_marging", sql_param);
            gridControl1.DataSource = ds.Tables[0];
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
        }
    }
}