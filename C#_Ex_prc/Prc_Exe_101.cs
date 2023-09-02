using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_101
    {
        public static void ModifyArr(int[] arr)
        {
            if(arr.Length == 3)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 5 && arr[i + 1] == 7)
                    {
                        arr[i + 1] = 1;
                    }

                    Console.Write(arr[i] + " ");
                }

            }
            else
            {
                Console.WriteLine(arr);
            }
            Console.WriteLine("\n");
        }
    }
}
