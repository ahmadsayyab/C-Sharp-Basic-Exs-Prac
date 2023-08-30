using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_8
    {
        public void CopiesOfString()
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
                else if (inputString.Length >= 2)
                {


                    newString = inputString.Substring(0,2);

                    string result = newString +" " + newString + " " + newString + " " + newString;

                    Console.WriteLine(result);



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
