using System;
using System.ComponentModel;
using System.Linq;
using Xunit;

namespace CodeWars
{
    public class StringOrder
    {
        [Fact, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.Equal("Thi1s is2 3a T4est", Kata.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("For the2 g3ood 4of th5e pe6ople", Kata.Order("4of For pe6ople g3ood th5e the2"));
            Assert.Equal("", Kata.Order(""));
        }

        public class Kata
        {
            public static string Order(string words)
            {
                return String.Join(' ', words.Split(' ').OrderBy(FindInt));
            }

            private static char FindInt(string word)
            {
                return word.FirstOrDefault(char.IsDigit);
            }
        }
    }
}