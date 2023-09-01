using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_66
    {
        public static string ModifyString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str1 + str2 + str1;
            }

            else
            {
                return str2 + str1 + str2;
            }
        }
    }
}
