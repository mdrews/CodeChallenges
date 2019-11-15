using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_kyu
{
    public class Find_The_Party_Outlier
    {
        public static int Find(int[] integers)
        {
            bool isEven = false;
            int evencheck = 0;
            //Find even/odd
            for (int x = 0; x < 2; x++)
            {
                if (integers[x] % 2 == 0)
                {
                    evencheck++;
                }
            }
            if (evencheck == 2)
            {
                isEven = true;
            }
            if (isEven == true)
            {
                foreach (var integer in integers)
                {
                    if (integer % 2 == 1)
                    {
                        return integer;
                    }
                }
            }
            foreach (var integer in integers)
                {
                    if (integer % 2 == 0)
                    {
                        return integer;
                    }
                }
            
            return 0;
        }
    }
}
