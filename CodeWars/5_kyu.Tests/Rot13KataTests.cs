using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5_kyu.Tests
{ 
    public class Rot13KataTests
    {
        [Fact]
        public void Test1()
        {
            string expected = "grfg";
            string actual = Rot13Kata.Rot13("test");
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Test2()
        {
            string expected = "Grfg";
            string actual = Rot13Kata.Rot13("Test");
            Assert.Equal(expected, actual);
        }
    }
}
