using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba
{
    class Obj2_Test
    {

        [TestCase("sTreSS", 'T')]
        [TestCase("appeases", "0")]
        public void first_non_repeating_letter_Test(string in_str, char out_char)
        {
            var result = Obj2.first_non_repeating_letter(in_str);
            Assert.AreEqual(result, out_char);
        }
    }
}