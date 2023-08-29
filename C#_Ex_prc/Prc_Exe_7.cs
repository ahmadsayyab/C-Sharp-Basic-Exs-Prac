using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_7
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
                else if(inputString.Length >= 2)
                {
                    char firstChar = inputString[0];
                    char lastChar = inputString[inputString.Length - 1];

                    newString = lastChar + inputString.Substring(1,inputString.Length-2) + firstChar;


                    Console.WriteLine(newString);

                    



                }
                else
                {
                    Console.WriteLine(inputString);
                }











                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
