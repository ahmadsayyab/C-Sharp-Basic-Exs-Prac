using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_5
    {
        public void CreateString()
        {
            string confirm;
            string result;

            

            do
            {
                Console.WriteLine("Create a string ");
                string inputString = Console.ReadLine();


                result = inputString.StartsWith("if") ? inputString : "if" + " " + inputString;

                Console.WriteLine(result);







                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
