using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of morse code and my function will decode it.");
            Console.WriteLine("Morse code letters have one space between them, and words have three spaces between them.");
            string userInput = Console.ReadLine();
            Console.WriteLine(MorseCodeDecoder.Decode(userInput));
        }
    }

    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            //In this function I chose to declare two concurrent arrays where the index of morseDictionary corresponds to the index of alphabet
            //This works fine, but I acknowledge it is not maintainable, nor is it extensible, nor is it readable!

            //If I were to do this again, I would declare a Dictionary data type, and store the morse code as keys whilst the alphabet letters would be 
            //the values
            string[] morseDictionary = {"/", "...---...", "-.-.--", ".-.-.-", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

            string[] alphabet = {" ", "SOS", "!", ".", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z" };

            string result = "";
            morseCode = morseCode.Replace("   ", " / ");
            string[] toDecode = morseCode.Split(' ');

            //Double nested loop to check the values of the morse code message against the morseDictionary
            //When located, concatenate the corresponding index from alphabet to a result string
            //Time complexity O(n^2), terrible.
            //The use of a Dictionary data structure would make this O(n), much better.
            for (int i = 0; i < toDecode.Length; i++)
            {
                for (int index = 0; index < morseDictionary.Length; index++)
                {
                    if (toDecode[i] == morseDictionary[index])
                    {
                        result += alphabet[index];
                    }
                }
            }
            return result.Trim();
        }
    }
}
