using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_106
    {
        public static void CreateNewArr(int[] arr)
        {

            if (arr.Length >= 3)
            {
                int midElementArr1 = arr.Length / 2 - 1;


                Console.Write(arr[midElementArr1] + " ");
                Console.Write(arr[midElementArr1 + 1] + " ");
                Console.Write(arr[midElementArr1 + 2] + " ");

            }

            Console.WriteLine("\n");
        }
    }
}
