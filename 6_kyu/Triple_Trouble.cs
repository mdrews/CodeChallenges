using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Kyu_6
{
    public class Triple_Trouble
    {
        public static int TripleDouble(long num1, long num2)
        {
            string strNum1 = num1.ToString();
            string strNum2 = num2.ToString();
            List<char> numbers = new List<char>();
            char current = ' ';
            int count = 0;
            for (int x = 0; x < strNum1.Length; x++)
            {
                if (x == 0)
                {
                    current = strNum1[0];
                    count++;
                }
                else
                {
                    if (strNum1[x] == current)
                    {
                        count++;
                        if (count == 3)
                        {
                            numbers.Add(current);
                        }
                    }
                    else
                    {
                        count = 1;
                        current = strNum1[x];
                    }
                }
            }
            count = 1;
            if (numbers.Count == 0)
            {
                return 0;
            }
            for (int y = 0; y < strNum2.Length; y++)
            {
                if (y == 0)
                {
                    current = strNum2[0];
                }
                else
                {
                    if (strNum2[y] == current && numbers.Contains(current))
                    {
                        count++;
                        if (count == 2)
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        count = 1;
                        current = strNum2[y];
                    }
                }
            }
            return 0;
        }
    }
}
