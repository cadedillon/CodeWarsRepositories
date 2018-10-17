using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOddInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Populate an array of 5 numbers, but only one integer can appear an odd number of times.");
            int[] userArray = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter an integer for position {i + 1}.");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The integer that appears an odd number of times is: {FindOddInteger.FindItFx(userArray)}");
        }
    }

    public class FindOddInteger
    {
        public static int FindItFx(int[] sequence)
        {
            //Iterate through the sequence of numbers, taking a count of how many times each number appears in the array
            for (int i = 0; i < sequence.Length; i++)
            {
                int count = 0;
                for (int index = 0; index < sequence.Length; index++)
                {

                    if (sequence[i] == sequence[index])
                        count++;
                }
                //Check if the count of the number is odd, if it is, return the number.
                if (count % 2 != 0)
                {
                    return sequence[i];
                }
            }

            return 0;
        }
    }
}
