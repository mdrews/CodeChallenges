using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int x = 0; x < str.Length; x++)
            {
                if (!result.ContainsKey(str[x]))
                {
                    int count = str.Count(i => i == str[x]);
                    result.Add(str[x], count);
                }
            }
            return result;
        }
    }
}
