using System;
using System.Collections.Generic;
using Xunit;

namespace CodeWars
{
    public class RectangleToSquare
    {
        [Fact]
        public void Test1()
        {
            int[] r = new int[] { 3, 2, 1, 1 };
            Assert.Equal(r, Kata.sqInRect(5, 3));
        }
        [Fact]
        public void Test2()
        {
            int[] r = new int[] { 3, 2, 1, 1 };
            Assert.Equal(r, Kata.sqInRect(3, 5));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(null, Kata.sqInRect(5, 5));
        }
        [Fact]
        public void Test4()
        {
            int[] r = new int[] { 14, 6, 6, 2, 2, 2 };
            Assert.Equal(r, Kata.sqInRect(20, 14));
        }
        [Fact]
        public void Test5()
        {
            int[] r = new int[] { 14, 6, 6, 2, 2, 2 };
            Assert.Equal(r, Kata.sqInRect(14, 20));
        }
        [Fact]
        public void Test6()
        {
            int[] r = new int[] { 32, 32, 32, 32, 32, 32, 32, 16, 16 };
            Assert.Equal(r, Kata.sqInRect(240, 32));
        }
        [Fact]
        public void Test7()
        {
            int[] r = new int[] { 230, 230, 165, 65, 65, 35, 30, 5, 5, 5, 5, 5, 5 };
            Assert.Equal(r, Kata.sqInRect(625, 230));
        }
        [Fact]
        public void Test8()
        {
            int[] r = new int[] { 230, 230, 230, 41, 41, 41, 41, 41, 25, 16, 9, 7, 2, 2, 2, 1, 1 };
            Assert.Equal(r, Kata.sqInRect(731, 230));
        }
        [Fact]
        public void Test9()
        {
            int[] r = new int[] { 14, 14, 9, 5, 4, 1, 1, 1, 1 };
            Assert.Equal(r, Kata.sqInRect(37, 14));
        }
        [Fact]
        public void Test10()
        {
            int[] r = new int[] { 1, 1 };
            Assert.Equal(r, Kata.sqInRect(2, 1));
        }

        internal class Kata
        {
            public static List<int> sqInRect(int lng, int wdth)
            {
                if (lng == wdth) return null;
                var squares = new List<int>();

                var min = Math.Min(lng, wdth);
                var max = Math.Max(lng, wdth);

                squares.Add(min);
                squares.AddRange(sqInRect(min, max - min) ?? new List<int> { min });

                return squares;
            }
        }
    }
}

