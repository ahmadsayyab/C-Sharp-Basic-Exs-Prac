using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_145
    {
        public static List<int> CreateNewList(List<int> newList)
        {



            IEnumerable<int> doubled = newList.Select(x => (x + 2)*5);
            return doubled.ToList<int>();


        }
    }
}
