using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_1
    {
        public void Sum()
        {
            string confirm;
            int result;
           
            do
            {
                Console.WriteLine("Enter 1st number ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number ");
                int num2 = int.Parse(Console.ReadLine());



                if (num1 == num2)
                {
                    result = (num1 + num2) * 3;
                    Console.WriteLine($"As your 2 numbers are same, so triple of their sum is: {result}");
                }
                else
                {
                    result = (num1 + num2);
                    Console.WriteLine($"Summation is equal to: {result}");
                }

                Console.WriteLine("Do you want to do another operation? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }




    }
}

