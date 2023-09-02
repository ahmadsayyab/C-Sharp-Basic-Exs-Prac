using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_105
    {
        public static void SwapElements(int[] arr)
        {

            if(arr.Length > 0)
            {
                int index1 = arr[0];
                arr[0] = arr[arr.Length-1];

                arr[arr.Length-1] = index1;

                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }

               
            }
            Console.WriteLine("\n");
        }
    }
}
