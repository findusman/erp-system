using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Configuration;
using System.ComponentModel;


namespace DAL
{
    public class DALCustome
    {


       public static bool IsWindowsAutheticate = false;

        public static string connectionstring = "";
    //    public static string SERVERNAME = ".";//@"AASHU-G\MSSQLSERVER12";
     //   public static string SERVERNAME2 = "WINDOWS-IKTTVMB";
        public static string DATABASE = "DM_6_Sep_2018";

        public static string USERID = "sa";

        public static string PASSWORD = "123";

     //   public static string SERVERNAME;
      public static string SERVERNAME2 = ".";
      //  public static string DATABASE;

        //public static string USERID;

        //public static string PASSWORD;

    

   //  public static string connectionstring = @"Server=" + SERVERNAME2 + "; Database=" + DATABASE +  ";" + "Integrated Security = True;";
          
        SqlConnection obj_con ;//= new SqlConnection();
        SqlTransaction obj_trn ;
       // SqlCommand obj_cmd;
        DataSet ds = null;


        public static object ToDBNull(object value)
        {
            if (null != value)
                return value;
            return DBNull.Value;
        }


        public void transaction()
        {
           // obj_trn = new SqlTransaction();

        }


        public void transactioRollBack()
        {
            obj_trn.Rollback();
        }

        public void transactioCommit()
        {
            obj_trn.Commit();
        }


        public string open_connection()
        {
            if (IsWindowsAutheticate)
            {
               connectionstring = @"Server=" + SERVERNAME2 + "; Database=" + DATABASE +  ";" + "Integrated Security = True;";
            }
            else
            {
                connectionstring = @"Data Source=" + SERVERNAME2 + "; Database=" + DATABASE + "; User Id=" + USERID + "; Password=" + PASSWORD + ";";

               // connectionstring = @"Data Source=" + SERVERNAME2 + ";  User Id=" + USERID + "; Password=" + PASSWORD + ";";


            }//  connectionstring = "Data Source=" + SERVERNAME + "; Database=" + DATABASE + "; User Id=" + USERID + "; Password=" + PASSWORD + ";";
     
             try
            {
               // obj_con = new SqlConnection();
                obj_con = new SqlConnection();
                obj_con.ConnectionString = connectionstring;
                obj_con.Open();
         
            }
            catch(Exception e)
            {
                obj_con.Close();
                return e.Message; 

            }

            try
            {

                obj_trn = obj_con.BeginTransaction();

            }
            catch (Exception ee)
            {

                obj_con.Close();
                return ee.Message; 

            
            }
            return "ok";
            
        }

        public string closeconnection()
        {

            try
            {

                obj_trn.Commit();
            }

            catch (Exception e)
            {
               
                return e.Message;
            
            }

            try
            {

                obj_con.Close();
                
            }

            catch (Exception e)
            {
               
                return e.Message;

            }

            return "ok";

        }

  

        public DataSet selection(string storeprocedure, SqlParameter[] sql_param, SqlCommand pobj_cmd, bool IsParent)
       {

           try
           {
               if (IsParent)
               pobj_cmd.Connection = obj_con;

           }
           catch (Exception e)
           {

              
               ds = null;
               return ds;
           }

           try
           {
               if (IsParent)
               pobj_cmd.Transaction = obj_trn;


           }
           catch (Exception ee)
           {
             
               ds = null;

               return ds;
                   
            }

       
            pobj_cmd.CommandTimeout = 0;
       
           pobj_cmd.CommandType = CommandType.StoredProcedure;
           pobj_cmd.CommandText = storeprocedure;
           pobj_cmd.Parameters.Clear();
           try
           {

               for (int x = 0; x < sql_param.Length; x++)
               {
                   sql_param[x].Value = ToDBNull(sql_param[x].Value);
                   pobj_cmd.Parameters.Add(sql_param[x]);

               }

           }
           catch (Exception eeee)
           {
              
             
               return ds;
           
           }
          

         
           try
           {

               SqlDataAdapter da = new SqlDataAdapter(pobj_cmd);
           
               ds = new DataSet();
               
               da.Fill(ds);
               pobj_cmd.Parameters.Clear();
           }
            
           catch (Exception eee)
            {

              
                ds = null;
                return ds;
            }

         
           
           return ds;
       
       }

