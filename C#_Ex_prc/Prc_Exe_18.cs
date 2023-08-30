using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_18
    {
        public void CheckInput()
        {
            string confirm;
            



            do
            {
                Console.WriteLine("Enter number1 ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2 ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number3 ");
                int num3 = int.Parse(Console.ReadLine());

                //if(num1 > num2 && num1 > num3 )
                //{
                //    Console.WriteLine(num1);
                //}

                //else if(num2 > num1 && num2 > num3 )
                //{
                //    Console.WriteLine(num2);
                //}

                // else if(num3 > num1 && num3 > num2 )
                //{
                //    Console.WriteLine(num3);
                //}
                //else 
                //{
                //    Console.WriteLine("Something went wrong");
                //}

                int result = (Math.Max(num1, Math.Max(num2, num3)));
                Console.WriteLine(result);





                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
