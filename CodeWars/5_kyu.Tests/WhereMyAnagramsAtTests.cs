using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5_kyu.Tests
{
    public class WhereMyAnagramsAtTests
    {
        [Fact]
        public void Example1()
        {
            List<string> expected = new List<string>() { "aabb", "bbaa" };
            List<string> actual =
                WhereMyAnagramsAt.Anagrams("abba", new List<string>() {"aabb", "abcd", "bbaa", "dada"});
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Example2()
        {
            List<string> expected = new List<string>() { "carer", "racer" };
            List<string> actual =
                WhereMyAnagramsAt.Anagrams("racer", new List<string>() { "crazer", "carer", "racar", "caers", "racer" });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Example3()
        {
            List<string> expected = new List<string>() {};
            List<string> actual =
                WhereMyAnagramsAt.Anagrams("laser", new List<string>() { "lazing", "lazy", "lacer" });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test1()
        {
            List<string> expected = new List<string>(){"a"};
            List<string> actual = WhereMyAnagramsAt.Anagrams("a", new List<string>() { "a", "b", "c", "d" });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            List<string> expected = new List<string>() { "carer", "arcre", "carre" };
            List<string> actual = WhereMyAnagramsAt.Anagrams("racer", new List<string>() { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" });
            Assert.Equal(expected, actual);
        }

    }
}
