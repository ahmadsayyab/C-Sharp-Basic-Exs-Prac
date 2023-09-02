using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_107
    {
        public static void FindLargestElement(int[] arr)
        {

            if (arr.Length % 2 ==  1)
            {
                int firstElment = arr[0];
                int midElementArr1 = arr.Length / 2;
                
                int lastElement = arr[arr.Length -1];


                if (firstElment > arr[midElementArr1] && firstElment > lastElement)
                {
                    Console.WriteLine(firstElment);

                }
                else if (arr[midElementArr1] > firstElment && arr[midElementArr1] > lastElement)
                {
                    Console.WriteLine(arr[midElementArr1]);
                }
                else
                {
                    Console.WriteLine(lastElement);
                }

            }

        }
    }
}
