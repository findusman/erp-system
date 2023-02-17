using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
//using GEN_DAL;
 
namespace BLL.GEN_BLL
{
//     *****************************************************************************************************************************************************************
 
 
//                             Code Type:           Business Logic Layer
//                             Creation Date:       6/26/2014 9:37:10 AM
//                             Auther:              Muhammad Usman Raza Attari
//                             Developed By :       786 Software House 
 
 
//    *****************************************************************************************************************************************************************
 
  public   class cls_TBL_IMG
    {
      DAL.DALCustome obj_dal = new DAL.DALCustome();
 
        public Boolean  gproperty_allocatoin = false;
 
        string ExeState = "";
 
        private  String  status  ;
 
        public  String  STATUS  
        {
              get { return status; }
              set {status = value ; }
        }
 
       private string cMP_ID  = null;
 
        public  string  CMP_ID  
        {
              get { return cMP_ID; }
              set {cMP_ID = value ; }
        }
 
      private string bRC_ID = null;
 
        public  string  BRC_ID  
        {
              get { return bRC_ID; }
              set {bRC_ID = value ; }
        }
 
        private  string  iMG_ID  = string.Empty;
 
        public  string  IMG_ID  
        {
              get { return iMG_ID; }
              set {iMG_ID = value ; }
        }
 
        private  string  iMG_name  = string.Empty;
 
        public  string  IMG_name  
        {
              get { return iMG_name; }
              set {iMG_name = value ; }
        }
 
        private  string  iMG_format  = string.Empty;
 
        public  string  IMG_format  
        {
              get { return iMG_format; }
              set {iMG_format = value ; }
        }
 
        private  Byte[]  iMG_image ;

        public Byte[] IMG_image  
        {
              get { return iMG_image; }
              set {iMG_image = value ; }
        }
 
        private  Double  iMG_imageSize  = 0;
 
        public  Double  IMG_imageSize  
        {
              get { return iMG_imageSize; }
              set {iMG_imageSize = value ; }
        }

        private Byte[] iMG_imageSmall ;

        public Byte[] IMG_imageSmall  
        {
              get { return iMG_imageSmall; }
              set {iMG_imageSmall = value ; }
        }
 
        private  Double  iMG_imageSmallSize  = 0;
 
        public  Double  IMG_imageSmallSize  
        {
              get { return iMG_imageSmallSize; }
              set {iMG_imageSmallSize = value ; }
        }

        private Byte[] iMG_imageMedium;

        public Byte[] IMG_imageMedium  
        {
              get { return iMG_imageMedium; }
              set {iMG_imageMedium = value ; }
        }
 
        private  Double  iMG_imageMediumSize  = 0;
 
        public  Double  IMG_imageMediumSize  
        {
              get { return iMG_imageMediumSize; }
              set {iMG_imageMediumSize = value ; }
        }

        private Byte[] iMG_imagelarge;

        public Byte[] IMG_imagelarge  
        {
              get { return iMG_imagelarge; }
              set {iMG_imagelarge = value ; }
        }
 
        private  Double  iMG_imagelargeSize  = 0;
 
        public  Double  IMG_imagelargeSize  
        {
              get { return iMG_imagelargeSize; }
              set {iMG_imagelargeSize = value ; }
        }
 
        private  string  iMG_description  = string.Empty;
 
        public  string  IMG_description  
        {
              get { return iMG_description; }
              set {iMG_description = value ; }
        }

        private bool iMG_isActive = true;
 
        public  bool  IMG_isActive  
        {
              get { return iMG_isActive; }
              set {iMG_isActive = value ; }
        }
 
        private  bool  iMG_isDeleted  = true;
 
        public  bool  IMG_isDeleted  
        {
              get { return iMG_isDeleted; }
              set {iMG_isDeleted = value ; }
        }


        public DataTable GetAllImages()
        {

            SqlParameter[] sql_param = new SqlParameter[0];



            DataTable dt = new DataTable();

            dt = obj_dal.selection("sp_GET_All_Images", sql_param).Tables[0];

            if (dt == null)
            {
                return null;
            }

            return dt;

        }
 
