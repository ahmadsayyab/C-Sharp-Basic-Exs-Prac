using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_100
    {
        public static bool FindElements(int[] arr)
        {
            return arr.Length == 2
                && ((arr[0] == 10 && arr[1] == 10)
                     || (arr[0] == 20 && arr[1] == 20));

        }
    }
}
