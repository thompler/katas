using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CodeWars
{
    public class ValidBraces
    {
        [Fact]
        public void ValidBracesTest()
        {
            Assert.True(Kata.ValidateBraces("(){}[]"));
            Assert.True(Kata.ValidateBraces("([{}])"));
            Assert.False(Kata.ValidateBraces("(}"));
            Assert.False(Kata.ValidateBraces("[(])"));
            Assert.False(Kata.ValidateBraces("[({})](]"));
        }

        public class Kata
        {
            public static bool ValidateBraces(string braces)
            {
                var braceDict = new Dictionary<char, char> { { '(', ')' }, { '[', ']' }, { '{', '}' } };

                if (string.IsNullOrWhiteSpace(braces))
                {
                    return false;
                }

                var braceStack = new Stack<char>();

                foreach (var brace in braces)
                {
                    if (braceDict.ContainsKey(brace))
                    {
                        braceStack.Push(brace);
                    }
                    else
                    {
                        if (!braceStack.Any() || braceDict[braceStack.Pop()] != brace)
                        {
                            return false;
                        }
                    }
                }

                return !braceStack.Any();
            }
        }
    }
}
