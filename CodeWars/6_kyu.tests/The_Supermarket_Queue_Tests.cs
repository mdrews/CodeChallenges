using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using _6_kyu;

namespace _6_kyu.tests
{
    public class The_Supermarket_Queue_Tests
    {
        [Fact]
        public void Example1()
        {
            long expected = 12;
            long actual = The_Supermarket_Queue.QueueTime(new int[] {5, 3, 4}, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Example2()
        {
            long expected = 10;
            long actual = The_Supermarket_Queue.QueueTime(new int[] {10, 2, 3, 3}, 2);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Example3()
        {
            long expected = 12;
            long actual = The_Supermarket_Queue.QueueTime(new int[] {2, 3, 10}, 2);
        }
        [Fact]
        public void Test1()
        {
            long expected = 0;
            long actual = The_Supermarket_Queue.QueueTime(new int[]{}, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            long expected = 10;
            long actual = The_Supermarket_Queue.QueueTime(new int[] {1, 2, 3, 4}, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            long expected = 9;

            long actual = The_Supermarket_Queue.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            long expected = 5;

            long actual = The_Supermarket_Queue.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.Equal(expected, actual);
        }
    }
}
