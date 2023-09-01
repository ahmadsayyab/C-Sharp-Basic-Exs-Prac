using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_76
    {
        public static string ModifyString(string str)
        {


           // return (str.Length > 2) ? str.Substring(0,2) : str+ "#" ;

            if (str.Length >= 2)
            {
                str = str.Substring(0, 2);
            }
            else if (str.Length > 0)
            {
                str = str.Substring(0, 1) + "#";
            }
            else
            {
                str = "##";
            }

            return str;

        }
    }
}
