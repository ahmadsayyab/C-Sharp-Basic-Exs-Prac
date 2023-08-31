using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_31
    {
        public void ModifyString()
        {
            string confirm;




            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());



               

                var last_two_char = inputstring.Substring(inputstring.Length - 2);
                var count = 0;

                for (var i = 0; i < inputstring.Length - 2; i++)
                {
                    if (inputstring.Substring(i, 2).Equals(last_two_char)) count++;
                }
                //return ctr;
                Console.WriteLine(count);

                Console.WriteLine("\nDo you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
