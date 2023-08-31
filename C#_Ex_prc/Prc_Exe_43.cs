using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_43
    {
        public static bool CheckInputs(int num)
        {

            //the ^ symbol is used as the XOR(exclusive OR) operator in this context.
            //It returns true if exactly one of the conditions is true(either n is divisible by 
            //3 or n is divisible by 7, but not both).If both conditions are true or both are false, it returns false.

            return (num % 3 == 0 ^ num % 7 == 0) ? true : false;

          



        }
    }
}
