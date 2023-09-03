using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_124
    {
        public static bool CheckInput(int[] arr)
        {
            int arr_len = arr.Length;
            bool flag = true;

            for (int i = 0; i < arr_len; i++)
            {
                if (arr[i] == 5)
                {
                    if ((i > 0 && arr[i - 1] == 5) || (i < arr_len - 1 && arr[i + 1] == 5)) flag = true;
                    else if (i == arr_len - 1) flag = false;
                    else return false;
                }
            }
            return flag;






            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 5 && arr[i+1] == 5)
            //    {
            //        for (int j = i+2; j < arr.Length-1; j++)
            //        {
            //            if (arr[j] == 5 && arr[j+1] == 5)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }


            //    } 

            //}
            //return false;

        }
    }
}
