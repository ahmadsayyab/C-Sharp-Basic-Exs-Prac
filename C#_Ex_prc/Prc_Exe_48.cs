using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_48
    {
        public static void CheckInputs()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = int.Parse(Console.ReadLine());



            

            bool result = (num1 < num2 && num2 < num3);


            Console.WriteLine(result);

        }
    }
}
