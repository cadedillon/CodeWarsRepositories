using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer and my function will write it out in words.");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you entered was: {NumberTranslation.Number2Words(userInput)}");
            
        }
    }

    public class NumberTranslation
    {

        public static string Number2Words(int number)
        {

            string words = "";

            if (number == 0)
                return "zero";

            //In this series of If statements, we're checking to see what range of numbers the number falls into
            //Say we have 250 as a number, it would fall through the first 2 if statements
            if ((number / 1000000) > 0)
                words += Number2Words(number / 1000000) + " million ";
            number %= 1000000;

            if ((number / 1000) > 0)
                words += Number2Words(number / 1000) + " thousand ";
            number %= 1000;

            //And when it gets here, it is divided by a hundred, and the function is called recursively with the value of number / 100
            //The function will be called recursively until the number has been divided so many times it is less than 100
            if ((number / 100) > 0)
                words += Number2Words(number / 100) + " hundred ";
            number %= 100;

            //In this section of code, we determine which prefix or suffix to write, based on the value of the number
            //Each digit of the number will be processed here
            if (number > 0)
            {
                if (words != "")
                    words += " ";

                string[] prefix = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] suffix = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                    "seventeen", "eighteen", "nineteen", };

                if (number < 20)
                    words += suffix[number];

                else
                {
                    words += prefix[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + suffix[number % 10];
                }
            }

            string rWords = words.Replace("  ", " ");
            return rWords.Trim();
        }

    }
}
