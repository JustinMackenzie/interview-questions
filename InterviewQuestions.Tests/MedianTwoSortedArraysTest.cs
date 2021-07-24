using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class MedianTwoSortedArraysTest
    {
        [Fact]
        public void Test1()
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 4, 5, 6 };

            var solution = new MedianTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(a, b);

            Assert.Equal(3.5, result);
        }

        [Fact]
        public void Test2()
        {
            int[] a = new int[] { 1, 3, 8, 9, 15 };
            int[] b = new int[] { 7, 11, 18, 19, 21, 25 };

            var solution = new MedianTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(a, b);

            Assert.Equal(11, result);
        }

        [Fact]
        public void Test3()
        {
            int[] a = new int[] { 23, 26, 31, 35 };
            int[] b = new int[] { 3, 5, 7, 9, 11, 16 };

            var solution = new MedianTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(a, b);

            Assert.Equal(13.5, result);
        }

        [Fact]
        public void Test4()
        {
            int[] a = new int[] { };
            int[] b = new int[] { 1 };

            var solution = new MedianTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(a, b);

            Assert.Equal(1, result);
        }
    }
}
