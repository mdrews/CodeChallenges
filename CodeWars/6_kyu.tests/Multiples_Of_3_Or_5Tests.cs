using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace _6_kyu.tests
{

    public class Multiples_Of_3_Or_5Tests
    {
        [Fact]
        public void Test1()
        {
            int expected = 10;
            int actual = Multiples_Of_3_Or_5.Solution(23);
            Assert.Equal(expected, actual);
        }
    }
}
