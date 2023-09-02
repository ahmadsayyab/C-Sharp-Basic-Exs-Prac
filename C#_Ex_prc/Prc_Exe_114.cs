using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_114
    {
        public static bool CheckInput(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 7)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
