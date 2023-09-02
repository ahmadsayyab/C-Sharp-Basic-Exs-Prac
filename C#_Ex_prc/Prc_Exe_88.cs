using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_88
    {
        public static bool CheckInput(int[] arr)
        {
            
                if (arr[0] == 10)
                {
                    return true;

                }
                else if (arr[arr.Length-1] == 10)
                {
                    return true;
                }
            
            return false;
        }
    }
}
