using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_67
    {
        public static string ModifyString(string str1, string str2)
        {
            
            if (str1.Length > 0 && str2.Length > 0)
            {
                return str1.Substring(1) + str2.Substring(1);

            }
            return "String length should be at least 2";
        }
    }
}
