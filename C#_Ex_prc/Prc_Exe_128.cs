using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_128
    {
        public static int[] CreateNewArr(int[] arr)
        {
            int size = 0;
            int[] pre_ele_5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    size = i;
                    break;
                }
            }
            pre_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                pre_ele_5[j] = arr[j];
            }
            return pre_ele_5;
            //int size = arr.Length;
            //int[] newArr = new int[arr.Length];

            //for (int i = 0; i < size; i++)
            //{
            //    if (arr[i] != 5)
            //    {
            //        newArr[i] = arr[i];
            //    }
            //    else if (arr[i] == 5)
            //    {
            //        break;
            //    }

            //}
            //return newArr;


        }
    }
}
