using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata8_CountSum_ArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 5, 7, 6, 4, -3, -28, -84, 25, -43 };
            int[] result = Kata8.CountPositivesSumNegatives(testArray);
            foreach (int item in result)
            {
                Console.Write(item.ToString());
            }
        }
    }

    public class Kata8
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[0];

            }
            else
            {
                int positivecount = 0;
                int negativesum = 0;
                for (int index = 0; index < input.Length; index++)
                {
                    if (input[index] >= 1)
                    {
                        positivecount++;
                    }
                    else
                    {
                        negativesum += input[index];
                    }
                }
                return new int[] { positivecount, negativesum };

            }
        }
    }
}
