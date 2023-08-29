using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_exe_6
    {
        public void RemoveCharFromString()
        {
            string confirm;
            string result;



            do
            {
                Console.WriteLine("Create a string ");
                string inputString = Console.ReadLine();
                Console.WriteLine("Enter an index to remove character from:  ");
                int removeCharAt = int.Parse(Console.ReadLine());
                Console.WriteLine("How many characters do you want to remove?:  ");
                int numOfChar = int.Parse(Console.ReadLine());



                
                if (string.IsNullOrEmpty(inputString) || removeCharAt > inputString.Length)
                {
                    Console.WriteLine("String cannot be null or empty & index should also not exceed the length of the string");
                }
                else
                {
                    result = inputString.Remove(removeCharAt, numOfChar);
                    Console.WriteLine(result);

                }
               

               

                







                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
