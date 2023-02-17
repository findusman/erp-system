using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using GEN.GenericClasses;
using GEN;

using System.Data;
using System.Windows.Forms;
using System.Drawing;
using PRESENTATION_LAYER;

namespace PRESENTATION_LAYER.GEN_PRESENTATION_LAYER.DEF_FORM.frm_TBL_IMG
{
    public class cls_TBL_IMG_P
    {

        Boolean isAllowedInsertion = true, isAllowedUpdation = true, isAllowedDeletion = true, isDisturebedOnce = false;
        GEN.GEN_GEN.GenericClasses.Form.Gen_Form ObjGenForm;


        GEN.GEN_GEN.GenericClasses.cls_MessageBox objcls_MessageBox = new GEN.GEN_GEN.GenericClasses.cls_MessageBox();

        DATASET.GEN_DATASET.cls_DataSet objcls_DataSet = new DATASET.GEN_DATASET.cls_DataSet();
        GEN.GEN_GEN.Look.frlLOOKUP objfrlLOOKUP = null;

        bool isImageSelected = false;

     //   GenImages.GEN_Images objGENIMAGE;


        BLL.GEN_BLL.cls_TBL_IMG objcls_TBL_IMG = new BLL.GEN_BLL.cls_TBL_IMG();

        frm_TBL_IMG objfrm_TBL_IMG = null;

        

        void InitializeComponents(frm_TBL_IMG pobjfrm_TBL_IMG, String pID)
        {
            
            objfrm_TBL_IMG = pobjfrm_TBL_IMG;
            GEN.GEN_GEN.GenericClasses.cls_CustomeForm.applyPropertiesOnXtraForm(objfrm_TBL_IMG, 'A');

            loadGridLookUpEdit('A');

            if (pID == "N")
                Referesh(true);
            else
            {
                objfrm_TBL_IMG.TextEdit_IMG_ID.Text = pID;

                selection("V", objfrm_TBL_IMG.TextEdit_IMG_ID.Text.Trim());
            }
            
        }

        //public bool loadgLOBALimages()
        //{

        //    objcls_DataSet.f_TBL_IMG("ALL", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, "", objfrm_TBL_IMG.CheckEdit_IMG_isActive.Checked, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
        //    DataSet ds = objcls_DataSet.g_TBL_IMG;
        //    if (ds == null)
        //    {
        //        objcls_MessageBox.MessageBoxStatic("BLL_E");
        //        Referesh(false);
        //        return false;

        //    }
        //}

        public cls_TBL_IMG_P(frm_TBL_IMG pobjfrm_TBL_IMG, String pID, GEN.GEN_GEN.GenericClasses.Form.Gen_Form pObjGenForm)
        {
            ObjGenForm = pObjGenForm;
            InitializeComponents(pobjfrm_TBL_IMG, pID);

        }

        public bool validate(out string value)
        {

            if (objfrm_TBL_IMG.DBStatus == 'I')
            {
                if (!isAllowedInsertion)
                {
                    value = objcls_MessageBox.error_insert_rights;
                    return false;

                }

            }
            if (objfrm_TBL_IMG.DBStatus == 'U')
            {
                if (!isAllowedUpdation)
                {
                    value = objcls_MessageBox.error_update_rights;
                    return false;

                }

            }

            if (!isImageSelected)
            {

                value = "V_P";
                return false;

            }

            value = "N";
            return true;
        }

        public void getMax()
        {

            int tempID = objcls_DataSet.f_GETMAX("TBL_IMG", 0, 0, 0, "", "", "");
            objfrm_TBL_IMG.maxID = tempID.ToString();
            objfrm_TBL_IMG.TextEdit_IMG_ID.Text = objfrm_TBL_IMG.maxID;
        }

        public void loadGridLookUpEdit(char Status)
        {
            if (Status == 'A')
            {


            }

        }



        public byte[] SaveImage(Image img)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return arr;
        }


