using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyu_6
{
    public class Create_Phone_Number
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string result =
                $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
            return result;
        }
    }
}
