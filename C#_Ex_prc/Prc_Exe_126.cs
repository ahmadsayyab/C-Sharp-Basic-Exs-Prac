using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_126
    {
        public static bool CheckInput(int[] arr)
        {
            
            for (int i = 0; i < arr.Length-2; i++)
            {

                if (arr[i] == arr[i + 1] - 1
                    && arr[i] == arr[i + 2] - 2)
                {
                    return true;
                }
                //if (arr[i] < arr[i+1] && arr[i+1] < arr[i + 2]) 
                //{ 
                //    return true;
                //}
            }
            return false;


        }
    }
}
