using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace GEN.GEN_GEN.GenericClasses.DataTables
{
      public class cls_NativDataSet
      {


            public static bool checkIsNullIsNoTableIsTableEmpty(DataSet ds, int pTableIndex)
            {



                  if (ds == null)
                  {

                        return true;
                  }
                  else
                  {

                        if (ds.Tables.Count <= 0)
                        {

                              return true;
                        }
                        else
                        {

                              if (ds.Tables[pTableIndex].Rows.Count <= 0)
                              {
                                    return true;
                              }
                              else
                              {

                                    return false;
                              }

                        }
                  }

                  return false;
            }
            public static bool checkIsNullTableEmpty(DataTable dt)
            {



                  if (dt == null)
                  {

                        return true;
                  }
                  else
                  {


                        if (dt.Rows.Count <= 0)
                        {
                              return true;
                        }
                        else
                        {

                              return false;
                        }


                  }

                  return false;
            }


            public static bool checkIsNullIsNoTable(DataSet ds)
            {

                  if (ds == null)
                  {

                        return true;
                  }
                  else
                  {

                        if (ds.Tables.Count <= 0)
                        {

                              return true;
                        }
                        else
                        {

                              return false;

                        }
                  }

                  return false;
            }

            public static bool addAllvalue(DataSet pDataSet, string pValueMember, string pDisplayMember)
            {

                  if(pDataSet.Tables.Count > 0)
                  {
                        var desRow = pDataSet.Tables[0].NewRow();
                        desRow[pValueMember] = -1;
                        desRow[pDisplayMember] = "All";

                        foreach (DataColumn tmpColumn in pDataSet.Tables[0].Columns)
                              if (tmpColumn.ColumnName != pValueMember && tmpColumn.ColumnName != pDisplayMember)
                              {

                                    if (tmpColumn.DataType == typeof(System.String))
                                    {
                                          desRow[tmpColumn.ColumnName] = "All";

                                    }

                              }


                        pDataSet.Tables[0].Rows.InsertAt(desRow, 0);
                  }


                  return true;
            }


            
      }
}
