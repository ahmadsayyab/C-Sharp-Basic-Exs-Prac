using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_26
    {
        public void PrintCharCopies()
        {
            string confirm;




            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());
                Console.WriteLine("How many copies do you want create?  ");
                int copies = Math.Abs(int.Parse(Console.ReadLine()));

                
                
                    if(inputstring.Length >= 3)
                    {
                        string subString = inputstring.Substring(0, 3);
                        for (int i = 0; i < copies; i++)
                        {
                            Console.Write(subString);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < copies; i++)
                        {
                            Console.Write(inputstring);
                        }
                    }
                    
                



                Console.WriteLine("\nDo you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
