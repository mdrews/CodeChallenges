using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kyu_6.Tests
{
    public class Triple_TroubleTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int actual = Triple_Trouble.TripleDouble(451999277, 41177722899);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            int expected = 0;
            int actual = Triple_Trouble.TripleDouble(1222345, 12345);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            int expected = 0;
            int actual = Triple_Trouble.TripleDouble(12345, 12345);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test4()
        {
            int expected = 1;
            int actual = Triple_Trouble.TripleDouble(666789, 12345667);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            int expected = 1;
            int actual = Triple_Trouble.TripleDouble(10560002, 100);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test6()
        {
            int expected = 0;
            int actual = Triple_Trouble.TripleDouble(594421776, 534215177);
            Assert.Equal(expected,actual);
        }
    }
}
