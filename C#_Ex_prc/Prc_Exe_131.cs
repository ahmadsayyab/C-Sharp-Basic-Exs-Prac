using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_131
    {
        public static int[] ShiftElement(int[] arr)
        {
            int size = arr.Length, index = 0;
            int[] newArr = new int[size];


            for (int i = 0; i < size; i++)
            {
                if (arr[i] != 5)
                {
                    newArr[index++] = arr[i];
                }
            }

            return newArr;

        }
    }
}

