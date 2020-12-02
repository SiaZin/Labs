using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba
{
    class Obj1_Test
    {
        [TestCase(new object[] { 1, 2, "a", "b" }, new object[] { 1, 2 })]
        [TestCase(new object[] { 1, 2, "a", "b", 0, 15 }, new object[] { 1, 2, 0, 15 })]
        [TestCase(new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 }, new object[] { 1, 2, 231 })]

        public void GetIntegersFromList_Test(object[] in_list, object[] out_list)
        {
            var result = Obj1.GetIntegersFromList(in_list.ToList());
            Assert.AreEqual(result, out_list.ToList());
        }
    }
}
