using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_65
    {
        public static string ModifyString(string str)
        {


            //return str.Substring(0, str.Length / 2);

            if(str.Length > 2 ) 
            {
                return str.Substring(1, str.Length - 2);
            }
            return "String length should be at least 3";

        }
    }
}
