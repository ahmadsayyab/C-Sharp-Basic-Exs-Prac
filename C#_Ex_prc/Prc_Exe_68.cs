using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_68
    {
        public static string ModifyString(string str)
        {

          
           if(str.Length >= 2)
            {
                string firs2Char = str.Substring(0, 2);
                return str.Remove(0,2) + firs2Char;
            }
            return "String Length should at least 2";
        }
    }
}
