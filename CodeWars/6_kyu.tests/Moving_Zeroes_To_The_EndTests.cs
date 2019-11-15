using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _6_kyu.tests
{
    public class Moving_Zeroes_To_The_EndTests
    {
        [Fact]
        public void Example1()
        {
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
            int[] actual = Moving_Zeroes_To_The_End.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
            Assert.Equal(expected, actual);
        }
    }
}
