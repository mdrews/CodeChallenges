using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class JosephusSurvivor
    {
        public static int JoeSurvivor(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int result = ((JoeSurvivor(n - 1, k) + k-1) % n+1);
                return result;
            }
        }
    }
}
