using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_14
    {
        public void CheckInput()
        {
            string confirm;
            string result;



            do
            {
                Console.WriteLine("Enter number1 ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2 ");
                int num2 = int.Parse(Console.ReadLine());


                result = ((num1 < 100 || num1 > 200) || (num2 < 100 || num2 > 200)) ? "false" : "true";

                Console.WriteLine(result);

                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
