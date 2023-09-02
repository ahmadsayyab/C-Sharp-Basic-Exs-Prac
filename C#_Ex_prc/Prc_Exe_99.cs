using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_99
    {
        public static void CreateNewArr(int[] arr)
        {

            int elements = arr.Length * 2;
            int[] doubleNums = new int[elements];

            doubleNums[0] = arr[0];
            foreach (int i in doubleNums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //for (int i = 1; i < arr.Length; i++)
            //{

            //    arr[i] = 0;
            //}

            //int[] combinedArray = arr.Concat(arr).ToArray();

            //foreach (var item in combinedArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");



        }
    }
}
