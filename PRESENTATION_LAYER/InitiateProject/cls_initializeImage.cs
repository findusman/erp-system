using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace PRESENTATION_LAYER.InitiateProject
{
    class cls_initializeImage
    {

        public bool loadgimages()
        {
            DATASET.GEN_DATASET.cls_DataSet objcls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
            objcls_DataSet.f_TBL_IMG("ALL", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "", true, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
            DataSet ds = objcls_DataSet.g_TBL_IMG;
            Image obj_Imaegtmp = null;
            if (ds == null)
            {
                return false;
            }




            foreach (DataRow dr in ds.Tables[0].Rows)
            {


                System.IO.MemoryStream stream = new System.IO.MemoryStream((byte[])(dr[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG.cls_CTBL_IMG.IMG_image]));
                string imageName = dr[PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG.cls_CTBL_IMG.IMG_ID].ToString();
                obj_Imaegtmp= Image.FromStream(stream);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_16X16.Images.Add(obj_Imaegtmp, imageName);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_32X32.Images.Add(obj_Imaegtmp, imageName);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_64X64.Images.Add(obj_Imaegtmp, imageName);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_128X128.Images.Add(obj_Imaegtmp, imageName);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_256X256.Images.Add(obj_Imaegtmp, imageName);
                GEN.GEN_GEN.GenericClasses.Images.cls_Images.ImageListCollection_512X512.Images.Add(obj_Imaegtmp, imageName);

                

            }

            return true;

        }



    }
}
