using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_78
    {
        public static string ModifyString(string str1 , string str2)
        {


            if (str1.Length < 1)
            {
                return str2;
            }

            if (str2.Length < 1)
            {
                return str1;
            }

            return !str1.EndsWith(str2.Substring(0, 1)) ? str1 + str2 : str1 + str2.Substring(1);

        }
    }
}
