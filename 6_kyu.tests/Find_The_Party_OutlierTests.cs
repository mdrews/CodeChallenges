using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _6_kyu.tests
{
    public class Find_The_Party_OutlierTests
    {
        [Fact]
        public void Example1()
        {
            int[] integers = new int[] {2, 4, 0, 100, 4, 11, 2602, 36};
            int expected = 11;
            int actual = Find_The_Party_Outlier.Find(integers);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Example2()
        {
            int[] integers = new int[] { 160, 3, 1719, 19, 11, 13, -21 };
            int expected = 160;
            int actual = Find_The_Party_Outlier.Find(integers);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test1()
        {
            int[] integers = new int[] { 2, 6, 8, -10, 3 };
            int expected = 3;
            int actual = Find_The_Party_Outlier.Find(integers);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            int[] integers = new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            int expected = 206847684;
            int actual = Find_The_Party_Outlier.Find(integers);
            Assert.Equal(expected, actual);
        }
    }
}
