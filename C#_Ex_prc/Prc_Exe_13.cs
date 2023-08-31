using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_13
    {
        public void CheckInput()
        {
            string confirm;
            bool result;



            do
            {
                Console.WriteLine("Enter Temperature value1 ");
                int tempValue1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Temperature value2 ");
                int tempValue2 = int.Parse(Console.ReadLine());


                result = ((tempValue1 < 0 || tempValue2 < 0) && (tempValue1 > 100 || tempValue2 > 100)) ? true : false;

                Console.WriteLine(result);
                
                Console.WriteLine("Do you want to contineue ? type yes or No");
                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");




        }
    }
}
