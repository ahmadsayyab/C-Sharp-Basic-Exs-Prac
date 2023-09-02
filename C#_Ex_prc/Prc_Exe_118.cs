using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_118
    {
        public static bool CheckInput(int[] arr)
        {

            var three = false;
            var five = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 3) { three = true; }
                if (arr[i] == 5) { five = true; }
                if (three && five) return false;
            }
            return true;

        }
    }
}
