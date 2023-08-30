using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_22
    {
        public void CheckInput()
        {
            string confirm;
            string result;



            do
            {
                Console.WriteLine("Create a string ");
                string inputstring = (Console.ReadLine());


                int count = 0;
                for (int i = 0; i < inputstring.Length; i++)
                {
                    if (inputstring[i] == 'z')
                    {
                        count++;
                    }
                }

                result = (count > 1 && count <= 4) ? "true" : "false";

                Console.WriteLine(result);


                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