        public string valueGetting()
        {

            try
            {

                string validate_value = "";
                if (!validate(out validate_value))
                {

                    if (validate_value == "N")
                        return "V_P";
                    else
                        return validate_value;

                }

                objcls_TBL_IMG.CMP_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID;  //Convert.ToString(objfrm_TBL_IMG.TextEdit_CMP_ID.Text.Trim());
                objcls_TBL_IMG.BRC_ID = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID; //Convert.ToString(objfrm_TBL_IMG.TextEdit_BRC_ID.Text.Trim());
                objcls_TBL_IMG.IMG_ID = Convert.ToString(objfrm_TBL_IMG.TextEdit_IMG_ID.Text.Trim().Trim() == "" ? "0" : objfrm_TBL_IMG.TextEdit_IMG_ID.Text.Trim());
                objcls_TBL_IMG.IMG_name = Convert.ToString(objfrm_TBL_IMG.TextEdit_IMG_name.Text.Trim());
                objcls_TBL_IMG.IMG_format = Convert.ToString(objfrm_TBL_IMG.TextEdit_IMG_format.Text);
                objcls_TBL_IMG.IMG_imageSize = Convert.ToDouble(objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text.Trim());
                objcls_TBL_IMG.IMG_imageSmallSize = Convert.ToDouble(objfrm_TBL_IMG.TextEdit_IMG_imageSmallSize.Text.Trim());
                objcls_TBL_IMG.IMG_imageMediumSize = Convert.ToDouble(objfrm_TBL_IMG.TextEdit_IMG_imageMediumSize.Text.Trim());
                objcls_TBL_IMG.IMG_imagelargeSize = Convert.ToDouble(objfrm_TBL_IMG.TextEdit_IMG_imagelargeSize.Text.Trim());
                objcls_TBL_IMG.IMG_description = Convert.ToString(objfrm_TBL_IMG.MemoEdit_IMG_description.Text);
                objcls_TBL_IMG.IMG_isActive = objfrm_TBL_IMG.CheckEdit_IMG_isActive.Checked;
                objcls_TBL_IMG.IMG_isDeleted = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;  // Convert.ToBoolean(objfrm_TBL_IMG.TextEdit_IMG_isDeleted.Text.Trim());
                objcls_TBL_IMG.IMG_image = SaveImage(objfrm_TBL_IMG.Picture_IMG_image.Image);
                objcls_TBL_IMG.IMG_imagelarge = SaveImage(objfrm_TBL_IMG.Picture_IMG_imagelarge.Image);
                objcls_TBL_IMG.IMG_imageMedium = SaveImage(objfrm_TBL_IMG.Picture_IMG_imageMedium.Image);
                objcls_TBL_IMG.IMG_imageSmall = SaveImage(objfrm_TBL_IMG.PictureEdit_IMG_imageSmall.Image);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return "ok";

        }

        public Image RetrieveImage(Byte[] MyData)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream(MyData);
            
            return Image.FromStream(stream);

        }