        public DataSet insertion()
        {

              SqlParameter[] sql_param = new SqlParameter[15];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
        sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[1].Value = BRC_ID ;
 
 
        sql_param[2] = new SqlParameter("@IMG_name", SqlDbType.NVarChar);
        sql_param[2].Value = IMG_name ;
 
        sql_param[3] = new SqlParameter("@IMG_format", SqlDbType.NVarChar);
        sql_param[3].Value = IMG_format ;
 
        sql_param[4] = new SqlParameter("@IMG_image", SqlDbType.Image);
        sql_param[4].Value = IMG_image ;

        sql_param[5] = new SqlParameter("@IMG_imageSize", SqlDbType.Float);
        sql_param[5].Value = IMG_imageSize ;

        sql_param[6] = new SqlParameter("@IMG_imageSmall", SqlDbType.Image);
        sql_param[6].Value = IMG_imageSmall ;
 
        sql_param[7] = new SqlParameter("@IMG_imageSmallSize", SqlDbType.Float);
        sql_param[7].Value = IMG_imageSmallSize ;

        sql_param[8] = new SqlParameter("@IMG_imageMedium", SqlDbType.Image);
        sql_param[8].Value = IMG_imageMedium ;
 
        sql_param[9] = new SqlParameter("@IMG_imageMediumSize", SqlDbType.Float);
        sql_param[9].Value = IMG_imageMediumSize ;

        sql_param[10] = new SqlParameter("@IMG_imagelarge", SqlDbType.Image);
        sql_param[10].Value = IMG_imagelarge ;
 
        sql_param[11] = new SqlParameter("@IMG_imagelargeSize", SqlDbType.Float);
        sql_param[11].Value = IMG_imagelargeSize ;
 
        sql_param[12] = new SqlParameter("@IMG_description", SqlDbType.NVarChar);
        sql_param[12].Value = IMG_description ;
 
        sql_param[13] = new SqlParameter("@IMG_isActive", SqlDbType.NVarChar);
        sql_param[13].Value = IMG_isActive ;
 
        sql_param[14] = new SqlParameter("@IMG_isDeleted", SqlDbType.Bit);
        sql_param[14].Value = IMG_isDeleted ;

         DataSet ds = new DataSet();

         ds = obj_dal.selection("sp_TBL_IMG_insertion", sql_param);

          return ds;

        }
        
        
        
        
        
        public DataSet updation()

        {

              SqlParameter[] sql_param = new SqlParameter[16];
 
        sql_param[0] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[0].Value = CMP_ID ;
 
        sql_param[1] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[1].Value = BRC_ID ;
 
        sql_param[2] = new SqlParameter("@IMG_ID", SqlDbType.NVarChar);
        sql_param[2].Value = IMG_ID ;
 
        sql_param[3] = new SqlParameter("@IMG_name", SqlDbType.NVarChar);
        sql_param[3].Value = IMG_name ;
 
        sql_param[4] = new SqlParameter("@IMG_format", SqlDbType.NVarChar);
        sql_param[4].Value = IMG_format ;
 
        sql_param[5] = new SqlParameter("@IMG_image", SqlDbType.Image);
        sql_param[5].Value = IMG_image ;
 
        sql_param[6] = new SqlParameter("@IMG_imageSize", SqlDbType.Float);
        sql_param[6].Value = IMG_imageSize ;

        sql_param[7] = new SqlParameter("@IMG_imageSmall", SqlDbType.Image);
        sql_param[7].Value = IMG_imageSmall ;
 
        sql_param[8] = new SqlParameter("@IMG_imageSmallSize", SqlDbType.Float);
        sql_param[8].Value = IMG_imageSmallSize ;

        sql_param[9] = new SqlParameter("@IMG_imageMedium", SqlDbType.Image);
        sql_param[9].Value = IMG_imageMedium ;
 
        sql_param[10] = new SqlParameter("@IMG_imageMediumSize", SqlDbType.Float);
        sql_param[10].Value = IMG_imageMediumSize ;

        sql_param[11] = new SqlParameter("@IMG_imagelarge", SqlDbType.Image);
        sql_param[11].Value = IMG_imagelarge ;
 
        sql_param[12] = new SqlParameter("@IMG_imagelargeSize", SqlDbType.Float);
        sql_param[12].Value = IMG_imagelargeSize ;
 
        sql_param[13] = new SqlParameter("@IMG_description", SqlDbType.NVarChar);
        sql_param[13].Value = IMG_description ;
 
        sql_param[14] = new SqlParameter("@IMG_isActive", SqlDbType.NVarChar);
        sql_param[14].Value = IMG_isActive ;
 
        sql_param[15] = new SqlParameter("@IMG_isDeleted", SqlDbType.Bit);
        sql_param[15].Value = IMG_isDeleted ;

         DataSet ds = new DataSet();

         ds = obj_dal.selection("sp_TBL_IMG_updation", sql_param);

          return ds;

        }
        public string deletion()
        {

        SqlParameter[] sql_param = new SqlParameter[6];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = CMP_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = BRC_ID ;
        sql_param[3] = new SqlParameter("@IMG_ID", SqlDbType.NVarChar);
        sql_param[3].Value = IMG_ID ;
        sql_param[4] = new SqlParameter("@IMG_isActive", SqlDbType.NVarChar);
        sql_param[4].Value = IMG_isActive ;
        sql_param[5] = new SqlParameter("@IMG_isDeleted", SqlDbType.Bit);
        sql_param[5].Value = IMG_isDeleted ;


        ExeState = obj_dal.ins_del_upd("sp_TBL_IMG_deletion", sql_param);
        return ExeState ;

        }
        
