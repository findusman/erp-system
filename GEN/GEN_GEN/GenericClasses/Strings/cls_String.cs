using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEN.GEN_GEN.GenericClasses.Strings
{
   public  class cls_String
    {

       public static string getProperCodeFormat(string pFormat, int pCode)
       {


           int format_length = pFormat.Length;
           int code_length = pCode.ToString().Length;
           int format_limit = Convert.ToInt32(pFormat.Replace('0', '9'));

           if ((format_limit + 1) > pCode)
               return pFormat.Substring(0, format_length - code_length) + pCode;
           else
               return "N";

       }

    }
}
