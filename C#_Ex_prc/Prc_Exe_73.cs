using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_73
    {
        public static string ModifyString(string str, int num)
        {


            return str.Substring(0, num) + str.Substring(str.Length - num);




        }
    }
}
