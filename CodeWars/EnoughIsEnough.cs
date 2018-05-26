using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CodeWars
{
    /// <summary>
    /// http://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
    /// </summary>
    public class EnoughIsEnough
    {
        [Fact]
        public void TestSimple()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = Kata.DeleteNth2(new int[] { 20, 37, 20, 21 }, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSimple2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = Kata.DeleteNth2(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            Assert.Equal(expected, actual);
        }

        internal class Kata
        {
            public static int[] DeleteNth(int[] arr, int x)
            {
                var l = new List<int>();
                arr.ToList().ForEach(a => { if(l.Count(e => e == a) < x) l.Add(a); });

                return l.ToArray();
            }

            public static int[] DeleteNth2(int[] arr, int x)
            {
                return arr.Where((a, i) => arr.Take(i + 1).Count(e => e == a) <= x).ToArray();
            }
        }
    }
}
