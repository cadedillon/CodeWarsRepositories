using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringtoCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with '-' or '_' between each word and my function will return a camelCase string.");
            string userInput = Console.ReadLine();
            Console.WriteLine(ConvertStringToCamelCase.ToCamelCaseFx(userInput));
        }
    }

    public class ConvertStringToCamelCase
    {
        public static string ToCamelCaseFx(string str)
        {
            string result = "";
            //Here I split the string passed into the function into an array of strings with the string.Split() method.
            string[] split = str.Split(new Char[] { '-', '_' });
            //Save the index 0 string as a variable to preserve the lowercasing
            string first = split[0];
            
            //Upper case the first letter of the rest of the strings with ToUpper() and concatenate them with Substring()
            for (int i = 1; i < split.Length; i++)
            {

                string upper = split[i];
                if (upper.Length > 1)
                {
                    upper = char.ToUpper(upper[0]) + upper.Substring(1);
                }
                else
                {
                    upper = char.ToUpper(upper[0]).ToString();
                }

                result += upper;
            }
            //Return the lowercase string concatenated to the result string
            return first + result;
        }
    }
}
