using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_61
    {
        public static string ModifyString(string str1, string str2)
        {
            if(str1.Length == 4)
            {
                
                return str1.Insert(2, str2);
            }

            else
            {
                return "String1 length should be four";
            }
        }
    }
}
