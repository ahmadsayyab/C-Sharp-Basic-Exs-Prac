using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_25
    {
        public void PrintStringCopies()
        {
            string confirm;
            



            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());
                Console.WriteLine("How many copies of your string do you want create?  ");
                int copies = Math.Abs(int.Parse(Console.ReadLine()));

                if(copies > 0)
                {
                    for (int i = 0; i < copies; i++)
                    {
                        Console.WriteLine(inputstring);
                    }
                }
                else
                {
                    Console.WriteLine(inputstring);
                }

                

                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
