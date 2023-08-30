using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_24
    {
        public void CheckInput()
        {
            string confirm;
            string result;



            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());

                if(inputstring.Length > 3)
                {
                   string subString = inputstring.Substring(inputstring.Length - 3);
                   string newString = subString.ToUpper();
                   result = inputstring.Replace(subString, newString);
                    Console.WriteLine(result);
                }
                else
                {
                    result = inputstring.ToUpper();
                    Console.WriteLine(result);
                }

                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
