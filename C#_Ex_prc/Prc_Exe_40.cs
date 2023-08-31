using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_40
    {
        public static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            if(sum >= 10 && sum <= 20)
            {
                return 30;
            }

            return sum;
        }
    }
}
