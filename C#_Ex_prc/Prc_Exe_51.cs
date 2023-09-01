using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_51
    {
        public static bool CheckInputs(int num1, int num2, int num3)
        {


            return Math.Abs(num1 - num2) >= 20 || Math.Abs(num1 - num3) >= 20 ||
                    Math.Abs(num2 - num3) >= 20;


        }
    }
}
