using System;
using System.Collections.Generic;
using System.Linq;
namespace Count_characters_in_your_string
{
    public class DescOrdering
    {
        public static int DescendingOrder(int num)
        {
            // clever
            //  return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
            char[] a = num.ToString().ToArray();
            var index = a.OrderByDescending(x => x);
            string result = "";
            foreach (char ch in index)
            {
               result += ch;
            }
            return Int32.Parse(result);

        }
    }
}
