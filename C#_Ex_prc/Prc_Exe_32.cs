using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_32
    {
        bool result;
        public void FindValue(int[] arr1)
        {
            Console.WriteLine("Enter a number to search for in the array");
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            if(arr1.Contains(num))
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }


        }
    }
}
