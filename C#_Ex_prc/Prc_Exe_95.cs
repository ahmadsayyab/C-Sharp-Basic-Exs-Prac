using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_95
    {
        public static void FindMidArrElements(int[] arr1, int[] arr2)
        {
           
            if (arr1.Length == 5 && arr2.Length == 5)
            {
                int midElementArr1 = arr1.Length / 2;
                int midElementArr2 = arr2.Length / 2;

                Console.WriteLine(arr1[midElementArr1]);
                Console.WriteLine(arr2[midElementArr2]);
            }

        }
    }
}
