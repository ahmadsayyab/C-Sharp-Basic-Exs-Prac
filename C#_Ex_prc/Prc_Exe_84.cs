using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_84
    {
        public static string ModifyString(string str)
        {

            string first2Char = str.Substring(0, 2);
            
            string last2Char = str.Substring(str.Length - 2);

            if(first2Char == last2Char)
            {
                
                return str.Substring(2);

            }
            else
            {
                return str;
            }

            

        }
    }
}
