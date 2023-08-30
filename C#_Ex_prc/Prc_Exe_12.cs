using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_12
    {
        public void CheckInput()
        {
            string confirm;
            bool result;



            do
            {
                Console.WriteLine("Create a string ");
                string inputString = (Console.ReadLine());



                if (inputString.StartsWith("C#"))
                {
                    
                    result = true;
                    Console.WriteLine(result);
                }

                else
                {
                    result = false;
                    Console.WriteLine(result);
                }
                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
