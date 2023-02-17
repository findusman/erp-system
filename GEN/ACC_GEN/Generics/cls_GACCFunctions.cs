using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEN.ACC_GEN.Generics
{
   public class cls_GACCFunctions
    {

       public static bool isDateInFinancialyear(DateTime pFromDate, DateTime pToDate)
       {
           if (pFromDate >= GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_FinancialYearFromDate && pFromDate <= GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_FinancialYearToDate)
           {
               if (pToDate >= GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_FinancialYearFromDate && pToDate <= GEN.GEN_GEN.GenericClasses.cls_GENGlobalClass.GV_FinancialYearToDate)
                   return true;
               else
                   return false;

           }
           else
              return false;
           

       }

       public static bool isFixed(int pLevelIndex)
       {

           return Convert.ToBoolean(cls_ACCGlobalClass.GT_LevelInformation.Rows[pLevelIndex]["TBL_ACC_PLAN_DEF_isFixed"]); 
       }


      public static  string getCompleteCOAID(string pParentId, string pCurrentlevelId, int pLevelNo)
        {
            
            string[] Splited_formates = pParentId.Split(cls_ACCGlobalClass.GV_leveSeperator);

            string temp_code = string.Empty;

            for (int x = 0; x < pLevelNo; x++)
                temp_code = temp_code + Splited_formates[x] + cls_ACCGlobalClass.GV_leveSeperator;

            if (pLevelNo == (cls_ACCGlobalClass.GL_LevelFormat.Count - 1))
                temp_code = temp_code + pCurrentlevelId ;
            else
                temp_code = temp_code + pCurrentlevelId + cls_ACCGlobalClass.GV_leveSeperator;
        
            for (int x = (pLevelNo +1); x < cls_ACCGlobalClass.GL_LevelFormat.Count; x++)
            {
                if (x == (cls_ACCGlobalClass.GL_LevelFormat.Count -1))
                {

                    temp_code = temp_code + Splited_formates[x] ;
                
                }
                else
                {

                    temp_code = temp_code + Splited_formates[x] + cls_ACCGlobalClass.GV_leveSeperator;
             
                }
           }
                return temp_code;
        }


      public static string replace_Value(int pLevel_no, string pParent_Key, char pSeparator,string pValue_TOReplace )
      {
          string level_code = "";
          try
          {

              string[] Value = pParent_Key.Split(pSeparator);
             
              Value[pLevel_no - 1] = pValue_TOReplace.ToString().PadLeft(Value[pLevel_no - 1].ToString().Length, '0');


              for (int i = 0; i < Value.Length; i++)
              {
                  level_code += Value[i].ToString() + pSeparator;
              }
               
           
          }
          catch (Exception ex)
          {

          }
         

          return level_code = level_code.TrimEnd(pSeparator);
      
      }

      public static string getLevelCode(int pLevel_no, string pParent_Key, char pSeparator)
      {
          string level_code = "";
          try
          {

              string[] Value = pParent_Key.Split(pSeparator);

//              Value[pLevel_no - 1] = pValue_TOReplace.ToString().PadLeft(Value[pLevel_no - 1].ToString().Length, '0');

              level_code = Value[pLevel_no - 1].ToString();

              //for (int i = 0; i < Value.Length; i++)
              //{
              //    level_code += Value[i].ToString() + pSeparator;
              //}


          }
          catch (Exception ex)
          {

          }


          return level_code;//= level_code.TrimEnd(pSeparator);

      }

      public static string getCompleteVCHCodeWithoutPrefix( string pFormatedCodeWIthourPrefix)
      {

            if (pFormatedCodeWIthourPrefix.Length == 1)
            {

                  pFormatedCodeWIthourPrefix = "00000" + pFormatedCodeWIthourPrefix;
            }
            else if (pFormatedCodeWIthourPrefix.Length == 2)
            {

                  pFormatedCodeWIthourPrefix = "0000" + pFormatedCodeWIthourPrefix;
            }
            else if (pFormatedCodeWIthourPrefix.Length == 3)
            {

                  pFormatedCodeWIthourPrefix = "000" + pFormatedCodeWIthourPrefix;
            }
            else if (pFormatedCodeWIthourPrefix.Length == 4)
            {

                  pFormatedCodeWIthourPrefix = "00" + pFormatedCodeWIthourPrefix;
            }
            else if (pFormatedCodeWIthourPrefix.Length == 5)
            {

                  pFormatedCodeWIthourPrefix = "0" + pFormatedCodeWIthourPrefix;
            }
            return pFormatedCodeWIthourPrefix;

      }

      public static string getCompleteVCHCodeWithPrefix(string pFormatedCodeWIthourPrefix, string pPrefix)
      {

             return pPrefix + "-" + pFormatedCodeWIthourPrefix;

      }

     

      


    
    }
}
