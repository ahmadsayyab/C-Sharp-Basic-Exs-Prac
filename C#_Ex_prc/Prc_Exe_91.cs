using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_91
    {
        public static int SumArrElements(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
