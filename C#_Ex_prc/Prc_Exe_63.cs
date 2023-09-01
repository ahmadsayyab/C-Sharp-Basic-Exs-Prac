using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_63
    {
        public static string ModifyString(string str)
        {
            
            
            return (str.Length < 2) ? str : str.Substring(0, 2);

        }
    }
}
