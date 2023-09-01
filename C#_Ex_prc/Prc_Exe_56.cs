using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_56
    {
        public static int CheckInputs(int num1, int num2, int num3)
        {


            int sum = num1 + num2 + num3;

            if(num1 == 13)
            {
                return 0;
            }

            else if(num2 == 13)
            {
                return num1;
            }

            else if (num3 == 13)
            {
                return num1 + num2;
            }
            else
            {
                return sum;
            }

        }
    }
}
