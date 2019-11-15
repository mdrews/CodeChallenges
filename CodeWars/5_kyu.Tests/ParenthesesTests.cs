using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5_kyu.Tests
{
    public class ParenthesesTests
    {
        [Fact]
        public void Example1()
        {
            bool expected = true;
            bool actual = Parentheses.ValidParentheses("()");
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Example2()
        {
            bool expected = false;
            bool actual = Parentheses.ValidParentheses(")(()))");
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Example3()
        {
            bool expected = false;
            bool actual = Parentheses.ValidParentheses("(");
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Example4()
        {
            bool expected = true;
            bool actual = Parentheses.ValidParentheses("(())((()())())");
            Assert.Equal(actual, expected);
        }
    }
}