        public DataSet selection()
        {

        SqlParameter[] sql_param = new SqlParameter[6];
 
        sql_param[0] = new SqlParameter("@STATUS", SqlDbType.NVarChar);
        sql_param[0].Value = STATUS ;
        sql_param[1] = new SqlParameter("@CMP_ID", SqlDbType.NVarChar);
        sql_param[1].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_CMP_ID ;
        sql_param[2] = new SqlParameter("@BRC_ID", SqlDbType.NVarChar);
        sql_param[2].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_BRC_ID;
        sql_param[3] = new SqlParameter("@IMG_ID", SqlDbType.NVarChar);
        sql_param[3].Value = IMG_ID ;
        sql_param[4] = new SqlParameter("@IMG_isActive", SqlDbType.NVarChar);
        sql_param[4].Value = IMG_isActive ;
        sql_param[5] = new SqlParameter("@IMG_isDeleted", SqlDbType.Bit);
        sql_param[5].Value = GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_isDeleted;
 

        DataSet ds = new DataSet();

        ds = obj_dal.selection("sp_TBL_IMG_selection", sql_param);

        if(ds == null)
        {
        return ds ;
        }

        int x = ds.Tables.Count;

         DataTable dt = new DataTable();

        dt = ds.Tables[0];

        if(gproperty_allocatoin == true)
        {
        if (dt.Rows.Count != 0)

        {

        CMP_ID = (dt.Rows[0]["CMP_ID"].ToString());
        BRC_ID =(dt.Rows[0]["BRC_ID"].ToString());
        IMG_ID = Convert.ToString( dt.Rows[0]["IMG_ID"].ToString());
        IMG_name = Convert.ToString( dt.Rows[0]["IMG_name"].ToString());
        IMG_format = Convert.ToString( dt.Rows[0]["IMG_format"].ToString());
        IMG_imageSize = Convert.ToDouble( dt.Rows[0]["IMG_imageSize"].ToString());
        IMG_imageSmallSize = Convert.ToDouble( dt.Rows[0]["IMG_imageSmallSize"].ToString());
        IMG_imageMediumSize = Convert.ToDouble( dt.Rows[0]["IMG_imageMediumSize"].ToString());
        IMG_imagelargeSize = Convert.ToDouble( dt.Rows[0]["IMG_imagelargeSize"].ToString());
        IMG_description = Convert.ToString( dt.Rows[0]["IMG_description"].ToString());
        IMG_isActive = (bool)dt.Rows[0]["IMG_isActive"];
        IMG_isDeleted = Convert.ToBoolean( dt.Rows[0]["IMG_isDeleted"].ToString());

        }

        }

        return ds;

        }
        
    }
}