        public DataSet selection(string query)
        {



            SqlCommand pobj_cmd = new SqlCommand();
            DataSet dataset = null;

            if (IsWindowsAutheticate)
            {
                connectionstring = @"Server=" + SERVERNAME2 + "; Database=" + DATABASE + ";" + "Integrated Security = True;";
            }
            else
            {
                connectionstring = @"Data Source=" + SERVERNAME2 + "; Database=" + DATABASE + "; User Id=" + USERID + "; Password=" + PASSWORD + ";";

      

            }
               // obj_con = new SqlConnection();
                obj_con = new SqlConnection();
                obj_con.ConnectionString = connectionstring;
                obj_con.Open();

                try
            {
                
                    pobj_cmd.Connection = obj_con;

            }
            catch (Exception e)
            {

                    obj_con.Close();
                    dataset = null;
                return dataset;
            }

            


            

            pobj_cmd.CommandType = CommandType.Text;
            pobj_cmd.CommandText = query;
            



            try
            {

                SqlDataAdapter da = new SqlDataAdapter(pobj_cmd);

                dataset = new DataSet();

                da.Fill(dataset);
                
            }

            catch (Exception eee)
            {

                    obj_con.Close();
                    dataset = null;
                return dataset;
            }


                obj_con.Close();
                return dataset;

        }


        public string ins_del_upd(string storeprocedure, SqlParameter[] sql_param, SqlCommand pobj_cmd , bool IsParent)
        {
            if (IsParent)
                pobj_cmd.Connection = obj_con;


            if (IsParent)
                pobj_cmd.Transaction = obj_trn;



            pobj_cmd.CommandType = CommandType.StoredProcedure;
            pobj_cmd.CommandText = storeprocedure;
            pobj_cmd.Parameters.Clear();




            for (int x = 0; x < sql_param.Length; x++)
            {
                sql_param[x].Value = ToDBNull(sql_param[x].Value);
                pobj_cmd.Parameters.Add(sql_param[x]);

            }



            try
            {

                pobj_cmd.ExecuteNonQuery();

            }
            catch (Exception eee)
            {
               
              //  obj_con.Close();
                return eee.Message;
            }



           
            return "ok";
        }


       public DataSet selection(string storeprocedure, SqlParameter[] sql_param)
       {

           SqlCommand obj_cmd = new SqlCommand();

           //obj_cmd.Connection = obj_con;
           //obj_cmd.CommandType = CommandType.StoredProcedure;
           //obj_cmd.CommandText = storeprocedure;


           //for (int x = 0; x < sql_param.Length; x++)
           //{

           //    obj_cmd.Parameters.Add(sql_param[x]);

           //}
           //open_connection();
           try
           {
               string state = open_connection();
           }
           catch (Exception eee)
           {
               obj_trn.Rollback();
               obj_con.Close();
               ds = null;
               return ds;
           }

           if (obj_con.State == ConnectionState.Closed || obj_con.State == ConnectionState.Broken)
           {
               ds = null;
               return ds;

           }


           try
           {

               obj_cmd.Connection = obj_con;

           }
           catch (Exception e)
           {


               obj_con.Close();
               ds = null;
               return ds;

           }

           try
           {

               obj_cmd.Transaction = obj_trn;


           }
           catch (Exception ee)
           {
               obj_trn.Rollback();
               ds = null;

               return ds;

           }

           obj_cmd.CommandType = CommandType.StoredProcedure;
           obj_cmd.CommandText = storeprocedure;
           obj_cmd.Parameters.Clear();
           try
           {

               for (int x = 0; x < sql_param.Length; x++)
               {
                   sql_param[x].Value = ToDBNull(sql_param[x].Value);
                   obj_cmd.Parameters.Add(sql_param[x]);

               }

           }
           catch (Exception eeee)
           {

               obj_con.Close();
               return ds;

           }



           try
           {

               SqlDataAdapter da = new SqlDataAdapter(obj_cmd);

               ds = new DataSet();

               da.Fill(ds);
           }

           catch (Exception eee)
           {

               obj_con.Close();
               ds = null;
               return ds;
           }

           try
           {
               closeconnection();
               obj_cmd.Parameters.Clear();
           }
           catch (Exception eeeee)
           {

               obj_con.Close();
               ds = null;
               return ds;
           }

           return ds;

       }

