using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_82
    {
        public static string ModifyString(string str1, string str2)
        {

            if (str1.Length < str2.Length)
            {
                return str1 + str2.Substring(str2.Length - str1.Length);
            }
            else if (str1.Length > str2.Length)
            {
                return str1.Substring(str1.Length - str2.Length) + str2;
            }
            else
            {
                return str1 + str2;
            }

        }
    }
}
