using System;
using System.Linq;
using Xunit;

namespace CodeWars
{
    /// <summary>
    /// https://www.codewars.com/kata/520b9d2ad5c005041100000f
    /// </summary>
    public class SimplePigLatin
    {
        [Fact]
        public void KataTests()
        {
            Assert.Equal("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.Equal("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }

        internal class Kata
        {
            public static string PigIt(string str)
            {
                return String.Join(' ',
                    str.Split(' ').Select(w =>
                        Char.IsLetter(w.Last())
                            ? $"{w.Substring(1)}{w[0]}ay"
                            : $"{w.Substring(1, w.Length - 2)}{w[0]}ay{w.Last()}"));
            }
        }
    }
}
