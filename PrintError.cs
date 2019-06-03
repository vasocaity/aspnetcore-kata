using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_characters_in_your_string
{
    public class PrintError
    {
        public static string PrinterError(string s)
        {
            char[] cha = s.ToCharArray();
            string color = "abcdefghijklm";
            int countColor = 0;
            var output = cha.GroupBy(word => word).Select(group => group.Key).ToList();
           
            foreach (char ch in output)
            {
                if (!color.Contains(ch))
                {
                    //  Console.WriteLine("ch = "+ ch);
                    int count = s.Where(w => w.Equals(ch)).Count();
                    // Console.WriteLine("count = "+ count);
                    countColor += count;
                }
            }
            return countColor + "/" + s.Length;
        }
    }
}
