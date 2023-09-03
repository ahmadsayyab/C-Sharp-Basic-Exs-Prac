using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_149
    {
        public static List<int> CreateNewList(List<int> newList)
        {



            return newList.Where(n => n < 4).ToList();


        }
    }
}
