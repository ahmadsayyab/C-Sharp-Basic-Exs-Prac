using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_90
    {
        public static bool CheckInput(int[] arr1, int[] arr2)
        {

            return arr1.Length > 0 && arr2.Length > 0 && arr1[0] == arr2[0] || arr1[arr1.Length-1] == arr2[arr1.Length-1];
        }
    }
}
