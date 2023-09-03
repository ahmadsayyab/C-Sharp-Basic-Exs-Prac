using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_136
    {
        public static int CheckInputs(string[] arr , int len)
        {

            int ctr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == len) ctr++;
            }
            return ctr;

        }
    }
}
