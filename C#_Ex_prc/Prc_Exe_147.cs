using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_147
    {
        public static List<string> CreateNewList(List<string> newList)
        {



            IEnumerable<string> doubled = newList.Select(x => x.ToUpper());
            return doubled.ToList<string>();


        }
    }
}
