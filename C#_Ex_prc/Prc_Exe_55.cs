using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_55
    {
        public static int CheckInputs(int num1, int num2, int num3)
        {


            //int sum = num1 + num2 + num3;

            //return (num1 == num2) ? num3 : sum;

            if (num1 == num2 && num2 == num3) return 0;

            if (num1 == num2) return num3;

            if (num1 == num3) return num2;
            if (num2 == num3) return num1;
            return num1 + num2 + num3;


        }
    }
}
