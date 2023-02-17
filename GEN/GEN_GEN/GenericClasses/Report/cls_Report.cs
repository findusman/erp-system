using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;

namespace GEN.GEN_GEN.GenericClasses.Report
{
    public class cls_Report
    
    {
           public static void reportSetting(bool pIsReportHeader , XtraReport pRpt , bool islandscape , bool isLine )
        {
          //  rpt.BackColor = Color.Aqua;
            ReportHeaderBand obj_ReportHeader = new ReportHeaderBand();

            XRLabel obj_title = new XRLabel();
            obj_title.Text = "786 Software Technologies";
            obj_title.Name = "xrLabel1";
            obj_title.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            obj_title.SizeF = new System.Drawing.SizeF(500F, 23F);
            obj_title.LocationFloat = new DevExpress.Utils.PointFloat(5.0F, 5.0F);
            obj_title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obj_ReportHeader.Controls.Add(obj_title);


            obj_ReportHeader.HeightF = 50F;
            pRpt.Bands.Add(obj_ReportHeader);

            
            

         




            XRPictureBox obj_xrPictureBox1 = new XRPictureBox();
            // obj_xrPictureBox1
                
        

        }

    }
}
