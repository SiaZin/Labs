using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    class Obj4_Test
    {
        [TestCase(new int[] { 1,3,6,2,2,0,4,5 }, 5)]
        [TestCase(new int[] { 1,2 }, 0)]

        public void Number_of_pairs_Test(int[] in_arr, int output, int target )
        {
            var result = Obj4.Number_of_pairs(in_arr, target);
            Assert.AreEqual(result, output);
        }

    }
}
