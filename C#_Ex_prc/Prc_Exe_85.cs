using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_85
    {
        public static string ModifyString(string str)
        {



            if (str.Length >= 2)
            {
                if (String.Compare(str.Substring(1, 1), "y") != 0)
                {
                    str = str.Remove(1, 1);
                }

                if (String.Compare(str.Substring(0, 1), "p") != 0)
                {
                    str = str.Remove(0, 1);
                }
            }
            else if (str.Length > 0 && String.Compare(str.Substring(0, 1), "p") != 0)
            {
                str = str.Remove(0, 1);
            }
           

            return str;
        }


    }
    }

