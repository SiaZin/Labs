using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba
{
    class Obj3
    {
        static public int Digital_root(int n)
        {
            //int res = (int)input.ToString().ToList().ConvertAll(el => char.GetNumericValue(el)).Sum();
            //  return res.ToString().Length < 2 ? res : Task3.DigitalRoot(res);

            int A;
            A =(int)n.ToString().ToList().ConvertAll(item => char.GetNumericValue(item)).Sum();

            if (A.ToString().Length > 2)
                return Obj3.Digital_root(A);
            else
                return A;
        }
       
    }
}
