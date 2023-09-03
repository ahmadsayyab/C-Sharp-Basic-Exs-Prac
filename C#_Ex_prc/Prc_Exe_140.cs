using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_140
    {
        public static int[] CreateNewArr(int[] arr, int len)
        {


            int[] odds = new int[len];
            int j = 0;
            for (int i = 0; j < len; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odds[j] = arr[i];
                    j++;
                }
            }
            return odds;

        }
    }
}
