using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_112
    {
        public static int AddElements(int[] arr)
        {
            int sum = 0;
            int inSection = 0;
            int flag = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                inSection = 0;
                if (arr[i] == 5)
                {
                    inSection = 0;
                    flag = 1;
                }
                if (inSection == 0 && arr[i] == 6)
                {
                    if (flag == 1)
                    {
                        sum = sum - 5;
                        inSection = 1;
                    }
                    flag = 0;
                }
                if (inSection == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 5 && arr[i+1] == 6)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sum += arr[i];
            //    }
            //}
            //return sum;
        }
    }
}
