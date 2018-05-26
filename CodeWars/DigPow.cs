using System;
using System.Linq;
using Xunit;

namespace CodeWars
{
    public class DigPow
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, Kata.DigPow(89, 1));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(-1, Kata.DigPow(92, 1));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(51, Kata.DigPow(46288, 3));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(-1, Kata.DigPow(3456789, 5));
        }

        public class Kata
        {
            public static long DigPow(int n, int p)
            {
                double sum = 0;
                n.ToString().Select(c => int.Parse(c.ToString())).ToList().ForEach(number =>
                    {
                        sum += Math.Pow(number, p++);
                    });

                double k = sum / n;

                return Math.Abs(Math.Floor(k) - k) <= 0 && Math.Abs(k * n - sum) <= 0 ? Convert.ToInt64(k) : -1;
            }
        }
    }
}
