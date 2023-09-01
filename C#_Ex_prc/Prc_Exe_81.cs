using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_81
    {
        public static bool ModifyString(string str)
        {

            return str.Substring(0,2) == str.Substring(str.Length-2);


        }
    }
}
