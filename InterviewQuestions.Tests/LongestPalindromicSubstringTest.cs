using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class LongestPalindromicSubstringTest
    {
        [Fact]
        public void Test1()
        {
            string s = "babad";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("bab", result);
        }

        [Fact]
        public void Test2()
        {
            string s = "sdfracecarsffdg";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("racecar", result);
        }

        [Fact]
        public void Test3()
        {
            string s = "cbbd";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("bb", result);
        }

        [Fact]
        public void Test4()
        {
            string s = "a";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("a", result);
        }

        [Fact]
        public void Test5()
        {
            string s = "ac";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("a", result);
        }

        [Fact]
        public void Test6()
        {
            string s = "dabbat";
            LongestPalindromicSubstring solution = new LongestPalindromicSubstring();
            string result = solution.LongestPalindrome(s);

            Assert.Equal("abba", result);
        }
    }
}
