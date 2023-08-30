using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_17
    {
        public void CheckInput()
        {
            string confirm;
            string result;



            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());


                string newString = inputstring.Substring(1,2);
                
                if (newString == "yt")
                {
                    result = inputstring.Remove(1,2);                   
                    Console.WriteLine(result);
                }

                else
                {
                    result = inputstring;
                    Console.WriteLine(result);
                }
                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
