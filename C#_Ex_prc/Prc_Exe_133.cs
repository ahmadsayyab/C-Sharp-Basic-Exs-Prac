using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_133
    {
        public static bool CheckInput(int[] arr)
        {
            
            for (int i = 0; i < arr.Length-1; i++)
            {

                if(arr[i+1] < arr[i])
                {
                    return false;
                    
                }
            }
            return true;
            

        }
    }
}
