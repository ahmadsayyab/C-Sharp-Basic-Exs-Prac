using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_3
    {
        public void Check()
        {
            string confirm;
            //bool result;
            string result;

            do
            {
                Console.WriteLine("Enter 1st number ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number ");
                int num2 = int.Parse(Console.ReadLine());


            result = ((num1 == 30) || (num2 == 30) || (num1 + num2 == 30)) ? "true" : "false";


                Console.WriteLine(result);


                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Do you want to continue? type yes or No");
                confirm = Console.ReadLine().ToLower();




            } while (confirm == "yes");

            




        }
    }
}
