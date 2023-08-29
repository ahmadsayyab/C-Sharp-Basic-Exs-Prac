using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Ex_prc_2
    {
        public void AbsoluteDiff()
        {
            string confirm;
            int result;
            int num = 51;
            do
            {
                Console.WriteLine("Enter a number ");
                int n = int.Parse(Console.ReadLine());
                


                if (n > num)
                {
                    result = (n - num) * 3;
                    Console.WriteLine($"As 'n' is broader than 51, so triple of their absolute diff is: {result}");
                }
                else
                {
                    result = num - n;
                    Console.WriteLine($"Absolute diff is: {result}");
                }

                Console.WriteLine("Do you want to do another operation? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }




    }
}

