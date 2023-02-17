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
    public class DAL
    {

      public static string SERVERNAME;

      public static string DATABASE = "";

      public static string USERID;

      public static string PASSWORD;


      public static string connectionstring = @"Data Source=.; Database=master; User Id=sa; Password=123;";
     
          
        SqlConnection obj_con ;//= new SqlConnection();

        SqlCommand obj_cmd;
        DataSet ds = null;


        public string ins_del_upd(string query)
        {
              obj_cmd = new SqlCommand();
              //obj_cmd.CommandType = CommandType.Text;
              //obj_cmd.CommandText = "insert into tabl values ( 'usman' , 'usman' , 'usman' )";
              //obj_cmd.ExecuteNonQuery();


              try
              {
                    string state = open_connection();
              }
              catch (Exception eee)
              {

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





              obj_cmd.CommandType = CommandType.Text;
              obj_cmd.CommandText = query;
              //  obj_cmd.Parameters.Clear();




              //for (int x = 0; x < sql_param.Length; x++)
              //{

              //    obj_cmd.Parameters.Add(sql_param[x]);

              //}



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
                    closeconnection();
                    // obj_trn.Commit();

              }
              catch (Exception eee)
              {

                    obj_con.Close();
                    return eee.Message;
              }
              return "ok";
        }
    
     

        public string open_connection()
        {
             //connectionstring = "Data Source=" + SERVERNAME + "; Database=" + DATABASE + "; User Id=" + USERID + "; Password=" + PASSWORD + ";";
           //  connectionstring = "Data Source=" + SERVERNAME + "; Database = master; User Id=" + USERID + "; Password=" + PASSWORD + ";";
     
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
                obj_con.Dispose();
                return e.Message; 

            }

           
            return "ok";
            
        }
     
        public string closeconnection()
        {

            try
            {

                obj_con.Close();
            }

            catch (Exception e)
            {
               // obj_trn.Rollback();
                return e.Message;
            
            }

            try
            {

                obj_con.Close();
                obj_con.Dispose();
                
            }

            catch (Exception e)
            {
               
                return e.Message;

            }

            return "ok";

        }




     
     
          public DataSet selectionWithExecuteTextType(string pQuery )
       {

           SqlCommand obj_cmd = new SqlCommand();
       
        
           try
           {
               string state = open_connection();
           }
           catch (Exception eee)
           {
             
               obj_con.Close();
               obj_con.Dispose();
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

          
           obj_cmd.CommandType = CommandType.Text;
           obj_cmd.CommandText = pQuery;
          
         
           try
           {
           
               SqlDataAdapter da = new SqlDataAdapter(obj_cmd);
           
               ds = new DataSet();
               
               da.Fill(ds);

               da.Dispose();
               obj_con.Close();
               obj_con.Dispose();
           }
            
           catch (Exception eee)
            {

                obj_con.Close();
                obj_con.Dispose();
               
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
               ds = null ;
               return ds;
           }
           
           return ds;
       
       }

          public DataSet selectionWithExecuteProcedureType(string pProcedureName , SqlParameter[] pSQLParam )
          {
              
              SqlCommand obj_cmd = new SqlCommand();


              try
              {
                  string state = open_connection();
              }
              catch (Exception eee)
              {

                  obj_con.Close();
                  obj_con.Dispose();
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


              obj_cmd.CommandType = CommandType.StoredProcedure;
              obj_cmd.CommandText = pProcedureName;
              obj_cmd.Parameters.Clear();
              try
              {

                  for (int x = 0; x < pSQLParam.Length; x++)
                  {

                      obj_cmd.Parameters.Add(pSQLParam[x]);

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

                  da.Dispose();
                  obj_con.Close();
                  obj_con.Dispose();
              }

              catch (Exception eee)
              {

                  obj_con.Close();
                  obj_con.Dispose();

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
          public DataSet selectionWithExecuteProcedureTypeWithEmptySQLParameter(string pProcedureName)
          {

              SqlCommand obj_cmd = new SqlCommand();


              try
              {
                  string state = open_connection();
              }
              catch (Exception eee)
              {

                  obj_con.Close();
                  obj_con.Dispose();
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


              obj_cmd.CommandType = CommandType.StoredProcedure;
              obj_cmd.CommandText = pProcedureName;
           


              try
              {

                  SqlDataAdapter da = new SqlDataAdapter(obj_cmd);

                  ds = new DataSet();

                  da.Fill(ds);

                  da.Dispose();
                  obj_con.Close();
                  obj_con.Dispose();
              }

              catch (Exception eee)
              {

                  obj_con.Close();
                  obj_con.Dispose();

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

    }



}
