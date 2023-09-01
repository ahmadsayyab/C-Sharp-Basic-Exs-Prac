using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_80
    {
        public static string ModifyString(string str)
        {

            string emptyString = string.Empty;

            if (str.StartsWith("abc") )
            {
                return "abc";
            }
            else if (str.StartsWith("xyz"))
            {
                return "xyz";
            }
            return emptyString;

            
        }
    }
}
