using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_129
    {
        public static int[] CreateNewArr(int[] arr)
        {

            int len = arr.Length, size = 0, i = len - 1;

            int[] post_ele_5;

            while (i >= 0 && arr[i] != 5) i--;
            i++;

            size = len - i;
            post_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                post_ele_5[j] = arr[i + j];
            }

            return post_ele_5;
            //// int size = 0;
            // int[] newArr = new int[arr.Length];
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (arr[i] == 5)
            //     {

            //         for (int j = i+1; j < arr.Length; j++)
            //         {
            //             newArr[j] = arr[j];
            //         }
            //     }
            // }

            // return newArr;



        }
    }
}
