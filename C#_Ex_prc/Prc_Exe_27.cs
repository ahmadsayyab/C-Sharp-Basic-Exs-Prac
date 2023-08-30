using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_27
    {
        public void CountChar()
        {
            string confirm;




            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());



                int count = 0;
                for (int i = 0; i < inputstring.Length-1; i++)
                {
                    if(inputstring.Substring(i, 2) == "aa")
                    {
                        count++;
                    }
                    //if (inputstring[i] == 'a' && inputstring[i + 1] == 'a')
                    //{
                    //    count++;
                    //}
                    //else if (inputstring[i] == 'a' && inputstring[i + 1] == 'a' && inputstring[i + 2] == 'a')
                    //{
                    //    count += 1;
                    //}
                }
                Console.WriteLine(count);






                Console.WriteLine("\nDo you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
