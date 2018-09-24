using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata6.BreakCamelCase("camelCasing");
        }


        public class Kata6
        {
            public static string BreakCamelCase(string str)
            {
                char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] strArr = str.ToCharArray();
                string result = "";
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
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
