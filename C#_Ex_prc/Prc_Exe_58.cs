using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_58
    {
        public static int CheckInputs(int num1, int num2)
        {


            int newValue1 = 13 - num1;
            int newValue2 = 13 - num2;

            if(num1 > 13 && num2 > 13)
            {
                return 0;
            }

            else if(newValue1 > newValue2)
            {
                return num2;
            }
            else
            {
                return num1;
            }

        }
    }
}
