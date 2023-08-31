using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_15
    {
        public void CheckInput()
        {
            string confirm;
            bool result;



            do
            {
                Console.WriteLine("Enter number1 ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2 ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number3 ");
                int num3 = int.Parse(Console.ReadLine());


                result = ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50)) ? true : false;

                Console.WriteLine(result);

                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
