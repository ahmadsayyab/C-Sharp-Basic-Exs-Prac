using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_116
    {
        public static bool CheckInput(int[] arr)
        {
            int counterFor3 = 0;
            int counterFor5 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 3)
                {
                    counterFor3++;

                }
                else if (arr[i] == 5)
                {
                    counterFor5++;
                }

            }
            if(counterFor3 > counterFor5) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
