using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_79
    {
        public static string ModifyString(string str)
        {


            if (str.Length > 1)
            {
                return str.Substring(0, str.Length - 2) + str[str.Length - 1] + str[str.Length - 2];
            }
            else
            {
                return str;
            }
        }
    }
}
