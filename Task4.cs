using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba
{
    class Obj4
    {
        static public int Number_of_pairs(int[] in_arr, int target)
        {
            int sum = 0;
            int number = 0;
            for(int i=0; i < in_arr.Length; i++)
            {
                for(int j=i+1; j < in_arr.Length; j++)
                {
                    sum = in_arr[i] + in_arr[j];
                    if (target == sum)
                        number++;
                    sum = 0;
                }
            }
            return number;
        }
       
    }
}
