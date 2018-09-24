using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata6_ConvertStringtoCamelCase
{
    public class Kata6
    {
        public static string ToCamelCase(string str)
        {
            string result = "";
            string[] split = str.Split(new Char[] { '-', '_' });
            string first = split[0];
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
            return first + result;
        }
    }
}
