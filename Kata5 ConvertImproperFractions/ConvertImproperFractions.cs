using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertImproperFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive improper fraction in the format of '42/9' and the function will return a mixed number.");
            string userInput = Console.ReadLine();
            Console.WriteLine($"The mixed number is: {ConvertImproperFractions.MixedNumberFx(userInput)}");
        }
    }

    public class ConvertImproperFractions
    {
        public static string MixedNumberFx(string s)
        {
            //I used a try block so that I could implement exception handling for Divide by Zero, which might accidently occur as a result of user input
            try
            {
                string result = "";
                //Split the input string into a numerator and a denominator using the '/' character 
                string[] splitNumber = s.Split('/');
                int numerator = Int32.Parse(splitNumber[0]);
                int denominator = Int32.Parse(splitNumber[1]);
                //If the numerator and denominator are the same number, return 1. Easy!
                if (numerator == denominator)
                {
                    result += 1;
                    return result;
                }

                //Here we calculate the Whole number portion of the mixed number by dividing the numerator by the denominator
                //Then we set the numerator to the remainder
                int wholeNum = numerator / denominator;
                numerator = numerator % denominator;

                //We calculate the greatest common divisor (GCD) with a method call that takes the numerator and denominator as parameters
                int divisor = GreatestCommonDivisor(numerator, denominator);
                numerator /= divisor;
                denominator /= divisor;

                //Here we take the results of the above division operations and concatenate them to the results string
                //There are three different methods of concatenation depending on the context of the numbers we've been working with
                if (denominator == 1)
                {
                    result += wholeNum;
                    return result;
                }
                else if (wholeNum != 0)
                {
                    result = wholeNum + " " + numerator + "/" + denominator;
                    return result;
                }
                else
                {
                    result = numerator + "/" + denominator;
                    return result;
                }
            }

            //Always use protection
            catch (DivideByZeroException)
            {
                string result = "Attempted to divide by zero.";
                return result;
            }
        }

        //This method is a simple function that finds the GCD of two numbers by continuously dividing and taking the remainder
        //Until one of the numbers is equal to 0.
        public static int GreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }

            }
            return a == 0 ? b : a;
        }
    }
}