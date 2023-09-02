using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_96
    {
        public static void FirstANdLastElements(int[] arr)
        {
           
            int[] newArr = { arr[0] , arr[arr.Length-1] };
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
