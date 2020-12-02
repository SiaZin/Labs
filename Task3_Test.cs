using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    class Obj3_Test
    {
        [TestCase(16, 7)]
        [TestCase(942, 6)]
        [TestCase(132189, 6)]
  
        public void Digital_root_Test(int input, int output)
        {
            var result = Obj3.Digital_root(input);
            Assert.AreEqual(result, output);
        }
    }
}
