using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace PRESENTATION_LAYER
{
    public partial class MDIClassic : DevExpress.XtraEditors.XtraForm
    {



        public MDIClassic()
        {

            InitializeComponent();

        }



        public static DataTable dtRights = null;
        public static DataTable dtRightsButton = null;
        public bool GV_isLoadRights = false;
        DataRow drRights = null;
        DataRow[] drRightsRows = null;
        DataSet ds_Rights = null;

        public bool IsAlreadyOpen(Type formType)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    isOpen = true;
                }
            }

            return isOpen;
        }

        public bool IsAlreadyOpen(string pFormTag)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Tag == pFormTag)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    isOpen = true;
                }
            }

            return isOpen;
        }

       

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

          
        }



        private void SetSubMenuVisibility(BarSubItem subItem)
        {
              foreach (BarItemLink itemLink in subItem.ItemLinks)
                    if (itemLink.Item.Visibility == BarItemVisibility.Always)
                    {
                          subItem.Visibility = BarItemVisibility.Always;
                          return;
                    }

             // subItem.Visibility = BarItemVisibility.Never;
        }

        private void MDIClassic_Load(object sender, EventArgs e)
        {

              //SetSubMenuVisibility(bar2.);

              
              //foreach (BarItemLink subItem in bar2.ItemLinks)
              //{
              //      BarItem barItem = subItem.Item;
              //      Type t = barItem.GetType();
              //      //MessageBox.Show(t.Assembly.FullName);
              //      //MessageBox.Show(t.AssemblyQualifiedName);
              //      //MessageBox.Show(t.FullName);
              //      MessageBox.Show(t.Name);
              //      //MessageBox.Show(t.Namespace);

              //}


              //      //if (typeof(barItem == BarSubItem)
              //      //{ 
                    
              //      //}

              //     // BarSubItem barItem = (BarSubItem)subItem.Item;
              //      //MessageBox.Show(barItem.Caption);


              //}
                    //MessageBox.Show(subItem.Caption);
              //BarItemLink Itemlink = bar2.ItemLinks[0];
              //MessageBox.Show(Itemlink.Caption);
              //BarSubItem barItem = (BarSubItem)Itemlink.Item;
//barItem.

              //MessageBox.Show(barItem.Caption);
              //BarManagerCategory cat = barItem.Category;
              //MessageBox.Show(cat.Name);
              //foreach (BarSubItem subItem  in bar2.)
              //{
              //      MessageBox.Show(itemLink.Caption);



              //      foreach (BarItemLink itemLinkchild in itemLink.Item.ItemLinks)
              //      {
              //            MessageBox.Show(itemLink.Caption);

              //      }  
              //}     




            //GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID = null;
           // GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID = null;
            //GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_USER_ID = "1";
            //SkinHelper.InitSkinGallery(RibbonGalleryBarItem_Skins, true);
            //DATASET.GEN_DATASET.cls_DataSet.f_TBL_FINANCIAL_YEAR();
            //DataTable dt2 = DATASET.GEN_DATASET.cls_DataSet.g_TBL_FINANCIAL_YEAR.Tables[0];


            //if(GV_isLoadRights)
            //loadRights(ribbon);
            //ribbon.Minimized = true;

            PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.ConstructorClasses.ConstructorClass objConstructorClass = new PRESENTATION_LAYER.ACC_PRESENTATION_LAYER.ConstructorClasses.ConstructorClass();
            objConstructorClass.InitiateACC();

            GEN_PRESENTATION_LAYER.Forms.TBL_KEY.cls_LoadKeys obj_cls_LoadKeys = new GEN_PRESENTATION_LAYER.Forms.TBL_KEY.cls_LoadKeys();
            obj_cls_LoadKeys.loadKeysWithValues();

            //PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Generics.cls_Functions.code_Generator();
            //objConstructorClass.initiateCOA();
            //PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Generics.cls_Functions.GetCOA_All();
            ////   PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Generics.cls_Functions.GetFORMATS();

            PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic = this;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.defaultImageListCollection = this.ImageCollection_defaultImages;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_16X16 = this.ImageCollection_16X16;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_32X32 = this.ImageCollection_32X32;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_64X64 = this.ImageCollection_64X64;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_128X128 = this.ImageCollection_128X128;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_256X256 = this.ImageCollection_256X256;
            //GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_512X512 = this.ImageCollection_512X512;
            //GEN_PRESENTATION_LAYER.cls_StaticObjects.obj_MDIClassic = this;

            //PRESENTATION_LAYER.InitiateProject.cls_InitilizeProject obj_cls_InitilizeProject = new InitiateProject.cls_InitilizeProject();
            //obj_cls_InitilizeProject.initialize();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void BarButtonItem_keysTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_KEYS_TYPES("N", true, true, false);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_KEY("N", true, true, false);
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ACC_PRESENTATION_LAYER.COA.frm_COA obj = new ACC_PRESENTATION_LAYER.COA.frm_COA();
            obj.MdiParent = this;
            obj.Show();

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.frm_TBL_DEFAULT_ACCT obj = new GEN_PRESENTATION_LAYER.TBL_DEFAULT_ACCT.frm_TBL_DEFAULT_ACCT();
            obj.MdiParent = this;
            obj.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false,"CP");
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_DEPARTMENTS("N", true, true, false);
   
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_UNITS("N", true, true, false);
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VEHICLE_MAKERS("N", true, true, false);
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_CUSTOMERS("N", true, true, false);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SUPPLIERS("N", true, true, false);
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PRODUCTS("N", true, true, false);
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PACKINGS_MAIN("N", true, true, false);
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    //GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_TEMP_MAIN("N", true, true, false);

              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_TEMPLATE("N", true, true, false);
              

              //DevExpress.XtraBars.BarItemLinkCollection obj = bar2.ItemLinks;
              //foreach(DevExpress.XtraBars.BarItemLink itemLinks in bar2.ItemLinks)
              //{
              //      //Object obj = itemLinks.;

              //      //DevExpress.XtraBars.BarSubItemLink sub = itemLinks;
              //     DevExpress.XtraBars.BarItem singleItem = itemLinks.Item;



              //     DevExpress.XtraBars.BarManagerCategory c = singleItem.Category;
                  

                  
                  
              //}
            //BLL.ACC_BLL.cls_TBL_COA obj = new BLL.ACC_BLL.cls_TBL_COA();
            //obj.insertionDirect(1, "02-00-00-0000", "", 0, "C1", 0, "", true, "Insertion", "Child", false, true); 


        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_FINANCIAL_YEAR("N", true, true, false);
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_TEMPLATE("N", true, true, false);
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_RIGHTS_MAIN("N", "N", true, true, false);
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_USERS("N", true, true, false);
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_CMP("N", true, true, false);
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

              GEN_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_BRC("N", true, true, false);
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

              PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.Users_Login.frm_LOGIN objfrm_LOGIN = new GEN_PRESENTATION_LAYER.Users_Login.frm_LOGIN();
              objfrm_LOGIN.Show();
              this.Close();



        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false, "BP");
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false, "CR");
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false, "BR");
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false, "GV");
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_OPENING_BALANCE("1", true, true, false);
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              //ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger obj_frm_rpt_Ledger = new ACC_PRESENTATION_LAYER.Reports.Ledger.frm_rpt_Ledger();
              //obj_frm_rpt_Ledger.MdiParent = this;
              //obj_frm_rpt_Ledger.Show();

                ACC_PRESENTATION_LAYER.cls_ShowReportEntities.Ledger("",true,false);  

        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN("N", true, false, false, "Cash", "Purchase");
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN("N", true, false, false, "Credit", "Purchase");
  
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN("N", true, false, false, "Cash", "Purchase Return");
  
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN("N", true, false, false, "Credit", "Purchase Return");
  
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.TrialBalance("", true, false);
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
              //ACC_PRESENTATION_LAYER.cls_ShowReportEntities.TrialBalance("", true, false); 
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
             
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN("N", true, false, false, "Credit", "Sales");
  
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_SALES_AND_RETURN_MAIN("N", true, false, false, "Credit", "Sales Return");
  
        }

        private void barButtonItem52_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowReportEntities.ItemTransactionReport("N", DateTime.Now,DateTime.Now, true, false);  
        }

        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowReportEntities.Item_Stock_Summary(DateTime.Now, DateTime.Now, true, false);  
     
        }

        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_PURCHASE_AND_RETURN_MAIN("N", true, false, false, "Credit", "Opening");
  
        }

        private void barButtonItem55_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowFormEntities.TBL_VCH_MAIN("N", true, false, false, "OB");
        }

        private void barButtonItem56_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.profitorLoss("", true, false);
     
        }

        private void barButtonItem58_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.Ledger("", true, false);  
        }

        private void barButtonItem61_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.profitorLoss("", true, false);
        }

        private void barButtonItem62_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowReportEntities.Item_Stock_Summary(DateTime.Now, DateTime.Now, true, false);  
     
        }

        private void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowReportEntities.ItemTransactionReport("N", DateTime.Now, DateTime.Now, true, false);  
    
        }

        private void barButtonItem59_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.TrialBalance("", true, false);
        }

        private void barButtonItem60_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.balanceSheet("", true, false);
        }

        private void barButtonItem64_ItemClick(object sender, ItemClickEventArgs e)
        {
              IMS_PRESENTATION_LAYER.cls_ShowReportEntities.productWiseProfitorLoss("", true, false);
        }

        private void barButtonItem65_ItemClick(object sender, ItemClickEventArgs e)
        {
              DATA_MS.frmBACKUP obj = new DATA_MS.frmBACKUP();
              obj.ShowDialog();
        }

        private void barButtonItem66_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.AuditTrial("", true, false);
        }

        private void barButtonItem67_ItemClick(object sender, ItemClickEventArgs e)
        {
              ACC_PRESENTATION_LAYER.cls_ShowReportEntities.AccountSummary_filterByParent("Receiveables", "01-01-01-0000", true, false);
   
        }


    }

}