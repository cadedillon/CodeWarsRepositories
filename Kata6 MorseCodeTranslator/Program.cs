using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata6_MorseCodeTranslator
{
    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            string[] morseDictionary = {"/", "...---...", "-.-.--", ".-.-.-", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

            string[] alphabet = {" ", "SOS", "!", ".", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z" };

            string result = "";
            morseCode = morseCode.Replace("   ", " / ");
            string[] toDecode = morseCode.Split(' ');

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
