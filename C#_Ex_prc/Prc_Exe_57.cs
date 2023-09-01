using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_57
    {
        public static int CheckInputs(int num1, int num2, int num3)
        {


            return Prc_Exe_57.fix_num(num1) + Prc_Exe_57.fix_num(num2) + Prc_Exe_57.fix_num(num3);
        }

            private static int fix_num(int n)
            {
                return (n > 9 && n < 13) || (n > 13 && n < 17) || (n > 17 && n < 21) ? 0 : n;
            }
        }
    }

