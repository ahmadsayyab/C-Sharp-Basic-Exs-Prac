using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_77
    {
        public static string ModifyString(string str1, string str2)
        {

            string lastChars = String.Empty;

            if (str1.Length > 0)
            {
                lastChars += str1.Substring(0, 1);
            }
            else
            {
                lastChars += "#";
            }

            if (str2.Length > 0)
            {
                lastChars += str2.Substring(str2.Length - 1);
            }
            else
            {
                lastChars += "#";
            }

            return lastChars;
            //if(str1.Length > 0 && str2.Length > 0)
            //{
            //   string newString = str1.Substring(0,1) + str2.Substring(str2.Length-1);
            //   return newString;
            //}
            //else if(str1.Length == 0)
            //{
            //    string newString = str1.Substring(0, 1) + "#";
            //    return newString;
            //}
            //else //if(str2.Length == 0)
            //{
            //    string newString =  "#" + str2.Substring(str2.Length - 1);
            //    return newString;
            //}



        }
    }
}
