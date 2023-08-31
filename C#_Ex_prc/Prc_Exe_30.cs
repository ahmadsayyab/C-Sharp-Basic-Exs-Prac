using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_30
    {
        public string ModifyInput(string inputstr)
        {


             var result = string.Empty;
            for (var i = 0; i < inputstr.Length; i++)
            {
                result += inputstr.Substring(0, i + 1);
            }
            return result;

   }
    }
}
