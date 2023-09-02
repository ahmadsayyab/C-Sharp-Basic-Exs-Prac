using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_89
    {
        public static bool CheckInput(int[] arr)
        {

            return arr.Length > 0 && arr[0] == arr[arr.Length-1];
        }
    }
}
