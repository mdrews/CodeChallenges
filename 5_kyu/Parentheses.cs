using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int count = 0;
            for (int x = 0; x < input.Length; x++)
            {
                if (input[x] == '(')
                {
                    count++;
                }
                else if (input[x] == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    return false;
                }
            }
            if (count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
