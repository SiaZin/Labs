using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laba
{
   
    class Obj1

    {
        static public List<object> GetIntegersFromList(List<object> _list)
        {
            foreach (object i in _list)
            {
                if (i.GetType() == typeof(int) || i.GetType() == typeof(string))
                {
                    Console.WriteLine("Error!");
                    Environment.Exit(0);
                }
            }

            return _list.Where(item => item.GetType().Equals(typeof(int))).ToList();
 
        }
    }
}
