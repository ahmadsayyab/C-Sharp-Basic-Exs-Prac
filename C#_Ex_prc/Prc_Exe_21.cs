using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_21
    {
        public void CheckInput()
        {
            string confirm;
            int result;




            do
            {
                Console.WriteLine("Enter number1 ");
                int num1 = Math.Abs(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter number2 ");
                int num2 = Math.Abs(int.Parse(Console.ReadLine()));


                
                if((num1 >= 20 && num1 <= 30) && (num2 >= 20 && num2 <= 30))
                {
                    result = (Math.Max(num1, num2));
                    Console.WriteLine(result);
                }
                else
                {
                    int vl = 0;
                    Console.WriteLine(vl);
                }
                

                





                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
