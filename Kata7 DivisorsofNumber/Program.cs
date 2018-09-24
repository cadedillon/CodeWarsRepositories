using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata7_DivisorsofNumber
{
    public class Kata7
    {
        public static int Divisors(int n)
        {
            int divisor = 1;
            int match = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n % divisor == 0)
                {
                    match++;
                }
                divisor++;
            }
            return match;
        }
    }
}