       public string ins_del_upd(string storeprocedure, SqlParameter[] sql_param)
       {
           SqlCommand obj_cmd = new SqlCommand();
           //obj_cmd.CommandType = CommandType.Text;
           //obj_cmd.CommandText = "insert into tabl values ( 'usman' , 'usman' , 'usman' )";
           //obj_cmd.ExecuteNonQuery();


           try
           {
               string state = open_connection();
           }
           catch (Exception eee)
           {
               obj_trn.Rollback();
               obj_con.Close();
               return eee.Message;
           }
           // transaction();
           if (obj_con.State == ConnectionState.Closed || obj_con.State == ConnectionState.Broken)
           {

               return "Error in connecting database.";

           }


           try
           {

               obj_cmd.Connection = obj_con;

           }
           catch (Exception e)
           {


               obj_con.Close();
               return e.Message;


           }

           try
           {

               obj_cmd.Transaction = obj_trn;


           }
           catch (Exception ee)
           {
               obj_trn.Rollback();
               return ee.Message;
           }



           obj_cmd.CommandType = CommandType.StoredProcedure;
           obj_cmd.CommandText = storeprocedure;
           obj_cmd.Parameters.Clear();




           for (int x = 0; x < sql_param.Length; x++)
           {
               sql_param[x].Value = ToDBNull(sql_param[x].Value);
               obj_cmd.Parameters.Add(sql_param[x]);

           }



           try
           {

               obj_cmd.ExecuteNonQuery();

           }
           catch (Exception eee)
           {
               obj_trn.Rollback();
               obj_con.Close();
               return eee.Message;
           }



           try
           {
               closeconnection();
               // obj_trn.Commit();

           }
           catch (Exception eee)
           {
               obj_trn.Rollback();
               obj_con.Close();
               return eee.Message;
           }
           return "ok";
       }
        public string ins_del_upd(string query)
        {
            SqlCommand obj_cmd = new SqlCommand();
            //obj_cmd.CommandType = CommandType.Text;
            //obj_cmd.CommandText = "insert into tabl values ( 'usman' , 'usman' , 'usman' )";
            //obj_cmd.ExecuteNonQuery();

            if (IsWindowsAutheticate)
            {
                connectionstring = @"Server=" + SERVERNAME2 + "; Database=" + DATABASE + ";" + "Integrated Security = True;";
            }
            else
            {
                connectionstring = @"Data Source=" + SERVERNAME2 + "; Database=" + DATABASE + "; User Id=" + USERID + "; Password=" + PASSWORD + ";";



            }
            // obj_con = new SqlConnection();
            obj_con = new SqlConnection();
            obj_con.ConnectionString = connectionstring;
            obj_con.Open();


           

        
            // transaction();

            if (obj_con.State == ConnectionState.Closed || obj_con.State == ConnectionState.Broken)
            {

                return "Error in connecting database.";

            }


            try
            {

                obj_cmd.Connection = obj_con;

            }
            catch (Exception e)
            {


                obj_con.Close();
                return e.Message;


            }

           


            obj_cmd.CommandType = CommandType.Text;
            obj_cmd.CommandText = query;
           



            try
            {

                obj_cmd.ExecuteNonQuery();

            }
            catch (Exception eee)
            {
              
                obj_con.Close();
                return eee.Message;
            }



            try
            {
                obj_con.Close();
                // obj_trn.Commit();

            }
            catch (Exception eee)
            {
               
                obj_con.Close();
                return eee.Message;
            }
            return "ok";
        }

    }

}
