using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class ReverseLinkedListTest
    {
        [Fact]
        public void Test1()
        {
            Node head = new Node(1, new Node(2, new Node(3, null)));
            ReverseLinkedListSolution solution = new ReverseLinkedListSolution();
            Node result = solution.Reverse(head);

            Assert.Equal(3, result.Value);
            Assert.Equal(2, result.Next.Value);
            Assert.Equal(1, result.Next.Next.Value);
        }
    }
}
