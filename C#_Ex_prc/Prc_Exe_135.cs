using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_135
    {
        public static int ReturnMaxVal(int[] arr)
        {

            var firstHalf = Average(arr, 0, arr.Length / 2);
            
            var secondHalf = Average(arr, arr.Length / 2, arr.Length);
           
            return firstHalf > secondHalf ? firstHalf : secondHalf;

        }

        private static int Average(int[] num, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
                sum += num[i];
            return sum / (num.Length / 2);
        }
    }
}
