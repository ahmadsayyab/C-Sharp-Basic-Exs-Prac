using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_121
    {
        public static bool CheckInput(int[] arr)
        {



            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == 3 && arr[i + 1] == 5)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
