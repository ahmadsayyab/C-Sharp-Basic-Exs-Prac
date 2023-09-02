using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_97
    {
        public static bool FindElements(int[] arr)
        {
            return arr.Length == 2 && arr.Contains(15) || arr.Contains(20);
            
        }
    }
}
