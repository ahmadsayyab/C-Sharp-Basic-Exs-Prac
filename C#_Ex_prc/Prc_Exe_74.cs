using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_74
    {
        public static string ModifyString(string str, int num)
        {
            return num + 2 <= str.Length ? str.Substring(num, 2) : str.Substring(0, 2);
           




        }
    }
}
