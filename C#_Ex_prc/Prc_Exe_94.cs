using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_94
    {
        public static void FindMaxNumInArrElements(int[] arr)
        {
            if(arr.Length == 4)
            {
               int maxVal = Math.Max(arr[1], arr[2]);

                int[] newArray = { maxVal , maxVal , maxVal , maxVal };

                foreach(int i in newArray)
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine("\n");


        }
    }
}
