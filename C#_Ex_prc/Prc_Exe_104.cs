using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_104
    {
        public static void CreateNewArr(int[] arr1, int[] arr2)
        {

            int[] newArr = arr1.Concat(arr2).ToArray();
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
