using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_46
    {
        public static string ModifyString()
        {
            
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());


            if (inputstring.StartsWith("F") && inputstring.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (inputstring.StartsWith("F"))
            {
                return "Fizz";
            }
            else if (inputstring.EndsWith("B"))
            {
                return "Buzz";
            }
            else
            {
                return inputstring;
            }














        }
    }
}
