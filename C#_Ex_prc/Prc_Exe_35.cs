using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_35
    {
        //string str1 = "abcdefgh";
        //string str2 = "abijsklm";
        //string str1 = "abcde";
        //string str2 = "osuefrcd";
        string str1 = "pqrstuvwx";
        string str2 = "pqkdiewx";

        public int FindSameSbString()
        {
            
            var ctr = 0;
            for (var i = 0; i < str1.Length - 1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (var j = 0; j < str2.Length - 1; j++)
                {
                    var secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString))
                        ctr++;
                }
            }
            return ctr;

        }


    }
}
