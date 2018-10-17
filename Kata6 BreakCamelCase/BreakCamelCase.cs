using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a camelCase string and my function will return a string with spacing inserted.");
            string userInput = Console.ReadLine();
            Console.WriteLine(BreakCamelCase.BreakCamelFx(userInput));
        }

    }

    public class BreakCamelCase
    {
        public static string BreakCamelFx(string str)
        {
            //I chose to use an array to store the uppercase letters of the alphabet
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] strArr = str.ToCharArray();
            string result = "";
    
            //Here, I check each character of the string individually against each uppercase alphabet character. If there is a match,
            //I simply concatenate a space into the result string to break the camel casing. At the end of each internal loop I write 
            //the character to the result string.
            for (int i = 0; i < strArr.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (strArr[i] == alphabet[j])
                    {
                        result += " ";
                    }
                }
                result += strArr[i];
            }
    
            //I realize this is a very inefficient solution. The time complexity of this solution is about O(n^2).
            //If I were to optimize it retroactively, I would use the contains method instead of a nested for loop to 
            //check if the character is in the array, and that should bring the time complexity down to O(n), scaling
            //linearly with the number of string characters.
            
            return result;
        }
    }
    
}
