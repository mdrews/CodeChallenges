using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5_kyu.Tests
{
    public class JosephusSurvivorTests
    {
        [Fact]
        public void myTest1()
        {
            int expected = 905;
            int actual = JosephusSurvivor.JoeSurvivor(2500, 2);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void myTest2()
        {
            int expected = 6405;
            int actual = JosephusSurvivor.JoeSurvivor(6500, 6000);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test1()
        {
            int expected = 4;
            int actual = JosephusSurvivor.JoeSurvivor(7, 3);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test2()
        {
            int expected = 10;
            int actual = JosephusSurvivor.JoeSurvivor(11, 19);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test3()
        {
            int expected = 28;
            int actual = JosephusSurvivor.JoeSurvivor(40, 3);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test4()
        {
            int expected = 13;
            int actual = JosephusSurvivor.JoeSurvivor(14, 2);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test5()
        {
            int expected = 100;
            int actual = JosephusSurvivor.JoeSurvivor(100, 1);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test6()
        {
            int expected = 1;
            int actual = JosephusSurvivor.JoeSurvivor(1, 300);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test7()
        {
            int expected = 1;
            int actual = JosephusSurvivor.JoeSurvivor(2, 300);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test8()
        {
            int expected = 1;
            int actual = JosephusSurvivor.JoeSurvivor(5, 300);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test9()
        {
            int expected = 7;
            int actual = JosephusSurvivor.JoeSurvivor(7, 300);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Test10()
        {
            int expected = 265;
            int actual = JosephusSurvivor.JoeSurvivor(300, 300);
            Assert.Equal(actual, expected);
        }
    }
}
