using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_33
    {
        
        public bool FindValue(int[] arr)
        {
            Console.WriteLine("Enter a number to search for in the array");
            int num = Math.Abs(int.Parse(Console.ReadLine()));



            
            return arr.Length < 4 ? arr.Contains(num) : arr.Take(4).Contains(num);

        }
    }
}
