using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_86
    {
        public static string ModifyString(string str)
        {

            string firstChar = str.Substring(0, 1);

            string lastChar = str.Substring(str.Length - 1);

            if(firstChar == "a" && lastChar == "a")
            {
                str = str.Substring(1, str.Length-2);
            }
            else if (firstChar == "a" )
            {
               str = str.Substring(1);
            }
            else if (lastChar == "a" )
            {
                str = str.Substring(0, str.Length-1);
            }
            return str;



        }
    }
}
