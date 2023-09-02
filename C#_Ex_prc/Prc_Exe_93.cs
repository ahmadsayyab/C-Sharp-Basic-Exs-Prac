using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_93
    {
        public static void ReverseArrElements(int[] arr)
        {
            Console.Write("Original Array\n");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("\nReversed array is below");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                
                Console.Write(arr[i]+ " ");
                
            }
            Console.WriteLine("\n");


        }
    }
}
