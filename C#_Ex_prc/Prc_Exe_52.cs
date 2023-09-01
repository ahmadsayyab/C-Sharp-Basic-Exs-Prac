using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_52
    {
        public static int CheckInputs(int num1, int num2)
        {



            if (num1 == num2)
            {
                return 0;
            }
            else if (num1 % 7 == num2 % 7) 
            {
                int minValue = Math.Min(num1, num2);
                return minValue;
            }
           
            else
            {
                int maxValue = Math.Max(num1, num2);
                return maxValue;

            }
            


        }
    }
}
