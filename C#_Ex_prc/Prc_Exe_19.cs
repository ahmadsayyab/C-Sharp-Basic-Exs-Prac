using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_19
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

                int newValue1 = Math.Abs(100 - num1);
                int newValue2 = Math.Abs(100 - num2);

                if(newValue1 > newValue2)
                {
                    Console.WriteLine(num2);
                }
                else if(num1 == num2)
                {
                    int vl = 0;
                    Console.WriteLine(vl);
                }
                else
                {
                    Console.WriteLine(num1);
                }





                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
