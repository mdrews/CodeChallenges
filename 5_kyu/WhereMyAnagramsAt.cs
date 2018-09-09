using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> result = new List<string>();
            char[] wordArray = word.ToCharArray();
            Array.Sort(wordArray);
            for (int x = 0; x < words.Count; x++)
            {
                char[] wordsArray = words[x].ToCharArray();
                Array.Sort(wordsArray);
                if (wordArray.SequenceEqual(wordsArray))
                {
                    result.Add(words[x]);
                }
            }
            return result;
        }
    }
}
