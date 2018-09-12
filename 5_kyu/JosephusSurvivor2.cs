using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class JosephusSurvivor2
    {
        public static int JosSurvivor(int n, int k)
        {
            List<int> persons = new List<int>();
            for (int x = 1; x <= n; x++)
            {
                persons.Add(x);
            }
            while (persons.Count > 1)
            {
                for (int y = 0; y < k - 1; y++)
                {
                    persons.Add(persons[0]);
                    persons.RemoveAt(0);
                }
                persons.RemoveAt(0);
            }

            return persons[0];
        }
    }
}
