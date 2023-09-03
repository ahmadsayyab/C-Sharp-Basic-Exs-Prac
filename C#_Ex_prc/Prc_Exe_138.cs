using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_138
    {
        public static string[] CreateNewArr(string[] arr, int len)
        {

            string[] newArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == len)
                {
                    newArr[i] = arr[i];
                }
            }
            return newArr;

        }
    }
}
