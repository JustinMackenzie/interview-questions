using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Fact]
        public void Test1()
        {
            var input = "abcabcbb";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            var input = "bbbbb";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            var input = "pwwkew";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test4()
        {
            var input = "";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            var input = "au";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test6()
        {
            var input = "dvdf";
            var solution = new LongestSubstringWithoutRepeatingCharactersInitialSolution();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(3, result);
        }
    }
}
