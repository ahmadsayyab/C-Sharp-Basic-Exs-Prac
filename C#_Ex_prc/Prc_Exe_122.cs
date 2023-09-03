using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_122
    {
        public static bool CheckInput(int[] arr)
        {



            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 2 == 0 && arr[i + 1] % 2 == 0) || (arr[i] % 2 == 1 && arr[i + 1] % 2 == 1))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
