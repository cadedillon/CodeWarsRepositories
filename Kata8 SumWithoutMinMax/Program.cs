using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8_SumWithoutMinMax
{
    public static class Kata8
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers != null && numbers.Length != 0 && numbers.Length != 1)
            {
                int sum = 0;
                for (int index = 0; index < numbers.Length; index++)
                {
                    sum += numbers[index];
                }
                int result = sum - numbers.Max() - numbers.Min();
                return result;
            }
            else if (numbers.Length == 1)
            {
                return 0;
            }
            else
            {
                return 0;
            }

        }
    }
}
