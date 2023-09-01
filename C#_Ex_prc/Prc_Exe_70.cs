using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_70
    {
        public static string ModifyString(string str)
        {
            return str.Length < 2 ? String.Empty : str.Substring(1, str.Length - 2);
        }
    }
}
