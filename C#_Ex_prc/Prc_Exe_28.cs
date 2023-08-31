using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_28
    {
        public bool CheckInput(string inputstring)
        {
           
           



            
                var count = 0;
                for (var i = 0; i < inputstring.Length - 1; i++)
                {
                    if (inputstring[i].Equals('a')) count++;

                    if (inputstring.Substring(i, 2).Equals("aa") && count < 2)

                        return true;
                }
                return false;







               




        }
    }
}
