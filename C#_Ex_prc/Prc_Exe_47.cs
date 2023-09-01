using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_47
    {
        public static void CheckInputs()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = int.Parse(Console.ReadLine());

            

            bool result;

            result = (num1 == num2 + num3 || num2 == num1 + num3 || num3 == num1 + num2) ? true : false;


            Console.WriteLine(result);

        }
    }
}
