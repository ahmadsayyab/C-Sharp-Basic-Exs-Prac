using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_137
    {
        public static string[] CreateNewArr(string[] arr, int len)
        {

            string[] newArr = new string[len];

            for (int i = 0; i < len; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;

        }
    }
}
