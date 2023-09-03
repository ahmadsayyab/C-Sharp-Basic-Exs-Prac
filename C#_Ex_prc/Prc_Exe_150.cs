using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_150
    {
        public static List<int> CreateNewList(List<int> newList)
        {

            List<int> modifiedList = new List<int>();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] % 10 == 7)
                {
                    continue;
                }
                modifiedList.Add(newList[i]);

            }
            return modifiedList;

            //following is the second way to solve the above problem
            //return newList.Where(n => n % 10 < 7).ToList();


        }
    }
}
