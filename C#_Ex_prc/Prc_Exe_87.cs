using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_87
    {
        public static string ModifyString(string str)
        {



            if (str.Length == 1 && str.Substring(0, 1) == "a")
            {
                str = str.Remove(0, 1);
            }

            if (str.Length > 1)
            {
                if (str.Substring(1, 1) == "a")
                {
                    str= str.Remove(1, 1);
                }

                if (str.Substring(0, 1) == "a")
                {
                    str= str.Remove(0, 1);
                }
            }

            return str;





        }
    }
}
