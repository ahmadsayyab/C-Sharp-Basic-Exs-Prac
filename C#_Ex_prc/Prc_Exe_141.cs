using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_141
    {
        public static List<int> CreateNewList(List<int> newList)
        {



            IEnumerable<int> doubled = newList.Select(x => x *= 3);
            return doubled.ToList<int>();
        }
    }
}
