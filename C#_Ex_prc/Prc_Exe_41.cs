using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_41
    {
        public static bool CheckInputs(int a, int b)
        {
            if(a == 5 || b == 5)
            {
                return true;
            }
            else if(a+b == 5 || Math.Abs(a-b)==5)
            {
                return true;
            }
           
            return false;
        }
    }
}
