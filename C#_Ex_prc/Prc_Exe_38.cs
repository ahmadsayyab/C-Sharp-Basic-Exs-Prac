using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_38
    {
        public static int CountNum(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == 5 && arr[i+1] == 5 || arr[i+1] == 6)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
