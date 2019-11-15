using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6_kyu
{
    public class The_Supermarket_Queue
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (customers.Length == 0)
            {
                return 0;
            }
            else if (customers.Length < n)
            {
                customers = customers.OrderByDescending(i => i).ToArray();
                return customers[0];
            }

            long[] queues = new long[n];
            for (int x = 0; x < customers.Length; x++)
            {
                queues[0] += customers[x];
                queues = queues.OrderBy(i => i).ToArray();
            }

            return queues[n-1];
        }
    }
}
