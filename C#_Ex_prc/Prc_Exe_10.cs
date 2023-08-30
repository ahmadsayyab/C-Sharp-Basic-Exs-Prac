using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_10
    {
        public void CheckInt()
        {
            string confirm;
            int num;
            bool result;



            do
            {
                Console.WriteLine("Enter a number ");
                int inputInt = int.Parse(Console.ReadLine());



                if(inputInt < 0 || inputInt % 3 == 0 || inputInt % 7 == 0)
                {
                    num = Math.Abs(inputInt);
                    result = true;
                    Console.WriteLine(result);
                }
                
                else
                {
                    result = false;
                    Console.WriteLine(result);
                }
                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
