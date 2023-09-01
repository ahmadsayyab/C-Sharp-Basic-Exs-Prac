using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_53
    {
        public static bool CheckInputs(int num1, int num2)
        {



            return num1 / 10 == num2 / 10 || num1 / 10 == num2 % 10 || num1 % 10 == num2 / 10 || num1 % 10 == num2 % 10;


        }
    }
}
