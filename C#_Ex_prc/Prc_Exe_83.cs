using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_83
    {
        public static string ModifyString(string str)
        {

           if(str.Length > 2)
            {
                return str.Substring(0,2) + str.Substring(0, 2) + str.Substring(0, 2);
            }

            else
            {
                return str + str + str;
            }


        }
    }
}
