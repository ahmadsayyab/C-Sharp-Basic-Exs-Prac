using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_127
    {
        public static int[] ShiftElement(int[] arr)
        {
            int size = arr.Length;
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < size; i++)
            {
                newArr[i] = arr[(i + 1) % size];
            }
            return newArr;


        }
    }
}
