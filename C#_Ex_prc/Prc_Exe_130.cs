using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_130
    {
        public static int[] ShiftElement(int[] arr)
        {
            int size = arr.Length;
            

            int pos = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = arr[pos];
                    arr[pos++] = 0;
                }
               
            }
            return arr;


        }
    }
}
