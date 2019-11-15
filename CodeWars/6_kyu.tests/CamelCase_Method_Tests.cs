using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _6_kyu.tests
{
    public class CamelCase_Method_Tests
    {
        [Fact]
        public void Example1()
        {
            string expected = "HelloCase";
            string actual = CamelCase_Method.CamelCase("hello case");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Example2()
        {
            string expected = "CamelCaseWord";
            string actual = CamelCase_Method.CamelCase("camel case word");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test1()
        {
            string expected = "TestCase";
            string actual = CamelCase_Method.CamelCase("test case");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            string expected = "CamelCaseMethod";
            string actual = CamelCase_Method.CamelCase("camel case method");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            string expected = "SayHello";
            string actual = CamelCase_Method.CamelCase("say hello");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test4()
        {
            string expected = "CamelCaseWord";
            string actual = CamelCase_Method.CamelCase(" camel case word");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            string expected = "";
            string actual = CamelCase_Method.CamelCase("");
            Assert.Equal(expected, actual);
        }

    }
}
