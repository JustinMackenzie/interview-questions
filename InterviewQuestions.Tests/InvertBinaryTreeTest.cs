using InterviewQuestions.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InterviewQuestions.Tests
{
    public class InvertBinaryTreeTest
    {
        [Fact]
        public void Test1()
        {
            BinaryTreeNode root = new BinaryTreeNode
            {
                Value = 1,
                Left = new BinaryTreeNode
                {
                    Value = 2,
                    Left = new BinaryTreeNode
                    {
                        Value = 4
                    },
                    Right = new BinaryTreeNode
                    {
                        Value = 5
                    }
                },
                Right = new BinaryTreeNode
                {
                    Value = 3,
                    Left = new BinaryTreeNode
                    {
                        Value = 6
                    },
                    Right = new BinaryTreeNode
                    {
                        Value = 7
                    }
                }
            };

            InvertBinaryTreeSolution solution = new InvertBinaryTreeSolution();
            BinaryTreeNode result = solution.Inverse(root);

            Assert.Equal(1, result.Value);
            Assert.Equal(3, result.Left.Value);
            Assert.Equal(2, result.Right.Value);
        }
    }
}
