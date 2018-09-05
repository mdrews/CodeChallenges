using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _6_kyu
{
    //https://www.codewars.com/kata/587731fda577b3d1b0001196/train/csharp
    public class CamelCase_Method
    {
        public static string CamelCase(string str)
        {
            string result = "";
            string[] words = str.Split(" ");
            foreach (string word in words)
            {
                if (word == "")
                {

                }
                else
                {
                    string newWord = "";
                    newWord = word.First().ToString().ToUpper() + word.Substring(1);
                    result += newWord;
                }
                
            }
            return result;
        }
    }
}
