using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_kyu
{
    public class Moving_Zeroes_To_The_End
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int count = 0;
            int[] result = new int[arr.Length];
            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] != 0)
                {
                    result[count] = arr[x];
                    count++;
                }
            }
            return result;
        }
    }
}
