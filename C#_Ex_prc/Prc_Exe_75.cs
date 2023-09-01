using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_75
    {
        public static string ModifyString(string str)
        {

           
            return str.Substring((str.Length - 1) / 2 - 1, 3);

        }
    }
}
