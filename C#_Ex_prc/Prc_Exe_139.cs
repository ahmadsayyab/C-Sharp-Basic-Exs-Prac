using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace C__Ex_prc
{
    internal class Prc_Exe_139
    {
        public static bool CheckInput(int len)
        {
            while (len > 0)
            {
                if (len % 10 == 2) return true;
                len /= 10;
            }
            return false;

            //string number = len.ToString();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] == '2')
            //    {
            //        return true;
            //    }
            //}
            //return false;

        }
    }
}