        public string valueSetting(System.Data.DataSet ds)
        {

            try

            {
                Referesh(false);
                DataTable dt_Main = ds.Tables[0];


                //  objfrm_TBL_IMG.TextEdit_CMP_ID.Text.Trim() = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.CMP_ID]);
                //objfrm_TBL_IMG.TextEdit_BRC_ID.Text.Trim() = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.BRC_ID]);
                objfrm_TBL_IMG.TextEdit_IMG_ID.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_ID]);
                objfrm_TBL_IMG.TextEdit_IMG_name.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_name]);
                objfrm_TBL_IMG.TextEdit_IMG_format.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_format]);
                objfrm_TBL_IMG.Picture_IMG_image.Image = RetrieveImage((byte[])(dt_Main.Rows[0][cls_CTBL_IMG.IMG_image]));
                objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imageSize]);
                objfrm_TBL_IMG.PictureEdit_IMG_imageSmall.Image=  RetrieveImage((byte[])(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imageSmall]));
                objfrm_TBL_IMG.TextEdit_IMG_imageSmallSize.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imageSmallSize]);
                objfrm_TBL_IMG.Picture_IMG_imageMedium.Image = RetrieveImage((byte[])(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imageMedium]));
                objfrm_TBL_IMG.TextEdit_IMG_imageMediumSize.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imageMediumSize]);
                objfrm_TBL_IMG.PictureEdit_IMG_imageSmall.Image = RetrieveImage((byte[])(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imagelarge]));
                objfrm_TBL_IMG.TextEdit_IMG_imagelargeSize.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_imagelargeSize]);
                objfrm_TBL_IMG.MemoEdit_IMG_description.Text = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_description]);
                objfrm_TBL_IMG.CheckEdit_IMG_isActive.Checked = Convert.ToBoolean(dt_Main.Rows[0][cls_CTBL_IMG.IMG_isActive]);
                //objfrm_TBL_IMG.TextEdit_IMG_isDeleted.Text.Trim() = Convert.ToString(dt_Main.Rows[0][cls_CTBL_IMG.IMG_isDeleted]);
                objfrm_TBL_IMG.DBStatus = 'U';

            }
            catch (Exception ex)
            {

                return ex.Message;

            }

            return "ok";

        }


        public void SelectImage()

        {
            try
            {
               
                
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Select  Image";
                    dlg.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        isImageSelected = true;

                        //pic
                        objfrm_TBL_IMG.Picture_IMG_image.Image = new  Bitmap(dlg.FileName);
                        objfrm_TBL_IMG.Picture_IMG_imagelarge.Image = new Bitmap(dlg.FileName);
                        objfrm_TBL_IMG.Picture_IMG_imageMedium.Image = new Bitmap(dlg.FileName);
                        objfrm_TBL_IMG.PictureEdit_IMG_imageSmall.Image = new Bitmap(dlg.FileName);
                        //frmt
                        objfrm_TBL_IMG.TextEdit_IMG_format.Text = GetImageFormat(objfrm_TBL_IMG.Picture_IMG_image.Image);

                        //size
                        objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text = Convert.ToString(objfrm_TBL_IMG.Picture_IMG_image.Image.Size.Width * objfrm_TBL_IMG.Picture_IMG_image.Image.Size.Height);

                        
                                  objfrm_TBL_IMG.TextEdit_IMG_imagelargeSize.Text = objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text;
                                   objfrm_TBL_IMG.TextEdit_IMG_imageMediumSize.Text =  objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text;
                                   objfrm_TBL_IMG.TextEdit_IMG_imageSmallSize.Text = objfrm_TBL_IMG.TextEdit_IMG_imageSize.Text;


                      
                       
                    }
                }

                
            }
            catch 
            {

               
            }

        }


        public static String GetImageFormat(System.Drawing.Image img)
        {
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return "Jpeg";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return "Bmp";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return "Png";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
                return "Emf";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
                return "Exif";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return "Gif";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
                return "Icon";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
                return "MemoryBmp";
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
                return "Tiff";
            else
                return "Wmf";
        }

        public void Referesh(bool isComplete)
        {
            objfrm_TBL_IMG.DBStatus = 'I';

            if (isComplete)
            {


                try
                {
                    DataRow[] drr = MDIClassic.dtRightsButton.Select(" [Parent Key] = '" + objfrm_TBL_IMG.Tag + "'");
                    foreach (DataRow d in drr)
                    {
                        if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_del == d["Primary Key"].ToString())
                         {
                             isAllowedDeletion = true;
                         }
                         else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_insert == d["Primary Key"].ToString())
                         {
                             isAllowedInsertion = true;
                         }
                         else if (GEN.GEN_GEN.GenericClasses.UserRIghts.cls_RightsKeys.key_update == d["Primary Key"].ToString())
                         {
                             isAllowedUpdation = true;
                         }
                    }

                }
                catch
                {
                    //throw;
                }


         
                if (!isAllowedInsertion && !isAllowedUpdation)
                    objfrm_TBL_IMG.SimpleButton_Save.Enabled = false;
                if (!isAllowedDeletion)
                    objfrm_TBL_IMG.SimpleButton_Delete.Enabled = false;


                loadGridLookUpEdit('A');
            }

            ObjGenForm.GenRefresh();
            objfrm_TBL_IMG.Picture_IMG_image.Image = GEN.GEN_GEN.GenericClasses.Images.cls_Images.defaultImageListCollection.Images["ImageForm"];
            getMax();
            PRESENTATION_LAYER.InitiateProject.cls_initializeImage obj_cls_initializeImage = new PRESENTATION_LAYER.InitiateProject.cls_initializeImage();
            bool is_All_Images_Loded_Propoerly = obj_cls_initializeImage.loadgimages();

        }


        public void Delete()
        {

            string executeFunctions = "";

            if (!isAllowedDeletion)
            {
                objcls_MessageBox.MessageBoxStatic("D_RE");
                Referesh(false);
                return;

            }

            if (objfrm_TBL_IMG.TextEdit_IMG_ID.Text != "")
            {

                if (objcls_MessageBox.MessageBoxStatic("D_Q") == "no")
                {

                    return;

                }


                objcls_TBL_IMG.STATUS = "D";
                objcls_TBL_IMG.IMG_ID = Convert.ToString(objfrm_TBL_IMG.TextEdit_IMG_ID.Text.Trim().Trim() == "" ? "0" : objfrm_TBL_IMG.TextEdit_IMG_ID.Text.Trim());



                executeFunctions = objcls_TBL_IMG.deletion();
                if (executeFunctions == "ok")
                {
                    isDisturebedOnce = true;
                    objcls_MessageBox.MessageBoxStatic("D_S");


                    Referesh(false);

                }
                else
                {

                    objcls_MessageBox.MessageBoxDynamics(executeFunctions, "D_E");

                    Referesh(false);

                }


            }
            else
            {

                objcls_MessageBox.MessageBoxStatic("SE_E");

                Referesh(false);



            }


        }



        public void Save()
        {


            string executeFunctions = "";

            if (objfrm_TBL_IMG.DBStatus == 'I')
            {

                executeFunctions = valueGetting();

                if (executeFunctions != "ok")
                {
                    if (executeFunctions != "N")
                    {
                        if (executeFunctions == "V_P")
                        {
                            objcls_MessageBox.MessageBoxStatic("VP_E");
                            return;
                        }
                        else
                        {
                            objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                            return;

                        }
                    }
                }





                if (executeFunctions == "ok")
                {

                    if (objcls_MessageBox.MessageBoxStatic("I_Q") == "no")
                    {
                        return;
                    }
                    DataSet ds = objcls_TBL_IMG.insertion();

                    if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                    {
                        executeFunctions = ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {

                        objcls_MessageBox.MessageBoxStatic("BLL_E");
                        Referesh(false);
                        return;
                    }

                    if (executeFunctions == "ok")
                    {
                        isDisturebedOnce = true;
                        Referesh(false);
                        objcls_MessageBox.MessageBoxStatic("I_S");


                    }
                    else
                    {


                        objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");

                        return;

                    }
                }
                else
                {


                    objcls_MessageBox.MessageBoxDynamics(executeFunctions, "I_E");
                    Referesh(false);

                }


            }


            else if (objfrm_TBL_IMG.DBStatus == 'U')
            {

                if (objfrm_TBL_IMG.TextEdit_IMG_ID.Text != "")
                {
                    executeFunctions = valueGetting();

                    if (executeFunctions == "V_P")
                    {

                        objcls_MessageBox.MessageBoxStatic("VP_E");
                        return;
                    }






                    if (executeFunctions == "ok")
                    {

                        if (objcls_MessageBox.MessageBoxStatic("U_Q") == "no")
                        {

                            return;
                        }


                        DataSet ds = objcls_TBL_IMG.updation();

                        if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                        {
                            executeFunctions = ds.Tables[0].Rows[0][0].ToString();
                        }
                        else
                        {

                            objcls_MessageBox.MessageBoxStatic("BLL_E");
                            Referesh(false);
                            return;

                        }


                        if (executeFunctions == "ok")
                        {
                            isDisturebedOnce = true;
                            objcls_MessageBox.MessageBoxStatic("U_S");
                            Referesh(false);

                        }
                        else
                        {


                            objcls_MessageBox.MessageBoxDynamics(executeFunctions, "U_E");

                            return;

                        }




                    }

                    else
                    {


                        objcls_MessageBox.MessageBoxDynamics(executeFunctions, "U_E");
                        Referesh(false);

                    }

                }
                else
                {


                    objcls_MessageBox.MessageBoxStatic("SE_E");


                }
            }

        }

        public void selection(string pStatus, string pId)
        {
            if (pStatus == "A")
            {
                objcls_DataSet.f_TBL_IMG("A", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, pId, objfrm_TBL_IMG.CheckEdit_IMG_isActive.Checked, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
                DataSet ds = objcls_DataSet.g_TBL_IMG;

                if (ds == null)
                {
                    objcls_MessageBox.MessageBoxStatic("BLL_E");
                    Referesh(false);
                    return;

                }


                objfrlLOOKUP = new GEN.GEN_GEN.Look.frlLOOKUP(ds, 4, true, "100,286,50", 1, "", "", true, "IDs",false);

                objfrlLOOKUP.ShowDialog();

                string value = GEN.GEN_GEN.Look.frlLOOKUP.value;

                if (value != "")
                {

                    string[] cols_values = value.Split('|');
                    selection("V", cols_values[0]);
                }



            }
            else
            {
                objcls_DataSet.f_TBL_IMG("V", GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID, pId, objfrm_TBL_IMG.CheckEdit_IMG_isActive.Checked, GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted, false);
                DataSet ds = objcls_DataSet.g_TBL_IMG;
                string executeFunctions = "";

                if (!GEN.GEN_GEN.GenericClasses.DataTables.cls_NativDataSet.checkIsNullIsNoTableIsTableEmpty(ds, 0))
                {
                    executeFunctions = valueSetting(ds);
                }
                else
                {

                    objcls_MessageBox.MessageBoxStatic("TB_E");
                    Referesh(false);
                    return;

                }


                if (executeFunctions != "ok")
                {
                    objcls_MessageBox.MessageBoxDynamics(executeFunctions, "S_E");
                    return;

                    Referesh(false);


                }


            }

        }




    }
}
