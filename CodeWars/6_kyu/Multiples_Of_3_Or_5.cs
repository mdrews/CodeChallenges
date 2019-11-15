using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_kyu
{
    public class Multiples_Of_3_Or_5
    {
        public static int Solution(int value)
        {
            int result = 0;
            for (int x = 0; x < value; x++)
            {
                if (x % 3 == 0 || x % 5 == 0)
                {
                    result += x;
                }
            }
            return result;
        }
    }
}
