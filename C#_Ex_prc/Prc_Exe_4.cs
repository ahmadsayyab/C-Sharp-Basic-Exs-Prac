using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_4
    {
        public void CheckForValue()
        {
            string confirm;
            string result;

            int num1 = 100;
            int num2 = 200;
            
            do
            {
                Console.WriteLine("Enter a number ");
                int n = int.Parse(Console.ReadLine());

                result = (Math.Abs(n - num1) <= 10 || Math.Abs(n - num2) <= 10) ? "true" : "false";
                Console.WriteLine(result);





                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
