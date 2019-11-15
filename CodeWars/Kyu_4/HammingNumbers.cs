using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kyu_4
{
    public class HammingNumbers
    {
        public static long Hamming(int n)
        {
            long [] results = new long[n];
            results[0] = 1;
            long t2 = 2;
            long t3 = 3;
            long t5 = 5;
            int i = 0;
            int j = 0;
            int k = 0;

            for (int index = 1; index < n; index++)
            {
                results[index] = Math.Min(t2, (Math.Min(t3, t5)));
                if (results[index] == t2)
                {
                    t2 = 2 * results[++i];
                }
                if (results[index] == t3)
                {
                    t3 = 3 * results[++j];
                }
                if (results[index] == t5)
                {
                    t5 = 5 * results[++k];
                }
            }
            return results[n-1];
        }
    }
}
