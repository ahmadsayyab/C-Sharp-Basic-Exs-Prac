using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_59
    {
        public static bool CheckInputs(int small, int medium, int large)
        {

            int value1 = small - medium;
            int value2 = medium - large;

            if(value1 == value2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}

