using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_108
    {
        public static int[] CreatNewArr(int[] arr)
        {
            int firstElment = arr[0];
            int secondElement = arr[1];


            int[] newArr;
            if (arr.Length >= 2)
            {
                 newArr = new int[] {firstElment, secondElement};
                
            }

            else if(arr.Length > 0)
            {
                newArr = new int[]{ arr[0] };
               
            }
            else
            {
                newArr = new int[0];
            }


            return newArr;
            
           

        }
    }
}
