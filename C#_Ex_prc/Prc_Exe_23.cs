using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_23
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

                int lastdigitNum1 = num1 % 10;
                int lastdigitNum2 = num2 % 10;

                result = (lastdigitNum1 == lastdigitNum2) ? "true" : "false";
                Console.WriteLine(result);


                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
