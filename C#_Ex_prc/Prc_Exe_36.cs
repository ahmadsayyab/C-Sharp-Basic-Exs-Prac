using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_36
    {
        public string ModifyString()
        {
            
            //string str1 = "xxHxix";
            //string str1 = "abxdddca";
            string str1 = "xabjbhtrb";

            Console.WriteLine("Enter a Char which you want to remove from the give string");
            string inputChar = Console.ReadLine();

            for (int i = str1.Length - 2; i > 0; i--)
            {
                if (str1[i] == inputChar[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }

            return str1;
        }



    }
    }

