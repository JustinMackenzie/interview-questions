using InterviewQuestions.Solutions;
using System;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Test1()
        {
            ListNode node1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode node2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            AddTwoNumbers solution = new AddTwoNumbersInitialSolution();
            var result = solution.AddTwoNumbers(node1, node2);

            Assert.Equal(7, result.val);
            Assert.Equal(0, result.next.val);
            Assert.Equal(8, result.next.next.val);
        }
    }
}
