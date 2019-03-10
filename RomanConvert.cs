using System;
using System.Linq;

namespace Count_characters_in_your_string
{
    public class RomanConvert
    {
        public static string Solution(int n)
        {
            string[] roman = { "I", "V", "X", "L", "C", "D", "M" };
            string result = "";
            while (n > 0)
            {
                if (n % 1000 == 0)
                {

                }
                else if (n % 500 == 0)
                {

                }
                else if (n % 100 == 0)
                {

                }
                else if (n % 50 == 0)
                {

                }
                else if (n % 10 == 0)
                {

                }
                else if (n % 5 == 0)
                {
                    int time = n % 5 == 0 ? 1 : n % 5;
                    result += result.PadLeft(time, 'V');
                    n -= 5;
                }
                else
                {
                    if (n - 5 < 5) {
                          result = "V";
                    }
                        result += result.PadLeft(n, 'I');
                    n = 0;
                }
            }
            return result;
        }
    }
}
