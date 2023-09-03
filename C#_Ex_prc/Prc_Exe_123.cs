using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ex_prc
{
    internal class Prc_Exe_123
    {
        public static bool CheckInput(int[] arr)
        {


            int counter = 0;
            

            for (int i = 0; i < arr.Length ; i++)
            {
               
                if (arr[i] == 5)
                {
                    counter++;
                   
                }
                for (int j = 0; j < 5; j++)
                {
                    int count = 0;
                    if (arr[j] == 5)
                    {
                        count++;

                        if (count >= 5)
                        {
                            return false;
                        }
                    }
                    

                }
            }
            return counter == 5;

        }
    }
}
