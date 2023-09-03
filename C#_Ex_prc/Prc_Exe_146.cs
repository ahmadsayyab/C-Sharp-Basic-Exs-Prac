using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_146
    {
        public static List<int> CreateNewList(List<int> newList)
        {



            List<int> modifiedList = new List<int>();

            for (int i = 0; i < newList.Count ; i++)
            {
                int element = newList[i] % 10;
                modifiedList.Add(element);

            }
            return modifiedList;


            //another way to do it easily
            //IEnumerable<int> digits = nums.Select(x => x % 10);
            //return digits.ToList();



        }
    }
}
