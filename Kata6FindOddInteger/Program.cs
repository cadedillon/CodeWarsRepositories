using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata6FindOddInteger
{
    class Kata6
    {
        public static int find_it(int[] seq)
        {
            for (int i = 0; i < seq.Length; i++)
            {
                int count = 0;
                for (int index = 0; index < seq.Length; index++)
                {

                    if (seq[i] == seq[index])
                        count++;
                }
                if (count % 2 != 0)
                {
                    return seq[i];
                }
            }

            return 0;
        }
    }
}
