using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_characters_in_your_string
{
    public class CountString
    {
        public static Dictionary<char, int> Count(string str)
        {
            char[] list = str.ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < list.Length; i++)
            {
                int count = str.Count(f => f == list[i]);
                if (count > 1 && !dic.ContainsKey(list[i]))
                {
                    dic.Add(list[i], count);

                }
                else if (count == 1)
                {
                    dic.Add(list[i], count);
                }
            }
            return dic;
        }
    }
}
