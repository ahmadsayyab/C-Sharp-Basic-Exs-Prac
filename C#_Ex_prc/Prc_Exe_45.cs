using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_45
    {
        public static int CheckInputs(int a, int b)
        {

            return (a >= 10 && a <= 20 || b >= 10 && b <= 20) ? 18 : a + b;

           
        }
    }
}
