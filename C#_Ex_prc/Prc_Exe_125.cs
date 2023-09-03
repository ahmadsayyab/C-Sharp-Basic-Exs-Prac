using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_125
    {
        public static bool CheckInput(int[] arr , int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (arr[i] != arr[arr.Length - num + i])
                {
                    return false;
                }
            }

            return true;


        }
    }
}
