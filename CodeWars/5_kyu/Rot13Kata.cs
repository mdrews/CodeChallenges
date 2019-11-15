using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_kyu
{
    public class Rot13Kata
    {
        public static string Rot13(string message)
        {
            for (int x = 0; x < message.Length; x++)
            {
                char current = message[x];
                if ((current > 64 && current < 78) || current > 96 && current < 110)
                {
                    current = (char)(Convert.ToInt16(current) + 13);
                }
                else if ((current > 77 && current < 91) || current > 109 && current < 123)
                {
                    current = (char)(Convert.ToInt16(current) - 13);
                }
                message = message.Remove(x, 1).Insert(x, current.ToString());
            }
            return message;
        }
    }
}
