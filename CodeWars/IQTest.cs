using System;
using System.Linq;
using Xunit;

namespace CodeWars
{
    /// <summary>
    /// https://www.codewars.com/kata/iq-test/csharp
    /// </summary>
    public class IQTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Kata.Test("2 4 7 8 10"));
            Assert.Equal(1, Kata.Test("1 2 2"));
        }

        internal class Kata
        {
            public static int Test(string numbers)
            {
                var numList = numbers.Split(' ').Select(n => Convert.ToInt32(Convert.ToInt32(n)) % 2).ToList();
                return numList.FindIndex(n => numList.Count(x => x == n) == 1) + 1;
            }

            public static int Test2(string numbers)
            {
                return numbers
                    .Split(' ')
                    .Select((n, i) => new {index = i + 1, number = Convert.ToInt32(n) % 2})
                    .GroupBy(g => g.number)
                    .First(n => n.Count() == 1)
                    .Single().index;
            }
        }
    }
}
