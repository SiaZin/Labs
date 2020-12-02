using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Laba
{
    class Obj2
    {
        static public char first_non_repeating_letter(string s)
        {
                char c = '0';

                for (int i = 0; i < s.Length; i++)
                {
                    bool isdistinct = true;
                for (int j = 0; j < s.Length; j++)
                {
                    char a = Char.ToLower(s[i]);
                    char b = Char.ToLower(s[j]);
                    if (a == b && i != j)
                        {
                            isdistinct = false;
                            break;
                        }
                    }
                    if (isdistinct)
                    {
                        c = s[i];
                        break;
                    }
                }
                return c;
            
        }
    }
}
