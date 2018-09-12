using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kyu_4.Tests
{
    public class HammingNumbersTest
    {
        [Fact]
        public void Test1()
        {
            long expected = 1;
            long actual = HammingNumbers.Hamming(1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            long expected = 2;
            long actual = HammingNumbers.Hamming(2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            long expected = 3;
            long actual = HammingNumbers.Hamming(3);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Tes4()
        {
            long expected = 4;
            long actual = HammingNumbers.Hamming(4);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            long expected = 5;
            long actual = HammingNumbers.Hamming(5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test6()
        {
            long expected = 6;
            long actual = HammingNumbers.Hamming(6);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test7()
        {
            long expected = 8;
            long actual = HammingNumbers.Hamming(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test9()
        {
            long expected = 10;
            long actual = HammingNumbers.Hamming(9);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test10()
        {
            long expected = 12;
            long actual = HammingNumbers.Hamming(10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test11()
        {
            long expected = 15;
            long actual = HammingNumbers.Hamming(11);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test12()
        {
            long expected = 16;
            long actual = HammingNumbers.Hamming(12);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test13()
        {
            long expected = 18;
            long actual = HammingNumbers.Hamming(13);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test14()
        {
            long expected = 20;
            long actual = HammingNumbers.Hamming(14);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test15()
        {
            long expected = 24;
            long actual = HammingNumbers.Hamming(15);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test16()
        {
            long expected = 25;
            long actual = HammingNumbers.Hamming(16);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test17()
        {
            long expected = 27;
            long actual = HammingNumbers.Hamming(17);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test18()
        {
            long expected = 30;
            long actual = HammingNumbers.Hamming(18);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test19()
        {
            long expected = 32;
            long actual = HammingNumbers.Hamming(19);
            Assert.Equal(expected, actual);
        }
    }
}
