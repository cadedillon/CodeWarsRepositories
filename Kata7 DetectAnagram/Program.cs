using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata7_DetectAnagram
{
    public class Kata7
    {
        public static bool IsAnagram(string test, string original)
        {
            string aLower = original.ToLower();
            string bLower = test.ToLower();
            string a = String.Concat(aLower.OrderBy(c => c));
            string b = String.Concat(bLower.OrderBy(c => c));

            if (a == b)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
