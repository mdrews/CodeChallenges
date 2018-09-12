using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5_kyu.Tests
{
    public class CountCharactersInYourStringTests
    {
        [Fact]
        public void myTest1()
        {
            Dictionary<char, int> expected = new Dictionary<char, int>();
            expected.Add('e', 1);
            expected.Add('s', 1);
            expected.Add('t', 2);
            Dictionary<char, int> actual = CountCharactersInYourString.Count("test");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test1()
        {
            Dictionary<char, int> expected = new Dictionary<char, int>();
            expected.Add('a', 2);
            expected.Add('b', 2);
            Dictionary<char, int> actual = CountCharactersInYourString.Count("aabb");
            Assert.Equal(expected, actual);
        }

    }
}
