using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_54
    {
        public static int CheckInputs(int num1, int num2)
        {

            int sum = num1 + num2;
            
            if (sum.ToString().Length == num1.ToString().Length)
            {
                return sum;
            }
            else 
            {
                return num1;
            }

        }
    }
}
