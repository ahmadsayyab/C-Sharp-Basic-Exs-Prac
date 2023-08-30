using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_11
    {
        public void ExchangeStringChar()
        {
            string confirm;
            string newString;



            do
            {
                Console.WriteLine("Create a string ");
                string inputString = Console.ReadLine();



                if (string.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Input String can not be null or empty");
                }
                else if (inputString.Length > 2)
                {


                    newString = inputString.Substring(0, 3) + inputString + inputString.Substring(0, 3);
                    Console.WriteLine(newString);
                }
                else
                {

                    newString = inputString + inputString + inputString;
                    Console.WriteLine(newString);

                }
                



                    Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
