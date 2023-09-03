using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_132
    {
        public static int[] ShiftElement(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;

                    index++;
                }
            }
            return arr;

        }
    }
}
