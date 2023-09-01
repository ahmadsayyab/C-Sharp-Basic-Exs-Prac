using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_62
    {
        public static string ModifyString(string str)
        {
           
            string last2char = str.Substring(str.Length - 2);
            return last2char + last2char + last2char;
        }
    }
}
