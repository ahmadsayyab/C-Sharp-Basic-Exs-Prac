using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_69
    {
        public static string ModifyString(string str)
        {

            

            if (str.Length >= 2)
            {
                return str.Substring(str.Length - 2) + str.Remove(str.Length - 2);
            }
            return "String Length should at least 2";
        }
    }
}
