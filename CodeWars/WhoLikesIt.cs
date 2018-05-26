using System.ComponentModel;
using System.Linq;
using System.Text;
using Xunit;

namespace CodeWars
{
    public class WhoLikesIt
    {
        [Fact, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.Equal("no one likes this", Kata.Likes(new string[0]));
            Assert.Equal("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.Equal("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.Equal("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.Equal("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        public static class Kata
        {
            public static string Likes(string[] names)
            {
                if (names == null || !names.Any())
                {
                    return "no one likes this";
                }

                var builder = new StringBuilder();
                var otherCount = 0;
                for (int i = 0; i <= names.Length - 1; i++)
                {
                    if (i > 1 && names.Length > 3)
                    {
                        otherCount++;
                    }
                    else
                    {
                        builder.Append(names[i] == names.First() ? names[i] : (names[i] == names.Last() ? $" and {names[i]}" : $", {names[i]}"));
                    }
                }

                if (otherCount > 0)
                {
                    builder.Append($" and {otherCount} others");
                }

                builder.Append(string.Format(" like{0} this", names.Length == 1 ? "s" : string.Empty));

                return builder.ToString();
            }
        }
    }
}
