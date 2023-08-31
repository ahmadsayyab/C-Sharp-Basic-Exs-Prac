using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_29
    {
        public void ModifyString()
        {
            string confirm;




            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());



                char firstChar = inputstring[0];

                for (var i = 0; i <= inputstring.Length-1; i++)
                {
                    if(i % 2 != 0)
                    {

                        continue;
                    }
                    else
                    {
                        Console.Write(inputstring[i]);
                    }

                     
                    


                }






                Console.WriteLine("\nDo you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
