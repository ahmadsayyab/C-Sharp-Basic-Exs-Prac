using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_34
    {
        
        public bool FindSequence(int[] arr)
        {
            for (var i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 2 && arr[i + 2] == 3)
                    return true;
            }
            return false;
        }
    }
}
