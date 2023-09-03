using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_148
    {
        public static List<string> CreateNewList(List<string> newList)
        {
            char charToRemove = 'a';


            IEnumerable<string> doubled = newList.Select(x => x.Replace(charToRemove.ToString(), ""));
            return doubled.ToList<string>();


        }
    }
}
