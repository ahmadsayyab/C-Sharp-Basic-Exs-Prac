using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prx_Exe_102
    {
        public static void FindLargestArr(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;
            foreach (int i in arr1)
            {
                sum1 += i;
            }
            foreach (int i in arr2)
            {
                sum2 += i;
            }

            Math.Max(sum1, sum2);
            if(sum1 > sum2)
            {
                foreach (int i in arr1)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                foreach (int i in arr2)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
