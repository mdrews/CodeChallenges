using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kyu_6.Tests
{
    public class Create_Phone_NumberTests
    {
        [Fact]
        public void Test1()
        {
            string expected = "(123) 456-7890";
            string actual = Create_Phone_Number.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0});
            Assert.Equal(expected, actual);
        }
    }
}
