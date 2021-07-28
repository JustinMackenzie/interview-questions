using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class ReverseIntegerTest
    {
        [Fact]
        public void Test1()
        {
            int x = 342;
            ReverseIntegerSolution solution = new ReverseIntegerSolution();
            int result = solution.Reverse(x);

            Assert.Equal(243, result);
        }

        [Fact]
        public void Test2()
        {
            int x = -123;
            ReverseIntegerSolution solution = new ReverseIntegerSolution();
            int result = solution.Reverse(x);

            Assert.Equal(-321, result);
        }

    }
}
